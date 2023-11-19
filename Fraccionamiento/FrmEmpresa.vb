Public Class FrmEmpresa
    Dim empresa As New ClaseEmpresa
    Private Sub FrmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblamos el DGV de los colores, la clase Fraccionamiento (ClaseFr) tiene un método llamado PoblarDGVEmpresa
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del DGV

        empresa.PoblarDataGridEmpresa(DGVEmpresa)

        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnBorrar, "Clic para Borrar información en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para Limpiar cajas de texto")
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para Salir de la ventana actual")

        'Si el campo ID EMPRESA no tiene ningun dato, muestra el ID siguiente permitido
        If TbIdEmpresa.Text = "" Then
            empresa.mostrarIdMax()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEmpresa.CellContentClick
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVEmpresa.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVColores.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TbIdEmpresa.Text = DGVEmpresa.Rows(renglon).Cells(0).Value
        TbNombreEmpresa.Text = DGVEmpresa.Rows(renglon).Cells(1).Value
        TbDireccEmpr.Text = DGVEmpresa.Rows(renglon).Cells(2).Value
        TbNumEmpr.Text = DGVEmpresa.Rows(renglon).Cells(3).Value
        TbCodPost.Text = DGVEmpresa.Rows(renglon).Cells(4).Value
        TbTelEmpr.Text = DGVEmpresa.Rows(renglon).Cells(5).Value
        TbCorreoEmpr.Text = DGVEmpresa.Rows(renglon).Cells(6).Value
        TbPagWebEmpr.Text = DGVEmpresa.Rows(renglon).Cells(7).Value
        TbRFCEmpr.Text = DGVEmpresa.Rows(renglon).Cells(8).Value

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Uso del Try Catch para capturar el error y evitar romper el programa
        Try
            'Validamos que esta empresa no tenga empleados dados de alta, es decir que no tenga hijos.
            'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
            'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
            If TbIdEmpresa.Text = "" And TbNombreEmpresa.Text = "" And TbDireccEmpr.Text = "" And TbNumEmpr.Text = "" And TbCodPost.Text = "" And TbTelEmpr.Text = "" And TbCorreoEmpr.Text = "" And TbPagWebEmpr.Text = "" And TbRFCEmpr.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdEmpresa.Text = "" Then
                MessageBox.Show("EL CAMPO ID EMPRESA ESTÁ VACÍO!")
            ElseIf TbNombreEmpresa.Text = "" Then
                MessageBox.Show("EL CAMPO NOMBRE EMPRESA ESTÁ VACÍO!")
            ElseIf TbDireccEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO DIRECCIÓN DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbNumEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO NÚMERO DIRECCIÓN DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbCodPost.Text = "" Then
                MessageBox.Show("EL CAMPO CÓDIGO POSTAL DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbTelEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO TELÉFONO DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbCorreoEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO CORREO DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbPagWebEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO PÁGINA WEB DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbRFCEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO RFC DE LA EMPRESA ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los 9 datos de las cajas de texto
                Dim empresa As New ClaseEmpresa(TbIdEmpresa.Text, TbNombreEmpresa.Text, TbDireccEmpr.Text, TbNumEmpr.Text, TbCodPost.Text, TbTelEmpr.Text, TbCorreoEmpr.Text, TbPagWebEmpr.Text, TbRFCEmpr.Text)

                'Consulta de que exista la empresa
                If empresa.consultaUnIdEmpresa() = False Then
                    MsgBox("NO EXISTE EL ID DE LA EMPRESA!")
                Else
                    'Consulta que ningún empleado dependa de la empresa
                    If empresa.validaEmpresa() = True Then
                        MsgBox("NO SE PUEDE ELIMINAR LA EMPRESA '" & TbNombreEmpresa.Text & "' PORQUE TIENE UNO O MÁS EMPLEADOS QUE DEPENDEN DE ÉSTA MISMA!")
                    Else
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR LA EMPRESA " & TbNombreEmpresa.Text & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            'Llamamos al método que elimina el registro de la empresa
                            empresa.eliminarEmpresa()
                            MessageBox.Show("EMPRESA ELIMINADA CORRECTAMENTE!")

                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            empresa.PoblarDataGridEmpresa(DGVEmpresa)
                            'Después de eliminar mostramos el ID proximo
                            empresa.mostrarIdMax()
                            'Si se encuentra abierto el formulario de Empleado, se actualiza el combo
                            'empresa con los nuevos cambios
                            FrmEmpleado.empleado.poblarComboEmpresas()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'Se puede limpiar una caja de textos de diferente manera, aquí les muestro dos,
        'ambas hacen lo mismo, quita el contenido de las cajas de texto 
        TbNombreEmpresa.Text = ""
        TbDireccEmpr.Text = ""
        TbNumEmpr.Text = ""
        TbCodPost.Text = ""
        TbTelEmpr.Text = ""
        TbCorreoEmpr.Text = ""
        TbPagWebEmpr.Text = ""
        TbRFCEmpr.Text = ""
        'Después de limpiar mostrar el siguiente ID permitido
        empresa.mostrarIdMax()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
            'capturado texto en las cajas de texto
            If TbIdEmpresa.Text = "" And TbNombreEmpresa.Text = "" And TbDireccEmpr.Text = "" And TbNumEmpr.Text = "" And TbCodPost.Text = "" And TbTelEmpr.Text = "" And TbCorreoEmpr.Text = "" And TbPagWebEmpr.Text = "" And TbRFCEmpr.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS ESTÁN VACÍOS!")
            ElseIf TbIdEmpresa.Text = "" Then
                MessageBox.Show("EL CAMPO ID EMPRESA ESTÁ VACÍO!")
            ElseIf TbNombreEmpresa.Text = "" Then
                MessageBox.Show("EL CAMPO NOMBRE EMPRESA ESTÁ VACÍO!")
            ElseIf TbDireccEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO DIRECCIÓN DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbNumEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO NÚMERO DIRECCIÓN DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbCodPost.Text = "" Then
                MessageBox.Show("EL CAMPO CÓDIGO POSTAL DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbTelEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO TELÉFONO DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbCorreoEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO CORREO DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbPagWebEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO PÁGINA WEB DE LA EMPRESA ESTÁ VACÍO!")
            ElseIf TbRFCEmpr.Text = "" Then
                MessageBox.Show("EL CAMPO RFC DE LA EMPRESA ESTÁ VACÍO!")
            Else
                'Instanciamos la clase y le pasamos como parámetros los 9 datos de las cajas de texto
                Dim empresa As New ClaseEmpresa(TbIdEmpresa.Text, TbNombreEmpresa.Text, TbDireccEmpr.Text, TbNumEmpr.Text, TbCodPost.Text, TbTelEmpr.Text, TbCorreoEmpr.Text, TbPagWebEmpr.Text, TbRFCEmpr.Text)

                'En el siguiente IF, usamos un método para verificar si la empresa está registrada

                If empresa.consultaUnIdEmpresa() = False Then
                    'Si la empresa NO está registrada, lo inserta como una nueva
                    empresa.insertaEmpresa() 'INSERTA NUEVA EMPRESA

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("EMPRESA REGISTRADA CORRECTAMENTE!")
                Else
                    'Si la empresa se encuentra registrada, se modifica la información
                    empresa.actualizaEmpresa() 'ACTUALIZA LA EMPRESA

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("EMPRESA MODIFICADA CORRECTAMENTE!")
                End If
                'Una vez realizada la accion del Insert o Update, debemos de presentar
                'la información de nueva cuenta en el DGV correspondiente
                empresa.PoblarDataGridEmpresa(DGVEmpresa)
                'Limpiamos las cajas de texto y mostramos el ID proximo
                Call BtnLimpiar_Click(sender, e)
                'Si se encuentra abierto el formulario de Empleado, se actualiza el combo
                'empresa con los nuevos cambios
                FrmEmpleado.empleado.poblarComboEmpresas()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class