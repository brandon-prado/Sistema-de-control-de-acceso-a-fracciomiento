<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.TbSueldo = New System.Windows.Forms.TextBox()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.TbMaternoEmpl = New System.Windows.Forms.TextBox()
        Me.TbIdEmpleado = New System.Windows.Forms.TextBox()
        Me.TbNombreEmpl = New System.Windows.Forms.TextBox()
        Me.TbPaternoEmpl = New System.Windows.Forms.TextBox()
        Me.TbIne = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVEmpleado = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbGeneroD = New System.Windows.Forms.ComboBox()
        Me.CbHoraInicioD = New System.Windows.Forms.ComboBox()
        Me.CbHoraFinD = New System.Windows.Forms.ComboBox()
        Me.CbEmpresaD = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbContrasena = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CbMostrar = New System.Windows.Forms.CheckBox()
        Me.LbIdGenero = New System.Windows.Forms.Label()
        Me.LbIdHorario = New System.Windows.Forms.Label()
        Me.LbIdEmpresa = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarInformaciónFaltanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnHorarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnaEmpresaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGVEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbSueldo
        '
        Me.TbSueldo.Location = New System.Drawing.Point(490, 196)
        Me.TbSueldo.Margin = New System.Windows.Forms.Padding(2)
        Me.TbSueldo.MaxLength = 5
        Me.TbSueldo.Name = "TbSueldo"
        Me.TbSueldo.Size = New System.Drawing.Size(104, 20)
        Me.TbSueldo.TabIndex = 28
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(77, 196)
        Me.TbTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.TbTelefono.MaxLength = 13
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(114, 20)
        Me.TbTelefono.TabIndex = 29
        '
        'TbMaternoEmpl
        '
        Me.TbMaternoEmpl.Location = New System.Drawing.Point(795, 100)
        Me.TbMaternoEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.TbMaternoEmpl.MaxLength = 15
        Me.TbMaternoEmpl.Name = "TbMaternoEmpl"
        Me.TbMaternoEmpl.Size = New System.Drawing.Size(118, 20)
        Me.TbMaternoEmpl.TabIndex = 30
        '
        'TbIdEmpleado
        '
        Me.TbIdEmpleado.Location = New System.Drawing.Point(96, 100)
        Me.TbIdEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIdEmpleado.MaxLength = 5
        Me.TbIdEmpleado.Name = "TbIdEmpleado"
        Me.TbIdEmpleado.Size = New System.Drawing.Size(67, 20)
        Me.TbIdEmpleado.TabIndex = 31
        '
        'TbNombreEmpl
        '
        Me.TbNombreEmpl.Location = New System.Drawing.Point(263, 100)
        Me.TbNombreEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.TbNombreEmpl.MaxLength = 20
        Me.TbNombreEmpl.Name = "TbNombreEmpl"
        Me.TbNombreEmpl.Size = New System.Drawing.Size(120, 20)
        Me.TbNombreEmpl.TabIndex = 32
        '
        'TbPaternoEmpl
        '
        Me.TbPaternoEmpl.Location = New System.Drawing.Point(542, 100)
        Me.TbPaternoEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.TbPaternoEmpl.MaxLength = 15
        Me.TbPaternoEmpl.Name = "TbPaternoEmpl"
        Me.TbPaternoEmpl.Size = New System.Drawing.Size(114, 20)
        Me.TbPaternoEmpl.TabIndex = 33
        '
        'TbIne
        '
        Me.TbIne.Location = New System.Drawing.Point(260, 196)
        Me.TbIne.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIne.MaxLength = 13
        Me.TbIne.Name = "TbIne"
        Me.TbIne.Size = New System.Drawing.Size(123, 20)
        Me.TbIne.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Id. Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(702, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 199)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Teléfono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(228, 199)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "INE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(433, 199)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Sueldo: $"
        '
        'DGVEmpleado
        '
        Me.DGVEmpleado.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGVEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVEmpleado.Location = New System.Drawing.Point(23, 264)
        Me.DGVEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVEmpleado.Name = "DGVEmpleado"
        Me.DGVEmpleado.RowTemplate.Height = 28
        Me.DGVEmpleado.Size = New System.Drawing.Size(812, 236)
        Me.DGVEmpleado.TabIndex = 42
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(858, 264)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(56, 56)
        Me.BtnGuardar.TabIndex = 43
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(858, 324)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(55, 56)
        Me.BtnBorrar.TabIndex = 44
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(859, 384)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(55, 56)
        Me.BtnLimpiar.TabIndex = 45
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(859, 444)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 56)
        Me.BtnSalir.TabIndex = 46
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(937, 31)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "EMPLEADO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 152)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Id. Género:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(301, 153)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Id. Horario:"
        '
        'CbGeneroD
        '
        Me.CbGeneroD.FormattingEnabled = True
        Me.CbGeneroD.Location = New System.Drawing.Point(133, 148)
        Me.CbGeneroD.Name = "CbGeneroD"
        Me.CbGeneroD.Size = New System.Drawing.Size(87, 21)
        Me.CbGeneroD.TabIndex = 54
        Me.CbGeneroD.Text = "Género"
        '
        'CbHoraInicioD
        '
        Me.CbHoraInicioD.FormattingEnabled = True
        Me.CbHoraInicioD.Items.AddRange(New Object() {""})
        Me.CbHoraInicioD.Location = New System.Drawing.Point(405, 150)
        Me.CbHoraInicioD.Name = "CbHoraInicioD"
        Me.CbHoraInicioD.Size = New System.Drawing.Size(97, 21)
        Me.CbHoraInicioD.TabIndex = 55
        Me.CbHoraInicioD.Text = "Entrada"
        '
        'CbHoraFinD
        '
        Me.CbHoraFinD.FormattingEnabled = True
        Me.CbHoraFinD.Location = New System.Drawing.Point(508, 149)
        Me.CbHoraFinD.Name = "CbHoraFinD"
        Me.CbHoraFinD.Size = New System.Drawing.Size(97, 21)
        Me.CbHoraFinD.TabIndex = 56
        Me.CbHoraFinD.Text = "Salida"
        '
        'CbEmpresaD
        '
        Me.CbEmpresaD.FormattingEnabled = True
        Me.CbEmpresaD.Items.AddRange(New Object() {"Ninguno"})
        Me.CbEmpresaD.Location = New System.Drawing.Point(785, 148)
        Me.CbEmpresaD.Name = "CbEmpresaD"
        Me.CbEmpresaD.Size = New System.Drawing.Size(128, 21)
        Me.CbEmpresaD.TabIndex = 59
        Me.CbEmpresaD.Text = "Empresa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(672, 152)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Id. Empresa:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(664, 199)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Contraseña:"
        '
        'TbContrasena
        '
        Me.TbContrasena.Location = New System.Drawing.Point(734, 196)
        Me.TbContrasena.Margin = New System.Windows.Forms.Padding(2)
        Me.TbContrasena.MaxLength = 15
        Me.TbContrasena.Name = "TbContrasena"
        Me.TbContrasena.Size = New System.Drawing.Size(128, 20)
        Me.TbContrasena.TabIndex = 60
        Me.TbContrasena.UseSystemPasswordChar = True
        '
        'CbMostrar
        '
        Me.CbMostrar.AutoSize = True
        Me.CbMostrar.Location = New System.Drawing.Point(734, 229)
        Me.CbMostrar.Name = "CbMostrar"
        Me.CbMostrar.Size = New System.Drawing.Size(100, 17)
        Me.CbMostrar.TabIndex = 62
        Me.CbMostrar.Text = "Mostrar/Ocultar"
        Me.CbMostrar.UseVisualStyleBackColor = True
        '
        'LbIdGenero
        '
        Me.LbIdGenero.AutoSize = True
        Me.LbIdGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdGenero.Location = New System.Drawing.Point(99, 150)
        Me.LbIdGenero.Name = "LbIdGenero"
        Me.LbIdGenero.Size = New System.Drawing.Size(0, 16)
        Me.LbIdGenero.TabIndex = 63
        '
        'LbIdHorario
        '
        Me.LbIdHorario.AutoSize = True
        Me.LbIdHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdHorario.Location = New System.Drawing.Point(368, 151)
        Me.LbIdHorario.Name = "LbIdHorario"
        Me.LbIdHorario.Size = New System.Drawing.Size(0, 16)
        Me.LbIdHorario.TabIndex = 64
        '
        'LbIdEmpresa
        '
        Me.LbIdEmpresa.AutoSize = True
        Me.LbIdEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdEmpresa.Location = New System.Drawing.Point(752, 150)
        Me.LbIdEmpresa.Name = "LbIdEmpresa"
        Me.LbIdEmpresa.Size = New System.Drawing.Size(0, 16)
        Me.LbIdEmpresa.TabIndex = 65
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarInformaciónFaltanteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(937, 24)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarInformaciónFaltanteToolStripMenuItem
        '
        Me.AgregarInformaciónFaltanteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AgregarUnHorarioToolStripMenuItem1, Me.AgregarUnaEmpresaToolStripMenuItem1})
        Me.AgregarInformaciónFaltanteToolStripMenuItem.Image = CType(resources.GetObject("AgregarInformaciónFaltanteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgregarInformaciónFaltanteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Teal
        Me.AgregarInformaciónFaltanteToolStripMenuItem.Name = "AgregarInformaciónFaltanteToolStripMenuItem"
        Me.AgregarInformaciónFaltanteToolStripMenuItem.Size = New System.Drawing.Size(195, 20)
        Me.AgregarInformaciónFaltanteToolStripMenuItem.Text = "Modificar información externa"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripMenuItem1.Text = "Género"
        '
        'AgregarUnHorarioToolStripMenuItem1
        '
        Me.AgregarUnHorarioToolStripMenuItem1.Image = CType(resources.GetObject("AgregarUnHorarioToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AgregarUnHorarioToolStripMenuItem1.Name = "AgregarUnHorarioToolStripMenuItem1"
        Me.AgregarUnHorarioToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.AgregarUnHorarioToolStripMenuItem1.Text = "Horario"
        '
        'AgregarUnaEmpresaToolStripMenuItem1
        '
        Me.AgregarUnaEmpresaToolStripMenuItem1.Image = CType(resources.GetObject("AgregarUnaEmpresaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AgregarUnaEmpresaToolStripMenuItem1.Name = "AgregarUnaEmpresaToolStripMenuItem1"
        Me.AgregarUnaEmpresaToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.AgregarUnaEmpresaToolStripMenuItem1.Text = "Empresa"
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 518)
        Me.Controls.Add(Me.LbIdEmpresa)
        Me.Controls.Add(Me.LbIdHorario)
        Me.Controls.Add(Me.LbIdGenero)
        Me.Controls.Add(Me.CbMostrar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TbContrasena)
        Me.Controls.Add(Me.CbEmpresaD)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CbHoraFinD)
        Me.Controls.Add(Me.CbHoraInicioD)
        Me.Controls.Add(Me.CbGeneroD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.DGVEmpleado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbIne)
        Me.Controls.Add(Me.TbPaternoEmpl)
        Me.Controls.Add(Me.TbNombreEmpl)
        Me.Controls.Add(Me.TbIdEmpleado)
        Me.Controls.Add(Me.TbMaternoEmpl)
        Me.Controls.Add(Me.TbTelefono)
        Me.Controls.Add(Me.TbSueldo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado"
        CType(Me.DGVEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbSueldo As TextBox
    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents TbMaternoEmpl As TextBox
    Friend WithEvents TbIdEmpleado As TextBox
    Friend WithEvents TbNombreEmpl As TextBox
    Friend WithEvents TbPaternoEmpl As TextBox
    Friend WithEvents TbIne As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DGVEmpleado As DataGridView
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CbGeneroD As ComboBox
    Friend WithEvents CbHoraInicioD As ComboBox
    Friend WithEvents CbHoraFinD As ComboBox
    Friend WithEvents CbEmpresaD As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TbContrasena As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CbMostrar As CheckBox
    Friend WithEvents LbIdGenero As Label
    Friend WithEvents LbIdHorario As Label
    Friend WithEvents LbIdEmpresa As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarInformaciónFaltanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarUnHorarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarUnaEmpresaToolStripMenuItem1 As ToolStripMenuItem
End Class
