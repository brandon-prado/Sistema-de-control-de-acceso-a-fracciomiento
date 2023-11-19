<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LbEmpleado = New System.Windows.Forms.Label()
        Me.LbContrasena = New System.Windows.Forms.Label()
        Me.TbEmpleado = New System.Windows.Forms.TextBox()
        Me.TbContrasena = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbMostrar = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.BtnIngresar, "BtnIngresar")
        Me.BtnIngresar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.BtnLimpiar, "BtnLimpiar")
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Crimson
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.BtnSalir, "BtnSalir")
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LbEmpleado
        '
        resources.ApplyResources(Me.LbEmpleado, "LbEmpleado")
        Me.LbEmpleado.Name = "LbEmpleado"
        '
        'LbContrasena
        '
        resources.ApplyResources(Me.LbContrasena, "LbContrasena")
        Me.LbContrasena.Name = "LbContrasena"
        '
        'TbEmpleado
        '
        resources.ApplyResources(Me.TbEmpleado, "TbEmpleado")
        Me.TbEmpleado.Name = "TbEmpleado"
        '
        'TbContrasena
        '
        resources.ApplyResources(Me.TbContrasena, "TbContrasena")
        Me.TbContrasena.Name = "TbContrasena"
        Me.TbContrasena.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'CbMostrar
        '
        resources.ApplyResources(Me.CbMostrar, "CbMostrar")
        Me.CbMostrar.Name = "CbMostrar"
        Me.CbMostrar.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CbMostrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbContrasena)
        Me.Controls.Add(Me.TbEmpleado)
        Me.Controls.Add(Me.LbContrasena)
        Me.Controls.Add(Me.LbEmpleado)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnIngresar)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LbEmpleado As Label
    Friend WithEvents LbContrasena As Label
    Friend WithEvents TbEmpleado As TextBox
    Friend WithEvents TbContrasena As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CbMostrar As CheckBox
End Class
