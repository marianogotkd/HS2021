Public Class VentaRegional_consulta
    Dim DAventaregional As New Datos.Venta_regional


    Dim ds_ventas As New DataSet
    Private Sub obtener_todos_ventas()
        ds_ventas = DAventaregional.Venta_obtener_todas()

        DG_ventas.DataSource = ds_ventas.Tables(1)


    End Sub
    Private Sub Mostrar_detalle()
        limpiar_detalle()

        If DG_ventas.Rows.Count <> 0 Then
            Lb_detalle_nroventa.Text = DG_ventas.CurrentRow.Cells("VentacodigoDataGridViewTextBoxColumn").Value
            Lb_detalle_cliente.Text = DG_ventas.CurrentRow.Cells("CLInomDataGridViewTextBoxColumn").Value
            Lb_detalle_fechafactura.Text = DG_ventas.CurrentRow.Cells("FechafacturaDataGridViewTextBoxColumn").Value
            Lb_detalle_monto.Text = DG_ventas.CurrentRow.Cells("VentatotalDataGridViewTextBoxColumn").Value
            Lb_detalle_nrofactura.Text = DG_ventas.CurrentRow.Cells("NrofacturaDataGridViewTextBoxColumn").Value
            Dim ds_detalle As DataSet = DAventaregional.Venta_buscar_detalles(DG_ventas.CurrentRow.Cells(0).Value)
            DG_detalles.DataSource = ds_detalle.Tables(0)

        Else
            DG_ventas.DataSource = ""
            DG_detalles.DataSource = ""
        End If

    End Sub

    Private Sub limpiar_detalle()

        Lb_detalle_cliente.Text = ".................................."
        Lb_detalle_fechafactura.Text = "00/00/00"
        Lb_detalle_monto.Text = "00,00"
        Lb_detalle_nroventa.Text = "0000"
        Lb_detalle_nrofactura.Text = "0000"

    End Sub


    Private Sub VentaRegional_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obtener_todos_ventas()
    End Sub

    Private Sub DG_ventas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_ventas.CellClick
        Mostrar_detalle()



        Dim cell As DataGridViewCell = DG_ventas.CurrentCell
        If Not (TypeOf cell Is DataGridViewButtonCell) Then Return
        Dim ds_vtainforme As DataSet = DAventaregional.Venta_informe_detallado(DG_ventas.CurrentRow.Cells("VentaidDataGridViewTextBoxColumn").Value)
        ' Dim ds_cliente As DataSet = DAcliente.Informe_Cliente
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Informe Regional\CR_Informe_venta_detalle.rpt")
        CrReport.Database.Tables("Venta").SetDataSource(ds_vtainforme.Tables(0))
        CrReport.Database.Tables("Venta_detalle").SetDataSource(ds_vtainforme.Tables(1))
        'CrReport.SetDataSource(ds_Jugador.Tables(0))
        Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
        'ERROR_Socio.Visible = False
        Informe_Mostrar.Show()

    End Sub

    Private Sub DG_ventas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ventas.SelectionChanged
        Mostrar_detalle()
    End Sub



