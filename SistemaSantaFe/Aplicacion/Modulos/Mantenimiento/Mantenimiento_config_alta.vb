Public Class Mantenimiento_config_alta
    Dim DAequipo As New Datos.Equipo
    Public Equipo_id As Integer 'me lo envia el formulario "Equipo_consulta.vb"
    Dim Cat2_equipo_id As Integer = 0 'cuando recupere la info del equipo lo cargo con un valor válido


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Mantenimiento_config_agregar.Close()

        Mantenimiento_config_agregar.Cat2_equipo_id = Cat2_equipo_id
        Mantenimiento_config_agregar.Equipo_id = Equipo_id


        Mantenimiento_config_agregar.Show()
    End Sub

    Private Sub Mantenimiento_config_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'recupero la info del equipo
        recuperar_info_equipo()

    End Sub

    Public Sub recuperar_info_equipo()
        Try
            Dim ds_equipo As DataSet = DAequipo.Equipo_obtener_info(Equipo_id)
            txt_equipo.Text = ds_equipo.Tables(0).Rows(0).Item("Equipo_descripcion")
            txt_sector.Text = ds_equipo.Tables(0).Rows(0).Item("Cliente_suc_sector_descripcion")
            txt_etiqueta.Text = ds_equipo.Tables(0).Rows(0).Item("etiqueta")
            txt_categoria.Text = ds_equipo.Tables(0).Rows(0).Item("categoria")
            Cat2_equipo_id = ds_equipo.Tables(0).Rows(0).Item("Equipo_idcat")
            recuperar_mantenimientos_del_equipo(ds_equipo)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub recuperar_mantenimientos_del_equipo(ByVal ds_equipo As DataSet)
        Mantenimiento_ds.Tables("Mantenimiento_prog").Rows.Clear()
        Mantenimiento_ds.Tables("Tareas_asignadas").Rows.Clear()
        Try
            If ds_equipo.Tables(1).Rows.Count <> 0 Then
                Mantenimiento_ds.Tables("Mantenimiento_prog").Merge(ds_equipo.Tables(1))
                Mantenimiento_ds.Tables("Tareas_asignadas").Merge(ds_equipo.Tables(2))
                If Mantenimiento_ds.Tables("Mantenimiento_prog").Rows.Count <> 0 Then
                    aplicar_filtro_tareas(Mantenimiento_ds.Tables("Mantenimiento_prog").Rows(0).Item("Mantenimiento_id"))
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub aplicar_filtro_tareas(ByVal Mantenimiento_id As Integer)
        Dim Filtro
        'Filtro = String.Format("{0} LIKE '%{1}%'", "Mantenimiento_id", CStr(Mantenimiento_id)) 'esto para campos strings, FUNCIONA PERFECTO
        Filtro = String.Format("CONVERT(Mantenimiento_id, System.String) LIKE '%{0}%'", CStr(Mantenimiento_id)) 'esto para campos strings, FUNCIONA PERFECTO

        TareasasignadasBindingSource.Filter = Filtro
    End Sub

    Private Sub DG_clientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_clientes.Click
        If Mantenimiento_ds.Tables("Mantenimiento_prog").Rows.Count <> 0 Then
            aplicar_filtro_tareas(DG_clientes.CurrentRow.Cells("MantenimientoidDataGridViewTextBoxColumn").Value)
        End If
    End Sub

    Private Sub DG_clientes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_clientes.SelectionChanged
        If Mantenimiento_ds.Tables("Mantenimiento_prog").Rows.Count <> 0 Then
            aplicar_filtro_tareas(DG_clientes.CurrentRow.Cells("MantenimientoidDataGridViewTextBoxColumn").Value)
        End If
    End Sub
End Class