<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.BtnCambiarUsuario = New System.Windows.Forms.Button()
        Me.BtnSalirMenu = New System.Windows.Forms.Button()
        Me.BtnEmpresa = New System.Windows.Forms.Button()
        Me.BtnHorario = New System.Windows.Forms.Button()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.BtnGenero = New System.Windows.Forms.Button()
        Me.BtnVivienda = New System.Windows.Forms.Button()
        Me.BtnVehiculo = New System.Windows.Forms.Button()
        Me.BtnCaseta = New System.Windows.Forms.Button()
        Me.BtnVisitante = New System.Windows.Forms.Button()
        Me.BtnHabitante = New System.Windows.Forms.Button()
        Me.BtnEmpleado = New System.Windows.Forms.Button()
        Me.BtnFolio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PBHelp = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTitulo
        '
        Me.LbTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitulo.Location = New System.Drawing.Point(-1, 18)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(736, 29)
        Me.LbTitulo.TabIndex = 0
        Me.LbTitulo.Text = "MENÚ PRINCIPAL"
        Me.LbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnCambiarUsuario
        '
        Me.BtnCambiarUsuario.Location = New System.Drawing.Point(565, 394)
        Me.BtnCambiarUsuario.Name = "BtnCambiarUsuario"
        Me.BtnCambiarUsuario.Size = New System.Drawing.Size(114, 23)
        Me.BtnCambiarUsuario.TabIndex = 7
        Me.BtnCambiarUsuario.Text = "Cerrar sesión"
        Me.BtnCambiarUsuario.UseVisualStyleBackColor = True
        '
        'BtnSalirMenu
        '
        Me.BtnSalirMenu.Location = New System.Drawing.Point(565, 433)
        Me.BtnSalirMenu.Name = "BtnSalirMenu"
        Me.BtnSalirMenu.Size = New System.Drawing.Size(114, 23)
        Me.BtnSalirMenu.TabIndex = 8
        Me.BtnSalirMenu.Text = "Salir"
        Me.BtnSalirMenu.UseVisualStyleBackColor = True
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.Location = New System.Drawing.Point(61, 184)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(75, 23)
        Me.BtnEmpresa.TabIndex = 9
        Me.BtnEmpresa.Text = "Empresa"
        Me.BtnEmpresa.UseVisualStyleBackColor = True
        '
        'BtnHorario
        '
        Me.BtnHorario.Location = New System.Drawing.Point(181, 184)
        Me.BtnHorario.Name = "BtnHorario"
        Me.BtnHorario.Size = New System.Drawing.Size(86, 23)
        Me.BtnHorario.TabIndex = 10
        Me.BtnHorario.Text = "Horario laboral"
        Me.BtnHorario.UseVisualStyleBackColor = True
        '
        'BtnColor
        '
        Me.BtnColor.Location = New System.Drawing.Point(319, 184)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(81, 23)
        Me.BtnColor.TabIndex = 11
        Me.BtnColor.Text = "Color"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'BtnGenero
        '
        Me.BtnGenero.Location = New System.Drawing.Point(450, 184)
        Me.BtnGenero.Name = "BtnGenero"
        Me.BtnGenero.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenero.TabIndex = 12
        Me.BtnGenero.Text = "Género"
        Me.BtnGenero.UseVisualStyleBackColor = True
        '
        'BtnVivienda
        '
        Me.BtnVivienda.Location = New System.Drawing.Point(585, 184)
        Me.BtnVivienda.Name = "BtnVivienda"
        Me.BtnVivienda.Size = New System.Drawing.Size(75, 23)
        Me.BtnVivienda.TabIndex = 13
        Me.BtnVivienda.Text = "Vivienda"
        Me.BtnVivienda.UseVisualStyleBackColor = True
        '
        'BtnVehiculo
        '
        Me.BtnVehiculo.Location = New System.Drawing.Point(449, 335)
        Me.BtnVehiculo.Name = "BtnVehiculo"
        Me.BtnVehiculo.Size = New System.Drawing.Size(75, 23)
        Me.BtnVehiculo.TabIndex = 18
        Me.BtnVehiculo.Text = "Vehículo"
        Me.BtnVehiculo.UseVisualStyleBackColor = True
        '
        'BtnCaseta
        '
        Me.BtnCaseta.Location = New System.Drawing.Point(585, 335)
        Me.BtnCaseta.Name = "BtnCaseta"
        Me.BtnCaseta.Size = New System.Drawing.Size(75, 23)
        Me.BtnCaseta.TabIndex = 17
        Me.BtnCaseta.Text = "Caseta"
        Me.BtnCaseta.UseVisualStyleBackColor = True
        '
        'BtnVisitante
        '
        Me.BtnVisitante.Location = New System.Drawing.Point(324, 335)
        Me.BtnVisitante.Name = "BtnVisitante"
        Me.BtnVisitante.Size = New System.Drawing.Size(75, 23)
        Me.BtnVisitante.TabIndex = 16
        Me.BtnVisitante.Text = "Visitante"
        Me.BtnVisitante.UseVisualStyleBackColor = True
        '
        'BtnHabitante
        '
        Me.BtnHabitante.Location = New System.Drawing.Point(187, 335)
        Me.BtnHabitante.Name = "BtnHabitante"
        Me.BtnHabitante.Size = New System.Drawing.Size(86, 23)
        Me.BtnHabitante.TabIndex = 15
        Me.BtnHabitante.Text = "Habitante"
        Me.BtnHabitante.UseVisualStyleBackColor = True
        '
        'BtnEmpleado
        '
        Me.BtnEmpleado.Location = New System.Drawing.Point(62, 335)
        Me.BtnEmpleado.Name = "BtnEmpleado"
        Me.BtnEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.BtnEmpleado.TabIndex = 14
        Me.BtnEmpleado.Text = "Empleado"
        Me.BtnEmpleado.UseVisualStyleBackColor = True
        '
        'BtnFolio
        '
        Me.BtnFolio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFolio.Location = New System.Drawing.Point(188, 405)
        Me.BtnFolio.Name = "BtnFolio"
        Me.BtnFolio.Size = New System.Drawing.Size(195, 49)
        Me.BtnFolio.TabIndex = 19
        Me.BtnFolio.Text = "Folio"
        Me.BtnFolio.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 80)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(189, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(319, 80)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 84)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(445, 80)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(86, 84)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(577, 80)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(58, 233)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(87, 84)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 26
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(181, 233)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(94, 84)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(312, 233)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(95, 84)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 28
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(569, 233)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(98, 84)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 29
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(438, 233)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(100, 84)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 30
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(61, 383)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(100, 92)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 31
        Me.PictureBox12.TabStop = False
        '
        'PBHelp
        '
        Me.PBHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBHelp.Image = CType(resources.GetObject("PBHelp.Image"), System.Drawing.Image)
        Me.PBHelp.Location = New System.Drawing.Point(456, 383)
        Me.PBHelp.Name = "PBHelp"
        Me.PBHelp.Size = New System.Drawing.Size(79, 78)
        Me.PBHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBHelp.TabIndex = 32
        Me.PBHelp.TabStop = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 499)
        Me.Controls.Add(Me.PBHelp)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnFolio)
        Me.Controls.Add(Me.BtnVehiculo)
        Me.Controls.Add(Me.BtnCaseta)
        Me.Controls.Add(Me.BtnVisitante)
        Me.Controls.Add(Me.BtnHabitante)
        Me.Controls.Add(Me.BtnEmpleado)
        Me.Controls.Add(Me.BtnVivienda)
        Me.Controls.Add(Me.BtnGenero)
        Me.Controls.Add(Me.BtnColor)
        Me.Controls.Add(Me.BtnHorario)
        Me.Controls.Add(Me.BtnEmpresa)
        Me.Controls.Add(Me.BtnSalirMenu)
        Me.Controls.Add(Me.BtnCambiarUsuario)
        Me.Controls.Add(Me.LbTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LbTitulo As Label
    Friend WithEvents BtnCambiarUsuario As Button
    Friend WithEvents BtnSalirMenu As Button
    Friend WithEvents BtnEmpresa As Button
    Friend WithEvents BtnHorario As Button
    Friend WithEvents BtnColor As Button
    Friend WithEvents BtnGenero As Button
    Friend WithEvents BtnVivienda As Button
    Friend WithEvents BtnVehiculo As Button
    Friend WithEvents BtnCaseta As Button
    Friend WithEvents BtnVisitante As Button
    Friend WithEvents BtnHabitante As Button
    Friend WithEvents BtnEmpleado As Button
    Friend WithEvents BtnFolio As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PBHelp As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
