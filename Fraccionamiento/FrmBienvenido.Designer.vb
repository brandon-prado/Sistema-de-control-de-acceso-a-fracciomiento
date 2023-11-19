<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBienvenido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBienvenido))
        Me.LbBienvenido = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnVolverLogin = New System.Windows.Forms.Button()
        Me.BtnMenuPrinc = New System.Windows.Forms.Button()
        Me.LbAtiendeNomD = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbBienvenido
        '
        Me.LbBienvenido.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBienvenido.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LbBienvenido.Location = New System.Drawing.Point(2, -5)
        Me.LbBienvenido.Name = "LbBienvenido"
        Me.LbBienvenido.Size = New System.Drawing.Size(428, 67)
        Me.LbBienvenido.TabIndex = 0
        Me.LbBienvenido.Text = "Bienvenido"
        Me.LbBienvenido.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 265)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnVolverLogin
        '
        Me.BtnVolverLogin.Location = New System.Drawing.Point(297, 311)
        Me.BtnVolverLogin.Name = "BtnVolverLogin"
        Me.BtnVolverLogin.Size = New System.Drawing.Size(120, 23)
        Me.BtnVolverLogin.TabIndex = 2
        Me.BtnVolverLogin.Text = "Cerrar sesión"
        Me.BtnVolverLogin.UseVisualStyleBackColor = True
        '
        'BtnMenuPrinc
        '
        Me.BtnMenuPrinc.Location = New System.Drawing.Point(11, 311)
        Me.BtnMenuPrinc.Name = "BtnMenuPrinc"
        Me.BtnMenuPrinc.Size = New System.Drawing.Size(99, 23)
        Me.BtnMenuPrinc.TabIndex = 3
        Me.BtnMenuPrinc.Text = "Ir al menú principal"
        Me.BtnMenuPrinc.UseVisualStyleBackColor = True
        '
        'LbAtiendeNomD
        '
        Me.LbAtiendeNomD.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAtiendeNomD.ForeColor = System.Drawing.Color.OrangeRed
        Me.LbAtiendeNomD.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LbAtiendeNomD.Location = New System.Drawing.Point(-3, 55)
        Me.LbAtiendeNomD.Name = "LbAtiendeNomD"
        Me.LbAtiendeNomD.Size = New System.Drawing.Size(433, 30)
        Me.LbAtiendeNomD.TabIndex = 84
        Me.LbAtiendeNomD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmBienvenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 352)
        Me.Controls.Add(Me.LbAtiendeNomD)
        Me.Controls.Add(Me.BtnMenuPrinc)
        Me.Controls.Add(Me.BtnVolverLogin)
        Me.Controls.Add(Me.LbBienvenido)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBienvenido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido al Fraccionamiento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LbBienvenido As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnVolverLogin As Button
    Friend WithEvents BtnMenuPrinc As Button
    Friend WithEvents LbAtiendeNomD As System.Windows.Forms.Label
End Class
