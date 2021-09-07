Public Class VentaRegiona_busqueda
    Dim DAventaregional As New Datos.Venta_regional


    Private Sub VentaRegiona_busqueda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'OBTENGO LOS PRODUCTOS Q ESTAN EN STOCK
        Obtener_productos_stock()
    End Sub

    Dim ds_stock As DataSet
    Dim lote_ok = "no"
    Dim prod_id
    Dim nro_lote
    Private Sub Obtener_productos_stock()
        ds_stock = DAventaregional.Venta_obtener_productos_en_stock()
        '  dataset_egresos.Tables(0).Merge(dataset_egresos.Tables(1)
        DataGridView1.DataSource = ds_stock.Tables(0)

    End Sub


#Region "SELECCION DE PRODUCTOS EN GRILLA"

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Label_codinterno.Text = " "
        txt_precio.Text = "00,00"
        txt_cantidad.Text = "1"
        Label_preciototal.Text = "00,00"

        If e.ColumnIndex <> 1 Then Exit Sub
        'primero quito la seleccion de los demas
        Dim i = 0
        While i < DataGridView1.Rows.Count
            DataGridView1.Rows(i).Cells(1).Value = False
            i = i + 1
        End While

        If e.RowIndex >= 0 Then


            If DataGridView1.Rows(e.RowIndex).Cells(1).Value = True Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = False
            Else
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = True 'lo selecciono
                'paso los datos del producto abajo...
                Label_codinterno.Text = DataGridView1.Rows(e.RowIndex).Cells("PRODcodigoDataGridViewTextBoxColumn").Value
                txt_precio.Text = CDec(DataGridView1.Rows(e.RowIndex).Cells("PRODprecioUvtaDataGridViewTextBoxColumn").Value)
                txt_cantidad.Text = CInt("1")
                Label_preciototal.Text = CDec(txt_precio.Text) * CInt(txt_cantidad.Text)



            End If
        End If

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Label_codinterno.Text = " "
        txt_precio.Text = "00,00"
        txt_cantidad.Text = "1"
        Label_preciototal.Text = "00,00"

        'primero quito la seleccion de los demas
        Dim i = 0
        While i < DataGridView1.Rows.Count
            DataGridView1.Rows(i).Cells(1).Value = False
            i = i + 1
        End While

        If e.RowIndex >= 0 Then
            If DataGridView1.Rows(e.RowIndex).Cells(1).Value = True Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = False
            Else
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = True
                Label_codinterno.Text = DataGridView1.Rows(e.RowIndex).Cells("PRODcodigoDataGridViewTextBoxColumn").Value
                txt_precio.Text = CDec(DataGridView1.Rows(e.RowIndex).Cells("PRODprecioUvtaDataGridViewTextBoxColumn").Value)
                txt_cantidad.Text = CInt("1")
                Label_preciototal.Text = CDec(txt_precio.Text) * CInt(txt_cantidad.Text)
            End If
        End If
    End Sub


    Private Sub txt_precio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_precio.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                calcular_total_prod_seleccionado()
        End Select
    End Sub

    Private Sub txt_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.txt_precio.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_precio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_precio.LostFocus
        calcular_total_prod_seleccionado()
    End Sub

    Private Sub calcular_total_prod_seleccionado()
        'cuando modifico la cantidad del producto seleccionado, realizo el calculo para obtener total
        If txt_cantidad.Text <> "" Then
            If txt_cantidad.Text = "0" Then
                txt_cantidad.Text = "1"
            End If
            Dim total As Decimal = 0
            total = CInt(txt_cantidad.Text) * CDec(txt_precio.Text)
            Label_preciototal.Text = CDec(Math.Round(total, 2)).ToString("N2")
            'TX_LISTA_PROD_total.Text = Format(TX_LISTA_PROD_total.Text, "##,##0,00")
        Else
            If txt_cantidad.Text = "" Then
                txt_cantidad.Text = "1"
            End If
            If txt_precio.Text = "" Then
                txt_precio.Text = "00,00"
            End If

            Dim total As Decimal = 0
            total = CInt(txt_cantidad.Text) * CDec(txt_precio.Text)
            Label_preciototal.Text = CDec(Math.Round(total, 2)).ToString("N2")
        End If
    End Sub

    Private Sub txt_cantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cantidad.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                calcular_total_prod_seleccionado()
        End Select
    End Sub

    Private Sub txt_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                    e.Handled = True
                End If
            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_cantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cantidad.LostFocus
        calcular_total_prod_seleccionado()
    End Sub

