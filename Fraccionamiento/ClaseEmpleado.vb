Imports Oracle.DataAccess.Client

Public Class ClaseEmpleado
    'VARIABLES UTILIZADAS EN EL FORMULARIO EMPLEADO
    Private idEmpleado As Integer
    Private idGenero As Integer
    Private idHorario As Integer
    Private idEmpresa As Integer
    Private nombreEmpl As String
    Private paternoEmpl As String
    Private maternoEmpl As String
    Private telefonoEmpl As String
    Private ineEmpl As String
    Private sueldo As String
    Private contrasena As String
    '************************************TABLA EMPLEADO***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA EMPLEADO--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí inicializamos los datos
        idEmpleado = 0
        idGenero = 0
        idHorario = 0
        idEmpresa = 0
        nombreEmpl = ""
        paternoEmpl = ""
        maternoEmpl = ""
        telefonoEmpl = ""
        ineEmpl = ""
        sueldo = ""
        contrasena = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA EMPLEADO
    Public Sub New(ByVal elIdEmpl As Integer, ByVal elIdGenero As Integer, ByVal elIdHorario As Integer, ByVal elIdEmpr As Integer, ByVal elNombEpl As String, ByVal elPaternEmpl As String, ByVal elMaterEmpl As String, ByVal elTelefEmpl As String, ByVal elIneEmpl As String, ByVal elSueldoEmpl As String, ByVal laContrasena As String)
        'Aquí recibimos los datos
        idEmpleado = elIdEmpl
        idGenero = elIdGenero
        idHorario = elIdHorario
        idEmpresa = elIdEmpr
        nombreEmpl = elNombEpl
        paternoEmpl = elPaternEmpl
        maternoEmpl = elMaterEmpl
        telefonoEmpl = elTelefEmpl
        ineEmpl = elIneEmpl
        sueldo = elSueldoEmpl
        contrasena = laContrasena

    End Sub

    '-------------------------MÉTODOS GET Y SET DE LA TABLA EMPLEADO--------------------------------------
    'Métodos get y set TABLA EMPLEADO
    Public Property getSetIdEmpl() As Integer
        Get
            Return idEmpleado
        End Get
        Set(ByVal Value As Integer)
            idEmpleado = Value
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

    Public Property getSetIdHorario() As Integer
        Get
            Return idHorario
        End Get
        Set(ByVal Value As Integer)
            idHorario = Value
        End Set
    End Property

    Public Property getSetIdEmpr() As Integer
        Get
            Return idEmpresa
        End Get
        Set(ByVal Value As Integer)
            idEmpresa = Value
        End Set
    End Property

    Public Property getSetNombreEmpl() As String
        Get
            Return nombreEmpl
        End Get
        Set(ByVal Value As String)
            nombreEmpl = Value
        End Set
    End Property

    Public Property getSetPaterEmpl() As String
        Get
            Return paternoEmpl
        End Get
        Set(ByVal Value As String)
            paternoEmpl = Value
        End Set
    End Property

    Public Property getSetMaterEmpl() As String
        Get
            Return maternoEmpl
        End Get
        Set(ByVal Value As String)
            maternoEmpl = Value
        End Set
    End Property

    Public Property getSetTelEmpl() As String
        Get
            Return telefonoEmpl
        End Get
        Set(ByVal Value As String)
            telefonoEmpl = Value
        End Set
    End Property

    Public Property getSetIneEmpl() As String
        Get
            Return ineEmpl
        End Get
        Set(ByVal Value As String)
            ineEmpl = Value
        End Set
    End Property

    Public Property getSetSueldoEmpl() As String
        Get
            Return sueldo
        End Get
        Set(ByVal Value As String)
            sueldo = Value
        End Set
    End Property

    Public Property getSetContrEmpl() As String
        Get
            Return contrasena
        End Get
        Set(ByVal Value As String)
            contrasena = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA EMPLEADO
    Public Function consultaTodosEmpleados() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los colores registrados en la tabla de Color
        ' para llenar el DGV correspondiente
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "Select id_empleado As ID, nombre_empl As NOMBRE, paterno_empl As PATERNO, materno_empl As MATERNO, genero As ""GÉNERO"", hora_inicio_lab As ENTRADA, hora_fin_lab As SALIDA, telefono_empl As ""TELÉFONO"", nombre_empr As EMPRESA, ine_empl As ""FOLIO INE"", sueldo As SUELDO, contrasena AS ""PASSWORD"" FROM Empleado empl, Genero g, Horario_laboral h, Empresa empr WHERE empl.id_genero = g.id_genero AND empl.id_horario = h.id_horario AND empl.id_empresa = empr.id_empresa ORDER BY id_empleado ASC"

        consultaTodosEmpleados = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO EMPLEADO POR MEDIO DEL MÉTODO CONSULTATODOSEMPLEADOS()
    Public Sub PoblarDataGridColor(ByVal DGVEmpl As DataGridView)
        'Método que lee todos los empleados del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVEmpl.DataSource = consultaTodosEmpleados()

        'Con el refresh actualiza el contenido del DGV

        DGVEmpl.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVEmpl.Columns.Item(0).Width = 40
        DGVEmpl.Columns.Item(1).Width = 100
        DGVEmpl.Columns.Item(2).Width = 88
        DGVEmpl.Columns.Item(3).Width = 88
        DGVEmpl.Columns.Item(4).Width = 88
        DGVEmpl.Columns.Item(5).Width = 68
        DGVEmpl.Columns.Item(6).Width = 60
        DGVEmpl.Columns.Item(7).Width = 88
        DGVEmpl.Columns.Item(8).Width = 120
        DGVEmpl.Columns.Item(9).Width = 100
        DGVEmpl.Columns.Item(10).Width = 60
    End Sub

    'MÉTODO QUE INSERTA REGISTROS A LA TABLA EMPLEADO
    'Inserta nuevo empleado en la tabla correspondiente
    'la tabla tiene 11 atributos, por lo tanto se requieren de 11 valores
    Public Sub insertaEmpleado()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idEmpleado <> 0 And idGenero <> 0 And idHorario <> 0 And idEmpresa <> 0 And nombreEmpl <> "" And paternoEmpl <> "" And maternoEmpl <> "" And telefonoEmpl <> "" And ineEmpl <> "" And sueldo <> "" And contrasena <> "" Then
            'Realiza inserción de datos

            strSql = "INSERT INTO Empleado (id_empleado, id_genero, id_horario, id_empresa, nombre_empl, paterno_empl, materno_empl, telefono_empl, ine_empl, sueldo, contrasena) VALUES (" & idEmpleado & ", " & idGenero & ", " & idHorario & ", " & idEmpresa & ", '" & nombreEmpl & "', '" & paternoEmpl & "', '" & maternoEmpl & "', '" & telefonoEmpl & "', '" & ineEmpl & "', '" & sueldo & "', '" & contrasena & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos para el empleado, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE LA TABLA EMPLEADO
    'Actualiza datos de un empleado específico
    Public Sub actualizaEmpleado()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEmpleado <> 0 And idGenero <> 0 And idHorario <> 0 And idEmpresa <> 0 And nombreEmpl <> "" And paternoEmpl <> "" And maternoEmpl <> "" And telefonoEmpl <> "" And ineEmpl <> "" And sueldo <> "" And contrasena <> "" Then

            'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
            ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
            ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

            strSql = "UPDATE Empleado SET id_genero = " & idGenero & ", id_horario = " & idHorario & ", id_empresa = " & idEmpresa & ", nombre_empl = '" & nombreEmpl & "', paterno_empl = '" & paternoEmpl & "', materno_empl = '" & maternoEmpl & "', telefono_empl = '" & telefonoEmpl & "', ine_empl = '" & ineEmpl & "', sueldo = '" & sueldo & "', contrasena = '" & contrasena & "' " &
                     "WHERE id_empleado = " & idEmpleado
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para el empleado !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA UN EMPLEADO EN ESPECIFICO DE LA TABLA EMPLEADO Y REGRESA TRUE O FALSE
    'Consulta un EMPLEADO en específico
    Public Function consultaUnIdEmpleado() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_empleado FROM Empleado " &
                 "WHERE id_empleado = " & idEmpleado

        consultaUnIdEmpleado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdEmpleado = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY CASETAS QUE DEPENDEN DE ALGÚN EMPLEADO
    Public Function validaEmpleado() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Caseta " &
                 " WHERE id_empleado = " & idEmpleado
        validaEmpleado = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaEmpleado = True
        End If
    End Function

    'MÉTODO QUE ELIMINA REGISTROS (ID) DE LA TABLA EMPLEADO
    Public Sub eliminarEmpleado()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idEmpleado <> 0 And idGenero <> 0 And idHorario <> 0 And idEmpresa <> 0 And nombreEmpl <> "" And paternoEmpl <> "" And maternoEmpl <> "" And telefonoEmpl <> "" And ineEmpl <> "" And sueldo <> "" And contrasena <> "" Then
            strSql = "DELETE FROM Empleado " &
                     " WHERE id_empleado = " & idEmpleado
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DEL EMPLEADO !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE GENERO DE LA TABLA EMPLEADO
    Public Sub poblarComboGeneros()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT genero FROM Genero ORDER BY id_genero"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmEmpleado.CbGeneroD
            .DataSource = xDT
            .DisplayMember = "id_genero"
            .ValueMember = "genero"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DEL GÉNERO EN LA TABLA EMPLEADO
    Public Sub mostrarIdDelGenero()
        Dim xDT As New DataTable

        If FrmEmpleado.CbGeneroD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_genero FROM genero WHERE genero = '" & FrmEmpleado.CbGeneroD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmEmpleado.LbIdGenero.Text = registro("id_genero").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE HORA ENTRADA DE LA TABLA EMPLEADO
    Public Sub poblarComboHoraEntrada()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT hora_inicio_lab FROM Horario_laboral"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmEmpleado.CbHoraInicioD
            .DataSource = xDT
            .DisplayMember = "id_horario"
            .ValueMember = "hora_inicio_lab"
        End With

    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE HORA SALIDA DE LA TABLA EMPLEADO
    Public Sub poblarComboHoraSalida()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT hora_fin_lab FROM Horario_laboral"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmEmpleado.CbHoraFinD
            .DataSource = xDT
            .DisplayMember = "id_horario"
            .ValueMember = "hora_fin_lab"
        End With

    End Sub

    'MÉTODO PARA MOSTRAR EL ID DEL HORARIO EN LA TABLA EMPLEADO
    Public Sub mostrarIdDelHorario()
        Dim xDT As New DataTable

        If FrmEmpleado.CbHoraInicioD.ValueMember.ToString <> "" And FrmEmpleado.CbHoraFinD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_horario FROM Horario_laboral WHERE hora_inicio_lab = '" & FrmEmpleado.CbHoraInicioD.SelectedValue.ToString & "' AND hora_fin_lab = '" & FrmEmpleado.CbHoraFinD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmEmpleado.LbIdHorario.Text = registro("id_horario").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA POBLAR UN COMBO BOX DE EMPRESA DE LA TABLA EMPLEADO
    Public Sub poblarComboEmpresas()
        Dim strSql As String
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT nombre_empr FROM Empresa ORDER BY id_empresa"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmEmpleado.CbEmpresaD
            .DataSource = xDT
            .DisplayMember = "id_empresa"
            .ValueMember = "nombre_empr"
        End With
    End Sub
    'MÉTODO PARA MOSTRAR EL ID DE LA EMPRESA EN LA TABLA EMPLEADO
    Public Sub mostrarIdDeEmpresa()
        Dim xDT As New DataTable

        If FrmEmpleado.CbEmpresaD.ValueMember.ToString <> "" Then
            Dim conector As New OracleDataAdapter("SELECT id_empresa FROM Empresa WHERE nombre_empr = '" & FrmEmpleado.CbEmpresaD.SelectedValue.ToString & "'", cnx)

            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmEmpleado.LbIdEmpresa.Text = registro("id_empresa").ToString
            Next
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO EMPLEADO
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_empleado)+1 FROM Empleado", cnx)

            conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmEmpleado.TbIdEmpleado.Text = registro("MAX(id_empleado)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA EMPLEADO***************************************
End Class
