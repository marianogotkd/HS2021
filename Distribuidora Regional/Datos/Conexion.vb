Imports System.Configuration

Public Class Conexion

    'Conexion CON EL SERVER
    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_DistribuidoraRegional;Data Source=PC-PC\SQLEXPRESS")


    'Conexion local NoteMariano
    ' Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_DistribuidoraRegional;Data Source=")




End Class
