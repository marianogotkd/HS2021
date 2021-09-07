<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolución_gestión
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Devolución_gestión))
        Me.Devolucion = New System.Windows.Forms.TabControl()
        Me.TabPage0 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.BO_registrar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Combo_Stock = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx_Cant = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tx_entidad = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Tx_motivo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BO_Cargar = New System.Windows.Forms.Button()
        Me.Tx_CodLte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BO_Buscar_Cod = New System.Windows.Forms.Button()
        Me.ERROR_tx_entidad = New System.Windows.Forms.PictureBox()
        Me.tx_CodProd = New System.Windows.Forms.TextBox()
        Me.lb_dni_modif = New System.Windows.Forms.Label()
        Me.DT_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Lb_cod_dev = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ObtenerProdPorCodyLteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Devolucion_ds = New Aplicacion.Devolucion_ds()
        Me.ObtenerProdPorCodyLteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROD_presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcanomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Devolucion.SuspendLayout()
        Me.TabPage0.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_entidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenerProdPorCodyLteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Devolucion_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenerProdPorCodyLteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Devolucion
        '
        Me.Devolucion.Controls.Add(Me.TabPage0)
        Me.Devolucion.Location = New System.Drawing.Point(5, 4)
        Me.Devolucion.Name = "Devolucion"
        Me.Devolucion.SelectedIndex = 0
        Me.Devolucion.Size = New System.Drawing.Size(862, 544)
        Me.Devolucion.TabIndex = 1
        '
        'TabPage0
        '
        Me.TabPage0.Controls.Add(Me.Label13)
        Me.TabPage0.Controls.Add(Me.Bo_cancelar)
        Me.TabPage0.Controls.Add(Me.BO_registrar)
        Me.TabPage0.Controls.Add(Me.GroupBox5)
        Me.TabPage0.Controls.Add(Me.GroupBox2)
        Me.TabPage0.Controls.Add(Me.DT_fecha)
        Me.TabPage0.Controls.Add(Me.Lb_cod_dev)
        Me.TabPage0.Controls.Add(Me.Label17)
        Me.TabPage0.Location = New System.Drawing.Point(4, 22)
        Me.TabPage0.Name = "TabPage0"
        Me.TabPage0.Size = New System.Drawing.Size(854, 518)
        Me.TabPage0.TabIndex = 1
        Me.TabPage0.Text = "Devolucion a Proveedor"
        Me.TabPage0.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(478, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 13)
        Me.Label13.TabIndex = 264
        Me.Label13.Text = "Fecha de alta del sistema:"
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bo_cancelar.Location = New System.Drawing.Point(562, 460)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(106, 43)
        Me.Bo_cancelar.TabIndex = 255
        Me.Bo_cancelar.Text = "Cancelar"
        Me.Bo_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bo_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'BO_registrar
        '
        Me.BO_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_registrar.Image = CType(resources.GetObject("BO_registrar.Image"), System.Drawing.Image)
        Me.BO_registrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_registrar.Location = New System.Drawing.Point(682, 460)
        Me.BO_registrar.Name = "BO_registrar"
        Me.BO_registrar.Size = New System.Drawing.Size(106, 43)
        Me.BO_registrar.TabIndex = 254
        Me.BO_registrar.Text = "Registrar"
        Me.BO_registrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BO_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BO_registrar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Combo_Stock)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.tx_Cant)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Tx_entidad)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Tx_motivo)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 307)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(849, 147)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos del Formulario "
        '
        'Combo_Stock
        '
        Me.Combo_Stock.FormattingEnabled = True
        Me.Combo_Stock.Items.AddRange(New Object() {"SI", "NO"})
        Me.Combo_Stock.Location = New System.Drawing.Point(532, 26)
        Me.Combo_Stock.Name = "Combo_Stock"
        Me.Combo_Stock.Size = New System.Drawing.Size(48, 21)
        Me.Combo_Stock.TabIndex = 261
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(315, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 15)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "¿El Producto Se Encuentra en Stock?"
        '
        'tx_Cant
        '
        Me.tx_Cant.Location = New System.Drawing.Point(193, 25)
        Me.tx_Cant.Name = "tx_Cant"
        Me.tx_Cant.Size = New System.Drawing.Size(93, 20)
        Me.tx_Cant.TabIndex = 259
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(1, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 258
        Me.Label2.Text = "Cantidad"
        '
        'Tx_entidad
        '
        Me.Tx_entidad.Location = New System.Drawing.Point(193, 107)
        Me.Tx_entidad.Name = "Tx_entidad"
        Me.Tx_entidad.Size = New System.Drawing.Size(506, 20)
        Me.Tx_entidad.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label19.Location = New System.Drawing.Point(2, 107)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(185, 15)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Persona o Entidad que Devuelve"
        '
        'Tx_motivo
        '
        Me.Tx_motivo.Location = New System.Drawing.Point(193, 61)
        Me.Tx_motivo.Name = "Tx_motivo"
        Me.Tx_motivo.Size = New System.Drawing.Size(506, 20)
        Me.Tx_motivo.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label18.Location = New System.Drawing.Point(2, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 15)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Motivo de La Devolucion"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BO_Cargar)
        Me.GroupBox2.Controls.Add(Me.Tx_CodLte)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.BO_Buscar_Cod)
        Me.GroupBox2.Controls.Add(Me.ERROR_tx_entidad)
        Me.GroupBox2.Controls.Add(Me.tx_CodProd)
        Me.GroupBox2.Controls.Add(Me.lb_dni_modif)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(4, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(848, 239)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda Producto"
        '
        'BO_Cargar
        '
        Me.BO_Cargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Cargar.Image = CType(resources.GetObject("BO_Cargar.Image"), System.Drawing.Image)
        Me.BO_Cargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Cargar.Location = New System.Drawing.Point(538, 14)
        Me.BO_Cargar.Name = "BO_Cargar"
        Me.BO_Cargar.Size = New System.Drawing.Size(118, 47)
        Me.BO_Cargar.TabIndex = 258
        Me.BO_Cargar.Text = "Nueva Busqueda"
        Me.BO_Cargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BO_Cargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BO_Cargar.UseVisualStyleBackColor = True
        Me.BO_Cargar.Visible = False
        '
        'Tx_CodLte
        '
        Me.Tx_CodLte.Location = New System.Drawing.Point(394, 25)
        Me.Tx_CodLte.Name = "Tx_CodLte"
        Me.Tx_CodLte.Size = New System.Drawing.Size(138, 20)
        Me.Tx_CodLte.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(298, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Codigo de Lote"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(0, 67)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(842, 148)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Producto"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.PRODcodigoDataGridViewTextBoxColumn, Me.PRODnombreDataGridViewTextBoxColumn, Me.PROD_presentacion, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.MarcanomDataGridViewTextBoxColumn, Me.ProvnombreDataGridViewTextBoxColumn, Me.PRODidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ObtenerProdPorCodyLteBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(830, 126)
        Me.DataGridView1.TabIndex = 2
        '
        'BO_Buscar_Cod
        '
        Me.BO_Buscar_Cod.Image = CType(resources.GetObject("BO_Buscar_Cod.Image"), System.Drawing.Image)
        Me.BO_Buscar_Cod.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Buscar_Cod.Location = New System.Drawing.Point(538, 14)
        Me.BO_Buscar_Cod.Name = "BO_Buscar_Cod"
        Me.BO_Buscar_Cod.Size = New System.Drawing.Size(75, 38)
        Me.BO_Buscar_Cod.TabIndex = 2
        Me.BO_Buscar_Cod.Text = "Busqueda"
        Me.BO_Buscar_Cod.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BO_Buscar_Cod.UseVisualStyleBackColor = True
        '
        'ERROR_tx_entidad
        '
        Me.ERROR_tx_entidad.Image = CType(resources.GetObject("ERROR_tx_entidad.Image"), System.Drawing.Image)
        Me.ERROR_tx_entidad.Location = New System.Drawing.Point(743, 29)
        Me.ERROR_tx_entidad.Name = "ERROR_tx_entidad"
        Me.ERROR_tx_entidad.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_entidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_entidad.TabIndex = 257
        Me.ERROR_tx_entidad.TabStop = False
        Me.ERROR_tx_entidad.Visible = False
        '
        'tx_CodProd
        '
        Me.tx_CodProd.Location = New System.Drawing.Point(140, 25)
        Me.tx_CodProd.Name = "tx_CodProd"
        Me.tx_CodProd.Size = New System.Drawing.Size(138, 20)
        Me.tx_CodProd.TabIndex = 1
        '
        'lb_dni_modif
        '
        Me.lb_dni_modif.AutoSize = True
        Me.lb_dni_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni_modif.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_dni_modif.Location = New System.Drawing.Point(19, 26)
        Me.lb_dni_modif.Name = "lb_dni_modif"
        Me.lb_dni_modif.Size = New System.Drawing.Size(115, 15)
        Me.lb_dni_modif.TabIndex = 0
        Me.lb_dni_modif.Text = "Codigo de Producto"
        '
        'DT_fecha
        '
        Me.DT_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_fecha.Location = New System.Drawing.Point(640, 24)
        Me.DT_fecha.Name = "DT_fecha"
        Me.DT_fecha.Size = New System.Drawing.Size(135, 20)
        Me.DT_fecha.TabIndex = 8
        '
        'Lb_cod_dev
        '
        Me.Lb_cod_dev.AutoSize = True
        Me.Lb_cod_dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Lb_cod_dev.Location = New System.Drawing.Point(156, 22)
        Me.Lb_cod_dev.Name = "Lb_cod_dev"
        Me.Lb_cod_dev.Size = New System.Drawing.Size(21, 22)
        Me.Lb_cod_dev.TabIndex = 9
        Me.Lb_cod_dev.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Location = New System.Drawing.Point(7, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(143, 22)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Devolucion N°:"
        '
        'ObtenerProdPorCodyLteBindingSource1
        '
        Me.ObtenerProdPorCodyLteBindingSource1.DataMember = "ObtenerProd_Por_CodyLte"
        Me.ObtenerProdPorCodyLteBindingSource1.DataSource = Me.Devolucion_ds
        '
        'Devolucion_ds
        '
        Me.Devolucion_ds.DataSetName = "Devolucion_ds"
        Me.Devolucion_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObtenerProdPorCodyLteBindingSource
        '
        Me.ObtenerProdPorCodyLteBindingSource.DataMember = "ObtenerProd_Por_CodyLte"
        Me.ObtenerProdPorCodyLteBindingSource.DataSource = Me.Devolucion_ds
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "RECEPCION_id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "RECEPCION_id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'PRODcodigoDataGridViewTextBoxColumn
        '
        Me.PRODcodigoDataGridViewTextBoxColumn.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.Name = "PRODcodigoDataGridViewTextBoxColumn"
        Me.PRODcodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODnombreDataGridViewTextBoxColumn
        '
        Me.PRODnombreDataGridViewTextBoxColumn.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.PRODnombreDataGridViewTextBoxColumn.Name = "PRODnombreDataGridViewTextBoxColumn"
        Me.PRODnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PROD_presentacion
        '
        Me.PROD_presentacion.DataPropertyName = "PROD_presentacion"
        Me.PROD_presentacion.HeaderText = "Presentacion"
        Me.PROD_presentacion.Name = "PROD_presentacion"
        Me.PROD_presentacion.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "RECEPCION_nrolote"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "RECEPCION_fecha_sistema"
        Me.DataGridViewTextBoxColumn12.HeaderText = "RECEPCION_fecha_sistema"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "RECEPCION_cantidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "RECEPCION_nrofactura"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nro de Factura"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "RECEPCION_fechafactura"
        Me.DataGridViewTextBoxColumn15.HeaderText = "RECEPCION_fechafactura"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'MarcanomDataGridViewTextBoxColumn
        '
        Me.MarcanomDataGridViewTextBoxColumn.DataPropertyName = "Marca_nom"
        Me.MarcanomDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcanomDataGridViewTextBoxColumn.Name = "MarcanomDataGridViewTextBoxColumn"
        Me.MarcanomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvnombreDataGridViewTextBoxColumn
        '
        Me.ProvnombreDataGridViewTextBoxColumn.DataPropertyName = "Prov_nombre"
        Me.ProvnombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProvnombreDataGridViewTextBoxColumn.Name = "ProvnombreDataGridViewTextBoxColumn"
        Me.ProvnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        '
        'Devolución_gestión
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 553)
        Me.Controls.Add(Me.Devolucion)
        Me.Name = "Devolución_gestión"
        Me.Text = "Devolución_gestión"
        Me.Devolucion.ResumeLayout(False)
        Me.TabPage0.ResumeLayout(False)
        Me.TabPage0.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_entidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenerProdPorCodyLteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Devolucion_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenerProdPorCodyLteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Devolucion As System.Windows.Forms.TabControl
    Friend WithEvents TabPage0 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_Buscar_Cod As System.Windows.Forms.Button
    Friend WithEvents tx_CodProd As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni_modif As System.Windows.Forms.Label
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents BO_registrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DT_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tx_entidad As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Tx_motivo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents RECEPCIONnombreproductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONcodigoproductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONPRODTidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONcondialmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONfechavencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONMarcaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lb_cod_dev As System.Windows.Forms.Label
    Friend WithEvents ERROR_tx_entidad As System.Windows.Forms.PictureBox
    Friend WithEvents Tx_CodLte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tx_Cant As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RECEPCIONidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONfechasistemaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONnroloteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONcantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONnrofacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONfechafacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ObtenerProdPorCodyLteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Devolucion_ds As Aplicacion.Devolucion_ds
    Friend WithEvents Combo_Stock As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BO_Cargar As System.Windows.Forms.Button
    Friend WithEvents ObtenerProdPorCodyLteBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROD_presentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcanomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
