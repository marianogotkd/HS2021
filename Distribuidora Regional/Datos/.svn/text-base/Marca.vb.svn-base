Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Marca
    Inherits Datos.Conexion
    'Para el combo de alta de producto
    Public Function Marca_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Marca_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Marca")
        dbconn.Close()
        Return ds_MT
    End Function

    'Alta de marca
    Public Sub Marca_alta(ByVal marca_nom As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Marca_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_nom", marca_nom))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Marca")
        dbconn.Close()
    End Sub

    Public Sub Marca_modificar(ByVal Marca_id As Integer, ByVal marca_nom As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Marca_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Marca_id", Marca_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_nom", marca_nom))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Marca")
        dbconn.Close()
    End Sub



End Class
