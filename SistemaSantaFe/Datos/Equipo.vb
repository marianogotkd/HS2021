Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Equipo
    Inherits Datos.Conexion

#Region "Equipo alta"
    Public Function Equipo_alta(ByVal descripcion As String, ByVal denominacion As String, ByVal sector_id As Integer, ByVal idcat As Integer, ByVal nrocat As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_descripcion", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_id", sector_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_idcat", idcat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_nrocat", nrocat))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function
#End Region

#Region "Equipo modificar"
    Public Function Equipo_modificar(ByVal Equipo_denominacion As String, ByVal Equipo_descripcion As String, ByVal Equipo_idcat As Integer, ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", Equipo_denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_descripcion", Equipo_descripcion))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", Equipo_denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_idcat", Equipo_idcat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

    'Equipo_recuperar_info
    Public Function Equipo_recuperar_info(ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_recuperar_info", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))
        
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region

    Public Function Equipo_validar(ByVal Cliente_suc_sector_id As Integer, ByVal Equipo_descripcion As String, ByVal Equipo_denominacion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_id", Cliente_suc_sector_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_descripcion", Equipo_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", Equipo_denominacion))
        
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Equipo_buscar_x_sucursal(ByVal SucxClie_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_buscar_x_sucursal", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@SucxClie_id", SucxClie_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function


    'recuperar_info_equipo
    Public Function Equipo_obtener_info(ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_obtener_info", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
