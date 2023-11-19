Imports Oracle.DataAccess.Client

Public Class ClaseGenero
    'VARIABLES UTILIZADAS EN EL FORMULARIO GÉNERO
    Private idGenero As Integer
    Private genero As String
    '************************************TABLA GÉNERO***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA GÉNERO--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí inicializamos los datos
        idGenero = 0
        genero = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA GÉNERO
    Public Sub New(ByVal elIdGenero As Integer, ByVal elGenero As String)
        'Aquí recibimos los datos
        idGenero = elIdGenero
        genero = elGenero

    End Sub

    '-------------------------MÉTODOS GET Y SET DE LA TABLA GÉNERO--------------------------------------
    'Métodos get y set TABLA GÉNERO
    Public Property getSetIdGenero() As Integer
        Get
            Return idGenero
        End Get
        Set(ByVal Value As Integer)
            idGenero = Value
        End Set
    End Property

    Public Property getSetGenero() As String
        Get
            Return genero
        End Get
        Set(ByVal Value As String)
            genero = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA GÉNERO
    Public Function consultaTodosGeneros() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los colores registrados en la tabla de género
        ' para llenar el DGV correspondiente
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "Select id_genero As ID, genero As ""GÉNERO"" " &
                 "FROM Genero " &
                 "ORDER BY id_genero ASC"

        consultaTodosGeneros = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO GÉNERO POR MEDIO DEL MÉTODO CONSULTATODOSGENEROS()
    Public Sub PoblarDataGridGenero(ByVal DGVGenero As DataGridView)
        'Método que lee todos los generos del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVGenero.DataSource = consultaTodosGeneros()

        'Con el refresh actualiza el contenido del DGV

        DGVGenero.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVGenero.Columns.Item(0).Width = 190
        DGVGenero.Columns.Item(1).Width = 98
    End Sub

    'MÉTODO QUE INSERTA REGISTROS A LA TABLA GÉNERO
    'Inserta nuevo género en la tabla correspondiente
    'la tabla tiene 2 atributos, por lo tanto se requieren de 2 valores
    Public Sub insertaGenero()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idGenero <> 0 And genero <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Genero VALUES(" & idGenero & ", " & "'" & genero & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos para el género, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE LA TABLA GÉNERO
    'Actualiza datos de un GÉNERO específico
    Public Sub actualizaGenero()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idGenero <> 0 And genero <> "" Then

            'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
            ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
            ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

            strSql = "UPDATE Genero SET genero = '" & genero &
                     "' WHERE id_genero = " & idGenero
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para el género !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA UN GÉNERO EN ESPECIFICO DE LA TABLA GÉNERO Y REGRESA TRUE O FALSE
    'Consulta un GÉNERO en específico
    Public Function consultaUnIdGenero() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_genero FROM Genero " &
                 "WHERE id_genero = " & idGenero

        consultaUnIdGenero = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdGenero = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY EMPLEADOS QUE DEPENDEN DE ALGÚN GÉNERO
    Public Function validaGeneroEmpl() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Empleado " &
                 " WHERE id_genero = " & idGenero
        validaGeneroEmpl = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaGeneroEmpl = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY HABITANTES QUE DEPENDEN DE ALGÚN GÉNERO
    Public Function validaGeneroHab() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Habitante " &
                 " WHERE id_genero = " & idGenero
        validaGeneroHab = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaGeneroHab = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY VISITANTES QUE DEPENDEN DE ALGÚN GÉNERO
    Public Function validaGeneroVis() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Visitante " &
                 " WHERE id_genero = " & idGenero
        validaGeneroVis = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaGeneroVis = True
        End If
    End Function

    'MÉTODO QUE ELIMINA REGISTROS (ID) DE LA TABLA GÉNERO
    Public Sub eliminarGenero()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idGenero <> 0 And genero <> "" Then
            strSql = "DELETE FROM Genero " &
                     " WHERE id_genero = " & idGenero
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DEL GÉNERO !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO GÉNERO
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_genero)+1 FROM Genero", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmGenero.TbIdGenero.Text = registro("MAX(id_genero)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA GÉNERO***************************************
End Class
