Public Class Retiro_Producto
    Dim DAretiro As New Datos.Retiro
    Dim DAventa As New Datos.Venta_regional
    Private Sub Retiro_Producto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Focus()

        Generar_cod_interno()

    End Sub

    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAretiro.Retiro_obtener_todo
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            lb_codigo.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("Retiro_codigo") + 1
        Else
            lb_codigo.Text = "1"
        End If
    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click

        Limpiar_restablecer()


    End Sub

   

    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click

        If DG_retiro.Rows.Count <> 0 Then

            If tx_destino.Text <> "" Then

                '/////////////////////////////////////////GUARDO EN BASE DATOS////////////////////////////////////////////////////////////////////////////////////
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Dim PROD_codigo As String = DG_retiro.Rows(0).Cells(1).Value
                Dim PRODDET_nrolote As String = DG_retiro.Rows(0).Cells("PRODDETnroloteDataGridViewTextBoxColumn").Value
                Dim ds_venta As DataSet = DAretiro.Retiro_alta("Proveedor", lb_codigo.Text, tx_motivo.Text, tx_destino.Text, DateTime_fechsistema.Value, PROD_codigo, PRODDET_nrolote)
                Dim retiro_id As Integer = ds_venta.Tables(0).Rows(0).Item("Retiro_id")
                Dim prod_id As Integer = DG_retiro.Rows(0).Cells(0).Value
                Dim nro_lote As String = DG_retiro.Rows(0).Cells("PRODDETnroloteDataGridViewTextBoxColumn").Value
                Dim diferencia As Integer
                diferencia = CInt(DG_retiro.Rows(0).Cells(4).Value) - CInt(DG_retiro.Rows(0).Cells(10).Value)
                Dim ds_prod As DataSet = DAretiro.ProdDetalle_modificar(diferencia, "Retirado", prod_id, nro_lote)
                MessageBox.Show("Se retiro el lote correctamente", "Sistema de Gestion.")

                Limpiar_restablecer()
                
            Else
                MessageBox.Show("Error. ingrese el destino para registrar", "Sistema de Gestion.")
                tx_destino.SelectAll()
                tx_destino.Focus()

            End If
        Else

            MessageBox.Show("Error. realice la busqueda de algun lote para registrar", "Sistema de Gestion.")
            tx_cod_prod.SelectAll()
            tx_cod_prod.Focus()
        End If
    End Sub

    Public Sub Limpiar_restablecer()

        DG_retiro.DataSource = ""
        tx_cod_lote.Text = Nothing
        tx_cod_prod.Text = Nothing
        DateTime_fechsistema.Value = Today
        tx_destino.Text = Nothing
        tx_destino.Text = Nothing
        tx_cod_prod.Focus()
        Generar_cod_interno()

    End Sub
  
    Private Sub BO_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
        Buscar_codprod_nrolote()
    End Sub

    Private Sub Buscar_codprod_nrolote()
        If tx_cod_prod.Text <> "" And tx_cod_lote.Text <> "" Then

            Dim DS As New DataSet
            DS = DAretiro.Retiro_ObtenerDatos_cod_lote(tx_cod_prod.Text, tx_cod_lote.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                If DS.Tables(0).Rows(0).Item(5) <> "Retirado" Then
                    DG_retiro.DataSource = DS.Tables(0)
                Else
                    MessageBox.Show("El lote ya fue retirado", "Sistema de Gestion.", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("No existe el lote o producto", "Sistema de Gestion.", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("Complete los Datos en los 2 Campos", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub tx_cod_prod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_cod_prod.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tx_cod_lote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_cod_lote.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_codprod_nrolote()
        End If
    End Sub

End Class

