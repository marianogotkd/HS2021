Public Class Equipos_atributos_editar
    Public indice As Integer 'me lo envia el form equipos_categorias_alta
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txt_atributo.Text <> "" Then
            Dim atributo As String = Equipos_categorias_alta.dg_atributos.Rows(indice).Cells("Cat2caractatributoDataGridViewTextBoxColumn").Value 'lo uso en la busqueda

            Equipos_categorias_alta.dg_atributos.Rows(indice).Cells("Cat2caractatributoDataGridViewTextBoxColumn").Value = txt_atributo.Text

            If Equipos_categorias_alta.dg_atributos.Rows(indice).Cells("estado_column").Value = "en_bd" Then
                Equipos_categorias_alta.dg_atributos.Rows(indice).Cells("estado_column").Value = "modificado"
            End If


            '/////////////////////////////////////////////////////////////////////
            'tambien debo actualizar en la tabla auxiliar, que es de donde voy a recorrer mas adelante cuando guarde los cambios en bd.
            Dim h As Integer = 0
            'Dim Cat2_caract_id As Integer = CInt(dg_atributos.Rows(i).Cells("Cat2caractidDataGridViewTextBoxColumn").Value) 'puedo usar esto en  la busqueda, x que esta en la bd
            Dim subtipo As String = Equipos_categorias_alta.dg_atributos.Rows(indice).Cells("DataGridViewTextBoxColumn1").Value 'lo uso en la busqueda

            While h < Equipos_categorias_alta.Equipos_cat_DS.Tables("Atributos_todos_aux").Rows.Count
                If (atributo = Equipos_categorias_alta.Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(h).Item("Cat2_caract_atributo")) And (subtipo = Equipos_categorias_alta.Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(h).Item("subtipo")) Then
                    Equipos_categorias_alta.Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(h).Item("Cat2_caract_atributo") = txt_atributo.Text
                    If Equipos_categorias_alta.Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(h).Item("estado") = "en_bd" Then
                        Equipos_categorias_alta.Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(h).Item("estado") = "modificado"
                    End If
                    Exit While
                End If
                h = h + 1
            End While
            '/////////////////////////////////////////////////////////////////////

            Me.Close()
        Else
            MessageBox.Show("Error, el campo esta vacio. Ingrese la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_atributo.SelectAll()
            txt_atributo.Focus()
        End If
    End Sub
End Class