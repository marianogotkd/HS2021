Public Class Equipos_subtipo_editar
    Public indice As Integer 'me lo envia el form equipos_categorias_alta

    Private Sub bot_agregar_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot_agregar_cat.Click
        If txt_subtipo.Text <> "" Then
            Equipos_categorias_alta.DG_subtipos.Rows(indice).Cells("DescripcionDataGridViewTextBoxColumn").Value = txt_subtipo.Text

            If Equipos_categorias_alta.DG_subtipos.Rows(indice).Cells("estado").Value = "en_bd" Then
                Equipos_categorias_alta.DG_subtipos.Rows(indice).Cells("estado").Value = "modificado"
            End If
            Me.Close()
        Else
            MessageBox.Show("Error, el campo esta vacio. Ingrese la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_subtipo.SelectAll()
            txt_subtipo.Focus()
        End If
    End Sub
End Class