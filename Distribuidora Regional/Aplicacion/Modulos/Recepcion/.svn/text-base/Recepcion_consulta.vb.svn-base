Public Class Recepcion_consulta

    Dim DAproveedores As New Datos.Proveedor
    Dim DArecepcion As New Datos.Recepcion
    Dim DAmarca As New Datos.Marca

    Private Sub Recepcion_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_todos_productos()
    End Sub

    Dim ds_productos As DataSet
    Private Sub Obtener_todos_productos()
        ds_productos = DArecepcion.Recepcion_obtener_todos_productos()

        DataGridView1.DataSource = ds_productos.Tables(0)
        DataGridView1.Refresh()
    End Sub

    Private Sub BO_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ape.Click
        DataGridView1.DataSource = Nothing
        If TX_buscar_nombre.Text <> "" Then
            Filtrar_datatable(Me.TX_buscar_nombre.Text)
        Else
            DataGridView1.DataSource = ds_productos.Tables(0)
        End If
    End Sub

    Private Sub TX_buscar_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_buscar_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            DataGridView1.DataSource = Nothing
            If TX_buscar_nombre.Text <> "" Then
                Filtrar_datatable(Me.TX_buscar_nombre.Text)
            Else
                DataGridView1.DataSource = ds_productos.Tables(0)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        If TX_buscar_codigo.Text <> "" Then
            Filtrar_datatable2(Me.TX_buscar_codigo.Text)
        Else
            DataGridView1.DataSource = ds_productos.Tables(0)
        End If
    End Sub

    Private Sub TX_buscar_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_buscar_codigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            DataGridView1.DataSource = Nothing
            If TX_buscar_codigo.Text <> "" Then
                Filtrar_datatable2(Me.TX_buscar_codigo.Text)
            Else
                DataGridView1.DataSource = ds_productos.Tables(0)
            End If
        End If
    End Sub

    Public Sub Filtrar_datatable(ByVal parametro As String)
        If ds_productos.Tables.Count <> 0 Then
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("PROD_id")
            table_filtrada.Columns.Add("PROD_codigo")
            table_filtrada.Columns.Add("PROD_nombre")
            table_filtrada.Columns.Add("PROD_T_nom")
            table_filtrada.Columns.Add("PROD_condi_alm")
            table_filtrada.Columns.Add("PROD_cant_total")
            table_filtrada.Columns.Add("Marca_nom")
            table_filtrada.Columns.Add("PROD_estado")
            table_filtrada.Columns.Add("PROD_iva")
            table_filtrada.Columns.Add("PROD_totalU_iva")
            table_filtrada.Columns.Add("PROD_total_iva")
            table_filtrada.Rows.Clear()
            DataGridView1.DataSource = Nothing
            Dim table As DataTable = ds_productos.Tables(0)
            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("PROD_nombre")
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
                DataGridView1.DataSource = table_filtrada
            Else
                DataGridView1.DataSource = ds_productos.Tables(0)
            End If
        End If
    End Sub

    Public Sub Filtrar_datatable2(ByVal parametro As String)
        If ds_productos.Tables.Count <> 0 Then
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("PROD_id")
            table_filtrada.Columns.Add("PROD_codigo")
            table_filtrada.Columns.Add("PROD_nombre")
            table_filtrada.Columns.Add("PROD_T_nom")
            table_filtrada.Columns.Add("PROD_condi_alm")
            table_filtrada.Columns.Add("PROD_cant_total")
            table_filtrada.Columns.Add("Marca_nom")
            table_filtrada.Columns.Add("PROD_estado")
            table_filtrada.Columns.Add("PROD_iva")
            table_filtrada.Columns.Add("PROD_totalU_iva")
            table_filtrada.Columns.Add("PROD_total_iva")
            table_filtrada.Rows.Clear()
            DataGridView1.DataSource = Nothing
            Dim table As DataTable = ds_productos.Tables(0)
            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("PROD_codigo")
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
                DataGridView1.DataSource = table_filtrada
            Else
                DataGridView1.DataSource = ds_productos.Tables(0)
            End If
        End If
    End Sub




    
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Mostrar_detalle_combo()
    End Sub



    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Mostrar_detalle_combo()
    End Sub


    Private Sub Mostrar_detalle_combo()


        If DataGridView1.Rows.Count <> 0 Then

            Lb_nombre.Text = DataGridView1.CurrentRow.Cells("PRODnombreDataGridViewTextBoxColumn").Value
            lb_código.Text = DataGridView1.CurrentRow.Cells("PRODcodigoDataGridViewTextBoxColumn").Value
            Lb_cantidadtotal.Text = DataGridView1.CurrentRow.Cells("PRODcanttotalDataGridViewTextBoxColumn").Value
            Lb_presentacion.Text = DataGridView1.CurrentRow.Cells("PROD_presentacion").Value




            Dim ds_lote As DataSet = DArecepcion.Recepcion_buscar_lotes(DataGridView1.CurrentRow.Cells(0).Value)

            DataGridView2.DataSource = ds_lote.Tables(0)

        Else
            DataGridView1.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub





    Private Sub limpiar_detalle()
        Lb_nombre.Text = "................................................"
        lb_código.Text = "0000"
        Lb_cantidadtotal.Text = "0"
        Lb_presentacion.Text = "..............................................................."
    End Sub



    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim cell As DataGridViewCell = DataGridView2.CurrentCell
        If Not (TypeOf cell Is DataGridViewButtonCell) Then Return
        Dim ds_recepcion As DataSet = DArecepcion.Recepcion_informe_detallado(DataGridView2.CurrentRow.Cells("PRODDETcodigorecepcionDataGridViewTextBoxColumn").Value)
        ' Dim ds_cliente As DataSet = DAcliente.Informe_Cliente
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Informe Regional\CR_recepcion_detalle.rpt")
        CrReport.Database.Tables("Recepcion").SetDataSource(ds_recepcion.Tables(0))
        'CrReport.SetDataSource(ds_Jugador.Tables(0))
        Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
        'ERROR_Socio.Visible = False
        Informe_Mostrar.Show()
    End Sub
End Class