<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFolio))
        Me.TbIdFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LbIdHabitante = New System.Windows.Forms.Label()
        Me.LbIdVisitante = New System.Windows.Forms.Label()
        Me.CbVisitanteD = New System.Windows.Forms.ComboBox()
        Me.CbEsHabitante = New System.Windows.Forms.CheckBox()
        Me.CbEsVisitante = New System.Windows.Forms.CheckBox()
        Me.LbIdCaseta = New System.Windows.Forms.Label()
        Me.CbCasetaD = New System.Windows.Forms.ComboBox()
        Me.DGVFolio = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModificarInformaciónExternaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CbHabitanteD = New System.Windows.Forms.ComboBox()
        Me.BtnConfirmSalida = New System.Windows.Forms.Button()
        Me.LbLeAtiende = New System.Windows.Forms.Label()
        Me.LbAtiendeNomD = New System.Windows.Forms.Label()
        Me.LbAtiendeApellD = New System.Windows.Forms.Label()
        Me.LbUsuarioSinCaseta = New System.Windows.Forms.Label()
        Me.LbNoHanSalidoD = New System.Windows.Forms.Label()
        Me.LbNoHanSalido = New System.Windows.Forms.Label()
        Me.LbTotalFolios = New System.Windows.Forms.Label()
        Me.LbTotalFoliosD = New System.Windows.Forms.Label()
        Me.LbCantHab = New System.Windows.Forms.Label()
        Me.LbCantHabD = New System.Windows.Forms.Label()
        Me.LbCantVis = New System.Windows.Forms.Label()
        Me.LbCantVisD = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbLlegoEnVehic = New System.Windows.Forms.CheckBox()
        Me.LbIdVehiculo = New System.Windows.Forms.Label()
        Me.CbMatriculaVeh = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbMarcaD = New System.Windows.Forms.Label()
        Me.LbColorD = New System.Windows.Forms.Label()
        CType(Me.DGVFolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbIdFolio
        '
        Me.TbIdFolio.Location = New System.Drawing.Point(80, 80)
        Me.TbIdFolio.Margin = New System.Windows.Forms.Padding(2)
        Me.TbIdFolio.MaxLength = 5
        Me.TbIdFolio.Name = "TbIdFolio"
        Me.TbIdFolio.Size = New System.Drawing.Size(63, 20)
        Me.TbIdFolio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id. Folio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(656, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Id. Caseta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(420, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Id. Visitante:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(162, 83)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Id. Habitante:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(910, 31)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "FOLIO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbIdHabitante
        '
        Me.LbIdHabitante.AutoSize = True
        Me.LbIdHabitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdHabitante.Location = New System.Drawing.Point(251, 80)
        Me.LbIdHabitante.Name = "LbIdHabitante"
        Me.LbIdHabitante.Size = New System.Drawing.Size(0, 16)
        Me.LbIdHabitante.TabIndex = 65
        '
        'LbIdVisitante
        '
        Me.LbIdVisitante.AutoSize = True
        Me.LbIdVisitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdVisitante.Location = New System.Drawing.Point(503, 81)
        Me.LbIdVisitante.Name = "LbIdVisitante"
        Me.LbIdVisitante.Size = New System.Drawing.Size(0, 16)
        Me.LbIdVisitante.TabIndex = 67
        '
        'CbVisitanteD
        '
        Me.CbVisitanteD.FormattingEnabled = True
        Me.CbVisitanteD.Location = New System.Drawing.Point(537, 79)
        Me.CbVisitanteD.Name = "CbVisitanteD"
        Me.CbVisitanteD.Size = New System.Drawing.Size(106, 21)
        Me.CbVisitanteD.TabIndex = 66
        '
        'CbEsHabitante
        '
        Me.CbEsHabitante.AutoSize = True
        Me.CbEsHabitante.Location = New System.Drawing.Point(287, 112)
        Me.CbEsHabitante.Name = "CbEsHabitante"
        Me.CbEsHabitante.Size = New System.Drawing.Size(85, 17)
        Me.CbEsHabitante.TabIndex = 68
        Me.CbEsHabitante.Text = "Es habitante"
        Me.CbEsHabitante.UseVisualStyleBackColor = True
        '
        'CbEsVisitante
        '
        Me.CbEsVisitante.AutoSize = True
        Me.CbEsVisitante.Location = New System.Drawing.Point(537, 112)
        Me.CbEsVisitante.Name = "CbEsVisitante"
        Me.CbEsVisitante.Size = New System.Drawing.Size(80, 17)
        Me.CbEsVisitante.TabIndex = 69
        Me.CbEsVisitante.Text = "Es visitante"
        Me.CbEsVisitante.UseVisualStyleBackColor = True
        '
        'LbIdCaseta
        '
        Me.LbIdCaseta.AutoSize = True
        Me.LbIdCaseta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdCaseta.Location = New System.Drawing.Point(726, 82)
        Me.LbIdCaseta.Name = "LbIdCaseta"
        Me.LbIdCaseta.Size = New System.Drawing.Size(0, 16)
        Me.LbIdCaseta.TabIndex = 71
        '
        'CbCasetaD
        '
        Me.CbCasetaD.FormattingEnabled = True
        Me.CbCasetaD.Location = New System.Drawing.Point(751, 79)
        Me.CbCasetaD.Name = "CbCasetaD"
        Me.CbCasetaD.Size = New System.Drawing.Size(138, 21)
        Me.CbCasetaD.TabIndex = 70
        Me.CbCasetaD.Text = "Caseta"
        '
        'DGVFolio
        '
        Me.DGVFolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFolio.Location = New System.Drawing.Point(25, 213)
        Me.DGVFolio.Name = "DGVFolio"
        Me.DGVFolio.Size = New System.Drawing.Size(782, 236)
        Me.DGVFolio.TabIndex = 73
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Location = New System.Drawing.Point(834, 393)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 56)
        Me.BtnSalir.TabIndex = 77
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(834, 333)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(55, 56)
        Me.BtnLimpiar.TabIndex = 76
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(833, 273)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(55, 56)
        Me.BtnBorrar.TabIndex = 75
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(833, 213)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(56, 56)
        Me.BtnGuardar.TabIndex = 74
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarInformaciónExternaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(910, 24)
        Me.MenuStrip1.TabIndex = 78
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModificarInformaciónExternaToolStripMenuItem
        '
        Me.ModificarInformaciónExternaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HabitanteToolStripMenuItem, Me.VisitanteToolStripMenuItem, Me.CasetaToolStripMenuItem, Me.VehToolStripMenuItem})
        Me.ModificarInformaciónExternaToolStripMenuItem.Image = CType(resources.GetObject("ModificarInformaciónExternaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModificarInformaciónExternaToolStripMenuItem.Name = "ModificarInformaciónExternaToolStripMenuItem"
        Me.ModificarInformaciónExternaToolStripMenuItem.Size = New System.Drawing.Size(195, 20)
        Me.ModificarInformaciónExternaToolStripMenuItem.Text = "Modificar información externa"
        '
        'HabitanteToolStripMenuItem
        '
        Me.HabitanteToolStripMenuItem.Image = CType(resources.GetObject("HabitanteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HabitanteToolStripMenuItem.Name = "HabitanteToolStripMenuItem"
        Me.HabitanteToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.HabitanteToolStripMenuItem.Text = "Habitante"
        '
        'VisitanteToolStripMenuItem
        '
        Me.VisitanteToolStripMenuItem.Image = CType(resources.GetObject("VisitanteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VisitanteToolStripMenuItem.Name = "VisitanteToolStripMenuItem"
        Me.VisitanteToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.VisitanteToolStripMenuItem.Text = "Visitante"
        '
        'CasetaToolStripMenuItem
        '
        Me.CasetaToolStripMenuItem.Image = CType(resources.GetObject("CasetaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CasetaToolStripMenuItem.Name = "CasetaToolStripMenuItem"
        Me.CasetaToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CasetaToolStripMenuItem.Text = "Caseta"
        '
        'VehToolStripMenuItem
        '
        Me.VehToolStripMenuItem.Image = CType(resources.GetObject("VehToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VehToolStripMenuItem.Name = "VehToolStripMenuItem"
        Me.VehToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.VehToolStripMenuItem.Text = "Vehículo"
        '
        'CbHabitanteD
        '
        Me.CbHabitanteD.FormattingEnabled = True
        Me.CbHabitanteD.Location = New System.Drawing.Point(287, 79)
        Me.CbHabitanteD.Name = "CbHabitanteD"
        Me.CbHabitanteD.Size = New System.Drawing.Size(109, 21)
        Me.CbHabitanteD.TabIndex = 79
        '
        'BtnConfirmSalida
        '
        Me.BtnConfirmSalida.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmSalida.Location = New System.Drawing.Point(748, 145)
        Me.BtnConfirmSalida.Name = "BtnConfirmSalida"
        Me.BtnConfirmSalida.Size = New System.Drawing.Size(131, 28)
        Me.BtnConfirmSalida.TabIndex = 80
        Me.BtnConfirmSalida.Text = "Confirmar salida"
        Me.BtnConfirmSalida.UseVisualStyleBackColor = True
        '
        'LbLeAtiende
        '
        Me.LbLeAtiende.AutoSize = True
        Me.LbLeAtiende.Location = New System.Drawing.Point(466, 152)
        Me.LbLeAtiende.Name = "LbLeAtiende"
        Me.LbLeAtiende.Size = New System.Drawing.Size(60, 13)
        Me.LbLeAtiende.TabIndex = 81
        Me.LbLeAtiende.Text = "Le atiende:"
        '
        'LbAtiendeNomD
        '
        Me.LbAtiendeNomD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAtiendeNomD.Location = New System.Drawing.Point(523, 153)
        Me.LbAtiendeNomD.Name = "LbAtiendeNomD"
        Me.LbAtiendeNomD.Size = New System.Drawing.Size(91, 14)
        Me.LbAtiendeNomD.TabIndex = 82
        Me.LbAtiendeNomD.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbAtiendeApellD
        '
        Me.LbAtiendeApellD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAtiendeApellD.Location = New System.Drawing.Point(637, 153)
        Me.LbAtiendeApellD.Name = "LbAtiendeApellD"
        Me.LbAtiendeApellD.Size = New System.Drawing.Size(105, 17)
        Me.LbAtiendeApellD.TabIndex = 83
        '
        'LbUsuarioSinCaseta
        '
        Me.LbUsuarioSinCaseta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuarioSinCaseta.ForeColor = System.Drawing.Color.DarkRed
        Me.LbUsuarioSinCaseta.Location = New System.Drawing.Point(3, 57)
        Me.LbUsuarioSinCaseta.Name = "LbUsuarioSinCaseta"
        Me.LbUsuarioSinCaseta.Size = New System.Drawing.Size(909, 19)
        Me.LbUsuarioSinCaseta.TabIndex = 84
        Me.LbUsuarioSinCaseta.Text = "USTED NO TIENE NINGUNA CASETA REGISTRADA, SOLAMENTE PUEDE VER LA INFORMACIÓN!"
        Me.LbUsuarioSinCaseta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbNoHanSalidoD
        '
        Me.LbNoHanSalidoD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNoHanSalidoD.Location = New System.Drawing.Point(752, 460)
        Me.LbNoHanSalidoD.Name = "LbNoHanSalidoD"
        Me.LbNoHanSalidoD.Size = New System.Drawing.Size(55, 15)
        Me.LbNoHanSalidoD.TabIndex = 85
        Me.LbNoHanSalidoD.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbNoHanSalido
        '
        Me.LbNoHanSalido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNoHanSalido.Location = New System.Drawing.Point(670, 461)
        Me.LbNoHanSalido.Name = "LbNoHanSalido"
        Me.LbNoHanSalido.Size = New System.Drawing.Size(106, 13)
        Me.LbNoHanSalido.TabIndex = 86
        Me.LbNoHanSalido.Text = "NO han salido:"
        Me.LbNoHanSalido.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbTotalFolios
        '
        Me.LbTotalFolios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalFolios.Location = New System.Drawing.Point(176, 460)
        Me.LbTotalFolios.Name = "LbTotalFolios"
        Me.LbTotalFolios.Size = New System.Drawing.Size(52, 13)
        Me.LbTotalFolios.TabIndex = 88
        Me.LbTotalFolios.Text = "Folios: "
        Me.LbTotalFolios.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbTotalFoliosD
        '
        Me.LbTotalFoliosD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalFoliosD.Location = New System.Drawing.Point(234, 460)
        Me.LbTotalFoliosD.Name = "LbTotalFoliosD"
        Me.LbTotalFoliosD.Size = New System.Drawing.Size(55, 15)
        Me.LbTotalFoliosD.TabIndex = 87
        '
        'LbCantHab
        '
        Me.LbCantHab.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCantHab.Location = New System.Drawing.Point(333, 460)
        Me.LbCantHab.Name = "LbCantHab"
        Me.LbCantHab.Size = New System.Drawing.Size(80, 15)
        Me.LbCantHab.TabIndex = 90
        Me.LbCantHab.Text = "Habitantes: "
        Me.LbCantHab.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbCantHabD
        '
        Me.LbCantHabD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCantHabD.Location = New System.Drawing.Point(419, 460)
        Me.LbCantHabD.Name = "LbCantHabD"
        Me.LbCantHabD.Size = New System.Drawing.Size(55, 15)
        Me.LbCantHabD.TabIndex = 89
        '
        'LbCantVis
        '
        Me.LbCantVis.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCantVis.Location = New System.Drawing.Point(502, 460)
        Me.LbCantVis.Name = "LbCantVis"
        Me.LbCantVis.Size = New System.Drawing.Size(80, 15)
        Me.LbCantVis.TabIndex = 92
        Me.LbCantVis.Text = "Visitantes: "
        Me.LbCantVis.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbCantVisD
        '
        Me.LbCantVisD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCantVisD.Location = New System.Drawing.Point(588, 460)
        Me.LbCantVisD.Name = "LbCantVisD"
        Me.LbCantVisD.Size = New System.Drawing.Size(55, 15)
        Me.LbCantVisD.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 459)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Totales: "
        '
        'CbLlegoEnVehic
        '
        Me.CbLlegoEnVehic.AutoSize = True
        Me.CbLlegoEnVehic.Location = New System.Drawing.Point(170, 152)
        Me.CbLlegoEnVehic.Name = "CbLlegoEnVehic"
        Me.CbLlegoEnVehic.Size = New System.Drawing.Size(37, 17)
        Me.CbLlegoEnVehic.TabIndex = 97
        Me.CbLlegoEnVehic.Text = "Sí"
        Me.CbLlegoEnVehic.UseVisualStyleBackColor = True
        '
        'LbIdVehiculo
        '
        Me.LbIdVehiculo.AutoSize = True
        Me.LbIdVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdVehiculo.Location = New System.Drawing.Point(235, 151)
        Me.LbIdVehiculo.Name = "LbIdVehiculo"
        Me.LbIdVehiculo.Size = New System.Drawing.Size(0, 16)
        Me.LbIdVehiculo.TabIndex = 96
        '
        'CbMatriculaVeh
        '
        Me.CbMatriculaVeh.FormattingEnabled = True
        Me.CbMatriculaVeh.Location = New System.Drawing.Point(274, 149)
        Me.CbMatriculaVeh.Name = "CbMatriculaVeh"
        Me.CbMatriculaVeh.Size = New System.Drawing.Size(145, 21)
        Me.CbMatriculaVeh.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 151)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "¿Llego en algún vehículo?"
        '
        'LbMarcaD
        '
        Me.LbMarcaD.AutoSize = True
        Me.LbMarcaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarcaD.Location = New System.Drawing.Point(271, 181)
        Me.LbMarcaD.Name = "LbMarcaD"
        Me.LbMarcaD.Size = New System.Drawing.Size(0, 15)
        Me.LbMarcaD.TabIndex = 98
        '
        'LbColorD
        '
        Me.LbColorD.AutoSize = True
        Me.LbColorD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbColorD.Location = New System.Drawing.Point(359, 181)
        Me.LbColorD.Name = "LbColorD"
        Me.LbColorD.Size = New System.Drawing.Size(0, 15)
        Me.LbColorD.TabIndex = 99
        '
        'FrmFolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 488)
        Me.Controls.Add(Me.LbColorD)
        Me.Controls.Add(Me.LbMarcaD)
        Me.Controls.Add(Me.CbLlegoEnVehic)
        Me.Controls.Add(Me.LbIdVehiculo)
        Me.Controls.Add(Me.CbMatriculaVeh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbCantVis)
        Me.Controls.Add(Me.LbCantVisD)
        Me.Controls.Add(Me.LbCantHab)
        Me.Controls.Add(Me.LbCantHabD)
        Me.Controls.Add(Me.LbTotalFolios)
        Me.Controls.Add(Me.LbTotalFoliosD)
        Me.Controls.Add(Me.LbNoHanSalido)
        Me.Controls.Add(Me.LbNoHanSalidoD)
        Me.Controls.Add(Me.LbUsuarioSinCaseta)
        Me.Controls.Add(Me.LbAtiendeApellD)
        Me.Controls.Add(Me.LbAtiendeNomD)
        Me.Controls.Add(Me.LbLeAtiende)
        Me.Controls.Add(Me.BtnConfirmSalida)
        Me.Controls.Add(Me.CbHabitanteD)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.DGVFolio)
        Me.Controls.Add(Me.LbIdCaseta)
        Me.Controls.Add(Me.CbCasetaD)
        Me.Controls.Add(Me.CbEsVisitante)
        Me.Controls.Add(Me.CbEsHabitante)
        Me.Controls.Add(Me.LbIdVisitante)
        Me.Controls.Add(Me.CbVisitanteD)
        Me.Controls.Add(Me.LbIdHabitante)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbIdFolio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmFolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folio"
        CType(Me.DGVFolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbIdFolio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LbIdHabitante As System.Windows.Forms.Label
    Friend WithEvents LbIdVisitante As System.Windows.Forms.Label
    Friend WithEvents CbVisitanteD As System.Windows.Forms.ComboBox
    Friend WithEvents CbEsHabitante As System.Windows.Forms.CheckBox
    Friend WithEvents CbEsVisitante As System.Windows.Forms.CheckBox
    Friend WithEvents LbIdCaseta As System.Windows.Forms.Label
    Friend WithEvents CbCasetaD As System.Windows.Forms.ComboBox
    Friend WithEvents DGVFolio As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModificarInformaciónExternaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabitanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CasetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CbHabitanteD As System.Windows.Forms.ComboBox
    Friend WithEvents BtnConfirmSalida As System.Windows.Forms.Button
    Friend WithEvents LbLeAtiende As System.Windows.Forms.Label
    Friend WithEvents LbAtiendeNomD As System.Windows.Forms.Label
    Friend WithEvents LbAtiendeApellD As System.Windows.Forms.Label
    Friend WithEvents LbUsuarioSinCaseta As System.Windows.Forms.Label
    Friend WithEvents LbNoHanSalidoD As System.Windows.Forms.Label
    Friend WithEvents LbNoHanSalido As System.Windows.Forms.Label
    Friend WithEvents LbTotalFolios As System.Windows.Forms.Label
    Friend WithEvents LbTotalFoliosD As System.Windows.Forms.Label
    Friend WithEvents LbCantHab As System.Windows.Forms.Label
    Friend WithEvents LbCantHabD As System.Windows.Forms.Label
    Friend WithEvents LbCantVis As System.Windows.Forms.Label
    Friend WithEvents LbCantVisD As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbLlegoEnVehic As System.Windows.Forms.CheckBox
    Friend WithEvents LbIdVehiculo As System.Windows.Forms.Label
    Friend WithEvents CbMatriculaVeh As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VehToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LbMarcaD As System.Windows.Forms.Label
    Friend WithEvents LbColorD As System.Windows.Forms.Label
End Class
