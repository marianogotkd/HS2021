

Public Class Consultar_General
    Dim DA As New Datos.Consulta_General
    

    Private Sub BO_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
        Dim DSdev As New DataSet
        Dim DSrec As New DataSet
        Dim DSret As New DataSet
        Dim DSven As New DataSet
        DSdev = DA.Consulta_General_Obtener_Devoluciones(tx_cod_prod.Text)
        DSrec = DA.Consulta_General_Obtener_Recepciones(tx_cod_prod.Text)
        DSven = DA.Consulta_General_Obtener_Ventas(tx_cod_prod.Text)
        DSret = DA.Consulta_General_Obtener_Retiros(tx_cod_prod.Text)

        If DSrec.Tables(0).Rows.Count <> 0 Then
            DG_Recepcionado.DataSource = DSrec.Tables(0)
       
            If DSdev.Tables(0).Rows.Count <> 0 Then
                DG_Devuelto.DataSource = DSdev.Tables(0)
            Else
                DG_Devuelto.DataSource = ""
            End If

            If DSven.Tables(0).Rows.Count <> 0 Then
                DG_Vendido.DataSource = DSven.Tables(0)
            Else
                DG_Vendido.DataSource = ""
            End If

            If DSret.Tables(0).Rows.Count <> 0 Then
                DG_Retirado.DataSource = DSret.Tables(0)
            Else
                DG_Retirado.DataSource = ""
            End If

        Else
            MessageBox.Show("No existe El Producto", "Sistema de Gestion.", MessageBoxButtons.OK)
            Limpiar_Todas()
        End If
    End Sub

    Public Sub Limpiar_Todas()
        DG_Retirado.DataSource = ""
        DG_Vendido.DataSource = ""
        DG_Devuelto.DataSource = ""
        DG_Recepcionado.DataSource = ""

    End Sub
       
End Class