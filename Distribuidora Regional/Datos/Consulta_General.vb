Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Consulta_General
    Inherits Datos.Conexion

    Public Function Consulta_General_Obtener_Devoluciones(ByVal PROD_codigo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_General_Obtener_Devoluciones", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_General_Obtener_Recepciones(ByVal PROD_codigo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_General_Obtener_Recepciones", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_General_Obtener_Retiros(ByVal PROD_codigo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_General_Obtener_Retiros", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_General_Obtener_Ventas(ByVal PROD_codigo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_General_Obtener_Ventas", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

   
End Class
