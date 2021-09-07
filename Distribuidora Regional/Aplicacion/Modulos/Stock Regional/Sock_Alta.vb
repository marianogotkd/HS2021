Public Class Sock_Alta
    Dim DAretiro As New Datos.Retiro
    Dim DAventa As New Datos.Venta_regional
    Dim DAstock As New Datos.Stock

    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub tx_busc_factura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim ds_recepciones As DataSet

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Buscar_factura()
    End Sub

    Private Sub Buscar_factura()
        If tx_busc_factura.Text <> "" Then
            ds_recepciones = DAretiro.Retiro_Recepcion_obtener_Por_Fac(tx_busc_factura.Text)
            If ds_recepciones.Tables(0).Rows.Count <> 0 Then
                DataGridView1.DataSource = ds_recepciones.Tables(0)
            Else
                DataGridView1.DataSource = ""
            End If
        Else
            DataGridView1.DataSource = ""
        End If
    End Sub

    Private Sub tx_busc_factura_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_busc_factura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_factura()
        End If
    End Sub


    
  

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged


        If Me.DataGridView1.CurrentRow IsNot Nothing Then

            Dim documentoselec As Integer = DataGridView1.SelectedCells(1).Value
            If documentoselec <> 0 Then
                tx_cant.Text = DataGridView1.SelectedCells(10).Value
                tx_fchavto.Text = DataGridView1.SelectedCells(11).Value
                tx_nrofac.Text = DataGridView1.SelectedCells(5).Value
                tx_nrolte.Text = DataGridView1.SelectedCells(8).Value
                BO_guardar.Enabled = True

            End If

        End If

    End Sub

    
    Private Sub BO_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            DAstock.Stock_alta(lb_codigo.Text,
                                           DateTime_fechsistema.Value,
                                           row.Cells("RECEPCIONidDataGridViewTextBoxColumn").Value,
                                           DataGridView1.SelectedCells(6).Value, DataGridView1.SelectedCells(7).Value,
                                            tx_nrolte.Text, DataGridView1.SelectedCells(9).Value,
                                            tx_cant.Text, tx_fchavto.Text, DataGridView1.SelectedCells(12).Value,
                                            tx_nrofac.Text, DataGridView1.SelectedCells(4).Value, DataGridView1.SelectedCells(13).Value)
        Next
        MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")
    End Sub
End Class