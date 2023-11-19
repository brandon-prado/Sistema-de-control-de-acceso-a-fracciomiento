Imports Oracle.DataAccess.Client

Public Class ClaseVivienda
    'VARIABLES UTILIZADAS EN EL FORMULARIO VIVIENDA
    Private idVivienda As Integer
    Private direccionViv As String
    Private numVivienda As String
    Private codPostalViv As String
    '************************************TABLA VIVIENDA***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA VIVIENDA--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí inicializamos los datos
        idVivienda = 0
        direccionViv = ""
        numVivienda = ""
        codPostalViv = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA VIVIENDA
    Public Sub New(ByVal elIdVivienda As Integer, ByVal laDireccionViv As String, ByVal elNumVivienda As String, ByVal elCodPostalViv As String)
        'Aquí recibimos los datos
        idVivienda = elIdVivienda
        direccionViv = laDireccionViv
        numVivienda = elNumVivienda
        codPostalViv = elCodPostalViv

    End Sub

    '-------------------------MÉTODOS GET Y SET DE LA TABLA VIVIENDA--------------------------------------
    'Métodos get y set TABLA VIVIENDA
    Public Property getSetIdVivienda() As Integer
        Get
            Return idVivienda
        End Get
        Set(ByVal Value As Integer)
            idVivienda = Value
        End Set
    End Property

    Public Property getSetDirecViv() As String
        Get
            Return direccionViv
        End Get
        Set(ByVal Value As String)
            direccionViv = Value
        End Set
    End Property

    Public Property getSetNumViv() As String
        Get
            Return numVivienda
        End Get
        Set(ByVal Value As String)
            numVivienda = Value
        End Set
    End Property

    Public Property getSetCodPostViv() As String
        Get
            Return codPostalViv
        End Get
        Set(ByVal Value As String)
            codPostalViv = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA VIVIENDA
    Public Function consultaTodasViviendas() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los colores registrados en la tabla de Color
        ' para llenar el DGV correspondiente
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "Select id_vivienda As ID, direccion_vivienda As ""DIRECCIÓN"", numero_vivienda As ""NÚMERO"", cod_postal_vivienda ""CÓD. POSTAL"" FROM Vivienda ORDER BY id_vivienda ASC"

        consultaTodasViviendas = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO VIVIENDA POR MEDIO DEL MÉTODO CONSULTATODASVIVIENDAS()
    Public Sub PoblarDataGridVivienda(ByVal DGVVivienda As DataGridView)
        'Método que lee todos las viviendas del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVVivienda.DataSource = consultaTodasViviendas()

        'Con el refresh actualiza el contenido del DGV

        DGVVivienda.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVVivienda.Columns.Item(0).Width = 86
        DGVVivienda.Columns.Item(1).Width = 160
        DGVVivienda.Columns.Item(2).Width = 110
        DGVVivienda.Columns.Item(3).Width = 120
    End Sub

    'MÉTODO QUE INSERTA REGISTROS A LA TABLA VIVIENDA
    'Inserta nueva vivienda en la tabla correspondiente
    'la tabla tiene 4 atributos, por lo tanto se requieren de 4 valores
    Public Sub insertaVivienda()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idVivienda <> 0 And direccionViv <> "" And numVivienda <> "" And codPostalViv <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Vivienda (id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda) VALUES(" & idVivienda & ", '" & direccionViv & "', '" & numVivienda & "', '" & codPostalViv & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos para la vivienda, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE LA TABLA VIVIENDA
    'Actualiza datos de una VIVIENDA específica
    Public Sub actualizaVivienda()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idVivienda <> 0 And direccionViv <> "" And numVivienda <> "" And codPostalViv <> "" Then

            'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
            ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
            ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

            strSql = "UPDATE Vivienda SET direccion_vivienda = '" & direccionViv & "', numero_vivienda = '" & numVivienda & "', cod_postal_vivienda = '" & codPostalViv &
                     "' WHERE id_vivienda = " & idVivienda
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para la vivienda !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA UNA VIVIENDA EN ESPECIFICO DE LA TABLA VIVIENDA Y REGRESA TRUE O FALSE
    'Consulta un VIVIENDA en específico
    Public Function consultaUnIdVivienda() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_vivienda FROM Vivienda " &
                 "WHERE id_vivienda = " & idVivienda

        consultaUnIdVivienda = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdVivienda = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY HABITANTES QUE DEPENDEN DE ALGUNA VIVIENDA
    Public Function validaVivienda() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Habitante " &
                 " WHERE id_vivienda = " & idVivienda
        validaVivienda = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaVivienda = True
        End If
    End Function

    'MÉTODO QUE ELIMINA REGISTROS (ID) DE LA TABLA VIVIENDA
    Public Sub eliminarVivienda()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idVivienda <> 0 And direccionViv <> "" And numVivienda <> "" And codPostalViv <> "" Then
            strSql = "DELETE FROM Vivienda " &
                     " WHERE id_vivienda = " & idVivienda
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DE LA VIVIENDA !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO VIVIENDA
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_vivienda)+1 FROM Vivienda", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmVivienda.TbIdVivienda.Text = registro("MAX(id_vivienda)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA VIVIENDA***************************************
End Class
