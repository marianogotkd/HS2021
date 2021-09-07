Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Usuario

    Inherits Datos.Conexion

    'USUARIO
    Public Function Usuario_Sesion(ByVal USU_usuario As String, ByVal USU_contr As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_sesion", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_usuario", USU_usuario))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_cont ", USU_contr))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Sub Usuario_alta(ByVal UT_id As Integer, ByVal USU_ape As String, ByVal USU_nom As String, ByVal USU_usuario As String,
                            ByVal USU_contr As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_ape", USU_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_nom", USU_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_usuario", USU_usuario))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_contr", USU_contr))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    Public Function UsuarioTipo_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand(" UsuarioTipo_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function UsuarioEstado_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("UsuarioEstado_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "UsuarioEstado")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Usuario_Cont(ByVal USU_id As String, ByVal USU_contr As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_Cont", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_contr", USU_contr))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    'Usuario Bloquear
    Public Sub Usuario_bloquear(ByVal USU_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_bloquear", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    'Usuario Desbloquear
    Public Sub Usuario_Desbloquear(ByVal USU_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_desbloquear", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    'Usuario Obtener
    Public Function Usuario_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function

   

    'Usuario Cambiar
    Public Sub Usuario_cambiar(ByVal USU_id As String, ByVal UT_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_cambiar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

End Class
