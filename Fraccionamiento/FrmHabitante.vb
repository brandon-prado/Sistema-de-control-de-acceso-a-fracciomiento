Public Class FrmHabitante
    Public habitante As New ClaseHabitante
    Private Sub FrmHabitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los colores, la clase Fraccionamiento (ClaseFr) tiene un método llamado PoblarDGVEmpresa
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        habitante.PoblarDataGridHabitante(DGVHabitante)
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")


        'Poblar el comboBox de géneros
        habitante.poblarComboGeneros()
        'Poblar el comboBox de viviendas
        habitante.poblarComboIdVivienda()
        'Actualizamos Id's correspondientes
        actualizaIds()

        'Si el campo ID HABITANTE no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdHabitante.Text = "" Then
            habitante.mostrarIdMax()
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHabitante.CellContentClick
        Try
            'Con éste código podemos seleccionar los datos que están mostrados
            'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

            Dim renglon As Integer

            renglon = DGVHabitante.CurrentCellAddress.Y

            'Al darle clic al renglón mostramos los datos en las cajas de texto
            'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
            'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
            'dejamos en la caja de texto correspondiente

            TbIdHabitante.Text = DGVHabitante.Rows(renglon).Cells(0).Value
            TbNombre.Text = DGVHabitante.Rows(renglon).Cells(1).Value
            TbPaterno.Text = DGVHabitante.Rows(renglon).Cells(2).Value
            TbMaterno.Text = DGVHabitante.Rows(renglon).Cells(3).Value
            CbGeneroD.Text = DGVHabitante.Rows(renglon).Cells(4).Value
            CbViviendaD.Text = DGVHabitante.Rows(renglon).Cells(6).Value
            TbTelefonoHab.Text = DGVHabitante.Rows(renglon).Cells(8).Value
            DTFechaNacimD.Text = DGVHabitante.Rows(renglon).Cells(9).Value
            TbIneHab.Text = DGVHabitante.Rows(renglon).Cells(10).Value

        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try

    End Sub
    Private Sub BtnBorrar_Click_1(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Validamos que esta empresa no tenga empleados dados de alta, es decir que no tenga hijos.
            'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
            'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
            If TbIdHabitante.Text = "" And LbIdGenero.Text = "" And LbIdVivienda.Text = "" And TbNombre.Text = "" And TbPaterno.Text = "" And TbMaterno.Text = "" And TbTelefonoHab.Text = "" And DTFechaNacimD.Text = "" And TbIneHab.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdHabitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID HABITANTE ESTÁ VACÍO!")
            ElseIf LbIdGenero.Text = "" Then
                MessageBox.Show("EL CAMPO ID SEXO ESTÁ VACÍO!")
            ElseIf LbIdVivienda.Text = "" Then
                MessageBox.Show("EL CAMPO ID VIVIENDA DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbNombre.Text = "" Then
                MessageBox.Show("EL NOMBRE DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbPaterno.Text = "" Then
                MessageBox.Show("EL APELLIDO PATERNO DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbMaterno.Text = "" Then
                MessageBox.Show("EL APELLIDO MATERNO DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbTelefonoHab.Text = "" Then
                MessageBox.Show("EL TELEFONO DEL HABITANTE ESTÁ VACÍO!")
            ElseIf DTFechaNacimD.Text = "" Then
                MessageBox.Show(" LA FECHA DE NACIMIENTO DEL HABITANTE ESTÁ VACÍA!")
            ElseIf TbIneHab.Text = "" Then
                MessageBox.Show("LA INE DEL HABITANTE ESTÁ VACÍA")
            Else
                'Instanciamos la clase y le pasamos como parámetros los 9 datos de las cajas de texto
                Dim habitante As New ClaseHabitante(TbIdHabitante.Text, LbIdGenero.Text, LbIdVivienda.Text, TbNombre.Text, TbPaterno.Text, TbMaterno.Text, TbTelefonoHab.Text, DTFechaNacimD.Text, TbIneHab.Text)

                'Consulta de que exista el habitante
                If habitante.consultaUnIdHabitante() = False Then
                    MsgBox("NO EXISTE EL ID DEL HABITANTE!")
                Else
                    'Consulta que ningun vehiculo o folio dependa del habitante
                    If habitante.validaHabitanteVeh() = True Or habitante.validaHabitanteFolio() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR EL HABITANTE '" & TbNombre.Text & "' PORQUE TIENE UN AUTOMOVIL O FOLIO QUE DEPENDEN DE ÉSTE MISMO!")
                    Else
                        'Sí ninguna caseta depende del empleado se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL HABITANTE '" & TbNombre.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro del HABITANTE
                            habitante.eliminarHabitante()
                            MessageBox.Show("HABITANTE ELIMINADO CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            habitante.PoblarDataGridHabitante(DGVHabitante)
                            'Después de eliminar mostramos el ID HABITANTE proximo
                            habitante.mostrarIdMax()
                            'Si se encuentra abierto el formulario de Vehiculo, se actualiza el combo
                            'habitante con los nuevos cambios
                            FrmVehiculo.vehiculo.poblarComboHabitante()
                            'Si se encuentra abierto el formulario de Folio, se actualiza el combo
                            'habitante con los nuevos cambios
                            FrmFolio.folio.poblarComboHabitante()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnLimpiar_Click_1(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'Se puede limpiar una caja de textos de diferente manera, aquí les muestro dos,
        'ambas hacen lo mismo, quita el contenido de las cajas de texto 

        TbNombre.Text = ""
        TbPaterno.Text = ""
        TbMaterno.Text = ""
        TbTelefonoHab.Text = ""
        DTFechaNacimD.Text = ""
        TbIneHab.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        habitante.mostrarIdMax()
    End Sub
    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdHabitante.Text = "" And LbIdGenero.Text = "" And LbIdVivienda.Text = "" And TbNombre.Text = "" And TbPaterno.Text = "" And TbMaterno.Text = "" And TbTelefonoHab.Text = "" And DTFechaNacimD.Text = "" And TbIneHab.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdHabitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID HABITANTE ESTÁ VACÍO!")
            ElseIf LbIdGenero.Text = "" Then
                MessageBox.Show("EL CAMPO ID SEXO ESTÁ VACÍO!")
            ElseIf LbIdVivienda.Text = "" Then
                MessageBox.Show("EL CAMPO ID VIVIENDA DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbNombre.Text = "" Then
                MessageBox.Show("EL NOMBRE DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbPaterno.Text = "" Then
                MessageBox.Show("EL APELLIDO PATERNO DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbMaterno.Text = "" Then
                MessageBox.Show("EL APELLIDO MATERNO DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbTelefonoHab.Text = "" Then
                MessageBox.Show("EL TELEFONO DEL HABITANTE ESTÁ VACÍO!")
            ElseIf DTFechaNacimD.Text = "" Then
                MessageBox.Show(" LA FECHA DE NACIMIENTO DEL HABITANTE ESTÁ VACÍA!")
            ElseIf TbIneHab.Text = "" Then
                MessageBox.Show("LA INE DEL HABITANTE ESTÁ VACÍA")
            Else
                'Instanciamos la clase y le pasamos como parámetros los 9 datos de las cajas de texto
                Dim habitante As New ClaseHabitante(TbIdHabitante.Text, LbIdGenero.Text, LbIdVivienda.Text, TbNombre.Text, TbPaterno.Text, TbMaterno.Text, TbTelefonoHab.Text, DTFechaNacimD.Text, TbIneHab.Text)

                'En el siguiente IF, usamos un método para verificar si el habitante esta registrado

                If habitante.consultaUnIdHabitante() = False Then
                    'Si EL HABITANTE NO está registradO, lo inserta como una nuevo
                    habitante.insertaHabitante() 'INSERTA NUEVO HABITANTE

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("HABITANTE REGISTRADO CORRECTAMENTE!")
                Else
                    'SI el habitante está registrado, se modifica la información
                    habitante.actualizaHabitante() 'ACTUALIZA EL HABITANTE

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("HABITANTE MODIFICADO CORRECTAMENTE!")
                End If
                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                habitante.PoblarDataGridHabitante(DGVHabitante)
                'Limpiamos las cajas de texto y mostramos el ID EMPLEADO proximo
                Call BtnLimpiar_Click_1(sender, e)
                'Si se encuentra abierto el formulario de Vehiculo, se actualiza el combo
                'habitante con los nuevos cambios
                FrmVehiculo.vehiculo.poblarComboHabitante()
                'Si se encuentra abierto el formulario de Folio, se actualiza el combo
                'habitante con los nuevos cambios
                FrmFolio.folio.poblarComboHabitante()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click_1(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub CbGeneroD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbGeneroD.SelectedIndexChanged
        habitante.mostrarIdDelGenero()
    End Sub
    Private Sub CbIdViviendaD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbViviendaD.SelectedIndexChanged
        habitante.mostrarIdDeVivienda()
    End Sub
    Public Sub actualizaIds()
        habitante.mostrarIdDelGenero()
        habitante.mostrarIdDeVivienda()
    End Sub

    Private Sub GToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GToolStripMenuItem.Click
        FrmGenero.Show()

    End Sub

    Private Sub ViviendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViviendaToolStripMenuItem.Click
        FrmVivienda.Show()

    End Sub
End Class