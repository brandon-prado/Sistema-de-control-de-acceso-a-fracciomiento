Public Class FrmEmpleado
    Public empleado As New ClaseEmpleado
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los empleados, la clase empleado (ClaseEmpleado) tiene un método llamado PoblarDGVEmpleados
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        empleado.PoblarDataGridColor(DGVEmpleado)

        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'OCULTAR COLUMNA DEL DGV DE EMPLEADO QUE CONTIENE LA CONTRASEÑA
        DGVEmpleado.Columns(11).Visible = False

        'Poblar el comboBox de géneros
        empleado.poblarComboGeneros()

        'Poblar el comboBox de horario inicio
        empleado.poblarComboHoraEntrada()
        'Poblar el comboBox de horario fin
        empleado.poblarComboHoraSalida()

        'Poblar el comboBox de empresa
        empleado.poblarComboEmpresas()

        'Actualizamos Id's correspondientes
        actualizaIds()

        'Si el campo ID EMPLEADO no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdEmpleado.Text = "" Then
            empleado.mostrarIdMax()
        End If
    End Sub

    Private Sub DGVEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEmpleado.CellContentClick
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVEmpleado.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TbIdEmpleado.Text = DGVEmpleado.Rows(renglon).Cells(0).Value
        TbNombreEmpl.Text = DGVEmpleado.Rows(renglon).Cells(1).Value
        TbPaternoEmpl.Text = DGVEmpleado.Rows(renglon).Cells(2).Value
        TbMaternoEmpl.Text = DGVEmpleado.Rows(renglon).Cells(3).Value
        CbGeneroD.Text = DGVEmpleado.Rows(renglon).Cells(4).Value
        CbHoraInicioD.Text = DGVEmpleado.Rows(renglon).Cells(5).Value
        CbHoraFinD.Text = DGVEmpleado.Rows(renglon).Cells(6).Value
        TbTelefono.Text = DGVEmpleado.Rows(renglon).Cells(7).Value
        CbEmpresaD.Text = DGVEmpleado.Rows(renglon).Cells(8).Value
        TbIne.Text = DGVEmpleado.Rows(renglon).Cells(9).Value
        TbSueldo.Text = DGVEmpleado.Rows(renglon).Cells(10).Value

        TbContrasena.Text = DGVEmpleado.Rows(renglon).Cells(11).Value
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TbNombreEmpl.Text = ""
        TbPaternoEmpl.Text = ""
        TbMaternoEmpl.Text = ""
        TbTelefono.Text = ""
        TbIne.Text = ""
        TbSueldo.Text = ""
        TbContrasena.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        empleado.mostrarIdMax()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdEmpleado.Text = "" And LbIdGenero.Text = "0" And LbIdHorario.Text = "0" And LbIdEmpresa.Text = "0" And TbNombreEmpl.Text = "" And TbPaternoEmpl.Text = "" And TbMaternoEmpl.Text = "" And TbTelefono.Text = "" And TbIne.Text = "" And TbSueldo.Text = "" And TbContrasena.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdEmpleado.Text = "" Then
                MessageBox.Show("EL CAMPO ID EMPLEADO ESTÁ VACÍO!")
            ElseIf LbIdGenero.Text = "" Then
                MessageBox.Show("EL CAMPO ID GÉNERO ESTÁ VACÍO!")
            ElseIf LbIdHorario.Text = "" Then
                MessageBox.Show("EL CAMPO ID HORARIO ESTÁ VACÍO!")
            ElseIf LbIdEmpresa.Text = "" Then
                MessageBox.Show("EL CAMPO ID EMPRESA ESTÁ VACÍO!")
            ElseIf TbNombreEmpl.Text = "" Then
                MessageBox.Show("EL CAMPO NOMBRE EMPLEADO ESTÁ VACÍO!")
            ElseIf TbPaternoEmpl.Text = "" Then
                MessageBox.Show("EL CAMPO APELLIDO PATERNO ESTÁ VACÍO!")
            ElseIf TbMaternoEmpl.Text = "" Then
                MessageBox.Show("EL CAMPO APELLIDO MATERNO ESTÁ VACÍO!")
            ElseIf TbTelefono.Text = "" Then
                MessageBox.Show("EL CAMPO TELÉFONO ESTÁ VACÍO!")
            ElseIf TbIne.Text = "" Then
                MessageBox.Show("EL CAMPO INE EMPLEADO ESTÁ VACÍO!")
            ElseIf TbSueldo.Text = "" Then
                MessageBox.Show("EL CAMPO SUELDO ESTÁ VACÍO!")
            ElseIf TbContrasena.Text = "" Then
                MessageBox.Show("EL CAMPO CONTRASEÑA ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim empleado As New ClaseEmpleado(TbIdEmpleado.Text, LbIdGenero.Text, LbIdHorario.Text, LbIdEmpresa.Text, TbNombreEmpl.Text, TbPaternoEmpl.Text, TbMaternoEmpl.Text, TbTelefono.Text, TbIne.Text, TbSueldo.Text, TbContrasena.Text)

                'En el siguiente IF, usamos un método para verificar si el empleado está registrado
                If empleado.consultaUnIdEmpleado() = False Then
                    'Si el empleado NO está registrado, lo inserta como uno nuevo
                    empleado.insertaEmpleado()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("EMPLEADO '" & TbNombreEmpl.Text & "' REGISTRADO CORRECTAMENTE!")
                Else
                    'Si el empleado se encuentra registrado, se modifica la información
                    empleado.actualizaEmpleado()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("EMPLEADO MODIFICADO CORRECTAMENTE!")
                End If

                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                empleado.PoblarDataGridColor(DGVEmpleado)
                'Limpiamos las cajas de texto y mostramos el ID EMPLEADO proximo
                Call BtnLimpiar_Click(sender, e)
                'Si se encuentra abierto el formulario de CASETA, se actualiza el combo
                'empleado con los nuevos cambios
                FrmCaseta.caseta.poblarComboEmpleado()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Validamos que este empleado no tenga casetas dadas de alta, es decir que no tenga hijos.
            'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
            'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
            If TbIdEmpleado.Text = "" And LbIdGenero.Text = "" And LbIdHorario.Text = "" And LbIdEmpresa.Text = "" And TbNombreEmpl.Text = "" And TbPaternoEmpl.Text = "" And TbMaternoEmpl.Text = "" And TbTelefono.Text = "" And TbIne.Text = "" And TbSueldo.Text = "" And TbContrasena.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdEmpleado.Text = "" Then
                MessageBox.Show("EL CAMPO ID EMPLEADO ESTÁ VACÍO!")
            ElseIf LbIdGenero.Text = "" Then
                MessageBox.Show("EL CAMPO ID GÉNERO ESTÁ VACÍO!")
            ElseIf LbIdHorario.Text = "" Then
                MessageBox.Show("EL CAMPO ID HORARIO ESTÁ VACÍO!")
            ElseIf LbIdEmpresa.Text = "" Then
                MessageBox.Show("EL CAMPO ID EMPRESA ESTÁ VACÍO!")
            ElseIf TbNombreEmpl.Text = "" Then
                MessageBox.Show("EL CAMPO NOMBRE EMPLEADO ESTÁ VACÍO!")
            ElseIf TbPaternoEmpl.Text = "" Then
                MessageBox.Show("EL CAMPO APELLIDO PATERNO ESTÁ VACÍO!")
            ElseIf TbMaternoEmpl.Text = "" Then
                MessageBox.Show("EL CAMPO APELLIDO MATERNO ESTÁ VACÍO!")
            ElseIf TbTelefono.Text = "" Then
                MessageBox.Show("EL CAMPO TELÉFONO ESTÁ VACÍO!")
            ElseIf TbIne.Text = "" Then
                MessageBox.Show("EL CAMPO INE EMPLEADO ESTÁ VACÍO!")
            ElseIf TbSueldo.Text = "" Then
                MessageBox.Show("EL CAMPO SUELDO ESTÁ VACÍO!")
            ElseIf TbContrasena.Text = "" Then
                MessageBox.Show("EL CAMPO CONTRASEÑA ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim empleado As New ClaseEmpleado(TbIdEmpleado.Text, LbIdGenero.Text, LbIdHorario.Text, LbIdEmpresa.Text, TbNombreEmpl.Text, TbPaternoEmpl.Text, TbMaternoEmpl.Text, TbTelefono.Text, TbIne.Text, TbSueldo.Text, TbContrasena.Text)

                'Consulta de que exista el empleado
                If empleado.consultaUnIdEmpleado() = False Then
                    MsgBox("NO EXISTE EL ID DEL EMPLEADO!")
                Else
                    'Consulta que ninguna caseta dependa del empleado
                    If empleado.validaEmpleado() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR EL EMPLEADO '" & TbNombreEmpl.Text & "' PORQUE TIENE UNA O MÁS CASETAS QUE DEPENDEN DE ÉSTE MISMO!")
                    Else
                        'Sí ninguna caseta depende del empleado se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL EMPLEADO '" & TbNombreEmpl.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro del empleado
                            empleado.eliminarEmpleado()
                            MessageBox.Show("EMPLEADO ELIMINADO CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            empleado.PoblarDataGridColor(DGVEmpleado)
                            'Después de eliminar mostramos el ID EMPLEADO proximo
                            empleado.mostrarIdMax()
                            'Si se encuentra abierto el formulario de CASETA, se actualiza el combo
                            'empleado con los nuevos cambios
                            FrmCaseta.caseta.poblarComboEmpleado()
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

    Private Sub CbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CbMostrar.CheckedChanged
        If CbMostrar.Checked = True Then
            TbContrasena.UseSystemPasswordChar = False
        Else
            TbContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CbGeneroD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbGeneroD.SelectedIndexChanged
        empleado.mostrarIdDelGenero()
    End Sub

    Private Sub CbHoraInicioD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbHoraInicioD.SelectedIndexChanged
    End Sub

    Private Sub CbHoraFinD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbHoraFinD.SelectedIndexChanged
        empleado.mostrarIdDelHorario()
    End Sub

    Private Sub CbEmpresaD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbEmpresaD.SelectedIndexChanged
        empleado.mostrarIdDeEmpresa()
    End Sub

    Public Sub actualizaIds()
        empleado.mostrarIdDelGenero()
        empleado.mostrarIdDelHorario()
        empleado.mostrarIdDeEmpresa()
        empleado.mostrarIdDelHorario()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FrmGenero.Show()
    End Sub

    Private Sub AgregarUnHorarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarUnHorarioToolStripMenuItem1.Click
        FrmHorarioLaboral.Show()
    End Sub

    Private Sub AgregarUnaEmpresaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarUnaEmpresaToolStripMenuItem1.Click
        FrmEmpresa.Show()
    End Sub

    Private Sub AgregarInformaciónFaltanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarInformaciónFaltanteToolStripMenuItem.Click

    End Sub
End Class