Public Class Busqueda_Productos

    Dim DAlista As New Datos.Lista
    Dim DAVentas As New Datos.Venta

    Dim ds_PROD As DataSet
    Dim rb_no_combo As String = "no"
    Dim rb_si_combo As String = "no"
    Public form_procedencia As String = ""

    Public Sub Obtener_Productos_Combos()
        'esta rutina la uso para traer todos los producos...solo la usi en el caso de que en el form: VENTA_CAHA_GESTION...se seleccione
        'configurar lista = NO

        Select form_procedencia
            Case "Venta_Caja_gestion"
                If Venta_Caja_gestion.RB_Si.Checked = False Then


                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos()

                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            DataGridView1.DataSource = ds_PROD.Tables(1)
                            'DataGridView2.DataSource = ds_PROD.Tables(3)

                            'Call Formato_combos()
                            'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                            ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                            'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_cant.Text = "1"
                            'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                        Else
                            'DataGridView1.Enabled = False

                            If ds_PROD.Tables(1).Rows.Count <> 0 Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Venta_Caja_gestion.RB_No.Checked = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Venta_Caja_gestion.CB_lista.SelectedValue)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If

                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If
            Case "Mesas_gestion"

                If Mesas_gestion.RB_Si.Checked = False Then


                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos()

                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            DataGridView1.DataSource = ds_PROD.Tables(1)
                            'DataGridView2.DataSource = ds_PROD.Tables(3)

                            'Call Formato_combos()
                            'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                            ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                            'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_cant.Text = "1"
                            'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                        Else
                            'DataGridView1.Enabled = False

                            If ds_PROD.Tables(1).Rows.Count <> 0 Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Mesas_gestion.RB_No.Checked = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Mesas_gestion.CB_lista.SelectedValue)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If

                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If


            Case "Mesa_cargar"

                If Mesa_cargar.RB_Si = False Then


                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos()

                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            DataGridView1.DataSource = ds_PROD.Tables(1)
                            'DataGridView2.DataSource = ds_PROD.Tables(3)

                            'Call Formato_combos()
                            'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                            ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                            'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_cant.Text = "1"
                            'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                        Else
                            'DataGridView1.Enabled = False
                            If ds_PROD.Tables(1).Rows.Count <> 0 Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Mesa_cargar.RB_No = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Mesa_cargar.CB_lista)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If

                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If
        End Select
        
    End Sub

    Private Sub Busqueda_Productos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Productos_Combos()
    End Sub

    Private Sub BO_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_salir.Click
        Me.Close()
    End Sub

    Private Sub BO_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_agregar.Click
        Select form_procedencia
            Case "Venta_Caja_gestion"
                'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Venta_Caja_gestion.TX_busc_codinterno.Text = DataGridView1.CurrentRow.Cells(1).Value
                    Venta_Caja_gestion.TX_busc_codinterno.Focus()
                    Venta_Caja_gestion.TX_busc_codinterno.SelectAll()
                    Venta_Caja_gestion.RB_CodInterno.Checked = True

                    '    Dim i As Integer = 0
                    '    Dim encontrado As String = "No"
                    '    While i < ds_PROD.Tables(1).Rows.Count
                    '        Dim cod_interno As String = ds_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    '        If Venta_Caja_gestion.TX_busc_codinterno.Text = cod_interno Then
                    '            'primero verifico que el producto q ingreso no este ya en la grilla
                    '            Dim item = 0
                    '            Dim presente = "no"
                    '            Dim fila_editar = 0
                    '            While item < Venta_Caja_gestion.DataG_lista.Rows.Count
                    '                If Venta_Caja_gestion.DataG_lista.Rows(item).Cells(2).Value = Venta_Caja_gestion.TX_busc_codinterno.Text Then
                    '                    presente = "si"
                    '                    fila_editar = item
                    '                End If
                    '                item = item + 1
                    '            End While
                    '            'ahora veo de agregar o editar
                    '            If presente = "no" Then
                    '                'agrego una nueva fila
                    '                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                    '                newCustomersRow("PROD_id") = ds_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                    '                newCustomersRow("codinterno") = ds_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    '                newCustomersRow("descripcion") = ds_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                    '                newCustomersRow("detalle") = ds_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                    '                Dim cant As Integer = 1
                    '                newCustomersRow("cantidad") = cant
                    '                newCustomersRow("precio_unitario") = ds_PROD.Tables(1).Rows(i).Item("prod_precio_vta")

                    '                Dim total As Decimal = 0
                    '                total = cant * CDec(ds_PROD.Tables(1).Rows(i).Item("prod_precio_vta"))
                    '                newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                    '                Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                    '                Venta_Caja_gestion.DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                    '                Dim a As Integer = Venta_Caja_gestion.DataG_lista.Rows.Count
                    '                Venta_Caja_gestion.DataG_lista.Rows(a - 1).Cells(0).Value = a

                    '            Else
                    '                ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
                    '                'Dim result As DialogResult
                    '                'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                    '                'If result = DialogResult.OK Then

                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
                    '                'End If
                    '            End If

                    '            encontrado = "Si"

                    '        End If

                    '        i = i + 1
                    '    End While

                    '    If encontrado = "No" Then
                    '        MsgBox("no existe")
                    '        Venta_Caja_gestion.TX_busc_codinterno.SelectAll()
                    '    Else
                    '        Venta_Caja_gestion.tx_cantidad.Text = "1"
                    '        Venta_Caja_gestion.tx_cantidad.Focus()
                    '        Venta_Caja_gestion.tx_cantidad.SelectAll()
                    '    End If
                    'End If
                    'Venta_Caja_gestion.calcular_totales()
                End If
            Case "Mesas_gestion"
                'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Mesas_gestion.TX_busc_codinterno.Text = DataGridView1.CurrentRow.Cells(1).Value
                    Mesas_gestion.TX_busc_codinterno.Focus()
                    Mesas_gestion.TX_busc_codinterno.SelectAll()
                    Mesas_gestion.RB_CodInterno.Checked = True

                    '    Dim i As Integer = 0
                    '    Dim encontrado As String = "No"
                    '    While i < ds_PROD.Tables(1).Rows.Count
                    '        Dim cod_interno As String = ds_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    '        If Venta_Caja_gestion.TX_busc_codinterno.Text = cod_interno Then
                    '            'primero verifico que el producto q ingreso no este ya en la grilla
                    '            Dim item = 0
                    '            Dim presente = "no"
                    '            Dim fila_editar = 0
                    '            While item < Venta_Caja_gestion.DataG_lista.Rows.Count
                    '                If Venta_Caja_gestion.DataG_lista.Rows(item).Cells(2).Value = Venta_Caja_gestion.TX_busc_codinterno.Text Then
                    '                    presente = "si"
                    '                    fila_editar = item
                    '                End If
                    '                item = item + 1
                    '            End While
                    '            'ahora veo de agregar o editar
                    '            If presente = "no" Then
                    '                'agrego una nueva fila
                    '                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                    '                newCustomersRow("PROD_id") = ds_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                    '                newCustomersRow("codinterno") = ds_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    '                newCustomersRow("descripcion") = ds_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                    '                newCustomersRow("detalle") = ds_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                    '                Dim cant As Integer = 1
                    '                newCustomersRow("cantidad") = cant
                    '                newCustomersRow("precio_unitario") = ds_PROD.Tables(1).Rows(i).Item("prod_precio_vta")

                    '                Dim total As Decimal = 0
                    '                total = cant * CDec(ds_PROD.Tables(1).Rows(i).Item("prod_precio_vta"))
                    '                newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                    '                Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                    '                Venta_Caja_gestion.DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                    '                Dim a As Integer = Venta_Caja_gestion.DataG_lista.Rows.Count
                    '                Venta_Caja_gestion.DataG_lista.Rows(a - 1).Cells(0).Value = a

                    '            Else
                    '                ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
                    '                'Dim result As DialogResult
                    '                'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                    '                'If result = DialogResult.OK Then

                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
                    '                'End If
                    '            End If

                    '            encontrado = "Si"

                    '        End If

                    '        i = i + 1
                    '    End While

                    '    If encontrado = "No" Then
                    '        MsgBox("no existe")
                    '        Venta_Caja_gestion.TX_busc_codinterno.SelectAll()
                    '    Else
                    '        Venta_Caja_gestion.tx_cantidad.Text = "1"
                    '        Venta_Caja_gestion.tx_cantidad.Focus()
                    '        Venta_Caja_gestion.tx_cantidad.SelectAll()
                    '    End If
                    'End If
                    'Venta_Caja_gestion.calcular_totales()
                End If

            Case "Mesa_cargar"
                'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Mesa_cargar.TX_busc_codinterno.Text = DataGridView1.CurrentRow.Cells(1).Value
                    Mesa_cargar.TX_busc_codinterno.Focus()
                    Mesa_cargar.TX_busc_codinterno.SelectAll()
                    Mesa_cargar.RB_CodInterno.Checked = True
                End If
        End Select
    End Sub

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        DataGridView1.DataSource = Nothing
        If tx_Buscar.Text <> "" Then
            Filtrar_datatable(tx_Buscar.Text)
        Else
            Select form_procedencia
                Case "Venta_Caja_gestion"
                    If Venta_Caja_gestion.RB_No.Checked = True Then
                        DataGridView1.DataSource = ds_PROD.Tables(1)
                    Else
                        DataGridView1.DataSource = ds_PROD.Tables(0)
                    End If
                Case "Mesas_gestion"
                    If Mesas_gestion.RB_No.Checked = True Then
                        DataGridView1.DataSource = ds_PROD.Tables(1)
                    Else
                        DataGridView1.DataSource = ds_PROD.Tables(0)
                    End If

                Case "Mesa_cargar"
                    If Mesa_cargar.RB_No = True Then
                        DataGridView1.DataSource = ds_PROD.Tables(1)
                    Else
                        DataGridView1.DataSource = ds_PROD.Tables(0)
                    End If
            End Select
        End If
    End Sub

    Private Sub Filtrar_datatable(ByVal parametro As String)
        Dim T As Integer = 0
        Select Case form_procedencia
            Case "Venta_Caja_gestion"
                If Venta_Caja_gestion.RB_No.Checked = True Then
                    T = 1
                Else
                    T = 0
                End If
            Case "Mesas_gestion"
                'Dim T As Integer = 0
                If Mesas_gestion.RB_No.Checked = True Then
                    T = 1
                Else
                    T = 0
                End If
            Case "Mesa_cargar"
                'Dim T As Integer = 0
                If Mesa_cargar.RB_No = True Then
                    T = 1
                Else
                    T = 0
                End If
        End Select

        If ds_PROD.Tables(T).Rows.Count <> 0 Then
            'uso ds_PROD que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("prod_id")
            table_filtrada.Columns.Add("prod_codinterno")
            table_filtrada.Columns.Add("prod_descripcion")
            table_filtrada.Columns.Add("prod_descrilarga")
            table_filtrada.Columns.Add("prod_precio_vta")
            table_filtrada.Columns.Add("prod_stock")
            table_filtrada.Columns.Add("prod_ptorepo")
            DataGridView1.DataSource = Nothing
            Dim table As DataTable = ds_PROD.Tables(T)
            Dim nombre As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("prod_descripcion")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DataGridView1.DataSource = table_filtrada
            Else
                DataGridView1.DataSource = ds_PROD.Tables(T)
            End If
        End If
    End Sub

    Private Sub Mostrar_detalle_combo()
        Select form_procedencia
            Case "Venta_Caja_gestion"
                Lb_combo.Text = "- - - - - - - - - - - - - - - -"

                DataGridView2.DataSource = Nothing
                Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                If Venta_Caja_gestion.RB_No.Checked = True Then
                    If rb_no_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(2).Rows.Count
                                    If ds_PROD.Tables(2).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(2).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(3).Rows.Count
                                            If ds_PROD.Tables(3).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(3).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If

                If Venta_Caja_gestion.RB_Si.Checked = True Then
                    If rb_si_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(1).Rows.Count
                                    If ds_PROD.Tables(1).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(1).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(2).Rows.Count
                                            If ds_PROD.Tables(2).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(2).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If


                    End If
                End If



            Case "Mesa_cargar"
                Lb_combo.Text = "- - - - - - - - - - - - - - - -"

                DataGridView2.DataSource = Nothing
                Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                If Mesa_cargar.RB_No = True Then
                    If rb_no_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(2).Rows.Count
                                    If ds_PROD.Tables(2).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(2).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(3).Rows.Count
                                            If ds_PROD.Tables(3).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(3).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If

                If Mesa_cargar.RB_Si = True Then
                    If rb_si_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(1).Rows.Count
                                    If ds_PROD.Tables(1).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(1).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(2).Rows.Count
                                            If ds_PROD.Tables(2).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(2).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If





            Case "Mesas_gestion"
                Lb_combo.Text = "- - - - - - - - - - - - - - - -"

                DataGridView2.DataSource = Nothing
                Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                If Mesas_gestion.RB_No.Checked = True Then
                    If rb_no_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(2).Rows.Count
                                    If ds_PROD.Tables(2).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(2).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(3).Rows.Count
                                            If ds_PROD.Tables(3).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(3).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If

                If Mesas_gestion.RB_Si.Checked = True Then
                    If rb_si_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(1).Rows.Count
                                    If ds_PROD.Tables(1).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(1).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(2).Rows.Count
                                            If ds_PROD.Tables(2).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(2).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If

        End Select
    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Mostrar_detalle_combo()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Mostrar_detalle_combo()
    End Sub
End Class