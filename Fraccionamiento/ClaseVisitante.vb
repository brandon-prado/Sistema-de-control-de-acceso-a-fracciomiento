Imports Oracle.DataAccess.Client
Public Class ClaseVisitante
    'VARIABLES UTILIZADAS EN EL FORMULARIO VISITANTE
    Private idVisitante As Integer
    Private idGenero As Integer
    Private nombreVis As String
    Private paternoVis As String
    Private maternoVis As String
    Private telefonoVis As String
    Private ineVis As String

    '************************************TABLA VISITANTE***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA VISITANTE--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí recibimos los datos
        idVisitante = 0
        idGenero = 0
        nombreVis = ""
        paternoVis = ""
        maternoVis = ""
        telefonoVis = ""
        ineVis = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA VISITANTE
    Public Sub New(ByVal elIdVis As Integer, ByVal elIdGenero As Integer, ByVal elNombreVis As String, ByVal elPaternoVis As String, ByVal elMaternoVis As String, ByVal elTelVis As String, ByVal elIneVis As String)
        'Aquí recibimos los datos
        idVisitante = elIdVis
        idGenero = elIdGenero
        nombreVis = elNombreVis
        paternoVis = elPaternoVis
        maternoVis = elMaternoVis
        telefonoVis = elTelVis
        ineVis = elIneVis

    End Sub

    'Métodos get y set TABLA VISITANTE
    Public Property getSetIdVisitante() As Integer
        Get
            Return idVisitante
        End Get
        Set(ByVal Value As Integer)
            idVisitante = Value
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

    Public Property getSetNombreVis() As String
        Get
            Return nombreVis
        End Get
        Set(ByVal Value As String)
            nombreVis = Value
        End Set
    End Property

    Public Property getSetPaternoVis() As String
        Get
            Return paternoVis
        End Get
        Set(ByVal Value As String)
            paternoVis = Value
        End Set
    End Property

    Public Property getSetMaternoVis() As String
        Get
            Return maternoVis
        End Get
        Set(ByVal Value As String)
            maternoVis = Value
        End Set
    End Property

    Public Property getSetTelVis() As String
        Get
            Return telefonoVis
        End Get
        Set(ByVal Value As String)
            telefonoVis = Value
        End Set
    End Property

    Public Property getSetIneVis() As String
        Get
            Return ineVis
        End Get
        Set(ByVal Value As String)
            ineVis = Value
        End Set
    End Property
    'AQUI TERMINA LOS GET Y SET DE LA TABLA VISITANTE

    'MÉTODO QUE CONSULTA SI EXISTE UN ID DE VISITANTE DE LA TABLA VISITANTE Y REGRESA TRUE/FALSE
    'Consulta un visitante en específico
    Public Function consultaUnIdVisitante() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_visitante FROM Visitante " &
                 "WHERE id_visitante = " & idVisitante

        consultaUnIdVisitante = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdVisitante = True
        End If
    End Function

    'MÉTODO QUE INSERTA UN REGISTRO A LA TABLA VISITANTE
    'Inserta nuevo visitante en la tabla correspondiente
    'la tabla tiene 9 atributos, por lo tanto se requieren de 9 valores
    Public Sub insertaVisitante()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idVisitante <> 0 And idGenero <> 0 And nombreVis <> "" And paternoVis <> "" And maternoVis <> "" And telefonoVis <> "" And ineVis <> "" Then
            'Realiza inserción de datos

            strSql = "INSERT INTO Visitante (id_visitante, id_genero, nombre_vis, paterno_vis, materno_vis, telefono_Vis, ine_vis) VALUES(" & idVisitante & ", " & idGenero & ", '" & nombreVis & "' , '" & paternoVis & "' , '" & maternoVis & "' , '" & telefonoVis & "' , '" & ineVis & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 

            MsgBox("Faltan datos para la visita, verifique !! ", MsgBoxStyle.Critical, " ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE UNA VISITANTE EN ESPECIFICO
    Public Sub actualizaVisitante()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idVisitante <> 0 And idGenero <> 0 And nombreVis <> "" And paternoVis <> "" And maternoVis <> "" And telefonoVis <> "" And ineVis <> "" Then

            strSql = "UPDATE Visitante SET id_genero = " & idGenero & ", nombre_vis = '" & nombreVis & "', paterno_vis = '" & paternoVis & "', materno_vis = '" & maternoVis &
                "', telefono_vis = '" & telefonoVis & "', ine_vis = '" & ineVis &
                     "' WHERE id_visitante = " & idVisitante

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para la visita, verifique !! ", MsgBoxStyle.Critical, " ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ELIMINAR UNA VISITANTE POR MEDIO DE SU ID
    Public Sub eliminarVisitante()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idVisitante <> 0 And idGenero <> 0 And nombreVis <> "" And paternoVis <> "" And maternoVis <> "" And telefonoVis <> "" And ineVis <> "" Then

            strSql = "DELETE FROM Visitante WHERE id_visitante = " & idVisitante

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DE LA VISITA !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA TODAS LAS VISITAS REGISTRADAS EN LA TABLA VISITANTE
    Public Function consultaTodasVisitas() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_visitante As ""ID"", nombre_vis As ""NOMBRE"", paterno_vis As ""PATERNO"", materno_Vis As ""MATERNO"", genero As ""GÉNERO"", telefono_vis As ""TELÉFONO"", ine_vis As ""INE"" FROM Visitante v, Genero g WHERE v.id_genero = g.id_genero ORDER BY id_Visitante ASC"

        consultaTodasVisitas = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO DE VISITANTE
    Public Sub PoblarDataGridVisitante(ByVal DGVVisitante As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVVisitante.DataSource = consultaTodasVisitas()

        'Con el refresh actualiza el contenido del DGV

        DGVVisitante.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVVisitante.Columns.Item(0).Width = 100
        DGVVisitante.Columns.Item(1).Width = 113
    End Sub

    'MÉTODO QUE VÁLIDA SI HAY VEHICULO QUE DEPENDEN DE ALGÚN VISITANTE
    Public Function validaVisitanteVeh() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM Vehiculo " &
                 " WHERE id_visitante = " & idVisitante
        validaVisitanteVeh = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaVisitanteVeh = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY FOLIOS QUE DEPENDEN DE ALGÚN VISITANTE
    Public Function validaVisitanteFolio() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM Folio " &
                 " WHERE id_visitante = " & idVisitante
        validaVisitanteFolio = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaVisitanteFolio = True
        End If
    End Function

    'MÉTODO PARA POBLAR UN COMBO BOX DE GENERO DE LA TABLA VISITANTES
    Public Sub poblarComboGeneros()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT genero FROM Genero"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmVisitante.CbGeneroD
            .DataSource = xDT
            .DisplayMember = "id_genero"
            .ValueMember = "genero"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL GÉNERO EN LA TABLA HABITANTE
    Public Sub mostrarIdDelGenero()
        Dim xDT As New DataTable

        If FrmVisitante.CbGeneroD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_genero FROM Genero WHERE genero = '" & FrmVisitante.CbGeneroD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmVisitante.LbIdGenero.Text = registro("id_genero").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO VISITANTE
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_visitante)+1 FROM Visitante", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmVisitante.TbIdVisitanteD.Text = registro("MAX(id_visitante)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA VISITANTE***************************************

End Class

