<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCaseta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCaseta))
        Me.TbDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVCaseta = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbIdCaseta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbIdEmpleado = New System.Windows.Forms.Label()
        Me.CbEmpleadoD = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModificarInformaciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbNombreCas = New System.Windows.Forms.Label()
        Me.TbNombreCas = New System.Windows.Forms.TextBox()
        CType(Me.DGVCaseta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbDireccion
        '
        Me.TbDireccion.Location = New System.Drawing.Point(218, 72)
        Me.TbDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.TbDireccion.MaxLength = 20
        Me.TbDireccion.Name = "TbDireccion"
        Me.TbDireccion.Size = New System.Drawing.Size(147, 20)
        Me.TbDireccion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dirección:"
        '
        'DGVCaseta
        '
        Me.DGVCaseta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCaseta.Location = New System.Drawing.Point(36, 155)
        Me.DGVCaseta.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVCaseta.Name = "DGVCaseta"
        Me.DGVCaseta.RowTemplate.Height = 28
        Me.DGVCaseta.Size = New System.Drawing.Size(546, 191)
        Me.DGVCaseta.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-6, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(623, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CASETA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TbIdCaseta
        '
        Me.TbIdCaseta.Location = New System.Drawing.Point(95, 72)
        Me.TbIdCaseta.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIdCaseta.MaxLength = 5
        Me.TbIdCaseta.Name = "TbIdCaseta"
        Me.TbIdCaseta.Size = New System.Drawing.Size(46, 20)
        Me.TbIdCaseta.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Id. Caseta:"
        '
        'LbIdEmpleado
        '
        Me.LbIdEmpleado.AutoSize = True
        Me.LbIdEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdEmpleado.Location = New System.Drawing.Point(118, 118)
        Me.LbIdEmpleado.Name = "LbIdEmpleado"
        Me.LbIdEmpleado.Size = New System.Drawing.Size(0, 16)
        Me.LbIdEmpleado.TabIndex = 68
        '
        'CbEmpleadoD
        '
        Me.CbEmpleadoD.FormattingEnabled = True
        Me.CbEmpleadoD.Location = New System.Drawing.Point(149, 117)
        Me.CbEmpleadoD.Name = "CbEmpleadoD"
        Me.CbEmpleadoD.Size = New System.Drawing.Size(130, 21)
        Me.CbEmpleadoD.TabIndex = 67
        Me.CbEmpleadoD.Text = "Empleado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Id. Empleado:"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(549, 112)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(33, 33)
        Me.BtnSalir.TabIndex = 73
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(512, 112)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(33, 33)
        Me.BtnLimpiar.TabIndex = 72
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(475, 112)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(33, 33)
        Me.BtnBorrar.TabIndex = 71
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(438, 112)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(33, 33)
        Me.BtnGuardar.TabIndex = 70
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarInformaciToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(623, 24)
        Me.MenuStrip1.TabIndex = 74
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModificarInformaciToolStripMenuItem
        '
        Me.ModificarInformaciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem})
        Me.ModificarInformaciToolStripMenuItem.Image = CType(resources.GetObject("ModificarInformaciToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModificarInformaciToolStripMenuItem.Name = "ModificarInformaciToolStripMenuItem"
        Me.ModificarInformaciToolStripMenuItem.Size = New System.Drawing.Size(195, 20)
        Me.ModificarInformaciToolStripMenuItem.Text = "Modificar información externa"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Image = CType(resources.GetObject("EmpleadoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'LbNombreCas
        '
        Me.LbNombreCas.AutoSize = True
        Me.LbNombreCas.Location = New System.Drawing.Point(394, 73)
        Me.LbNombreCas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNombreCas.Name = "LbNombreCas"
        Me.LbNombreCas.Size = New System.Drawing.Size(47, 13)
        Me.LbNombreCas.TabIndex = 76
        Me.LbNombreCas.Text = "Nombre:"
        '
        'TbNombreCas
        '
        Me.TbNombreCas.Location = New System.Drawing.Point(453, 71)
        Me.TbNombreCas.Margin = New System.Windows.Forms.Padding(2)
        Me.TbNombreCas.MaxLength = 20
        Me.TbNombreCas.Name = "TbNombreCas"
        Me.TbNombreCas.Size = New System.Drawing.Size(129, 20)
        Me.TbNombreCas.TabIndex = 75
        '
        'FrmCaseta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 376)
        Me.Controls.Add(Me.LbNombreCas)
        Me.Controls.Add(Me.TbNombreCas)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LbIdEmpleado)
        Me.Controls.Add(Me.CbEmpleadoD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbIdCaseta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVCaseta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbDireccion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmCaseta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caseta"
        CType(Me.DGVCaseta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbDireccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVCaseta As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TbIdCaseta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LbIdEmpleado As System.Windows.Forms.Label
    Friend WithEvents CbEmpleadoD As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModificarInformaciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LbNombreCas As System.Windows.Forms.Label
    Friend WithEvents TbNombreCas As System.Windows.Forms.TextBox
End Class
