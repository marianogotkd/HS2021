Public Class Equipo_nuevo
    Dim DAsector As New Datos.Sucursal_sector
    Dim Dacategorias As New Datos.Equipos_categorias
    Public SucxClie_id As Integer ' me lo envia el formulario equipo_consulta
    Public procedencia As String 'me indica si es un alta o modificacion, me lo envia el formulario equipo_consulta
    Public Equipo_id As Integer = 0 'me lo envia el formulario equipo_consulta si la procedencia es modificar
    Dim DAequipo As New Datos.Equipo

    Public Sub recuperar_sectores()
        Dim ds_sector As DataSet = DAsector.Cliente_suc_sector_recuperar_todos(SucxClie_id)
        If ds_sector.Tables(0).Rows.Count <> 0 Then

            cb_sector.DataSource = ds_sector.Tables(0)
            cb_sector.DisplayMember = "Cliente_suc_sector_descripcion"
            cb_sector.ValueMember = "Cliente_suc_sector_id"
        End If
    End Sub

    Private Sub Equipo_nuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_sectores()
        recuperar_categorias()

        If procedencia = "alta" Then
        Else
            If procedencia = "modificar" Then
                'recupero la info del equipo y selecciono los combos que correspondan.
                recuperar_info_equipo()
            End If
        End If

    End Sub

    Private Sub recuperar_info_equipo()
        Try
            Dim ds_info As DataSet = DAequipo.Equipo_recuperar_info(Equipo_id)
            txt_equipo_descripcion.Text = ds_info.Tables(0).Rows(0).Item("Equipo_descripcion")
            txt_equipo_denominacion.Text = ds_info.Tables(0).Rows(0).Item("Equipo_denominacion")
            'carga sector
            cb_sector.SelectedValue = ds_info.Tables(0).Rows(0).Item("Cliente_suc_sector_id")
            'cargo tipo y subtipo
            cb_tipo.SelectedValue = ds_info.Tables(0).Rows(0).Item("Cat1_equipo_id")
            cb_subtipo.SelectedValue = ds_info.Tables(0).Rows(0).Item("Cat2_equipo_id")
            'AHORA CARGO LOS ATRIBUTOS SI ES QUE LOS HAY.
            If ds_info.Tables(1).Rows.Count <> 0 Then
                If dg_atributos.Rows.Count <> 0 Then
                    Dim i As Integer = 0
                    While i < ds_info.Tables(1).Rows.Count
                        Dim Cat2_caract_id As Integer = CInt(ds_info.Tables(1).Rows(i).Item("Cat2_caract_id"))
                        Dim j As Integer = 0
                        While j < dg_atributos.Rows.Count
                            If Cat2_caract_id = CInt(dg_atributos.Rows(j).Cells("Cat2_caract_id").Value) Then
                                dg_atributos.Rows(j).Cells("Atributo_detalle_valor").Value = ds_info.Tables(1).Rows(i).Item("Atributo_detalle_valor")
                            End If
                            j = j + 1
                        End While
                        i = i + 1
                    End While
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Dim cat1_id As Integer = 0
    Dim Cat2_equipo_id As Integer = 0

    Private Sub recuperar_categorias()
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
                Cat2_equipo_id = cb_subtipo.SelectedValue

                'recupero para el primer sub tipo las caracteristicas
                Dim ds_info As DataSet = Dacategorias.Cat2_caract_Subtipo_Obtener(Cat2_equipo_id)
                Equipos_cat_DS.Tables("Equipo_atributo_detalle").Rows.Clear()
                Equipos_cat_DS.Tables("Equipo_atributo_detalle").Merge(ds_info.Tables(0))
            Else

            End If
        End If
    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_tipo.SelectedIndexChanged
        recuperar_subtipo()
    End Sub

    Private Sub Alta() 'no lo estoy usando, ya que quiero probar el alta COMPLETA usando "transaction de oledbconnection" en la capa de datos.
        If cb_sector.Items.Count <> 0 Then
            If cb_tipo.Items.Count <> 0 Then
                If txt_equipo_descripcion.Text <> "" Then
                    If txt_equipo_denominacion.Text <> "" Then
                        'validamos que no exista
                        Dim ds_validar As DataSet = DAequipo.Equipo_validar(cb_sector.SelectedValue, txt_equipo_descripcion.Text, txt_equipo_denominacion.Text, 0)

                        If ds_validar.Tables(0).Rows.Count = 0 And ds_validar.Tables(1).Rows.Count = 0 Then
                            'quiere decir q no existe una descripcion y un nombre igual, se puede guardar.
                            'aqui guardo
                            Dim DS_ALTA As DataSet = DAequipo.Equipo_alta(txt_equipo_descripcion.Text, txt_equipo_denominacion.Text, cb_sector.SelectedValue, cb_subtipo.SelectedValue, 2)
                            'recuperar equipo_id despues del alta
                            Dim Equipo_id As Integer = CInt(DS_ALTA.Tables(0).Rows(0).Item("Equipo_id"))

                            'si hay atributos cargados los guardo en la bd ****************************************************************
                            If dg_atributos.Rows.Count <> 0 Then
                                Dim ii As Integer = 0
                                While ii < dg_atributos.Rows.Count
                                    Dim valor As String = ""
                                    If IsDBNull(dg_atributos.Rows(ii).Cells("Atributo_detalle_valor").Value) Then
                                        valor = ""
                                    Else
                                        valor = dg_atributos.Rows(ii).Cells("Atributo_detalle_valor").Value

                                    End If
                                    DAequipo.Equipo_atributo_detalle_alta(Equipo_id,
                                                                          CInt(dg_atributos.Rows(ii).Cells("Cat2_caract_id").Value),
                                                                          valor)

                                    ii = ii + 1
                                End While
                            End If
                            '*************************************************************************************************************
                            MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'ahora actualizo la grilla del formulario Equipo_consulta
                            'tengo q llamar a la rutina publica que debo definir en el formulario equipo_consulta para q me liste los equipos para esa sucursal.
                            Equipo_consulta.recuperar_equipos()
                            Equipo_consulta.Show() 'pongo show x que esta hide
                            Me.Close()
                        Else
                            'ahora veamos cual es el error.
                            If ds_validar.Tables(0).Rows.Count <> 0 Then
                                MessageBox.Show("Error, ya existe un Equipo con esa descripción. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                txt_equipo_descripcion.SelectAll()
                                txt_equipo_descripcion.Focus()
                            Else
                                If ds_validar.Tables(1).Rows.Count <> 0 Then
                                    MessageBox.Show("Error, ya existe un Equipo con esa denominación. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    txt_equipo_denominacion.SelectAll()
                                    txt_equipo_denominacion.Focus()
                                End If
                            End If
                        End If
                    Else
                        MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_equipo_denominacion.SelectAll()
                        txt_equipo_denominacion.Focus()
                    End If
                Else
                    MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_equipo_descripcion.SelectAll()
                    txt_equipo_descripcion.Focus()
                End If
            Else
                MessageBox.Show("Error, asigne un tipo y subtipo al equipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error, asigne un sector al equipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_sector.Focus()
        End If
    End Sub

    Private Sub Alta_todojunto_en_capa_dato()
        If cb_sector.Items.Count <> 0 Then
            If cb_tipo.Items.Count <> 0 Then
                If txt_equipo_descripcion.Text <> "" Then
                    If txt_equipo_denominacion.Text <> "" Then
                        'validamos que no exista
                        Dim ds_validar As DataSet = DAequipo.Equipo_validar(cb_sector.SelectedValue, txt_equipo_descripcion.Text, txt_equipo_denominacion.Text, 0)
                        If ds_validar.Tables(0).Rows.Count = 0 And ds_validar.Tables(1).Rows.Count = 0 Then
                            'quiere decir q no existe una descripcion y un nombre igual, se puede guardar.
                            '*****************************************************************************************************************************************
                            '***********************SE HACE EL ALTA DEL EQUIPO Y SUS ATRIBUTOS TODO EN UNA SOLA TRANSACCION EN LA CAPA DE DATOS***********************
                            '*****************************************************************************************************************************************
                            '*****************************************************************************************************************************************
                            Dim validar_op As String = DAequipo.Equipo_alta_todo_junto(txt_equipo_descripcion.Text, txt_equipo_denominacion.Text, cb_sector.SelectedValue, cb_subtipo.SelectedValue, 2, Equipos_cat_DS.Tables("Equipo_atributo_detalle"))
                            '*****************************************************************************************************************************************
                            '*****************************************************************************************************************************************
                            '*****************************************************************************************************************************************
                            '*****************************************************************************************************************************************

                            If validar_op = "GUARDADO" Then
                                MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'ahora actualizo la grilla del formulario Equipo_consulta
                                'tengo q llamar a la rutina publica que debo definir en el formulario equipo_consulta para q me liste los equipos para esa sucursal.
                                Equipo_consulta.recuperar_equipos()
                                Equipo_consulta.Show() 'pongo show x que esta hide
                                Me.Close()
                            Else
                                'NO SE GUARDO X UN ERROR, POR ELLO EL FORM QUEDA ABIERTO PARA INTENTAR NUEVAMENTE.
                                MessageBox.Show("Error, la operación falló. Intente nuevamente. Si el error persiste contactar con el proveedor del servicio.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            'ahora veamos cual es el error.
                            If ds_validar.Tables(0).Rows.Count <> 0 Then
                                MessageBox.Show("Error, ya existe un Equipo con esa descripción. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                txt_equipo_descripcion.SelectAll()
                                txt_equipo_descripcion.Focus()
                            Else
                                If ds_validar.Tables(1).Rows.Count <> 0 Then
                                    MessageBox.Show("Error, ya existe un Equipo con esa denominación. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    txt_equipo_denominacion.SelectAll()
                                    txt_equipo_denominacion.Focus()
                                End If
                            End If
                        End If
                    Else
                        MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_equipo_denominacion.SelectAll()
                        txt_equipo_denominacion.Focus()
                    End If
                Else
                    MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_equipo_descripcion.SelectAll()
                    txt_equipo_descripcion.Focus()
                End If
            Else
                MessageBox.Show("Error, asigne un tipo y subtipo al equipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error, asigne un sector al equipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_sector.Focus()
        End If
    End Sub

    Private Sub bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bo_guardar.Click
        If procedencia = "alta" Then
            'Alta()
            Alta_todojunto_en_capa_dato()
        End If
        If procedencia = "modificar" Then
            modificar()
        End If
    End Sub

    Private Sub modificar_b()
        DAequipo.Equipo_modificar(txt_equipo_denominacion.Text, txt_equipo_descripcion.Text, cb_subtipo.SelectedValue, Equipo_id)
        'ademas modificamos los valores de los atributos****************************************************************
        '1 - elimino los atributos guardados, uso el parametro Equipo_id
        DAequipo.Equipo_atributo_detalle_borrar(Equipo_id)
        '2 - guardo los valores de los atributos en el gridview
        If dg_atributos.Rows.Count <> 0 Then
            Dim ii As Integer = 0
            While ii < dg_atributos.Rows.Count
                Dim valor As String = ""
                If IsDBNull(dg_atributos.Rows(ii).Cells("Atributo_detalle_valor").Value) Then
                    valor = ""
                Else
                    valor = dg_atributos.Rows(ii).Cells("Atributo_detalle_valor").Value

                End If
                DAequipo.Equipo_atributo_detalle_alta(Equipo_id,
                                                      CInt(dg_atributos.Rows(ii).Cells("Cat2_caract_id").Value),
                                                      valor)

                ii = ii + 1
            End While
        End If
        '**************************************************************************************************************
        MessageBox.Show("Los datos se actualizaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ahora actualizo la grilla del formulario Equipo_consulta
        'tengo q llamar a la rutina publica que debo definir en el formulario equipo_consulta para q me liste los equipos para esa sucursal.
        Equipo_consulta.recuperar_equipos()
        Equipo_consulta.Show() 'pongo show x que esta hide
        Me.Close()
    End Sub

    Private Sub modificar()
        If cb_sector.Items.Count <> 0 Then
            If cb_tipo.Items.Count <> 0 Then
                If txt_equipo_descripcion.Text <> "" Then
                    If txt_equipo_denominacion.Text <> "" Then
                        'validamos que no exista
                        'Equipo_id() 'lo voy a necesitar para ver q no existan mantenimientos, y si los existe no debo cambiar la categoria
                        Dim ds_validar As DataSet = DAequipo.Equipo_validar(cb_sector.SelectedValue, txt_equipo_descripcion.Text, txt_equipo_denominacion.Text, Equipo_id)

                        'vamos a verificar si hay mantenimientos programados. y si es asi que correspondan al mismo subtipo de equipo, en caso de q sean distintos no puedo guardar
                        'y voy a emitir un msj explicando el motivo.
                        Dim valido_subtipo As String = "si"
                        If ds_validar.Tables(2).Rows.Count <> 0 Then
                            Dim ii As Integer = 0
                            While ii < ds_validar.Tables(2).Rows.Count
                                If ds_validar.Tables(2).Rows(ii).Item("Equipo_idcat") <> cb_subtipo.SelectedValue Then
                                    'si son distintos, no puedo guardar, ya que tendre problemas con las consultas de mantenimientos.
                                    valido_subtipo = "no"
                                    Exit While
                                End If
                                ii = ii + 1
                            End While
                        End If
                        If ds_validar.Tables(3).Rows.Count <> 0 Then
                            Dim ii As Integer = 0
                            While ii < ds_validar.Tables(3).Rows.Count
                                If ds_validar.Tables(3).Rows(ii).Item("Equipo_idcat") <> cb_subtipo.SelectedValue Then
                                    'si son distintos, no puedo guardar, ya que tendre problemas con las consultas de mantenimientos.
                                    valido_subtipo = "no"
                                    Exit While
                                End If
                                ii = ii + 1
                            End While
                        End If
                        If valido_subtipo = "si" Then
                            If ds_validar.Tables(0).Rows.Count = 0 And ds_validar.Tables(1).Rows.Count = 0 Then
                                'quiere decir q no existe una descripcion y un nombre igual, se puede guardar.
                                'aqui guardo
                                modificar_b()
                            Else
                                'ahora veamos cual es el error.
                                If ds_validar.Tables(0).Rows.Count <> 0 Then
                                    Dim equipo_id_bd As Integer = ds_validar.Tables(0).Rows(0).Item("Equipo_id")
                                    If equipo_id_bd = Equipo_id Then
                                        'si se puede guardar
                                        modificar_b()
                                    Else
                                        'no se puede guardar
                                        MessageBox.Show("Error, ya existe un Equipo con esa descripción. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        txt_equipo_descripcion.SelectAll()
                                        txt_equipo_descripcion.Focus()
                                    End If
                                Else
                                    If ds_validar.Tables(1).Rows.Count <> 0 Then
                                        Dim equipo_id_bd As Integer = ds_validar.Tables(1).Rows(0).Item("Equipo_id")
                                        If equipo_id_bd = Equipo_id Then
                                            'si se puede guardar
                                            modificar_b()
                                        Else
                                            MessageBox.Show("Error, ya existe un Equipo con esa denominación. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            txt_equipo_denominacion.SelectAll()
                                            txt_equipo_denominacion.Focus()
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            MessageBox.Show("Error, no puede cambiar la categoria ya que existen mantenimientos programados. Por favor modifique la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If



                    Else
                        MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_equipo_denominacion.SelectAll()
                        txt_equipo_denominacion.Focus()
                    End If
                Else
                    MessageBox.Show("Error, debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_equipo_descripcion.SelectAll()
                    txt_equipo_descripcion.Focus()
                End If
            Else
                MessageBox.Show("Error, asigne un tipo y subtipo al equipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error, asigne un sector al equipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cb_sector.Focus()
        End If
    End Sub

    Private Sub Bo_nuevosector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_nuevosector.Click
        Sucursales_sector_nuevo.Close()
        Sucursales_sector_nuevo.SucxClie_id = SucxClie_id
        Sucursales_sector_nuevo.Show()
    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        Equipo_consulta.Show()
        Me.Close()
    End Sub

    Private Sub cb_subtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_subtipo.SelectedIndexChanged
        If Cat2_equipo_id <> 0 Then
            Cat2_equipo_id = cb_subtipo.SelectedValue
            Dim ds_info As DataSet = Dacategorias.Cat2_caract_Subtipo_Obtener(Cat2_equipo_id)
            Equipos_cat_DS.Tables("Equipo_atributo_detalle").Rows.Clear()
            Equipos_cat_DS.Tables("Equipo_atributo_detalle").Merge(ds_info.Tables(0))
        End If



    End Sub
End Class