Imports System.IO
Imports System.Data.OleDb
Public Class Producto_modificar

    Dim DAmarca As New Datos.Marca
    Dim DAproveedores As New Datos.Proveedor
    Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener

    Public Sub Cargarcombo_proveedor()

        ds_proveedor = DAproveedores.Proveedor_obtener
        'Cargar Proveedor
        cb_proveedores.DataSource = ds_proveedor.Tables(0)
        cb_proveedores.DisplayMember = "Prov_nombre"
        cb_proveedores.ValueMember = "Prov_id"

    End Sub

    Public Sub Cargarcombo_marca()
        'Cargar la Marca
        Dim ds_marca As DataSet = DAmarca.Marca_obtener
        cb_marca.DataSource = ds_marca.Tables(0)
        cb_marca.DisplayMember = "Marca_nom"
        cb_marca.ValueMember = "Marca_id"
        cb_marca.SelectedValue = "1"
    End Sub

    Dim DAproducto As New Datos.Producto

    Private Sub Buscar_codinterno()
        If Tx_Codinterno.Text <> "" Then
            Me.DG_Producto.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproducto.Producto_buscarcod(Me.Tx_Codinterno.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DG_Producto.Rows().Add()
                    DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(6) 'COD interno
                    DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(1) 'producto
                    DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(5) 'marca
                    DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(3) 'Stock
                    DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(4) 'ptoreposicion
                    If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                        DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                        DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                    End If
                    fila = fila + 1
                End While
            End If
            Me.Tx_Codinterno.Select()
        Else
            Prod_obtenertodo()
        End If
    End Sub

    Private Sub BO_Buscar_codinterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_codinterno.Click
        Buscar_codinterno()
    End Sub

    Public Sub Prod_obtenertodo()
        Me.DG_Producto.Rows.Clear()
        Dim DS As New DataSet
        DS = DAproducto.prod_obtener()
        If DS.Tables(0).Rows.Count <> 0 Then
            Dim fila As Integer = 0
            While fila < DS.Tables(0).Rows.Count
                Me.DG_Producto.Rows().Add()
                DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(6) 'COD interno
                DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(1) 'producto
                DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(5) 'marca
                DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(3) 'Stock
                DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(4) 'ptoreposicion
                If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                    DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                    DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                End If
                fila = fila + 1
            End While
            DG_Producto.ClearSelection()
        End If

    End Sub

    Private Sub BO_producto_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_producto_modificar.Click
        habilitar()
        If Me.DG_Producto.CurrentRow IsNot Nothing Then

            Dim productoselec As String = DG_Producto.SelectedCells(1).Value
            If productoselec <> "" Then
                Tx_Codinterno.Text = DG_Producto.SelectedCells(1).Value
                Me.TabControl1.SelectedTab = TabPage2
                recuperar_datos_producto()

                Me.TabControl1.SelectedTab = TabPage3
                recuperar_datos()

                Bo_guardar.Enabled = True
                Bo_cancelar.Enabled = True
                GroupBox1.Enabled = False
            Else
                MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub recuperar_datos()
        Dim ds_prod As New DataSet
        ds_prod = DAproducto.Producto_obtenerDatos(Tx_Codinterno.Text)

        Tx_cod_modif.Text = ds_prod.Tables(0).Rows(0).Item(11)
        tx_descripcion.Text = ds_prod.Tables(0).Rows(0).Item(1)
        tx_descrilarga.Text = ds_prod.Tables(0).Rows(0).Item(13)
        cb_marca.Text = ds_prod.Tables(0).Rows(0).Item(14)
        tx_unimedida.Text = ds_prod.Tables(0).Rows(0).Item(15)
        tx_codbarra.Text = ds_prod.Tables(0).Rows(0).Item(16)

        'recupero foto
        Dim arrImg As Byte() = DirectCast(ds_prod.Tables(1).Rows(0).Item("prod_foto"), Byte())
        Dim ms As New MemoryStream(arrImg)
        Dim img As Image = Image.FromStream(ms)
        PictureBox1.Image = img

    End Sub

    Public Sub recuperar_datos_producto()
        Dim ds_producto As New DataSet
        ds_producto = DAproducto.Producto_obtenerDatos(Tx_Codinterno.Text)

        If ds_producto.Tables(0).Rows.Count <> 0 Then
            Dim item As Integer = 0
            While item < ds_producto.Tables(0).Rows.Count
                Dim newCustomersRow As DataRow = Producto_ds.Tables("ProductoModificar").NewRow()
                newCustomersRow("Prov_id") = ds_producto.Tables(0).Rows(item).Item(5)
                newCustomersRow("Prod_id") = ds_producto.Tables(0).Rows(item).Item(0)
                newCustomersRow("Prov_prod_id") = ds_producto.Tables(0).Rows(item).Item(9)
                newCustomersRow("Prov_Prod_Com_id") = ds_producto.Tables(0).Rows(item).Item(10)
                newCustomersRow("Prod_descripcion") = ds_producto.Tables(0).Rows(item).Item(1)
                newCustomersRow("Prov_nombre") = ds_producto.Tables(0).Rows(item).Item(6)
                newCustomersRow("Prov_Prod_Com_precio") = ds_producto.Tables(0).Rows(item).Item(8)
                newCustomersRow("Prod_precio_vta") = ds_producto.Tables(0).Rows(item).Item(2)
                newCustomersRow("Prod_stock") = ds_producto.Tables(0).Rows(item).Item(3)
                newCustomersRow("Prod_ptorepo") = ds_producto.Tables(0).Rows(item).Item(4)
                newCustomersRow("Prov_Prod_Com_fecha") = ds_producto.Tables(0).Rows(item).Item(7)
                Producto_ds.Tables("ProductoModificar").Rows.Add(newCustomersRow)
                DG_prod_modif.DataSource = Producto_ds.Tables("ProductoModificar")
                item = item + 1
            End While
        End If

    End Sub

    Public Sub Editar_prod()
        Me.cb_proveedores.Text = DG_prod_modif.CurrentRow.Cells(5).Value
        Me.Tx_stock_modif.Text = DG_prod_modif.CurrentRow.Cells(8).Value
        Me.Tx_compra_modif.Text = DG_prod_modif.CurrentRow.Cells(6).Value
        Me.tx_venta_modif.Text = DG_prod_modif.CurrentRow.Cells(7).Value
        Me.tx_ptorepo.Text = DG_prod_modif.CurrentRow.Cells(9).Value
        Me.DT_fecha_compra.Text = Today
    End Sub

    Private Sub DG_prod_modif_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_prod_modif.DoubleClick
        Editar_prod()
        GroupBox4.Enabled = True

    End Sub

    Private Sub Bo_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_agregar.Click

        Dim item = 0
        Dim presente = "no"
        Dim fila_editar = 0
        While item < DG_prod_modif.Rows.Count
            If DG_prod_modif.Rows(item).Cells(5).Value = cb_proveedores.Text Then
                presente = "si"
                fila_editar = item
            End If
            item = item + 1
        End While
        If presente = "no" Then
            'agrego una nueva fila
            Dim newCustomersRow As DataRow = Producto_ds.Tables("ProductoModificar").NewRow()
            newCustomersRow("Prov_id") = ds_proveedor.Tables(0).Rows(cb_proveedores.SelectedIndex).Item("Prov_id").ToString
            newCustomersRow("Prod_id") = DG_Producto.CurrentRow.Cells(0).Value
            newCustomersRow("Prov_Prod_Com_id") = 0
            newCustomersRow("Prov_Prod_id") = 0
            newCustomersRow("Prov_Prod_Com_precio") = Tx_compra_modif.Text
            newCustomersRow("Prod_precio_vta") = tx_venta_modif.Text
            newCustomersRow("Prod_stock") = CInt(Tx_stock_modif.Text) + CInt(DG_prod_modif.CurrentRow.Cells(8).Value)
            newCustomersRow("Prod_ptorepo") = tx_ptorepo.Text
            Dim fechacompra As Date = DT_fecha_compra.Text
            newCustomersRow("Prov_prod_com_fecha") = fechacompra.ToString("dd/MM/yyy")
            newCustomersRow("Prov_nombre") = cb_proveedores.Text
            Producto_ds.Tables("ProductoModificar").Rows.Add(newCustomersRow)
            DG_prod_modif.DataSource = Producto_ds.Tables("ProductoModificar")
            'Producto_limpiar()

        Else
            Dim result As DialogResult
            result = MessageBox.Show("Los atributos fueron modificados", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prov_nombre") = cb_proveedores.Text
                Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prod_stock") = CInt(Tx_stock_modif.Text) + CInt(Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prod_stock"))
                Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("Prov_Prod_Com_precio") = Tx_compra_modif.Text
                Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prod_precio_vta") = tx_venta_modif.Text
                Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prod_ptorepo") = tx_ptorepo.Text
                Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("Prov_Prod_Com_fecha") = DT_fecha_compra.Text
                DG_prod_modif.DataSource = Producto_ds.Tables("ProductoModificar")
            End If
        End If

        'Actualizar la grilla todos los valores en comun stock precio vta pto repo
        Dim a As Integer = 0
        While a < DG_prod_modif.Rows.Count
            If cb_proveedores.Text <> Producto_ds.Tables("ProductoModificar").Rows(a).Item("prov_nombre") Then
                Dim stock_grilla As Integer = CInt(Producto_ds.Tables("ProductoModificar").Rows(a).Item("prod_stock"))

                Producto_ds.Tables("ProductoModificar").Rows(a).Item("prod_stock") = CInt(Tx_stock_modif.Text) + stock_grilla
                Producto_ds.Tables("ProductoModificar").Rows(a).Item("prod_precio_vta") = tx_venta_modif.Text
                Producto_ds.Tables("ProductoModificar").Rows(a).Item("prod_ptorepo") = tx_ptorepo.Text
            End If
            a = a + 1
        End While
        Producto_limpiar()
        GroupBox4.Enabled = False

    End Sub

    Private Sub Producto_limpiar()

        'Tx_prov_modif.Text = Nothing
        tx_ptorepo.Text = Nothing
        Tx_stock_modif.Text = Nothing
        tx_venta_modif.Text = Nothing
        Tx_compra_modif.Text = Nothing
        DT_fecha_compra.Text = Today
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Proveedor_alta.Origen_alta("producto_modificar")
        Proveedor_alta.Show()
    End Sub

    Private Sub Producto_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Clipboard.SetDataObject(Me.PictureBox1.Image)
        deshabilitar()
        tx_codbarra_modif.Focus()
        Cargarcombo_proveedor()
        Cargarcombo_marca()
    End Sub


    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click

        If DG_prod_modif.Rows.Count <> 0 Then
            Dim item = 0
            While item < DG_prod_modif.Rows.Count
                Dim variable As Integer = DG_prod_modif.Rows(item).Cells(3).Value

                Dim dt_provprodcom As New DataSet
                dt_provprodcom = DAproducto.Prov_prod_com_buscar(DG_prod_modif.Rows(item).Cells(3).Value) 'la colum 3 es prov_prod_com_id
                'busco en bd para ver si existe, y veo si hago un update o agregar uno nuevo
                If dt_provprodcom.Tables(0).Rows.Count <> 0 Then
                    'modifico
                    'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////





                    Dim producto_foto As Byte()
                    producto_foto = Nothing
                    If PictureBox1.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
                        Dim ms = New MemoryStream
                        Dim fs = New FileStream(PictureBox1.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                        ms.SetLength(fs.Length)
                        fs.Read(ms.GetBuffer(), 0, fs.Length)
                        producto_foto = ms.GetBuffer
                        ms.Flush()
                        fs.Close()
                    Else
                        'si no tiene foto, le pongo x defecto la q esta en picture.image
                        Dim ms = New MemoryStream
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        producto_foto = ms.GetBuffer
                        ms.Flush()
                    End If
                    Dim ds_provprodcom As DataSet = DAproducto.ProdProvCom_modificar(DG_prod_modif.Rows(item).Cells(3).Value, DG_prod_modif.Rows(item).Cells(6).Value, DG_prod_modif.Rows(item).Cells(10).Value)
                    Dim ds_prod As DataSet = DAproducto.Producto_modificar(DG_prod_modif.Rows(item).Cells(1).Value, DG_prod_modif.Rows(item).Cells(7).Value, DG_prod_modif.Rows(item).Cells(8).Value, DG_prod_modif.Rows(item).Cells(9).Value)
                    Dim idmarca As Integer = cb_marca.SelectedValue
                    Dim producto_id As Integer = DG_Producto.CurrentRow.Cells(0).Value
                    Dim ds_proddatos As DataSet = DAproducto.Producto_modifDatos(producto_id, tx_descripcion.Text, tx_descrilarga.Text, tx_codbarra.Text, idmarca, tx_unimedida.Text, producto_foto)

                Else
                    'doy de alta
                    Dim ds_provprod As DataSet = DAproducto.ProveedorProducto_alta(DG_prod_modif.Rows(item).Cells(0).Value, DG_prod_modif.Rows(item).Cells(1).Value)
                    Dim provprodid As Integer = ds_provprod.Tables(0).Rows(0).Item(0)
                    DAproducto.ProveedorProductoCompra_alta(provprodid, DG_prod_modif.Rows(item).Cells(10).Value, DG_prod_modif.Rows(item).Cells(6).Value)

                End If
                item = item + 1
            End While
            MessageBox.Show("El producto se modifico correctamente", "Sistema de Gestion")
            DG_Producto.Rows.Clear()
            Prod_modif_limpiar()
            Me.TabControl1.SelectedTab = TabPage1
            'DG_prod_modif.Refresh()

            deshabilitar()
        End If

    End Sub

    Public Sub Prod_modif_limpiar()
        GroupBox1.Enabled = True
        'DG_Producto.Rows.Clear()
        DG_prod_modif.DataSource = Nothing
        Producto_ds.Tables("ProductoModificar").Rows.Clear()
        Tx_Codinterno.Text = Nothing
        Tx_nomprod_modif.Text = Nothing
        tx_codbarra_modif.Text = Nothing
        Tx_cod_modif.Text = Nothing
        tx_descripcion.Text = Nothing
        tx_descrilarga.Text = Nothing
        tx_unimedida.Text = Nothing
        tx_codbarra.Text = Nothing
        tx_codbarra_modif.Focus()
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox1.Image = bmap
        End If
    End Sub

    Public Sub deshabilitar()
        TabPage2.Enabled = False
        TabPage3.Enabled = False
    End Sub
    Public Sub habilitar()
        TabPage2.Enabled = True
        TabPage3.Enabled = True
    End Sub

    Private Sub Buscar_codbarra()
        If tx_codbarra_modif.Text <> "" Then
            Me.DG_Producto.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproducto.producto_buscarcodbarra(Me.tx_codbarra_modif.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DG_Producto.Rows().Add()
                    DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(6) 'COD interno
                    DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(1) 'producto
                    DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(5) 'marca
                    DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(3) 'Stock
                    DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(4) 'ptoreposicion
                    If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                        DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                        DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                    End If
                    fila = fila + 1
                End While
                DG_Producto.ClearSelection()
            End If
            Me.tx_codbarra_modif.Select()
        Else
            Prod_obtenertodo()
        End If

    End Sub

    Private Sub Bo_codbarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_codbarra.Click
        Buscar_codbarra()
    End Sub

    Public Sub Buscar_prodnom()
        If Tx_nomprod_modif.Text <> "" Then
            Me.DG_Producto.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproducto.producto_buscarnom(Me.Tx_nomprod_modif.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DG_Producto.Rows().Add()
                    DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(6) 'COD interno
                    DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(1) 'producto
                    DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(5) 'marca
                    DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(3) 'Stock
                    DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(4) 'ptoreposicion
                    If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                        DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                        DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                    End If
                    fila = fila + 1
                End While
                DG_Producto.ClearSelection()
            End If
            Me.Tx_nomprod_modif.Select()
        Else
            Prod_obtenertodo()
        End If

    End Sub

    Private Sub Bo_buscar_nombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_buscar_nombre.Click
        Buscar_prodnom()
    End Sub


    Private Sub Bo_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cargar.Click
        OpenFileDialog1.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Bo_deshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_deshacer.Click
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox1.Image = bmap
        End If
    End Sub

    Private Sub Bo_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_exportar.Click
        Dim saveImage As New SaveFileDialog 'Este es el SaveFileDialog
        Dim ruta As String = "" 'Para tener la ruta de la imagen
        saveImage.Title = "Guardar imagen como..." 'Título de la ventana
        saveImage.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        If saveImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Recuperar la ruta de la imagen si no está vacía
            If Not String.IsNullOrEmpty(saveImage.FileName) Then ruta = saveImage.FileName
            Dim myImg As Image = PictureBox1.Image 'Objeto Image para guardar la imagen del Picture

            Dim extension As String = ruta.Substring(ruta.Length - 3, 3) 'Recuperar los ultimos 3 caracteres de la extensió

            'ESTO SOLO FUNCIONA EN VISUAL BASIC 2008
            Select Case extension
                Case "bmp"
                    myImg.Save(ruta, System.Drawing.Imaging.ImageFormat.Bmp) 'Guardar en formato BMP
                Case "jpg"
                    PictureBox1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg) 'Guardar en formato JPG
                Case "png"
                    PictureBox1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Png) 'Guardar en formato PNG
            End Select
        End If
    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        Producto_limpiar()
        Prod_modif_limpiar()

        GroupBox4.Enabled = False

        deshabilitar()

        Me.TabControl1.SelectedTab = TabPage1
        GroupBox1.Enabled = True
        DG_prod_modif.DataSource = Nothing
        Producto_ds.Tables("ProductoModificar").Rows.Clear()

        'DG_Producto.Rows.Clear()
        tx_codbarra_modif.Text = Nothing
        Tx_Codinterno.Text = Nothing
        Tx_nomprod_modif.Text = Nothing
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox1.Image = bmap
        End If

    End Sub


    'Validaciones
    Private Sub Tx_Codinterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_Codinterno.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_codinterno()
        End If
    End Sub

    Private Sub Tx_nomprod_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_nomprod_modif.KeyPress
        'If Char.IsLetter(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_prodnom()
        End If
    End Sub

    Private Sub tx_codbarra_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_codbarra_modif.KeyPress
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_codbarra()
        End If
    End Sub

    Private Sub Tx_stock_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_stock_modif.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tx_ptorepo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_ptorepo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Tx_compra_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_compra_modif.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.Tx_compra_modif.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub tx_venta_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_venta_modif.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.tx_venta_modif.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    
    Private Sub Tx_Codinterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tx_Codinterno.TextChanged

    End Sub
End Class

