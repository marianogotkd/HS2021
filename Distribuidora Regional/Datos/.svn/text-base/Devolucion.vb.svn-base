Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Devolucion
    Inherits Datos.Conexion

    Public Function Recepcion_obtener_Por_Fac(ByVal RECEPCION_nrofactura As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Recepcion_obtener_Por_Fac", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_nrofactura", RECEPCION_nrofactura))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Devolucion_Recepcion_obtener_Por_Fac_Venta(ByVal RECEPCION_nrofactura As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Devolucion_Recepcion_obtener_Por_Fac_Venta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_nrofactura", RECEPCION_nrofactura))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "recepciones")
        dbconn.Close()
        Return ds_JE
    End Function


    'devolucion_obtener_todo
    Public Function Devolucion_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Devolucion_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Devolucion")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Devolucion_alta(ByVal Dev_codigo As String, ByVal Dev_motivo As String,
                                ByVal Dev_entidad As String, ByVal Dev_fecha As Date, ByVal Dev_Cantidad As Integer, ByVal PROD_codigo As String, ByVal RECEPCION_nrolote As String, ByVal PROD_presentacion As String, ByVal PROD_Nombre As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Devolucion_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Dev_codigo", Dev_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dev_motivo", Dev_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dev_entidad", Dev_entidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dev_fecha", Dev_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dev_Cantidad", Dev_Cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_nrolote", RECEPCION_nrolote))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_presentacion", PROD_presentacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_Nombre", PROD_Nombre))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Devolucion")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function DevolucionDetalle_alta(ByVal RECEPCION_id As Integer, ByVal Dev_id As Integer, ByVal Cantidad As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("DevolucionDetalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_id", RECEPCION_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dev_id", Dev_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cantidad", Cantidad))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Devolucion_detalle")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Devolucion_informe(ByVal Dev_codigo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Devolucion_informe", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Dev_codigo", Dev_codigo))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Devolucion")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Devolucion_ObtenerProd_Por_CodyLte(ByVal Cod As String, ByVal lote As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Devolucion_ObtenerProd_Por_CodyLte", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cod", Cod))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote", lote))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Devolucion_Prod_modifCant(ByVal prod_id As Integer, ByVal prod_descripcion As String, ByVal prod_descrilarga As String, ByVal prod_codbarra As String, ByVal idmarca As Integer, ByVal prod_unidadmedida As String, ByVal producto_foto() As Byte) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_modifDatos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_descripcion", prod_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_descrilarga", prod_descrilarga))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codbarra", prod_codbarra))
        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", idmarca))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_unidadmedida", prod_unidadmedida))
        comando.Parameters.Add(New OleDb.OleDbParameter("@producto_foto", producto_foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function




    Public Function ProdDetalle_modificar(ByVal Diferencia As Integer, ByVal PRODDET_estado As String,
                                    ByVal Prod_id As Integer, ByVal nro_lote As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("ProdDetalle_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Diferencia", Diferencia))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_estado", PRODDET_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prod_id", Prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nro_lote", nro_lote))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto_detalle")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Devolucion_obtener_Producto(ByVal PROD_codigo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Devolucion_obtener_Producto", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
