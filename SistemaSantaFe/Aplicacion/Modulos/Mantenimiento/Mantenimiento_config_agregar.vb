Public Class Mantenimiento_config_agregar
    Dim daMant As New Datos.Mantenimiento
    Dim daTareas As New Datos.Tareas
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
End Class