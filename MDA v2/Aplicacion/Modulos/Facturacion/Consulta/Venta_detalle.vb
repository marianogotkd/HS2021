﻿Public Class Venta_detalle
    Dim DAventa As New Datos.Venta
    Public ventaprod_id
    Public sucursal_id
    Public Venta_consulta As New DataSet
    Dim facturacion_ds_report As New Facturacion_ds_report
    Dim DAcliente As New Datos.Cliente
    Private Sub limbiar_datos_del_reporte()
        facturacion_ds_report.Tables("Cliente").Rows.Clear()
        facturacion_ds_report.Tables("Sucursal").Rows.Clear()
        facturacion_ds_report.Tables("Empresa").Rows.Clear()
        facturacion_ds_report.Tables("venta").Rows.Clear()
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
    End Sub




    Private Sub crear_reporte(ByVal ventaprod_id As Integer)
        limbiar_datos_del_reporte() 'esto lo hago porque cuando intento abrir varios reportes se juntan todos los datos, los de la nueva consulta con la anterior

        '1) cargo todos los datos en un ds
        Dim ds_venta As DataSet = DAventa.Venta_consultar_detalle_venta(ventaprod_id, sucursal_id)


        '///////////////TABLA CLIENTE//////////////////////////////////'
        facturacion_ds_report.Tables("Cliente").Rows.Clear()
        If ds_venta.Tables(0).Rows.Count <> 0 Then 'la tabla es la que tiene asociado venta a un cliente, si el cliente es consumidor final, entonces esta tabla esta vacia
            'Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni(CStr(ds_venta.Tables(0).Rows(0).Item("DNI")))
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = ds_venta.Tables(0).Rows(0).Item("fantasia") + ", " + ds_venta.Tables(0).Rows(0).Item("SucxClie_nombre")
            row_cliente("dni") = ds_venta.Tables(0).Rows(0).Item("DNI")
            row_cliente("telefono") = ds_venta.Tables(0).Rows(0).Item("SucxClie_tel")
            row_cliente("mail") = ds_venta.Tables(0).Rows(0).Item("SucxClie_mail")
            row_cliente("direccion") = ds_venta.Tables(0).Rows(0).Item("SucxClie_dir")
            row_cliente("localidad") = ds_venta.Tables(0).Rows(0).Item("provincia") + ", " + ds_venta.Tables(0).Rows(0).Item("Localidad")
            row_cliente("iva_condicion") = ds_venta.Tables(0).Rows(0).Item("IVA_Descripcion").ToString
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        Else
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = ""
            row_cliente("dni") = ""
            row_cliente("telefono") = ""
            row_cliente("mail") = ""
            row_cliente("iva_condicion") = "Consumidor Final"
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        End If

        '///////////////TABLA SUCURSAL//////////////////////////////////'
        facturacion_ds_report.Tables("Sucursal").Rows.Clear()
        Dim row_sucursal As DataRow = facturacion_ds_report.Tables("Sucursal").NewRow()
        row_sucursal("sucursal") = ds_venta.Tables(3).Rows(0).Item("sucursal")
        row_sucursal("direccion") = ds_venta.Tables(3).Rows(0).Item("direccion")
        row_sucursal("telefono") = ds_venta.Tables(3).Rows(0).Item("telefono")
        row_sucursal("mail") = ds_venta.Tables(3).Rows(0).Item("mail")
        row_sucursal("cuit") = "20 - 00000000 - 4"
        Facturacion_ds_report.Tables("Sucursal").Rows.Add(row_sucursal)

        '///////////////TABLA EMPRESA//////////////////////////////////'
        facturacion_ds_report.Tables("Empresa").Rows.Clear()
        If ds_venta.Tables(4).Rows.Count <> 0 Then
            facturacion_ds_report.Tables("Empresa").Merge(ds_venta.Tables(4))
        End If



        '///////////////TABLA VENTA//////////////////////////////////'
        'pregunto por el estado de los table 0 y 1, si 0 esta vacio, los datos estan en table 1, q es consumidor final
        facturacion_ds_report.Tables("venta").Rows.Clear()
        If ds_venta.Tables(0).Rows.Count <> 0 Then
            Dim row_venta As DataRow = Facturacion_ds_report.Tables("venta").NewRow()
            row_venta("nro_factura") = ds_venta.Tables(0).Rows(0).Item("factura_id") 'aqui el id de la factura.
            row_venta("fecha") = ds_venta.Tables(0).Rows(0).Item("factura_fecha") 'aqui va la fecha de la factura
            row_venta("vendedor") = ds_venta.Tables(0).Rows(0).Item("vendedor")
            row_venta("tipo_venta") = ds_venta.Tables(0).Rows(0).Item("ventaprod_tipovta")
            Facturacion_ds_report.Tables("venta").Rows.Add(row_venta)
        Else
            'esta en tabla 1, es consumidor final
            Dim row_venta As DataRow = Facturacion_ds_report.Tables("venta").NewRow()
            row_venta("nro_factura") = ds_venta.Tables(1).Rows(0).Item("factura_id")
            row_venta("fecha") = ds_venta.Tables(1).Rows(0).Item("factura_fecha")
            row_venta("vendedor") = ds_venta.Tables(1).Rows(0).Item("vendedor")
            row_venta("tipo_venta") = ds_venta.Tables(1).Rows(0).Item("ventaprod_tipovta")
            Facturacion_ds_report.Tables("venta").Rows.Add(row_venta)
        End If

        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        'pregunto por el estado de los table 0 y 1, si 0 esta vacio, los datos estan en table 1, q es consumidor final
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        If ds_venta.Tables(0).Rows.Count <> 0 Then
            Dim row_totales As DataRow = Facturacion_ds_report.Tables("Totales_aplicados").NewRow()
            row_totales("subtotal") = ds_venta.Tables(0).Rows(0).Item("ventaprod_subtotal")
            row_totales("total") = ds_venta.Tables(0).Rows(0).Item("ventaprod_total")
            row_totales("iva") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_iva_porcentaje"))
            row_totales("descuento_porcentaje") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_descuento_porcentaje"))
            row_totales("descuento_pesos") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_descuento_pesos"))
            row_totales("iva_pesos") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_iva_pesos"))
            Facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)
        Else
            Dim row_totales As DataRow = Facturacion_ds_report.Tables("Totales_aplicados").NewRow()
            row_totales("subtotal") = ds_venta.Tables(1).Rows(0).Item("ventaprod_subtotal")
            row_totales("total") = ds_venta.Tables(1).Rows(0).Item("ventaprod_total")
            row_totales("iva") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_iva_porcentaje"))
            row_totales("descuento_porcentaje") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_descuento_porcentaje"))
            row_totales("descuento_pesos") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_descuento_pesos"))
            row_totales("iva_pesos") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_iva_pesos"))
            Facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)
        End If


        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        Dim i As Integer = 0
        While i < ds_venta.Tables(2).Rows.Count
            Dim row_prodADD As DataRow = Facturacion_ds_report.Tables("Producto_agregado").NewRow()
            row_prodADD("PROD_id") = ds_venta.Tables(2).Rows(i).Item("prod_id")
            row_prodADD("codinterno") = CInt(ds_venta.Tables(2).Rows(i).Item("prod_codinterno"))
            row_prodADD("descripcion") = ds_venta.Tables(2).Rows(i).Item("ventaprod_descripcion")
            row_prodADD("detalle") = ds_venta.Tables(2).Rows(i).Item("prod_descrilarga")
            row_prodADD("cantidad") = CDec(ds_venta.Tables(2).Rows(i).Item("ventaprod_cant"))
            row_prodADD("precio_unitario") = CDec(ds_venta.Tables(2).Rows(i).Item("ventaprod_precio"))
            row_prodADD("precio_subtotal") = CDec(ds_venta.Tables(2).Rows(i).Item("ventaprod_subtotal"))
            row_prodADD("codbarra") = ""
            row_prodADD("TURNO_id") = ""
            row_prodADD("descuento") = CDec(ds_venta.Tables(2).Rows(i).Item("descuento"))
            row_prodADD("grupo_id") = CInt(1)
            Facturacion_ds_report.Tables("Producto_agregado").Rows.Add(row_prodADD)
            i = i + 1
        End While

        Dim ocultar As String = "si"
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_comprobante.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(Facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(Facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(Facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("venta").SetDataSource(Facturacion_ds_report.Tables("venta"))
        CrReport.Database.Tables("Producto_agregado").SetDataSource(Facturacion_ds_report.Tables("Producto_agregado"))
        CrReport.Database.Tables("Totales_aplicados").SetDataSource(Facturacion_ds_report.Tables("Totales_aplicados"))
        'Facturacion_report_show.CrystalReportViewer1.ReportSource = CrReport
        Dim numerofactura As String = ds_venta.Tables(1).Rows(0).Item("factura_id")
        Dim factura_report As New Facturacion_report_show
        factura_report.CrystalReportViewer1.ReportSource = CrReport
        factura_report.Text = "Comprobante Nº: " + CStr(numerofactura) + " - Imprimir."
        factura_report.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ''Dim ds_cliente As DataSet = DAcliente.Informe_Cliente
        'If Venta_consulta.Tables(0).Rows.Count > 0 Then
        '    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        '    CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_Informe_Venta_detalle_prod.rpt")
        '    CrReport.Database.Tables("Venta_consulta").SetDataSource(Venta_consulta.Tables(0))
        '    Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
        '    Informe_Mostrar.Show()
        'End If
        crear_reporte(ventaprod_id)
    End Sub

    Private Sub Venta_detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            'Venta_consulta_sucursal.sucursal_id = sucursal_id
            'Venta_consulta_sucursal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Venta_detalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '1) cargo todos los datos en un ds
        Dim ds_venta As DataSet = DAventa.Venta_consultar_detalle_venta(ventaprod_id, sucursal_id)
        '///////////////TABLA CLIENTE//////////////////////////////////'
        If ds_venta.Tables(0).Rows.Count <> 0 Then 'la tabla es la que tiene asociado venta a un cliente, si el cliente es consumidor final, entonces esta tabla esta vacia
            TextBox_fantasia.Text = ds_venta.Tables(0).Rows(0).Item("fantasia") + ", " + ds_venta.Tables(0).Rows(0).Item("SucxClie_nombre")
            TextBox_dni.Text = ds_venta.Tables(0).Rows(0).Item("DNI")
            TextBox_telefono.Text = ds_venta.Tables(0).Rows(0).Item("SucxClie_tel") 'telefono
            TextBox_mail.Text = ds_venta.Tables(0).Rows(0).Item("SucxClie_mail")
        End If
        '///////////////TABLA SUCURSAL//////////////////////////////////'
        'Dim row_sucursal As DataRow = Facturacion_ds_report.Tables("Sucursal").NewRow()
        'row_sucursal("sucursal") = ds_venta.Tables(3).Rows(0).Item("sucursal")
        'row_sucursal("direccion") = ds_venta.Tables(3).Rows(0).Item("direccion")
        'row_sucursal("telefono") = ds_venta.Tables(3).Rows(0).Item("telefono")
        'row_sucursal("mail") = ds_venta.Tables(3).Rows(0).Item("mail")
        'row_sucursal("cuit") = "20 - 32547904 - 4"
        'Facturacion_ds_report.Tables("Sucursal").Rows.Add(row_sucursal)
        '///////////////TABLA EMPRESA//////////////////////////////////'
        'If ds_venta.Tables(4).Rows.Count <> 0 Then
        '    Facturacion_ds_report.Tables("Empresa").Merge(ds_venta.Tables(4))
        'End If
        '///////////////TABLA VENTA//////////////////////////////////'
        'pregunto por el estado de los table 0 y 1, si 0 esta vacio, los datos estan en table 1, q es consumidor final
        If ds_venta.Tables(0).Rows.Count <> 0 Then
            TextBox_factura.Text = ds_venta.Tables(0).Rows(0).Item("factura_id")
            TextBox_fecha.Text = ds_venta.Tables(0).Rows(0).Item("factura_fecha")
            TextBox_vendedor.Text = ds_venta.Tables(0).Rows(0).Item("vendedor")
            TextBox_tipovta.Text = ds_venta.Tables(0).Rows(0).Item("ventaprod_tipovta")
            'Dim row_venta As DataRow = Facturacion_ds_report.Tables("venta").NewRow()
            'row_venta("nro_factura") = ds_venta.Tables(0).Rows(0).Item("ventaprod_id")
            'row_venta("fecha") = ds_venta.Tables(0).Rows(0).Item("fecha")
            'row_venta("vendedor") = ds_venta.Tables(0).Rows(0).Item("vendedor")
            'row_venta("tipo_venta") = ds_venta.Tables(0).Rows(0).Item("ventaprod_tipovta")
            'Facturacion_ds_report.Tables("venta").Rows.Add(row_venta)
        Else
            TextBox_factura.Text = ds_venta.Tables(1).Rows(0).Item("factura_id")
            TextBox_fecha.Text = ds_venta.Tables(1).Rows(0).Item("factura_fecha")
            TextBox_vendedor.Text = ds_venta.Tables(1).Rows(0).Item("vendedor")
            TextBox_tipovta.Text = ds_venta.Tables(1).Rows(0).Item("ventaprod_tipovta")
            ''esta en tabla 1, es consumidor final
            'Dim row_venta As DataRow = Facturacion_ds_report.Tables("venta").NewRow()
            'row_venta("nro_factura") = ds_venta.Tables(1).Rows(0).Item("ventaprod_id")
            'row_venta("fecha") = ds_venta.Tables(1).Rows(0).Item("fecha")
            'row_venta("vendedor") = ds_venta.Tables(1).Rows(0).Item("vendedor")
            'row_venta("tipo_venta") = ds_venta.Tables(1).Rows(0).Item("ventaprod_tipovta")
            'Facturacion_ds_report.Tables("venta").Rows.Add(row_venta)
        End If
        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        'pregunto por el estado de los table 0 y 1, si 0 esta vacio, los datos estan en table 1, q es consumidor final
        If ds_venta.Tables(0).Rows.Count <> 0 Then
            TextBox_subtotal.Text = ds_venta.Tables(0).Rows(0).Item("ventaprod_subtotal")
            TextBox_total.Text = ds_venta.Tables(0).Rows(0).Item("ventaprod_total")
            lb_porc_iva.Text = "%" + CStr(CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_iva_porcentaje")))
            Lb_porc_descuento.Text = "%" + CStr(CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_descuento_porcentaje")))
            TextBox_descuento.Text = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_descuento_pesos"))
            TextBox_impuesto.Text = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_iva_pesos"))
            'Dim row_totales As DataRow = Facturacion_ds_report.Tables("Totales_aplicados").NewRow()
            'row_totales("subtotal") = ds_venta.Tables(0).Rows(0).Item("ventaprod_subtotal")
            'row_totales("total") = ds_venta.Tables(0).Rows(0).Item("ventaprod_total")
            'row_totales("iva") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_iva_porcentaje"))
            'row_totales("descuento_porcentaje") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_descuento_porcentaje"))
            'row_totales("descuento_pesos") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_descuento_pesos"))
            'row_totales("iva_pesos") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_iva_pesos"))
            'Facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)
        Else
            TextBox_subtotal.Text = ds_venta.Tables(1).Rows(0).Item("ventaprod_subtotal")
            TextBox_total.Text = ds_venta.Tables(1).Rows(0).Item("ventaprod_total")
            lb_porc_iva.Text = "%" + CStr(CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_iva_porcentaje")))
            Lb_porc_descuento.Text = "%" + CStr(CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_descuento_porcentaje")))
            TextBox_descuento.Text = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_descuento_pesos"))
            TextBox_impuesto.Text = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_iva_pesos"))
            'Dim row_totales As DataRow = Facturacion_ds_report.Tables("Totales_aplicados").NewRow()
            'row_totales("subtotal") = ds_venta.Tables(1).Rows(0).Item("ventaprod_subtotal")
            'row_totales("total") = ds_venta.Tables(1).Rows(0).Item("ventaprod_total")
            'row_totales("iva") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_iva_porcentaje"))
            'row_totales("descuento_porcentaje") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_descuento_porcentaje"))
            'row_totales("descuento_pesos") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_descuento_pesos"))
            'row_totales("iva_pesos") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_iva_pesos"))
            'Facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)
        End If
        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        Venta_consulta_ds.Tables("Productos_detalle_consulta").Rows.Clear() 'choco edition
        Dim i As Integer = 0
        While i < ds_venta.Tables(2).Rows.Count
            Dim row_prodADD As DataRow = Venta_consulta_ds.Tables("Productos_detalle_consulta").NewRow()
            row_prodADD("PROD_id") = ds_venta.Tables(2).Rows(i).Item("prod_id")
            row_prodADD("codinterno") = CInt(ds_venta.Tables(2).Rows(i).Item("prod_codinterno"))
            row_prodADD("descripcion") = ds_venta.Tables(2).Rows(i).Item("ventaprod_descripcion")
            row_prodADD("detalle") = ds_venta.Tables(2).Rows(i).Item("prod_descrilarga")
            row_prodADD("cantidad") = CDec(ds_venta.Tables(2).Rows(i).Item("ventaprod_cant"))
            row_prodADD("precio_unitario") = CDec(ds_venta.Tables(2).Rows(i).Item("ventaprod_precio"))
            row_prodADD("precio_subtotal") = CDec(ds_venta.Tables(2).Rows(i).Item("ventaprod_subtotal"))
            row_prodADD("codbarra") = ""
            row_prodADD("TURNO_id") = ""
            '/choco modificacion: 02-12-2019, agrego columna descuento
            row_prodADD("descuento") = CDec(ds_venta.Tables(2).Rows(i).Item("descuento"))
            '/////////////////fin modificacion/////////////////////////
            Venta_consulta_ds.Tables("Productos_detalle_consulta").Rows.Add(row_prodADD) 'choco edition
            i = i + 1
        End While

        If ds_venta.Tables(5).Rows.Count <> 0 Then
            GroupBox_tarjeta.Visible = True
            TextBox_nrotarjeta.Text = ds_venta.Tables(5).Rows(0).Item("Venta_x_tarjeta_nrotarjeta")
            TextBox_nrocomprobante.Text = ds_venta.Tables(5).Rows(0).Item("Venta_x_tarjeta_nrocomprobante")
        End If
    End Sub
End Class