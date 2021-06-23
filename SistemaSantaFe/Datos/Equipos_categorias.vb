Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Equipos_categorias
    Inherits Datos.Conexion

    Public Function Equipo_categoria1_alta(ByVal descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria1_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat1_equipo_desc", descripcion))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria1")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Equipo_categoria2_alta(ByVal descripcion As String, ByVal Cat1_equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria2_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_desc", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat1_equipo_id", Cat1_equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Equipo_categoria2_modificar(ByVal Cat2_equipo_desc As String, ByVal Cat2_equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria2_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_desc", Cat2_equipo_desc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Equipo_categoria2_caracteristicas_alta(ByVal Cat2_equipo_id As Integer, ByVal Cat2_caract_atributo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria2_caracteristicas_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_caract_atributo", Cat2_caract_atributo))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Equipo_categoria2_caracteristicas_modificar(ByVal Cat2_caract_atributo As String, ByVal Cat2_caract_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria2_caracteristicas_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_caract_atributo", Cat2_caract_atributo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_caract_id", Cat2_caract_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Equipo_categoria2_caracteristicas_eliminar(ByVal Cat2_caract_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria2_caracteristicas_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_caract_id", Cat2_caract_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_caract_atributo", Cat2_caract_atributo))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Equipo_categoria1_validar(ByVal descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria1_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_desc", descripcion))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat1_equipo_id", Cat1_equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Equipo_categoria2_eliminar(ByVal Cat2_equipo_id As Integer) As DataSet 'esta no borra, solo cambia el estado a ELIMINADO
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria2_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_desc", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Equipo_categoria1_y_2_recuperar(ByVal Cat1_equipo_id As Integer) As DataSet 'esta no borra, solo cambia el estado a ELIMINADO
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria1_y_2_recuperar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_desc", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat1_equipo_id", Cat1_equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Equipo_categorias_recuperartodo() As DataSet 'esta no borra, solo cambia el estado a ELIMINADO
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categorias_recuperartodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_desc", descripcion))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat1_equipo_id", Cat1_equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function



    'lo uso en el formulario Mantenimiento_config_alta, la idea es traer a partir de un subtipo (categoria 2), el id de la categoria 1 q necesito en un combo
    Public Function Equipo_categoria1_b(ByVal Cat2_equipo_id As Integer) As DataSet 'esta no borra, solo cambia el estado a ELIMINADO
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_categoria1_b", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_desc", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_equipo_id", Cat2_equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo_categoria2")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