#Region "busqueda"
    Private Sub TX_buscar_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_buscar_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            DG_ventas.DataSource = Nothing
            If TX_buscar_nombre.Text <> "" Then
                Filtrar_x_producto(Me.TX_buscar_nombre.Text)
            Else
                DG_ventas.DataSource = ds_ventas.Tables(1)
            End If
        End If
    End Sub
    Private Sub BO_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_producto.Click
        DG_ventas.DataSource = Nothing
        If TX_buscar_nombre.Text <> "" Then
            Filtrar_x_producto(Me.TX_buscar_nombre.Text)
        Else
            DG_ventas.DataSource = ds_ventas.Tables(1)
        End If
    End Sub

    Public Sub Filtrar_x_producto(ByVal parametro As String)
        If ds_ventas.Tables.Count <> 0 Then
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("Venta_id")
            table_filtrada.Columns.Add("Venta_codigo")
            table_filtrada.Columns.Add("CLI_id")
            table_filtrada.Columns.Add("CLI_nom")
            table_filtrada.Columns.Add("Venta_fecha")
            table_filtrada.Columns.Add("Nro_factura")
            table_filtrada.Columns.Add("Fecha_factura")
            table_filtrada.Columns.Add("Venta_total")
            table_filtrada.Rows.Clear()
            DG_ventas.DataSource = Nothing
            Dim table As DataTable = ds_ventas.Tables(1)
            Dim apellido As String = parametro
            Dim a = 0
            While a < ds_ventas.Tables(2).Rows.Count
                Dim fila As String = ds_ventas.Tables(2).Rows(a).Item("PROD_nombre")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    Dim venta_id As String = ds_ventas.Tables(2).Rows(a).Item("Venta_id")
                    'aqui lo buscamos en tabla 1 para importarlo a table_filtrada
                    Dim k As Integer = 0
                    While k < ds_ventas.Tables(1).Rows.Count
                        If venta_id = ds_ventas.Tables(1).Rows(k).Item("Venta_id") Then
                            'solo lo importo si es q ya no existe
                            Dim ind As Integer = 0
                            Dim valido = "si"
                            While ind < table_filtrada.Rows().Count
                                If venta_id = table_filtrada.Rows(ind).Item("Venta_id") Then
                                    valido = "no"
                                    ind = table_filtrada.Rows.Count
                                End If
                                ind = ind + 1
                            End While

                            If valido = "si" Then
                                table_filtrada.ImportRow(table.Rows(k))
                            End If

                            k = ds_ventas.Tables(1).Rows.Count
                        End If
                        k = k + 1
                    End While
                End If

                'If apellido = table.Rows(a).Item("CLI_ape") Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If
                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DG_ventas.DataSource = table_filtrada
            Else
                DG_ventas.DataSource = ds_ventas.Tables(1)
            End If
        End If
    End Sub


#End Region

    
    
    Private Sub TX_buscar_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_buscar_codigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            DG_ventas.DataSource = Nothing
            If TX_buscar_codigo.Text <> "" Then
                Filtrar_x_factura(Me.TX_buscar_codigo.Text)
            Else
                DG_ventas.DataSource = ds_ventas.Tables(1)
            End If
        End If
    End Sub

    Private Sub bo_nrofactura_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bo_nrofactura.Click
        DG_ventas.DataSource = Nothing
        If TX_buscar_codigo.Text <> "" Then
            Filtrar_x_factura(Me.TX_buscar_codigo.Text)
        Else
            DG_ventas.DataSource = ds_ventas.Tables(1)
        End If
    End Sub

    Public Sub Filtrar_x_factura(ByVal parametro As String)
        If ds_ventas.Tables.Count <> 0 Then
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("Venta_id")
            table_filtrada.Columns.Add("Venta_codigo")
            table_filtrada.Columns.Add("CLI_id")
            table_filtrada.Columns.Add("CLI_nom")
            table_filtrada.Columns.Add("Venta_fecha")
            table_filtrada.Columns.Add("Nro_factura")
            table_filtrada.Columns.Add("Fecha_factura")
            table_filtrada.Columns.Add("Venta_total")
            table_filtrada.Rows.Clear()
            table_filtrada.Rows.Clear()
            DG_ventas.DataSource = Nothing
            Dim table As DataTable = ds_ventas.Tables(1)
            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("Nro_factura")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                'If apellido = table.Rows(a).Item("CLI_ape") Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If
                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DG_ventas.DataSource = table_filtrada
            Else
                DG_ventas.DataSource = ds_ventas.Tables(1)
            End If
        End If
    End Sub


    Private Sub DG_detalles_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_detalles.CellClick
        Dim cell As DataGridViewCell = DG_detalles.CurrentCell
        If Not (TypeOf cell Is DataGridViewButtonCell) Then Return
        Dim ds_lotesvendidos As DataSet = DAventaregional.Venta_obtener_lotesvendidos(DG_detalles.CurrentRow.Cells("VentadetidDataGridViewTextBoxColumn").Value, DG_detalles.CurrentRow.Cells("PRODidDataGridViewTextBoxColumn").Value)
        VentaRegional_lotesvendidos.Show()
        VentaRegional_lotesvendidos.DataGridView1.DataSource = ds_lotesvendidos.Tables(0)
        VentaRegional_lotesvendidos.lb_codigo.Text = ds_lotesvendidos.Tables(0).Rows(0).Item("PROD_codigo")
        VentaRegional_lotesvendidos.lb_nombre.Text = ds_lotesvendidos.Tables(0).Rows(0).Item("PROD_nombre")
        VentaRegional_lotesvendidos.lb_presentacion.Text = ds_lotesvendidos.Tables(0).Rows(0).Item("PROD_presentacion")
    End Sub
End Class


