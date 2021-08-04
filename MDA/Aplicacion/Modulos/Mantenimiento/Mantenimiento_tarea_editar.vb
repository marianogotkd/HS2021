Public Class Mantenimiento_tarea_editar
    Public Tareas_id As Integer 'este parametro me lo envia el formulario "Mantenimiento_tarea_agregar"
    Public Cat2_equipo_id As Integer 'este parametro me lo envia el formulario "Mantenimiento_tarea_agregar"
    Public tipo As String
    Public subtipo As String
    Public indice_fila As String 'este parametro me lo envia el formulario "Mantenimiento_tarea_agregar"
    Dim DAtareas As New Datos.Tareas



    Private Sub bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bo_guardar.Click

        If txt_tarea.Text <> "" Then
            'tengo que validar que no exista una tarea con esa descripcion para ese subtipo especifico.
            Dim ds_validar As DataSet = DAtareas.Tareas_validar(txt_tarea.Text, Cat2_equipo_id)
            Dim valido As String = "si"
            If ds_validar.Tables(0).Rows.Count = 0 Then
                'es valido
            Else
                If (ds_validar.Tables(0).Rows(0).Item("Tareas_desc") = txt_tarea.Text) And (ds_validar.Tables(0).Rows(0).Item("Tareas_id") = Tareas_id) Then
                    'es valido
                Else
                    valido = "no"
                End If
            End If
            If valido = "si" Then
                DAtareas.Tareas_modificar(Tareas_id, txt_tarea.Text)
                'ahora lo actualizo en el gridview del formulario "Mantenimiento_tarea_agregar"

                Dim i As Integer = 0
                While i < Mantenimiento_tarea_agregar.Mantenimiento_ds.Tables("Tareas").Rows.Count
                    If Cat2_equipo_id = Mantenimiento_tarea_agregar.Mantenimiento_ds.Tables("Tareas").Rows(i).Item("Cat2_equipo_id") Then
                        If Tareas_id = Mantenimiento_tarea_agregar.Mantenimiento_ds.Tables("Tareas").Rows(i).Item("Tareas_id") Then
                            'aqui lo actualizo
                            Mantenimiento_tarea_agregar.Mantenimiento_ds.Tables("Tareas").Rows(i).Item("Tareas_desc") = txt_tarea.Text
                            Exit While
                        End If
                    End If
                    i = i + 1
                End While
                Me.Close()
            Else
                MessageBox.Show("Error, ya existe una tarea definida para el tipo: " + tipo + ", subtipo: " + subtipo + ". Por favor modifique la descripción.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_tarea.SelectAll()
                txt_tarea.Focus()
            End If
        Else
            MessageBox.Show("Error, el campo esta vacio. Por favor complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_tarea.SelectAll()
            txt_tarea.Focus()
        End If
    End Sub
End Class