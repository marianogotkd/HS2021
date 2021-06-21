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

#Region "MANTENIMIENTO"
    Public Function Mantenimiento_alta(ByVal Equipo_id As Integer, ByVal Mant_periodicidad_id As Integer, ByVal Mantenimiento_fecha_inicio As DateTime, ByVal Mantenimiento_activo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_fecha_inicio", Mantenimiento_fecha_inicio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_activo", Mantenimiento_activo))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Mantenimiento_quitar(ByVal Mantenimiento_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_quitar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_id", Mantenimiento_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_fecha_inicio", Mantenimiento_fecha_inicio))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_activo", Mantenimiento_activo))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Tareas_asignadas_alta(ByVal Tareas_id As Integer, ByVal Mantenimiento_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Tareas_asignadas_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_id", Tareas_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_id", Mantenimiento_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_fecha_inicio", Mantenimiento_fecha_inicio))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Mantenimiento_realizado_buscar_2(ByVal fecha As DateTime, ByVal SucxClie_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_realizado_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha", fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@SucxClie_id", SucxClie_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_fecha_inicio", Mantenimiento_fecha_inicio))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function


    'mantenimiento_realizado_Alta
    Public Function Mantenimiento_realizado_alta(ByVal Mantenimiento_id As Integer, ByVal Mant_realizados_fecha As DateTime) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_realizado_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_id", Mantenimiento_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_realizados_fecha", Mant_realizados_fecha))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_asignadas_id", Tareas_asignadas_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function

    'mantenimiento_realizado_Detalle alta
    Public Function Mantenimiento_realizado_detalle_alta(ByVal Mant_realizados_id As Integer, ByVal Mant_detalle As String, ByVal Tareas_asignadas_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_realizado_detalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_realizados_id", Mant_realizados_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_detalle", Mant_detalle))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_asignadas_id", Tareas_asignadas_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function

    'mantenimiento_realizado_Detalle modificar
    Public Function Mantenimiento_realizado_detalle_modificar(ByVal Mant_detalle As String, ByVal Mant_realizado_detalle_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_realizado_detalle_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_detalle", Mant_detalle))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_realizado_detalle_id", Mant_realizado_detalle_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_asignadas_id", Tareas_asignadas_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function

    'mantenimiento_realizados_detalle_validar
    Public Function Mantenimiento_realizado_detalle_validar(ByVal Tareas_asignadas_id As Integer, ByVal Mant_realizados_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_realizado_detalle_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_asignadas_id", Tareas_asignadas_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_realizados_id", Mant_realizados_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_asignadas_id", Tareas_asignadas_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function




#End Region

#Region "CALENDARIO MANTENIMIENTO"
    Public Function Mantenimiento_iniciales_obtener(ByVal SucxClie_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mantenimiento_iniciales_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@SucxClie_id", SucxClie_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mantenimiento_fecha_inicio", Mantenimiento_fecha_inicio))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function





#End Region

End Class
