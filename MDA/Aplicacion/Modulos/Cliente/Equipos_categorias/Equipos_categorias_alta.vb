Public Class Equipos_categorias_alta

    Public procedencia As String
    Public Cat1_equipo_id As Integer 'me lo envia el form equipos_categoria_consultar
    Private Sub Equipos_categorias_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If procedencia = "modificar" Then
            'tengo q recuperar tipo y subtipos
            Dim ds_info As DataSet = daEquip_cat.Equipo_categoria1_y_2_recuperar(Cat1_equipo_id)

            Try

                txt_tipo.Text = ds_info.Tables(0).Rows(0).Item("Cat1_equipo_desc")
                txt_tipo.ReadOnly = True

                Equipos_cat_DS.Tables("subtipos_agregados").Merge(ds_info.Tables(1))
                Equipos_cat_DS.Tables("Atributos_todos_aux").Merge(ds_info.Tables(2))

                '/////////////////AHORA CARGO LOS ATRIBUTOS PARA EL PRIMER SUBTIPO RECUPERDO////////////////////////////////////////////////////////////
                If DG_subtipos.Rows.Count <> 0 Then
                    txt_subtipo_info.Text = DG_subtipos.CurrentRow.Cells("DescripcionDataGridViewTextBoxColumn").Value
                    'aqui tambien tengo q recuperar los atributos q esten en la bd

                    Equipos_cat_DS.Tables("Atributos").Rows.Clear()
                    'ahora cargo en la tabla atributos solo los que correspondonde a ese subtipo
                    Dim i As Integer = 0
                    Dim subtipo As String = DG_subtipos.CurrentRow.Cells("DescripcionDataGridViewTextBoxColumn").Value
                    While i < Equipos_cat_DS.Tables("Atributos_todos_aux").Rows.Count
                        If subtipo = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("subtipo") Then
                            Dim fila As DataRow = Equipos_cat_DS.Tables("Atributos").NewRow
                            fila("Cat2_equipo_id") = CInt(DG_subtipos.CurrentRow.Cells("Cat2equipoidDataGridViewTextBoxColumn").Value)
                            fila("Cat2_caract_id") = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("Cat2_caract_id")
                            fila("Cat2_caract_atributo") = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("Cat2_caract_atributo")
                            fila("estado") = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("estado")
                            fila("subtipo") = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("subtipo")
                            Equipos_cat_DS.Tables("Atributos").Rows.Add(fila)
                        End If
                        i = i + 1
                    End While
                Else
                    txt_subtipo_info.Clear()
                End If
                '//////////////////////////////////////////////////////////////////FIN////////////////////////////////////////////////////////////


            Catch ex As Exception

            End Try

        Else
            txt_tipo.ReadOnly = False

        End If

    End Sub

    Private Sub bot_agregar_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot_agregar_cat.Click
        If txt_subtipo.Text <> "" Then

            'valido que el subtipo no este en la grilla de abajo.
            Dim valido As String = "si"
            Dim i As Integer = 0
            While i < DG_subtipos.Rows.Count
                If txt_subtipo.Text = DG_subtipos.Rows(i).Cells("DescripcionDataGridViewTextBoxColumn").Value Then
                    valido = "no"
                    Exit While
                End If
                i = i + 1
            End While
            If valido = "si" Then
                Dim fila As DataRow = Equipos_cat_DS.Tables("subtipos_agregados").NewRow
                'Dim fila As DataRow = Cliente_alta_New.Cliente_ds.Tables("Sucursales").NewRow
                fila("Cat2_equipo_id") = 0 'pongo cero x que aun no lo guarde en  la bd
                fila("descripcion") = txt_subtipo.Text
                fila("estado") = "agregado" 'agregado/en_bd/eliminado en bd/eliminado no bd
                Equipos_cat_DS.Tables("subtipos_agregados").Rows.Add(fila)

                txt_subtipo.Clear()
                txt_subtipo.SelectAll()
                txt_subtipo.Focus()
            Else
                MessageBox.Show("Error, ya se encuentra cargado un Subtipo con esa descripción. Por favor modifique los datos ingresados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_subtipo.SelectAll()
                txt_subtipo.Focus()
            End If

        Else
            MessageBox.Show("Error, el campo es vacio. Para agregar un subtipo debe completar la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_subtipo.SelectAll()
            txt_subtipo.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim valido_seleccion As String = "no"
        If DG_subtipos.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DG_subtipos.Rows.Count
                If DG_subtipos.Rows(i).Cells("item").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                        If MsgBox("¿Esta seguro que quiere eliminar el subtipo seleccionado? Los datos se actualizaran directamente en su base de datos.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                            pregunta = "si"
                        Else
                            'aqui corto el ciclo, ya que se cancelo la eliminacion
                            i = DG_subtipos.Rows.Count
                        End If
                    End If
                    If pregunta = "si" Then
                        'primero guardo el nro de item q contiene
                        Dim item As Decimal = DG_subtipos.CurrentRow.Index
                        'valido eso de las 2 opciones que detalle arriba
                        Dim estado As String = DG_subtipos.Rows(i).Cells("estado").Value
                        If estado = "agregado" Then
                            'no esta guardado en bd, asi que solo quito
                        Else
                            If estado = "en_bd" Then
                                'si esta en bd, entonces actualizo en bd, el estado del campo SucxClie_estado = "eliminado"
                                'DAcliente.Cliente_Sucursales_eliminar(CInt(DG_Servicio.Rows(i).Cells("SucxClieidDataGridViewTextBoxColumn").Value), "ELIMINADO")
                                daEquip_cat.Equipo_categoria2_eliminar(DG_subtipos.Rows(i).Cells("Cat2equipoidDataGridViewTextBoxColumn").Value)
                            End If
                        End If
                        DG_subtipos.Rows.RemoveAt(i)
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
                MessageBox.Show("Seleccione un subtipo para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("No hay subtipos asignados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub DG_subtipos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_subtipos.Click
        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If DG_subtipos.Rows.Count <> 0 Then
            'DataGridView2.Rows(i).Cells("Item").Value = True
            'If DataGridView2.CurrentRow.Cells("item").Value = True Then
            Dim i As Integer = 0
            While i < DG_subtipos.Rows.Count
                If DG_subtipos.Rows(i).Cells("item").Value = True Then
                    DG_subtipos.Rows(i).Cells("item").Value = False
                End If
                i = i + 1
            End While
            'ahora solo tildo el actual
            DG_subtipos.CurrentRow.Cells("item").Value = True
            'End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DG_subtipos.RowCount <> 0 Then

            Dim indice_fila As Integer = DG_subtipos.CurrentRow.Index
            Equipos_subtipo_editar.Close()
            Equipos_subtipo_editar.indice = indice_fila
            Equipos_subtipo_editar.txt_subtipo.Text = DG_subtipos.CurrentRow.Cells("DescripcionDataGridViewTextBoxColumn").Value
            Equipos_subtipo_editar.Show()


        Else
            MessageBox.Show("Seleccione un subtipo para editar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Dim daEquip_cat As New Datos.Equipos_categorias

    Private Sub alta()
        Try
            Dim valido As String = "si"
            If txt_tipo.Text <> "" Then
                'continuo
                If DG_subtipos.Rows.Count <> 0 Then
                    'aqui guardo

                    Dim ds_validar As DataSet = daEquip_cat.Equipo_categoria1_validar(txt_tipo.Text)
                    If ds_validar.Tables(0).Rows.Count = 0 Then
                        'primero tipo
                        Dim ds_cat1 As DataSet = daEquip_cat.Equipo_categoria1_alta(txt_tipo.Text)
                        Dim cat1_id As Integer = CInt(ds_cat1.Tables(0).Rows(0).Item("Cat1_equipo_id"))
                        'luego ciclo y cargo los subtipos
                        Dim i As Integer = 0
                        While i < DG_subtipos.Rows.Count
                            'aqui guardo subtipo
                            Dim ds_subtipo_info As DataSet = daEquip_cat.Equipo_categoria2_alta(DG_subtipos.Rows(i).Cells("DescripcionDataGridViewTextBoxColumn").Value, cat1_id)

                            'ahora doy de alta los atributos para ese subtipo
                            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            Dim Cat2_equipo_id As Integer = ds_subtipo_info.Tables(0).Rows(0).Item("Cat2_equipo_id")
                            Dim j As Integer = 0
                            While j < Equipos_cat_DS.Tables("Atributos_todos_aux").Rows.Count
                                If DG_subtipos.Rows(i).Cells("DescripcionDataGridViewTextBoxColumn").Value = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(j).Item("subtipo") Then
                                    'aqui va la alta
                                    daEquip_cat.Equipo_categoria2_caracteristicas_alta(Cat2_equipo_id, Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(j).Item("Cat2_caract_atributo"))
                                End If
                                j = j + 1
                            End While
                            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            i = i + 1
                        End While

                        MessageBox.Show("Los datos fueron guardados correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Equipos_categoria_consultar.recuperar_categorias()
                        Equipos_categoria_consultar.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("ERROR, ya existe un TIPO con esa descripción, por favor modifique los datos.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_tipo.SelectAll()
                        txt_tipo.Focus()
                    End If
                Else
                    MessageBox.Show("Error, debe ingresar al menos un subtipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_subtipo.SelectAll()
                    txt_subtipo.Focus()
                End If
            Else
                MessageBox.Show("Error, debe ingresar un nombre para el Tipo de Equipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_tipo.SelectAll()
                txt_tipo.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Fallo en la conexión, intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub modificar()
        Try
            Dim valido As String = "si"
            If txt_tipo.Text <> "" Then
                'continuo
                If DG_subtipos.Rows.Count <> 0 Then
                    'no se guarda tipo,

                    'guardamos subtipos
                    'se puede dar de alta o bien modificar uno existente.



                    Dim cat1_id As Integer = Cat1_equipo_id
                    Dim i As Integer = 0
                    While i < DG_subtipos.Rows.Count
                        'aqui guardo subtipo
                        Dim ds_subtipo_info As DataSet
                        Dim Cat2_equipo_id As Integer
                        Dim estado As String = DG_subtipos.Rows(i).Cells("estado").Value

                        Select estado
                            Case "modificado"
                                daEquip_cat.Equipo_categoria2_modificar(DG_subtipos.Rows(i).Cells("DescripcionDataGridViewTextBoxColumn").Value, DG_subtipos.Rows(i).Cells("Cat2equipoidDataGridViewTextBoxColumn").Value)
                                Cat2_equipo_id = DG_subtipos.Rows(i).Cells("Cat2equipoidDataGridViewTextBoxColumn").Value

                            Case "agregado"
                                ds_subtipo_info = daEquip_cat.Equipo_categoria2_alta(DG_subtipos.Rows(i).Cells("DescripcionDataGridViewTextBoxColumn").Value, cat1_id)
                                Cat2_equipo_id = ds_subtipo_info.Tables(0).Rows(0).Item("Cat2_equipo_id")
                            Case "en_bd"
                                Cat2_equipo_id = DG_subtipos.Rows(i).Cells("Cat2equipoidDataGridViewTextBoxColumn").Value 'lo necesito recuperar para hacer alta de un atributo
                        End Select

                        'ahora doy de alta los atributos para ese subtipo
                        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        Dim j As Integer = 0
                        While j < Equipos_cat_DS.Tables("Atributos_todos_aux").Rows.Count
                            If DG_subtipos.Rows(i).Cells("DescripcionDataGridViewTextBoxColumn").Value = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(j).Item("subtipo") Then
                                Dim estado_atributo As String = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(j).Item("estado")

                                Select Case estado_atributo
                                    Case "nuevo"
                                        'aqui va la alta
                                        daEquip_cat.Equipo_categoria2_caracteristicas_alta(Cat2_equipo_id, Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(j).Item("Cat2_caract_atributo"))
                                    Case "modificado"
                                        'aqui modifico 
                                        Dim atributo As String = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(j).Item("Cat2_caract_atributo")
                                        Dim Cat2_caract_id As Integer = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(j).Item("Cat2_caract_id")
                                        daEquip_cat.Equipo_categoria2_caracteristicas_modificar(atributo, Cat2_caract_id)
                                End Select
                            End If
                            j = j + 1
                        End While
                        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        i = i + 1
                    End While

                    MessageBox.Show("Los datos fueron guardados correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Equipos_categoria_consultar.recuperar_categorias()
                    Equipos_categoria_consultar.Show()
                    Me.Close()

                Else
                    MessageBox.Show("Error, debe ingresar al menos un subtipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_subtipo.SelectAll()
                    txt_subtipo.Focus()
                End If
            Else
                MessageBox.Show("Error, debe ingresar un nombre para el Tipo de Equipo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_tipo.SelectAll()
                txt_tipo.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Fallo en la conexión, intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bo_guardar.Click

        If procedencia = "modificar" Then
            modificar()
        Else
            alta()
        End If

        
    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        Equipos_categoria_consultar.recuperar_categorias()
        Equipos_categoria_consultar.Show()
        Me.Close()
    End Sub

    
    Private Sub DG_subtipos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_subtipos.SelectionChanged

        If DG_subtipos.Rows.Count <> 0 Then
            txt_subtipo_info.Text = DG_subtipos.CurrentRow.Cells("DescripcionDataGridViewTextBoxColumn").Value
            'aqui tambien tengo q recuperar los atributos q esten en la bd

            Equipos_cat_DS.Tables("Atributos").Rows.Clear()
            'ahora cargo en la tabla atributos solo los que correspondonde a ese subtipo
            Dim i As Integer = 0
            Dim subtipo As String = DG_subtipos.CurrentRow.Cells("DescripcionDataGridViewTextBoxColumn").Value
            While i < Equipos_cat_DS.Tables("Atributos_todos_aux").Rows.Count
                If subtipo = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("subtipo") Then
                    Dim fila As DataRow = Equipos_cat_DS.Tables("Atributos").NewRow
                    fila("Cat2_equipo_id") = CInt(DG_subtipos.CurrentRow.Cells("Cat2equipoidDataGridViewTextBoxColumn").Value)
                    fila("Cat2_caract_id") = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("Cat2_caract_id")
                    fila("Cat2_caract_atributo") = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("Cat2_caract_atributo")
                    fila("estado") = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("estado")
                    fila("subtipo") = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(i).Item("subtipo")
                    Equipos_cat_DS.Tables("Atributos").Rows.Add(fila)
                End If
                i = i + 1
            End While
        Else
            txt_subtipo_info.Clear()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If txt_subtipo_info.Text <> "" Then
                If txt_atributo.Text <> "" Then
                    Dim valido As String = "si"
                    Dim i As Integer = 0
                    While i < dg_atributos.Rows.Count
                        If txt_atributo.Text = dg_atributos.Rows(i).Cells("Cat2caractatributoDataGridViewTextBoxColumn").Value Then
                            valido = "no"
                            Exit While
                        End If
                        i = i + 1
                    End While

                    If valido = "si" Then
                        Dim fila As DataRow = Equipos_cat_DS.Tables("Atributos").NewRow
                        fila("Cat2_equipo_id") = CInt(DG_subtipos.CurrentRow.Cells("Cat2equipoidDataGridViewTextBoxColumn").Value)
                        fila("Cat2_caract_id") = 0
                        fila("Cat2_caract_atributo") = txt_atributo.Text
                        fila("estado") = "nuevo"
                        fila("subtipo") = DG_subtipos.CurrentRow.Cells("DescripcionDataGridViewTextBoxColumn").Value 'me va a servir para hacer el alta, no puedo usar el id x que aun no lo tengo si es un alta
                        Equipos_cat_DS.Tables("Atributos").Rows.Add(fila)

                        '//////////////////////////////////////////////////////////////////
                        Dim fila2 As DataRow = Equipos_cat_DS.Tables("Atributos_todos_aux").NewRow
                        fila2("Cat2_equipo_id") = CInt(DG_subtipos.CurrentRow.Cells("Cat2equipoidDataGridViewTextBoxColumn").Value)
                        fila2("Cat2_caract_id") = 0
                        fila2("Cat2_caract_atributo") = txt_atributo.Text
                        fila2("estado") = "nuevo"
                        fila2("subtipo") = DG_subtipos.CurrentRow.Cells("DescripcionDataGridViewTextBoxColumn").Value 'me va a servir para hacer el alta, no puedo usar el id x que aun no lo tengo si es un alta
                        Equipos_cat_DS.Tables("Atributos_todos_aux").Rows.Add(fila2)
                        '//////////////////////////////////////////////////////////////////

                        txt_atributo.Clear()
                        txt_atributo.SelectAll()
                        txt_atributo.Focus()
                    Else
                        MessageBox.Show("Error, ya se encuentra cargado un atributo con esa descripción. Por favor modifique los datos ingresados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_atributo.SelectAll()
                        txt_atributo.Focus()
                    End If
                Else
                    MessageBox.Show("Error, debe ingresar un atributo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_atributo.SelectAll()
                    txt_atributo.Focus()
                End If
            End If
        Catch ex As Exception

        End Try

        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim valido_seleccion As String = "no"
        If dg_atributos.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < dg_atributos.Rows.Count
                If dg_atributos.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                        If MsgBox("¿Esta seguro que quiere eliminar el atributo seleccionado? Los datos se actualizaran directamente en su base de datos.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
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
                        Dim estado As String = dg_atributos.Rows(i).Cells("estado_column").Value
                        If estado = "nuevo" Then
                            'no esta guardado en bd, asi que solo quito
                        Else
                            If estado = "en_bd" Then
                                'si esta en bd, entonces actualizo en bd, el estado del campo SucxClie_estado = "eliminado"
                                daEquip_cat.Equipo_categoria2_caracteristicas_eliminar(dg_atributos.Rows(i).Cells("Cat2caractidDataGridViewTextBoxColumn").Value)

                            End If
                        End If
                        '//////////////////////////////////////////////////////////////////////////////////////////////////////////
                        'ahora lo tengo que quitar de la tabla auxiliar
                        Dim h As Integer = 0
                        'Dim Cat2_caract_id As Integer = CInt(dg_atributos.Rows(i).Cells("Cat2caractidDataGridViewTextBoxColumn").Value) 'puedo usar esto en  la busqueda, x que esta en la bd
                        Dim subtipo As String = dg_atributos.Rows(i).Cells("DataGridViewTextBoxColumn1").Value 'lo uso en la busqueda
                        Dim atributo As String = dg_atributos.Rows(i).Cells("Cat2caractatributoDataGridViewTextBoxColumn").Value 'lo uso en la busqueda
                        While h < Equipos_cat_DS.Tables("Atributos_todos_aux").Rows.Count
                            If (atributo = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(h).Item("Cat2_caract_atributo")) And (subtipo = Equipos_cat_DS.Tables("Atributos_todos_aux").Rows(h).Item("subtipo")) Then
                                Equipos_cat_DS.Tables("Atributos_todos_aux").Rows.RemoveAt(h)
                                Exit While
                            End If
                            h = h + 1
                        End While
                        '//////////////////////////////////////////////////////////////////////////////////////////////////////////

                        dg_atributos.Rows.RemoveAt(i)
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
                MessageBox.Show("Seleccione un atributo para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("No hay atributos asignados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub dg_atributos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_atributos.Click
        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If dg_atributos.Rows.Count <> 0 Then
            'DataGridView2.Rows(i).Cells("Item").Value = True
            'If DataGridView2.CurrentRow.Cells("item").Value = True Then
            Dim i As Integer = 0
            While i < dg_atributos.Rows.Count
                If dg_atributos.Rows(i).Cells("Column1").Value = True Then
                    dg_atributos.Rows(i).Cells("Column1").Value = False
                End If
                i = i + 1
            End While
            'ahora solo tildo el actual
            dg_atributos.CurrentRow.Cells("Column1").Value = True
            'End If
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dg_atributos.RowCount <> 0 Then
            Dim indice_fila As Integer = dg_atributos.CurrentRow.Index
            Equipos_atributos_editar.Close()
            Equipos_atributos_editar.indice = indice_fila
            Equipos_atributos_editar.txt_atributo.Text = dg_atributos.CurrentRow.Cells("Cat2caractatributoDataGridViewTextBoxColumn").Value
            Equipos_atributos_editar.Show()
        Else
            MessageBox.Show("Seleccione un atributo para editar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class