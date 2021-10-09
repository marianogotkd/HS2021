Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Pedido
    Inherits Capa_Datos.Conexion
    Public Function Pedido_ObtenerTodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedido_ObtenerTodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure



        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " Pedido_ObtenerTodo")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function Pedido_Alta(ByVal ObraId As Integer, ByVal VehiculoId As Integer, ByVal PedidoFecha As Date, ByVal Usuario As String
                             ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Pedido_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraId", ObraId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoFecha", PedidoFecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Usuario", Usuario))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Pedido_Alta")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function PedidoDetalle_Alta(ByVal PedidoId As Integer, ByVal ArticuloId As Integer, ByVal PedidoDetCant As Decimal, ByVal PedidoDetObs As String
                           ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("PedidoDetalle_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoId", PedidoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ArticuloId", ArticuloId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoDetCant", PedidoDetCant))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoDetObs", PedidoDetObs))

        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "PedidoDetalle_Alta")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Pedido_ObtenerTodo_detallado() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedido_ObtenerTodo_detallado", dbconn)
        comando.CommandType = CommandType.StoredProcedure



        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " Pedido_ObtenerTodo_detallado")
        dbconn.Close()
        Return ds_usu
    End Function


    Public Function Pedido_Recibir(ByVal PedidoId As Integer, ByVal PedidoReciboFecha As Date
                          ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Pedido_Recibir", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoId", PedidoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoReciboFecha", PedidoReciboFecha))


        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Pedido_Recibir")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Pedido_Eliminar(ByVal PedidoId As Integer
                         ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Pedido_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoId", PedidoId))



        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Pedido_Eliminar")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Pedido_Obtener_con_Det_X_ID(ByVal PedidoId As Integer
                         ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Pedido_Obtener_con_Det_X_ID", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoId", PedidoId))



        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Pedido_Obtener_con_Det_X_ID")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Pedido_Actualizar(ByVal PedidoId As Integer, ByVal ObraId As Integer, ByVal VehiculoId As Integer, ByVal PedidoFecha As Date, ByVal Usuario As String,
                        ByVal PedidoReciboFecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Pedido_Actualizar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoId", PedidoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraId", ObraId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoFecha", PedidoFecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Usuario", Usuario))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoReciboFecha", PedidoReciboFecha))

        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Pedido_Actualizar")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

End Class
