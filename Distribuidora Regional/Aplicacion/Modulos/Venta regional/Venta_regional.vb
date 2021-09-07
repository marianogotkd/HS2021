Public Class Venta_regional

    Dim DAcliente As New Datos.Cliente
    Dim DAventaregional As New Datos.Venta_regional
    Dim ds_recepcion As New DataSet
    Dim CLI_id As Integer = 0
    Private Sub BO_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Aceptar.Click
        Dim valido As String = "no"

        Dim aa As Integer = 0
        While aa < DG_clientes.Rows.Count
            If DG_clientes.Rows(aa).Cells(1).Value = True Then

                CLI_id = DG_clientes.Rows(aa).Cells(0).Value
                valido = "si"
            End If
            aa = aa + 1
        End While

        If tx_nrofactura.Text = "" Then
            valido = "no tiene nro factura"
        End If


        If valido = "si" Then
            GroupBox1.Enabled = False
            BO_Guardar.Enabled = True
            BO_cancelar.Enabled = True
            BO_Quitar.Enabled = True
            BO_editar.Enabled = True

            GroupBox_busqprod.Enabled = True
            GroupBox_prodagregados.Enabled = True


            TabControl1.SelectedTab = TabPage2



            'ahora obtenemos todas los productos q estan en stock

            ds_recepcion = DAventaregional.Venta_obtener_productos_recepcion()

            DG_recepcion.DataSource = ds_recepcion.Tables(0)



        Else

            If valido = "no" Then
                MessageBox.Show("Error. Seleccione un cliente para registrar una venta", "Sistema de Gestion.")
            Else
                MessageBox.Show("Error. ingrese un numero de factura para registra una venta", "Sistema de Gestion.")
            End If
        End If





        'If RB_Cliente.Checked = True Then
        '    If DG_clientes.CurrentRow.Cells(1).Value = True Then
        '        GroupBox12.Enabled = True 'habilito la pestaña 2
        '        GroupBox1.Enabled = False
        '        GroupBox2.Enabled = False
        '        GroupBox3.Enabled = False
        '        TabControl1.SelectedTab = TabPage2
        '        'LIMPIAR LA GRILLA DE PROD AGREGADOS
        '        DataG_lista.DataSource = Nothing
        '        Call habilitar_columnas_edicion()
        '        Call Obtener_Productos_Combos()


        '        tx_cantidad.Text = 1

        '    Else
        '        MessageBox.Show("Error, seleccione un cliente", "Sistema de Gestión")
        '    End If
        'Else
        '    GroupBox12.Enabled = True 'habilito la pestaña 2
        '    GroupBox1.Enabled = False
        '    GroupBox2.Enabled = False
        '    GroupBox3.Enabled = False
        '    TabControl1.SelectedTab = TabPage2
        '    'LIMPIAR LA GRILLA DE PROD AGREGADOS
        '    DataG_lista.DataSource = Nothing
        '    Call habilitar_columnas_edicion()
        '    Call Obtener_Productos_Combos()

        '    tx_cantidad.Text = 1
        'End If
    End Sub

    Private Sub Venta_regional_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Focus()
        Obtener_Clientes()
        Generar_cod_interno()
    End Sub
    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAventaregional.Venta_obtener_todas
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            lb_codigo.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("Venta_codigo") + 1
        Else
            lb_codigo.Text = "1"
        End If
    End Sub

