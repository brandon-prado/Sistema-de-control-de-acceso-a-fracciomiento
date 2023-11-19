Imports Oracle.DataAccess.Client

Public Class ClaseEmpresa
    'VARIABLES UTILIZADAS EN EL FORMULARIO EMPRESA
    Private idEmpresa As Integer
    Private nombreEmpresa As String
    Private direccionEmpr As String
    Private numDirEmpr As String
    Private codPostEmpr As String
    Private telefEmpr As String
    Private correoEmpr As String
    Private pagWebEmpr As String
    Private rfcEmpr As String

    '************************************TABLA EMPRESA***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA EMPRESA--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí recibimos los datos
        idEmpresa = 0
        nombreEmpresa = ""
        direccionEmpr = ""
        numDirEmpr = ""
        codPostEmpr = ""
        telefEmpr = ""
        correoEmpr = ""
        pagWebEmpr = ""
        rfcEmpr = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA EMPRESA
    Public Sub New(ByVal elIdEmpr As Integer, ByVal elNomEmpr As String, ByVal laDirEmpr As String, ByVal elNumDirEmpr As String, ByVal elCodPostEmp As String, ByVal elTelEmpr As String, ByVal elCorrEmpr As String, ByVal laPagWebEmpr As String, ByVal elRfcEmpr As String)
        'Aquí recibimos los datos
        idEmpresa = elIdEmpr
        nombreEmpresa = elNomEmpr
        direccionEmpr = laDirEmpr
        numDirEmpr = elNumDirEmpr
        codPostEmpr = elCodPostEmp
        telefEmpr = elTelEmpr
        correoEmpr = elCorrEmpr
        pagWebEmpr = laPagWebEmpr
        rfcEmpr = elRfcEmpr

    End Sub

    'Métodos get y set TABLA EMPRESA
    Public Property getSetIdEmpres() As Integer
        Get
            Return idEmpresa
        End Get
        Set(ByVal Value As Integer)
            idEmpresa = Value
        End Set
    End Property

    Public Property getSetNombEmpr() As String
        Get
            Return nombreEmpresa
        End Get
        Set(ByVal Value As String)
            nombreEmpresa = Value
        End Set
    End Property

    Public Property getSetDirecEmpr() As String
        Get
            Return direccionEmpr
        End Get
        Set(ByVal Value As String)
            direccionEmpr = Value
        End Set
    End Property

    Public Property getSetNumDirEmpr() As String
        Get
            Return numDirEmpr
        End Get
        Set(ByVal Value As String)
            numDirEmpr = Value
        End Set
    End Property

    Public Property getSetCodPostEmpr() As String
        Get
            Return codPostEmpr
        End Get
        Set(ByVal Value As String)
            codPostEmpr = Value
        End Set
    End Property

    Public Property getSetTelEmpr() As String
        Get
            Return telefEmpr
        End Get
        Set(ByVal Value As String)
            telefEmpr = Value
        End Set
    End Property

    Public Property getSetCorrEmpr() As String
        Get
            Return correoEmpr
        End Get
        Set(ByVal Value As String)
            correoEmpr = Value
        End Set
    End Property

    Public Property getSetPagWebEmpr() As String
        Get
            Return pagWebEmpr
        End Get
        Set(ByVal Value As String)
            pagWebEmpr = Value
        End Set
    End Property

    Public Property getSetRfcEmpr() As String
        Get
            Return rfcEmpr
        End Get
        Set(ByVal Value As String)
            rfcEmpr = Value
        End Set
    End Property
    'AQUI TERMINA LOS GET Y SET DE LA TABLA EMPRESA

    'MÉTODO QUE CONSULTA SI EXISTE UN ID DE EMPRESA DE LA TABLA EMPRESA Y REGRESA TRUE/FALSE
    'Consulta una empresa en específico
    Public Function consultaUnIdEmpresa() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_empresa FROM Empresa " &
                 "WHERE id_empresa = " & idEmpresa

        consultaUnIdEmpresa = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdEmpresa = True
        End If
    End Function

    'MÉTODO QUE INSERTA UN REGISTRO A LA TABLA EMPRESA
    'Inserta nueva empresa en la tabla correspondiente
    'la tabla tiene 9 atributos, por lo tanto se requieren de 9 valores
    Public Sub insertaEmpresa()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idEmpresa <> 0 And nombreEmpresa <> "" And direccionEmpr <> "" And numDirEmpr <> "" And codPostEmpr <> "" And telefEmpr <> "" And correoEmpr <> "" And pagWebEmpr <> "" And rfcEmpr <> "" Then
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

            strSql = "INSERT INTO Empresa (id_empresa, nombre_empr, direccion_empr, num_direccion, cod_postal_empr, telefono_empr, correo_empr, pag_web, rfc_empr) VALUES(" & idEmpresa & ", " & "'" & nombreEmpresa & "', " & "'" & direccionEmpr & "' , " & "'" & numDirEmpr & "' , " & "'" & codPostEmpr & "' , " & "'" & telefEmpr & "' , " & "'" & correoEmpr & "' , " & "'" & pagWebEmpr & "' , " & "'" & rfcEmpr & "' )"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 

            MsgBox("Faltan datos para la empresa, verifique !! ", MsgBoxStyle.Critical, " ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE UN EMPRESA EN ESPECIFICO
    'Actualiza datos de una empresa en específico
    Public Sub actualizaEmpresa()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEmpresa <> 0 And nombreEmpresa <> "" And direccionEmpr <> "" And numDirEmpr <> "" And codPostEmpr <> "" And telefEmpr <> "" And correoEmpr <> "" And pagWebEmpr <> "" And rfcEmpr <> "" Then

            'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
            ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
            ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

            strSql = "UPDATE Empresa SET nombre_empr = '" & nombreEmpresa & "', direccion_empr = '" & direccionEmpr &
                "', num_direccion = '" & numDirEmpr & "', cod_postal_empr = '" & codPostEmpr & "', telefono_empr = '" & telefEmpr &
                "', correo_empr = '" & correoEmpr & "', pag_web = '" & pagWebEmpr & "', rfc_empr = '" & rfcEmpr &
                     "' WHERE id_empresa = " & idEmpresa

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para la empresa, verifique !! ", MsgBoxStyle.Critical, " ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE VÁLIDA SI HAY EMPLEADOS QUE DEPENDEN DE ALGUNA EMPRESA
    Public Function validaEmpresa() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Empleado " &
                 " WHERE id_empresa = " & idEmpresa

        validaEmpresa = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaEmpresa = True
        End If
    End Function

    'MÉTODO QUE ELIMINAR UNA EMPRESA POR MEDIO DE SU ID
    Public Sub eliminarEmpresa()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idEmpresa <> 0 And nombreEmpresa <> "" And direccionEmpr <> "" And numDirEmpr <> "" And codPostEmpr <> "" And telefEmpr <> "" And correoEmpr <> "" And pagWebEmpr <> "" And rfcEmpr <> "" Then

            strSql = "DELETE FROM Empresa " &
                     " WHERE id_empresa = " & idEmpresa

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DE LA EMPRESA !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA TODAS LAS EMPRESAS REGISTRADAS EN LA TABLA EMPRESA
    Public Function consultaTodasEmpresas() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las empresas registradas en la tabla de Empresa
        ' para llenar el DGV correspondiente
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_empresa As ""ID"", nombre_empr As ""NOMBRE"", direccion_empr As ""DIRECCIÓN"", num_direccion As ""NÚMERO #"", cod_postal_empr As ""C.POSTAL"", telefono_empr As ""TELÉFONO"", correo_empr As ""CORREO"", pag_web As ""PÁG. WEB"", rfc_empr As ""RFC"" FROM Empresa ORDER BY id_empresa ASC"

        consultaTodasEmpresas = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO DE EMPRESA
    Public Sub PoblarDataGridEmpresa(ByVal DGVEmpresa As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVEmpresa.DataSource = consultaTodasEmpresas()

        'Con el refresh actualiza el contenido del DGV

        DGVEmpresa.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVEmpresa.Columns.Item(0).Width = 40
        DGVEmpresa.Columns.Item(1).Width = 120
        DGVEmpresa.Columns.Item(2).Width = 120
        DGVEmpresa.Columns.Item(3).Width = 95
        DGVEmpresa.Columns.Item(4).Width = 80
        DGVEmpresa.Columns.Item(5).Width = 100
        DGVEmpresa.Columns.Item(6).Width = 120
        DGVEmpresa.Columns.Item(7).Width = 120
        DGVEmpresa.Columns.Item(8).Width = 110
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO EMPRESA
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_empresa)+1 FROM Empresa", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmEmpresa.TbIdEmpresa.Text = registro("MAX(id_empresa)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA EMPRESA***************************************
End Class
