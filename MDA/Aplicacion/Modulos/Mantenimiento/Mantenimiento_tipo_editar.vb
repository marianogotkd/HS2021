Public Class Mantenimiento_tipo_editar
    Public indice As Integer = 0 'este parametro me lo envia el form mantenimiento_tipo_alta
    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txt_periodicidad_desc.Text <> "" Then
            If txt_dias.Text <> 0 Then
                'validamos que no exista ya con esa descripcion
                Dim valido As String = "si"
                Dim i As Integer = 0
                While i < Mantenimiento_tipo_alta.DG_PERIODICIDAD.Rows.Count
                    If Mantenimiento_tipo_alta.DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidaddescDataGridViewTextBoxColumn").Value.ToString.ToUpper = txt_periodicidad_desc.Text.ToUpper Then
                        If i <> indice Then
                            valido = "no"
                        End If
                        Exit While
                    End If
                    i = i + 1
                End While
                If valido = "si" Then
                    Mantenimiento_tipo_alta.DG_PERIODICIDAD.Rows(indice).Cells("MantperiodicidaddescDataGridViewTextBoxColumn").Value = txt_periodicidad_desc.Text
                    Mantenimiento_tipo_alta.DG_PERIODICIDAD.Rows(indice).Cells("MantperiodicidaddiasDataGridViewTextBoxColumn").Value = CInt(txt_dias.Text)
                    If Mantenimiento_tipo_alta.DG_PERIODICIDAD.Rows(indice).Cells("EstadoDataGridViewTextBoxColumn").Value <> "nuevo" Then 'solo edito los que estan en bd o bien editados
                        Mantenimiento_tipo_alta.DG_PERIODICIDAD.Rows(indice).Cells("EstadoDataGridViewTextBoxColumn").Value = "editado"
                    End If

                    Me.Close()
                Else
                    MessageBox.Show("Error, ya existe un item con esa descripción. Debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_periodicidad_desc.SelectAll()
                    txt_periodicidad_desc.Focus()
                End If
            Else
                MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_dias.Focus()
            End If
        Else
            MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_periodicidad_desc.SelectAll()
            txt_periodicidad_desc.Focus()
        End If
    End Sub
End Class