#Region "SELECCION DE CLIENTE"
    Dim ds_clie As DataSet
    'recupero todos los clientes
    Public Sub Obtener_Clientes()
        ds_clie = DAcliente.Cliente_obtenertodo()
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            DG_clientes.DataSource = ds_clie.Tables(0)
        End If
    End Sub
    Private Sub Txt_buscar_clie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_buscar_clie.KeyPress
        DG_clientes.DataSource = Nothing
        If Txt_buscar_clie.Text <> "" Then
            Filtrar_datatable(Me.Txt_buscar_clie.Text)
        Else
            DG_clientes.DataSource = ds_clie.Tables(0)
        End If
    End Sub
    Private Sub Filtrar_datatable(ByVal parametro As String)
        If ds_clie.Tables.Count <> 0 Then
            ''uso ds_CLIE que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("CLI_id")
            table_filtrada.Columns.Add("CLI_nom")
            table_filtrada.Columns.Add("CLI_tel")
            table_filtrada.Columns.Add("CLI_mail")
            table_filtrada.Columns.Add("CLI_observaciones")
            table_filtrada.Columns.Add("CLI_direc")
            table_filtrada.Columns.Add("CLI_cel")

            DG_clientes.DataSource = Nothing

            Dim table As DataTable = ds_clie.Tables(0)

            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("CLI_nom")
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
                DG_clientes.DataSource = table_filtrada
            Else
                DG_clientes.DataSource = ds_clie.Tables(0)
            End If
        End If
    End Sub
    Private Sub DG_clientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_clientes.CellClick
        If e.ColumnIndex <> 1 Then Exit Sub
        'primero quito la seleccion de los demas
        Dim i = 0
        While i < DG_clientes.Rows.Count
            DG_clientes.Rows(i).Cells(1).Value = False
            i = i + 1
        End While

        If e.RowIndex >= 0 Then


            If DG_clientes.Rows(e.RowIndex).Cells(1).Value = True Then
                DG_clientes.Rows(e.RowIndex).Cells(1).Value = False
            Else
                DG_clientes.Rows(e.RowIndex).Cells(1).Value = True
            End If
        End If
    End Sub
    Private Sub DG_clientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_clientes.CellDoubleClick
        'primero quito la seleccion de los demas
        Dim i = 0
        While i < DG_clientes.Rows.Count
            DG_clientes.Rows(i).Cells(1).Value = False
            i = i + 1
        End While

        If e.RowIndex >= 0 Then
            If DG_clientes.Rows(e.RowIndex).Cells(1).Value = True Then
                DG_clientes.Rows(e.RowIndex).Cells(1).Value = False
            Else
                DG_clientes.Rows(e.RowIndex).Cells(1).Value = True
            End If
        End If

    End Sub
#End Region

