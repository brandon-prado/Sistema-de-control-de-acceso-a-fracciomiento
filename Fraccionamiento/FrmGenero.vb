Public Class FrmGenero
    Dim genero As New ClaseGenero
    Private Sub FrmGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los colores, la clase género (ClaseGenero) tiene un método llamado PoblarDGVGeneros
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        genero.PoblarDataGridGenero(DGVGenero)

        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'Si el campo ID GÉNERO no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdGenero.Text = "" Then
            genero.mostrarIdMax()
        End If
    End Sub

    Private Sub DGVGenero_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGenero.CellContentClick
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVGenero.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TbIdGenero.Text = DGVGenero.Rows(renglon).Cells(0).Value
        TbGenero.Text = DGVGenero.Rows(renglon).Cells(1).Value
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TbGenero.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        genero.mostrarIdMax()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdGenero.Text = "" And TbGenero.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdGenero.Text = "" Then
                MessageBox.Show("EL CAMPO ID GÉNERO ESTÁ VACÍO!")
            ElseIf TbGenero.Text = "" Then
                MessageBox.Show("EL CAMPO GÉNERO ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim genero As New ClaseGenero(TbIdGenero.Text, TbGenero.Text)

                'En el siguiente IF, usamos un método para verificar si el género está registrado
                If genero.consultaUnIdGenero() = False Then
                    'Si el género NO está registrado, lo inserta como uno nuevo
                    genero.insertaGenero()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("GÉNERO '" & TbGenero.Text & "' REGISTRADO CORRECTAMENTE!")
                Else
                    'Si el género se encuentra registrado, se modifica la información
                    genero.actualizaGenero()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("GÉNERO MODIFICADO CORRECTAMENTE!")
                End If

                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                genero.PoblarDataGridGenero(DGVGenero)
                'Limpiamos las cajas de texto y mostramos el ID proximo
                Call BtnLimpiar_Click(sender, e)
                'Si se encuentra abierto el formulario de Empleado, se actualiza el combo
                'genero con los nuevos cambios
                FrmEmpleado.empleado.poblarComboGeneros()
                'Si se encuentra abierto el formulario de Habitante, se actualiza el combo
                'genero con los nuevos cambios
                FrmHabitante.habitante.poblarComboGeneros()
                'Si se encuentra abierto el formulario de Visitante, se actualiza el combo
                'genero con los nuevos cambios
                FrmVisitante.visitante.poblarComboGeneros()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Validamos que este GÉNERO no tenga empleados, habitantes y visitantes dados de alta, es decir que no tenga hijos.
            'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
            'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
            If TbIdGenero.Text = "" And TbGenero.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdGenero.Text = "" Then
                MessageBox.Show("EL CAMPO ID GÉNERO ESTÁ VACÍO!")
            ElseIf TbGenero.Text = "" Then
                MessageBox.Show("EL CAMPO GÉNERO ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim genero As New ClaseGenero(TbIdGenero.Text, TbGenero.Text)

                'Consulta de que exista el género
                If genero.consultaUnIdGenero() = False Then
                    MsgBox("NO EXISTE EL ID DEL GÉNERO!")
                Else
                    'Consulta que ningún EMPLEADO, HABITANTE y VISITANTE dependa del GÉNERO
                    If genero.validaGeneroEmpl() = True Or genero.validaGeneroHab() = True Or genero.validaGeneroVis() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR EL GÉNERO '" & TbGenero.Text & "' PORQUE TIENE UNO O MÁS PERSONAS QUE DEPENDEN DE ÉSTE MISMO!")
                    Else
                        'Sí ninguna persona depende del género se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL GÉNERO '" & TbGenero.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro del género
                            genero.eliminarGenero()
                            MessageBox.Show("GÉNERO ELIMINADO CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            genero.PoblarDataGridGenero(DGVGenero)
                            'Después de eliminar mostramos el ID proximo
                            genero.mostrarIdMax()
                            'Si se encuentra abierto el formulario de Empleado, se actualiza el combo
                            'genero con los nuevos cambios
                            FrmEmpleado.empleado.poblarComboGeneros()
                            'Si se encuentra abierto el formulario de Habitante, se actualiza el combo
                            'genero con los nuevos cambios
                            FrmHabitante.habitante.poblarComboGeneros()
                            'Si se encuentra abierto el formulario de Visitante, se actualiza el combo
                            'genero con los nuevos cambios
                            FrmVisitante.visitante.poblarComboGeneros()
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