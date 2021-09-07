Imports System.Data.OleDb
Imports System.Data.DataRow


Public Class Retiro

    Inherits Datos.Conexion


    Public Function Retiro_informe(ByVal Retiro_codigo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Retiro_informe", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Retiro_codigo", Retiro_codigo))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "RETIRO")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Retiro_Recepcion_obtener_Por_Fac(ByVal RECEPCION_nrofactura As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Retiro_Recepcion_obtener_Por_Fac", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_nrofactura", RECEPCION_nrofactura))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "recepciones")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Retiro_Recepcion_obtener_Por_Fac_Venta(ByVal RECEPCION_nrofactura As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Retiro_Recepcion_obtener_Por_Fac_Venta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_nrofactura", RECEPCION_nrofactura))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "recepciones")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Retiro_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Retiro_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "retiro")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Retiro_alta(ByVal Retiro_tipo As String,
                          ByVal Retiro_codigo As String, ByVal Retiro_motivo As String,
                          ByVal Retiro_destino As String, ByVal Retiro_fecha As Date, ByVal PROD_codigo As String, ByVal PRODDET_nrolote As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Retiro_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Retiro_tipo", Retiro_tipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Retiro_codigo", Retiro_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Retiro_motivo", Retiro_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Retiro_destino", Retiro_destino))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Retiro_fecha", Retiro_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_nrolote", PRODDET_nrolote))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "retiro")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Retiro_detalle_alta(ByVal RECEPCION_id As Integer,
                          ByVal Retiro_id As Integer, ByVal Cantidad As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Retiro_detalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@RECEPCION_id", RECEPCION_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Retiro_id", Retiro_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cantidad", Cantidad))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Retiro_detalle")
        dbconn.Close()
    End Sub

    Public Function Retiro_ObtenerDatos_cod_lote(ByVal PROD_codigo As String, ByVal PRODDET_nrolote As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Retiro_ObtenerDatos_cod_lote", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_nrolote", PRODDET_nrolote))
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

    Public Function Retiro_consulta(ByVal PROD_codigo As String, ByVal PRODDET_nrolote As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Retiro_consulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PRODDET_nrolote", PRODDET_nrolote))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Retiro_Consulta_todo()
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Retiro_Consulta_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
       
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
