Imports Oracle.DataAccess.Client

Public Class ClaseColor
    'VARIABLES UTILIZADAS EN EL FORMULARIO COLOR
    Private idColor As Integer
    Private color As String
    '************************************TABLA COLOR***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA COLOR--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí inicializamos los datos
        idColor = 0
        color = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA COLOR
    Public Sub New(ByVal elIdColor As Integer, ByVal elColor As String)
        'Aquí recibimos los datos
        idColor = elIdColor
        color = elColor

    End Sub

    '-------------------------MÉTODOS GET Y SET DE LA TABLA COLOR--------------------------------------
    'Métodos get y set TABLA COLOR
    Public Property getSetIdColor() As Integer
        Get
            Return idColor
        End Get
        Set(ByVal Value As Integer)
            idColor = Value
        End Set
    End Property

    Public Property getSetColor() As String
        Get
            Return color
        End Get
        Set(ByVal Value As String)
            color = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA COLOR
    Public Function consultaTodosColores() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los colores registrados en la tabla de Color
        ' para llenar el DGV correspondiente
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "Select id_color As ID, color As COLOR " &
                 "FROM Color " &
                 "ORDER BY id_color ASC"

        consultaTodosColores = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO COLOR POR MEDIO DEL MÉTODO CONSULTATODOSCOLORES()
    Public Sub PoblarDataGridColor(ByVal DGVColor As DataGridView)
        'Método que lee todos los colores del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVColor.DataSource = consultaTodosColores()

        'Con el refresh actualiza el contenido del DGV

        DGVColor.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVColor.Columns.Item(0).Width = 135
        DGVColor.Columns.Item(1).Width = 98
    End Sub

    'MÉTODO QUE INSERTA REGISTROS A LA TABLA COLOR
    'Inserta nuevo color en la tabla correspondiente
    'la tabla tiene 2 atributos, por lo tanto se requieren de 2 valores
    Public Sub insertaColor()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idColor <> 0 And color <> "" Then
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

            strSql = "INSERT INTO Color VALUES(" & idColor & ", " & "'" & color & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos para el color, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE LA TABLA COLOR
    'Actualiza datos de un color específico
    Public Sub actualizaColor()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idColor <> 0 And color <> "" Then

            'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
            ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
            ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

            strSql = "UPDATE Color SET color = '" & color &
                     "' WHERE id_color = " & idColor
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para el color !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA UN COLOR EN ESPECIFICO DE LA TABLA COLOR Y REGRESA TRUE O FALSE
    'Consulta un color en específico
    Public Function consultaUnIdColor() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_color FROM Color " &
                 "WHERE id_color = " & idColor

        consultaUnIdColor = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdColor = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY AUTOMÓVILES QUE DEPENDEN DE ALGÚN COLOR
    Public Function validaColores() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Vehiculo " &
                 " WHERE id_color = " & idColor
        validaColores = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaColores = True
        End If
    End Function

    'MÉTODO QUE ELIMINA REGISTROS (ID) DE LA TABLA COLOR
    Public Sub eliminarColor()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idColor <> 0 And color <> "" Then
            strSql = "DELETE FROM Color " &
                     " WHERE id_color = " & idColor
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DEL COLOR !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO COLOR
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_color)+1 FROM Color", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmColor.TxtIdColor.Text = registro("MAX(id_color)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA COLOR***************************************
End Class
