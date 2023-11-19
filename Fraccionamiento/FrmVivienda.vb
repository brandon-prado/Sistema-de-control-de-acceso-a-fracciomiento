Public Class FrmVivienda
    Dim vivienda As New ClaseVivienda
    Private Sub FrmVivienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de las viviendas, la clase vivienda (ClaseVivienda) tiene un método llamado PoblarDGVViviendas
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        vivienda.PoblarDataGridVivienda(DGVVivienda)

        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'Si el campo ID VIVIENDA no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdVivienda.Text = "" Then
            vivienda.mostrarIdMax()
        End If
    End Sub

    Private Sub DGVVivienda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVivienda.CellContentClick
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVVivienda.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVVivienda.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TbIdVivienda.Text = DGVVivienda.Rows(renglon).Cells(0).Value
        TbDireccionV.Text = DGVVivienda.Rows(renglon).Cells(1).Value
        TbNoVivienda.Text = DGVVivienda.Rows(renglon).Cells(2).Value
        TbCodPostViv.Text = DGVVivienda.Rows(renglon).Cells(3).Value
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TbDireccionV.Text = ""
        TbNoVivienda.Text = ""
        TbCodPostViv.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        vivienda.mostrarIdMax()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdVivienda.Text = "" And TbDireccionV.Text = "" And TbNoVivienda.Text = "" And TbCodPostViv.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdVivienda.Text = "" Then
                MessageBox.Show("EL CAMPO ID VIVIENDA ESTÁ VACÍO!")
            ElseIf TbDireccionV.Text = "" Then
                MessageBox.Show("EL CAMPO DIRECCIÓN ESTÁ VACÍO!")
            ElseIf TbNoVivienda.Text = "" Then
                MessageBox.Show("EL CAMPO NÚM. VIVIENDA ESTÁ VACÍO!")
            ElseIf TbCodPostViv.Text = "" Then
                MessageBox.Show("EL CAMPO CÓD. POSTAL ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim vivienda As New ClaseVivienda(TbIdVivienda.Text, TbDireccionV.Text, TbNoVivienda.Text, TbCodPostViv.Text)

                'En el siguiente IF, usamos un método para verificar si la vivienda está registrada
                If vivienda.consultaUnIdVivienda() = False Then
                    'Si la vivienda NO está registrada, lo inserta como uno nueva
                    vivienda.insertaVivienda()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("VIVIENDA REGISTRADA CORRECTAMENTE!")
                Else
                    'Si la vivienda se encuentra registrada, se modifica la información
                    vivienda.actualizaVivienda()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("VIVIENDA MODIFICADA CORRECTAMENTE!")
                End If

                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                vivienda.PoblarDataGridVivienda(DGVVivienda)
                'Limpiamos las cajas de texto y mostramos el ID proximo
                Call BtnLimpiar_Click(sender, e)
                'Si se encuentra abierto el formulario de Habitante, se actualiza el combo
                'NUMERO DE VIVIENDA con los nuevos cambios
                FrmHabitante.habitante.poblarComboIdVivienda()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Validamos que estA VIVIENDA no tenga habitantes dados de alta, es decir que no tenga hijos.
            'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
            'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
            If TbIdVivienda.Text = "" And TbDireccionV.Text = "" And TbNoVivienda.Text = "" And TbCodPostViv.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdVivienda.Text = "" Then
                MessageBox.Show("EL CAMPO ID VIVIENDA ESTÁ VACÍO!")
            ElseIf TbDireccionV.Text = "" Then
                MessageBox.Show("EL CAMPO DIRECCIÓN ESTÁ VACÍO!")
            ElseIf TbNoVivienda.Text = "" Then
                MessageBox.Show("EL CAMPO NÚM. VIVIENDA ESTÁ VACÍO!")
            ElseIf TbCodPostViv.Text = "" Then
                MessageBox.Show("EL CAMPO CÓD. POSTAL ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim vivienda As New ClaseVivienda(TbIdVivienda.Text, TbDireccionV.Text, TbNoVivienda.Text, TbCodPostViv.Text)
                'Consulta de que exista la vivienda
                If vivienda.consultaUnIdVivienda() = False Then
                    MsgBox("NO EXISTE EL ID DE LA VIVIENDA!")
                Else
                    'Consulta que ningún habitante dependa de la vivienda
                    If vivienda.validaVivienda() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR LA VIVIENDA PORQUE TIENE UNO O MÁS HABITANTES QUE DEPENDEN DE ÉSTA MISMA!")
                    Else
                        'Sí ningún habitante depende de la vivienda se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR LA VIVIENDA?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro de la vivienda
                            vivienda.eliminarVivienda()
                            MessageBox.Show("VIVIENDA ELIMINADA CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            vivienda.PoblarDataGridVivienda(DGVVivienda)
                            'Después de eliminar mostramos el ID proximo
                            vivienda.mostrarIdMax()
                            'Si se encuentra abierto el formulario de Habitante, se actualiza el combo
                            'NUMERO DE VIVIENDA con los nuevos cambios
                            FrmHabitante.habitante.poblarComboIdVivienda()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class