Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Sucursal_sector
    Inherits Datos.Conexion

#Region "Sector alta"
    Public Function Cliente_suc_sector_alta(ByVal descripcion As String,
                                            ByVal denominacion As String,
                                            ByVal SucxClie_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_suc_sector_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_descripcion", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_denominacion", denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@SucxClie_id", SucxClie_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sector")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Cliente_suc_sector_recuperar_todos(ByVal SucxClie_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_suc_sector_recuperar_todos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@SucxClie_id", SucxClie_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sector_todos_suc")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Cliente_suc_sector_validar(ByVal Cliente_suc_sector_descripcion As String, ByVal Cliente_suc_sector_denominacion As String, ByVal SucxClie_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_suc_sector_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_descripcion", Cliente_suc_sector_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_denominacion", Cliente_suc_sector_denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@SucxClie_id", SucxClie_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sector_todos_suc")
        dbconn.Close()
        Return ds_JE
    End Function




#End Region

End Class
