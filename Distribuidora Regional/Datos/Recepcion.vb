Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Recepcion
    Inherits Datos.Conexion

#Region "Informes"

    Public Function Recepcion_informe_detallado(ByVal RECEPCION_codigo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recepcion_informe_detallado", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_codigo", RECEPCION_codigo))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recepcion")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region



#Region "RECEPCION NUEVO DISEÑO"

    Public Function Recepcion_Obtener_Codigo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recepcion_Obtener_Codigo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Productos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Recepcion_buscar_productos_seleccionado(ByVal PROD_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recepcion_buscar_productos_seleccionado", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_id", PROD_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Recepcion_buscar_lotes(ByVal PROD_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recepcion_buscar_lotes", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_id", PROD_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "LOTE")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Recepcion_obtener_todos_productos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recepcion_obtener_todos_productos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Productos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Producto_alta(ByVal PROD_codigo As String,
                                      ByVal PROD_nombre As String,
                                      ByVal PROD_T_id As Integer,
                                      ByVal PROD_condi_alm As String,
                                      ByVal PROD_cant_total As Integer,
                                      ByVal marca_id As Integer,
                                      ByVal PROD_estado As String,
                                      ByVal PROD_precioU_vta As Decimal,
                                      ByVal PROD_iva As Decimal,
                                      ByVal PROD_totalU_iva As Decimal,
                                      ByVal PROD_total_iva As Decimal,
                                      ByVal PROD_presentacion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_nombre", PROD_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_T_id", PROD_T_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_condi_alm", PROD_condi_alm))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_cant_total", PROD_cant_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Marca_id", marca_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_estado", PROD_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_precioU_vta", PROD_precioU_vta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_iva", PROD_iva))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_totalU_iva", PROD_totalU_iva))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_total_iva", PROD_total_iva))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_presentacion", PROD_presentacion))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Producto_modificar(ByVal PROD_codigo As String,
                                      ByVal PROD_nombre As String,
                                      ByVal PROD_T_id As Integer,
                                      ByVal PROD_condi_alm As String,
                                      ByVal PROD_cant_total As Integer,
                                      ByVal marca_id As Integer,
                                      ByVal PROD_estado As String,
                                      ByVal PROD_precioU_vta As Decimal,
                                      ByVal PROD_iva As Decimal,
                                      ByVal PROD_totalU_iva As Decimal,
                                      ByVal PROD_total_iva As Decimal,
                                      ByVal PROD_presentacion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_nombre", PROD_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_T_id", PROD_T_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_condi_alm", PROD_condi_alm))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_cant_total", PROD_cant_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Marca_id", marca_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_estado", PROD_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_precioU_vta", PROD_precioU_vta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_iva", PROD_iva))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_totalU_iva", PROD_totalU_iva))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_total_iva", PROD_total_iva))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_presentacion", PROD_presentacion))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function ProdDet_alta(ByVal PRODDET_codigorecepcion As String, ByVal PROD_id As Integer, ByVal PRODDET_fecha_sistema As Date,
                                     ByVal PRODDET_nrolote As String, ByVal PRODDET_cantidad As Integer, ByVal PRODDET_fechavencimiento As Date,
                                     ByVal PRODDET_nrofactura As String, ByVal PRODDET_fechafactura As Date, ByVal Prov_id As Integer,
                                     ByVal PROD_codigo As String, ByVal PROD_nombre As String, ByVal PRODDET_estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ProdDet_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_codigorecepcion", PRODDET_codigorecepcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_id", PROD_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_fecha_sistema", PRODDET_fecha_sistema))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_nrolote", PRODDET_nrolote))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_cantidad", PRODDET_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_fechavencimiento", PRODDET_fechavencimiento))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_nrofactura", PRODDET_nrofactura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_fechafactura", PRODDET_fechafactura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_nombre", PROD_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_estado", PRODDET_estado))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto_detalle")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Recepcion_alta(ByVal RECEPCION_codigo As String, ByVal PROD_codigo As String, ByVal PROD_nombre As String, ByVal RECEPCION_nrolote As String, ByVal RECEPCION_fecha_sistema As Date, ByVal RECEPCION_cantidad As Integer, ByVal RECEPCION_fechavencimiento As Date, ByVal RECEPCION_nrofactura As String, ByVal RECEPCION_fechafactura As Date, ByVal PROD_totalU_iva As Decimal, ByVal Prov_id As Integer, ByVal RECEPCION_presentacion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Recepcion_alta_a", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_codigo", RECEPCION_codigo)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_nombre", PROD_nombre)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_nrolote", RECEPCION_nrolote)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_fecha_sistema", RECEPCION_fecha_sistema)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_cantidad", RECEPCION_cantidad)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_fechavencimiento", RECEPCION_fechavencimiento)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_nrofactura", RECEPCION_nrofactura)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_fechafactura", RECEPCION_fechafactura)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id)) 'ok
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_presentacion", RECEPCION_presentacion)) 'ok


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recepcion")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function ProdDetalle_modificar_Cantlote(ByVal Cantidad As String,
                                     ByVal Prod_id As Integer, ByVal nro_lote As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("ProdDetalle_modificar_Cantlote", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cantidad", Cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prod_id", Prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nro_lote", nro_lote))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto_detalle")
        dbconn.Close()
        Return ds_JE
    End Function



#End Region







    'Recepcion_obtener_todo
    Public Function Producto_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Producto_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto_detalle")
        dbconn.Close()
        Return ds_JE
    End Function

    'ProductoTipo_obtener
    Public Function ProductoTipo_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("ProductoTipo_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "productotipo")
        dbconn.Close()
        Return ds_JE
    End Function





End Class
