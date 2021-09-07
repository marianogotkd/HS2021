
Public Class Pago_caja
    Dim DAventa As New Datos.Venta
    Dim DAproducto As New Datos.Producto
    Dim DAcaja As New Datos.Caja

    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        If tx_parcial.Text = "" Then
            tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tx_parcial.Text = (Math.Round(CDec(tx_parcial.Text), 2).ToString("N2"))
        End If
        TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
        TextBox1.Text = (Math.Round(CDec(TextBox1.Text), 2).ToString("N2"))
        If TextBox1.Text < 0 Then
            TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If






        If CDec(tx_total.Text) = 0 Or CDec(tx_parcial.Text) = 0 Then
            MessageBox.Show("El monto total es incorrecto", "Sistema de Gestion.")

        Else

            'VALICACIONES

            If CDec(tx_parcial.Text) > CDec(tx_total.Text) Or CDec(tx_parcial.Text) = CDec(tx_total.Text) Then


                If Venta_Caja_gestion.DataG_lista.Rows.Count <> 0 Then
                    'If RB_Cliente.Checked = True Then
                    '    If DG_clientes.CurrentRow.Cells(1).Value = True Then
                    'GUARDAR EN TABLA "Venta_Producto"///////////////////////////////////////////////////////////////////////////////////
                    Dim usuario_id As String
                    usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                    Dim tipo_vta As String = ""
                    Dim cliente_id As Integer
                    If Venta_Caja_gestion.RB_Consumidor.Checked = True Then
                        tipo_vta = "Consumidor Final"
                        cliente_id = 0
                    Else
                        tipo_vta = "Cliente"
                        cliente_id = Venta_Caja_gestion.DG_clientes.CurrentRow.Cells(0).Value
                    End If
                    Dim ds_Venta As DataSet = DAventa.VentaProducto_alta(CDec(Venta_Caja_gestion.DataG_listaTotal.Rows(0).Cells(1).Value),
                                                    Now,
                                                    usuario_id,
                                                    tipo_vta,
                                                    cliente_id)

                    DAcaja.Caja_Actualizar(CDec(Venta_Caja_gestion.DataG_listaTotal.Rows(0).Cells(1).Value), Inicio.USU_id)

                    Dim ventaprod_id As Integer = CType(ds_Venta.Tables(0).Rows(0).Item("ventaprod_id"), String)
                    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    'GUARDAR EN TABLA "Venta_Producto_detalle"
                    For Each row As DataGridViewRow In Venta_Caja_gestion.DataG_lista.Rows
                        DAventa.VentaProductoDetalle_alta(ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(6).Value), CDec(row.Cells(7).Value), row.Cells(3).Value, row.Cells(2).Value)
                    Next

                    'aqui hago el descuento de stock...
                    'primero de los productos ....luego de los combos...(ya q estan formados por varios productos)

                    Dim i As Integer = 0
                    Dim ds_stock As New DataSet
                    While i < Venta_Caja_gestion.DataG_lista.Rows.Count
                        Dim prod_codigo As Integer = 0
                        If Venta_Caja_gestion.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value <> "0" Then
                            prod_codigo = CInt(Venta_Caja_gestion.DataG_lista.Rows(i).Cells("CodinternoDataGridViewTextBoxColumn").Value)
                        End If
                        ds_stock = DAproducto.Producto_buscarcod(prod_codigo)
                        If ds_stock.Tables(0).Rows.Count <> 0 Then
                            Dim diferencia As Integer = CInt(ds_stock.Tables(0).Rows(0).Item("prod_stock")) - CInt(Venta_Caja_gestion.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                            DAventa.Venta_actualizar_stock_Caja(prod_codigo, diferencia)
                            'MsgBox("actualizo stock de", prod_codigo)

                        Else 'si no lo encuentra significa q es un combo o bien una promocion...asi que tengo q actualizar el stock de varios
                            If Venta_Caja_gestion.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value <> "0" Then
                                'primero lo busco como combo.

                                'aqui veo si ponerle el indice _tabla en 2 o 3...dependiendo del procedimiento q tome los recursos el DS_PROD...
                                'son 2 las rutinas....Venta_obtenerProducto_listaregular y [Venta_obtenerProducto_Combos]
                                Dim indice_tabla As Integer = 0
                                If Venta_Caja_gestion.RB_Si.Checked = False Then
                                    indice_tabla = 3
                                Else
                                    indice_tabla = 2
                                End If
                                'id del combo
                                Dim ProdCombo_id As Integer = CInt(Venta_Caja_gestion.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value)
                                Dim cantidad_combos As Integer = CInt(Venta_Caja_gestion.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                                Dim j As Integer = 0
                                While j < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows.Count
                                    If ProdCombo_id = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdCombo_id") Then
                                        Dim prod_id As Integer = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("prod_id")
                                        Dim cantidad_item As Integer = CInt(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdComboDet_cantidad"))
                                        ds_stock = DAproducto.Producto_buscar_id(prod_id)

                                        Dim cantidad_total As Integer = CInt(cantidad_combos * cantidad_item)

                                        Dim diferencia As Integer = CInt(ds_stock.Tables(0).Rows(0).Item("prod_stock")) - cantidad_total
                                        DAventa.Venta_actualizar_stock_Caja_2(prod_id, diferencia)
                                        'MsgBox("actualizo stock de combo", prod_codigo)
                                    End If
                                    j = j + 1
                                End While
                            Else
                                'aqui llamo a la rutina ACTUALIZAR STOCK DE PROMOCION
                                Dim LISTA_codinterno As String = (Venta_Caja_gestion.DataG_lista.Rows(i).Cells("CodinternoDataGridViewTextBoxColumn").Value)
                                Dim cantidad_PROMOS As Integer = CInt(Venta_Caja_gestion.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                                Dim LISTA_ID As Integer = 0

                                'Busco el id de la promocion en el ds_promo
                                Dim ii As Integer = 0
                                While ii < Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows.Count
                                    If LISTA_codinterno = Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows(ii).Item("LISTA_codinterno") Then
                                        LISTA_ID = Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows(ii).Item("LISTA_id")
                                    End If
                                    ii = ii + 1
                                End While
                                Venta_Caja_gestion.Actualizar_Stock_Promocion(LISTA_ID, cantidad_PROMOS)

                            End If
                        End If
                        i = i + 1
                    End While

                    MessageBox.Show("La venta fue registrada correctamente.", "Sistema de Gestion.")
                    Venta_Caja_gestion.Limpiar()

                    Me.Close()

                    'Else
                    '    MessageBox.Show("Error, seleccione cliente", "Sistema de Gestion.")
                    'End If
                    '    End If
                Else
                    MessageBox.Show("Error, No hay productos agregados", "Sistema de Gestión")
                End If

            Else
                MessageBox.Show("Error! El monto ingresado es menor al total, por favor modifique", "Sistema de Gestion", MessageBoxButtons.OK)
                tx_parcial.Focus()
                tx_parcial.SelectAll()
            End If


        End If
    End Sub

    Private Sub Pago_caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tx_parcial.MaxLength = 6
    End Sub

    Private Sub tx_parcial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_parcial.KeyPress
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
                If e.KeyChar = "," And Not Me.tx_parcial.Text.IndexOf(",") Then
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
            If tx_parcial.Text = "" Then
                tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))


            End If
            TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
            TextBox1.Text = (Math.Round(CDec(TextBox1.Text), 2).ToString("N2"))
            If TextBox1.Text < 0 Then
                TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
        End If

    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Me.Close()
    End Sub
End Class