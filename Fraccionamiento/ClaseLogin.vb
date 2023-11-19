Public Class ClaseLogin

    'VARIABLES UTILIZADAS EN LOGIN
    Private empleado As Integer
    Private contrasena As String

    '*****************************INICIAR SESIÓN**********************************************
    'Método constructor inicializa variables PARA INICIAR SESIÓN
    Public Sub New()
        'Si tus variables son de otro tipo (numeric,Integer, etc) tendrías que iniciarlas en 0
        empleado = 0
        contrasena = ""
    End Sub

    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal empleadoL As Integer, ByVal contrasenaL As String)
        'Aquí recibimos los datos
        empleado = empleadoL
        contrasena = contrasenaL
    End Sub

    'Métodos get y set para iniciar SESIÓN
    Public Property getSetEmpleado() As Integer
        Get
            Return empleado
        End Get
        Set(ByVal Value As Integer)
            empleado = Value
        End Set
    End Property

    Public Property getSetContrasena() As String
        Get
            Return contrasena
        End Get
        Set(ByVal Value As String)
            contrasena = Value
        End Set
    End Property
    'AQUI TERMINA LOS GET Y SET DE LA TABLA LOGIN

    'MÉTODO QUE CONSULTA EL USUARIO INGRESADO Y COMPRUEBA SI EXISTE O NO
    Public Function consultaEmpleado() As Boolean

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_empleado FROM Empleado " &
                 "WHERE id_empleado = " & empleado

        consultaEmpleado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaEmpleado = True
        End If
    End Function

    'MÉTODO QUE CONSULTA EL USUARIO Y CONTRASEÑA INGRESADO Y COMPRUEBA SI ESTAN CORRECTOS
    Public Function consultaUsuarContr() As Boolean

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_empleado, contrasena FROM Empleado " &
                 "WHERE id_empleado = " & empleado &
                 " AND contrasena = '" & contrasena & "'"

        consultaUsuarContr = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUsuarContr = True
        End If
    End Function
    '**************************FIN DE LAS OPERACIONES DEL LOGIN****************************************
End Class
