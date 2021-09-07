Imports System.Data.OleDb
Imports System.Data.DataRow


Public Class Cliente
    Inherits Datos.Conexion

    'Cliente_Alta
    Public Sub Cliente_Alta(ByVal CLI_nom As String,
                            ByVal CLI_tel As String,
                            ByVal CLI_mail As String,
                            ByVal CLI_observaciones As String,
                            ByVal CLI_direc As String,
                            ByVal CLI_cel As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_nom", CLI_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_tel", CLI_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_mail", CLI_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_observaciones", CLI_observaciones))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_direc", CLI_direc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_cel", CLI_cel))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    'Cliente_Modificar
    Public Sub Cliente_Modificar(ByVal CLI_id As Integer,
                                 ByVal CLI_nom As String,
                                 ByVal CLI_tel As String,
                                 ByVal CLI_mail As String,
                                 ByVal CLI_observaciones As String,
                                 ByVal CLI_cel As String,
                                 ByVal CLI_direc As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_nom", CLI_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_tel", CLI_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_mail", CLI_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_observaciones", CLI_observaciones))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_cel", CLI_cel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_direc", CLI_direc))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    'Cliente_eliminar
    Public Sub Cliente_eliminar(ByVal clie_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", clie_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    'Cliente_ObtenerDni
    Public Function Cliente_ObtenerDni(ByVal CLI_dni As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_ObtenerDni", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dni", CLI_dni))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    'Cliente_ObtenerApe
    Public Function Cliente_ObtenerApe(ByVal CLI_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_ObtenerApe", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_nom", CLI_nom))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    'Cliente_VerificarDni
    Public Function Cliente_VerificarDni(ByVal CLI_dni As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_VerificarDni", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dni", CLI_dni))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    'Cliente_obtenertodo
    Public Function Cliente_obtenertodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_obtenertodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


    'Informe_Cliente
    Public Function Informe_Cliente() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Informe_Cliente", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
