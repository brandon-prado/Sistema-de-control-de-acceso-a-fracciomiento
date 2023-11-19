
Imports Oracle.DataAccess.Client

Public Class ClaseHorarioLab
    'VARIABLES UTILIZADAS EN EL FORMULARIO HORAIO_LABORAL
    Private idHorario As Integer
    Private turnoMat As Boolean
    Private turnoVesp As Boolean
    Private turnoNoct As Boolean
    Private horaInicio As String
    Private horaFin As String
    '************************************TABLA HORARIO LABORAL***************************************************
    '------------------------MÉTODO CONSTRUCTOR DE LA TABLA HORARIO LABORAL--------------------------------------
    'Método constructor vacío
    Public Sub New()
        'Aquí inicializamos los datos
        idHorario = 0
        turnoMat = False
        turnoVesp = False
        turnoNoct = False
        horaInicio = ""
        horaFin = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto TABLA HORARIO LABORAL
    Public Sub New(ByVal elIdHorario As Integer, ByVal elTurnoMat As Boolean, ByVal elTurnoVesp As Boolean, ByVal elTurnoNoct As Boolean, ByVal laHoraInicio As String, ByVal laHoraFin As String)
        'Aquí recibimos los datos
        idHorario = elIdHorario
        turnoMat = elTurnoMat
        turnoVesp = elTurnoVesp
        turnoNoct = elTurnoNoct
        horaInicio = laHoraInicio
        horaFin = laHoraFin
    End Sub

    '-------------------------MÉTODOS GET Y SET DE LA TABLA HORARIO LABORAL--------------------------------------
    'Métodos get y set TABLA HORARIO LABORAL
    Public Property getSetIdHorarioLab() As Integer
        Get
            Return idHorario
        End Get
        Set(ByVal Value As Integer)
            idHorario = Value
        End Set
    End Property

    Public Property getSetTurnMat() As Boolean
        Get
            Return turnoMat
        End Get
        Set(ByVal Value As Boolean)
            turnoMat = Value
        End Set
    End Property

    Public Property getSetTurnVesp() As Boolean
        Get
            Return turnoVesp
        End Get
        Set(ByVal Value As Boolean)
            turnoVesp = Value
        End Set
    End Property

    Public Property getSetTurnNoct() As Boolean
        Get
            Return turnoNoct
        End Get
        Set(ByVal Value As Boolean)
            turnoNoct = Value
        End Set
    End Property

    Public Property getSetHoraInicio() As String
        Get
            Return horaInicio
        End Get
        Set(ByVal Value As String)
            horaInicio = Value
        End Set
    End Property

    Public Property getSetHoraFin() As String
        Get
            Return horaFin
        End Get
        Set(ByVal Value As String)
            horaFin = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA HORARIO LABORAL
    Public Function consultaTodosHorario() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas los colores registrados en la HORARIO LABORAL
        ' para llenar el DGV correspondiente
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_horario As ID, turno_matutino As MATUTINO, turno_vespertino As VESPERTINO, turno_nocturno As NOCTURNO, " &
                 "hora_inicio_lab ""HORA INICIO"", hora_fin_lab ""HORA FIN"" FROM Horario_laboral " &
                 "ORDER BY id_horario ASC"

        consultaTodosHorario = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO HORARIO LABORAL POR MEDIO DEL MÉTODO consultaTodosHorario()
    Public Sub PoblarDataGridHorarioL(ByVal DGVHorarioL As DataGridView)
        'Método que lee todos los HORARIOS del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        DGVHorarioL.DataSource = consultaTodosHorario()

        'Con el refresh actualiza el contenido del DGV

        DGVHorarioL.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVHorarioL.Columns.Item(0).Width = 25
        DGVHorarioL.Columns.Item(1).Width = 80
        DGVHorarioL.Columns.Item(2).Width = 80
        DGVHorarioL.Columns.Item(3).Width = 80
        DGVHorarioL.Columns.Item(4).Width = 100
        DGVHorarioL.Columns.Item(5).Width = 95
    End Sub

    'MÉTODO QUE INSERTA REGISTROS A LA TABLA HORARIO LABORAL
    'Inserta nuevo horario en la tabla correspondiente
    'la tabla tiene 6 atributos, por lo tanto se requieren de 6 valores
    Public Sub insertaHorario()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idHorario <> 0 And turnoMat = True And turnoVesp = True And turnoNoct = True And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Horario_laboral (id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab) VALUES(" & idHorario & ", 'S', 'S', 'S', '" & horaInicio & "', '" & horaFin & "')"
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = True And turnoVesp = True And turnoNoct = False And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Horario_laboral (id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab) VALUES(" & idHorario & ", 'S', 'S', 'N', '" & horaInicio & "', '" & horaFin & "')"
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = True And turnoVesp = False And turnoNoct = True And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Horario_laboral (id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab) VALUES(" & idHorario & ", 'S', 'N', 'S', '" & horaInicio & "', '" & horaFin & "')"
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = False And turnoVesp = True And turnoNoct = True And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Horario_laboral (id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab) VALUES(" & idHorario & ", 'N', 'S', 'S', '" & horaInicio & "', '" & horaFin & "')"
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = True And turnoVesp = False And turnoNoct = False And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Horario_laboral (id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab) VALUES(" & idHorario & ", 'S', 'N', 'N', '" & horaInicio & "', '" & horaFin & "')"
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = False And turnoVesp = True And turnoNoct = False And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Horario_laboral (id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab) VALUES(" & idHorario & ", 'N', 'S', 'N', '" & horaInicio & "', '" & horaFin & "')"
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = False And turnoVesp = False And turnoNoct = True And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO Horario_laboral (id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab) VALUES(" & idHorario & ", 'N', 'N', 'S', '" & horaInicio & "', '" & horaFin & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 
            MsgBox("Faltan datos para del horario, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE ACTUALIZA LOS DATOS DE LA HORARIO LABORAL
    'Actualiza datos de un horario específico
    Public Sub actualizaHorario()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idHorario <> 0 And turnoMat = True And turnoVesp = True And turnoNoct = True And horaInicio <> "" And horaFin <> "" Then
            strSql = "UPDATE Horario_laboral SET turno_matutino = 'S', turno_vespertino = 'S', turno_nocturno = 'S', hora_inicio_lab = '" & horaInicio & "', hora_fin_lab = '" & horaFin & "' WHERE id_horario = " & idHorario
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = True And turnoVesp = True And turnoNoct = False And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "UPDATE Horario_laboral SET turno_matutino = 'S', turno_vespertino = 'S', turno_nocturno = 'N', hora_inicio_lab = '" & horaInicio & "', hora_fin_lab = '" & horaFin & "' WHERE id_horario = " & idHorario
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = True And turnoVesp = False And turnoNoct = True And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "UPDATE Horario_laboral SET turno_matutino = 'S', turno_vespertino = 'N', turno_nocturno = 'S', hora_inicio_lab = '" & horaInicio & "', hora_fin_lab = '" & horaFin & "' WHERE id_horario = " & idHorario
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = False And turnoVesp = True And turnoNoct = True And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "UPDATE Horario_laboral SET turno_matutino = 'N', turno_vespertino = 'S', turno_nocturno = 'S', hora_inicio_lab = '" & horaInicio & "', hora_fin_lab = '" & horaFin & "' WHERE id_horario = " & idHorario
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = True And turnoVesp = False And turnoNoct = False And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "UPDATE Horario_laboral SET turno_matutino = 'S', turno_vespertino = 'N', turno_nocturno = 'N', hora_inicio_lab = '" & horaInicio & "', hora_fin_lab = '" & horaFin & "' WHERE id_horario = " & idHorario
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = False And turnoVesp = True And turnoNoct = False And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "UPDATE Horario_laboral SET turno_matutino = 'N', turno_vespertino = 'S', turno_nocturno = 'F', hora_inicio_lab = '" & horaInicio & "', hora_fin_lab = '" & horaFin & "' WHERE id_horario = " & idHorario
            xCnx.objetoCommand(strSql)
        ElseIf idHorario <> 0 And turnoMat = False And turnoVesp = False And turnoNoct = True And horaInicio <> "" And horaFin <> "" Then
            'Realiza inserción de datos
            strSql = "UPDATE Horario_laboral SET turno_matutino = 'N', turno_vespertino = 'N', turno_nocturno = 'S', hora_inicio_lab = '" & horaInicio & "', hora_fin_lab = '" & horaFin & "' WHERE id_horario = " & idHorario
            xCnx.objetoCommand(strSql)

        Else
            MsgBox("Faltan datos para del horario, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO QUE CONSULTA UN HORARIO EN ESPECIFICO DE LA TABLA HORARIO LABORAL Y REGRESA TRUE O FALSE
    'Consulta un horario en específico
    Public Function consultaUnIdHorario() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_horario FROM Horario_laboral " &
                 "WHERE id_horario = " & idHorario

        consultaUnIdHorario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnIdHorario = True
        End If
    End Function

    'MÉTODO QUE VÁLIDA SI HAY EMPLEADOS QUE DEPENDEN DE ALGÚN HORARIO
    Public Function validaHorarioL() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT * FROM Empleado " &
                 " WHERE id_horario = " & idHorario
        validaHorarioL = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            validaHorarioL = True
        End If
    End Function

    'MÉTODO QUE ELIMINA REGISTROS (ID) DE LA TABLA HORARIO LABORAL
    Public Sub eliminarHorarioL()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        If idHorario <> 0 Then
            strSql = "DELETE FROM Horario_laboral " &
                     " WHERE id_horario = " & idHorario
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("FALTAN DATOS DEL HORARIO !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'MÉTODO PARA MOSTRAR EL SIGUIENTE ID EN EL FORMULARIO HORARIO LABORAL
    Public Sub mostrarIdMax()
        Dim xDT As New DataTable

        Dim conector As New OracleDataAdapter("SELECT MAX(id_horario)+1 FROM Horario_laboral", cnx)

        conector.Fill(xDT)
        For Each registro As DataRow In xDT.Rows
            FrmHorarioLaboral.TbIdHorarioLab.Text = registro("MAX(id_horario)+1").ToString
        Next
    End Sub
    '****************************FIN DE LAS OPERACIONES DE LA TABLA HORARIO LABORAL***************************************
End Class
