Public Class FrmVisitante
    Public visitante As New ClaseVisitante
    Private Sub FrmVisitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        visitante.PoblarDataGridVisitante(DGVVisitante)
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")


        'Poblar el comboBox de géneros
        visitante.poblarComboGeneros()

        'Actualizamos Id's correspondientes
        actualizaIds()

        'Si el campo ID VISITANTE no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdVisitanteD.Text = "" Then
            visitante.mostrarIdMax()
        End If
    End Sub

    Private Sub DGVVisitante_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVisitante.CellContentClick
        Try
            'Con éste código podemos seleccionar los datos que están mostrados
            'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

            Dim renglon As Integer

            renglon = DGVVisitante.CurrentCellAddress.Y

            TbIdVisitanteD.Text = DGVVisitante.Rows(renglon).Cells(0).Value
            TbNombreVis.Text = DGVVisitante.Rows(renglon).Cells(1).Value
            TbPaterno.Text = DGVVisitante.Rows(renglon).Cells(2).Value
            TbMaterno.Text = DGVVisitante.Rows(renglon).Cells(3).Value
            CbGeneroD.Text = DGVVisitante.Rows(renglon).Cells(4).Value
            TbTelefono.Text = DGVVisitante.Rows(renglon).Cells(5).Value
            TbIneVis.Text = DGVVisitante.Rows(renglon).Cells(6).Value

        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Validamos que esta empresa no tenga empleados dados de alta, es decir que no tenga hijos.
            'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
            'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
            If TbIdVisitanteD.Text = "" And TbNombreVis.Text = "" And TbPaterno.Text = "" And TbMaterno.Text = "" And LbIdGenero.Text = "" And TbTelefono.Text = "" And TbIneVis.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdVisitanteD.Text = "" Then
                MessageBox.Show("EL CAMPO ID VISITANTE ESTÁ VACÍO!")
            ElseIf TbNombreVis.Text = "" Then
                MessageBox.Show("EL CAMPO NOMBRE ESTÁ VACÍO!")
            ElseIf TbPaterno.Text = "" Then
                MessageBox.Show("EL CAMPO PATERNO DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbMaterno.Text = "" Then
                MessageBox.Show("EL CAMPO MATERNO ESTÁ VACÍO!")
            ElseIf LbIdGenero.Text = "" Then
                MessageBox.Show("EL CAMPO ID GÉNERO ESTÁ VACÍO!")
            ElseIf TbTelefono.Text = "" Then
                MessageBox.Show("EL CAMPO TELÉFONO ESTÁ VACÍO!")
            ElseIf TbIneVis.Text = "" Then
                MessageBox.Show("EL CAMPO INE ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los 9 datos de las cajas de texto
                Dim visitante As New ClaseVisitante(TbIdVisitanteD.Text, LbIdGenero.Text, TbNombreVis.Text, TbPaterno.Text, TbMaterno.Text, TbTelefono.Text, TbIneVis.Text)

                'Consulta de que exista el visitante
                If visitante.consultaUnIdVisitante() = False Then
                    MsgBox("NO EXISTE EL ID DEL VISITANTE!")
                Else
                    'Consulta que ningun vehiculo o folio dependa del visitante
                    If visitante.validaVisitanteVeh() = True Or visitante.validaVisitanteFolio() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR EL VISITANTE '" & TbNombreVis.Text & "' PORQUE TIENE UN AUTOMOVIL O FOLIO QUE DEPENDEN DE ÉSTE MISMO!")
                    Else
                        'Sí ninguna caseta depende del empleado se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL VISITANTE '" & TbNombreVis.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro del VISITANTE
                            visitante.eliminarVisitante()
                            MessageBox.Show("VISITANTE ELIMINADO CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            visitante.PoblarDataGridVisitante(DGVVisitante)
                            'Después de eliminar mostramos el ID HABITANTE proximo
                            visitante.mostrarIdMax()
                            'Si se encuentra abierto el formulario de Vehiculo, se actualiza el combo
                            'VISITANTE con los nuevos cambios
                            FrmVehiculo.vehiculo.poblarComboVisitante()
                            'Si se encuentra abierto el formulario de Folio, se actualiza el combo
                            'VISITANTE con los nuevos cambios
                            FrmFolio.folio.poblarComboVisitante()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TbNombreVis.Text = ""
        TbPaterno.Text = ""
        TbMaterno.Text = ""
        TbTelefono.Text = ""
        TbIneVis.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        visitante.mostrarIdMax()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdVisitanteD.Text = "" And TbNombreVis.Text = "" And TbPaterno.Text = "" And TbMaterno.Text = "" And LbIdGenero.Text = "" And TbTelefono.Text = "" And TbIneVis.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdVisitanteD.Text = "" Then
                MessageBox.Show("EL CAMPO ID VISITANTE ESTÁ VACÍO!")
            ElseIf TbNombreVis.Text = "" Then
                MessageBox.Show("EL CAMPO NOMBRE ESTÁ VACÍO!")
            ElseIf TbPaterno.Text = "" Then
                MessageBox.Show("EL CAMPO PATERNO DEL HABITANTE ESTÁ VACÍO!")
            ElseIf TbMaterno.Text = "" Then
                MessageBox.Show("EL CAMPO MATERNO ESTÁ VACÍO!")
            ElseIf LbIdGenero.Text = "" Then
                MessageBox.Show("EL CAMPO ID GÉNERO ESTÁ VACÍO!")
            ElseIf TbTelefono.Text = "" Then
                MessageBox.Show("EL CAMPO TELÉFONO ESTÁ VACÍO!")
            ElseIf TbIneVis.Text = "" Then
                MessageBox.Show("EL CAMPO INE ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los 9 datos de las cajas de texto
                Dim visitante As New ClaseVisitante(TbIdVisitanteD.Text, LbIdGenero.Text, TbNombreVis.Text, TbPaterno.Text, TbMaterno.Text, TbTelefono.Text, TbIneVis.Text)

                'En el siguiente IF, usamos un método para verificar si EL VISITANTE está registrada

                If visitante.consultaUnIdVisitante() = False Then
                    'Si EL visitante NO está registradO, lo inserta como una nuevo
                    visitante.insertaVisitante()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("VISITANTE REGISTRADO CORRECTAMENTE!")
                Else
                    'SI el VISITANTE está registrado, se modifica la información
                    visitante.actualizaVisitante() 'ACTUALIZA EL visitante

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("VISITANTE MODIFICADO CORRECTAMENTE!")
                End If
                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                visitante.PoblarDataGridVisitante(DGVVisitante)
                'Limpiamos las cajas de texto y mostramos el ID VISITANTE proximo
                Call BtnLimpiar_Click(sender, e)
                'Si se encuentra abierto el formulario de Vehiculo, se actualiza el combo
                'VISITANTE con los nuevos cambios
                FrmVehiculo.vehiculo.poblarComboVisitante()
                'Si se encuentra abierto el formulario de Folio, se actualiza el combo
                'VISITANTE con los nuevos cambios
                FrmFolio.folio.poblarComboVisitante()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbGeneroD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbGeneroD.SelectedIndexChanged
        visitante.mostrarIdDelGenero()
    End Sub

    Public Sub actualizaIds()
        visitante.mostrarIdDelGenero()
    End Sub

    Private Sub GToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GToolStripMenuItem1.Click
        FrmGenero.Show()
    End Sub
End Class