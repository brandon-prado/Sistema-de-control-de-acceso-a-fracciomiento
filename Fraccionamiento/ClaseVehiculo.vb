Imports Oracle.DataAccess.Client

Public Class ClaseVehiculo
    'VARIABLES UTILIZADAS EN EL FORMULARIO VEHÍCULO
    Private idVehiculo As Integer
    Private idColor As Integer
    Private idHabitante As Integer
    Private idVisitante As Integer
    Private matricula As String
    Private marca As String
    Private esHabitante As Boolean
    Private esVisitante As Boolean
    '************************************TABLA VEHÍCULO***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA VEHÍCULO--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí inicializamos los datos
        idVehiculo = 0
        idColor = 0
        idHabitante = 0
        idVisitante = 0
        matricula = ""
        marca = ""
        esHabitante = False
        esVisitante = False

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA VEHÍCULO
    Public Sub New(ByVal elIdVehiculo As Integer, ByVal elIdColor As Integer, ByVal elIdHab As Integer, ByVal elIdVis As Integer, ByVal laMatricula As String, ByVal laMarca As String, ByVal esHab As Boolean, ByVal esVis As Boolean)
        'Aquí recibimos los datos
        idVehiculo = elIdVehiculo
        idColor = elIdColor
        idHabitante = elIdHab
        idVisitante = elIdVis
        matricula = laMatricula
        marca = laMarca
        esHabitante = esHab
        esVisitante = esVis

    End Sub

    '-------------------------MÉTODOS GET Y SET DE LA TABLA VEHÍCULO--------------------------------------
    'Métodos get y set TABLA VEHÍCULO
    Public Property getSetIdVehiculo() As Integer
        Get
            Return idVehiculo
        End Get
        Set(ByVal Value As Integer)
            idVehiculo = Value
        End Set
    End Property

    Public Property getSetIdColor() As Integer
        Get
            Return idColor
        End Get
        Set(ByVal Value As Integer)
            idColor = Value
        End Set
    End Property

    Public Property getSetIdHabitante() As Integer
        Get
            Return idHabitante
        End Get
        Set(ByVal Value As Integer)
            idHabitante = Value
        End Set
    End Property

    Public Property getSetIdVisitante() As Integer
        Get
            Return idVisitante
        End Get
        Set(ByVal Value As Integer)
            idVisitante = Value
        End Set
    End Property

    Public Property getSetMatricula() As String
        Get
            Return matricula
        End Get
        Set(ByVal Value As String)
            matricula = Value
        End Set
    End Property

    Public Property getSetMarca() As String
        Get
            Return marca
        End Get
        Set(ByVal Value As String)
            marca = Value
        End Set
    End Property

    Public Property getSetEsHabitante() As Boolean
        Get
            Return esHabitante
        End Get
        Set(ByVal Value As Boolean)
            esHabitante = Value
        End Set
    End Property

    Public Property getSetEsVisitante() As Boolean
        Get
            Return esVisitante
        End Get
        Set(ByVal Value As Boolean)
            esVisitante = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA VEHÍCULO
    Public Function consultaTodosVehic() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los colores registrados en la tabla de VEHÍCULO
        ' para llenar el DGV correspondiente
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "Select id_vehiculo As ID, id_habitante As ""ID. HAB."", id_visitante As ""ID. VIS."", dueno_HabVis AS ""DUEÑO"", matricula As ""MATRÍCULA"", marca As MARCA, color As COLOR " &
                 "FROM Vehiculo v, Color c " &
                 "WHERE v.id_color = c.id_color " &
                 "ORDER BY id_vehiculo ASC"

        consultaTodosVehic = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO VEHÍCULO POR MEDIO DEL MÉTODO CONSULTATODOSVEHIC()
    Public Sub PoblarDataGridVehic(ByVal DGVVehic As DataGridView)
        'Método que lee todos los VEHÍCULOS del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVVehic.DataSource = consultaTodosVehic()

        'Con el refresh actualiza el contenido del DGV

        DGVVehic.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVVehic.Columns.Item(0).Width = 50
        DGVVehic.Columns.Item(1).Width = 73
        DGVVehic.Columns.Item(2).Width = 73
        DGVVehic.Columns.Item(3).Width = 88
        DGVVehic.Columns.Item(4).Width = 88
        DGVVehic.Columns.Item(5).Width = 88
        DGVVehic.Columns.Item(6).Width = 80
    End Sub

    'MÉTODO QUE INSERTA REGISTROS A LA TABLA VEHÍCULO
    'Inserta nuevo VEHÍCULO en la tabla correspondiente
    'la tabla tiene 4 atributos, por lo tanto se requieren de 4 valores
    Public Sub insertaVehiculo()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If esHabitante = True And esVisitante = False Then
            'Realiza inserción de datos de habitante
            strSql = "INSERT INTO Vehiculo (id_vehiculo, id_color, id_habitante, id_visitante, matricula, marca, dueno_HabVis) VALUES(" & idVehiculo & ", " & idColor & ", " & idHabitante & ", null, '" & matricula & "', '" & marca & "', 'HABITANTE')"
            xCnx.objetoCommand(strSql)
        ElseIf esHabitante = False And esVisitante = True Then
            'Realiza inserción de datos de habitante
            strSql = "INSERT INTO Vehiculo (id_vehiculo, id_color, id_habitante, id_visitante, matricula, marca, dueno_HabVis) VALUES(" & idVehiculo & ", " & idColor & ", null, " & idVisitante & ", '" & matricula & "', '" & marca & "', 'VISITANTE')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos para el vehículo, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE LA TABLA VEHÍCULO
    'Actualiza datos de un VEHÍCULO específico
    Public Sub actualizaVehiculo()
        Dim strSql As String
        Dim xCnx As New Oracle
        If esHabitante = True And esVisitante = False Then
            strSql = "UPDATE Vehiculo SET id_color = " & idColor & ", id_habitante = " & idHabitante & ", id_visitante = null, matricula = '" & matricula & "', marca = '" & marca & "', dueno_HabVis = 'HABITANTE' " &
                     "WHERE id_vehiculo = " & idVehiculo
            xCnx.objetoCommand(strSql)
        ElseIf esHabitante = False And esVisitante = True Then
            strSql = "UPDATE Vehiculo SET id_color = " & idColor & ", id_habitante = null, id_visitante = " & idVisitante & ", matricula = '" & matricula & "', marca = '" & marca & "', dueno_HabVis = 'VISITANTE' " &
                     "WHERE id_vehiculo = " & idVehiculo
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para el vehículo !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA UN VEHÍCULO EN ESPECIFICO DE LA TABLA VEHÍCULO Y REGRESA TRUE O FALSE
    'Consulta un VEHÍCULO en específico
    Public Function consultaUnIdVehic() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_vehiculo FROM Vehiculo " &
                 "WHERE id_vehiculo = " & idVehiculo

        consultaUnIdVehic = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdVehic = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY FOLIOS QUE DEPENDEN DE ALGÚN VEHÍCULO
    Public Function validaVehicFolio() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Folio " &
                 " WHERE id_vehiculo = " & idVehiculo
        validaVehicFolio = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaVehicFolio = True
        End If
    End Function

    'MÉTODO QUE ELIMINA REGISTROS (ID) DE LA TABLA VEHÍCULO
    Public Sub eliminarVehiculo()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idVehiculo <> 0 Then
            strSql = "DELETE FROM Vehiculo " &
                     " WHERE id_vehiculo = " & idVehiculo
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DEL VEHÍCULO !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE COLOR DE LA TABLA VEHÍCULO
    Public Sub poblarComboColor()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT color FROM Color ORDER BY id_color"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmVehiculo.CbColorD
            .DataSource = xDT
            .DisplayMember = "id_color"
            .ValueMember = "color"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL COLOR EN LA TABLA VEHÍCULO
    Public Sub mostrarIdColor()
        Dim xDT As New DataTable

        If FrmVehiculo.CbColorD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_color FROM Color WHERE color = '" & FrmVehiculo.CbColorD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmVehiculo.LbIdColor.Text = registro("id_color").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE HABITANTE DE LA TABLA VEHÍCULO
    Public Sub poblarComboHabitante()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT nombre_hab FROM Habitante ORDER BY id_habitante"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmVehiculo.CbHabitanteD
            .DataSource = xDT
            .DisplayMember = "id_habitante"
            .ValueMember = "nombre_hab"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL HABITANTE EN LA TABLA VEHÍCULO
    Public Sub mostrarIdDelHabitante()
        Dim xDT As New DataTable

        If FrmVehiculo.CbHabitanteD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_habitante FROM Habitante WHERE nombre_hab = '" & FrmVehiculo.CbHabitanteD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmVehiculo.LbIdHabitante.Text = registro("id_habitante").ToString
            Next
        End If
    End Sub
    'MÉTODO PARA MOSTRAR EL NOMBRE DEL HABITANTE EN LA TABLA VEHÍCULO
    Public Sub mostrarNombreDelHabitante()
        Dim xDT As New DataTable

        If FrmVehiculo.LbIdHabitante.Text <> "" Then
            Dim conector As New OracleDataAdapter("SELECT nombre_hab FROM Habitante WHERE id_habitante = '" & FrmVehiculo.LbIdHabitante.Text & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmVehiculo.CbHabitanteD.Text = registro("nombre_hab").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE VISITANTE DE LA TABLA VEHÍCULO
    Public Sub poblarComboVisitante()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT nombre_vis FROM Visitante ORDER BY id_visitante"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmVehiculo.CbVisitanteD
            .DataSource = xDT
            .DisplayMember = "id_visitante"
            .ValueMember = "nombre_vis"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL VISITANTE EN LA TABLA VEHÍCULO
    Public Sub mostrarIdDelVisitante()
        Dim xDT As New DataTable

        If FrmVehiculo.CbVisitanteD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_visitante FROM Visitante WHERE nombre_vis = '" & FrmVehiculo.CbVisitanteD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmVehiculo.LbIdVisitante.Text = registro("id_visitante").ToString
            Next
        End If
    End Sub
    'MÉTODO PARA MOSTRAR EL NOMBRE DEL VISITANTE EN LA TABLA VEHÍCULO
    Public Sub mostrarNombreDelVisitante()
        Dim xDT As New DataTable

        If FrmVehiculo.LbIdVisitante.Text <> "" Then
            Dim conector As New OracleDataAdapter("SELECT nombre_vis FROM Visitante WHERE id_visitante = '" & FrmVehiculo.LbIdVisitante.Text & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmVehiculo.CbVisitanteD.Text = registro("nombre_vis").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO VEHÍCULO
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_vehiculo)+1 FROM Vehiculo", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmVehiculo.TbIdVehiculo.Text = registro("MAX(id_vehiculo)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA VEHÍCULO***************************************
End Class

