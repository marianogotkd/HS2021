Public Class Mantenimiento_config_agregar
    Dim daMant As New Datos.Mantenimiento
    Dim daTareas As New Datos.Tareas
    Public Equipo_id As Integer = 0 'me lo envia el form mantenimiento_config_alta
    Dim mant_tipo_id As Integer = 0
    Public Cat2_equipo_id As Integer 'esta es el subtipo para recuperar todas las tareas



    Public Sub recuperar_mantenimiento_tipo()

        Dim ds_tipo As DataSet = daMant.Mantenimiento_tipo_obtener_todo

        If ds_tipo.Tables(0).Rows.Count <> 0 Then
            cb_tipo_mant.DataSource = ds_tipo.Tables(0)
            cb_tipo_mant.DisplayMember = "Mant_tipo_descr"
            cb_tipo_mant.ValueMember = "Mant_tipo_id"
            mant_tipo_id = cb_tipo_mant.SelectedValue
            'ahora debo recuperar las periodicidades para el primer tipo que se liste.
            recuperar_periodicidad()
        Else
        End If
    End Sub

    Dim Mant_periodicidad_id As Integer = 0

    Private Sub recuperar_periodicidad()
        Try
            If mant_tipo_id <> 0 Then
                mant_tipo_id = cb_tipo_mant.SelectedValue
                Dim ds_period As DataSet = daMant.Mantenimiento_periodicidad_obtener(mant_tipo_id)
                cb_periodicidad.DataSource = ds_period.Tables(0)
                cb_periodicidad.DisplayMember = "descripcion"
                cb_periodicidad.ValueMember = "Mant_periodicidad_id"
                Mant_periodicidad_id = cb_periodicidad.SelectedValue
                recuperar_tareas()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub recuperar_tareas()

        Try
            If Mant_periodicidad_id <> 0 Then
                Mant_periodicidad_id = cb_periodicidad.SelectedValue
                'aqui llamo al proc alm para recuperar las tareas
                Dim ds_tareas As DataSet = daTareas.Tareas_recuperar_x_periodicidad(Cat2_equipo_id, Mant_periodicidad_id)
                'primero blanqueamos
                Mantenimiento_ds.Tables("Tareas").Rows.Clear()
                Mantenimiento_ds.Tables("Tareas").Merge(ds_tareas.Tables(0))
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cb_tipo_mant_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_tipo_mant.SelectedIndexChanged
        recuperar_periodicidad()
    End Sub

    Private Sub Mantenimiento_config_agregar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_mantenimiento_tipo() 'y aqui tambien se recupera las periodicidades
        fecha.Value = Today
    End Sub

    Private Sub cb_periodicidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_periodicidad.SelectedIndexChanged
        recuperar_tareas()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Try
            If dg_tareas.Rows.Count <> 0 Then
                'ahora controlo que al menos este seleccionada 1
                Dim valido As String = "no"

                Dim i As Integer = 0
                While i < dg_tareas.Rows.Count
                    If dg_tareas.Rows(i).Cells("item").Value = True Then
                        valido = "si"
                        Exit While
                    End If
                    i = i + 1
                End While
                If valido = "si" Then

                    'aqui guardo
                    Dim ds_mant As DataSet = daMant.Mantenimiento_alta(Equipo_id, cb_periodicidad.SelectedValue, fecha.Value.Date, "si")
                    Dim Mantenimiento_id As Integer = ds_mant.Tables(0).Rows(0).Item(0)

                    'ahora guardo las tareas asignadas
                    Dim j As Integer = 0
                    While j < dg_tareas.Rows.Count
                        If dg_tareas.Rows(j).Cells("item").Value = True Then
                            Dim Tareas_id As Integer = dg_tareas.Rows(j).Cells("TareasidDataGridViewTextBoxColumn").Value
                            daMant.Tareas_asignadas_alta(Tareas_id, Mantenimiento_id)
                        End If
                        j = j + 1
                    End While
                    'aqui viene mensaje de confirmacion

                    MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'reflejar los cambios en el formulario Mantenimiento_config_alta
                    Mantenimiento_config_alta.recuperar_info_equipo()
                    Me.Close()
                Else
                    'error
                    MessageBox.Show("Error, debe seleccionar al menos una tarea.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                'error
                MessageBox.Show("Error, debe seleccionar al menos una tarea.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class