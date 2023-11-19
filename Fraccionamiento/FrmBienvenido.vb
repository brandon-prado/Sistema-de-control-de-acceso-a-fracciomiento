Public Class FrmBienvenido
    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FrmFolio.folio.mostrarNombEmplFolio()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub LbBienvenido_Click(sender As Object, e As EventArgs) Handles LbBienvenido.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVolverLogin.Click
        FrmMenu.Close()
        FrmLogin.Show()
        FrmEmpresa.Close()
        FrmHorarioLaboral.Close()
        FrmColor.Close()
        FrmGenero.Close()
        FrmVivienda.Close()
        FrmEmpleado.Close()
        FrmHabitante.Close()
        FrmCaseta.Close()
        FrmVehiculo.Close()
        FrmFolio.Close()
        FrmVisitante.Close()
        FrmAcercaDe.Close()
        FrmAyuda.Close()
        cnx.Close()
        Me.Close()
    End Sub

    Private Sub BtnMenuPrinc_Click(sender As Object, e As EventArgs) Handles BtnMenuPrinc.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
End Class