Public Class FrmMenu
    Private Sub BtnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles BtnCambiarUsuario.Click
        FrmBienvenido.Close()
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

    Private Sub BtnSalirMenu_Click(sender As Object, e As EventArgs) Handles BtnSalirMenu.Click
        FrmBienvenido.Show()
        Me.Hide()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.BtnEmpresa, "Clic para abrir el formulario de Empresa")
        Me.ToolTip1.SetToolTip(Me.BtnHorario, "Clic para abrir el formulario de Horario")
        Me.ToolTip1.SetToolTip(Me.BtnColor, "Clic para abrir el formulario de Color")
        Me.ToolTip1.SetToolTip(Me.BtnGenero, "Clic para abrir el formulario de Genero")
        Me.ToolTip1.SetToolTip(Me.BtnVivienda, "Clic para abrir el formulario de Vivienda")
        Me.ToolTip1.SetToolTip(Me.BtnEmpleado, "Clic para abrir el formulario de Empleado")
        Me.ToolTip1.SetToolTip(Me.BtnHabitante, "Clic para abrir el formulario de Habitante")
        Me.ToolTip1.SetToolTip(Me.BtnVisitante, "Clic para abrir el formulario de Visitante")
        Me.ToolTip1.SetToolTip(Me.BtnCaseta, "Clic para abrir el formulario de Caseta")
        Me.ToolTip1.SetToolTip(Me.BtnVehiculo, "Clic para abrir el formulario de Vehículo")
        Me.ToolTip1.SetToolTip(Me.BtnFolio, "Clic para abrir el formulario de Folio")
        Me.ToolTip1.SetToolTip(Me.BtnCambiarUsuario, "Clic para cambiar de usuario")
        Me.ToolTip1.SetToolTip(Me.BtnSalirMenu, "Clic para salir del menú principal")

        Me.ToolTip1.SetToolTip(Me.PBHelp, "Clic para abrir la ayuda")
    End Sub

    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        FrmEmpresa.Show()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles BtnHorario.Click
        FrmHorarioLaboral.Show()
    End Sub

    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColor.Click
        FrmColor.Show()
    End Sub

    Private Sub BtnGenero_Click(sender As Object, e As EventArgs) Handles BtnGenero.Click
        FrmGenero.Show()
    End Sub

    Private Sub BtnVivienda_Click(sender As Object, e As EventArgs) Handles BtnVivienda.Click
        FrmVivienda.Show()
    End Sub

    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEmpleado.Click
        FrmEmpleado.Show()
    End Sub

    Private Sub BtnHabitante_Click(sender As Object, e As EventArgs) Handles BtnHabitante.Click
        FrmHabitante.Show()
    End Sub

    Private Sub BtnFolio_Click(sender As Object, e As EventArgs) Handles BtnFolio.Click
        If FrmFolio.folio.consultaEmplCaseta() Then
            FrmFolio.Show()
        Else
            MsgBox("USTED NO CUENTA CON NIGUNA CASETA REGISTRADA POR LO QUE SOLO PUEDE VER LA INFORMACIÓN")
            FrmFolio.Show()
            FrmFolio.BtnGuardar.Enabled = False
            FrmFolio.BtnBorrar.Enabled = False
            FrmFolio.TbIdFolio.Enabled = False
            FrmFolio.CbEsVisitante.Enabled = False
            FrmFolio.CbEsHabitante.Enabled = False
            FrmFolio.CbHabitanteD.Enabled = False
            FrmFolio.CbVisitanteD.Enabled = False
            FrmFolio.CbCasetaD.Enabled = False
            FrmFolio.BtnConfirmSalida.Visible = False
            FrmFolio.LbLeAtiende.Visible = False
            FrmFolio.LbAtiendeNomD.Visible = False
            FrmFolio.LbAtiendeApellD.Visible = False
            FrmFolio.LbUsuarioSinCaseta.Visible = True

        End If

    End Sub

    Private Sub BtnCaseta_Click(sender As Object, e As EventArgs) Handles BtnCaseta.Click
        FrmCaseta.Show()
    End Sub

    Private Sub BtnVisitante_Click(sender As Object, e As EventArgs) Handles BtnVisitante.Click
        FrmVisitante.Show()
    End Sub

    Private Sub BtnVehiculo_Click(sender As Object, e As EventArgs) Handles BtnVehiculo.Click
        FrmVehiculo.Show()
    End Sub

    Private Sub LbBienevenido_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PBHelp_Click(sender As Object, e As EventArgs) Handles PBHelp.Click
        FrmAyuda.Show()
    End Sub

End Class