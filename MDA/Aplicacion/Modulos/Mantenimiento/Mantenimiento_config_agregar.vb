Public Class Mantenimiento_config_agregar
    Dim daMant As New Datos.Mantenimiento
    Dim daTareas As New Datos.Tareas
    Public Equipo_id As Integer = 0 'me lo envia el form mantenimiento_config_alta
    Public mant_tipo_id As Integer = 0
    Public Cat2_equipo_id As Integer 'esta es el subtipo para recuperar todas las tareas

    '*********************variables que uso si la procedencia es "modificar"******************************

    Public procedencia As String = ""
    Public modif_Mant_tipo_id As Integer = 0
    Public modif_Mant_periodicidad_id As Integer = 0
    Public mantenimiento_id As Integer = 0
    '*****************************************************************************************************



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
            'es alta
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


        If procedencia = "modificar" Then
            'selecciono el tipo de mantenimiento
            cb_tipo_mant.SelectedValue = modif_Mant_tipo_id
            'selecciono la periodicidad
            cb_periodicidad.SelectedValue = modif_Mant_periodicidad_id

            'cb_tipo_mant.Enabled = False
            'cb_periodicidad.Enabled = False


            'chequeo en la grilla las tareas que ya estaban asignadas.
            Dim i As Integer = 0
            While i < Mantenimiento_config_alta.DataGridView1.Rows.Count
                Dim tareas_id As Integer = CInt(Mantenimiento_config_alta.DataGridView1.Rows(i).Cells("TareasidDataGridViewTextBoxColumn").Value)
                Dim j As Integer = 0
                While j < dg_tareas.Rows.Count
                    If dg_tareas.Rows(j).Cells("TareasidDataGridViewTextBoxColumn").Value = tareas_id Then
                        dg_tareas.Rows(j).Cells("item").Value = True
                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
        Else
            fecha.Value = Today
        End If


    End Sub

    Private Sub cb_periodicidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_periodicidad.SelectedIndexChanged
        recuperar_tareas()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'Try
        If dg_tareas.Rows.Count <> 0 Then
            'ahora controlo que al menos este seleccionada 1
            Dim valido As String = "no"

            If fecha.Value.DayOfWeek <> DayOfWeek.Saturday And fecha.Value.DayOfWeek <> DayOfWeek.Sunday Then





                Dim i As Integer = 0
                While i < dg_tareas.Rows.Count
                    If dg_tareas.Rows(i).Cells("item").Value = True Then
                        valido = "si"
                        Exit While
                    End If
                    i = i + 1
                End While

                'por ultimo validar que no exista un mantenimiento programado.
                Dim validar_mant_programado As String = "no existe"
                Dim periodicidad_id As Integer = CInt(cb_periodicidad.SelectedValue)
                Dim tipo_mantenimiento_id As Integer = CInt(cb_tipo_mant.SelectedValue)
                'Equipo_id 'este es el equipo que voy a validar
                Dim j As Integer = 0
                While j < dg_tareas.Rows.Count
                    'j = j + 1
                    Dim tareas_id As Integer = dg_tareas.Rows(j).Cells("TareasidDataGridViewTextBoxColumn").Value
                    Dim k As Integer = 0
                    While k < Mantenimiento_config_alta.Mantenimiento_ds.Tables("Tareas_asignadas").Rows.Count
                        'busco la tarea
                        If tareas_id = Mantenimiento_config_alta.Mantenimiento_ds.Tables("Tareas_asignadas").Rows(k).Item("Tareas_id") Then
                            'lo encontre, ahora controlo.
                            Dim mantenimiento_id_ss As Integer = Mantenimiento_config_alta.Mantenimiento_ds.Tables("Tareas_asignadas").Rows(k).Item("Mantenimiento_id")
                            'ahora lo busco en el otro gridview. el de la izquierda
                            Dim h As Integer = 0
                            While h < Mantenimiento_config_alta.Mantenimiento_ds.Tables("Mantenimiento_prog").Rows.Count
                                If mantenimiento_id_ss = Mantenimiento_config_alta.Mantenimiento_ds.Tables("Mantenimiento_prog").Rows(h).Item("Mantenimiento_id") Then
                                    Dim fecha_a As Date = Mantenimiento_config_alta.Mantenimiento_ds.Tables("Mantenimiento_prog").Rows(h).Item("Mantenimiento_fecha_inicio")
                                    Dim tipo_mant_id_a As Integer = Mantenimiento_config_alta.Mantenimiento_ds.Tables("Mantenimiento_prog").Rows(h).Item("Mant_tipo_id")
                                    Dim periodicidad_id_a As Integer = Mantenimiento_config_alta.Mantenimiento_ds.Tables("Mantenimiento_prog").Rows(h).Item("Mant_periodicidad_id")
                                    If (fecha.Value.Date = fecha_a) And (tipo_mant_id_a = tipo_mantenimiento_id) And (periodicidad_id = periodicidad_id_a) Then
                                        If procedencia = "modificar" Then
                                            If mantenimiento_id = mantenimiento_id_ss Then
                                                'si estoy modificando no me importa que exista.
                                            Else
                                                validar_mant_programado = "existe, encontrado"
                                                valido = "no"
                                            End If

                                        Else
                                            validar_mant_programado = "existe, encontrado"
                                            valido = "no"
                                        End If

                                        Exit While
                                    End If
                                End If
                                h = h + 1
                            End While
                        End If
                        If validar_mant_programado = "no existe" Then
                            k = k + 1
                        Else
                            Exit While
                        End If
                    End While
                    If validar_mant_programado = "no existe" Then
                        j = j + 1
                    Else
                        Exit While
                    End If
                End While
                If valido = "si" Then

                    If procedencia = "modificar" Then
                        'voy a hacer un borrado lógico. cambiando el estado del campo mantenimiento_activo en la base de datos.
                        daMant.Mantenimiento_quitar(mantenimiento_id)
                    End If

                    'aqui guardo
                    Dim ds_mant As DataSet = daMant.Mantenimiento_alta(Equipo_id, cb_periodicidad.SelectedValue, fecha.Value.Date, "si")
                    mantenimiento_id = ds_mant.Tables(0).Rows(0).Item(0)

                    'ahora guardo las tareas asignadas
                    Dim jj As Integer = 0
                    While jj < dg_tareas.Rows.Count
                        If dg_tareas.Rows(jj).Cells("item").Value = True Then
                            Dim Tareas_id As Integer = dg_tareas.Rows(jj).Cells("TareasidDataGridViewTextBoxColumn").Value
                            daMant.Tareas_asignadas_alta(Tareas_id, mantenimiento_id)
                        End If
                        jj = jj + 1
                    End While
                    'aqui viene mensaje de confirmacion

                    MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'reflejar los cambios en el formulario Mantenimiento_config_alta
                    Mantenimiento_config_alta.recuperar_info_equipo()
                    Me.Close()
                Else
                    'error
                    If validar_mant_programado = "existe, encontrado" Then
                        MessageBox.Show("Error, ya se encuentra programado un mantenimiento con las mismas caracteristicas. Las tareas no seran guardadas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Error, debe seleccionar al menos una tarea.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                'error
                MessageBox.Show("Error, modifique la fecha, no debe ser fin de semana.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            'error
            MessageBox.Show("Error, debe seleccionar al menos una tarea.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Catch ex As Exception

        'End Try

    End Sub
End Class