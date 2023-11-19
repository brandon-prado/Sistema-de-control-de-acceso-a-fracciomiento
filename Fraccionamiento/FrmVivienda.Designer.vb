<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVivienda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVivienda))
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.TbDireccionV = New System.Windows.Forms.TextBox()
        Me.LbDireccViv = New System.Windows.Forms.Label()
        Me.TbIdVivienda = New System.Windows.Forms.TextBox()
        Me.LbIdVivienda = New System.Windows.Forms.Label()
        Me.DGVVivienda = New System.Windows.Forms.DataGridView()
        Me.LbNumViv = New System.Windows.Forms.Label()
        Me.TbNoVivienda = New System.Windows.Forms.TextBox()
        Me.TbCodPostViv = New System.Windows.Forms.TextBox()
        Me.LbCodPost = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVVivienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTitulo
        '
        Me.LbTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitulo.Location = New System.Drawing.Point(1, 9)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(624, 33)
        Me.LbTitulo.TabIndex = 39
        Me.LbTitulo.Text = "VIVIENDA"
        Me.LbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TbDireccionV
        '
        Me.TbDireccionV.Location = New System.Drawing.Point(203, 55)
        Me.TbDireccionV.MaxLength = 20
        Me.TbDireccionV.Name = "TbDireccionV"
        Me.TbDireccionV.Size = New System.Drawing.Size(131, 20)
        Me.TbDireccionV.TabIndex = 38
        '
        'LbDireccViv
        '
        Me.LbDireccViv.AutoSize = True
        Me.LbDireccViv.Location = New System.Drawing.Point(142, 58)
        Me.LbDireccViv.Name = "LbDireccViv"
        Me.LbDireccViv.Size = New System.Drawing.Size(55, 13)
        Me.LbDireccViv.TabIndex = 37
        Me.LbDireccViv.Text = "Dirección:"
        '
        'TbIdVivienda
        '
        Me.TbIdVivienda.Location = New System.Drawing.Point(87, 54)
        Me.TbIdVivienda.MaxLength = 5
        Me.TbIdVivienda.Name = "TbIdVivienda"
        Me.TbIdVivienda.Size = New System.Drawing.Size(49, 20)
        Me.TbIdVivienda.TabIndex = 36
        '
        'LbIdVivienda
        '
        Me.LbIdVivienda.AutoSize = True
        Me.LbIdVivienda.Location = New System.Drawing.Point(14, 57)
        Me.LbIdVivienda.Name = "LbIdVivienda"
        Me.LbIdVivienda.Size = New System.Drawing.Size(66, 13)
        Me.LbIdVivienda.TabIndex = 35
        Me.LbIdVivienda.Text = "Id. Vivienda:"
        '
        'DGVVivienda
        '
        Me.DGVVivienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVivienda.Location = New System.Drawing.Point(12, 98)
        Me.DGVVivienda.Name = "DGVVivienda"
        Me.DGVVivienda.Size = New System.Drawing.Size(539, 167)
        Me.DGVVivienda.TabIndex = 34
        '
        'LbNumViv
        '
        Me.LbNumViv.AutoSize = True
        Me.LbNumViv.Location = New System.Drawing.Point(355, 58)
        Me.LbNumViv.Name = "LbNumViv"
        Me.LbNumViv.Size = New System.Drawing.Size(17, 13)
        Me.LbNumViv.TabIndex = 40
        Me.LbNumViv.Text = "#:"
        '
        'TbNoVivienda
        '
        Me.TbNoVivienda.Location = New System.Drawing.Point(378, 54)
        Me.TbNoVivienda.MaxLength = 7
        Me.TbNoVivienda.Name = "TbNoVivienda"
        Me.TbNoVivienda.Size = New System.Drawing.Size(49, 20)
        Me.TbNoVivienda.TabIndex = 41
        '
        'TbCodPostViv
        '
        Me.TbCodPostViv.Location = New System.Drawing.Point(534, 54)
        Me.TbCodPostViv.MaxLength = 7
        Me.TbCodPostViv.Name = "TbCodPostViv"
        Me.TbCodPostViv.Size = New System.Drawing.Size(75, 20)
        Me.TbCodPostViv.TabIndex = 43
        '
        'LbCodPost
        '
        Me.LbCodPost.AutoSize = True
        Me.LbCodPost.Location = New System.Drawing.Point(449, 57)
        Me.LbCodPost.Name = "LbCodPost"
        Me.LbCodPost.Size = New System.Drawing.Size(74, 13)
        Me.LbCodPost.TabIndex = 42
        Me.LbCodPost.Text = "Código postal:"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(570, 226)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(39, 39)
        Me.BtnSalir.TabIndex = 81
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(570, 183)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(39, 39)
        Me.BtnLimpiar.TabIndex = 80
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(570, 142)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(39, 37)
        Me.BtnBorrar.TabIndex = 79
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(570, 97)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(39, 41)
        Me.BtnGuardar.TabIndex = 78
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmVivienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 280)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TbCodPostViv)
        Me.Controls.Add(Me.LbCodPost)
        Me.Controls.Add(Me.TbNoVivienda)
        Me.Controls.Add(Me.LbNumViv)
        Me.Controls.Add(Me.LbTitulo)
        Me.Controls.Add(Me.TbDireccionV)
        Me.Controls.Add(Me.LbDireccViv)
        Me.Controls.Add(Me.TbIdVivienda)
        Me.Controls.Add(Me.LbIdVivienda)
        Me.Controls.Add(Me.DGVVivienda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVivienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vivienda"
        CType(Me.DGVVivienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTitulo As Label
    Friend WithEvents TbDireccionV As TextBox
    Friend WithEvents LbDireccViv As Label
    Friend WithEvents TbIdVivienda As TextBox
    Friend WithEvents LbIdVivienda As Label
    Friend WithEvents DGVVivienda As DataGridView
    Friend WithEvents LbNumViv As Label
    Friend WithEvents TbNoVivienda As TextBox
    Friend WithEvents TbCodPostViv As TextBox
    Friend WithEvents LbCodPost As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
End Class
