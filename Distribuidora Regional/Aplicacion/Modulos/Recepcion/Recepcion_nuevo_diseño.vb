Public Class Recepcion_nuevo_diseño

    Dim DAproveedores As New Datos.Proveedor
    Dim DArecepcion As New Datos.Recepcion
    Dim DAmarca As New Datos.Marca
    Dim operacion As String = ""
    Dim DAventaregional As New Datos.Venta_regional
    Dim ds_lotes As DataSet
    Dim bandera = 0


#Region "CARGA DE COMBOS AL INICIO DEL FORM"
    Public Sub Generar_cod_interno()

        Dim ds_generar As DataSet = DArecepcion.Recepcion_Obtener_Codigo()
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            lb_codigo.Text = ds_generar.Tables(0).Rows.Count + 1
        Else
            lb_codigo.Text = "1"
            'tx_codproducto.Text = "100"
        End If



        ''obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        'Dim ds_generar As DataSet = DArecepcion.Producto_obtener_todo()
        'If ds_generar.Tables(0).Rows.Count <> 0 Then
        '    lb_codigo.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count).Item("PRODDET_codigorecepcion")
        '    'tx_codproducto.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("RECEPCION_codigoproducto") + 1
        'Else
        '    lb_codigo.Text = "1"
        '    'tx_codproducto.Text = "100"
        'End If
    End Sub
    Dim ds_proveedor As New DataSet
    Public Sub Cargarcombo_proveedor()
        ds_proveedor = DAproveedores.Proveedor_obtener
        'Cargar Proveedor
        cb_proveedores.DataSource = ds_proveedor.Tables(0)
        cb_proveedores.DisplayMember = "Prov_nombre"
        cb_proveedores.ValueMember = "Prov_id"
        cb_proveedores.SelectedValue = ds_proveedor.Tables(0).Rows(0).Item("Prov_id")
    End Sub
    Dim ds_marca As New DataSet
    Public Sub Cargarcombo_marca()
        'Cargar la Marca
        ds_marca = DAmarca.Marca_obtener
        cb_marca.DataSource = ds_marca.Tables(0)
        cb_marca.DisplayMember = "Marca_nom"
        cb_marca.ValueMember = "Marca_id"
        cb_marca.SelectedValue = ds_marca.Tables(0).Rows(0).Item("Marca_id")
    End Sub
    Dim ds_tipoproducto As New DataSet
    Public Sub Cargarcombo_tipoproducto()
        'Cargar la Marca
        ds_tipoproducto = DArecepcion.ProductoTipo_obtener()
        cb_tipoproducto.DataSource = ds_tipoproducto.Tables(0)
        cb_tipoproducto.DisplayMember = "PROD_T_nom"
        cb_tipoproducto.ValueMember = "PROD_T_id"
        cb_tipoproducto.SelectedValue = ds_tipoproducto.Tables(0).Rows(0).Item("PROD_T_id")
    End Sub
