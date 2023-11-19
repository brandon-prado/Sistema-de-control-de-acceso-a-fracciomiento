<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenero))
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.TbGenero = New System.Windows.Forms.TextBox()
        Me.LbGenero = New System.Windows.Forms.Label()
        Me.TbIdGenero = New System.Windows.Forms.TextBox()
        Me.LbIdGenero = New System.Windows.Forms.Label()
        Me.DGVGenero = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTitulo
        '
        Me.LbTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitulo.Location = New System.Drawing.Point(0, 9)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(427, 25)
        Me.LbTitulo.TabIndex = 30
        Me.LbTitulo.Text = "GÉNERO"
        Me.LbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TbGenero
        '
        Me.TbGenero.Location = New System.Drawing.Point(262, 49)
        Me.TbGenero.MaxLength = 15
        Me.TbGenero.Name = "TbGenero"
        Me.TbGenero.Size = New System.Drawing.Size(94, 20)
        Me.TbGenero.TabIndex = 29
        '
        'LbGenero
        '
        Me.LbGenero.AutoSize = True
        Me.LbGenero.Location = New System.Drawing.Point(202, 52)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(45, 13)
        Me.LbGenero.TabIndex = 28
        Me.LbGenero.Text = "Género:"
        '
        'TbIdGenero
        '
        Me.TbIdGenero.Location = New System.Drawing.Point(87, 48)
        Me.TbIdGenero.MaxLength = 5
        Me.TbIdGenero.Name = "TbIdGenero"
        Me.TbIdGenero.Size = New System.Drawing.Size(67, 20)
        Me.TbIdGenero.TabIndex = 27
        '
        'LbIdGenero
        '
        Me.LbIdGenero.AutoSize = True
        Me.LbIdGenero.Location = New System.Drawing.Point(13, 51)
        Me.LbIdGenero.Name = "LbIdGenero"
        Me.LbIdGenero.Size = New System.Drawing.Size(60, 13)
        Me.LbIdGenero.TabIndex = 26
        Me.LbIdGenero.Text = "Id. Género:"
        '
        'DGVGenero
        '
        Me.DGVGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGenero.Location = New System.Drawing.Point(13, 84)
        Me.DGVGenero.Name = "DGVGenero"
        Me.DGVGenero.Size = New System.Drawing.Size(349, 110)
        Me.DGVGenero.TabIndex = 25
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(376, 160)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(33, 34)
        Me.BtnSalir.TabIndex = 77
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(376, 121)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(33, 34)
        Me.BtnLimpiar.TabIndex = 76
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(376, 83)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(33, 34)
        Me.BtnBorrar.TabIndex = 75
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(376, 45)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(33, 34)
        Me.BtnGuardar.TabIndex = 74
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 207)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LbTitulo)
        Me.Controls.Add(Me.TbGenero)
        Me.Controls.Add(Me.LbGenero)
        Me.Controls.Add(Me.TbIdGenero)
        Me.Controls.Add(Me.LbIdGenero)
        Me.Controls.Add(Me.DGVGenero)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmGenero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Género"
        CType(Me.DGVGenero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTitulo As Label
    Friend WithEvents TbGenero As TextBox
    Friend WithEvents LbGenero As Label
    Friend WithEvents TbIdGenero As TextBox
    Friend WithEvents LbIdGenero As Label
    Friend WithEvents DGVGenero As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
End Class
