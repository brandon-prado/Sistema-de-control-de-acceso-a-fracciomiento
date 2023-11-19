<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVehiculo))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdVehiculo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbMatricula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbMarca = New System.Windows.Forms.TextBox()
        Me.DGVVehic = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbIdColor = New System.Windows.Forms.Label()
        Me.CbColorD = New System.Windows.Forms.ComboBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModificarInformaciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CbHabitanteD = New System.Windows.Forms.ComboBox()
        Me.CbEsVisitante = New System.Windows.Forms.CheckBox()
        Me.CbEsHabitante = New System.Windows.Forms.CheckBox()
        Me.LbIdVisitante = New System.Windows.Forms.Label()
        Me.CbVisitanteD = New System.Windows.Forms.ComboBox()
        Me.LbIdHabitante = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGVVehic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(647, 31)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "VEHÍCULO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Id. Vehiculo:"
        '
        'TbIdVehiculo
        '
        Me.TbIdVehiculo.Location = New System.Drawing.Point(92, 79)
        Me.TbIdVehiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIdVehiculo.Name = "TbIdVehiculo"
        Me.TbIdVehiculo.Size = New System.Drawing.Size(48, 20)
        Me.TbIdVehiculo.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Matrícula:"
        '
        'TbMatricula
        '
        Me.TbMatricula.Location = New System.Drawing.Point(211, 79)
        Me.TbMatricula.Margin = New System.Windows.Forms.Padding(2)
        Me.TbMatricula.Name = "TbMatricula"
        Me.TbMatricula.Size = New System.Drawing.Size(89, 20)
        Me.TbMatricula.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Marca:"
        '
        'TbMarca
        '
        Me.TbMarca.Location = New System.Drawing.Point(359, 79)
        Me.TbMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.TbMarca.Name = "TbMarca"
        Me.TbMarca.Size = New System.Drawing.Size(89, 20)
        Me.TbMarca.TabIndex = 54
        '
        'DGVVehic
        '
        Me.DGVVehic.AllowUserToOrderColumns = True
        Me.DGVVehic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehic.Location = New System.Drawing.Point(25, 173)
        Me.DGVVehic.Name = "DGVVehic"
        Me.DGVVehic.Size = New System.Drawing.Size(603, 168)
        Me.DGVVehic.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Color:"
        '
        'LbIdColor
        '
        Me.LbIdColor.AutoSize = True
        Me.LbIdColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdColor.Location = New System.Drawing.Point(503, 80)
        Me.LbIdColor.Name = "LbIdColor"
        Me.LbIdColor.Size = New System.Drawing.Size(0, 16)
        Me.LbIdColor.TabIndex = 65
        '
        'CbColorD
        '
        Me.CbColorD.FormattingEnabled = True
        Me.CbColorD.Location = New System.Drawing.Point(541, 78)
        Me.CbColorD.Name = "CbColorD"
        Me.CbColorD.Size = New System.Drawing.Size(87, 21)
        Me.CbColorD.TabIndex = 64
        Me.CbColorD.Text = "Colores"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(595, 132)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(33, 31)
        Me.BtnSalir.TabIndex = 69
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(558, 132)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(33, 31)
        Me.BtnLimpiar.TabIndex = 68
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(521, 132)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(33, 32)
        Me.BtnBorrar.TabIndex = 67
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(484, 132)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(33, 33)
        Me.BtnGuardar.TabIndex = 66
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarInformaciToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 24)
        Me.MenuStrip1.TabIndex = 70
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModificarInformaciToolStripMenuItem
        '
        Me.ModificarInformaciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem})
        Me.ModificarInformaciToolStripMenuItem.Image = CType(resources.GetObject("ModificarInformaciToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModificarInformaciToolStripMenuItem.Name = "ModificarInformaciToolStripMenuItem"
        Me.ModificarInformaciToolStripMenuItem.Size = New System.Drawing.Size(195, 20)
        Me.ModificarInformaciToolStripMenuItem.Text = "Modificar información externa"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Image = CType(resources.GetObject("ColorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'CbHabitanteD
        '
        Me.CbHabitanteD.FormattingEnabled = True
        Me.CbHabitanteD.Location = New System.Drawing.Point(129, 117)
        Me.CbHabitanteD.Name = "CbHabitanteD"
        Me.CbHabitanteD.Size = New System.Drawing.Size(117, 21)
        Me.CbHabitanteD.TabIndex = 87
        '
        'CbEsVisitante
        '
        Me.CbEsVisitante.AutoSize = True
        Me.CbEsVisitante.Location = New System.Drawing.Point(318, 148)
        Me.CbEsVisitante.Name = "CbEsVisitante"
        Me.CbEsVisitante.Size = New System.Drawing.Size(80, 17)
        Me.CbEsVisitante.TabIndex = 86
        Me.CbEsVisitante.Text = "Es visitante"
        Me.CbEsVisitante.UseVisualStyleBackColor = True
        '
        'CbEsHabitante
        '
        Me.CbEsHabitante.AutoSize = True
        Me.CbEsHabitante.Location = New System.Drawing.Point(129, 148)
        Me.CbEsHabitante.Name = "CbEsHabitante"
        Me.CbEsHabitante.Size = New System.Drawing.Size(85, 17)
        Me.CbEsHabitante.TabIndex = 85
        Me.CbEsHabitante.Text = "Es habitante"
        Me.CbEsHabitante.UseVisualStyleBackColor = True
        '
        'LbIdVisitante
        '
        Me.LbIdVisitante.AutoSize = True
        Me.LbIdVisitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdVisitante.Location = New System.Drawing.Point(284, 117)
        Me.LbIdVisitante.Name = "LbIdVisitante"
        Me.LbIdVisitante.Size = New System.Drawing.Size(0, 16)
        Me.LbIdVisitante.TabIndex = 84
        '
        'CbVisitanteD
        '
        Me.CbVisitanteD.FormattingEnabled = True
        Me.CbVisitanteD.Location = New System.Drawing.Point(318, 115)
        Me.CbVisitanteD.Name = "CbVisitanteD"
        Me.CbVisitanteD.Size = New System.Drawing.Size(107, 21)
        Me.CbVisitanteD.TabIndex = 83
        '
        'LbIdHabitante
        '
        Me.LbIdHabitante.AutoSize = True
        Me.LbIdHabitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdHabitante.Location = New System.Drawing.Point(93, 118)
        Me.LbIdHabitante.Name = "LbIdHabitante"
        Me.LbIdHabitante.Size = New System.Drawing.Size(0, 16)
        Me.LbIdHabitante.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "¿Dueño?"
        '
        'FrmVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 353)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbHabitanteD)
        Me.Controls.Add(Me.CbEsVisitante)
        Me.Controls.Add(Me.CbEsHabitante)
        Me.Controls.Add(Me.LbIdVisitante)
        Me.Controls.Add(Me.CbVisitanteD)
        Me.Controls.Add(Me.LbIdHabitante)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LbIdColor)
        Me.Controls.Add(Me.CbColorD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVVehic)
        Me.Controls.Add(Me.TbMarca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbMatricula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbIdVehiculo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehiculo"
        CType(Me.DGVVehic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdVehiculo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbMatricula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbMarca As TextBox
    Friend WithEvents DGVVehic As DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbIdColor As System.Windows.Forms.Label
    Friend WithEvents CbColorD As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModificarInformaciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CbHabitanteD As System.Windows.Forms.ComboBox
    Friend WithEvents CbEsVisitante As System.Windows.Forms.CheckBox
    Friend WithEvents CbEsHabitante As System.Windows.Forms.CheckBox
    Friend WithEvents LbIdVisitante As System.Windows.Forms.Label
    Friend WithEvents CbVisitanteD As System.Windows.Forms.ComboBox
    Friend WithEvents LbIdHabitante As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
