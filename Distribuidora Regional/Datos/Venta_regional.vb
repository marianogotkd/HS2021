Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Venta_regional
    Inherits Datos.Conexion

#Region "INFORMES"

    Public Function Venta_informe_detallado(ByVal Venta_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_informe_detallado", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_id", Venta_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "producto")
        dbconn.Close()
        Return ds_JE
    End Function


#End Region

#Region "NUEVO DISEÑO"
    Public Function Venta_obtener_productos_en_stock() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtener_productos_en_stock", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Productos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Venta_modificar_stock(ByVal PROD_id As Integer,
                          ByVal PROD_cant_total As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_modificar_stock", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_id", PROD_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_cant_total", PROD_cant_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
    End Sub

    'Venta_obtener_todas
    Public Function Venta_obtener_todas() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_obtener_todas", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recepcion")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Venta_obtener_todas_Codigo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_obtener_todas_Codigo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recepcion")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Venta_obtener_lotes_de_producto(ByVal PROD_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_obtener_lotes_de_producto", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_id", PROD_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Venta_obtener_lotesvendidos(ByVal Venta_det_id As Integer, ByVal PROD_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_obtener_lotesvendidos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_det_id", Venta_det_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_id", PROD_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "lotes")
        dbconn.Close()
        Return ds_JE
    End Function



    'Venta_buscar_detalles
    Public Function Venta_buscar_detalles(ByVal Venta_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_buscar_detalles", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_id", Venta_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Productos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Venta_detalle_lotevendido_alta(ByVal Venta_det_id As Integer, ByVal PRODDET_id As Integer, ByVal Cant_lote As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_detalle_lotevendido_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_det_id", Venta_det_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_id", PRODDET_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cant_lote", Cant_lote))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Venta_actualizarsotck_producto_detalle(ByVal PRODDET_id As Integer,
                          ByVal PRODDET_cantidad As Integer, ByVal PRODDET_estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_actualizarsotck_producto_detalle", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_id", PRODDET_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_cantidad", PRODDET_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_estado", PRODDET_estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_detalle")
        dbconn.Close()
        Return ds_JE
    End Function




#End Region


    'Obtener productos recepcion----los trae para agregarlos despues en una venta
    Public Function Venta_obtener_productos_recepcion() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtener_productos_recepcion", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Productos")
        dbconn.Close()
        Return ds_JE
    End Function


    



    'venta_alta
    Public Function Venta_alta(ByVal Venta_codigo As String,
                          ByVal CLI_id As Integer, ByVal Venta_fecha As Date,
                          ByVal Nro_factura As String, ByVal Fecha_factura As Date, ByVal Venta_total As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_codigo", Venta_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_fecha", Venta_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Nro_factura", Nro_factura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha_factura", Fecha_factura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_total", Venta_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function



    'Venta_detalle_alta
    Public Function Venta_detalle_alta(ByVal Venta_id As Integer,
                          ByVal PROD_id As Integer, ByVal Cantidad As Integer, ByVal precio_U As Decimal, ByVal precio_subtotal As Decimal, ByVal Venta_Lote As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_detalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_id", Venta_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_id", PROD_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cantidad", Cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@precio_U", precio_U))
        comando.Parameters.Add(New OleDb.OleDbParameter("@precio_subtotal", precio_subtotal))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_Lote", Venta_Lote))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_detalle")
        dbconn.Close()
        Return ds_JE
    End Function




    'Venta_modificar_recepcion
    Public Sub Venta_modificar_recepcion(ByVal RECEPCION_id As Integer,
                          ByVal RECEPCION_cantidad As Integer, ByVal RECEPCION_estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_modificar_recepcion", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_id", RECEPCION_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_cantidad", RECEPCION_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_estado", RECEPCION_estado))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
    End Sub




End Class
