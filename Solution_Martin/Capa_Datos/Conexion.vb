Imports System.Configuration
Public Class Conexion
    'BD MARTIN CHOCO-RYZEN - hamachi
    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=Martin;Data Source=25.112.197.145\SQLEXPRESS_CHOK")

    ''LOCAL
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Martin;Data Source=(local)")
    ''SERVIDOR SALTA
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;password=Chiquita$;Initial Catalog=Martin;Data Source=SERVIDOR")
End Class