#Region "BUSQUEDA DE PRODUCTOS"
    Private Sub DG_recepcion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_recepcion.CellClick
        If e.ColumnIndex <> 1 Then Exit Sub
        'primero quito la seleccion de los demas
        Dim i = 0
        'While i < DG_recepcion.Rows.Count
        'DG_recepcion.Rows(i).Cells(1).Value = False
        'i = i + 1
        'End While

        If e.RowIndex >= 0 Then


            If DG_recepcion.Rows(e.RowIndex).Cells(1).Value = True Then
                DG_recepcion.Rows(e.RowIndex).Cells(1).Value = False
            Else
                DG_recepcion.Rows(e.RowIndex).Cells(1).Value = True
            End If

        End If
    End Sub
    Private Sub DG_recepcion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_recepcion.CellDoubleClick
        'primero quito la seleccion de los demas
        Dim i = 0
        'While i < DG_recepcion.Rows.Count
        '    DG_recepcion.Rows(i).Cells(1).Value = False
        '    i = i + 1
        'End While
        If e.RowIndex >= 0 Then
            If DG_recepcion.Rows(e.RowIndex).Cells(1).Value = True Then
                DG_recepcion.Rows(e.RowIndex).Cells(1).Value = False
            Else
                DG_recepcion.Rows(e.RowIndex).Cells(1).Value = True
            End If
        End If

    End Sub
    Dim ds_ventareg As New DS_venta_regional
    Private Sub BO_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_agregar.Click

        Dim i As Integer = 0
        While i < DG_recepcion.Rows.Count
            If DG_recepcion.Rows(i).Cells(1).Value = True Then
                DG_recepcion.Rows(i).Cells(1).Value = False
                'ahora antes de agregarlo debo fijarsi si ya no esta en la grilla "DG_PRODAGREGADOS"
                Dim existe As String = "no"
                Dim j As Integer = 0
                While j < Me.DG_PRODAGREGADOS.Rows.Count
                    If DG_recepcion.Rows(i).Cells(0).Value = DG_PRODAGREGADOS.Rows(j).Cells(0).Value Then
                        existe = "si"
                        j = DG_PRODAGREGADOS.Rows.Count
                    End If
                    j = j + 1
                End While
                If existe = "no" Then 'si no esta en la grilla lo agrego
                    Dim newCustomersRow As DataRow = ds_ventareg.Tables("Productos_agregados").NewRow()
                    newCustomersRow("RECEPCION_id") = DG_recepcion.Rows(i).Cells("RECEPCIONidDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_codigo") = DG_recepcion.Rows(i).Cells("RECEPCIONcodigoDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_fecha_sistema") = DG_recepcion.Rows(i).Cells("RECEPCIONfechasistemaDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_codigoproducto") = DG_recepcion.Rows(i).Cells("RECEPCIONcodigoproductoDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_nombreproducto") = DG_recepcion.Rows(i).Cells("RECEPCIONnombreproductoDataGridViewTextBoxColumn").Value
                    newCustomersRow("PROD_T_nom") = DG_recepcion.Rows(i).Cells("PRODTnomDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_nrolote") = DG_recepcion.Rows(i).Cells("RECEPCIONnroloteDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_condi_alm") = DG_recepcion.Rows(i).Cells("RECEPCIONcondialmDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_cantidad") = DG_recepcion.Rows(i).Cells("RECEPCIONcantidadDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_fechavencimiento") = DG_recepcion.Rows(i).Cells("RECEPCIONfechavencimientoDataGridViewTextBoxColumn").Value
                    newCustomersRow("Marca_nom") = DG_recepcion.Rows(i).Cells("MarcanomDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_nrofactura") = DG_recepcion.Rows(i).Cells("RECEPCIONnrofacturaDataGridViewTextBoxColumn").Value
                    newCustomersRow("RECEPCION_fechafactura") = DG_recepcion.Rows(i).Cells("RECEPCIONfechafacturaDataGridViewTextBoxColumn").Value
                    newCustomersRow("Prov_nombre") = DG_recepcion.Rows(i).Cells("ProvnombreDataGridViewTextBoxColumn").Value
                    ds_ventareg.Tables("Productos_agregados").Rows.Add(newCustomersRow)
                    DG_PRODAGREGADOS.DataSource = ds_ventareg.Tables("Productos_agregados")
                End If
            End If
            i = i + 1
        End While

    End Sub
    Private Sub TX_busc_nrofactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_busc_nrofactura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras

            DG_recepcion.DataSource = Nothing
            If TX_busc_nrofactura.Text <> "" Then
                Filtrar_recepcion_factura(Me.TX_busc_nrofactura.Text)
            Else
                DG_recepcion.DataSource = ds_recepcion.Tables(0)
            End If
        End If
    End Sub
    Private Sub Filtrar_recepcion_factura(ByVal parametro As String)
        If ds_recepcion.Tables.Count <> 0 Then
            ''uso ds_recepcion que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("RECEPCION_id")
            table_filtrada.Columns.Add("RECEPCION_codigo")
            table_filtrada.Columns.Add("RECEPCION_fecha_sistema")
            table_filtrada.Columns.Add("RECEPCION_codigoproducto")
            table_filtrada.Columns.Add("RECEPCION_nombreproducto")
            table_filtrada.Columns.Add("PROD_T_nom")
            table_filtrada.Columns.Add("RECEPCION_nrolote")
            table_filtrada.Columns.Add("RECEPCION_condi_alm")
            table_filtrada.Columns.Add("RECEPCION_cantidad")
            table_filtrada.Columns.Add("RECEPCION_fechavencimiento")
            table_filtrada.Columns.Add("Marca_nom")
            table_filtrada.Columns.Add("RECEPCION_nrofactura")
            table_filtrada.Columns.Add("RECEPCION_fechafactura")
            table_filtrada.Columns.Add("Prov_nombre")

            DG_recepcion.DataSource = Nothing

            Dim table As DataTable = ds_recepcion.Tables(0)
            Dim a = 0
            While a < table.Rows.Count

                If parametro = table.Rows(a).Item("RECEPCION_nrofactura") Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If
                a = a + 1
            End While

            If table_filtrada.Rows.Count <> 0 Then
                DG_recepcion.DataSource = table_filtrada
            Else
                DG_recepcion.DataSource = ds_recepcion.Tables(0)
            End If
        End If
    End Sub
    Private Sub TX_busc_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_busc_nombre.KeyPress
        DG_recepcion.DataSource = Nothing
        If TX_busc_nombre.Text <> "" Then
            Filtrar_recepcion_nombre(Me.TX_busc_nombre.Text)
        Else
            DG_recepcion.DataSource = ds_recepcion.Tables(0)
        End If
    End Sub
    Private Sub Filtrar_recepcion_nombre(ByVal parametro As String)
        If ds_recepcion.Tables.Count <> 0 Then
            ''uso ds_recepcion que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("RECEPCION_id")
            table_filtrada.Columns.Add("RECEPCION_codigo")
            table_filtrada.Columns.Add("RECEPCION_fecha_sistema")
            table_filtrada.Columns.Add("RECEPCION_codigoproducto")
            table_filtrada.Columns.Add("RECEPCION_nombreproducto")
            table_filtrada.Columns.Add("PROD_T_nom")
            table_filtrada.Columns.Add("RECEPCION_nrolote")
            table_filtrada.Columns.Add("RECEPCION_condi_alm")
            table_filtrada.Columns.Add("RECEPCION_cantidad")
            table_filtrada.Columns.Add("RECEPCION_fechavencimiento")
            table_filtrada.Columns.Add("Marca_nom")
            table_filtrada.Columns.Add("RECEPCION_nrofactura")
            table_filtrada.Columns.Add("RECEPCION_fechafactura")
            table_filtrada.Columns.Add("Prov_nombre")

            DG_recepcion.DataSource = Nothing

            Dim table As DataTable = ds_recepcion.Tables(0)

            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("RECEPCION_nombreproducto")
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
                DG_recepcion.DataSource = table_filtrada
            Else
                DG_recepcion.DataSource = ds_recepcion.Tables(0)
            End If
        End If
    End Sub
