Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Caja
    Inherits Datos.Conexion


    Public Function Caja_consultar() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_consultar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Sub Caja_abrir(ByVal CAJA_apertura As DateTime, ByVal CAJA_estado As String, ByVal CAJA_montoinicial As Decimal, ByVal CAJA_montoingresos As Decimal, ByVal CAJA_montoneto As Decimal, ByVal USU_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_abrir", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_apertura ", CAJA_apertura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_estado", CAJA_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoinicial", CAJA_montoinicial))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresos", CAJA_montoingresos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoneto", CAJA_montoneto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub

    Public Sub Caja_modificar(ByVal CAJA_montoingresos As Decimal, ByVal CAJA_montoneto As Decimal, ByVal USU_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresos ", CAJA_montoingresos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoneto", CAJA_montoneto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub


    Public Sub Caja_cierre(ByVal CAJA_montoingresos As Decimal, ByVal CAJA_montoneto As Decimal, ByVal USU_id As Integer, ByVal CAJA_cierre As datetime)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_cierre", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresos ", CAJA_montoingresos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoneto", CAJA_montoneto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_cierre", CAJA_cierre))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub




    Public Function Caja_validad_AperturayCierre() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_validad_AperturayCierre", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    'Caja_Actualizar
    Public Sub Caja_Actualizar(ByVal CAJA_monto As Decimal, ByVal USU_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_Actualizar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresos ", CAJA_monto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub

End Class
