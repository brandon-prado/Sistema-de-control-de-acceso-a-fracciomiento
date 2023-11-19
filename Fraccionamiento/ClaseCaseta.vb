Imports Oracle.DataAccess.Client

Public Class ClaseCaseta
    'VARIABLES UTILIZADAS EN EL FORMULARIO CASETA
    Private idCaseta As Integer
    Private idEmpleado As Integer
    Private direccion As String
    Private nombre As String
    '************************************TABLA CASETA***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA CASETA--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí inicializamos los datos
        idCaseta = 0
        idEmpleado = 0
        direccion = ""
        nombre = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA CASETA
    Public Sub New(ByVal elIdCaseta As Integer, ByVal elIdEmpleado As Integer, ByVal laDireccion As String, ByVal elNombre As String)
        'Aquí recibimos los datos
        idCaseta = elIdCaseta
        idEmpleado = elIdEmpleado
        direccion = laDireccion
        nombre = elNombre

    End Sub

    '-------------------------MÉTODOS GET Y SET DE LA TABLA CASETA--------------------------------------
    'Métodos get y set TABLA CASETA
    Public Property getSetIdCaseta() As Integer
        Get
            Return idCaseta
        End Get
        Set(ByVal Value As Integer)
            idCaseta = Value
        End Set
    End Property

    Public Property getSetIdEmpleado() As Integer
        Get
            Return idEmpleado
        End Get
        Set(ByVal Value As Integer)
            idEmpleado = Value
        End Set
    End Property

    Public Property getSetDireccion() As String
        Get
            Return direccion
        End Get
        Set(ByVal Value As String)
            direccion = Value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA CASETA
    Public Function consultaTodasCasetas() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "Select id_caseta As ID, direccion_caseta As ""DIRECCIÓN CASETA"", nombre_caseta As ""NOMBRE CASETA"", nombre_empl As ""NOMBRE EMPLEADO"", paterno_empl As ""PATERNO EMPLEADO"", hora_inicio_lab As ""HORA DE ATENCIÓN"", hora_fin_lab As ""HORA FIN DE ATENCIÓN"" " &
                 "FROM Caseta c, Empleado e, Horario_laboral h " &
                 "WHERE c.id_empleado = e.id_empleado " &
                 "AND e.id_horario = h.id_horario " &
                 "ORDER BY id_caseta ASC"

        consultaTodasCasetas = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO CASETA POR MEDIO DEL MÉTODO CONSULTATODASCASETAS()
    Public Sub PoblarDataGridVCaseta(ByVal DGVCaseta As DataGridView)
        'Método que lee todos los CASETA del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVCaseta.DataSource = consultaTodasCasetas()

        'Con el refresh actualiza el contenido del DGV

        DGVCaseta.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVCaseta.Columns.Item(0).Width = 40
        DGVCaseta.Columns.Item(1).Width = 120
        DGVCaseta.Columns.Item(2).Width = 120
    End Sub

    'MÉTODO QUE INSERTA REGISTROS A LA TABLA CASETA
    'Inserta nuevo CASETA en la tabla correspondiente
    'la tabla tiene 3 atributos, por lo tanto se requieren de 3 valores
    Public Sub insertaCaseta()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idCaseta <> 0 And idEmpleado <> 0 And direccion <> "" And nombre <> "" Then
            'Realiza inserción de datos

            ' ----------------------------------------------------------------------------------------------------------
            'La parte que corresponde a la sintaxis del INSERT se escriben entre comillas 
            '        "INSERT INTO nombretabla VALUES(" 
            ' para indicar que hay continuación en la sintaxis se usa el simbolo & 
            ' Si el dato entra en un atributo tipo NUMERICO, ENTERO se escribe sin apóstrofe 
            '   "INSERT INTO nombretabla VALUES(" & primerdato 
            ' la como es parte de la sintaxis del INSERT entonces se escribe entre comillas
            '   "INSERT INTO nombretabla VALUES(" & primerdato & ", " 
            ' los datos que entran en campos VARCHAR o DATE se encierran entre apóstrofe
            '"INSERT INTO Ciudades VALUES(" & idPais & ", " & idEstado & ", " & idCiudad & ", '" & nombre & "')"
            ' ----------------------------------------------------------------------------------------------------------

            strSql = "INSERT INTO Caseta (id_caseta, id_empleado, direccion_caseta, nombre_caseta) VALUES(" & idCaseta & ", " & idEmpleado & ", '" & direccion & "', '" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos para la caseta, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE LA TABLA CASETA
    'Actualiza datos de un CASETA específico
    Public Sub actualizaCaseta()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idCaseta <> 0 And idEmpleado <> 0 And direccion <> "" And nombre <> "" Then
            'Realiza inserción de datos

            'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
            ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
            ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

            strSql = "UPDATE Caseta SET id_empleado = " & idEmpleado & ", direccion_caseta = '" & direccion & "', nombre_caseta = '" & nombre & "' " &
                     "WHERE id_caseta = " & idCaseta
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para la caseta !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA UNA CASETA EN ESPECIFICO DE LA TABLA CASETA Y REGRESA TRUE O FALSE
    'Consulta un CASETA en específico
    Public Function consultaUnIdCaseta() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_caseta FROM Caseta " &
                 "WHERE id_caseta = " & idCaseta

        consultaUnIdCaseta = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdCaseta = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY FOLIOS QUE DEPENDEN DE ALGUNA CASETA
    Public Function validaCasetaFolio() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Folio " &
                 " WHERE id_caseta = " & idCaseta
        validaCasetaFolio = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaCasetaFolio = True
        End If
    End Function

    'MÉTODO QUE ELIMINA REGISTROS (ID) DE LA TABLA CASETA
    Public Sub eliminarCaseta()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idCaseta <> 0 And idEmpleado <> 0 And direccion <> "" And nombre <> "" Then
            strSql = "DELETE FROM Caseta " &
                     " WHERE id_caseta = " & idCaseta
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS LA CASETA !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE EMPLEADO DE LA TABLA CASETA
    Public Sub poblarComboEmpleado()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT nombre_empl, paterno_empl FROM Empleado ORDER BY id_empleado"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmCaseta.CbEmpleadoD
            .DataSource = xDT
            .DisplayMember = "id_empleado"
            .ValueMember = "nombre_empl"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL EMPLEADO EN LA TABLA CASETA
    Public Sub mostrarIdEmpleado()
        Dim xDT As New DataTable

        If FrmCaseta.CbEmpleadoD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_empleado FROM Empleado WHERE nombre_empl = '" & FrmCaseta.CbEmpleadoD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmCaseta.LbIdEmpleado.Text = registro("id_empleado").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO CASETA
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_caseta)+1 FROM Caseta", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmCaseta.TbIdCaseta.Text = registro("MAX(id_caseta)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA CASETA***************************************
End Class