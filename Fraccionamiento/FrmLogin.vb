Public Class FrmLogin
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            If TbEmpleado.Text = "" And TbContrasena.Text = "" Then
                MessageBox.Show("El campo EMPLEADO Y CONTRASEÑA estan vacios")
                Me.Hide()
            ElseIf TbContrasena.Text = "" Then
                MessageBox.Show("El campo CONTRASEÑA esta vacio")
            ElseIf TbEmpleado.Text = "" Then
                MessageBox.Show("El campo EMPLEADO esta vacio")
            Else
                'Instanciamos la clase y le pasamos como parámetros los 2 datos de la caja de texto
                Dim login As New ClaseLogin(TbEmpleado.Text, TbContrasena.Text)

                If login.consultaEmpleado() = False Then
                    MessageBox.Show("EL EMPLEADO NO EXISTE")
                    TbEmpleado.Text = vbNullString
                    TbContrasena.Text = ""
                ElseIf login.consultaEmpleado() = True Then
                    If login.consultaUsuarContr() = False Then
                        MessageBox.Show("LA CONTRASEÑA ESTA INCORRECTA")
                    Else
                        TbContrasena.Text = ""
                        FrmBienvenido.Show()
                        Me.Hide()
                    End If
                End If
            End If
            
        Catch ex As Exception
            MessageBox.Show("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'Se puede limpiar una caja de textos de diferente manera, aquí les muestro dos,
        'ambas hacen lo mismo, quita el contenido de las cajas de texto 
        TbEmpleado.Text = vbNullString
        TbContrasena.Text = ""
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

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class