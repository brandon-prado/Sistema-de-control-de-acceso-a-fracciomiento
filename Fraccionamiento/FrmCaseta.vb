Public Class FrmCaseta
    Public caseta As New ClaseCaseta
    Private Sub FrmCaseta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los vehiculo, la clase vehiculo (ClaseVehiculo) tiene un método llamado PoblarDGVVehic
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        caseta.PoblarDataGridVCaseta(DGVCaseta)

        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'Poblar el comboBox de empleados
        caseta.poblarComboEmpleado()

        'Actualizamos Id's correspondientes
        actualizaIds()

        'Si el campo ID EMPLEADO no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdCaseta.Text = "" Then
            caseta.mostrarIdMax()
        End If
    End Sub

    Private Sub DGVCaseta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCaseta.CellContentClick
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVCaseta.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TbIdCaseta.Text = DGVCaseta.Rows(renglon).Cells(0).Value
        TbDireccion.Text = DGVCaseta.Rows(renglon).Cells(1).Value
        TbNombreCas.Text = DGVCaseta.Rows(renglon).Cells(2).Value
        CbEmpleadoD.Text = DGVCaseta.Rows(renglon).Cells(3).Value

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TbDireccion.Text = ""
        TbNombreCas.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        caseta.mostrarIdMax()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdCaseta.Text = "" And TbDireccion.Text = "" And TbNombreCas.Text = "" And LbIdEmpleado.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdCaseta.Text = "" Then
                MessageBox.Show("EL CAMPO ID CASETA ESTÁ VACÍO!")
            ElseIf TbDireccion.Text = "" Then
                MessageBox.Show("EL CAMPO DIRECCIÓN ESTÁ VACÍO!")
            ElseIf TbNombreCas.Text = "" Then
                MessageBox.Show("EL CAMPO NOMBRE ESTÁ VACÍO!")
            ElseIf LbIdEmpleado.Text = "" Then
                MessageBox.Show("EL CAMPO ID EMPLEADO ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim caseta As New ClaseCaseta(TbIdCaseta.Text, LbIdEmpleado.Text, TbDireccion.Text, TbNombreCas.Text)

                'En el siguiente IF, usamos un método para verificar si el caseta está registrado
                If caseta.consultaUnIdCaseta() = False Then
                    'Si el caseta NO está registrado, lo inserta como uno nuevo
                    caseta.insertaCaseta()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("CASETA REGISTRADA CORRECTAMENTE!")
                Else
                    'Si el caseta se encuentra registrado, se modifica la información
                    caseta.actualizaCaseta()

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("CASETA MODIFICADA CORRECTAMENTE!")
                End If

                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                caseta.PoblarDataGridVCaseta(DGVCaseta)
                'Limpiamos las cajas de texto y mostramos el ID CASETA proximo
                Call BtnLimpiar_Click(sender, e)
                'Si se encuentra abierto el formulario de folio, se actualiza el combo
                'caseta con los nuevos cambios
                FrmFolio.folio.poblarComboCaseta()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdCaseta.Text = "" And TbDireccion.Text = "" And TbNombreCas.Text = "" And LbIdEmpleado.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdCaseta.Text = "" Then
                MessageBox.Show("EL CAMPO ID CASETA ESTÁ VACÍO!")
            ElseIf TbDireccion.Text = "" Then
                MessageBox.Show("EL CAMPO DIRECCIÓN ESTÁ VACÍO!")
            ElseIf TbNombreCas.Text = "" Then
                MessageBox.Show("EL CAMPO NOMBRE ESTÁ VACÍO!")
            ElseIf LbIdEmpleado.Text = "" Then
                MessageBox.Show("EL CAMPO ID EMPLEADO ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los dos datos de la caja de texto
                Dim caseta As New ClaseCaseta(TbIdCaseta.Text, LbIdEmpleado.Text, TbDireccion.Text, TbNombreCas.Text)

                'Consulta de que exista LA CASETA
                If caseta.consultaUnIdCaseta() = False Then
                    MsgBox("NO EXISTE EL ID DE LA CASETA!")
                Else
                    'Consulta que ningun folio dependa de la caseta
                    If caseta.validaCasetaFolio() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR LA CASETA PORQUE TIENE UNO O MÁS FOLIOS QUE DEPENDEN DE ÉSTA MISMA!")
                    Else
                        'Sí ningun FOLIO depende de la caseta se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR LA CASETA ?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro de LA CASETA
                            caseta.eliminarCaseta()
                            MessageBox.Show("CASETA ELIMINADA CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            caseta.PoblarDataGridVCaseta(DGVCaseta)
                            'Después de eliminar mostramos el ID CASETA proximo
                            caseta.mostrarIdMax()
                            'Si se encuentra abierto el formulario de folio, se actualiza el combo
                            'caseta con los nuevos cambios
                            FrmFolio.folio.poblarComboCaseta()
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

    Private Sub CbEmpleadoD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbEmpleadoD.SelectedIndexChanged
        caseta.mostrarIdEmpleado()
    End Sub

    Public Sub actualizaIds()
        caseta.mostrarIdEmpleado()
    End Sub


    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        FrmEmpleado.Show()
    End Sub
End Class