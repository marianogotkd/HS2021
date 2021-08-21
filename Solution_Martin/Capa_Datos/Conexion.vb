Imports System.Configuration
Public Class Conexion
    ''LOCAL
    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Martin;Data Source=(local)")
    ''SERVIDOR SALTA
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;password=Chiquita$;Initial Catalog=Martin;Data Source=SERVIDOR")
End Class
