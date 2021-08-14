Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class CuentaCorriente
    Inherits Datos.Conexion

    Public Function CtaCte_obtenertodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("CtaCte_obtenertodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CtaCte")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function CtaCte_obtenertodo_Clientes() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("CtaCte_obtenertodo_Clientes", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CtaCte")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub CteCte_alta(ByVal CLI_id As Integer,
                                ByVal fechaalta As DateTime,
                                ByVal total As Decimal,
                                ByVal limite_deuda As Decimal
                                )
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CteCte_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fechaalta", fechaalta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@total", total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@limite_deuda", limite_deuda))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub



    Public Function CtaCte_Obtener_Movimientos(ByVal CtaCte_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_Obtener_Movimientos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function CtaCte_buscar_id(ByVal CtaCte_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_buscar_id", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub CtaCte_modificar(ByVal CtaCte_id As Integer,
                            ByVal CtaCte_estado As String,
                            ByVal CtaCte_limitedeuda As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_estado", CtaCte_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_limitedeuda", CtaCte_limitedeuda))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub

    'lo uso en el formulario de venta en caja. forma de pago: ctacte. CUENTA_CORRIENTE_VENTA
    Public Function Cuenta_Corriente_venta_TRANSACCION(ByVal ventaprod_total As Decimal, ByVal ventaprod_fecha As Date, ByVal usuario_id As Integer, ByVal ventaprod_tipovta As String, ByVal cliente_id As Integer,
                                       ByVal ventaprod_subtotal As Decimal, ByVal ventaprod_descuento_pesos As Decimal, ByVal ventaprod_descuento_porcentaje As Decimal,
                                       ByVal ventaprod_iva_porcentaje As Decimal, ByVal ventaprod_iva_pesos As Decimal, ByVal ventaprod_observacion As String,
                                       ByVal Servicio_id As Integer, ByVal vendedor_id As Integer, ByVal ventaprod_estado As String,
                                       ByVal CAJA_id As Integer, ByVal CtaCte_id As Integer, ByVal deuda As Decimal,
                                       ByVal producto_detalle As DataTable, ByVal sucursal_id As Integer) As DataTable
        Dim validar_op As String = ""
        Dim factura_id As Integer = 0
        Using connection As OleDbConnection = dbconn
            Dim transaccion As OleDbTransaction = Nothing
            Try
                connection.Open()
                transaccion = connection.BeginTransaction
                Dim comando As New OleDbCommand("VentaProducto_alta", connection)
                comando.Transaction = transaccion
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_fecha", ventaprod_fecha))
                comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_tipovta", ventaprod_tipovta))
                comando.Parameters.Add(New OleDb.OleDbParameter("@cliente_id", cliente_id))
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_subtotal", ventaprod_subtotal)) 'este parametro trae el total sumado de productos, sin descuento ni iva aplicado
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_descuento_pesos", ventaprod_descuento_pesos))
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_descuento_porcentaje", ventaprod_descuento_porcentaje))
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_iva_porcentaje", ventaprod_iva_porcentaje))
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_iva_pesos", ventaprod_iva_pesos))
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_observacion", ventaprod_observacion))
                comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", Servicio_id))
                comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_id", vendedor_id))
                comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_estado", ventaprod_estado))
                Dim ds_JE As New DataSet()
                Dim da_JE As New OleDbDataAdapter(comando)
                da_JE.Fill(ds_JE, "Venta_Producto") 'con esta instruccion recupero en un dataset el select del procedimiento almacenado "Equipo_alta"
                Dim ventaprod_id As Integer = ds_JE.Tables(0).Rows(0).Item("ventaprod_id")
                '/////////////////choco: 19-07-2021 - genero la factura en su correspondiente tabla///////////////////
                Dim comando2 As New OleDbCommand("Factura_alta", connection)
                comando2.Transaction = transaccion
                comando2.CommandType = CommandType.StoredProcedure
                comando2.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
                comando2.Parameters.Add(New OleDb.OleDbParameter("@factura_fecha", Now))
                comando2.Parameters.Add(New OleDb.OleDbParameter("@CAJA_id", CAJA_id))
                Dim ds_JE2 As New DataSet()
                Dim da_JE2 As New OleDbDataAdapter(comando2)
                da_JE2.Fill(ds_JE2, "Factura") 'con esta instruccion recupero en un dataset el select del procedimiento almacenado "Equipo_alta"
                factura_id = ds_JE2.Tables(0).Rows(0).Item("factura_id")
                '////////////////aqui cargamos en cuenta corriente, si corresponde - CHOCO: 03-12-2019//////////////////
                'tiene cuenta y genera deuda.
                '////////////////REGISTRO EGRESO EN CTA CTA.
                Dim comando_a As New OleDbCommand("CtaCte_registrar_egreso", connection)
                comando_a.Transaction = transaccion
                comando_a.CommandType = CommandType.StoredProcedure
                comando_a.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
                comando_a.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_total", deuda))
                Dim ds_JE_a As New DataSet()
                Dim da_JE_a As New OleDbDataAdapter(comando_a)
                da_JE_a.Fill(ds_JE_a, "CuentaCorriente")
                '////////////REGISTRO LA VENTA EN CTA CTE.
                Dim comando_b As New OleDbCommand("Venta_CtaCte_alta", connection)
                comando_b.Transaction = transaccion
                comando_b.CommandType = CommandType.StoredProcedure
                comando_b.Parameters.Add(New OleDb.OleDbParameter("@factura_id", factura_id))
                comando_b.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
                Dim ds_JE_b As New DataSet()
                Dim da_JE_b As New OleDbDataAdapter(comando_b)
                da_JE_b.Fill(ds_JE_b, "CuentaCorriente_b")
                '///////////////REGISTRO CTA CTE MOVIMIENTO ALTA
                Dim concepto As String = "Factura Nº: " + CStr(factura_id)
                Dim comando_c As New OleDbCommand("CtaCte_movimiento_alta", connection)
                comando_c.Transaction = transaccion
                comando_c.CommandType = CommandType.StoredProcedure
                comando_c.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
                comando_c.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_tipo", "Ingreso"))
                comando_c.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_concepto", concepto))
                comando_c.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_monto", ventaprod_total))
                comando_c.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_fecha", Now))
                Dim ds_JE_c As New DataSet()
                Dim da_JE_C As New OleDbDataAdapter(comando_c)
                da_JE_C.Fill(ds_JE_c, "CuentaCorriente")
                '//////////////////////////////////////////////////////////////////////////////////////////////////////
                Dim i As Integer = 0
                While i < producto_detalle.Rows.Count
                    Dim prod_id As Integer = producto_detalle.Rows(i).Item("PROD_id")
                    Dim ventaprod_cant As Decimal = producto_detalle.Rows(i).Item("cantidad")
                    Dim ventaprod_precio As Decimal = producto_detalle.Rows(i).Item("precio_unitario")
                    Dim ventaprod_subtotal_A As Decimal = producto_detalle.Rows(i).Item("precio_subtotal")
                    Dim ventaprod_descripcion As String = producto_detalle.Rows(i).Item("descripcion")
                    Dim codigointerno As String = producto_detalle.Rows(i).Item("codinterno")
                    Dim TURNO_id As Integer = 0
                    Dim descuento As Decimal = producto_detalle.Rows(i).Item("descuento")
                    Dim comando3 As New OleDbCommand("VentaProductoDetalle_alta", connection)
                    comando3.Transaction = transaccion
                    comando3.CommandType = CommandType.StoredProcedure
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_cant", ventaprod_cant))
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_precio", ventaprod_precio))
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_subtotal", ventaprod_subtotal_A))
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_descripcion", ventaprod_descripcion))
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@codigointerno", codigointerno))
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))
                    comando3.Parameters.Add(New OleDb.OleDbParameter("@descuento", descuento))
                    comando3.ExecuteNonQuery() 'lo uso para que guarde a medida que cicla.
                    i = i + 1
                End While

                'aqui hago el descuento de stock...
                Dim j As Integer = 0
                While j < producto_detalle.Rows.Count
                    Dim prod_codigo As Integer = 0
                    If producto_detalle.Rows(j).Item("codinterno") <> "" Then
                        If producto_detalle.Rows(j).Item("codinterno") <> "0" Then
                            prod_codigo = CInt(producto_detalle.Rows(j).Item("codinterno"))
                        End If
                    Else
                        Exit While 'salgo del ciclo x que la fila esta vacia
                    End If
                    Dim comando5 As New OleDbCommand("Producto_x_sucursal_buscarcod", connection)
                    comando5.Transaction = transaccion
                    comando5.CommandType = CommandType.StoredProcedure
                    comando5.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codigo))
                    comando5.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
                    Dim ds_JE3 As New DataSet()
                    Dim da_JE3 As New OleDbDataAdapter(comando5)
                    da_JE3.Fill(ds_JE3, "Producto") 'con esta instruccion recupero en un dataset el select del procedimiento almacenado 
                    If ds_JE3.Tables(0).Rows.Count <> 0 Then
                        Dim diferencia As Decimal = CDec(ds_JE3.Tables(0).Rows(0).Item("ProdxSuc_stock")) - CDec(producto_detalle.Rows(j).Item("cantidad"))
                        If diferencia < 0 Then
                            diferencia = 0
                        End If

                        Dim diferencia_gondola As Integer = 0
                        Dim cantidad As Integer = 0

                        Dim comando6 As New OleDbCommand("Venta_actualizar_stock_Caja", connection)
                        comando6.Transaction = transaccion
                        comando6.CommandType = CommandType.StoredProcedure
                        comando6.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codigo))
                        comando6.Parameters.Add(New OleDb.OleDbParameter("@prod_stock", diferencia))
                        comando6.Parameters.Add(New OleDb.OleDbParameter("@prod_gondola", diferencia_gondola))
                        comando6.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
                        comando6.ExecuteNonQuery() 'lo uso para que guarde a medida que cicla.
                    End If
                    j = j + 1
                End While

                transaccion.Commit() 'esta instruccion recien hace la transaccion en lote de todo lo q estoy insertando.
                validar_op = "GUARDADO"

            Catch ex As Exception
                validar_op = "ERROR"
                'MsgBox("ERROR EN LA TRANSACCION, SE VOLVERA A ATRAS.", vbOK, "Sistema de Gestión.")
                Try
                    transaccion.Rollback() 'deshace todos los insert en la bd, en ambas tablas. -------------IMPORTANTEEEEEEEEEEEEEEEEE
                Catch ex_rollback As Exception
                    'no muestro nada
                End Try
            End Try
        End Using
        'defino un dataset para devolver a la capa de aplicacion, necesito mandar 2 valores. validar_op y factura_id para generar el reporte.
        Dim tabla_datos As New DataTable
        tabla_datos.Clear()
        tabla_datos.Columns.Add("validar_op")
        tabla_datos.Columns.Add("factura_id")

        Dim fila As DataRow = tabla_datos.NewRow
        fila("validar_op") = validar_op
        fila("factura_id") = factura_id

        tabla_datos.Rows.Add(fila)

        Return tabla_datos
    End Function






    Public Function CtaCte_buscar_Cliente(ByVal cliente_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_buscar_Cliente", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", cliente_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function CtaCte_movimiento_alta(ByVal CtaCte_id As Integer, ByVal MovimientosCtaCte_tipo As String, ByVal MovimientosCtaCte_concepto As String,
                                 ByVal MovimientosCtaCte_monto As Decimal, ByVal MovimientosCtaCte_fecha As DateTime) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_movimiento_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_tipo", MovimientosCtaCte_tipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_concepto", MovimientosCtaCte_concepto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_monto", MovimientosCtaCte_monto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_fecha", MovimientosCtaCte_fecha))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function CtaCte_movimiento_modificar(ByVal movimiento_id As Integer, ByVal concepto As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_movimiento_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@movimiento_id", movimiento_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_concepto", concepto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Sub Venta_CtaCte_alta(ByVal factura_id As Integer, ByVal CtaCte_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_CtaCte_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@factura_id", factura_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub

    Public Sub CtaCte_registrar_egreso(ByVal CtaCte_id As Integer, ByVal CtaCte_total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_registrar_egreso", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_total", CtaCte_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub

    Public Function Recibo_obtener_ultimo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recibo_obtener_ultimo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", cliente_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recibo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Recibo_alta(ByVal mov_id As Integer, ByVal fecha As DateTime) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recibo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_id", mov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha", fecha))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recibo")
        dbconn.Close()
        Return (ds_JE)
    End Function

    Public Function Recibo_obtener_reporte(ByVal recibo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recibo_obtener_reporte", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@recibo_id", recibo_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recibo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Recibo_recuperar_todos_ctacte(ByVal CtaCte_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recibo_recuperar_todos_ctacte", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recibo")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
