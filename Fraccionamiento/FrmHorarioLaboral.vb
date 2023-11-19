Public Class FrmHorarioLaboral
    Dim horario As New ClaseHorarioLab
    Private Sub FrmHorarioLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los horarios, la clase Horario Laboral (ClaseHorarioLab) tiene un método llamado PoblarDGVHorarioL
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        horario.PoblarDataGridHorarioL(DGVHorario)
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'Si el campo ID HORARIO no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdHorarioLab.Text = "" Then
            horario.mostrarIdMax()
        End If
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        CbHoraInicio.Text = "Selecciona entrada"
        CbHoraFin.Text = "Selecciona salida"
        Me.CbTurnoMat.Checked = False
        Me.CbTurnoVesp.Checked = False
        Me.CbTurnoNoct.Checked = False
        'Después de limpiar mostrar el siguiente ID permitido
        horario.mostrarIdMax()
    End Sub

    Private Sub BtnSalir_Click_1(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdHorarioLab.Text = "" And Me.CbTurnoMat.Checked = False And Me.CbTurnoVesp.Checked = False And Me.CbTurnoNoct.Checked = False Then 'And CbHoraInicio.Text = "" And CbHoraFin.Text = "" 
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf Me.CbTurnoMat.Checked = False And Me.CbTurnoVesp.Checked = False And Me.CbTurnoNoct.Checked = False Then
                MessageBox.Show("SELECCIONE EL TURNO CORRESPONDIENTE!")
            ElseIf CbHoraInicio.Text = "Selecciona entrada" Or CbHoraInicio.Text = "" Then
                MessageBox.Show("SELECCIONE LA HORA DE INICIO!")
            ElseIf CbHoraFin.Text = "Selecciona salida" Or CbHoraFin.Text = "" Then
                MessageBox.Show("SELECCIONE LA HORA DE SALIDA!")
            Else
                Dim horario As New ClaseHorarioLab(TbIdHorarioLab.Text, Me.CbTurnoMat.Checked, Me.CbTurnoVesp.Checked, Me.CbTurnoNoct.Checked, CbHoraInicio.Text, CbHoraFin.Text)
                'En el siguiente IF, usamos un método para verificar si el horario está registrado
                If horario.consultaUnIdHorario() = False Then
                    'Si el horario NO está registrado, lo inserta como uno nuevo
                    horario.insertaHorario()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("HORARIO REGISTRADO CORRECTAMENTE!")
                Else
                    'Si el horario se encuentra registrado, se modifica la información
                    horario.actualizaHorario()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("HORARIO MODIFICADO CORRECTAMENTE!")
                End If

                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                horario.PoblarDataGridHorarioL(DGVHorario)
                'Limpiamos las cajas de texto y mostramos el ID proximo
                Call BtnLimpiar_Click(sender, e)
                'Si se encuentra abierto el formulario de Empleado, se actualiza el combo
                'horario con los nuevos cambios
                FrmEmpleado.empleado.poblarComboHoraEntrada()
                FrmEmpleado.empleado.poblarComboHoraSalida()

            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub DGVHorario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHorario.CellContentClick
        Try
            'Con éste código podemos seleccionar los datos que están mostrados
            'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

            Dim renglon As Integer

            renglon = DGVHorario.CurrentCellAddress.Y

            'Al darle clic al renglón mostramos los datos en las cajas de texto
            'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
            'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
            'dejamos en la caja de texto correspondiente

            TbIdHorarioLab.Text = DGVHorario.Rows(renglon).Cells(0).Value
            '''''''''
            If DGVHorario.Rows(renglon).Cells(1).Value = "S" And DGVHorario.Rows(renglon).Cells(2).Value = "S" And DGVHorario.Rows(renglon).Cells(3).Value = "S" Then
                Me.CbTurnoMat.Checked = True
                Me.CbTurnoVesp.Checked = True
                Me.CbTurnoNoct.Checked = True
            ElseIf DGVHorario.Rows(renglon).Cells(1).Value = "S" And DGVHorario.Rows(renglon).Cells(2).Value = "S" And DGVHorario.Rows(renglon).Cells(3).Value = "N" Then
                Me.CbTurnoMat.Checked = True
                Me.CbTurnoVesp.Checked = True
                Me.CbTurnoNoct.Checked = False
            ElseIf DGVHorario.Rows(renglon).Cells(1).Value = "S" And DGVHorario.Rows(renglon).Cells(2).Value = "N" And DGVHorario.Rows(renglon).Cells(3).Value = "S" Then
                Me.CbTurnoMat.Checked = True
                Me.CbTurnoVesp.Checked = False
                Me.CbTurnoNoct.Checked = True
            ElseIf DGVHorario.Rows(renglon).Cells(1).Value = "N" And DGVHorario.Rows(renglon).Cells(2).Value = "S" And DGVHorario.Rows(renglon).Cells(3).Value = "S" Then
                Me.CbTurnoMat.Checked = False
                Me.CbTurnoVesp.Checked = True
                Me.CbTurnoNoct.Checked = True
            ElseIf DGVHorario.Rows(renglon).Cells(1).Value = "S" Then
                Me.CbTurnoMat.Checked = True
                Me.CbTurnoVesp.Checked = False
                Me.CbTurnoNoct.Checked = False
            ElseIf DGVHorario.Rows(renglon).Cells(2).Value = "S" Then
                Me.CbTurnoMat.Checked = False
                Me.CbTurnoVesp.Checked = True
                Me.CbTurnoNoct.Checked = False
            ElseIf DGVHorario.Rows(renglon).Cells(3).Value = "S" Then
                Me.CbTurnoMat.Checked = False
                Me.CbTurnoVesp.Checked = False
                Me.CbTurnoNoct.Checked = True
            End If
            '''''''''''
            CbHoraInicio.Text = DGVHorario.Rows(renglon).Cells(4).Value
            CbHoraFin.Text = DGVHorario.Rows(renglon).Cells(5).Value
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try


    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Validamos que este horario no tenga empleados dadas de alta, es decir que no tenga hijos.
            'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
            'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
            If TbIdHorarioLab.Text = "" And Me.CbTurnoMat.Checked = False And Me.CbTurnoVesp.Checked = False And Me.CbTurnoNoct.Checked = False And CbHoraInicio.Text = "" And CbHoraFin.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf Me.CbTurnoMat.Checked = False And Me.CbTurnoVesp.Checked = False And Me.CbTurnoNoct.Checked = False Then
                MessageBox.Show("SELECCIONE EL TURNO CORRESPONDIENTE!")
            ElseIf CbHoraInicio.Text = "" Then
                MessageBox.Show("SELECCIONE LA HORA DE INICIO!")
            ElseIf CbHoraFin.Text = "" Then
                MessageBox.Show("SELECCIONE LA HORA DE SALIDA!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim horario As New ClaseHorarioLab(TbIdHorarioLab.Text, Me.CbTurnoMat.Checked, Me.CbTurnoVesp.Checked, Me.CbTurnoNoct.Checked, CbHoraInicio.Text, CbHoraFin.Text)

                'Consulta de que exista el horario
                If horario.consultaUnIdHorario() = False Then
                    MsgBox("NO EXISTE EL ID DEL HORARIO!")
                Else
                    'Consulta que ningún empleado dependa del horario
                    If horario.validaHorarioL() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR EL HORARIO PORQUE TIENE UNO O MÁS EMPLEADOS QUE DEPENDEN DE ÉSTE MISMO!")
                    Else
                        'Sí ningún empleado depende del horario se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL HORARIO?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro del horario
                            horario.eliminarHorarioL()
                            MessageBox.Show("HORARIO ELIMINADO CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            horario.PoblarDataGridHorarioL(DGVHorario)
                            'Después de eliminar mostramos el ID proximo
                            horario.mostrarIdMax()
                            'Si se encuentra abierto el formulario de Empleado, se actualiza el combo
                            'horario con los nuevos cambios
                            FrmEmpleado.empleado.poblarComboHoraEntrada()
                            FrmEmpleado.empleado.poblarComboHoraSalida()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub
End Class