Imports System.Configuration

Public Class Conexion

    'Conexion HAMERSERVER
    ' Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=25.13.170.93")

    'Conexion HAMERSERVER-LOCAL_LAN
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=HAMER-HOME-PC")

    'Conexion CHOCO-RYZEN
    'ESTA ES LA SOLUCION PRUEBA

    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=CHOCO;Initial Catalog=Delicias;Data Source=25.112.197.145\SQLEXPRESS_CHOK")

    'Conexion local NoteMariano
    ' Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SantaFe;Data Source=(local)")

    'Conexion Servidor la Delicias(Local)
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Delicias;Data Source=DELICIAS-PC\SQLEXPRESS")

    '
End Class
