Imports Oracle.DataAccess.Client
Public Class ClaseHabitante
    'VARIABLES UTILIZADAS EN EL FORMULARIO HABITANTE
    Private idHabitante As Integer
    Private idGenero As Integer
    Private idVivienda As Integer
    Private nombreHabitante As String
    Private paternoHabitante As String
    Private maternoHabitante As String
    Private telefonoHabitante As String
    Private fechaNacimiento As String
    Private ineHabitante As String

    '************************************TABLA HABITANTE***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA HABITANTE--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí recibimos los datos
        idHabitante = 0
        idGenero = 0
        idVivienda = 0
        nombreHabitante = ""
        paternoHabitante = ""
        maternoHabitante = ""
        telefonoHabitante = ""
        fechaNacimiento = ""
        ineHabitante = ""
    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA HABITANTE
    Public Sub New(ByVal elIdHabitante As Integer, ByVal elIdGenero As Integer, ByVal elIdVivienda As Integer, ByVal elNombreHabitante As String, ByVal elPaternoHabitante As String, ByVal elMaternoHabitante As String, ByVal elTelefonoHabitante As String, ByVal elFechaNacimiento As String, ByVal elIneHabitante As String)
        'Aquí recibimos los datos
        idHabitante = elIdHabitante
        idGenero = elIdGenero
        idVivienda = elIdVivienda
        nombreHabitante = elNombreHabitante
        paternoHabitante = elPaternoHabitante
        maternoHabitante = elMaternoHabitante
        telefonoHabitante = elTelefonoHabitante
        fechaNacimiento = elFechaNacimiento
        ineHabitante = elIneHabitante

    End Sub

    'Métodos get y set TABLA HABITANTE
    Public Property getSetIdHabitante() As Integer
        Get
            Return idHabitante
        End Get
        Set(ByVal Value As Integer)
            idHabitante = Value
        End Set
    End Property

    Public Property getSetIdGenero() As Integer
        Get
            Return idGenero
        End Get
        Set(ByVal Value As Integer)
            idGenero = Value
        End Set
    End Property

    Public Property getSetIdVivienda() As Integer
        Get
            Return idVivienda
        End Get
        Set(ByVal Value As Integer)
            idVivienda = Value
        End Set
    End Property

    Public Property getSetNombreHabitante() As String
        Get
            Return nombreHabitante
        End Get
        Set(ByVal Value As String)
            nombreHabitante = Value
        End Set
    End Property

    Public Property getSetPaternoHabitante() As String
        Get
            Return paternoHabitante
        End Get
        Set(ByVal Value As String)
            paternoHabitante = Value
        End Set
    End Property

    Public Property getSetMaternoHabitante() As String
        Get
            Return maternoHabitante
        End Get
        Set(ByVal Value As String)
            maternoHabitante = Value
        End Set
    End Property

    Public Property getSetTelefonoHabitante() As String
        Get
            Return telefonoHabitante
        End Get
        Set(ByVal Value As String)
            telefonoHabitante = Value
        End Set
    End Property

    Public Property getSetFechaNacimiento() As String
        Get
            Return fechaNacimiento
        End Get
        Set(ByVal Value As String)
            fechaNacimiento = Value
        End Set
    End Property
    Public Property getSetIneHabitante() As String
        Get
            Return ineHabitante
        End Get
        Set(ByVal Value As String)
            ineHabitante = Value
        End Set
    End Property

    'AQUI TERMINAN LOS GET Y SET DE LA TABLA HABITANTE

    'MÉTODO QUE CONSULTA SI EXISTE UN ID DE HABITANTE DE LA TABLA HABITANTE Y REGRESA TRUE/FALSE
    'Consulta un HABITANTE en específico
    Public Function consultaUnIdHabitante() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_habitante FROM Habitante " &
                 "WHERE id_habitante = " & idHabitante

        consultaUnIdHabitante = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdHabitante = True
        End If
    End Function

    'MÉTODO QUE INSERTA UN REGISTRO A LA TABLA HABITANTE
    Public Sub insertaHabitante()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idHabitante <> 0 And idGenero <> 0 And idVivienda <> 0 And nombreHabitante <> "" And paternoHabitante <> "" And maternoHabitante <> "" And telefonoHabitante <> "" And fechaNacimiento <> "" And ineHabitante <> "" Then
            'Realiza inserción de datos

            strSql = "INSERT INTO Habitante (id_habitante, id_genero, id_vivienda, nombre_hab, paterno_hab, materno_hab, telefono_hab, fecha_nacimiento, ine_hab) VALUES(" & idHabitante & ", " & idGenero & ", " & idVivienda & ", '" & nombreHabitante & "' , '" & paternoHabitante & "' , '" & maternoHabitante & "' , '" & telefonoHabitante & "' , TO_DATE('" & fechaNacimiento & "', 'DD/MM/YYYY') , '" & ineHabitante & "')"
            xCnx.objetoCommand(strSql)
            'Notificamos al usuario final por medio de un mensaje 
        Else
            MsgBox("Faltan datos para el habitante, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE UN HABITANTE EN ESPECIFICO
    Public Sub actualizaHabitante()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idHabitante <> 0 And idGenero <> 0 And idVivienda <> 0 And nombreHabitante <> "" And paternoHabitante <> "" And maternoHabitante <> "" And telefonoHabitante <> "" And fechaNacimiento <> "" And ineHabitante <> "" Then
            strSql = "UPDATE Habitante SET id_genero = " & idGenero & ", id_vivienda = " & idVivienda & ", nombre_hab = '" & nombreHabitante & "', paterno_hab = '" & paternoHabitante &
                "', materno_hab = '" & maternoHabitante & "', telefono_hab = '" & telefonoHabitante & "', fecha_nacimiento = TO_DATE('" & fechaNacimiento & "', 'DD/MM/YYYY')" &
                ", ine_hab = '" & ineHabitante & "' " &
              "WHERE id_habitante = " & idHabitante

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del habitante, verifique !! ", MsgBoxStyle.Critical, " ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ELIMINAR UNA EMPRESA POR MEDIO DE SU ID
    Public Sub eliminarHabitante()
        Dim strSql As String
        Dim xCnx As New Oracle

        If idHabitante <> 0 And idGenero <> 0 And idVivienda <> 0 And nombreHabitante <> "" And paternoHabitante <> "" And maternoHabitante <> "" And telefonoHabitante <> "" And fechaNacimiento <> "" And ineHabitante <> "" Then

            strSql = "DELETE FROM Habitante " &
                     " WHERE id_habitante = " & idHabitante

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DE LA EMPRESA !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA TODAS LOS HABITANTES EN LA TABLA HABITANTE
    Public Function consultaTodosHabitantes() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT Habitante.id_habitante As ""ID"", Habitante.nombre_hab As ""NOMBRE"", Habitante.paterno_hab As ""PATERNO"", Habitante.materno_hab As ""MATERNO"", Genero.genero As ""GÉNERO"", Vivienda.direccion_vivienda As ""DIRECCIÓN"", Vivienda.numero_vivienda As ""#"", Vivienda.cod_postal_vivienda ""CÓD. POSTAL"", Habitante.telefono_hab As ""TELÉFONO"", TO_CHAR(Habitante.fecha_nacimiento, 'DD/MM/YYYY') As ""NACIMIENTO"", Habitante.ine_hab As ""INE"" FROM Habitante, Genero, Vivienda WHERE Habitante.id_genero = Genero.id_genero AND Habitante.id_vivienda = Vivienda.id_vivienda ORDER BY id_habitante ASC"

        consultaTodosHabitantes = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO DE HABITANTE
    Public Sub PoblarDataGridHabitante(ByVal DGVHabitante As DataGridView)

        DGVHabitante.DataSource = consultaTodosHabitantes()


        DGVHabitante.Refresh()

        DGVHabitante.Columns.Item(0).Width = 40
        DGVHabitante.Columns.Item(1).Width = 88
        DGVHabitante.Columns.Item(2).Width = 88
        DGVHabitante.Columns.Item(3).Width = 88
        DGVHabitante.Columns.Item(4).Width = 88
        DGVHabitante.Columns.Item(5).Width = 130
        DGVHabitante.Columns.Item(6).Width = 60
        DGVHabitante.Columns.Item(7).Width = 60
        DGVHabitante.Columns.Item(8).Width = 88
        DGVHabitante.Columns.Item(9).Width = 88
        DGVHabitante.Columns.Item(10).Width = 100
    End Sub

    'MÉTODO QUE VÁLIDA SI HAY VEHICULO QUE DEPENDEN DE ALGÚN HABITANTE
    Public Function validaHabitanteVeh() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM Vehiculo " &
                 " WHERE id_habitante = " & idHabitante
        validaHabitanteVeh = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaHabitanteVeh = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY FOLIOS QUE DEPENDEN DE ALGÚN HABITANTE
    Public Function validaHabitanteFolio() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM Folio " &
                 " WHERE id_habitante = " & idHabitante
        validaHabitanteFolio = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaHabitanteFolio = True
        End If
    End Function

    'MÉTODO PARA POBLAR UN COMBO BOX DE GENERO DE LA TABLA HABITANTE
    Public Sub poblarComboGeneros()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT genero FROM Genero"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmHabitante.CbGeneroD
            .DataSource = xDT
            .DisplayMember = "id_genero"
            .ValueMember = "genero"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL GÉNERO EN LA TABLA HABITANTE
    Public Sub mostrarIdDelGenero()
        Dim xDT As New DataTable

        If FrmHabitante.CbGeneroD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_genero FROM Genero WHERE genero = '" & FrmHabitante.CbGeneroD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmHabitante.LbIdGenero.Text = registro("id_genero").ToString
            Next
        End If
    End Sub
    'MÉTODO PARA POBLAR UN COMBO BOX DE ID VIVIENDA DE LA TABLA HABITANTE
    Public Sub poblarComboIdVivienda()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT numero_vivienda FROM Vivienda"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmHabitante.CbViviendaD
            .DataSource = xDT
            .DisplayMember = "id_vivienda"
            .ValueMember = "numero_vivienda"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DE VIVIENDA EN LA TABLA HABITANTE
    Public Sub mostrarIdDeVivienda()
        Dim xDT As New DataTable

        If FrmHabitante.CbViviendaD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_vivienda FROM Vivienda WHERE numero_vivienda = '" & FrmHabitante.CbViviendaD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmHabitante.LbIdVivienda.Text = registro("id_vivienda").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO HABITANTE
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_habitante)+1 FROM Habitante", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmHabitante.TbIdHabitante.Text = registro("MAX(id_habitante)+1").ToString
        Next
    End Sub

    'MÉTODO PARA MOSTRAR LA EDAD DEL HABITANTE
    'Public Sub mostrarEdadHab()
    '    Dim xDT As New DataTable
    '    Try
    '        If FrmHabitante.TbIdHabitante.Text <> "" Then
    '            Dim conector As New OracleDataAdapter("SELECT TRUNC((TO_NUMBER(TO_CHAR(SYSDATE, 'YYYYMMDD')) - TO_NUMBER(TO_CHAR(fecha_nacimiento, 'YYYYMMDD')))/10000) WHERE id_habitante = " & FrmHabitante.TbIdHabitante.Text & " FROM Habitante", cnx)

    '            conector.Fill(xDT)
    '            For Each registro As DataRow In xDT.Rows
    '                FrmHabitante.LbIdVivienda.Text = registro("TRUNC((TO_NUMBER(TO_CHAR(SYSDATE, 'YYYYMMDD')) - TO_NUMBER(TO_CHAR(fecha_nacimiento, 'YYYYMMDD')))/10000)").ToString
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
    '    End Try

    'End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA HABITANTE***************************************
End Class