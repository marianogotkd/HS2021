Imports System.Configuration

Public Class Conexion

    'Conexion HAMERSERVER
    ' Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=25.13.170.93")

    'Conexion HAMERSERVER-LOCAL_LAN
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=HAMER-HOME-PC")

    'Conexion CHOCO-RYZEN
    'ESTA ES LA SOLUCION PRUEBA

   'Conexion Servidor la Delicias - Colon(Local)
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Delicias;Data Source=DELICIAS-PC\SQLEXPRESS")

    'Conexion Servidor la Delicias - Independencia(Local)
    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=choco;Password=choco123;Initial Catalog=Delicias;Data Source=DESKTOP-UTVUSOV")

End Class
