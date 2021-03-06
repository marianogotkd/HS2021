Public Class VentaRegional_nuevodiseño
    Dim DAcliente As New Datos.Cliente
    Dim DAventaregional As New Datos.Venta_regional


#Region "Primera pestaña"

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

    Public Sub Generar_cod_interno()
        Dim ds_generar As DataSet = DAventaregional.Venta_obtener_todas_Codigo()
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            lb_codigo.Text = ds_generar.Tables(0).Rows.Count + 1
        Else
            lb_codigo.Text = "1"
            'tx_codproducto.Text = "100"
        End If




        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        'Dim ds_generar As DataSet = DAventaregional.Venta_obtener_todas
        'If ds_generar.Tables(0).Rows.Count <> 0 Then
        '    lb_codigo.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("Venta_codigo") + 1
        'Else
        '    lb_codigo.Text = "1"
        'End If
    End Sub






    Dim CLI_id As Integer = 0
    Private Sub BO_Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_Aceptar.Click
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

            'GroupBox_busqprod.Enabled = True
            GroupBox_prodagregados.Enabled = True


            TabControl1.SelectedTab = TabPage2



            'ahora obtenemos todas los productos q estan en stock

            'ds_recepcion = DAventaregional.Venta_obtener_productos_recepcion()

            'DG_recepcion.DataSource = ds_recepcion.Tables(0)

        Else

            If valido = "no" Then
                MessageBox.Show("Error. Seleccione un cliente para registrar una venta", "Sistema de Gestion.")
            Else
                MessageBox.Show("Error. ingrese un numero de factura para registra una venta", "Sistema de Gestion.")
            End If
        End If


    End Sub


#End Region



    Private Sub VentaRegional_nuevodiseño_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Clientes()
        Generar_cod_interno()
    End Sub

