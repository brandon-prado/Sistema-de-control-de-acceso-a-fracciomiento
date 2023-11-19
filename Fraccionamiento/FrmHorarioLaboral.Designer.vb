<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHorarioLaboral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHorarioLaboral))
        Me.LbHorLab = New System.Windows.Forms.Label()
        Me.TbIdHorarioLab = New System.Windows.Forms.TextBox()
        Me.CbTurnoMat = New System.Windows.Forms.CheckBox()
        Me.CbTurnoVesp = New System.Windows.Forms.CheckBox()
        Me.CbTurnoNoct = New System.Windows.Forms.CheckBox()
        Me.CbHoraInicio = New System.Windows.Forms.ComboBox()
        Me.LbHoraInicio = New System.Windows.Forms.Label()
        Me.LbHoraFin = New System.Windows.Forms.Label()
        Me.CbHoraFin = New System.Windows.Forms.ComboBox()
        Me.DGVHorario = New System.Windows.Forms.DataGridView()
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbHorLab
        '
        Me.LbHorLab.AutoSize = True
        Me.LbHorLab.Location = New System.Drawing.Point(26, 63)
        Me.LbHorLab.Name = "LbHorLab"
        Me.LbHorLab.Size = New System.Drawing.Size(59, 13)
        Me.LbHorLab.TabIndex = 0
        Me.LbHorLab.Text = "Id. Horario:"
        '
        'TbIdHorarioLab
        '
        Me.TbIdHorarioLab.Location = New System.Drawing.Point(89, 61)
        Me.TbIdHorarioLab.MaxLength = 5
        Me.TbIdHorarioLab.Name = "TbIdHorarioLab"
        Me.TbIdHorarioLab.Size = New System.Drawing.Size(59, 20)
        Me.TbIdHorarioLab.TabIndex = 1
        '
        'CbTurnoMat
        '
        Me.CbTurnoMat.AutoSize = True
        Me.CbTurnoMat.Location = New System.Drawing.Point(33, 132)
        Me.CbTurnoMat.Name = "CbTurnoMat"
        Me.CbTurnoMat.Size = New System.Drawing.Size(97, 17)
        Me.CbTurnoMat.TabIndex = 2
        Me.CbTurnoMat.Text = "Turno matutino"
        Me.CbTurnoMat.UseVisualStyleBackColor = True
        '
        'CbTurnoVesp
        '
        Me.CbTurnoVesp.AutoSize = True
        Me.CbTurnoVesp.Location = New System.Drawing.Point(225, 132)
        Me.CbTurnoVesp.Name = "CbTurnoVesp"
        Me.CbTurnoVesp.Size = New System.Drawing.Size(106, 17)
        Me.CbTurnoVesp.TabIndex = 3
        Me.CbTurnoVesp.Text = "Turno vespertino"
        Me.CbTurnoVesp.UseVisualStyleBackColor = True
        '
        'CbTurnoNoct
        '
        Me.CbTurnoNoct.AutoSize = True
        Me.CbTurnoNoct.Location = New System.Drawing.Point(438, 132)
        Me.CbTurnoNoct.Name = "CbTurnoNoct"
        Me.CbTurnoNoct.Size = New System.Drawing.Size(99, 17)
        Me.CbTurnoNoct.TabIndex = 4
        Me.CbTurnoNoct.Text = "Turno nocturno"
        Me.CbTurnoNoct.UseVisualStyleBackColor = True
        '
        'CbHoraInicio
        '
        Me.CbHoraInicio.FormattingEnabled = True
        Me.CbHoraInicio.Items.AddRange(New Object() {"12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00"})
        Me.CbHoraInicio.Location = New System.Drawing.Point(373, 60)
        Me.CbHoraInicio.MaxLength = 5
        Me.CbHoraInicio.Name = "CbHoraInicio"
        Me.CbHoraInicio.Size = New System.Drawing.Size(164, 21)
        Me.CbHoraInicio.TabIndex = 5
        Me.CbHoraInicio.Text = "Selecciona entrada"
        '
        'LbHoraInicio
        '
        Me.LbHoraInicio.AutoSize = True
        Me.LbHoraInicio.Location = New System.Drawing.Point(256, 63)
        Me.LbHoraInicio.Name = "LbHoraInicio"
        Me.LbHoraInicio.Size = New System.Drawing.Size(75, 13)
        Me.LbHoraInicio.TabIndex = 6
        Me.LbHoraInicio.Text = "Hora de inicio:"
        '
        'LbHoraFin
        '
        Me.LbHoraFin.AutoSize = True
        Me.LbHoraFin.Location = New System.Drawing.Point(256, 99)
        Me.LbHoraFin.Name = "LbHoraFin"
        Me.LbHoraFin.Size = New System.Drawing.Size(62, 13)
        Me.LbHoraFin.TabIndex = 8
        Me.LbHoraFin.Text = "Hora de fin:"
        '
        'CbHoraFin
        '
        Me.CbHoraFin.FormattingEnabled = True
        Me.CbHoraFin.Items.AddRange(New Object() {"12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00"})
        Me.CbHoraFin.Location = New System.Drawing.Point(373, 99)
        Me.CbHoraFin.MaxLength = 5
        Me.CbHoraFin.Name = "CbHoraFin"
        Me.CbHoraFin.Size = New System.Drawing.Size(164, 21)
        Me.CbHoraFin.TabIndex = 7
        Me.CbHoraFin.Text = "Selecciona salida"
        '
        'DGVHorario
        '
        Me.DGVHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHorario.Location = New System.Drawing.Point(33, 165)
        Me.DGVHorario.Name = "DGVHorario"
        Me.DGVHorario.Size = New System.Drawing.Size(504, 140)
        Me.DGVHorario.TabIndex = 9
        '
        'LbTitulo
        '
        Me.LbTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitulo.Location = New System.Drawing.Point(0, 9)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(596, 31)
        Me.LbTitulo.TabIndex = 13
        Me.LbTitulo.Text = "HORARIO LABORAL"
        Me.LbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(550, 273)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(33, 32)
        Me.BtnSalir.TabIndex = 77
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(550, 238)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(33, 31)
        Me.BtnLimpiar.TabIndex = 76
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(550, 202)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(33, 32)
        Me.BtnBorrar.TabIndex = 75
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(550, 165)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(33, 33)
        Me.BtnGuardar.TabIndex = 74
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmHorarioLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 325)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LbTitulo)
        Me.Controls.Add(Me.DGVHorario)
        Me.Controls.Add(Me.LbHoraFin)
        Me.Controls.Add(Me.CbHoraFin)
        Me.Controls.Add(Me.LbHoraInicio)
        Me.Controls.Add(Me.CbHoraInicio)
        Me.Controls.Add(Me.CbTurnoNoct)
        Me.Controls.Add(Me.CbTurnoVesp)
        Me.Controls.Add(Me.CbTurnoMat)
        Me.Controls.Add(Me.TbIdHorarioLab)
        Me.Controls.Add(Me.LbHorLab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmHorarioLaboral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horario laboral"
        CType(Me.DGVHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbHorLab As Label
    Friend WithEvents TbIdHorarioLab As TextBox
    Friend WithEvents CbTurnoMat As CheckBox
    Friend WithEvents CbTurnoVesp As CheckBox
    Friend WithEvents CbTurnoNoct As CheckBox
    Friend WithEvents CbHoraInicio As ComboBox
    Friend WithEvents LbHoraInicio As Label
    Friend WithEvents LbHoraFin As Label
    Friend WithEvents CbHoraFin As ComboBox
    Friend WithEvents DGVHorario As DataGridView
    Friend WithEvents LbTitulo As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
End Class