#End Region


#Region "busqueda de productos con textbox"

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        DataGridView1.DataSource = Nothing
        If tx_Buscar.Text <> "" Then
            Filtrar_datatable(Me.tx_Buscar.Text)
        Else
            DataGridView1.DataSource = ds_stock.Tables(0)
        End If
    End Sub

    Private Sub Filtrar_datatable(ByVal parametro As String)
        If ds_stock.Tables.Count <> 0 Then
            ''uso ds_stock que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("PROD_id")
            table_filtrada.Columns.Add("PROD_codigo")
            table_filtrada.Columns.Add("PROD_nombre")
            table_filtrada.Columns.Add("PROD_T_id")
            table_filtrada.Columns.Add("PROD_condi_alm")
            table_filtrada.Columns.Add("PROD_cant_total")
            table_filtrada.Columns.Add("Marca_id")
            table_filtrada.Columns.Add("Marca_nom")
            table_filtrada.Columns.Add("PROD_estado")
            table_filtrada.Columns.Add("PROD_precioU_vta")
            table_filtrada.Columns.Add("PROD_iva")
            table_filtrada.Columns.Add("PROD_totalU_iva")
            table_filtrada.Columns.Add("PROD_total_iva")
            table_filtrada.Columns.Add("PRODDET_nrolote")

            DataGridView1.DataSource = Nothing

            Dim table As DataTable = ds_stock.Tables(0)

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

                'Dim fila2 As String = table.Rows(a).Item("CLI_dni")
                'fila2 = fila2.ToLower()
                'parametro = parametro.ToLower()
                'Dim primercaracter2 As Integer = fila2.IndexOf(parametro)
                'If primercaracter2 <> -1 Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If

                'If apellido = table.Rows(a).Item("CLI_ape") Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If
                a = a + 1
            End While

            If table_filtrada.Rows.Count <> 0 Then
                DataGridView1.DataSource = table_filtrada
            Else
                DataGridView1.DataSource = ds_stock.Tables(0)
            End If
        End If
    End Sub
