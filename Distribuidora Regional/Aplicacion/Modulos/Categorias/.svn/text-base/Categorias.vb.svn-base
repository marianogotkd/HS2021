Imports System.IO
Imports System.Data.OleDb

Public Class Categorias

    Dim Dacategoria As New Datos.Categoria

    'nuevo categoria
    Dim transaccion As String = ""
    Private Sub BO_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_nuevo.Click
        transaccion = "nuevo"
        Me.txt_categoria.Enabled = True
        Me.txt_rubro.Enabled = True
        Me.txt_subrubro.Enabled = True
        Me.bot_agregar_cat.Enabled = True
        Me.TreeView_agregadas.Enabled = True
        Me.bot_eliminar.Enabled = True

        'botones
        BO_cancelar.Enabled = True
        BO_nuevo.Enabled = False
        BO_edit_selec.Enabled = False
        bo_guardar.Enabled = True
        BO_delete.Enabled = False

        txt_categoria.Select()
    End Sub

    Private Sub bot_agregar_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot_agregar_cat.Click

        If txt_rubro.Text <> "" Then
            'VALIDO QUE EL RUBRO NO ESTE YA EN EL TREEVIEW AGREGADOS
            Dim valido As String = "si"
            Dim a As Integer = 0
            While a < Me.TreeView_agregadas.Nodes.Count
                If Me.txt_rubro.Text = TreeView_agregadas.Nodes(a).Text Then
                    'ahora si tiene subrubro agrego
                    If Me.txt_subrubro.Text <> "" Then
                        Dim valido_subrubro = "si"
                        Dim b As Integer = 0
                        While b < Me.TreeView_agregadas.Nodes(a).Nodes.Count
                            If Me.txt_subrubro.Text = Me.TreeView_agregadas.Nodes(a).Nodes(b).Text Then
                                valido_subrubro = "no"
                            End If
                            b = b + 1
                        End While
                        If valido_subrubro = "si" Then
                            TreeView_agregadas.Nodes(a).Nodes.Add(Me.txt_subrubro.Text)
                        End If
                    End If
                    valido = "no"
                End If
                a = a + 1
            End While
            If valido = "si" Then
                'aqui probamos los rubros agregas al treeview
                TreeView_agregadas.Nodes.Add(Me.txt_rubro.Text)
                Dim fila = 0
                Dim indice As Integer = Me.TreeView_agregadas.Nodes.Count - 1
                If txt_subrubro.Text <> "" Then
                    TreeView_agregadas.Nodes(indice).Nodes.Add(Me.txt_subrubro.Text)
                End If
            End If
        End If
        'FIN---------------------
        Me.txt_subrubro.Text = ""
        Me.txt_rubro.Select()

    End Sub


    Private Sub bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bo_guardar.Click
        If transaccion = "nuevo" Then
            'validacion 1
            If txt_categoria.Text <> "" Then
                'validacion 2
                Dim nuevo As String = "si"
                Dim a = 0
                While a < DataGridView1.Rows.Count
                    If DataGridView1.Rows(a).Cells(1).Value = txt_categoria.Text Then
                        nuevo = "no"
                        a = Me.DataGridView1.Rows.Count
                    End If
                    a = a + 1
                End While

                If nuevo = "si" Then

                    'agrego en bd categoria producto
                    Dim ds_categoria As DataSet
                    ds_categoria = Dacategoria.Categoria1_alta(txt_categoria.Text)
                    Dim id_categoria As Integer = ds_categoria.Tables(0).Rows(0).Item(0)
                    'ahora lo agrego a la grilla categorias
                    Dim newCustomersRow As DataRow = Categorias_DS.Tables("Categoria_1").NewRow()
                    newCustomersRow("cat_id") = id_categoria.ToString
                    newCustomersRow("cat1_nom") = txt_categoria.Text.ToString
                    Categorias_DS.Tables("Categoria_1").Rows.Add(newCustomersRow)
                    DataGridView1.DataSource = Categorias_DS.Tables("Categoria_1")
                    'cargo en el treeview las categirias y deportes
                    Me.TreeView1.Nodes.Add(txt_categoria.Text.ToString)

                    Dim fila = 0
                    Dim indice As Integer = Me.TreeView1.Nodes.Count - 1
                    While fila < TreeView_agregadas.Nodes.Count
                        'aqui cargo el rubro
                        TreeView1.Nodes(indice).Nodes.Add(TreeView_agregadas.Nodes(fila).Text)
                        Dim sub_indice = TreeView1.Nodes(indice).Nodes.Count - 1
                        'guardamos en bd el rubro
                        Dim ds_rubro As DataSet
                        ds_rubro = Dacategoria.Categoria2_alta(TreeView_agregadas.Nodes(fila).Text, id_categoria)
                        Dim id_rubro As Integer = ds_rubro.Tables(0).Rows(0).Item(0)


                        'hago un cilo para cargar los subrubros!!
                        Dim c As Integer = 0
                        While c < TreeView_agregadas.Nodes(fila).Nodes.Count

                            TreeView1.Nodes(indice).Nodes(sub_indice).Nodes.Add(TreeView_agregadas.Nodes(fila).Nodes(c).Text)
                            'guardo en bd los subrubros
                            Dacategoria.Categoria3_alta(TreeView_agregadas.Nodes(fila).Nodes(c).Text, id_rubro)
                            c = c + 1
                        End While

                        fila = fila + 1
                    End While


                    limpiar()
                Else
                    'mensaje error
                    MessageBox.Show("Ya se encuentra agregado, corrija la informacion", "Sistema de Gestion.")
                    Me.txt_categoria.SelectAll()
                End If
            Else
                'mensaje error
                MessageBox.Show("Complete la información", "Sistema de Gestion.")
                Me.txt_categoria.SelectAll()
            End If
        Else
            '//////////////////////////////////////////////////MODIFICAR CATEOGORIA RUBRO SUBRUBRO//////////////////////////////
            'modifico uno existente
            Dim CAT_id = (DataGridView1.CurrentRow.Cells(0).Value)

            Dim ds_rubros As DataSet = Dacategoria.Categoria_Rubro_borrar(CAT_id)

            'borro los subrubos de la bd, si los hay
            If ds_rubros.Tables(0).Rows.Count <> 0 Then
                Dim a As Integer = 0
                While a < ds_rubros.Tables(0).Rows.Count
                    Dacategoria.Categoria_Subrubro_borrar(ds_rubros.Tables(0).Rows(a).Item(0))
                    a = a + 1
                End While

            End If

            If TreeView1.SelectedNode.Nodes.Count <> 0 Then
                TreeView1.SelectedNode.Nodes.Clear()
            End If

            'aqui voy cargando los treeview
            Dim fila = 0

            Dim indice As Integer = Me.TreeView1.Nodes.Count - 1
            While fila < TreeView_agregadas.Nodes.Count
                'aqui cargo el rubro
                TreeView1.SelectedNode.Nodes.Add(TreeView_agregadas.Nodes(fila).Text) 'rubro
                Dim sub_indice = TreeView1.SelectedNode.Nodes.Count - 1
                'guardamos en bd el rubro
                Dim ds_rubro As DataSet
                ds_rubro = Dacategoria.Categoria2_alta(TreeView_agregadas.Nodes(fila).Text, CAT_id)
                Dim id_rubro As Integer = ds_rubro.Tables(0).Rows(0).Item(0)


                'hago un cilo para cargar los subrubros!!
                Dim c As Integer = 0
                While c < TreeView_agregadas.Nodes(fila).Nodes.Count

                    TreeView1.SelectedNode.Nodes(sub_indice).Nodes.Add(TreeView_agregadas.Nodes(fila).Nodes(c).Text)
                    'guardo en bd los subrubros
                    Dacategoria.Categoria3_alta(TreeView_agregadas.Nodes(fila).Nodes(c).Text, id_rubro)
                    c = c + 1
                End While

                fila = fila + 1
            End While

            limpiar()

        End If
        'Llama a dar de alta categoria desde producto alta
        If form_inicio = "producto_alta" Then
            Producto_alta.Cargar_categorias()
            Me.Close()
        End If
    End Sub

    Dim form_inicio As String = ""
    Public Sub Origen_alta(ByRef inicio As String)
        form_inicio = inicio
    End Sub

    Private Sub limpiar()

        Me.txt_categoria.Text = ""
        Me.txt_rubro.Text = ""
        Me.txt_subrubro.Text = ""
        TreeView_agregadas.Nodes.Clear()

        Me.txt_categoria.Enabled = False
        Me.txt_subrubro.Enabled = False
        Me.txt_rubro.Enabled = False
        Me.bot_agregar_cat.Enabled = False
        Me.bot_eliminar.Enabled = False 'elimina categoria

        'botones
        BO_cancelar.Enabled = False
        BO_nuevo.Enabled = True
        BO_edit_selec.Enabled = True
        bo_guardar.Enabled = False
        BO_delete.Enabled = True
        DataGridView1.Enabled = True
        TreeView1.Enabled = True

    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        limpiar()
    End Sub

    Private Sub bot_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot_eliminar.Click

        If TreeView_agregadas.SelectedNode Is Nothing Then
            MsgBox("seleccione Rubro")
        Else
            If TreeView_agregadas.SelectedNode.Parent Is Nothing Then
                'es nodo padre
                txt_rubro.Text = TreeView_agregadas.SelectedNode.Text
                txt_subrubro.Text = ""
                TreeView_agregadas.SelectedNode.Remove()
            Else
                'es nodo hijo, x ello selecciono al nodo padre del mismo
                txt_subrubro.Text = TreeView_agregadas.SelectedNode.Text
                Dim a = TreeView_agregadas.SelectedNode.Index
                'aqui selecciono al padre...o sea rubro 
                TreeView_agregadas.SelectedNode = TreeView_agregadas.SelectedNode.Parent
                txt_rubro.Text = TreeView_agregadas.SelectedNode.Text
                txt_subrubro.Focus()
                'quito del treeview el subrubro adecuado
                TreeView_agregadas.Nodes.Remove(TreeView_agregadas.SelectedNode.Nodes(a))
            End If
            'txt_rubro.Text = TreeView_agregadas.SelectedNode.Text
            'txt_subrubro.Text = TreeView_agregadas.SelectedNode.Text

        End If

    End Sub

    Private Sub BO_edit_selec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_edit_selec.Click
        If Me.DataGridView1.CurrentRow IsNot Nothing Then

            transaccion = "modificar"

            txt_categoria.Text = DataGridView1.CurrentRow.Cells(1).Value

            grilla_seleccion()
            If TreeView1.SelectedNode.Nodes.Count <> 0 Then

                'creo una variable que contenga la cantidad de nodos hijos, para el nodo raiz seleccionado
                Dim cant_nodos As Integer = TreeView1.SelectedNode.Nodes.Count
                Dim item As Integer = 0
                While item < cant_nodos
                    'ListBox1.Items.Add(TreeView1.SelectedNode.Nodes(item).Text) 'paso los nodos hijos al listbox de categorias
                    TreeView_agregadas.Nodes.Add(TreeView1.SelectedNode.Nodes(item).Text) 'agrego categoria en treeview _gregadas
                    Dim ultimo_item As Integer = TreeView_agregadas.Nodes.Count - 1

                    'ahora viene otro ciclo para pasar los nodos del subrubro si es necesario
                    Dim cant_subrubro As Integer = TreeView1.SelectedNode.Nodes(item).Nodes.Count
                    Dim item_rubro As Integer = 0
                    While item_rubro < cant_subrubro

                        TreeView_agregadas.Nodes(ultimo_item).Nodes.Add(TreeView1.SelectedNode.Nodes(item).Nodes(item_rubro).Text)
                        item_rubro = item_rubro + 1
                    End While
                    'TreeView_agregadas.Nodes(ultimo_item).Nodes.Add(TreeView1.SelectedNode.Nodes(item).Nodes(0).Text)
                    'TreeView_agregadas.Nodes(ultimo_item).Nodes.Add(TreeView1.SelectedNode.Nodes(item).Nodes(1).Text)

                    item = item + 1
                End While


            End If

            'Me.txt_deporte.Enabled = True
            Me.txt_rubro.Enabled = True
            Me.txt_subrubro.Enabled = True
            Me.bot_agregar_cat.Enabled = True
            Me.TreeView_agregadas.Enabled = True
            Me.bot_eliminar.Enabled = True

            'botones
            BO_cancelar.Enabled = True
            BO_nuevo.Enabled = False
            BO_edit_selec.Enabled = False
            BO_delete.Enabled = False
            bo_guardar.Enabled = True

            txt_rubro.SelectAll()

            'deshabilito el grid y el treeview, ya que cuando guarde, voy a actualizar lo que esta seleccionado
            DataGridView1.Enabled = False
            TreeView1.Enabled = False
        End If

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        grilla_seleccion()
    End Sub

    Private Sub grilla_seleccion() 'al selecciona una celda de la grilla, se selecciona la categoria correspondiente
        If Me.DataGridView1.CurrentRow IsNot Nothing Then
            Dim item As Integer = 0
            While item < Me.TreeView1.Nodes.Count

                If DataGridView1.CurrentRow.Cells(1).Value.ToString = TreeView1.Nodes(item).Text Then
                    TreeView1.SelectedNode = TreeView1.Nodes(item)
                    'TreeView1.SelectedNode.NodeFont.Bold
                End If
                item = item + 1
            End While
        End If
    End Sub

    Private Sub Categorias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cargar_deporte_y_categorias()

    End Sub

    Private Sub cargar_deporte_y_categorias()
        'DataGridView1.DataSource = ""
        Categorias_DS.Tables("Categoria_1").Rows.Clear()
        TreeView1.Nodes.Clear()
        TreeView_agregadas.Nodes.Clear()


        'cargo la grilla de deportes existentes
        Dim ds_categorias As New DataSet
        ds_categorias = Dacategoria.Categoria_obtener
        If ds_categorias.Tables(0).Rows.Count <> 0 Then
            Dim num As Integer = 0
            While num < ds_categorias.Tables(0).Rows.Count
                Dim newCustomersRow As DataRow = Categorias_DS.Tables("Categoria_1").NewRow()
                newCustomersRow("cat_id") = ds_categorias.Tables(0).Rows(num).Item(0).ToString
                newCustomersRow("cat1_nom") = ds_categorias.Tables(0).Rows(num).Item(1).ToString
                Categorias_DS.Tables("Categoria_1").Rows.Add(newCustomersRow)
                num = num + 1
            End While
            DataGridView1.DataSource = Categorias_DS.Tables("Categoria_1")
        End If
        'cargo en el treeview las categirias y deportes
        Dim ds_categoria As New DataSet
        ds_categoria = Dacategoria.Categoria_obtener_niveles
        If ds_categoria.Tables(0).Rows.Count <> 0 Then

            Dim item As Integer = 0
            While item < ds_categoria.Tables(0).Rows.Count
                Me.TreeView1.Nodes.Add(ds_categoria.Tables(0).Rows(item).Item("cat1_nom").ToString) 'agrego categoria
                If ds_categoria.Tables(1).Rows.Count <> 0 Then
                    Dim nro = 0

                    While nro < ds_categoria.Tables(1).Rows.Count
                        Dim raiz As String = ds_categoria.Tables(0).Rows(item).Item("cat_id").ToString
                        If raiz = ds_categoria.Tables(1).Rows(nro).Item("cat_id").ToString Then
                            TreeView1.Nodes(item).Nodes.Add(ds_categoria.Tables(1).Rows(nro).Item("cat2_nom").ToString) 'agrego rubro

                            Dim raiz2 As String = ds_categoria.Tables(1).Rows(nro).Item("cat2_id").ToString

                            Dim ultimo_item As Integer = TreeView1.Nodes(item).Nodes.Count - 1
                            Dim c As Integer = 0

                            While c < ds_categoria.Tables(2).Rows.Count
                                If raiz2 = ds_categoria.Tables(2).Rows(c).Item("cat2_id").ToString Then
                                    TreeView1.Nodes(item).Nodes(ultimo_item).Nodes.Add(ds_categoria.Tables(2).Rows(c).Item("cat3_nom").ToString)
                                End If

                                c = c + 1
                            End While

                            'Dim ultimo_item As Integer = TreeView1.Nodes(item).Nodes.Count - 1
                            'TreeView1.Nodes(item).Nodes(ultimo_item).Nodes.Add("Inicio:" + ds_categoria.Tables(0).Rows(nro).Item("DEP_CAT_inic").ToString)
                            'TreeView1.Nodes(item).Nodes(ultimo_item).Nodes.Add("Fin:" + ds_categoria.Tables(0).Rows(nro).Item("DEP_CAT_fin").ToString)
                        End If
                        nro = nro + 1

                    End While
                End If
                item = item + 1
            End While






            'Dim item As Integer = 0
            'While item < ds_categoria.Tables(1).Rows.Count
            '    Me.TreeView1.Nodes.Add(ds_categoria.Tables(1).Rows(item).Item("DEP_nom").ToString)
            '    If ds_categoria.Tables(0).Rows.Count <> 0 Then
            '        Dim nro = 0
            '        While nro < ds_categoria.Tables(0).Rows.Count
            '            Dim raiz As String = ds_categoria.Tables(1).Rows(item).Item("DEP_id").ToString
            '            If raiz = ds_categoria.Tables(0).Rows(nro).Item("DEP_id").ToString Then
            '                TreeView1.Nodes(item).Nodes.Add(ds_categoria.Tables(0).Rows(nro).Item("DEP_CAT_nom").ToString)
            '                Dim ultimo_item As Integer = TreeView1.Nodes(item).Nodes.Count - 1
            '                TreeView1.Nodes(item).Nodes(ultimo_item).Nodes.Add("Inicio:" + ds_categoria.Tables(0).Rows(nro).Item("DEP_CAT_inic").ToString)
            '                TreeView1.Nodes(item).Nodes(ultimo_item).Nodes.Add("Fin:" + ds_categoria.Tables(0).Rows(nro).Item("DEP_CAT_fin").ToString)
            '            End If
            '            nro = nro + 1
            '        End While
            '    End If
            '    item = item + 1
            'End While




        End If
    End Sub

    Private Sub BO_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_delete.Click

        If DataGridView1.Rows.Count <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea eliminar Categoria seleccionada?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then


                'primero llamo a la rutina para obtener los id de los rubros, y borro todos ellos
                Dim CAT_id = (DataGridView1.CurrentRow.Cells(0).Value)

                Dim ds_rubros As DataSet = Dacategoria.Categoria_Rubro_borrar(CAT_id)

                'borro los subrubos de la bd, si los hay
                If ds_rubros.Tables(0).Rows.Count <> 0 Then
                    Dim a As Integer = 0
                    While a < ds_rubros.Tables(0).Rows.Count
                        Dacategoria.Categoria_Subrubro_borrar(ds_rubros.Tables(0).Rows(a).Item(0))
                        a = a + 1
                    End While
                End If

                Dacategoria.Categoria_borrar(Me.DataGridView1.CurrentRow.Cells(0).Value)
                cargar_deporte_y_categorias()
            End If

        End If

    End Sub

    
End Class