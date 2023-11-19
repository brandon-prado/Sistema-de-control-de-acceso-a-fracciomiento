Imports Oracle.DataAccess.Client

Public Class ClaseFolio

    'VARIABLES UTILIZADAS EN EL FORMULARIO FOLIO
    Private idFolio As Integer
    Private idHabitante As Integer
    Private idVisitante As Integer
    Private idCaseta As Integer
    Private idVehiculo As Integer
    Private esHabitante As Boolean
    Private esVisitante As Boolean
    Private llegaEnVehiculo As Boolean
    '************************************TABLA FOLIO***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA FOLIO--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí inicializamos los datos
        idFolio = 0
        idHabitante = 0
        idVisitante = 0
        idCaseta = 0
        idVehiculo = 0
        esHabitante = False
        esVisitante = False
        llegaEnVehiculo = False
    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA FOLIO
    Public Sub New(ByVal elIdFolio As Integer, ByVal elIdHabitante As Integer, ByVal elIdVisitante As Integer, ByVal elIdCaseta As Integer, ByVal elIdVehiculo As Integer, ByVal isHabitante As Boolean, ByVal isVisitante As Boolean, ByVal modoLlegada As Boolean)
        'Aquí recibimos los datos
        idFolio = elIdFolio
        idHabitante = elIdHabitante
        idVisitante = elIdVisitante
        idCaseta = elIdCaseta
        idVehiculo = elIdVehiculo
        esHabitante = isHabitante
        esVisitante = isVisitante
        llegaEnVehiculo = modoLlegada

    End Sub
    '-------------------------MÉTODOS GET Y SET DE LA TABLA FOLIO--------------------------------------
    'Métodos get y set TABLA FOLIO
    Public Property getSetIdFolio() As Integer
        Get
            Return idFolio
        End Get
        Set(ByVal Value As Integer)
            idFolio = Value
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

    Public Property getSetIdCaseta() As Integer
        Get
            Return idCaseta
        End Get
        Set(ByVal Value As Integer)
            idCaseta = Value
        End Set
    End Property

    Public Property getSetIdVehiculo() As Integer
        Get
            Return idVehiculo
        End Get
        Set(ByVal Value As Integer)
            idVehiculo = Value
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

    Public Property getSetLlegaEnVeh() As Boolean
        Get
            Return llegaEnVehiculo
        End Get
        Set(ByVal Value As Boolean)
            llegaEnVehiculo = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA FOLIO
    Public Function consultaTodosFolios() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los folios registrados en la tabla de Folio
        ' para llenar el DGV correspondiente
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT Folio.id_folio As ""FOLIO"", Folio.id_habitante As ""ID HAB."", Folio.id_visitante As ""ID VIS."", Folio.es_Hab_Vis ""TIPO DE PERSONA"", Folio.id_vehiculo As ""ID VEH."", llega_en_vehiculo As ""¿LLEGA EN VEH.?"", Folio.id_caseta As ""ID CASETA"", Caseta.direccion_caseta As ""DIRECCIÓN CASETA"", Caseta.nombre_caseta As ""NOMBRE CASETA"", Empleado.nombre_empl As ""NOMBRE EMPLEADO"", Empleado.paterno_empl As ""PATERNO EMPLEADO"", TO_CHAR(Folio.fecha_hora_entrada, 'DD/MON/YY HH24:MI:SS') As ""ENTRADA"", TO_CHAR(Folio.fecha_hora_salida, 'DD/MON/YY HH24:MI:SS') As ""SALIDA"" FROM Folio, Caseta, Empleado WHERE Folio.id_caseta = Caseta.id_caseta AND Caseta.id_empleado = Empleado.id_empleado ORDER BY id_folio DESC"

        consultaTodosFolios = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO FOLIO POR MEDIO DEL MÉTODO CONSULTATODOSFOLIOS()
    Public Sub PoblarDataGridFolio(ByVal DGVFolio As DataGridView)
        'Método que lee todos los folios del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVFolio.DataSource = consultaTodosFolios()

        'Con el refresh actualiza el contenido del DGV

        DGVFolio.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVFolio.Columns.Item(0).Width = 50
        DGVFolio.Columns.Item(1).Width = 40
        DGVFolio.Columns.Item(2).Width = 40
        DGVFolio.Columns.Item(3).Width = 75
        DGVFolio.Columns.Item(4).Width = 40
        DGVFolio.Columns.Item(5).Width = 86
        DGVFolio.Columns.Item(6).Width = 60
        DGVFolio.Columns.Item(7).Width = 110
        DGVFolio.Columns.Item(8).Width = 120
        DGVFolio.Columns.Item(9).Width = 120
        DGVFolio.Columns.Item(10).Width = 106
        DGVFolio.Columns.Item(11).Width = 120
        DGVFolio.Columns.Item(12).Width = 120
    End Sub

    'MÉTODO QUE INSERTA REGISTROS A LA TABLA FOLIO
    'Inserta nuevo FOLIO en la tabla correspondiente
    'la tabla tiene 6 atributos, sin embargo solo se requieren de 4 valores
    Public Sub insertaFolio()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If esHabitante = True And esVisitante = False Then
            'Realiza inserción de datos como habitante
            If llegaEnVehiculo = True Then
                strSql = "INSERT INTO Folio (id_folio, id_habitante, id_visitante, id_caseta, id_vehiculo, fecha_hora_entrada, fecha_hora_salida, es_Hab_Vis, llega_en_vehiculo) VALUES (" & idFolio & ", " & idHabitante & ", null, " & idCaseta & ", " & idVehiculo & ", SYSDATE, null, 'HABITANTE', 'SI')"
                xCnx.objetoCommand(strSql)
            ElseIf llegaEnVehiculo = False Then
                strSql = "INSERT INTO Folio (id_folio, id_habitante, id_visitante, id_caseta, id_vehiculo, fecha_hora_entrada, fecha_hora_salida, es_Hab_Vis, llega_en_vehiculo) VALUES (" & idFolio & ", " & idHabitante & ", null, " & idCaseta & ", null, SYSDATE, null, 'HABITANTE', 'OTRO')"
                xCnx.objetoCommand(strSql)
            End If
            
        ElseIf esHabitante = False And esVisitante = True Then
            'Realiza inserción de datos como visitante
            If llegaEnVehiculo = True Then
                strSql = "INSERT INTO Folio (id_folio, id_habitante, id_visitante, id_caseta, id_vehiculo, fecha_hora_entrada, fecha_hora_salida, es_Hab_Vis, llega_en_vehiculo) VALUES (" & idFolio & ", null, " & idVisitante & ", " & idCaseta & ", " & idVehiculo & ", SYSDATE, null, 'VISITANTE', 'SI')"
                xCnx.objetoCommand(strSql)
            ElseIf llegaEnVehiculo = False Then
                strSql = "INSERT INTO Folio (id_folio, id_habitante, id_visitante, id_caseta, id_vehiculo, fecha_hora_entrada, fecha_hora_salida, es_Hab_Vis, llega_en_vehiculo) VALUES (" & idFolio & ", null, " & idVisitante & ", " & idCaseta & ", null, SYSDATE, null, 'VISITANTE', 'OTRO')"
                xCnx.objetoCommand(strSql)
            End If

        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos para el folio, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE LA TABLA FOLIO
    'Actualiza datos de un FOLIO específico
    Public Sub actualizaFolio()
        Dim strSql As String
        Dim xCnx As New Oracle
        If esHabitante = True And esVisitante = False Then
            If llegaEnVehiculo = True Then
                strSql = "UPDATE Folio SET id_habitante = " & idHabitante & ", id_visitante = null, id_caseta = " & idCaseta & ", id_vehiculo = " & idVehiculo & ", es_Hab_Vis = 'HABITANTE', llega_en_vehiculo = 'SI' " &
                         "WHERE id_folio = " & idFolio
                xCnx.objetoCommand(strSql)
            ElseIf llegaEnVehiculo = False Then
                strSql = "UPDATE Folio SET id_habitante = " & idHabitante & ", id_visitante = null, id_caseta = " & idCaseta & ", id_vehiculo = null, es_Hab_Vis = 'HABITANTE', llega_en_vehiculo = 'OTRO' " &
                         "WHERE id_folio = " & idFolio
                xCnx.objetoCommand(strSql)
            End If

        ElseIf esHabitante = False And esVisitante = True Then
            If llegaEnVehiculo = True Then
                strSql = "UPDATE Folio SET id_habitante = null, id_visitante = " & idVisitante & ", id_caseta = " & idCaseta & ", id_vehiculo = " & idVehiculo & ", es_Hab_Vis = 'VISITANTE', llega_en_vehiculo = 'SI' " &
                         " WHERE id_folio = " & idFolio
                xCnx.objetoCommand(strSql)
            ElseIf llegaEnVehiculo = False Then
                strSql = "UPDATE Folio SET id_habitante = null, id_visitante = " & idVisitante & ", id_caseta = " & idCaseta & ", id_vehiculo = null, es_Hab_Vis = 'HABITANTE', llega_en_vehiculo = 'OTRO' " &
                         " WHERE id_folio = " & idFolio
                xCnx.objetoCommand(strSql)
            End If
        Else
            MsgBox("Faltan datos para el folio !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA UN FOLIO EN ESPECIFICO DE LA TABLA FOLIO Y REGRESA TRUE O FALSE
    'Consulta un FOLIO en específico
    Public Function consultaUnIdFolio() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_folio FROM Folio " &
                 "WHERE id_folio = " & idFolio

        consultaUnIdFolio = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdFolio = True
        End If
    End Function

    'MÉTODO QUE ELIMINA REGISTROS (ID) DE LA TABLA FOLIO
    Public Sub eliminarFolio()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idFolio <> 0 Then
            strSql = "DELETE FROM Folio " &
                     " WHERE id_folio = " & idFolio
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DEL FOLIO !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONFIRMA SALIDA DE HABITANTE O VISITANTE DE LA TABLA FOLIO
    Public Sub confirmaSalida()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Realiza inserción de datos como habitante
        strSql = "UPDATE Folio SET fecha_hora_salida = SYSDATE" &
                         " WHERE id_folio = " & idFolio
        xCnx.objetoCommand(strSql)
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE HABITANTE DE LA TABLA FOLIO
    Public Sub poblarComboHabitante()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT nombre_hab FROM Habitante ORDER BY id_habitante"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmFolio.CbHabitanteD
            .DataSource = xDT
            .DisplayMember = "id_habitante"
            .ValueMember = "nombre_hab"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL HABITANTE EN LA TABLA FOLIO
    Public Sub mostrarIdDelHabitante()
        Dim xDT As New DataTable

        If FrmFolio.CbHabitanteD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_habitante FROM Habitante WHERE nombre_hab = '" & FrmFolio.CbHabitanteD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmFolio.LbIdHabitante.Text = registro("id_habitante").ToString
            Next
        End If
    End Sub
    'MÉTODO PARA MOSTRAR EL NOMBRE DEL HABITANTE EN LA TABLA FOLIO
    Public Sub mostrarNombreDelHabitante()
        Dim xDT As New DataTable

        If FrmFolio.LbIdHabitante.Text <> "" Then
            Dim conector As New OracleDataAdapter("SELECT nombre_hab FROM Habitante WHERE id_habitante = '" & FrmFolio.LbIdHabitante.Text & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmFolio.CbHabitanteD.Text = registro("nombre_hab").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE VISITANTE DE LA TABLA FOLIO
    Public Sub poblarComboVisitante()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT nombre_vis FROM Visitante ORDER BY id_visitante"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmFolio.CbVisitanteD
            .DataSource = xDT
            .DisplayMember = "id_visitante"
            .ValueMember = "nombre_vis"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL VISITANTE EN LA TABLA FOLIO
    Public Sub mostrarIdDelVisitante()
        Dim xDT As New DataTable

        If FrmFolio.CbVisitanteD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_visitante FROM Visitante WHERE nombre_vis = '" & FrmFolio.CbVisitanteD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmFolio.LbIdVisitante.Text = registro("id_visitante").ToString
            Next
        End If
    End Sub
    'MÉTODO PARA MOSTRAR EL NOMBRE DEL VISITANTE EN LA TABLA FOLIO
    Public Sub mostrarNombreDelVisitante()
        Dim xDT As New DataTable

        If FrmFolio.LbIdVisitante.Text <> "" Then
            Dim conector As New OracleDataAdapter("SELECT nombre_vis FROM Visitante WHERE id_visitante = '" & FrmFolio.LbIdVisitante.Text & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmFolio.CbVisitanteD.Text = registro("nombre_vis").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE VEHICULO DE LA TABLA FOLIO DE LOS HABITANTES
    Public Sub poblarComboVehiculoHab()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT matricula FROM Vehiculo ORDER BY id_vehiculo"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmFolio.CbMatriculaVeh
            .DataSource = xDT
            .DisplayMember = "id_vehiculo"
            .ValueMember = "matricula"
        End With
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE VEHICULO DE LA TABLA FOLIO DE LOS VISITANTES
    Public Sub poblarComboVehiculoVis()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT matricula FROM Vehiculo ORDER BY id_vehiculo"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmFolio.CbMatriculaVeh
            .DataSource = xDT
            .DisplayMember = "id_vehiculo"
            .ValueMember = "matricula"
        End With
    End Sub

    'MÉTODO PARA MOSTRAR EL ID DE LA MATRICULA EN LA TABLA FOLIO
    Public Sub mostrarIdDelVehic()
        Dim xDT As New DataTable
        Try
            If FrmFolio.CbMatriculaVeh.ValueMember.ToString <> "" Then
                Dim conector As New OracleDataAdapter("SELECT id_vehiculo FROM Vehiculo WHERE matricula = '" & FrmFolio.CbMatriculaVeh.SelectedValue.ToString & "'", cnx)

                conector.Fill(xDT)
                For Each registro As DataRow In xDT.Rows
                    FrmFolio.LbIdVehiculo.Text = registro("id_vehiculo").ToString
                Next
            End If
        Catch ex As Exception

        End Try

        
    End Sub
    'MÉTODO PARA MOSTRAR LA MATRICULA EN LA TABLA FOLIO
    Public Sub mostrarMatricula()
        Dim xDT As New DataTable

        If FrmFolio.LbIdVehiculo.Text <> "" Then
            Dim conector As New OracleDataAdapter("SELECT matricula FROM Vehiculo WHERE id_vehiculo = " & FrmFolio.LbIdVehiculo.Text, cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmFolio.CbMatriculaVeh.Text = registro("matricula").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA MOSTRAR LA MARCA DEL VEHICULO EN LA TABLA FOLIO
    Public Sub mostrarMarcaVeh()
        Dim xDT As New DataTable

        If FrmFolio.LbIdVehiculo.Text <> "0" Then
            Dim conector As New OracleDataAdapter("SELECT marca FROM Vehiculo WHERE id_vehiculo = " & FrmFolio.LbIdVehiculo.Text, cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmFolio.LbMarcaD.Text = registro("marca").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA MOSTRAR LA MARCA DEL VEHICULO EN LA TABLA FOLIO
    Public Sub mostrarColorVeh()
        Dim xDT As New DataTable

        If FrmFolio.LbIdVehiculo.Text <> "0" Then
            Dim conector As New OracleDataAdapter("SELECT color FROM Vehiculo v, Color c WHERE v.id_color = c.id_color AND v.id_vehiculo = " & FrmFolio.LbIdVehiculo.Text, cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmFolio.LbColorD.Text = registro("color").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE CASETA DE LA TABLA FOLIO QUE LE CORRESPONDE AL EMPLEADO
    Public Sub poblarComboCaseta()
        Try
            Dim strSql As String
            Dim xDT As New DataTable
            Dim conector = New OracleDataAdapter

            strSql = "SELECT nombre_caseta FROM Caseta WHERE id_empleado = " & FrmLogin.TbEmpleado.Text & " ORDER BY id_caseta"
            'strSql = "SELECT direccion_caseta FROM Caseta"
            conector = New OracleDataAdapter(strSql, cnx)

            conector.Fill(xDT)
            With FrmFolio.CbCasetaD
                .DataSource = xDT
                .DisplayMember = "id_caseta"
                .ValueMember = "nombre_caseta"
            End With
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try

    End Sub

    'MÉTODO PARA MOSTRAR EL ID DE LA CASETA EN LA TABLA FOLIO
    Public Sub mostrarIdDeCaseta()
        Dim xDT As New DataTable
        Try
            If FrmFolio.CbCasetaD.ValueMember.ToString <> "" Then
                Dim conector As New OracleDataAdapter("SELECT id_caseta FROM Caseta WHERE nombre_caseta = '" & FrmFolio.CbCasetaD.Text & "'", cnx)

                conector.Fill(xDT)
                For Each registro As DataRow In xDT.Rows
                    FrmFolio.LbIdCaseta.Text = registro("id_caseta").ToString
                Next
            End If
        Catch ex As Exception
            
        End Try
        
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO FOLIO
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_folio)+1 FROM Folio", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmFolio.TbIdFolio.Text = registro("MAX(id_folio)+1").ToString
        Next
    End Sub

    'MÉTODO PARA MOSTRAR NOMBRE DE QUIEN ATIENDE
    Public Sub mostrarNombEmplFolio()
        Dim xDT As New DataTable

        If FrmLogin.TbEmpleado.Text <> "" Then
            Dim conector As New OracleDataAdapter("SELECT nombre_empl FROM Empleado WHERE id_empleado = " & FrmLogin.TbEmpleado.Text, cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmBienvenido.LbAtiendeNomD.Text = registro("nombre_empl").ToString
                FrmFolio.LbAtiendeNomD.Text = registro("nombre_empl").ToString
            Next
        ElseIf FrmLogin.LbEmpleado.Text = "" Then
            FrmFolio.LbAtiendeNomD.Text = "X"
        End If
    End Sub

    'MÉTODO PARA MOSTRAR APELLIDO PATERNO DE QUIEN ATIENDE
    Public Sub mostrarApellEmplFolio()
        Dim xDT As New DataTable

        If FrmLogin.TbEmpleado.Text <> "" Then
            Dim conector As New OracleDataAdapter("SELECT paterno_empl FROM Empleado WHERE id_empleado = " & FrmLogin.TbEmpleado.Text, cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmFolio.LbAtiendeApellD.Text = registro("paterno_empl").ToString
            Next
        ElseIf FrmLogin.LbEmpleado.Text = "" Then
            FrmFolio.LbAtiendeApellD.Text = "X"
        End If
    End Sub

    'MÉTODO QUE CONSULTA SI EL EMPLEADO TIENE CASETAS ASIGNADAS
    Public Function consultaEmplCaseta() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_caseta FROM Caseta " &
                 "WHERE id_empleado = " & FrmLogin.TbEmpleado.Text

        consultaEmplCaseta = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            consultaEmplCaseta = True
        End If
    End Function

    'MÉTODO PARA MOSTRAR LA CANTIDAD TOTAL DE FOLIOS
    Public Sub mostrarTotalFolio()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT COUNT(*) FROM Folio", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmFolio.LbTotalFoliosD.Text = registro("COUNT(*)").ToString
        Next
    End Sub

    'MÉTODO PARA MOSTRAR LA CANTIDAD TOTAL DE PERSONAS QUE NO HAN SALIDO DEL FRACCIONAMIENTO
    Public Sub mostrarPersonSinSalir()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT COUNT(*) FROM Folio WHERE fecha_hora_salida IS NULL", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmFolio.LbNoHanSalidoD.Text = registro("COUNT(*)").ToString
        Next
    End Sub

    'MÉTODO PARA MOSTRAR LA CANTIDAD TOTAL DE HABITANTES QUE HAN PASADO POR LA CASETA
    Public Sub mostrarTotalHab()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT COUNT(*) FROM Folio WHERE es_Hab_Vis = 'HABITANTE'", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmFolio.LbCantHabD.Text = registro("COUNT(*)").ToString
        Next
    End Sub

    'MÉTODO PARA MOSTRAR LA CANTIDAD TOTAL DE VISITANTES QUE HAN PASADO POR LA CASETA
    Public Sub mostrarTotalVis()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT COUNT(*) FROM Folio WHERE es_Hab_Vis = 'VISITANTE'", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmFolio.LbCantVisD.Text = registro("COUNT(*)").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA FOLIO***************************************
End Class
