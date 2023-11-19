<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmColor))
        Me.DGVColores = New System.Windows.Forms.DataGridView()
        Me.LbIdColor = New System.Windows.Forms.Label()
        Me.TxtIdColor = New System.Windows.Forms.TextBox()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.LbColor = New System.Windows.Forms.Label()
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVColores
        '
        Me.DGVColores.AllowUserToOrderColumns = True
        Me.DGVColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVColores.Location = New System.Drawing.Point(13, 87)
        Me.DGVColores.Name = "DGVColores"
        Me.DGVColores.Size = New System.Drawing.Size(295, 115)
        Me.DGVColores.TabIndex = 16
        '
        'LbIdColor
        '
        Me.LbIdColor.AutoSize = True
        Me.LbIdColor.Location = New System.Drawing.Point(13, 50)
        Me.LbIdColor.Name = "LbIdColor"
        Me.LbIdColor.Size = New System.Drawing.Size(49, 13)
        Me.LbIdColor.TabIndex = 17
        Me.LbIdColor.Text = "Id. Color:"
        '
        'TxtIdColor
        '
        Me.TxtIdColor.Location = New System.Drawing.Point(68, 47)
        Me.TxtIdColor.MaxLength = 5
        Me.TxtIdColor.Name = "TxtIdColor"
        Me.TxtIdColor.Size = New System.Drawing.Size(87, 20)
        Me.TxtIdColor.TabIndex = 18
        '
        'TxtColor
        '
        Me.TxtColor.Location = New System.Drawing.Point(214, 47)
        Me.TxtColor.MaxLength = 15
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(94, 20)
        Me.TxtColor.TabIndex = 20
        '
        'LbColor
        '
        Me.LbColor.AutoSize = True
        Me.LbColor.Location = New System.Drawing.Point(168, 50)
        Me.LbColor.Name = "LbColor"
        Me.LbColor.Size = New System.Drawing.Size(34, 13)
        Me.LbColor.TabIndex = 19
        Me.LbColor.Text = "Color:"
        '
        'LbTitulo
        '
        Me.LbTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitulo.Location = New System.Drawing.Point(0, 5)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(378, 35)
        Me.LbTitulo.TabIndex = 21
        Me.LbTitulo.Text = "COLOR"
        Me.LbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(326, 168)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(33, 34)
        Me.BtnSalir.TabIndex = 73
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(326, 128)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(33, 31)
        Me.BtnLimpiar.TabIndex = 72
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(326, 88)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(33, 32)
        Me.BtnBorrar.TabIndex = 71
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(326, 47)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(33, 33)
        Me.BtnGuardar.TabIndex = 70
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 226)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LbTitulo)
        Me.Controls.Add(Me.TxtColor)
        Me.Controls.Add(Me.LbColor)
        Me.Controls.Add(Me.TxtIdColor)
        Me.Controls.Add(Me.LbIdColor)
        Me.Controls.Add(Me.DGVColores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmColor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color"
        CType(Me.DGVColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVColores As DataGridView
    Friend WithEvents LbIdColor As Label
    Friend WithEvents TxtIdColor As TextBox
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents LbColor As Label
    Friend WithEvents LbTitulo As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
End Class
