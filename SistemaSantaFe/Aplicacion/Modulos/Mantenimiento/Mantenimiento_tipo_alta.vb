Public Class Mantenimiento_tipo_alta
    Dim daMant As New Datos.Mantenimiento
    Public op As String = "alta"
    Public procedencia As String = ""
    Public Mant_tipo_id As Integer 'este valor me lo envia el form mantenmiento_tarea_Agregar u otro aun por definir
    Private Sub Mantenimiento_tipo_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If op = "modificar" Then
            'recupero datos del tipo d emantenimiento
            Dim ds_info As DataSet = daMant.Mantenimiento_periodicidad_obtener(Mant_tipo_id)
            Try
                txt_descripcion.Text = ds_info.Tables(1).Rows(0).Item("Mant_tipo_descr")
            Catch ex As Exception
            End Try
            'recuper las periodicidas para ese tipo de mantenimiento
            Mantenimiento_ds.Tables("periodicidad").Merge(ds_info.Tables(2))
        End If
    End Sub






    Private Sub Bo_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txt_descripcion.Text <> "" Then
            'ahora valido
            Dim ds_validar As DataSet = daMant.Mantenimiento_tipo_validar(txt_descripcion.Text)
            If ds_validar.Tables(0).Rows.Count = 0 Then
                'no existe, guardo
                daMant.Mantenimiento_tipo_alta(txt_descripcion.Text)
                'ahora cierro y reflejo cambios en el combo del formulario mantenimiento_tarea_agregar



                Me.Close()
            Else
                MessageBox.Show("Error, ya existe un tipo de mantenimiento con esa descripción. Por favor ingrese nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_descripcion.SelectAll()
                txt_descripcion.Focus()
            End If

        Else
            MessageBox.Show("Error, ingrese la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                            )
            txt_descripcion.SelectAll()
            txt_descripcion.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_periodicidad_desc.Text <> "" Then
            'continuo validando
            If txt_dias.Text <> 0 Then
                'validamos que no exista ya con esa descripcion
                Dim valido As String = "si"
                Dim i As Integer = 0
                While i < Mantenimiento_ds.Tables("periodicidad").Rows.Count
                    If Mantenimiento_ds.Tables("periodicidad").Rows(i).Item("Mant_periodicidad_desc").ToString.ToUpper = txt_periodicidad_desc.Text.ToUpper Then
                        valido = "no"
                        Exit While
                    End If
                    i = i + 1
                End While

                If valido = "si" Then
                    Dim fila As DataRow = Mantenimiento_ds.Tables("periodicidad").NewRow
                    fila("Mant_periodicidad_id") = 0
                    fila("Mant_periodicidad_desc") = txt_periodicidad_desc.Text
                    fila("Mant_periodicidad_dias") = CInt(txt_dias.Text)
                    fila("Estado") = "nuevo"
                    Mantenimiento_ds.Tables("periodicidad").Rows.Add(fila)
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DG_PERIODICIDAD.Rows.Count <> 0 Then
            Mantenimiento_tipo_editar.Close()
            Dim indice As Integer = DG_PERIODICIDAD.CurrentRow.Index
            Mantenimiento_tipo_editar.indice = indice
            Mantenimiento_tipo_editar.txt_periodicidad_desc.Text = DG_PERIODICIDAD.CurrentRow.Cells("MantperiodicidaddescDataGridViewTextBoxColumn").Value
            Mantenimiento_tipo_editar.txt_dias.Value = DG_PERIODICIDAD.CurrentRow.Cells("MantperiodicidaddiasDataGridViewTextBoxColumn").Value
            Mantenimiento_tipo_editar.Show()
        Else
            MessageBox.Show("Error, no hay items disponibles para editar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub DG_PERIODICIDAD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_PERIODICIDAD.Click
        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If DG_PERIODICIDAD.Rows.Count <> 0 Then
            
            Dim i As Integer = 0
            While i < DG_PERIODICIDAD.Rows.Count
                If DG_PERIODICIDAD.Rows(i).Cells("item").Value = True Then
                    DG_PERIODICIDAD.Rows(i).Cells("item").Value = False
                End If
                i = i + 1
            End While
            'ahora solo tildo el actual
            DG_PERIODICIDAD.CurrentRow.Cells("item").Value = True
            'End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'entonce recorro el gridview.
            Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
            Dim valido_seleccion As String = "no"
            If DG_PERIODICIDAD.Rows.Count <> 0 Then
                Dim i As Integer = 0
                While i < DG_PERIODICIDAD.Rows.Count
                    If DG_PERIODICIDAD.Rows(i).Cells("item").Value = True Then 'el value en true significa que esta checkeado para eliminar
                        If pregunta = "no" Then
                            valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                            If MsgBox("¿Esta seguro que quiere eliminar el item seleccionado?. Los datos se actualizarán inmeditamente.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                                pregunta = "si"
                            Else
                                'aqui corto el ciclo, ya que se cancelo la eliminacion
                                i = DG_PERIODICIDAD.Rows.Count
                            End If
                        End If
                        If pregunta = "si" Then
                            'primero guardo el nro de item q contiene
                            Dim item As Decimal = DG_PERIODICIDAD.CurrentRow.Index
                            'valido eso de las 2 opciones que detalle arriba
                            Dim estado As String = DG_PERIODICIDAD.Rows(i).Cells("EstadoDataGridViewTextBoxColumn").Value
                            If estado = "nuevo" Then
                                'no esta guardado en bd, asi que solo quito
                            Else
                                'si esta en bd, entonces lo elimino
                                daMant.Mantenimiento_periodicidad_eliminar(DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidadidDataGridViewTextBoxColumn").Value)
                                'DAcliente.Cliente_Sucursales_eliminar(CInt(DG_Servicio.Rows(i).Cells("SucxClieidDataGridViewTextBoxColumn").Value), "ELIMINADO")
                            End If
                            DG_PERIODICIDAD.Rows.RemoveAt(i)
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

    Private Sub bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bo_guardar.Click
        If op = "alta" Then
            If txt_descripcion.Text <> "" Then
                If DG_PERIODICIDAD.Rows.Count <> 0 Then
                    'valido que no exista un mantenimiento con esa descripcion
                    Dim ds_validar As DataSet = daMant.Mantenimiento_tipo_validar(txt_descripcion.Text)
                    If ds_validar.Tables(0).Rows.Count = 0 Then
                        'no existe, guardo
                        Dim ds_mant As DataSet = daMant.Mantenimiento_tipo_alta(txt_descripcion.Text)
                        Dim Mant_tipo_id As Integer = ds_mant.Tables(0).Rows(0).Item("Mant_tipo_id")
                        'ahora guardo los periodos
                        'supuestamente ya tengo todo validado, no deberia haber 2 igual.
                        Dim i As Integer = 0
                        While i < DG_PERIODICIDAD.Rows.Count
                            daMant.Mantenimiento_periodicidad_alta(DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidaddescDataGridViewTextBoxColumn").Value,
                                                                   DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidaddiasDataGridViewTextBoxColumn").Value,
                                                                   Mant_tipo_id)

                            i = i + 1
                        End While



                        MessageBox.Show("Los datos fueron guardados correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'voy a recuperar para mostrarlos dependiendo si abro este formulario desde ahi.
                        If procedencia = "mantenimiento_tarea_agregar" Then
                            Mantenimiento_tarea_agregar.recuperar_mantenimiento_tipo()
                            'Mantenimiento_tarea_agregar.Show()
                        End If
                        Me.Close()
                    Else
                        MessageBox.Show("Error, ya existe un tipo de mantenimiento con esa descripción. Por favor ingrese nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt_descripcion.SelectAll()
                        txt_descripcion.Focus()
                    End If
                Else
                    MessageBox.Show("Error, debe ingresar al menos una periodicidad. Por favor complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_periodicidad_desc.SelectAll()
                    txt_periodicidad_desc.Focus()
                End If
            Else
                MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_descripcion.SelectAll()
                txt_descripcion.Focus()
            End If
        End If

        If op = "modificar" Then
            modificar()
        End If
    End Sub

    Private Sub modificar()
        If txt_descripcion.Text <> "" Then
            If DG_PERIODICIDAD.Rows.Count <> 0 Then
                'valido que no exista un mantenimiento con esa descripcion
                Dim ds_validar As DataSet = daMant.Mantenimiento_tipo_validar(txt_descripcion.Text)
                Dim valido = "si"
                If ds_validar.Tables(0).Rows.Count = 0 Then

                Else
                    'ahora veo si el que encontro es el mismo propio o bien otro registro
                    If ds_validar.Tables(0).Rows(0).Item("Mant_tipo_id") <> Mant_tipo_id Then
                        valido = "no"
                    End If
                End If


                If valido = "si" Then
                    'no existe, guardo
                    Dim ds_mant As DataSet = daMant.Mantenimiento_tipo_modificar(Mant_tipo_id, txt_descripcion.Text)

                    'ahora guardo los periodos
                    'supuestamente ya tengo todo validado, no deberia haber 2 igual.
                    Dim i As Integer = 0
                    While i < DG_PERIODICIDAD.Rows.Count
                        If DG_PERIODICIDAD.Rows(i).Cells("EstadoDataGridViewTextBoxColumn").Value = "nuevo" Then
                            daMant.Mantenimiento_periodicidad_alta(DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidaddescDataGridViewTextBoxColumn").Value,
                                                               DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidaddiasDataGridViewTextBoxColumn").Value,
                                                               Mant_tipo_id)
                            
                        End If

                        If DG_PERIODICIDAD.Rows(i).Cells("EstadoDataGridViewTextBoxColumn").Value = "editado" Then
                            'aqui hago el update
                            Dim Mant_periodicidad_id As Integer = DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidadidDataGridViewTextBoxColumn").Value
                            daMant.Mantenimiento_periodicidad_modificar(Mant_periodicidad_id, DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidaddescDataGridViewTextBoxColumn").Value,
                                                                        DG_PERIODICIDAD.Rows(i).Cells("MantperiodicidaddiasDataGridViewTextBoxColumn").Value)
                        End If

                        i = i + 1
                    End While
                    MessageBox.Show("Los datos fueron guardados correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'voy a recuperar para mostrarlos dependiendo si abro este formulario desde ahi.
                    If procedencia = "mantenimiento_tarea_agregar" Then
                        Mantenimiento_tarea_agregar.recuperar_mantenimiento_tipo()
                        'Mantenimiento_tarea_agregar.Show()
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("Error, ya existe un tipo de mantenimiento con esa descripción. Por favor ingrese nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_descripcion.SelectAll()
                    txt_descripcion.Focus()
                End If
            Else
                MessageBox.Show("Error, debe ingresar al menos una periodicidad. Por favor complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_periodicidad_desc.SelectAll()
                txt_periodicidad_desc.Focus()
            End If
        Else
            MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_descripcion.SelectAll()
            txt_descripcion.Focus()
        End If


    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        Me.Close()
    End Sub


End Class