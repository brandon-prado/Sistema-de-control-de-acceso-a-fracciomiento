<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisitante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisitante))
        Me.LbIdVisitante = New System.Windows.Forms.Label()
        Me.TbIdVisitanteD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbNombreVis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPaterno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbMaterno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbIneVis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DGVVisitante = New System.Windows.Forms.DataGridView()
        Me.CbGeneroD = New System.Windows.Forms.ComboBox()
        Me.LbIdGenero = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ModiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViviendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModificarInformaciónExternaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGVVisitante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbIdVisitante
        '
        Me.LbIdVisitante.AutoSize = True
        Me.LbIdVisitante.Location = New System.Drawing.Point(23, 88)
        Me.LbIdVisitante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbIdVisitante.Name = "LbIdVisitante"
        Me.LbIdVisitante.Size = New System.Drawing.Size(65, 13)
        Me.LbIdVisitante.TabIndex = 36
        Me.LbIdVisitante.Text = "Id. Visitante:"
        '
        'TbIdVisitanteD
        '
        Me.TbIdVisitanteD.Location = New System.Drawing.Point(92, 85)
        Me.TbIdVisitanteD.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIdVisitanteD.MaxLength = 5
        Me.TbIdVisitanteD.Name = "TbIdVisitanteD"
        Me.TbIdVisitanteD.Size = New System.Drawing.Size(62, 20)
        Me.TbIdVisitanteD.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Nombre:"
        '
        'TbNombreVis
        '
        Me.TbNombreVis.Location = New System.Drawing.Point(248, 85)
        Me.TbNombreVis.Margin = New System.Windows.Forms.Padding(2)
        Me.TbNombreVis.MaxLength = 20
        Me.TbNombreVis.Name = "TbNombreVis"
        Me.TbNombreVis.Size = New System.Drawing.Size(120, 20)
        Me.TbNombreVis.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Apellido Paterno:"
        '
        'TbPaterno
        '
        Me.TbPaterno.Location = New System.Drawing.Point(499, 85)
        Me.TbPaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.TbPaterno.MaxLength = 15
        Me.TbPaterno.Name = "TbPaterno"
        Me.TbPaterno.Size = New System.Drawing.Size(114, 20)
        Me.TbPaterno.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(647, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Apellido Materno:"
        '
        'TbMaterno
        '
        Me.TbMaterno.Location = New System.Drawing.Point(740, 85)
        Me.TbMaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.TbMaterno.MaxLength = 15
        Me.TbMaterno.Name = "TbMaterno"
        Me.TbMaterno.Size = New System.Drawing.Size(118, 20)
        Me.TbMaterno.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 134)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Telefono:"
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(328, 131)
        Me.TbTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.TbTelefono.MaxLength = 13
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(114, 20)
        Me.TbTelefono.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(482, 134)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "INE:"
        '
        'TbIneVis
        '
        Me.TbIneVis.Location = New System.Drawing.Point(514, 131)
        Me.TbIneVis.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIneVis.MaxLength = 13
        Me.TbIneVis.Name = "TbIneVis"
        Me.TbIneVis.Size = New System.Drawing.Size(107, 20)
        Me.TbIneVis.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(878, 31)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "VISITANTE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(804, 353)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 56)
        Me.BtnSalir.TabIndex = 108
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(804, 293)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(55, 56)
        Me.BtnLimpiar.TabIndex = 107
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(803, 233)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(55, 56)
        Me.BtnBorrar.TabIndex = 106
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(803, 173)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(56, 56)
        Me.BtnGuardar.TabIndex = 105
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DGVVisitante
        '
        Me.DGVVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVisitante.Location = New System.Drawing.Point(26, 175)
        Me.DGVVisitante.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVVisitante.Name = "DGVVisitante"
        Me.DGVVisitante.RowTemplate.Height = 28
        Me.DGVVisitante.Size = New System.Drawing.Size(758, 234)
        Me.DGVVisitante.TabIndex = 104
        '
        'CbGeneroD
        '
        Me.CbGeneroD.FormattingEnabled = True
        Me.CbGeneroD.Location = New System.Drawing.Point(128, 130)
        Me.CbGeneroD.Margin = New System.Windows.Forms.Padding(2)
        Me.CbGeneroD.Name = "CbGeneroD"
        Me.CbGeneroD.Size = New System.Drawing.Size(114, 21)
        Me.CbGeneroD.TabIndex = 111
        Me.CbGeneroD.Text = "Género"
        '
        'LbIdGenero
        '
        Me.LbIdGenero.AutoSize = True
        Me.LbIdGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdGenero.Location = New System.Drawing.Point(98, 131)
        Me.LbIdGenero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbIdGenero.Name = "LbIdGenero"
        Me.LbIdGenero.Size = New System.Drawing.Size(0, 16)
        Me.LbIdGenero.TabIndex = 110
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 133)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "ID Género:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ModiToolStripMenuItem
        '
        Me.ModiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GToolStripMenuItem, Me.ViviendaToolStripMenuItem})
        Me.ModiToolStripMenuItem.Image = CType(resources.GetObject("ModiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModiToolStripMenuItem.Name = "ModiToolStripMenuItem"
        Me.ModiToolStripMenuItem.Size = New System.Drawing.Size(195, 20)
        Me.ModiToolStripMenuItem.Text = "Modificar información externa"
        '
        'GToolStripMenuItem
        '
        Me.GToolStripMenuItem.Image = CType(resources.GetObject("GToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GToolStripMenuItem.Name = "GToolStripMenuItem"
        Me.GToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.GToolStripMenuItem.Text = "Género"
        '
        'ViviendaToolStripMenuItem
        '
        Me.ViviendaToolStripMenuItem.Image = CType(resources.GetObject("ViviendaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViviendaToolStripMenuItem.Name = "ViviendaToolStripMenuItem"
        Me.ViviendaToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ViviendaToolStripMenuItem.Text = "Vivienda"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarInformaciónExternaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 24)
        Me.MenuStrip1.TabIndex = 112
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModificarInformaciónExternaToolStripMenuItem
        '
        Me.ModificarInformaciónExternaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GToolStripMenuItem1})
        Me.ModificarInformaciónExternaToolStripMenuItem.Image = CType(resources.GetObject("ModificarInformaciónExternaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModificarInformaciónExternaToolStripMenuItem.Name = "ModificarInformaciónExternaToolStripMenuItem"
        Me.ModificarInformaciónExternaToolStripMenuItem.Size = New System.Drawing.Size(195, 20)
        Me.ModificarInformaciónExternaToolStripMenuItem.Text = "Modificar información externa"
        '
        'GToolStripMenuItem1
        '
        Me.GToolStripMenuItem1.Image = CType(resources.GetObject("GToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GToolStripMenuItem1.Name = "GToolStripMenuItem1"
        Me.GToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.GToolStripMenuItem1.Text = "Género"
        '
        'FrmVisitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 434)
        Me.Controls.Add(Me.CbGeneroD)
        Me.Controls.Add(Me.LbIdGenero)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.DGVVisitante)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbIneVis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbTelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbMaterno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbPaterno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbNombreVis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbIdVisitanteD)
        Me.Controls.Add(Me.LbIdVisitante)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmVisitante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visitante"
        CType(Me.DGVVisitante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbIdVisitante As Label
    Friend WithEvents TbIdVisitanteD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbNombreVis As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPaterno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbMaterno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbIneVis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents DGVVisitante As System.Windows.Forms.DataGridView
    Friend WithEvents CbGeneroD As System.Windows.Forms.ComboBox
    Friend WithEvents LbIdGenero As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ModiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViviendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModificarInformaciónExternaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