#End Region

#Region "PRODUCTOS AGREGADOS A VENTA"
    Private Sub BO_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Quitar.Click
        Dim i As Integer = 0
        While i < DG_PRODAGREGADOS.Rows.Count
            If DG_PRODAGREGADOS.Rows(i).Cells(1).Value = True Then
                DG_PRODAGREGADOS.Rows(i).Cells(1).Value = False
                ds_ventareg.Tables("Productos_agregados").Rows.RemoveAt(i)
                i = 0
                DG_PRODAGREGADOS.DataSource = ds_ventareg.Tables("Productos_agregados")
                DG_PRODAGREGADOS.Refresh()
            Else
                i = i + 1
            End If
        End While

    End Sub
    Private Sub DG_PRODAGREGADOS_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_PRODAGREGADOS.CellClick

        If e.ColumnIndex <> 1 Then Exit Sub
        'primero quito la seleccion de los demas
        Dim i = 0
        'While i < DG_recepcion.Rows.Count
        'DG_recepcion.Rows(i).Cells(1).Value = False
        'i = i + 1
        'End While
        If DG_PRODAGREGADOS.Rows(e.RowIndex).Cells(1).Value = True Then
            DG_PRODAGREGADOS.Rows(e.RowIndex).Cells(1).Value = False
        Else
            DG_PRODAGREGADOS.Rows(e.RowIndex).Cells(1).Value = True
        End If
    End Sub
    Private Sub DG_PRODAGREGADOS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_PRODAGREGADOS.CellDoubleClick
        'primero quito la seleccion de los demas
        Dim i = 0
        'While i < DG_recepcion.Rows.Count
        '    DG_recepcion.Rows(i).Cells(1).Value = False
        '    i = i + 1
        'End While
        If DG_PRODAGREGADOS.Rows(e.RowIndex).Cells(1).Value = True Then
            DG_PRODAGREGADOS.Rows(e.RowIndex).Cells(1).Value = False
        Else
            DG_PRODAGREGADOS.Rows(e.RowIndex).Cells(1).Value = True
        End If
    End Sub
#End Region

