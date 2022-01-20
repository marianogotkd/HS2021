Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Mantenimiento
    Inherits Datos.Conexion

    Public Function Manteniminento_evaluar_duplicado() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Manteniminento_evaluar_duplicado", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        ' comando.Parameters.Add(New OleDb.OleDbParameter("@medico_nombre", medico_nombre))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mantenimiento")
        dbconn.Close()
        Return ds_JE
    End Function
End Class
