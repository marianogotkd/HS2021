Public Class Sucursales_sector_nuevo

    Dim DAsector As New Datos.Sucursal_sector

    Public SucxClie_id As Integer 'me lo envia el form de equipo_alta


    Private Sub bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bo_guardar.Click
        Try
            If txt_descripcion.Text <> "" Then

                If txt_denominacion.Text <> "" Then

                    'ahora valido
                    Dim ds_validar As DataSet = DAsector.Cliente_suc_sector_validar(txt_descripcion.Text, txt_denominacion.Text, SucxClie_id)

                    If ds_validar.Tables(0).Rows.Count = 0 And ds_validar.Tables(1).Rows.Count = 0 Then
                        'puedo guardar
                        DAsector.Cliente_suc_sector_alta(txt_descripcion.Text, txt_denominacion.Text, SucxClie_id)
                        MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'ahora actualizo el combo en el formulario equipo_alta
                        Equipo_nuevo.recuperar_sectores()
                        Me.Close()
                    Else
                        If ds_validar.Tables(0).Rows.Count <> 0 Then
                            'no puedo guardar
                            MessageBox.Show("Error, ya existe un sector con esa descripción. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txt_descripcion.SelectAll()
                            txt_descripcion.Focus()
                        Else
                            If ds_validar.Tables(1).Rows.Count <> 0 Then
                                'no puedo guardar
                                MessageBox.Show("Error, ya existe un sector con esa denominación. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                txt_denominacion.SelectAll()
                                txt_denominacion.Focus()
                            End If
                        End If
                    End If

                Else
                    MessageBox.Show("Error, complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_denominacion.SelectAll()
                    txt_denominacion.Focus()
                End If
            Else
                MessageBox.Show("Error, complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_descripcion.SelectAll()
                txt_descripcion.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error, la operación no se realizó. Intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
        

    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        Me.Close()
    End Sub
End Class