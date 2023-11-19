<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHabitante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHabitante))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LbIdVivienda = New System.Windows.Forms.Label()
        Me.CbGeneroD = New System.Windows.Forms.ComboBox()
        Me.LbIdGenero = New System.Windows.Forms.Label()
        Me.CbViviendaD = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbIdHabitante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbIneHab = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbTelefonoHab = New System.Windows.Forms.TextBox()
        Me.TbPaterno = New System.Windows.Forms.TextBox()
        Me.TbMaterno = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.DGVHabitante = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViviendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DTFechaNacimD = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGVHabitante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbIdVivienda
        '
        Me.LbIdVivienda.AutoSize = True
        Me.LbIdVivienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdVivienda.Location = New System.Drawing.Point(693, 131)
        Me.LbIdVivienda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbIdVivienda.Name = "LbIdVivienda"
        Me.LbIdVivienda.Size = New System.Drawing.Size(0, 16)
        Me.LbIdVivienda.TabIndex = 97
        '
        'CbGeneroD
        '
        Me.CbGeneroD.FormattingEnabled = True
        Me.CbGeneroD.Location = New System.Drawing.Point(458, 128)
        Me.CbGeneroD.Margin = New System.Windows.Forms.Padding(2)
        Me.CbGeneroD.Name = "CbGeneroD"
        Me.CbGeneroD.Size = New System.Drawing.Size(114, 21)
        Me.CbGeneroD.TabIndex = 94
        Me.CbGeneroD.Text = "Género"
        '
        'LbIdGenero
        '
        Me.LbIdGenero.AutoSize = True
        Me.LbIdGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdGenero.Location = New System.Drawing.Point(428, 129)
        Me.LbIdGenero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbIdGenero.Name = "LbIdGenero"
        Me.LbIdGenero.Size = New System.Drawing.Size(0, 16)
        Me.LbIdGenero.TabIndex = 93
        '
        'CbViviendaD
        '
        Me.CbViviendaD.FormattingEnabled = True
        Me.CbViviendaD.Location = New System.Drawing.Point(732, 128)
        Me.CbViviendaD.Margin = New System.Windows.Forms.Padding(2)
        Me.CbViviendaD.Name = "CbViviendaD"
        Me.CbViviendaD.Size = New System.Drawing.Size(135, 21)
        Me.CbViviendaD.TabIndex = 98
        Me.CbViviendaD.Text = "Vivienda"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(617, 131)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "ID Vivienda:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(355, 131)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "ID Género:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 86)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "ID Habitante:"
        '
        'TbIdHabitante
        '
        Me.TbIdHabitante.Location = New System.Drawing.Point(116, 83)
        Me.TbIdHabitante.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIdHabitante.MaxLength = 5
        Me.TbIdHabitante.Name = "TbIdHabitante"
        Me.TbIdHabitante.Size = New System.Drawing.Size(50, 20)
        Me.TbIdHabitante.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(892, 33)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "HABITANTE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Fecha de nacimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 172)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "INE:"
        '
        'TbIneHab
        '
        Me.TbIneHab.Location = New System.Drawing.Point(85, 169)
        Me.TbIneHab.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIneHab.MaxLength = 13
        Me.TbIneHab.Name = "TbIneHab"
        Me.TbIneHab.Size = New System.Drawing.Size(129, 20)
        Me.TbIneHab.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(626, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Apellido Materno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 172)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Teléfono: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Nombre:"
        '
        'TbTelefonoHab
        '
        Me.TbTelefonoHab.Location = New System.Drawing.Point(326, 168)
        Me.TbTelefonoHab.Margin = New System.Windows.Forms.Padding(2)
        Me.TbTelefonoHab.MaxLength = 13
        Me.TbTelefonoHab.Name = "TbTelefonoHab"
        Me.TbTelefonoHab.Size = New System.Drawing.Size(142, 20)
        Me.TbTelefonoHab.TabIndex = 72
        '
        'TbPaterno
        '
        Me.TbPaterno.Location = New System.Drawing.Point(491, 83)
        Me.TbPaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.TbPaterno.MaxLength = 15
        Me.TbPaterno.Name = "TbPaterno"
        Me.TbPaterno.Size = New System.Drawing.Size(115, 20)
        Me.TbPaterno.TabIndex = 71
        '
        'TbMaterno
        '
        Me.TbMaterno.Location = New System.Drawing.Point(733, 86)
        Me.TbMaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.TbMaterno.MaxLength = 15
        Me.TbMaterno.Name = "TbMaterno"
        Me.TbMaterno.Size = New System.Drawing.Size(133, 20)
        Me.TbMaterno.TabIndex = 70
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(253, 83)
        Me.TbNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TbNombre.MaxLength = 20
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(124, 20)
        Me.TbNombre.TabIndex = 69
        '
        'DGVHabitante
        '
        Me.DGVHabitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHabitante.Location = New System.Drawing.Point(35, 230)
        Me.DGVHabitante.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVHabitante.Name = "DGVHabitante"
        Me.DGVHabitante.RowTemplate.Height = 28
        Me.DGVHabitante.Size = New System.Drawing.Size(758, 234)
        Me.DGVHabitante.TabIndex = 68
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 24)
        Me.MenuStrip1.TabIndex = 99
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(813, 408)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 56)
        Me.BtnSalir.TabIndex = 103
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(813, 348)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(55, 56)
        Me.BtnLimpiar.TabIndex = 102
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(812, 288)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(55, 56)
        Me.BtnBorrar.TabIndex = 101
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(812, 228)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(56, 56)
        Me.BtnGuardar.TabIndex = 100
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DTFechaNacimD
        '
        Me.DTFechaNacimD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaNacimD.Location = New System.Drawing.Point(167, 128)
        Me.DTFechaNacimD.Name = "DTFechaNacimD"
        Me.DTFechaNacimD.Size = New System.Drawing.Size(129, 20)
        Me.DTFechaNacimD.TabIndex = 104
        Me.DTFechaNacimD.Value = New Date(2021, 11, 21, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(733, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "No. de la vivienda"
        '
        'FrmHabitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 490)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTFechaNacimD)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LbIdVivienda)
        Me.Controls.Add(Me.CbGeneroD)
        Me.Controls.Add(Me.LbIdGenero)
        Me.Controls.Add(Me.CbViviendaD)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbIdHabitante)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbIneHab)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbTelefonoHab)
        Me.Controls.Add(Me.TbPaterno)
        Me.Controls.Add(Me.TbMaterno)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.DGVHabitante)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmHabitante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Habitante"
        CType(Me.DGVHabitante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LbIdVivienda As System.Windows.Forms.Label
    Friend WithEvents CbGeneroD As System.Windows.Forms.ComboBox
    Friend WithEvents LbIdGenero As System.Windows.Forms.Label
    Friend WithEvents CbViviendaD As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbIdHabitante As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbIneHab As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbTelefonoHab As System.Windows.Forms.TextBox
    Friend WithEvents TbPaterno As System.Windows.Forms.TextBox
    Friend WithEvents TbMaterno As System.Windows.Forms.TextBox
    Friend WithEvents TbNombre As System.Windows.Forms.TextBox
    Friend WithEvents DGVHabitante As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViviendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents DTFechaNacimD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