#End Region
    Dim ds_productos As DataSet
    Private Sub Obtener_todos_productos()
        ds_productos = DArecepcion.Recepcion_obtener_todos_productos()

        DataGridView1.DataSource = ds_productos.Tables(0)
        DataGridView1.Refresh()
    End Sub

    Private Sub Recepcion_gestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'traigo todos los productos para mostrarlos en grilla
        Obtener_todos_productos()
        Cargarcombo_proveedor()
        Cargarcombo_marca()
        Cargarcombo_tipoproducto()

        'seleccionar primer elemnto de combo iva, combo condicion de alm
        cb_condi_alm.SelectedIndex = 0
        cb_iva.SelectedIndex = 0
        cb_condi_alm.SelectedIndex = 0




    End Sub

    Private Sub Validar_producto(ByRef valida As String)

        If tx_cant.Text = "" Or tx_cant.Text = "0" Then
            tx_cant.Text = 1
        End If



        If operacion = "alta" Then
            'DATOS DEL PRODUCTO////////////////////////
            Dim CONTINUAR As String = "si"
            If tx_codproducto.Text <> "" Then
                'valido que no exista ese codigo de producto
                Dim i As Integer = 0
                While i < ds_productos.Tables(0).Rows.Count
                    If ds_productos.Tables(0).Rows(i).Item("PROD_codigo") = tx_codproducto.Text Then
                        i = ds_productos.Tables(0).Rows.Count
                        CONTINUAR = "no"
                    End If

                    i = i + 1
                End While
                If CONTINUAR = "si" Then
                    If tx_nombreproducto.Text <> "" Then
                        If tx_nrolote.Text <> "" Then
                            If tx_nrofactura.Text <> "" Then
                                If tx_cant.Text <> "" Then
                                    If tx_precioU.Text <> "" Then
                                        'vuelvo a calcular x las dudas el precio total
                                        tx_precio_total.Text = CInt(tx_cant.Text) * CDec(tx_precioU.Text)

                                        If tx_precioU_vta.Text <> "" Then
                                            '////////////////////////////////
                                            'validacion correcta correcto
                                            valida = "Si"
                                            '//////////////////////////////
                                        Else
                                            MessageBox.Show("Ingrese precio unitario en venta.", "Sistema de Gestion.")
                                            tx_precioU_vta.Clear()
                                            tx_precioU_vta.Focus()
                                            tx_precioU_vta.SelectAll()
                                            CONTINUAR = "no"
                                        End If
                                    Else
                                        MessageBox.Show("Ingrese precio unitario en compra.", "Sistema de Gestion.")
                                        tx_precioU.Clear()
                                        tx_precioU.Focus()
                                        tx_precioU.SelectAll()
                                        CONTINUAR = "no"
                                    End If
                                Else
                                    MessageBox.Show("Ingrese cantidad.", "Sistema de Gestion.")
                                    tx_cant.Clear()
                                    tx_cant.Focus()
                                    tx_cant.SelectAll()
                                    CONTINUAR = "no"
                                End If
                            Else
                                MessageBox.Show("Ingrese número de factura.", "Sistema de Gestion.")
                                tx_nrofactura.Clear()
                                tx_nrofactura.Focus()
                                tx_nrofactura.SelectAll()
                                CONTINUAR = "no"
                            End If
                        Else
                            MessageBox.Show("Ingrese número de lote.", "Sistema de Gestion.")
                            tx_nrolote.Clear()
                            tx_nrolote.Focus()
                            tx_nrolote.SelectAll()
                            CONTINUAR = "no"
                        End If
                    Else
                        MessageBox.Show("Ingrese nombre del producto.", "Sistema de Gestion.")
                        tx_nombreproducto.Clear()
                        tx_nombreproducto.Focus()
                        tx_nombreproducto.SelectAll()
                        CONTINUAR = "no"
                    End If
                Else
                    MessageBox.Show("Ingrese código del producto. El código ya existe", "Sistema de Gestion.")
                    tx_codproducto.Clear()
                    tx_codproducto.Focus()
                    tx_codproducto.SelectAll()
                    CONTINUAR = "no"
                End If
            Else
                MessageBox.Show("Ingrese código del producto", "Sistema de Gestion.")
                CONTINUAR = "no"
            End If
        Else
            'igual q el de arriba, solo q no valida el ingreso del cod producto
            'DATOS DEL PRODUCTO////////////////////////

            Dim CONTINUAR As String = "si"
            If tx_nombreproducto.Text <> "" Then
                If tx_nrolote.Text <> "" Or ComboBox_lote.Visible = True Then
                    If tx_nrofactura.Text <> "" Then
                        If tx_cant.Text <> "" Then
                            If tx_precioU.Text <> "" Then
                                'vuelvo a calcular x las dudas el precio total
                                tx_precio_total.Text = CInt(tx_cant.Text) * CDec(tx_precioU.Text)

                                If tx_precioU_vta.Text <> "" Then
                                    '////////////////////////////////
                                    'validacion correcta correcto
                                    valida = "Si"
                                    '//////////////////////////////
                                Else
                                    MessageBox.Show("Ingrese precio unitario en venta.", "Sistema de Gestion.")
                                    tx_precioU_vta.Clear()
                                    tx_precioU_vta.Focus()
                                    tx_precioU_vta.SelectAll()
                                    CONTINUAR = "no"
                                End If
                            Else
                                MessageBox.Show("Ingrese precio unitario en compra.", "Sistema de Gestion.")
                                tx_precioU.Clear()
                                tx_precioU.Focus()
                                tx_precioU.SelectAll()
                                CONTINUAR = "no"
                            End If
                        Else
                            MessageBox.Show("Ingrese cantidad.", "Sistema de Gestion.")
                            tx_cant.Clear()
                            tx_cant.Focus()
                            tx_cant.SelectAll()
                            CONTINUAR = "no"
                        End If
                    Else
                        MessageBox.Show("Ingrese número de factura.", "Sistema de Gestion.")
                        tx_nrofactura.Clear()
                        tx_nrofactura.Focus()
                        tx_nrofactura.SelectAll()
                        CONTINUAR = "no"
                    End If
                Else

                    MessageBox.Show("Ingrese número de lote.", "Sistema de Gestion.")
                    tx_nrolote.Clear()
                    tx_nrolote.Focus()
                    tx_nrolote.SelectAll()
                    CONTINUAR = "no"


                End If
            Else
                MessageBox.Show("Ingrese nombre del producto.", "Sistema de Gestion.")
                tx_nombreproducto.Clear()
                tx_nombreproducto.Focus()
                tx_nombreproducto.SelectAll()
                CONTINUAR = "no"
            End If
        End If
    End Sub

    Public Sub Obtener_lote_producto(ByVal codprod As String)
        ds_lotes = DAventaregional.Venta_obtener_lotes_de_producto(codprod)
        ComboBox_lote.DataSource = ds_lotes.Tables(0)
        ComboBox_lote.DisplayMember = "PRODDET_nrolote"
        ComboBox_lote.ValueMember = "PRODDET_id"
        ComboBox_lote.SelectedValue = ds_lotes.Tables(0).Rows(0).Item("PRODDET_id")
        tb_Cant_lote.Text = ds_lotes.Tables(0).Rows(0).Item("PRODDET_cantidad")
        bandera = 1

      

    End Sub
    Private Sub limpiar_deshabilitar()
        'aqui limpiamos los textbox una vez q guardo, o bien si cancelo la registracion en curso
        tx_codproducto.Clear()
        tx_nombreproducto.Clear()
        tx_nrolote.Clear()
        tx_cantidad.Text = "1"
        tx_nrofactura.Clear()

    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        limpiar_deshabilitar()
        Generar_cod_interno()
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Enabled = False 'deshabilito el group box de la pestaña 1
        TabControl1.SelectedTab = TabPage2 'paso a la pestaña 2
        limpiar_box_pestaña2()
        Generar_cod_interno()
        Panel_pestaña2.Enabled = True 'habilito el panel principal, donde estan todos los componentes de la pestaña 2
        operacion = "alta"
        tx_codproducto.Focus()
        tx_codproducto.ReadOnly = False
        ComboBox_lote.Visible = False
        tx_nrolote.Visible = True
    End Sub

    Private Sub limpiar_box_pestaña2()
        DT_fechasistema.Value = Today
        lb_codigo.Text = "0000"

        'group box datos del producto
        tx_codproducto.Clear()
        tx_nombreproducto.Clear()
        tx_presentacion.Text = ""
        tx_cantidad.Text = CInt(0) 'cantidad total

        'group box detalles del producto
        tx_nrolote.Clear()
        tx_nrofactura.Clear()
        DT_fechafactura.Value = Today
        DT_fechavencimiento.Value = Today

        'group box precio de compra
        tx_cant.Text = "0"
        tx_precioU.Clear()
        tx_precio_total.Clear()

        'group box precio de venta
        tx_precioU_vta.Clear()

    End Sub

    Private Sub BO_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        TabControl1.SelectedTab = TabPage1
        limpiar_box_pestaña2()
        GroupBox1.Enabled = True
        operacion = ""
        Panel_pestaña2.Enabled = False  'deshabilito el panel principal, donde estan todos los componentes de la pestaña 2
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
    'boton buscar x nombre
    Private Sub BO_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ape.Click
        DataGridView1.DataSource = Nothing
        If TX_buscar_nombre.Text <> "" Then
            Filtrar_datatable(Me.TX_buscar_nombre.Text)
        Else
            DataGridView1.DataSource = ds_productos.Tables(0)
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        If TX_buscar_codigo.Text <> "" Then
            Filtrar_datatable2(Me.TX_buscar_codigo.Text)
        Else
            DataGridView1.DataSource = ds_productos.Tables(0)
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
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
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = True
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
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
            End If
        End If
    End Sub


    
    Private Sub BO_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_registrar.Click


        '//////////////////ALT DE NUEVO PRODUCTO//////////////////////////////
        If operacion = "alta" Then
            Dim valida As String = "No"
            Validar_producto(valida)
            If valida = "Si" Then
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea registrar la nueva recepción?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    'Producto alta
                    Dim ds_recep As DataSet
                    ds_recep = DArecepcion.Producto_alta(tx_codproducto.Text, tx_nombreproducto.Text, cb_tipoproducto.SelectedValue,
                                              cb_condi_alm.SelectedItem, tx_cantidad.Text, cb_marca.SelectedValue, "Stock",
                                              CDec(tx_precioU_vta.Text), cb_iva.SelectedItem, tx_precioU.Text, tx_precio_total.Text, tx_presentacion.Text)
                    Dim PROD_id As Integer = ds_recep.Tables(0).Rows(0).Item(0)
                    'Producto_Detalle Alta y alta de recepcion, todo en el mismo procedimiento
                    Dim Lote As String
                    If ComboBox_lote.Visible = True Then
                        Lote = ComboBox_lote.SelectedText
                    Else
                        Lote = tx_nrolote.Text
                    End If
                    DArecepcion.ProdDet_alta(lb_codigo.Text, PROD_id, DT_fechasistema.Value, Lote, tx_cant.Text, DT_fechavencimiento.Value, tx_nrofactura.Text, DT_fechafactura.Value, cb_proveedores.SelectedValue, tx_codproducto.Text, tx_nombreproducto.Text, "Stock")
                    DArecepcion.Recepcion_alta(lb_codigo.Text, tx_codproducto.Text, tx_nombreproducto.Text, tx_nrolote.Text, DT_fechasistema.Value, tx_cant.Text, DT_fechavencimiento.Value, tx_nrofactura.Text, DT_fechafactura.Value, tx_precioU.Text, cb_proveedores.SelectedValue, tx_presentacion.Text)
                    Obtener_todos_productos()
                    MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")
                    'TENGO Q USAR LO DEL BOTON, CANCELAR ////////////////////////
                    TabControl1.SelectedTab = TabPage1
                    limpiar_box_pestaña2()
                    GroupBox1.Enabled = True
                    operacion = ""
                    Panel_pestaña2.Enabled = False  'deshabilito el panel principal, donde estan todos los componentes de la pestaña 2
                    '///////////////////////////////////////////////////////////
                End If
            End If
        End If

        If operacion = "modificar" Then
            Dim valida As String = "No"
            Validar_producto(valida)
            If valida = "Si" Then
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea registrar la nueva recepción?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    'Producto modificar
                    Dim ds_recep As DataSet
                    ds_recep = DArecepcion.Producto_modificar(tx_codproducto.Text, tx_nombreproducto.Text, cb_tipoproducto.SelectedValue,
                                              cb_condi_alm.SelectedItem, tx_cantidad.Text, cb_marca.SelectedValue, "Stock",
                                              CDec(tx_precioU_vta.Text), cb_iva.SelectedItem, tx_precioU.Text, tx_precio_total.Text, tx_presentacion.Text)
                    Dim PROD_id As Integer = ds_recep.Tables(0).Rows(0).Item(0)
                    'Producto_Detalle Alta y alta de recepcion, todo en el mismo procedimiento

                    'esto es solo para modificar la cantidad de un lote existente
                    If ComboBox_lote.Visible = True Then
                        Dim cantNueva = CInt(tb_Cant_lote.Text) + CInt(tx_cant.Text)
                        DArecepcion.ProdDetalle_modificar_Cantlote(cantNueva, PROD_id, ComboBox_lote.Text)
                        ''''''''''''''''''''''''''''''''''''''''''
                    Else
                        DArecepcion.ProdDet_alta(lb_codigo.Text, PROD_id, DT_fechasistema.Value, tx_nrolote.Text, tx_cant.Text, DT_fechavencimiento.Value, tx_nrofactura.Text, DT_fechafactura.Value, cb_proveedores.SelectedValue, tx_codproducto.Text, tx_nombreproducto.Text, "Stock")
                    End If

                    DArecepcion.Recepcion_alta(lb_codigo.Text, tx_codproducto.Text, tx_nombreproducto.Text, tx_nrolote.Text, DT_fechasistema.Value, tx_cant.Text, DT_fechavencimiento.Value, tx_nrofactura.Text, DT_fechafactura.Value, tx_precioU.Text, cb_proveedores.SelectedValue, tx_presentacion.Text)
                    Obtener_todos_productos()
                    MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")
                    'TENGO Q USAR LO DEL BOTON, CANCELAR ////////////////////////
                    TabControl1.SelectedTab = TabPage1
                    limpiar_box_pestaña2()
                    GroupBox1.Enabled = True
                    operacion = ""
                    Panel_pestaña2.Enabled = False  'deshabilito el panel principal, donde estan todos los componentes de la pestaña 2
                    '///////////////////////////////////////////////////////////
                End If
            End If
        End If

    End Sub

    Private Sub tx_cant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_cant.KeyPress
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


        If operacion = "alta" Then
            If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
                tx_cantidad.Text = CInt(tx_cant.Text)
            End If
        End If
        If operacion = "modificar" Then
            If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
                tx_cantidad.Text = CInt(tx_cant.Text) + cantidad_total
            End If
        End If
    End Sub

    Private Sub tx_precioU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_precioU.KeyPress
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
                If e.KeyChar = "," And Not Me.tx_precioU.Text.IndexOf(",") Then
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


        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            tx_precio_total.Text = CInt(tx_cant.Text) * CDec(tx_precioU.Text)
        End If
    End Sub

    Dim cantidad_total As Decimal = CDec(0)
    Private Sub BO_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cargar.Click
        ComboBox_lote.Visible = True
        tx_nrolote.Visible = False
        Dim PROD_id As Integer = 0
        Dim aa As Integer = 0
        While aa < DataGridView1.Rows.Count
            If DataGridView1.Rows(aa).Cells(1).Value = True Then
                PROD_id = DataGridView1.Rows(aa).Cells(0).Value
            End If
            aa = aa + 1
        End While

        If PROD_id <> 0 Then

            Dim ds_prod_selec As DataSet = DArecepcion.Recepcion_buscar_productos_seleccionado(PROD_id)


            limpiar_box_pestaña2()
            Generar_cod_interno()
            'ahora paso los datos recuperados a los controles de la pestaña 2...solo los q van en los group box: "Datos del producto" , "Precio de compra" y "Precio de venta".
            'group box datos del producto
            tx_codproducto.Text = ds_prod_selec.Tables(0).Rows(0).Item("PROD_codigo").ToString
            tx_nombreproducto.Text = ds_prod_selec.Tables(0).Rows(0).Item("PROD_nombre").ToString
            cb_tipoproducto.SelectedValue = ds_prod_selec.Tables(0).Rows(0).Item("PROD_T_id")
            If ds_prod_selec.Tables(0).Rows(0).Item("PROD_condi_alm").ToString = "Ambiente" Then
                cb_condi_alm.SelectedIndex = 0
            End If
            If ds_prod_selec.Tables(0).Rows(0).Item("PROD_condi_alm").ToString = "Heladera" Then
                cb_condi_alm.SelectedIndex = 1
            Else
                cb_condi_alm.SelectedIndex = 2
            End If
            tx_cantidad.Text = ds_prod_selec.Tables(0).Rows(0).Item("PROD_cant_total") 'cantidad total
            cantidad_total = ds_prod_selec.Tables(0).Rows(0).Item("PROD_cant_total") 'cantidad total, aqui lo guardo en esa variable ya que me sirve para el keypress de cant del lote
            cb_marca.SelectedValue = ds_prod_selec.Tables(0).Rows(0).Item("Marca_id")
            'group box precio de compra
            tx_precioU.Text = CDec(ds_prod_selec.Tables(0).Rows(0).Item("PROD_totalU_iva"))
            If ds_prod_selec.Tables(0).Rows(0).Item("PROD_iva").ToString = "21.00" Then
                cb_iva.SelectedIndex = 1
            Else
                cb_iva.SelectedIndex = 0
            End If
            'group box precio de venta
            tx_precioU_vta.Text = CDec(ds_prod_selec.Tables(0).Rows(0).Item("PROD_precioU_vta"))
            tx_presentacion.Text = CStr(ds_prod_selec.Tables(0).Rows(0).Item("PROD_presentacion"))
            GroupBox1.Enabled = False 'deshabilito el group box de la pestaña 1
            TabControl1.SelectedTab = TabPage2 'paso a la pestaña 2
            Panel_pestaña2.Enabled = True 'habilito el panel principal, donde estan todos los componentes de la pestaña 2
            operacion = "modificar"

            tx_codproducto.ReadOnly = True

            Obtener_lote_producto(PROD_id)


        Else
            MessageBox.Show("Seleccione un producto para agregar stock.", "Sistema de Gestión.")
        End If
    End Sub

    Private Sub tx_precioU_vta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_precioU_vta.KeyPress
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
                If e.KeyChar = "," And Not Me.tx_precioU_vta.Text.IndexOf(",") Then
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

    Private Sub tx_cant_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_cant.LostFocus
        If operacion = "alta" And tx_cant.Text <> "" Then

            tx_cantidad.Text = CInt(tx_cant.Text)

        End If
        If operacion = "modificar" And tx_cant.Text <> "" Then

            tx_cantidad.Text = CInt(tx_cant.Text) + cantidad_total

        End If
    End Sub

    Private Sub tx_precioU_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_precioU.LostFocus
        If tx_precioU.Text = "" Then
            tx_precioU.Text = CDec(0)
        End If
        If tx_cant.Text = "" Then
            tx_cant.Text = CInt(0)
        End If

        tx_precio_total.Text = CInt(tx_cant.Text) * CDec(tx_precioU.Text)

    End Sub

    Private Sub btn_marca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_marca.Click
        Marca_gestion.Show()
    End Sub

    Private Sub Bo_agregarcat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_agregarcat.Click
        Proveedor_modificar.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox_lote.Visible = False
        tx_nrolote.Visible = True
        tb_Cant_lote.Text = 0


    End Sub

    Private Sub ComboBox_lote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_lote.SelectedIndexChanged

        If bandera = 1 Then


            Dim i = 0
            While i < ds_lotes.Tables(0).Rows.Count
                If ComboBox_lote.SelectedValue = ds_lotes.Tables(0).Rows(i).Item("PRODDET_id") Then
                    tb_Cant_lote.Text = ds_lotes.Tables(0).Rows(i).Item("PRODDET_cantidad")
                End If
                i = i + 1
            End While

        End If
    End Sub


End Class