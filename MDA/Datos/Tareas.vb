Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Tareas
    Inherits Datos.Conexion


    Public Function Tareas_validar(ByVal Tareas_desc As String, ByVal Cat2_equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Tareas_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_desc", Tareas_desc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Tareas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Tareas_alta(ByVal Tareas_desc As String, ByVal Cat2_equipo_id As Integer, ByVal Mant_periodicidad_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Tareas_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_desc", Tareas_desc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Tareas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Tareas_modificar(ByVal Tareas_id As Integer, ByVal Tareas_desc As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Tareas_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_id", Tareas_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_desc", Tareas_desc))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Tareas")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Tareas_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Tareas_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_desc", Tareas_desc))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Tareas")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Tareas_eliminar(ByVal Tareas_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Tareas_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Tareas_id", Tareas_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Tareas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Tareas_recuperar_x_periodicidad(ByVal Cat2_equipo_id As Integer, ByVal Mant_periodicidad_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Tareas_recuperar_x_periodicidad", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Mant_periodicidad_id", Mant_periodicidad_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Tareas")
        dbconn.Close()
        Return ds_JE
    End Function



End Class