#Region "Segunda pestaña"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        VentaRegiona_busqueda.Show()
    End Sub


    Public Sub calcular_totales()


        Lb_pagoparcial.Text = "00,00"

        'sumamos los subtotales con un ciclo
        Dim sumar As Decimal = "0,00"

        Dim ii As Integer = 0
        While ii < DG_PRODAGREGADOS.Rows.Count
            sumar = sumar + DG_PRODAGREGADOS.Rows(ii).Cells("SubtotalDataGridViewTextBoxColumn").Value
            ii = ii + 1
        End While
        sumar = Math.Round(sumar, 2)

        Lb_pagoparcial.Text = Math.Round(sumar, 2).ToString("N2")
    End Sub

    Private Sub BO_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Quitar.Click
        Dim i As Integer = 0
        While i < DG_PRODAGREGADOS.Rows.Count
            If DG_PRODAGREGADOS.Rows(i).Cells(1).Value = True Then
                DG_PRODAGREGADOS.Rows(i).Cells(1).Value = False
                DS_venta_regional.Tables("Productos_agregados").Rows.RemoveAt(i)
                i = 0
                DG_PRODAGREGADOS.DataSource = DS_venta_regional.Tables("Productos_agregados")
                DG_PRODAGREGADOS.Refresh()
            Else
                i = i + 1
            End If
        End While
        calcular_totales()
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
        'TX_busc_nombre.Clear() 'textbox nombre de producto
        'TX_busc_nrofactura.Clear() 'textbox nro de factura
        'GroupBox_busqprod.Enabled = False 'group de busqueda de productos
        GroupBox_prodagregados.Enabled = False 'group de prod agregados
        TabControl1.SelectedTab = TabPage1 'vuelvo a la primera pestaña
        Generar_cod_interno() 'genero nuevamente codigo nuevo de venta
        tx_nrofactura.Clear()
        tx_nrofactura.SelectAll()
        tx_nrofactura.Focus()
        'DG_recepcion.DataSource = ""
        DG_PRODAGREGADOS.DataSource = ""
        DS_venta_regional.Tables("Productos_agregados").Rows.Clear()
        'quito la tilde del cliente seleccionado en grilla
        DateTime_fechfactura.Value = Today
        DateTime_fechsistema.Value = Today
        Dim i As Integer = 0
        While i < DG_clientes.Rows.Count
            DG_clientes.Rows(i).Cells(1).Value = False
            i = i + 1
        End While
        Lb_pagoparcial.Text = "00,00"
    End Sub


    Private Sub BO_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Guardar.Click
        'validamos...
        If tx_nrofactura.Text <> "" Then
            'validamos q ya no exista ese nro de factura en la bd
            Dim ds_vtas_registradas As DataSet = DAventaregional.Venta_obtener_todas
            Dim encontrada As String = "no"
            Dim a As Integer = 0
            While a < ds_vtas_registradas.Tables(0).Rows.Count
                If tx_nrofactura.Text = ds_vtas_registradas.Tables(0).Rows(a).Item("Nro_factura") Then
                    encontrada = "si"
                    a = ds_vtas_registradas.Tables(0).Rows.Count
                End If
                a = a + 1
            End While
            If encontrada = "no" Then
                'ahora validamos q haya productos agregados
                If DG_PRODAGREGADOS.Rows.Count <> 0 Then
                    '/////////////////////////////////////////GUARDO EN BASE DATOS////////////////////////////////////////////////////////////////////////////////////
                    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Dim ds_venta As DataSet = DAventaregional.Venta_alta(lb_codigo.Text, CLI_id, DateTime_fechsistema.Value, tx_nrofactura.Text, DateTime_fechfactura.Value, Lb_pagoparcial.Text)
                    Dim venta_id As Integer = ds_venta.Tables(0).Rows(0).Item("Venta_id")
                    'ahora viene el alta del detalle de venta....
                    Dim i As Integer = 0
                    While i < DG_PRODAGREGADOS.Rows.Count
                        Dim ds_venta_Detalle As DataSet = DAventaregional.Venta_detalle_alta(venta_id,
                                                           DG_PRODAGREGADOS.Rows(i).Cells(0).Value,
                                                           CInt(DG_PRODAGREGADOS.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value), DG_PRODAGREGADOS.Rows(i).Cells("PRODprecioUDataGridViewTextBoxColumn").Value, DG_PRODAGREGADOS.Rows(i).Cells("SubtotalDataGridViewTextBoxColumn").Value, DG_PRODAGREGADOS.Rows(i).Cells("Venta_Lote").Value)

                        Dim Venta_det_id As Integer = ds_venta_Detalle.Tables(0).Rows(0).Item("Venta_det_id")
                        'cambiamos el estado de los productos en stock---a vendido solo si se vendio toda la cantidad de productos q estaban en stock
                        'caso contrario solo se resta el valor y mantenemos el estado "STOCK"
                        Dim ds_stock = DAventaregional.Venta_obtener_productos_en_stock()
                        Dim es As Integer = 0
                        While es < ds_stock.Tables(0).Rows.Count
                            If ds_stock.Tables(0).Rows(es).Item("PROD_id") = DG_PRODAGREGADOS.Rows(i).Cells(0).Value Then
                                Dim cant_diferencia As Integer = CInt(ds_stock.Tables(0).Rows(es).Item("PROD_cant_total")) - CInt(DG_PRODAGREGADOS.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                                DAventaregional.Venta_modificar_stock(DG_PRODAGREGADOS.Rows(i).Cells(0).Value, cant_diferencia)
                            End If
                            es = es + 1
                        End While

                        '/////////////////////////////////REGISTRAR EN VENTA LOS LOTES Q SE ESTAN VENDIENDO DE CADA PRODUCTO//////////////////
                        Dim producto_id As Integer = DG_PRODAGREGADOS.Rows(i).Cells(0).Value

                        Dim ds_lotes As DataSet = DAventaregional.Venta_obtener_lotes_de_producto(producto_id)
                        Dim Lote_prod = DG_PRODAGREGADOS.Rows(i).Cells("Venta_Lote").Value
                        Dim cantidad As Integer = CInt(DG_PRODAGREGADOS.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                        Dim cant_inicial As Integer = 0
                        Dim j As Integer = 0

                        While j < ds_lotes.Tables(0).Rows.Count Or cantidad <> 0
                            If ds_lotes.Tables(0).Rows(j).Item("PRODDET_nrolote") = Lote_prod And ds_lotes.Tables(0).Rows(j).Item("PRODDET_cantidad") <> 0 Then


                                Dim cantlote As Integer = CInt(ds_lotes.Tables(0).Rows(j).Item("PRODDET_cantidad"))

                                If cantlote < cantidad Or cantlote = cantidad Then
                                    cantidad = cantidad - cantlote
                                    DAventaregional.Venta_detalle_lotevendido_alta(Venta_det_id, ds_lotes.Tables(0).Rows(j).Item("PRODDET_id"), cantlote)
                                    DAventaregional.Venta_actualizarsotck_producto_detalle(ds_lotes.Tables(0).Rows(j).Item("PRODDET_id"), "0", "Vendido")


                                Else
                                    If cantlote > cantidad Then
                                        DAventaregional.Venta_detalle_lotevendido_alta(Venta_det_id, ds_lotes.Tables(0).Rows(j).Item("PRODDET_id"), cantidad)
                                        cantlote = cantlote - cantidad
                                        DAventaregional.Venta_actualizarsotck_producto_detalle(ds_lotes.Tables(0).Rows(j).Item("PRODDET_id"), cantlote, "Stock")
                                        cantidad = 0
                                    End If
                                End If
                            End If
                            j = j + 1



                        End While




                        i = i + 1
                    End While
                    MessageBox.Show("La venta se registro correctamente", "Sistema de Gestion.")
                    Limpiar_restablecer()
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Else
                    MessageBox.Show("Error. No hay productos agregados para la venta", "Sistema de Gestion.")
                End If
            Else
                MessageBox.Show("Error. el numero de factura ya se encuentra registrado", "Sistema de Gestion.")
                tx_nrofactura.SelectAll()
                tx_nrofactura.Focus()
                TabControl1.SelectedTab = TabPage1
            End If
        Else
            MessageBox.Show("Error. ingrese un numero de factura para registra una venta", "Sistema de Gestion.")
            tx_nrofactura.SelectAll()
            tx_nrofactura.Focus()
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub

    Private Sub BO_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Nuevo.Click
        Cliente_modificar.Show()
    End Sub
End Class