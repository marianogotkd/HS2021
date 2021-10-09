Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Vehiculo
    Inherits Capa_Datos.Conexion


    Public Function Vehiculo_modificar(ByVal VehiculoId As Integer, ByVal VehiculoPatente As String, ByVal VehiculoMarca As String, ByVal VehiculoModelo As String,
                              ByVal VehiculoAño As String, ByVal VehiculoTipo As String, ByVal VehiculoEstado As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Vehiculo_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoPatente", VehiculoPatente))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoMarca", VehiculoMarca))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoModelo", VehiculoModelo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoAño", VehiculoAño))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoTipo", VehiculoTipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoEstado", VehiculoEstado))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Vehiculo")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Vehiculo_Alta(ByVal VehiculoPatente As String, ByVal VehiculoMarca As String, ByVal VehiculoModelo As String,
                             ByVal VehiculoAño As String, ByVal VehiculoTipo As String, ByVal VehiculoEstado As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Vehiculo_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoPatente", VehiculoPatente))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoMarca", VehiculoMarca))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoModelo", VehiculoModelo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoAño", VehiculoAño))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoTipo", VehiculoTipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoEstado", VehiculoEstado))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Vehiculo")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Vehiculo_ObtenerTodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Vehiculo_ObtenerTodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure



        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " Vehiculo_ObtenerTodo")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function Vehiculo_Obtener_Juntos_Activos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Vehiculo_Obtener_Juntos_Activos", dbconn)
        comando.CommandType = CommandType.StoredProcedure



        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " Vehiculo_Obtener_Juntos_Activos")
        dbconn.Close()
        Return ds_usu
    End Function


    Public Function Vehiculo_ObtenerTodo_X_ID(ByVal VehiculoId As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Vehiculo_ObtenerTodo_X_ID", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " Vehiculo_ObtenerTodo")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function Vehiculo_Eliminar(ByVal VehiculoId As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Vehiculo_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " Vehiculo_Eliminar")
        dbconn.Close()
        Return ds_usu
    End Function
End Class
