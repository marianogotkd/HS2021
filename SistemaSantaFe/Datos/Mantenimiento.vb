Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Mantenimiento
    Inherits Datos.Conexion

#Region "tipo de mantenimiento"
    Public Function Mantenimiento_tipo_alta(ByVal descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_tipo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_tipo_descr", descripcion))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento_tipo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Mantenimiento_tipo_modificar(ByVal Mant_tipo_id As Integer, ByVal descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_tipo_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_tipo_id", Mant_tipo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_tipo_descr", descripcion))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento_tipo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Mantenimiento_tipo_validar(ByVal descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_tipo_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_tipo_descr", descripcion))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento_tipo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Mantenimiento_tipo_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_tipo_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_tipo_descr", descripcion))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento_tipo")
        dbconn.Close()
        Return ds_JE
    End Function
#End Region

    
#Region "PERIODICIDAD"

    Public Function Mantenimiento_periodicidad_alta(ByVal descripcion As String, ByVal dias As Integer, ByVal Mant_tipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_periodicidad_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_desc", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_dias", dias))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_tipo_id", Mant_tipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento_periodicidad")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Mantenimiento_periodicidad_obtener(ByVal Mant_tipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_periodicidad_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_tipo_id", Mant_tipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento_periodicidad")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Mantenimiento_periodicidad_modificar(ByVal Mant_periodicidad_id As Integer, ByVal descripcion As String, ByVal dias As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_periodicidad_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_desc", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_dias", dias))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento_periodicidad")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Mantenimiento_periodicidad_eliminar(ByVal Mant_periodicidad_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_periodicidad_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento_periodicidad")
        dbconn.Close()
        Return ds_JE
    End Function
#End Region




End Class
