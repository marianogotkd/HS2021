﻿Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Producto
    Inherits Datos.Conexion

    Public Function Producto_Alta(ByVal prod_descripcion As String, ByVal prod_descrilarga As String, ByVal prod_precio_vta As Decimal, ByVal prod_stock As Integer, ByVal prod_ptorepo As String, ByVal prod_codinterno As String,
                                  ByVal prod_codbarra As String, ByVal idcat As Integer, ByVal nrocat As Integer, ByVal idmarca As Integer, ByVal prod_unimedida As String, ByVal producto_foto() As Byte) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_descripcion", prod_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_descrilarga", prod_descrilarga))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_precio_vta", prod_precio_vta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_stock", prod_stock))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_ptorepo", prod_ptorepo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codbarra", prod_codbarra))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_idcat", idcat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_nrocat", nrocat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", idmarca))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_unidadmedida", prod_unimedida))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_foto", producto_foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'ProveedorProducto alta
    Public Function ProveedorProducto_alta(ByVal prov_id As Integer, ByVal prod_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ProveedorProducto_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_id", prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProveedorProducto")
        dbconn.Close()
        Return ds_JE
    End Function

    'ProveedorProductoCompra alta
    Public Sub ProveedorProductoCompra_alta(ByVal prov_prod_id As Integer, ByVal prov_prod_com_fecha As Date, ByVal prov_prod_com_precio As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ProveedorProductoCompra_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_prod_id", prov_prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_prod_com_fecha", prov_prod_com_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_prod_com_precio", prov_prod_com_precio))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProveedorProductoCompra")
        dbconn.Close()
    End Sub

    'Producto_buscarcod
    Public Function Producto_buscarcod(ByVal codinterno As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("producto_buscarcod", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codigo", codinterno))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'Producto_buscar_id
    Public Function Producto_buscar_id(ByVal prod_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_buscar_id", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function producto_buscarnom(ByVal prod_descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("producto_buscarnom", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_descripcion", prod_descripcion))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function producto_buscarcodbarra(ByVal prod_codbarra As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("producto_buscarcodbarra", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codbarra", prod_codbarra))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Producto_modificar(ByVal prod_id As Integer, ByVal prod_precio_vta As Decimal, ByVal prod_stock As Integer, ByVal prod_ptorepo As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_precio_vta", prod_precio_vta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_stock", prod_stock))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_ptorepo", prod_ptorepo))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@producto_foto", producto_foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Producto_modifDatos(ByVal prod_id As Integer, ByVal prod_descripcion As String, ByVal prod_descrilarga As String, ByVal prod_codbarra As String, ByVal idmarca As Integer, ByVal prod_unidadmedida As String, ByVal producto_foto() As Byte) As DataSet
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

    Public Function Producto_obtenerDatos(ByVal codinterno As String) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("producto_obtenerDatos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", codinterno))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function prod_id_buscar(ByVal prod_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("prod_id_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function
    Public Function prod_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("prod_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Prov_prod_com_buscar(ByVal prov_prod_com_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("prov_prod_com_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_prod_com_id", prov_prod_com_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProveedorProductoCompra")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function ProdProvCom_modificar(ByVal prov_prod_com_id As Integer, ByVal prov_prod_com_precio As Decimal, ByVal prov_prod_com_fecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ProdProvCom_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_prod_com_id", prov_prod_com_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_prod_com_precio", prov_prod_com_precio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_prod_com_fecha", prov_prod_com_fecha))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProveedorProductoCompra")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Codinterno_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Codinterno_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Producto")
        dbconn.Close()
        Return ds_MT
    End Function

    'Producto_ActualizarStock
    Public Sub Producto_ActualizarStock(ByVal prod_id As Integer, ByVal prod_stock As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_ActualizarStock", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_stock", prod_stock))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
    End Sub


    Public Function Producto_modificar_Cant(ByVal PROD_codigo As Integer, ByVal PROD_cant_total As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_modificar_Cant", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_codigo", PROD_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PROD_cant_total", PROD_cant_total))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto_modificar_Cant")
        dbconn.Close()
        Return ds_JE
    End Function



End Class
