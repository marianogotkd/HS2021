﻿Imports System.Configuration

Public Class Conexion
    'Conexion HAMERSERVER
    ' Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=25.13.170.93")

    'Conexion HAMERSERVER-LOCAL_LAN
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=HAMER-HOME-PC")

    'Conexion CHOCO-RYZEN

    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=25.112.197.145\SQLEXPRESS_CHOK")

    'Conexion local NoteMariano
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SantaFe;Data Source=(local)")

    'Conexion MDA Electricidad
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SantaFe;Data Source=DESKTOP-CK4O564\SQLEXPRESS")


End Class
