Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Pedidos


    Inherits Datos.Conexion

    'Pedidos_Obtener_Prod_Prove
    Public Function Pedidos_Obtener_Prod_Prove(ByVal Prov As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Prod_Prove", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cod", Prov))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Pedidos_Alta(ByVal Pedidos_Cod As Integer, ByVal Pedidos_Fecha As Date, ByVal Pedidos_Cod_Prov As Integer, ByVal Pedidos_Total As Decimal, ByVal Pedidos_Estado As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Cod", Pedidos_Cod))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Fecha", Pedidos_Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Cod_Prov", Pedidos_Cod_Prov))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Total", Pedidos_Total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Estado", Pedidos_Estado))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Pedidos_validar() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Pedidos_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Pedidos_Detalle_Alta(ByVal PedidosDet_Pedidos_ID As Integer, ByVal PedidosDet_Prov_Prod_Com_id As Integer, ByVal PedidosDet_Cantida As Integer, ByVal PedidosDet_Total As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand(" Pedidos_Detalle_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Pedidos_ID", PedidosDet_Pedidos_ID))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Prov_Prod_Com_id", PedidosDet_Prov_Prod_Com_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Cantida", PedidosDet_Cantida))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Total", PedidosDet_Total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, " Pedidos_Detalle_Alta")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Obtener_Pendiente() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Pendiente", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Obtener_Listo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Listo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Detalle_Consulta(ByVal Prov As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Detalle_Consulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_ID", Prov))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'PedidoEstado_obtener
    Public Function PedidoEstado_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("PedidoEstado_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "PedidoEstado")
        dbconn.Close()
        Return ds_JE
    End Function

    'Pedidos_ActualizarCantidad
    Public Sub Pedidos_ActualizarCantidad(ByVal PedidosDet_id As Integer, ByVal PedidosDet_cantidad As String, ByVal PedidosDet_Total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_ActualizarCantidad", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_id", PedidosDet_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_cantidad", PedidosDet_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Total", PedidosDet_Total))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "PedidosDetalle")
        dbconn.Close()
    End Sub

    'Pedidos_ActualizarPrecio
    Public Sub Pedidos_ActualizarPrecio(ByVal Prov_Prod_Com_id As Integer, ByVal Prov_Prod_Com_precio As Decimal,
                                        ByVal PedidosDet_id As Integer, ByVal PedidosDet_Total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_ActualizarPrecio", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_Prod_Com_id", Prov_Prod_Com_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_Prod_Com_precio", Prov_Prod_Com_precio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_id", PedidosDet_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Total", PedidosDet_Total))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProveedorProductoCompra")
        dbconn.Close()
    End Sub

    'Pedidos_ActualizarTotal
    Public Sub Pedidos_ActualizarTotal(ByVal Pedidos_id As Integer, ByVal Pedidos_Total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_ActualizarTotal", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_id", Pedidos_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Total", Pedidos_Total))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
    End Sub

    'Pedidos_ActualizarEstado
    Public Sub Pedidos_ActualizarEstado(ByVal Pedidos_id As Integer, ByVal Pedidos_Estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_ActualizarEstado", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_id", Pedidos_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Estado", Pedidos_Estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
    End Sub

    'Pedidos_Eliminar
    Public Sub Pedidos_Eliminar(ByVal Pedidos_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_id", Pedidos_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
    End Sub


    Public Function Pedidos_Obtener_Listo_Fecha(ByVal FECHA_desde As Date, ByVal FECHA_hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Listo_Fecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA_desde", FECHA_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA_hasta", FECHA_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Pedidos_Obtener_Pendiente_Fecha(ByVal FECHA_desde As Date, ByVal FECHA_hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Pendiente_Fecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA_desde", FECHA_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA_hasta", FECHA_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
