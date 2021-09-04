Public Class Mantenimiento_tarea_agregar
    Dim daMant As New Datos.Mantenimiento
    Dim Dacategorias As New Datos.Equipos_categorias
    Dim mant_tipo_id As Integer = 0
    Dim DAtareas As New Datos.Tareas
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
    Private Sub recuperar_periodicidad()
        Try
            If mant_tipo_id <> 0 Then
                mant_tipo_id = cb_tipo_mant.SelectedValue
                Dim ds_period As DataSet = daMant.Mantenimiento_periodicidad_obtener(mant_tipo_id)
                cb_periodicidad.DataSource = ds_period.Tables(0)
                cb_periodicidad.DisplayMember = "descripcion"
                cb_periodicidad.ValueMember = "Mant_periodicidad_id"
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Dim cat1_id As Integer = 0
    Public Sub recuperar_categorias_equipo()
        Dim ds_cat As DataSet = Dacategorias.Equipo_categorias_recuperartodo
        If ds_cat.Tables(0).Rows.Count <> 0 Then
            cb_tipo.DataSource = ds_cat.Tables(0)
            cb_tipo.DisplayMember = "Cat1_equipo_desc"
            cb_tipo.ValueMember = "Cat1_equipo_id"
            cat1_id = cb_tipo.SelectedValue
            recuperar_subtipo()
        End If
    End Sub
    Private Sub recuperar_subtipo()
        If cat1_id <> 0 Then
            cat1_id = cb_tipo.SelectedValue 'se vuelve a seleccionar el actual
            Dim ds_subtipo As DataSet = Dacategorias.Equipo_categoria1_y_2_recuperar(cat1_id)
            If ds_subtipo.Tables(1).Rows.Count <> 0 Then
                cb_subtipo.DataSource = ds_subtipo.Tables(1)
                cb_subtipo.DisplayMember = "descripcion"
                cb_subtipo.ValueMember = "Cat2_equipo_id"
            Else

            End If
        End If
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'si hago click aqui debo recuperar la cateogira y mostrar los periodos q ya estan cargados en la bd
        Mantenimiento_tipo_alta.Close()
        Mantenimiento_tipo_alta.procedencia = "mantenimiento_tarea_agregar"
        Mantenimiento_tipo_alta.op = "modificar"
        Mantenimiento_tipo_alta.Mant_tipo_id = CInt(cb_tipo_mant.SelectedValue)
        Mantenimiento_tipo_alta.Text = "Modificar tipo de mantenimiento y periodicidades."
        Mantenimiento_tipo_alta.Show()
    End Sub

    Private Sub Bo_nuevosector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_nuevosector.Click
        Mantenimiento_tipo_alta.Close()

        Mantenimiento_tipo_alta.procedencia = "mantenimiento_tarea_agregar"

        Mantenimiento_tipo_alta.Show()

    End Sub
    Dim listo As String = "no"
    Private Sub Mantenimiento_tarea_agregar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LABEL_EQUIPO_CAT.Text = ""
        recuperar_categorias_equipo()
        recuperar_mantenimiento_tipo()
        recuperar_tareas_existentes()
        listo = "si"
        aplicar_filtro_tareas()

    End Sub

    Private Sub cb_tipo_mant_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_tipo_mant.SelectedIndexChanged
        recuperar_periodicidad()
        aplicar_filtro_tareas()
    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_tipo.SelectedIndexChanged
        recuperar_subtipo()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pregunta = ""
        If MsgBox("¿Esta seguro que quiere agregar la nueva tarea?. Los datos se actualizarán inmeditamente.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
            pregunta = "si"
        Else
            pregunta = "no"
        End If

        If pregunta = "si" Then
            'validamos
            If txt_descripcion.Text <> "" Then
                If cb_tipo.Items.Count <> 0 And cb_tipo_mant.Items.Count <> 0 Then
                    'ahora valido que no exista una tarea con ese nombre, para esa categoria y para ese tipo de mantenimiento.
                    'Dim ds_validar As DataSet = DAtareas.Tareas_validar(txt_descripcion.Text, cb_subtipo.SelectedValue)
                    'If ds_validar.Tables(0).Rows.Count = 0 Then

                    DAtareas.Tareas_alta(txt_descripcion.Text, cb_subtipo.SelectedValue, cb_periodicidad.SelectedValue)
                    txt_descripcion.Clear()
                    'aqui tengo q actualizar la grilla de la derecha.
                    recuperar_tareas_existentes()
                    aplicar_filtro_tareas()
                    MessageBox.Show("Se agregó correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    'Else
                    '    MessageBox.Show("Error, ya existe una tarea definida para el tipo: " + cb_tipo.Text + ", subtipo: " + cb_subtipo.Text + ". Por favor modifique la descripción.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '    txt_descripcion.SelectAll()
                    '    txt_descripcion.Focus()
                    'End If
                Else
                    If cb_tipo.Items.Count = 0 Then
                        MessageBox.Show("Error, debe definir el tipo de mantenimiento.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    If cb_tipo_mant.Items.Count = 0 Then
                        MessageBox.Show("Error, debe definir la categoría de equipos.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else
                MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_descripcion.SelectAll()
                txt_descripcion.Focus()
            End If


        End If



    End Sub

    Dim column1 As New AutoCompleteStringCollection
    Private Sub recuperar_tareas_existentes()
        Mantenimiento_ds.Tables("Tareas").Rows.Clear()
        Dim ds_tareas As DataSet = DAtareas.Tareas_obtener_todo()

        If ds_tareas.Tables(0).Rows.Count <> 0 Then
            Mantenimiento_ds.Tables("Tareas").Merge(ds_tareas.Tables(0))

            Mantenimiento_ds.Tables("Tareas_autocomplete").Rows.Clear()
            'tambien voy a llenar la tabla "Tareas_autcomplete" para q pueda sugerir tareas en el textbox
            Dim i As Integer = 0

            While i < ds_tareas.Tables(0).Rows.Count
                Dim fila As DataRow = Mantenimiento_ds.Tables("Tareas_autocomplete").NewRow
                fila("Tareas") = ds_tareas.Tables(0).Rows(i).Item("Tareas_desc").ToString
                Mantenimiento_ds.Tables("Tareas_autocomplete").Rows.Add(fila)
                column1.Add(ds_tareas.Tables(0).Rows(i).Item("Tareas_desc").ToString())
                i = i + 1
            End While
            txt_descripcion.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_descripcion.AutoCompleteCustomSource = column1
            txt_descripcion.AutoCompleteMode = AutoCompleteMode.Suggest
        End If
    End Sub



    Private Sub aplicar_filtro_tareas()
        Try
            If listo = "si" Then
                If cb_tipo.Items.Count <> 0 And cb_subtipo.Items.Count <> 0 Then
                    GroupBox5.Text = "TAREAS CREADAS PARA LA CATEGORÍA: "
                    LABEL_EQUIPO_CAT.Text = CStr(cb_tipo.Text.ToUpper) + ", " + CStr(cb_subtipo.Text.ToUpper) + "."
                    LABEL_EQUIPO_CAT.ForeColor = Color.Blue
                Else
                    GroupBox5.Text = "TAREAS CREADAS PARA LA CATEGORÍA: "
                    LABEL_EQUIPO_CAT.Text = ""
                    LABEL_EQUIPO_CAT.ForeColor = Color.Blue
                End If

                Dim filtro2
                filtro2 = String.Format("CONVERT(Mant_tipo_id, System.String) LIKE '%{0}%'", cb_tipo_mant.SelectedValue) 'esto para campos strings, FUNCIONA PERFECTO


                Dim Filtro
                Filtro = String.Format("CONVERT(Cat2_equipo_id, System.String) LIKE '%{0}%'", cb_subtipo.SelectedValue) 'esto para campos strings, FUNCIONA PERFECTO

                'Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_Fan", cb_subtipo.SelectedValue) 'esto para campos strings, FUNCIONA PERFECTO
                'TareasBindingSource.Filter = Filtro

                Dim tipo_mant As String = cb_tipo_mant.SelectedValue.ToString
                Dim tipo As String = cb_subtipo.SelectedValue.ToString

                Dim periodicidad As String = cb_periodicidad.SelectedValue.ToString

                Dim filtro_choco As String = "Mant_tipo_id ='" & tipo_mant & "'" & " and Cat2_equipo_id ='" & tipo & "'" & " and Mant_periodicidad_id ='" & periodicidad & "'"


                'TareasBindingSource.Filter = "CONVERT(Mant_tipo_id, System.String) = '" & tipo_mant & "' AND CONVERT(Cat2_equipo_id,System.String) = " & tipo 'este anda y filtra por tipo mant y tipo de categoria
                TareasBindingSource.Filter = filtro_choco


            End If
        Catch ex As Exception

        End Try


    End Sub


    Private Sub cb_subtipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_subtipo.SelectedIndexChanged
        aplicar_filtro_tareas()
    End Sub

    Private Sub dg_atributos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_atributos.Click
        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If dg_atributos.Rows.Count <> 0 Then

            Dim i As Integer = 0
            While i < dg_atributos.Rows.Count
                If dg_atributos.Rows(i).Cells("item").Value = True Then
                    dg_atributos.Rows(i).Cells("item").Value = False
                End If
                i = i + 1
            End While
            'ahora solo tildo el actual
            dg_atributos.CurrentRow.Cells("item").Value = True
            'End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'entonce recorro el gridview.
            Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
            Dim valido_seleccion As String = "no"
            If dg_atributos.Rows.Count <> 0 Then
                Dim i As Integer = 0
                While i < dg_atributos.Rows.Count
                    If dg_atributos.Rows(i).Cells("item").Value = True Then 'el value en true significa que esta checkeado para eliminar
                        If pregunta = "no" Then
                            valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                            If MsgBox("¿Esta seguro que quiere eliminar el item seleccionado?. Los datos se actualizarán inmediatamente.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                                pregunta = "si"
                            Else
                                'aqui corto el ciclo, ya que se cancelo la eliminacion
                                i = dg_atributos.Rows.Count
                            End If
                        End If
                        If pregunta = "si" Then
                            'primero guardo el nro de item q contiene
                            Dim item As Decimal = dg_atributos.CurrentRow.Index
                            'valido eso de las 2 opciones que detalle arriba

                            'aqui lo elimino de la bd
                            Dim tareas_id As Integer = dg_atributos.Rows(i).Cells("TareasidDataGridViewTextBoxColumn").Value
                            DAtareas.Tareas_eliminar(tareas_id)
                            dg_atributos.Rows.RemoveAt(i)

                            'aqui tengo q actualizar la grilla de la derecha.
                            recuperar_tareas_existentes()
                            aplicar_filtro_tareas()


                            i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices
                        End If
                    Else
                        i = i + 1
                    End If

                End While

                If pregunta = "si" Then
                    MessageBox.Show("Eliminación correcta, los datos fueron actualizados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                If valido_seleccion = "no" Then
                    MessageBox.Show("Seleccione una item para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("No hay items disponibles.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If dg_atributos.Rows.Count <> 0 Then
            Mantenimiento_tarea_editar.Close()
            Dim tarea_id As Integer = dg_atributos.CurrentRow.Cells("TareasidDataGridViewTextBoxColumn").Value
            Mantenimiento_tarea_editar.Tareas_id = tarea_id
            Mantenimiento_tarea_editar.Cat2_equipo_id = dg_atributos.CurrentRow.Cells("Cat2equipoidDataGridViewTextBoxColumn").Value
            Mantenimiento_tarea_editar.txt_tarea.Text = dg_atributos.CurrentRow.Cells("TareasdescDataGridViewTextBoxColumn").Value
            Mantenimiento_tarea_editar.tipo = dg_atributos.CurrentRow.Cells("TipoDataGridViewTextBoxColumn").Value
            Mantenimiento_tarea_editar.subtipo = dg_atributos.CurrentRow.Cells("SubtipoDataGridViewTextBoxColumn").Value
            Mantenimiento_tarea_editar.Show()
        Else
            MessageBox.Show("Debe seleccionar una tarea para editar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Mantenimiento_tarea_agregar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If cb_tipo.Items.Count = 0 Then
            MessageBox.Show("Error, no se encontraron categorías de equipo. Para acceder a la configuración de mantenimientos es necesario tener configuradas las categorías de equipo. Por favor ingrese al módulo correspondiente para dar de alta.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub


    Private Sub cb_periodicidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_periodicidad.SelectedIndexChanged
        aplicar_filtro_tareas()
    End Sub

    Private Sub txt_descripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descripcion.KeyPress
        'Dim cadena_tipeada As String = txt_descripcion.Text

        'Dim i As Integer = 0

        'While i < dg_atributos.Rows.Count

        '    Dim x = InStr(1, dg_atributos.Rows(i).Cells("TareasdescDataGridViewTextBoxColumn").Value.ToString.ToUpper, cadena_tipeada.ToUpper)


        '    If x = 1 Then
        '        dg_atributos.Rows(i).Selected = True
        '        Exit While

        '    End If

        '    'If dg_atributos.Rows(i).Cells("TareasdescDataGridViewTextBoxColumn").Value.ToString.ToUpper = cadena_tipeada.ToUpper Then
        '    '    dg_atributos.Rows(i).Selected = True
        '    '    Exit While
        '    'End If
        '    i = i + 1
        'End While
    End Sub

    Private Sub txt_descripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_descripcion.LostFocus
        Button1.Focus()
    End Sub

    Private Sub txt_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        Dim cadena_tipeada As String = txt_buscar.Text

        Dim i As Integer = 0

        While i < dg_atributos.Rows.Count

            Dim x = InStr(1, dg_atributos.Rows(i).Cells("TareasdescDataGridViewTextBoxColumn").Value.ToString.ToUpper, cadena_tipeada.ToUpper)


            If x = 1 Then
                dg_atributos.Rows(i).Selected = True
                Exit While

            End If

            'If dg_atributos.Rows(i).Cells("TareasdescDataGridViewTextBoxColumn").Value.ToString.ToUpper = cadena_tipeada.ToUpper Then
            '    dg_atributos.Rows(i).Selected = True






            '    Exit While
            'End If
            i = i + 1
        End While

    End Sub
End Class