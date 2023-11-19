Public Class FrmColor
    Dim colores As New ClaseColor
    Private Sub FrmColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los colores, la clase color (ClaseColor) tiene un método llamado PoblarDGVColores
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        colores.PoblarDataGridColor(DGVColores)

        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'Si el campo ID EMPLEADO no tiene ningun dato, muestra el ID siguiente permitido
        If TxtIdColor.Text = "" Then
            colores.mostrarIdMax()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVColores.CellContentClick
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVColores.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TxtIdColor.Text = DGVColores.Rows(renglon).Cells(0).Value
        TxtColor.Text = DGVColores.Rows(renglon).Cells(1).Value

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtColor.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        colores.mostrarIdMax()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TxtIdColor.Text = "" And TxtColor.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TxtIdColor.Text = "" Then
                MessageBox.Show("EL CAMPO ID COLOR ESTÁ VACÍO!")
            ElseIf TxtColor.Text = "" Then
                MessageBox.Show("EL CAMPO COLOR ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim colores As New ClaseColor(TxtIdColor.Text, TxtColor.Text)

                'En el siguiente IF, usamos un método para verificar si el color está registrado
                If colores.consultaUnIdColor() = False Then
                    'Si el color NO está registrado, lo inserta como uno nuevo
                    colores.insertaColor()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("COLOR '" & TxtColor.Text & "' REGISTRADO CORRECTAMENTE!")
                Else
                    'Si el color se encuentra registrado, se modifica la información
                    colores.actualizaColor()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("COLOR MODIFICADO CORRECTAMENTE!")
                End If

                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                colores.PoblarDataGridColor(DGVColores)
                'Limpiamos las cajas de texto y mostramos el ID proximo
                Call BtnLimpiar_Click(sender, e)
                'Si se encuentra abierto el formulario de Vehiculo, se actualiza el combo
                'color con los nuevos cambios
                FrmVehiculo.vehiculo.poblarComboColor()

            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Validamos que este color no tenga carros dadas de alta, es decir que no tenga hijos.
            'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
            'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
            If TxtIdColor.Text = "" And TxtColor.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TxtIdColor.Text = "" Then
                MessageBox.Show("EL CAMPO ID COLOR ESTÁ VACÍO!")
            ElseIf TxtColor.Text = "" Then
                MessageBox.Show("EL CAMPO COLOR ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim colores As New ClaseColor(TxtIdColor.Text, TxtColor.Text)

                'Consulta de que exista el color
                If colores.consultaUnIdColor() = False Then
                    MsgBox("NO EXISTE EL ID DEL COLOR!")
                Else
                    'Consulta que ningún vehículo dependa del color
                    If colores.validaColores() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR EL COLOR '" & TxtColor.Text & "' PORQUE TIENE UNO O MÁS VEHÍCULOS QUE DEPENDEN DE ÉSTE MISMO!")
                    Else
                        'Sí ningún vehículo depende del color se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL COLOR '" & TxtColor.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro del color
                            colores.eliminarColor()
                            MessageBox.Show("COLOR ELIMINADO CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            colores.PoblarDataGridColor(DGVColores)
                            'Después de eliminar mostramos el ID proximo
                            colores.mostrarIdMax()
                            'Si se encuentra abierto el formulario de Vehiculo, se actualiza el combo
                            'color con los nuevos cambios
                            FrmVehiculo.vehiculo.poblarComboColor()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click_1(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class