Public Class FrmVehiculo
    Public vehiculo As New ClaseVehiculo
    Private Sub FrmVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los vehiculo, la clase vehiculo (ClaseVehiculo) tiene un método llamado PoblarDGVVehic
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        vehiculo.PoblarDataGridVehic(DGVVehic)

        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'Poblar el comboBox de géneros
        vehiculo.poblarComboColor()

        'Poblar el comboBox de habitante
        vehiculo.poblarComboHabitante()

        'Poblar el comboBox de visitante
        vehiculo.poblarComboVisitante()

        'Actualizamos Id's correspondientes
        actualizaIds()

        'Modo inicial del boton de COMBOBOX, los checkbox, listos para su uso, limpios.
        If LbIdHabitante.Text = "1" And LbIdVisitante.Text = "1" And LbIdColor.Text = "1" Then
            CbHabitanteD.Enabled = False
            CbVisitanteD.Enabled = False
            LbIdHabitante.Text = "0"
            CbHabitanteD.Text = "Habitante"
            LbIdVisitante.Text = "0"
            CbVisitanteD.Text = "Visitante"
            LbIdColor.Text = "0"
            CbColorD.Text = "Color"
        End If

        'Si el campo ID EMPLEADO no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdVehiculo.Text = "" Then
            vehiculo.mostrarIdMax()
        End If
    End Sub

    Private Sub DGVVehic_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVehic.CellContentClick
        Try

        
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVVehic.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TbIdVehiculo.Text = DGVVehic.Rows(renglon).Cells(0).Value

        If IsDBNull(DGVVehic.Rows(renglon).Cells(1).Value) Then
            LbIdHabitante.Text = "0"
            CbHabitanteD.Text = "Habitante"
            CbEsVisitante.Checked = True
            CbEsHabitante.Checked = False
        Else
            LbIdHabitante.Text = DGVVehic.Rows(renglon).Cells(1).Value
            vehiculo.mostrarNombreDelHabitante()
        End If

        If IsDBNull(DGVVehic.Rows(renglon).Cells(2).Value) Then
            LbIdVisitante.Text = "0"
            CbVisitanteD.Text = "Visitante"
            CbEsHabitante.Checked = True
            CbEsVisitante.Checked = False
        Else
            LbIdVisitante.Text = DGVVehic.Rows(renglon).Cells(2).Value
            vehiculo.mostrarNombreDelVisitante()
        End If

        TbMatricula.Text = DGVVehic.Rows(renglon).Cells(4).Value
        TbMarca.Text = DGVVehic.Rows(renglon).Cells(5).Value
            CbColorD.Text = DGVVehic.Rows(renglon).Cells(6).Value

        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TbMatricula.Text = ""
        TbMarca.Text = ""
        CbHabitanteD.Text = "Habitante"
        CbEsHabitante.Checked = False
        CbHabitanteD.Enabled = False
        LbIdVisitante.Text = "0"
        CbVisitanteD.Text = "Visitante"
        CbEsVisitante.Checked = False
        CbVisitanteD.Enabled = False
        LbIdColor.Text = "0"
        CbColorD.Text = "Color"
        'Después de limpiar mostrar el siguiente ID permitido
        vehiculo.mostrarIdMax()
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdVehiculo.Text = "" And TbMatricula.Text = "" And TbMarca.Text = "" And LbIdColor.Text = "" And LbIdHabitante.Text = "" And LbIdVisitante.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdVehiculo.Text = "" Then
                MessageBox.Show("EL CAMPO ID VEHÍCULO ESTÁ VACÍO!")
            ElseIf TbMatricula.Text = "" Then
                MessageBox.Show("EL CAMPO MATRÍCULA DEL VEHÍCULO ESTÁ VACÍO!")
            ElseIf TbMarca.Text = "" Then
                MessageBox.Show("EL CAMPO MARCA DEL VEHÍCULO ESTÁ VACÍO!")
            ElseIf LbIdColor.Text = "" Then
                MessageBox.Show("EL CAMPO ID COLOR ESTÁ VACÍO!")
            ElseIf LbIdHabitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID HABITANTE ESTÁ VACÍO!")
            ElseIf LbIdVisitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID VISITANTE ESTÁ VACÍO!")
            ElseIf CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
                MessageBox.Show("SELECCIONE SI EL DUEÑO ES HABITANTE O VISITANTE!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim vehiculo As New ClaseVehiculo(TbIdVehiculo.Text, LbIdColor.Text, LbIdHabitante.Text, LbIdVisitante.Text, TbMatricula.Text, TbMarca.Text, Me.CbEsHabitante.Checked, Me.CbEsVisitante.Checked)

                'En el siguiente IF, usamos un método para verificar si el VEHÍCULO está registrado
                If vehiculo.consultaUnIdVehic() = False Then
                    'Si el VEHÍCULO NO está registrado, lo inserta como uno nuevo
                    vehiculo.insertaVehiculo()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("VEHÍCULO REGISTRADO CORRECTAMENTE!")
                Else
                    'Si el VEHÍCULO se encuentra registrado, se modifica la información
                    vehiculo.actualizaVehiculo()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("VEHÍCULO MODIFICADO CORRECTAMENTE!")
                End If

                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                vehiculo.PoblarDataGridVehic(DGVVehic)
                'Limpiamos las cajas de texto y mostramos el ID VEHÍCULO proximo
                Call BtnLimpiar_Click(sender, e)
                'Despues de la modificacion se actualiza el comboBox de VEHICULO en el folio
                FrmFolio.folio.poblarComboVehiculoHab()
                FrmFolio.folio.poblarComboVehiculoVis()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            If TbIdVehiculo.Text = "" And TbMatricula.Text = "" And TbMarca.Text = "" And LbIdColor.Text = "" And LbIdHabitante.Text = "" And LbIdVisitante.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdVehiculo.Text = "" Then
                MessageBox.Show("EL CAMPO ID VEHÍCULO ESTÁ VACÍO!")
            ElseIf TbMatricula.Text = "" Then
                MessageBox.Show("EL CAMPO MATRÍCULA DEL VEHÍCULO ESTÁ VACÍO!")
            ElseIf TbMarca.Text = "" Then
                MessageBox.Show("EL CAMPO MARCA DEL VEHÍCULO ESTÁ VACÍO!")
            ElseIf LbIdColor.Text = "" Then
                MessageBox.Show("EL CAMPO ID COLOR ESTÁ VACÍO!")
            ElseIf LbIdHabitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID HABITANTE ESTÁ VACÍO!")
            ElseIf LbIdVisitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID VISITANTE ESTÁ VACÍO!")
            ElseIf CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
                MessageBox.Show("SELECCIONE SI EL DUEÑO ES HABITANTE O VISITANTE!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim vehiculo As New ClaseVehiculo(TbIdVehiculo.Text, LbIdColor.Text, LbIdHabitante.Text, LbIdVisitante.Text, TbMatricula.Text, TbMarca.Text, Me.CbEsHabitante.Checked, Me.CbEsVisitante.Checked)
                'Consulta de que exista el VEHÍCULO
                If vehiculo.consultaUnIdVehic() = False Then
                    MsgBox("NO EXISTE EL ID DEL VEHÍCULO!")
                Else
                    'Consulta que ningun habitante o visitante dependa del VEHÍCULO
                    If vehiculo.validaVehicFolio() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR EL VEHÍCULO PORQUE TIENE UNA O MÁS FOLIOS QUE DEPENDEN DE ÉSTE MISMO!")
                    Else
                        'Sí ninguna persona depende del VEHÍCULO se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL VEHÍCULO ?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro del VEHÍCULO
                            vehiculo.eliminarVehiculo()
                            MessageBox.Show("VEHÍCULO ELIMINADO CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            vehiculo.PoblarDataGridVehic(DGVVehic)
                            'Después de eliminar mostramos el ID VEHÍCULO proximo
                            vehiculo.mostrarIdMax()
                            'Despues de la modificacion se actualiza el comboBox de VEHICULO en el folio
                            FrmFolio.folio.poblarComboVehiculoHab()
                            FrmFolio.folio.poblarComboVehiculoVis()
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

    Private Sub CbColorD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbColorD.SelectedIndexChanged
        vehiculo.mostrarIdColor()
    End Sub

    Private Sub CbHabitanteD_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CbHabitanteD.SelectedIndexChanged
        vehiculo.mostrarIdDelHabitante()
    End Sub

    Private Sub CbVisitanteD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVisitanteD.SelectedIndexChanged
        vehiculo.mostrarIdDelVisitante()
    End Sub

    Public Sub actualizaIds()
        vehiculo.mostrarIdColor()
        vehiculo.mostrarIdDelHabitante()
        vehiculo.mostrarIdDelVisitante()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        FrmColor.Show()
    End Sub

    Private Sub CbEsHabitante_CheckedChanged(sender As Object, e As EventArgs) Handles CbEsHabitante.CheckedChanged
        If CbEsHabitante.Checked = True Then
            CbEsVisitante.Checked = False
            LbIdVisitante.Text = "0"
            CbVisitanteD.Text = "Visitante"
            CbHabitanteD.Enabled = True
            CbVisitanteD.Enabled = False
        End If

        If CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
            LbIdVisitante.Text = "0"
            LbIdHabitante.Text = "0"
            CbHabitanteD.Text = "Habitante"
            CbVisitanteD.Text = "Visitante"
            CbHabitanteD.Enabled = False
            CbVisitanteD.Enabled = False
        End If
    End Sub

    Private Sub CbEsVisitante_CheckedChanged(sender As Object, e As EventArgs) Handles CbEsVisitante.CheckedChanged
        If CbEsVisitante.Checked = True Then
            CbEsHabitante.Checked = False
            LbIdHabitante.Text = "0"
            CbHabitanteD.Text = "Habitante"
            CbHabitanteD.Enabled = False
            CbVisitanteD.Enabled = True
        End If

        If CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
            LbIdVisitante.Text = "0"
            LbIdHabitante.Text = "0"
            CbHabitanteD.Text = "Habitante"
            CbVisitanteD.Text = "Visitante"
            CbHabitanteD.Enabled = False
            CbVisitanteD.Enabled = False
        End If
    End Sub
End Class