#Region "EDITAR PRODUCTOS AGREGADOS"
    Private Sub BO_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_editar.Click

        If BO_editar.Text = "Editar" Then


            Me.DG_PRODAGREGADOS.Columns(11).ReadOnly = False 'habilito para escribir en columna cantidad


            'deshabilito los botones....
            BO_Guardar.Enabled = False
            BO_cancelar.Enabled = False
            BO_Quitar.Enabled = False

            'deshabilito la grilla de productos recepcionados
            GroupBox_busqprod.Enabled = False


            'cambio el tipo de seleccion
            DG_PRODAGREGADOS.SelectionMode = DataGridViewSelectionMode.CellSelect


            BO_editar.Text = "Salir"

            'modificado = 1
            ''habilito columnas del grid1 

            'cambio el color de las columnas editables
            Dim fila As Integer = 0
            While fila < Me.DG_PRODAGREGADOS.Rows.Count
                Me.DG_PRODAGREGADOS.Rows(fila).Cells(11).Style.BackColor = Color.LightGoldenrodYellow
                fila = fila + 1
            End While

            'Me.DataGridView1.Columns(columgri1).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow

        Else

            'validamos q no se haya puesto un cero en la columna cantidad
            Dim valido As String = "si"
            Dim a As Integer = 0




            While a < ds_ventareg.Tables("Productos_agregados").Rows.Count

                Dim cantidad As String = IIf(IsDBNull(ds_ventareg.Tables("Productos_agregados").Rows(a).Item("RECEPCION_cantidad")), "vacio", ds_ventareg.Tables("Productos_agregados").Rows(a).Item("RECEPCION_cantidad"))

                If cantidad = "0" Or cantidad = "vacio" Then
                    valido = "no"
                End If
                a = a + 1
            End While


            If valido = "si" Then

                ''habilito columnas del grid1 
                Me.DG_PRODAGREGADOS.Columns(11).ReadOnly = True 'deshabilito escritura en columna cantidad

                'pongo el blanco el fondo de las columnas editables
                Dim fila As Integer = 0
                While fila < Me.DG_PRODAGREGADOS.Rows.Count
                    Me.DG_PRODAGREGADOS.Rows(fila).Cells(11).Style.BackColor = Color.White
                    fila = fila + 1

                End While


                'habilito los botones....
                BO_Guardar.Enabled = True
                BO_cancelar.Enabled = True
                BO_Quitar.Enabled = True

                'habilito la grilla de productos recepcionados
                GroupBox_busqprod.Enabled = True


                'cambio el tipo de seleccion
                DG_PRODAGREGADOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                BO_editar.Text = "Editar"

            Else
                MessageBox.Show("Error. Modifique la cantidad, no debe ser nula", "Sistema de Gestion.")
            End If
        End If

    End Sub
    Private Sub DG_PRODAGREGADOS_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG_PRODAGREGADOS.EditingControlShowing
        'referencia a la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregar el controlador de eventos para el keypress
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Me.DG_PRODAGREGADOS.CurrentRow.Cells(0).Value <> "" Then 'si es distinto de vacio valido 
            If Me.DG_PRODAGREGADOS.CurrentCell.ColumnIndex = 11 Then 'SI ES LA COLUMNA 11, solo numeros
                'obtener indice de la columna
                Dim columna As Integer = Me.DG_PRODAGREGADOS.CurrentCell.ColumnIndex
                'comprobar si la celda en edicion corresponde a la columnas deseadas
                'If columna = 1 Or columna = 2 Then
                'obtener caracter
                Dim caracter As Char = e.KeyChar
                'referencia a la celda
                Dim txt As TextBox = CType(sender, TextBox)
                'aqui pongo el codigo para remplazar el punto por una coma
                If txt.ToString() = "." Then
                    txt.Text = ","
                End If
                If caracter.ToString() = "." Then
                    caracter = ","
                End If
                'comprobar si el caracter es un número o el retroceso, si el caracter es un separador decimal y que no contiene ya el separador
                If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Then
                    e.KeyChar = caracter
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        Else 'si la celda cero de la fila actual es vacio...no dejo escribir nada
            e.Handled = True
        End If
    End Sub
