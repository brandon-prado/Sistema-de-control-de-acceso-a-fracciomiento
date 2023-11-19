<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresa))
        Me.DGVEmpresa = New System.Windows.Forms.DataGridView()
        Me.LbIdEmpresa = New System.Windows.Forms.Label()
        Me.TbIdEmpresa = New System.Windows.Forms.TextBox()
        Me.TbNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.LbNombreEmpresa = New System.Windows.Forms.Label()
        Me.TbDireccEmpr = New System.Windows.Forms.TextBox()
        Me.LbDireccion = New System.Windows.Forms.Label()
        Me.TbNumEmpr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbCodPost = New System.Windows.Forms.TextBox()
        Me.LbCodPostal = New System.Windows.Forms.Label()
        Me.TbTelEmpr = New System.Windows.Forms.TextBox()
        Me.LbTelEmp = New System.Windows.Forms.Label()
        Me.TbCorreoEmpr = New System.Windows.Forms.TextBox()
        Me.LbCorreoEmpr = New System.Windows.Forms.Label()
        Me.TbRFCEmpr = New System.Windows.Forms.TextBox()
        Me.LbRFCEmpr = New System.Windows.Forms.Label()
        Me.TbPagWebEmpr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVEmpresa
        '
        Me.DGVEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEmpresa.Location = New System.Drawing.Point(25, 187)
        Me.DGVEmpresa.Name = "DGVEmpresa"
        Me.DGVEmpresa.Size = New System.Drawing.Size(688, 150)
        Me.DGVEmpresa.TabIndex = 4
        '
        'LbIdEmpresa
        '
        Me.LbIdEmpresa.AutoSize = True
        Me.LbIdEmpresa.Location = New System.Drawing.Point(22, 63)
        Me.LbIdEmpresa.Name = "LbIdEmpresa"
        Me.LbIdEmpresa.Size = New System.Drawing.Size(66, 13)
        Me.LbIdEmpresa.TabIndex = 5
        Me.LbIdEmpresa.Text = "Id. Empresa:"
        '
        'TbIdEmpresa
        '
        Me.TbIdEmpresa.Location = New System.Drawing.Point(103, 60)
        Me.TbIdEmpresa.MaxLength = 5
        Me.TbIdEmpresa.Name = "TbIdEmpresa"
        Me.TbIdEmpresa.Size = New System.Drawing.Size(63, 20)
        Me.TbIdEmpresa.TabIndex = 6
        '
        'TbNombreEmpresa
        '
        Me.TbNombreEmpresa.Location = New System.Drawing.Point(240, 60)
        Me.TbNombreEmpresa.MaxLength = 20
        Me.TbNombreEmpresa.Name = "TbNombreEmpresa"
        Me.TbNombreEmpresa.Size = New System.Drawing.Size(111, 20)
        Me.TbNombreEmpresa.TabIndex = 8
        '
        'LbNombreEmpresa
        '
        Me.LbNombreEmpresa.AutoSize = True
        Me.LbNombreEmpresa.Location = New System.Drawing.Point(181, 63)
        Me.LbNombreEmpresa.Name = "LbNombreEmpresa"
        Me.LbNombreEmpresa.Size = New System.Drawing.Size(47, 13)
        Me.LbNombreEmpresa.TabIndex = 7
        Me.LbNombreEmpresa.Text = "Nombre:"
        '
        'TbDireccEmpr
        '
        Me.TbDireccEmpr.Location = New System.Drawing.Point(583, 59)
        Me.TbDireccEmpr.MaxLength = 25
        Me.TbDireccEmpr.Name = "TbDireccEmpr"
        Me.TbDireccEmpr.Size = New System.Drawing.Size(128, 20)
        Me.TbDireccEmpr.TabIndex = 10
        '
        'LbDireccion
        '
        Me.LbDireccion.AutoSize = True
        Me.LbDireccion.Location = New System.Drawing.Point(514, 62)
        Me.LbDireccion.Name = "LbDireccion"
        Me.LbDireccion.Size = New System.Drawing.Size(55, 13)
        Me.LbDireccion.TabIndex = 9
        Me.LbDireccion.Text = "Dirección:"
        '
        'TbNumEmpr
        '
        Me.TbNumEmpr.Location = New System.Drawing.Point(50, 102)
        Me.TbNumEmpr.MaxLength = 7
        Me.TbNumEmpr.Name = "TbNumEmpr"
        Me.TbNumEmpr.Size = New System.Drawing.Size(64, 20)
        Me.TbNumEmpr.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "#:"
        '
        'TbCodPost
        '
        Me.TbCodPost.Location = New System.Drawing.Point(212, 102)
        Me.TbCodPost.MaxLength = 7
        Me.TbCodPost.Name = "TbCodPost"
        Me.TbCodPost.Size = New System.Drawing.Size(69, 20)
        Me.TbCodPost.TabIndex = 14
        '
        'LbCodPostal
        '
        Me.LbCodPostal.AutoSize = True
        Me.LbCodPostal.Location = New System.Drawing.Point(131, 105)
        Me.LbCodPostal.Name = "LbCodPostal"
        Me.LbCodPostal.Size = New System.Drawing.Size(74, 13)
        Me.LbCodPostal.TabIndex = 13
        Me.LbCodPostal.Text = "Código postal:"
        '
        'TbTelEmpr
        '
        Me.TbTelEmpr.Location = New System.Drawing.Point(354, 102)
        Me.TbTelEmpr.MaxLength = 14
        Me.TbTelEmpr.Name = "TbTelEmpr"
        Me.TbTelEmpr.Size = New System.Drawing.Size(126, 20)
        Me.TbTelEmpr.TabIndex = 16
        '
        'LbTelEmp
        '
        Me.LbTelEmp.AutoSize = True
        Me.LbTelEmp.Location = New System.Drawing.Point(295, 105)
        Me.LbTelEmp.Name = "LbTelEmp"
        Me.LbTelEmp.Size = New System.Drawing.Size(52, 13)
        Me.LbTelEmp.TabIndex = 15
        Me.LbTelEmp.Text = "Télefono:"
        '
        'TbCorreoEmpr
        '
        Me.TbCorreoEmpr.Location = New System.Drawing.Point(548, 102)
        Me.TbCorreoEmpr.MaxLength = 25
        Me.TbCorreoEmpr.Name = "TbCorreoEmpr"
        Me.TbCorreoEmpr.Size = New System.Drawing.Size(165, 20)
        Me.TbCorreoEmpr.TabIndex = 18
        '
        'LbCorreoEmpr
        '
        Me.LbCorreoEmpr.AutoSize = True
        Me.LbCorreoEmpr.Location = New System.Drawing.Point(497, 105)
        Me.LbCorreoEmpr.Name = "LbCorreoEmpr"
        Me.LbCorreoEmpr.Size = New System.Drawing.Size(41, 13)
        Me.LbCorreoEmpr.TabIndex = 17
        Me.LbCorreoEmpr.Text = "Correo:"
        '
        'TbRFCEmpr
        '
        Me.TbRFCEmpr.Location = New System.Drawing.Point(407, 60)
        Me.TbRFCEmpr.MaxLength = 13
        Me.TbRFCEmpr.Name = "TbRFCEmpr"
        Me.TbRFCEmpr.Size = New System.Drawing.Size(87, 20)
        Me.TbRFCEmpr.TabIndex = 20
        '
        'LbRFCEmpr
        '
        Me.LbRFCEmpr.AutoSize = True
        Me.LbRFCEmpr.Location = New System.Drawing.Point(369, 63)
        Me.LbRFCEmpr.Name = "LbRFCEmpr"
        Me.LbRFCEmpr.Size = New System.Drawing.Size(31, 13)
        Me.LbRFCEmpr.TabIndex = 19
        Me.LbRFCEmpr.Text = "RFC:"
        '
        'TbPagWebEmpr
        '
        Me.TbPagWebEmpr.Location = New System.Drawing.Point(101, 143)
        Me.TbPagWebEmpr.MaxLength = 25
        Me.TbPagWebEmpr.Name = "TbPagWebEmpr"
        Me.TbPagWebEmpr.Size = New System.Drawing.Size(165, 20)
        Me.TbPagWebEmpr.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Página web:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(728, 31)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "EMPRESA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(677, 143)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(34, 34)
        Me.BtnSalir.TabIndex = 77
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(630, 143)
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
        Me.BtnBorrar.Location = New System.Drawing.Point(583, 143)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(33, 35)
        Me.BtnBorrar.TabIndex = 75
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(536, 143)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(33, 34)
        Me.BtnGuardar.TabIndex = 74
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 359)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbPagWebEmpr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbRFCEmpr)
        Me.Controls.Add(Me.LbRFCEmpr)
        Me.Controls.Add(Me.TbCorreoEmpr)
        Me.Controls.Add(Me.LbCorreoEmpr)
        Me.Controls.Add(Me.TbTelEmpr)
        Me.Controls.Add(Me.LbTelEmp)
        Me.Controls.Add(Me.TbCodPost)
        Me.Controls.Add(Me.LbCodPostal)
        Me.Controls.Add(Me.TbNumEmpr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbDireccEmpr)
        Me.Controls.Add(Me.LbDireccion)
        Me.Controls.Add(Me.TbNombreEmpresa)
        Me.Controls.Add(Me.LbNombreEmpresa)
        Me.Controls.Add(Me.TbIdEmpresa)
        Me.Controls.Add(Me.LbIdEmpresa)
        Me.Controls.Add(Me.DGVEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        CType(Me.DGVEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVEmpresa As DataGridView
    Friend WithEvents LbIdEmpresa As Label
    Friend WithEvents TbIdEmpresa As TextBox
    Friend WithEvents TbNombreEmpresa As TextBox
    Friend WithEvents LbNombreEmpresa As Label
    Friend WithEvents TbDireccEmpr As TextBox
    Friend WithEvents LbDireccion As Label
    Friend WithEvents TbNumEmpr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbCodPost As TextBox
    Friend WithEvents LbCodPostal As Label
    Friend WithEvents TbTelEmpr As TextBox
    Friend WithEvents LbTelEmp As Label
    Friend WithEvents TbCorreoEmpr As TextBox
    Friend WithEvents LbCorreoEmpr As Label
    Friend WithEvents TbRFCEmpr As TextBox
    Friend WithEvents LbRFCEmpr As Label
    Friend WithEvents TbPagWebEmpr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
End Class