#End Region


    Private Sub BO_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_salir.Click
        Me.Close()
    End Sub

    Private Sub Verificar_Lote()

        Dim ds_lotes As DataSet = DAventaregional.Venta_obtener_lotes_de_producto(prod_id)
        Dim msj = ""

        Dim j As Integer = 0
        While j < ds_lotes.Tables(0).Rows.Count <> 0
            If tb_nrolote.Text = ds_lotes.Tables(0).Rows(j).Item("PRODDET_nrolote") Then
                If txt_cantidad.Text <= CInt(ds_lotes.Tables(0).Rows(j).Item("PRODDET_cantidad")) Then
                    lote_ok = "si"
                    msj = ""
                    Exit While
                Else
                    msj = "Cant"
                    Exit While
                End If

            Else
                msj = "lote"
            End If
            j = j + 1
        End While

        If msj = "Cant" Then
            MsgBox("La cantidad ingresada supera la cantidad del lote", MsgBoxStyle.Information)
        Else
            If msj = "lote" Then
                MsgBox("No se Encuentra el Lote ingresado", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub BO_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_agregar.Click


        Dim valido As String = "no"
        'obtengo el index de la fila seleccionada
        Dim i As Integer = 0
        Dim indice As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells(1).Value = True Then
                indice = i
                valido = "si"
                i = Me.DataGridView1.Rows.Count
            End If
            i = i + 1
        End While

        If valido = "si" Then

            prod_id = CInt(DataGridView1.Rows(indice).Cells("PRODidDataGridViewTextBoxColumn").Value)
            
            If CInt(txt_cantidad.Text) > CInt(DataGridView1.Rows(indice).Cells("PRODcanttotalDataGridViewTextBoxColumn").Value) Then
                valido = "no"
            End If
            


            If valido = "si" Then

                'If tb_nrolote.Text <> "" Then
                'Verificar_Lote()
                'If lote_ok = "si" Then


                'primero verifico que el producto q ingreso no este ya en la grilla
                Dim item = 0
                Dim presente = "no"
                Dim fila_editar = 0
                While item < VentaRegional_nuevodiseño.DG_PRODAGREGADOS.Rows.Count
                    If VentaRegional_nuevodiseño.DG_PRODAGREGADOS.Rows(item).Cells("Venta_Lote").Value.ToString = DataGridView1.Rows(indice).Cells("PRODDET_nroloteDataGridViewTextBoxColumn").Value.ToString Then
                        presente = "si"
                        fila_editar = item
                    End If
                    item = item + 1
                End While
                'ahora veo de agregar o editar
                If presente = "no" Then
                    'agrego una nueva fila
                    Dim newCustomersRow As DataRow = VentaRegional_nuevodiseño.DS_venta_regional.Tables("Productos_agregados").NewRow()
                    newCustomersRow("PROD_id") = DataGridView1.Rows(indice).Cells(0).Value.ToString
                    newCustomersRow("PROD_codigo") = DataGridView1.Rows(indice).Cells(2).Value.ToString
                    newCustomersRow("PROD_nombre") = DataGridView1.Rows(indice).Cells(3).Value.ToString
                    newCustomersRow("cantidad") = CInt(txt_cantidad.Text)
                    newCustomersRow("PROD_precioU") = CInt(txt_precio.Text)
                    newCustomersRow("subtotal") = CDec(Label_preciototal.Text).ToString("N2")
                    newCustomersRow("Marca_nom") = DataGridView1.Rows(indice).Cells("MarcanomDataGridViewTextBoxColumn").Value.ToString
                    newCustomersRow("Venta_Lote") = DataGridView1.Rows(indice).Cells("PRODDET_nroloteDataGridViewTextBoxColumn").Value.ToString
                    VentaRegional_nuevodiseño.DS_venta_regional.Tables("Productos_agregados").Rows.Add(newCustomersRow)
                    VentaRegional_nuevodiseño.DG_PRODAGREGADOS.DataSource = VentaRegional_nuevodiseño.DS_venta_regional.Tables("Productos_agregados")
                    Me.txt_cantidad.Text = 1
                    Me.tb_nrolote.Text = ""
                    Me.txt_precio.Text = "0,00"
                    Obtener_productos_stock()
                    MessageBox.Show("Producto agregado correctamente.", "Sistema de Gestion.")

                Else
                    'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                    Dim result As DialogResult
                    result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                    If result = DialogResult.OK Then

                        VentaRegional_nuevodiseño.DG_PRODAGREGADOS.Rows(fila_editar).Cells("PRODprecioUDataGridViewTextBoxColumn").Value = CDec(txt_precio.Text)
                        VentaRegional_nuevodiseño.DG_PRODAGREGADOS.Rows(fila_editar).Cells("CantidadDataGridViewTextBoxColumn").Value = CInt(txt_cantidad.Text)
                        VentaRegional_nuevodiseño.DG_PRODAGREGADOS.Rows(fila_editar).Cells("SubtotalDataGridViewTextBoxColumn").Value = CDec(Label_preciototal.Text)

                        Me.txt_cantidad.Text = 1
                        Me.tb_nrolote.Text = ""
                        Me.txt_precio.Text = "0,00"
                        Obtener_productos_stock()
                        MessageBox.Show("Producto agregado correctamente.", "Sistema de Gestion.")
                    End If
                End If

                VentaRegional_nuevodiseño.calcular_totales()
                'Else

                'End If
                'Else

                '    MsgBox("Error, Debe Ingresar el Numero de Lote", MsgBoxStyle.Information)
                '    Me.tb_nrolote.Focus()
                '    Me.tb_nrolote.SelectAll()
                'End If


            Else
                MsgBox("Error, modifique la cantidad", MsgBoxStyle.Information)
                Me.txt_cantidad.Focus()
                Me.txt_cantidad.SelectAll()

            End If


        Else
            MsgBox("Seleccione producto", MsgBoxStyle.Information)
        End If

    End Sub



End Class