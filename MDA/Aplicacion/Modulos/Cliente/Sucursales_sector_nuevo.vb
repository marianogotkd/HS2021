Public Class Sucursales_sector_nuevo

    Dim DAsector As New Datos.Sucursal_sector

    Public SucxClie_id As Integer 'me lo envia el form de equipo_alta
    Public procedencia As String
    Public operacion As String = "alta"
    Public Cliente_suc_sector_id As Integer 'me lo envia el formulario sucursales_sector_modificar para editar un sector
    Private Sub bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bo_guardar.Click
        Try

            If operacion = "alta" Then
                'alta
                alta()
            Else
                'modificar
                modificar()
            End If

            
        Catch ex As Exception
            MessageBox.Show("Error, la operación no se realizó. Intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
        

    End Sub

    Private Sub alta()
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
                    If procedencia = "sucursales_sector_modificar" Then
                        'tambien actualizo en ese formulario.
                        Sucursales_sector_modificar.recuperar_sectores()
                    End If
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
    End Sub

    Private Sub validar_modificacion(ByRef valido As String)
        'ahora valido
        Dim ds_validar As DataSet = DAsector.Cliente_suc_sector_validar(txt_descripcion.Text, txt_denominacion.Text, SucxClie_id)
        If ds_validar.Tables(0).Rows.Count = 0 And ds_validar.Tables(1).Rows.Count = 0 Then
            valido = "si"
        Else
            If ds_validar.Tables(0).Rows.Count <> 0 Then
                Dim el_mismo As String = "no"
                Dim i As Integer = 0
                While i < ds_validar.Tables(0).Rows.Count
                    If ds_validar.Tables(0).Rows(i).Item("Cliente_suc_sector_id") = Cliente_suc_sector_id Then
                        valido = "si"
                    Else
                        valido = "no"
                        'no puedo guardar
                        MessageBox.Show("Error, ya existe un sector con esa descripción. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_descripcion.SelectAll()
                        txt_descripcion.Focus()
                        valido = "no"
                        Exit While
                    End If
                    i = i + 1
                End While
            End If

            If valido = "si" Then 'esta correcto la descripcion pero me falta ver la denominacion
                If (ds_validar.Tables(1).Rows.Count <> 0) Then
                    Dim el_mismo As String = "no"
                    Dim i As Integer = 0
                    While i < ds_validar.Tables(1).Rows.Count
                        If ds_validar.Tables(1).Rows(i).Item("Cliente_suc_sector_id") = Cliente_suc_sector_id Then
                            valido = "si"
                        Else
                            valido = "no"
                            'no puedo guardar
                            MessageBox.Show("Error, ya existe un sector con esa denominación. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txt_denominacion.SelectAll()
                            txt_denominacion.Focus()
                            valido = "no"
                            Exit While
                        End If
                        i = i + 1
                    End While
                End If
            End If
        End If

    End Sub


    Private Sub modificar()
        If txt_descripcion.Text <> "" Then

            If txt_denominacion.Text <> "" Then
                Dim valido As String = "si"
                validar_modificacion(valido)

                If valido = "si" Then
                    DAsector.Cliente_suc_sector_modificar(txt_descripcion.Text, txt_denominacion.Text, Cliente_suc_sector_id)
                    MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'ahora actualizo el combo en el formulario equipo_alta
                    Equipo_nuevo.recuperar_sectores()
                    If procedencia = "sucursales_sector_modificar" Then
                        'tambien actualizo en ese formulario.
                        Sucursales_sector_modificar.recuperar_sectores()
                    End If
                    Me.Close()
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
    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Sucursales_sector_nuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If operacion = "modificar" Then
            'es una modificacion


        End If
    End Sub
End Class