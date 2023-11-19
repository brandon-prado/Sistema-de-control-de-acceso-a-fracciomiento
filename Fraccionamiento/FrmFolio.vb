Public Class FrmFolio
    Public folio As New ClaseFolio
    Private Sub FrmFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los folios, la clase folio (ClaseFolio) tiene un método llamado PoblarDGVFolio
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        folio.PoblarDataGridFolio(DGVFolio)

        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'Poblar el comboBox de habitante
        folio.poblarComboHabitante()

        'Poblar el comboBox de visitante
        folio.poblarComboVisitante()

        'Poblar el comboBox de caseta
        folio.poblarComboCaseta()

        'Mostrar nombre y apellido de quien atiende
        folio.mostrarNombEmplFolio()
        folio.mostrarApellEmplFolio()

        'Mostrar la cantidad de folios, habitantes, visitantes y personas sin salir del fraccionamiento
        folio.mostrarTotalFolio()
        folio.mostrarPersonSinSalir()
        folio.mostrarTotalHab()
        folio.mostrarTotalVis()

        'Actualizamos Id's correspondientes
        actualizaIds()

        'Si el campo ID CASETA no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdFolio.Text = "" Then
            folio.mostrarIdMax()
        End If

        'Modo inicial del boton de confirmacion de salida
        BtnConfirmSalida.Enabled = False

        'Modo inicial del boton de confirmacion, los checkbox, listos para su uso, limpios.
        'If LbIdHabitante.Text = "1" And LbIdVisitante.Text = "1" And LbIdCaseta.Text = "1" Then
        '    BtnConfirmSalida.Enabled = False
        '    CbHabitanteD.Enabled = False
        '    CbVisitanteD.Enabled = False
        '    LbIdHabitante.Text = "0"
        '    CbHabitanteD.Text = "Habitante"
        '    LbIdVisitante.Text = "0"
        '    CbVisitanteD.Text = "Visitante"
        '    LbIdCaseta.Text = "0"
        '    CbCasetaD.Text = "Caseta"
        'End If

        If CbLlegoEnVehic.Checked = False Then
            LbIdVehiculo.Text = "0"
            CbMatriculaVeh.Text = "No Aplica"
        End If

        If CbLlegoEnVehic.Checked = False Then
            CbMatriculaVeh.Enabled = False
        End If

        'SI EL USUARIO SI TIENE CASETAS ASIGNADAS SE OCULTA EL MENSAJE
        LbUsuarioSinCaseta.Visible = False
    End Sub


    Private Sub DGVFolio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVFolio.CellContentClick
        Try
            'Con éste código podemos seleccionar los datos que están mostrados
            'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

            Dim renglon As Integer

            renglon = DGVFolio.CurrentCellAddress.Y

            'Al darle clic al renglón mostramos los datos en las cajas de texto
            'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
            'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
            'dejamos en la caja de texto correspondiente

            TbIdFolio.Text = DGVFolio.Rows(renglon).Cells(0).Value

            If IsDBNull(DGVFolio.Rows(renglon).Cells(1).Value) Then
                LbIdHabitante.Text = "0"
                CbHabitanteD.Text = "Habitante"
                CbEsVisitante.Checked = True
                CbEsHabitante.Checked = False
            Else
                LbIdHabitante.Text = DGVFolio.Rows(renglon).Cells(1).Value
                folio.mostrarNombreDelHabitante()
            End If

            If IsDBNull(DGVFolio.Rows(renglon).Cells(2).Value) Then
                LbIdVisitante.Text = "0"
                CbVisitanteD.Text = "Visitante"
                CbEsHabitante.Checked = True
                CbEsVisitante.Checked = False
            Else
                LbIdVisitante.Text = DGVFolio.Rows(renglon).Cells(2).Value
                folio.mostrarNombreDelVisitante()
            End If

            If IsDBNull(DGVFolio.Rows(renglon).Cells(4).Value) Then
                LbIdVehiculo.Text = "0"
                CbMatriculaVeh.Text = "No Aplica"
                CbLlegoEnVehic.Checked = False
            Else
                CbLlegoEnVehic.Checked = True
                LbIdVehiculo.Text = DGVFolio.Rows(renglon).Cells(4).Value
                folio.mostrarMatricula()

            End If

            LbIdCaseta.Text = DGVFolio.Rows(renglon).Cells(6).Value

            CbCasetaD.Text = DGVFolio.Rows(renglon).Cells(8).Value
            folio.mostrarIdDeCaseta()

            If IsDBNull(DGVFolio.Rows(renglon).Cells(12).Value) Then
                BtnConfirmSalida.Enabled = True
            Else
                BtnConfirmSalida.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LbIdHabitante.Text = "0"
        CbHabitanteD.Text = "Habitante"
        CbEsHabitante.Checked = False
        CbHabitanteD.Enabled = False
        LbIdVisitante.Text = "0"
        CbVisitanteD.Text = "Visitante"
        CbEsVisitante.Checked = False
        CbVisitanteD.Enabled = False
        LbIdCaseta.Text = "0"
        CbCasetaD.Text = "Caseta"
        BtnConfirmSalida.Enabled = False
        CbLlegoEnVehic.Checked = False
        LbIdVehiculo.Text = "0"
        CbMatriculaVeh.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        folio.mostrarIdMax()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If LbIdHabitante.Text = "" And LbIdVisitante.Text = "" And LbIdVehiculo.Text = "" And CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdFolio.Text = "" Then
                MessageBox.Show("EL CAMPO ID FOLIO ESTÁ VACÍO!")
            ElseIf LbIdHabitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID HABITANTE ESTÁ VACÍO!")
            ElseIf LbIdHabitante.Text = "0" And CbEsHabitante.Checked = True And CbEsVisitante.Checked = False Then
                MessageBox.Show("SELECCIONA EL HABITANTE!")
            ElseIf LbIdVisitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID VISITANTE ESTÁ VACÍO!")
            ElseIf LbIdVisitante.Text = "0" And CbEsVisitante.Checked = True And CbEsHabitante.Checked = False Then
                MessageBox.Show("SELECCIONA EL VISITANTE!")
            ElseIf LbIdCaseta.Text = "0" Or LbIdCaseta.Text = "" Then
                MessageBox.Show("EL CAMPO ID CASETA ESTÁ VACÍO!")
            ElseIf LbIdVehiculo.Text = "" Then
                MessageBox.Show("EL CAMPO ID VEHICULO ESTÁ VACÍO!")
            ElseIf CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
                MessageBox.Show("SELECCIONE SI LA PERSONA ES HABITANTE O VISITANTE!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim folio As New ClaseFolio(TbIdFolio.Text, LbIdHabitante.Text, LbIdVisitante.Text, LbIdCaseta.Text, LbIdVehiculo.Text, Me.CbEsHabitante.Checked, Me.CbEsVisitante.Checked, Me.CbLlegoEnVehic.Checked)

                'En el siguiente IF, usamos un método para verificar si el FOLIO está registrado
                If folio.consultaUnIdFolio() = False Then
                    'Si el folio NO está registrado, lo inserta como uno nuevo
                    folio.insertaFolio()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("FOLIO REGISTRADO CORRECTAMENTE!")
                Else
                    'Si el empleado se encuentra registrado, se modifica la información
                    folio.actualizaFolio()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("FOLIO MODIFICADO CORRECTAMENTE!")
                End If

                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                folio.PoblarDataGridFolio(DGVFolio)
                'Limpiamos las cajas de texto y mostramos el ID FOLIO proximo
                Call BtnLimpiar_Click(sender, e)
                'Mostrar la cantidad de folios, habitantes, visitantes y personas sin salir del fraccionamiento
                folio.mostrarTotalFolio()
                folio.mostrarPersonSinSalir()
                folio.mostrarTotalHab()
                folio.mostrarTotalVis()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            If LbIdHabitante.Text = "" And LbIdVisitante.Text = "" And LbIdVehiculo.Text = "" And CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdFolio.Text = "" Then
                MessageBox.Show("EL CAMPO ID FOLIO ESTÁ VACÍO!")
            ElseIf LbIdHabitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID HABITANTE ESTÁ VACÍO!")
            ElseIf LbIdHabitante.Text = "0" And CbEsHabitante.Checked = True And CbEsVisitante.Checked = False Then
                MessageBox.Show("SELECCIONA EL HABITANTE!")
            ElseIf LbIdVisitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID VISITANTE ESTÁ VACÍO!")
            ElseIf LbIdVisitante.Text = "0" And CbEsVisitante.Checked = True And CbEsHabitante.Checked = False Then
                MessageBox.Show("SELECCIONA EL VISITANTE!")
            ElseIf LbIdCaseta.Text = "0" Or LbIdCaseta.Text = "" Then
                MessageBox.Show("EL CAMPO ID CASETA ESTÁ VACÍO!")
            ElseIf LbIdVehiculo.Text = "" Then
                MessageBox.Show("EL CAMPO ID VEHICULO ESTÁ VACÍO!")
            ElseIf CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
                MessageBox.Show("SELECCIONE SI LA PERSONA ES HABITANTE O VISITANTE!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim folio As New ClaseFolio(TbIdFolio.Text, LbIdHabitante.Text, LbIdVisitante.Text, LbIdCaseta.Text, LbIdVehiculo.Text, Me.CbEsHabitante.Checked, Me.CbEsVisitante.Checked, Me.CbLlegoEnVehic.Checked)
                'Consulta de que exista el FOLIO
                If folio.consultaUnIdFolio() = False Then
                    MsgBox("NO EXISTE EL ID DEL FOLIO!")
                Else
                    'Se pide confirmar la acción de borrado
                    If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL FOLIO?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                        'Llamamos al método que elimina el registro del FOLIO
                        folio.eliminarFolio()
                        MessageBox.Show("FOLIO ELIMINADO CORRECTAMENTE!")

                        'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                        folio.PoblarDataGridFolio(DGVFolio)
                        'Después de eliminar mostramos el ID EMPLEADO proximo
                        folio.mostrarIdMax()
                        'Mostrar la cantidad de folios, habitantes, visitantes y personas sin salir del fraccionamiento
                        folio.mostrarTotalFolio()
                        folio.mostrarPersonSinSalir()
                        folio.mostrarTotalHab()
                        folio.mostrarTotalVis()
                        'Bloquear boton de salida ya que no hay dato
                        BtnConfirmSalida.Enabled = False
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

    Private Sub CbHabitanteD_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CbHabitanteD.SelectedIndexChanged
        folio.mostrarIdDelHabitante()
    End Sub

    Private Sub CbVisitanteD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVisitanteD.SelectedIndexChanged
        folio.mostrarIdDelVisitante()
    End Sub

    Private Sub CbCasetaD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCasetaD.SelectedIndexChanged
        folio.mostrarIdDeCaseta()
    End Sub

    Private Sub BtnConfirmSalida_Click_1(sender As Object, e As EventArgs) Handles BtnConfirmSalida.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            If LbIdHabitante.Text = "" And LbIdVisitante.Text = "" And LbIdVehiculo.Text = "" And CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdFolio.Text = "" Then
                MessageBox.Show("EL CAMPO ID FOLIO ESTÁ VACÍO!")
            ElseIf LbIdHabitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID HABITANTE ESTÁ VACÍO!")
            ElseIf LbIdHabitante.Text = "0" And CbEsHabitante.Checked = True And CbEsVisitante.Checked = False Then
                MessageBox.Show("SELECCIONA EL HABITANTE!")
            ElseIf LbIdVisitante.Text = "" Then
                MessageBox.Show("EL CAMPO ID VISITANTE ESTÁ VACÍO!")
            ElseIf LbIdVisitante.Text = "0" And CbEsVisitante.Checked = True And CbEsHabitante.Checked = False Then
                MessageBox.Show("SELECCIONA EL VISITANTE!")
            ElseIf LbIdCaseta.Text = "0" Or LbIdCaseta.Text = "" Then
                MessageBox.Show("EL CAMPO ID CASETA ESTÁ VACÍO!")
            ElseIf LbIdVehiculo.Text = "" Then
                MessageBox.Show("EL CAMPO ID VEHICULO ESTÁ VACÍO!")
            ElseIf CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
                MessageBox.Show("SELECCIONE SI LA PERSONA ES HABITANTE O VISITANTE!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim folio As New ClaseFolio(TbIdFolio.Text, LbIdHabitante.Text, LbIdVisitante.Text, LbIdCaseta.Text, LbIdVehiculo.Text, Me.CbEsHabitante.Checked, Me.CbEsVisitante.Checked, Me.CbLlegoEnVehic.Checked)
                folio.confirmaSalida()
                BtnConfirmSalida.Enabled = False
                'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                folio.PoblarDataGridFolio(DGVFolio)
                'Mostrar la cantidad de folios, habitantes, visitantes y personas sin salir del fraccionamiento
                folio.mostrarTotalFolio()
                folio.mostrarPersonSinSalir()
                folio.mostrarTotalHab()
                folio.mostrarTotalVis()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Public Sub actualizaIds()
        folio.mostrarIdDelHabitante()
        folio.mostrarIdDelVisitante()
        folio.mostrarIdDeCaseta()
    End Sub

    Private Sub HabitanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabitanteToolStripMenuItem.Click
        FrmHabitante.Show()
    End Sub

    Private Sub VisitanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitanteToolStripMenuItem.Click
        FrmVisitante.Show()
    End Sub

    Private Sub CasetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasetaToolStripMenuItem.Click
        FrmCaseta.Show()
    End Sub

    Private Sub CbEsHabitante_CheckedChanged(sender As Object, e As EventArgs) Handles CbEsHabitante.CheckedChanged
        If CbEsHabitante.Checked = True Then
            CbEsVisitante.Checked = False
            LbIdVisitante.Text = "0"
            CbVisitanteD.Text = "Visitante"
            CbHabitanteD.Enabled = True
            CbVisitanteD.Enabled = False

            folio.poblarComboVehiculoHab()
            folio.mostrarIdDelVehic()
        End If

        If CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
            LbIdVisitante.Text = "0"
            CbVisitanteD.Text = "Visitante"
            CbHabitanteD.Enabled = False
            CbVisitanteD.Enabled = False

        End If

        If CbLlegoEnVehic.Checked = False Then
            LbIdVehiculo.Text = "0"
        End If

    End Sub

    Private Sub CbEsVisitante_CheckedChanged(sender As Object, e As EventArgs) Handles CbEsVisitante.CheckedChanged
        If CbEsVisitante.Checked = True Then
            CbEsHabitante.Checked = False
            LbIdHabitante.Text = "0"
            CbHabitanteD.Text = "Habitante"
            CbHabitanteD.Enabled = False
            CbVisitanteD.Enabled = True

            folio.poblarComboVehiculoVis()
            folio.mostrarIdDelVehic()
        End If     

        If CbEsHabitante.Checked = False And CbEsVisitante.Checked = False Then
            LbIdHabitante.Text = "0"
            CbHabitanteD.Text = "Habitante"
            CbHabitanteD.Enabled = False
            CbVisitanteD.Enabled = False
        End If

        If CbLlegoEnVehic.Checked = False Then
            LbIdVehiculo.Text = "0"
        End If
    End Sub

    Private Sub CbMatriculaVeh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMatriculaVeh.SelectedIndexChanged
        folio.mostrarIdDelVehic()
        'Mostrar marca y color del vehiculo
        If CbLlegoEnVehic.Checked = True Then
            LbMarcaD.Visible = True
            LbColorD.Visible = True
            folio.mostrarMarcaVeh()
            folio.mostrarColorVeh()
        ElseIf CbLlegoEnVehic.Checked = False Then
            LbMarcaD.Visible = False
            LbColorD.Visible = False
        End If
        
    End Sub

    Private Sub CbLlegoEnVehic_CheckedChanged(sender As Object, e As EventArgs) Handles CbLlegoEnVehic.CheckedChanged
        If CbLlegoEnVehic.Checked = True Then
            CbMatriculaVeh.Enabled = True
        End If

        If CbLlegoEnVehic.Checked = False Then
            CbMatriculaVeh.Enabled = False
            LbIdVehiculo.Text = "0"
            CbMatriculaVeh.Text = "No Aplica"
        End If

        'Mostrar marca y color del vehiculo
        If CbLlegoEnVehic.Checked = True Then
            LbMarcaD.Visible = True
            LbColorD.Visible = True
            folio.mostrarMarcaVeh()
            folio.mostrarColorVeh()
        ElseIf CbLlegoEnVehic.Checked = False Then
            LbMarcaD.Visible = False
            LbColorD.Visible = False
        End If
        
    End Sub

    Private Sub VehToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehToolStripMenuItem.Click
        FrmVehiculo.Show()
    End Sub
End Class