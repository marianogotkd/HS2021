Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Venta
    Inherits Datos.Conexion

#Region "SECTOR"
    Public Sub Mesas_Sector_modificar(ByVal Sector_nombre_fijo As String, ByVal Sector_nombre_usuario As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Mesas_Sector_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sector_nombre_fijo", Sector_nombre_fijo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sector_nombre_usuario", Sector_nombre_usuario))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mesas")
        dbconn.Close()
    End Sub

    Public Function Mesas_Sector_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mesas_Sector_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mesas")
        dbconn.Close()
        Return ds_JE
    End Function



#End Region

#Region "MESAS"
    'VentaConfig_alta
    Public Sub VentaConfig_alta(ByVal Ventaprod_id As Integer, ByVal LISTA_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaConfig_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Ventaprod_id", Ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
    End Sub
    'VentaConfig_buscar
    Public Function VentaConfig_buscar(ByVal Ventaprod_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaConfig_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Ventaprod_id", Ventaprod_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function

    'MESAS_alta
    Public Sub Mesas_alta(ByVal MESA_numero As Integer, ByVal Estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Mesas_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@MESA_numero", MESA_numero))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Estado", Estado))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
    End Sub

    'MESAS_modificar ----NUEVO DISEÑO
    Public Sub MESAS_modificar(ByVal MESA_id As Integer, ByVal MESA_numero As Integer, ByVal Estado As String, ByVal Activo As String, ByVal Ventaprod_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Mesas_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@MESA_id", MESA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MESA_numero", MESA_numero))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Estado", Estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Activo", Activo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Ventaprod_id", Ventaprod_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub

    'Mesas_obtener_todas -----NUEVO DISEÑO
    Public Function Mesas_obtener_todas() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mesas_obtener_todas", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mesas")
        dbconn.Close()
        Return ds_JE
    End Function

    'Mesas_obtener
    Public Function Mesas_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mesas_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mesas")
        dbconn.Close()
        Return ds_JE
    End Function
    'ventaproducto_alta_mesa
    Public Function VentaProducto_alta_mesa(ByVal ventaprod_total As Decimal, ByVal ventaprod_pagoparcial As Decimal, ByVal ventaprod_estado As String, ByVal ventaprod_fecha As Date, ByVal usuario_id As Integer, ByVal ventaprod_tipovta As String, ByVal cliente_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_alta_mesa", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_pagoparcial", ventaprod_pagoparcial))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_estado", ventaprod_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_fecha", ventaprod_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_tipovta", ventaprod_tipovta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cliente_id", cliente_id))
        'el tipo de venta es cliente o consumidor final
        'el id del cliente es 0 en caso de ser consumidor final
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'ventaproducto_modificar_mesa
    Public Sub VentaProducto_modificar_mesa(ByVal ventaprod_id As Integer, ByVal ventaprod_total As Decimal, ByVal ventaprod_pagoparcial As Decimal, ByVal ventaprod_estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_modificar_mesa", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_pagoparcial", ventaprod_pagoparcial))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_estado", ventaprod_estado))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoVenta")
        dbconn.Close()
    End Sub

    'VentaProductoDetalle_borrar
    Public Sub VentaProductoDetalle_borrar(ByVal ventaprod_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProductoDetalle_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub

    'Mesas_eliminar
    Public Sub Mesas_eliminar(ByVal MESA_numero As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mesas_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@MESA_numero", MESA_numero))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub



    Public Function VentaProducto_buscar(ByVal ventaprod As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod", ventaprod))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function VentaProductoDetalle_buscar(ByVal ventaprod_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProductoDetalle_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Sector_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sector_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sector")
        dbconn.Close()
        Return ds_JE
    End Function



#End Region

    'venta_alta
    Public Sub Venta_alta(ByVal venta_fecha As Date, ByVal usuario_id As String, ByVal cliente_id As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@venta_fecha", venta_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cliente_id", cliente_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub


    Public Sub Venta_actualizar_stock_Caja(ByVal prod_codinterno As Integer, ByVal prod_stock As Integer)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_actualizar_stock_Caja", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_stock", prod_stock))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub

    'actualizar stock de los item del combo
    Public Sub Venta_actualizar_stock_Caja_2(ByVal prod_id As Integer, ByVal prod_stock As Integer)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_actualizar_stock_Caja_2", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_stock", prod_stock))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub




    'ventaproducto_alta
    Public Function VentaProducto_alta(ByVal ventaprod_total As Decimal, ByVal ventaprod_fecha As Date, ByVal usuario_id As Integer, ByVal ventaprod_tipovta As String, ByVal cliente_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProducto_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_fecha", ventaprod_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_tipovta", ventaprod_tipovta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cliente_id", cliente_id))

        'el tipo de venta es cliente o consumidor final
        'el id del cliente es 0 en caso de ser consumidor final

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'VentaProductoDetalle_alta
    Public Sub VentaProductoDetalle_alta(ByVal ventaprod_id As Integer,
                                         ByVal prod_id As Integer,
                                         ByVal ventaprod_cant As Integer,
                                         ByVal ventaprod_precio As Decimal,
                                         ByVal ventaprod_subtotal As Decimal,
                                         ByVal ventaprod_descripcion As String,
                                         ByVal codigointerno As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProductoDetalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_cant", ventaprod_cant))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_precio", ventaprod_precio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_subtotal", ventaprod_subtotal))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_descripcion", ventaprod_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@codigointerno", codigointerno))

        'el tipo de venta es cliente o consumidor final
        'el id del cliente es 0 en caso de ser consumidor final

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Producto")
        dbconn.Close()

    End Sub




    'ventaturno_alta
    Public Sub Ventaturno_alta(ByVal venta_id As String, ByVal turno_id As String, ByVal turno_tipo As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaTurno_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@venta_id", venta_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_id", turno_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_tipo", turno_tipo))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Turno")
        dbconn.Close()

    End Sub


    'Venta_obtenerProducto_Combos ---
    Public Function Venta_obtenerProducto_Combos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtenerProducto_Combos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function


    'Venta_obtenerProducto_listaregular
    Public Function Venta_obtenerProducto_listaregular(ByVal Lista_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtenerProducto_listaregular", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Lista_id", Lista_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Venta_Usuario_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_Usuario_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function VentaProducto_consultausuario() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProducto_consultausuario", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Ventaproducto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function VentaProducto_consulta(ByVal USU_id As Integer, ByVal ventaprod_fecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProducto_consulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_fecha", ventaprod_fecha))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Ventaproducto")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
