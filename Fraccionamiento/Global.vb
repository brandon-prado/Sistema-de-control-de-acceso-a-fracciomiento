''Para trabajar con una base de datos en ORACLE
Imports Oracle.DataAccess.Client

Module Globales

    'Para trabajar con una base de datos ORACLE desde cualquier
    'formulario, es requerido crear un modulo global
    'para poder abrir y cerrar la BD en los diferentes formularios

    Public cnx As OracleConnection
End Module