#End Region


    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        Limpiar_restablecer()
    End Sub

    Public Sub Limpiar_restablecer()
        GroupBox1.Enabled = True 'buscar cliente
        BO_Guardar.Enabled = False  'boton guardar
        BO_cancelar.Enabled = False  'boton cancelar 
        BO_Quitar.Enabled = False 'boton quitar
        BO_editar.Enabled = False 'boton editar
        TX_busc_nombre.Clear() 'textbox nombre de producto
        TX_busc_nrofactura.Clear() 'textbox nro de factura
        GroupBox_busqprod.Enabled = False 'group de busqueda de productos
        GroupBox_prodagregados.Enabled = False 'group de prod agregados
        TabControl1.SelectedTab = TabPage1 'vuelvo a la primera pestaña
        Generar_cod_interno() 'genero nuevamente codigo nuevo de venta
        tx_nrofactura.Clear()
        tx_nrofactura.SelectAll()
        tx_nrofactura.Focus()
        DG_recepcion.DataSource = ""
        DG_PRODAGREGADOS.DataSource = ""
        ds_ventareg.Tables("Productos_agregados").Rows.Clear()
        'quito la tilde del cliente seleccionado en grilla
        DateTime_fechfactura.Value = Today
        DateTime_fechsistema.Value = Today
        Dim i As Integer = 0
        While i < DG_clientes.Rows.Count
            DG_clientes.Rows(i).Cells(1).Value = False
            i = i + 1
        End While
    End Sub
    
    Private Sub BO_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Guardar.Click
        ''validamos...
        'If tx_nrofactura.Text <> "" Then
        '    'validamos q ya no exista ese nro de factura en la bd
        '    Dim ds_vtas_registradas As DataSet = DAventaregional.Venta_obtener_todas
        '    Dim encontrada As String = "no"
        '    Dim a As Integer = 0
        '    While a < ds_vtas_registradas.Tables(0).Rows.Count
        '        If tx_nrofactura.Text = ds_vtas_registradas.Tables(0).Rows(a).Item("Nro_factura") Then
        '            encontrada = "si"
        '            a = ds_vtas_registradas.Tables(0).Rows.Count
        '        End If
        '        a = a + 1
        '    End While
        '    If encontrada = "no" Then
        '        'ahora validamos q haya productos agregados
        '        If DG_PRODAGREGADOS.Rows.Count <> 0 Then
        '            '/////////////////////////////////////////GUARDO EN BASE DATOS////////////////////////////////////////////////////////////////////////////////////
        '            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '            'recupero todos los productos---para ver si resto stock o cambio de estado
        '            ds_recepcion = DAventaregional.Venta_obtener_productos_recepcion()
        '            Dim ds_venta As DataSet = DAventaregional.Venta_alta(lb_codigo.Text, CLI_id, DateTime_fechsistema.Value, tx_nrofactura.Text, DateTime_fechfactura.Value)
        '            Dim venta_id As Integer = ds_venta.Tables(0).Rows(0).Item("Venta_id")
        '            'ahora viene el alta del detalle de venta....
        '            Dim i As Integer = 0
        '            While i < DG_PRODAGREGADOS.Rows.Count
        '                DAventaregional.Venta_detalle_alta(venta_id, DG_PRODAGREGADOS.Rows(i).Cells(0).Value, CInt(DG_PRODAGREGADOS.Rows(i).Cells(11).Value))
        '                'cambiamos el estado de los productos en stock---a vendido solo si se vendio toda la cantidad de productos q estaban en stock
        '                'caso contrario solo se resta el valor y mantenemos el estado "STOCK"
        '                Dim j As Integer = 0
        '                While j < ds_recepcion.Tables(0).Rows.Count
        '                    If DG_PRODAGREGADOS.Rows(i).Cells(0).Value = ds_recepcion.Tables(0).Rows(j).Item("RECEPCION_id") Then
        '                        'si son iguales, ahora vemos el valor en stock
        '                        If DG_PRODAGREGADOS.Rows(i).Cells(11).Value >= ds_recepcion.Tables(0).Rows(j).Item("RECEPCION_cantidad") Then
        '                            DAventaregional.Venta_modificar_recepcion(DG_PRODAGREGADOS.Rows(i).Cells(0).Value, CInt(DG_PRODAGREGADOS.Rows(i).Cells(11).Value), "Vendido") 'pongo en cero la cant en stock, y cambia de estado a "Vendido"
        '                        Else
        '                            DAventaregional.Venta_modificar_recepcion(DG_PRODAGREGADOS.Rows(i).Cells(0).Value, CInt(DG_PRODAGREGADOS.Rows(i).Cells(11).Value), "Stock") 'resto stock y sigo manteniendo el estado en "Stock"
        '                        End If
        '                        j = ds_recepcion.Tables(0).Rows.Count 'aqui corto el ciclo ya q lo encontre
        '                    End If
        '                    j = j + 1
        '                End While
        '                i = i + 1
        '            End While
        '            MessageBox.Show("La venta se registro correctamente", "Sistema de Gestion.")
        '            Limpiar_restablecer()
        '            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '        Else
        '            MessageBox.Show("Error. No hay productos agregados para la venta", "Sistema de Gestion.")
        '        End If
        '    Else
        '        MessageBox.Show("Error. el numero de factura ya se encuentra registrado", "Sistema de Gestion.")
        '        tx_nrofactura.SelectAll()
        '        tx_nrofactura.Focus()
        '        TabControl1.SelectedTab = TabPage1
        '    End If
        'Else
        '    MessageBox.Show("Error. ingrese un numero de factura para registra una venta", "Sistema de Gestion.")
        '    tx_nrofactura.SelectAll()
        '    tx_nrofactura.Focus()
        '    TabControl1.SelectedTab = TabPage1
        'End If
    End Sub




End Class