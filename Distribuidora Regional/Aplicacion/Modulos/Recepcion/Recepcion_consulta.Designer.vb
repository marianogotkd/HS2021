<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recepcion_consulta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recepcion_consulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODTnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcondialmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcanttotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcanomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODtotalUivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODtotalivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROD_presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Recepcion_ds = New Aplicacion.Recepcion_ds()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lb_cantidadtotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lb_presentacion = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lb_código = New System.Windows.Forms.Label()
        Me.Lb_nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PRODDETidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETcodigorecepcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETfechasistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETnroloteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETcantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETfechavencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETnrofacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETfechafacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductodetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TX_buscar_codigo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BO_ape = New System.Windows.Forms.Button()
        Me.TX_buscar_nombre = New System.Windows.Forms.TextBox()
        Me.lb_ape_modif = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Recepcion_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductodetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 455)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de stock"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 19)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer1.Size = New System.Drawing.Size(814, 416)
        Me.SplitContainer1.SplitterDistance = 271
        Me.SplitContainer1.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODidDataGridViewTextBoxColumn, Me.PRODcodigoDataGridViewTextBoxColumn, Me.PRODnombreDataGridViewTextBoxColumn, Me.PRODTnomDataGridViewTextBoxColumn, Me.PRODcondialmDataGridViewTextBoxColumn, Me.PRODcanttotalDataGridViewTextBoxColumn, Me.MarcanomDataGridViewTextBoxColumn, Me.PRODestadoDataGridViewTextBoxColumn, Me.PRODivaDataGridViewTextBoxColumn, Me.PRODtotalUivaDataGridViewTextBoxColumn, Me.PRODtotalivaDataGridViewTextBoxColumn, Me.PROD_presentacion})
        Me.DataGridView1.DataSource = Me.ProductoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(265, 410)
        Me.DataGridView1.TabIndex = 0
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        '
        'PRODcodigoDataGridViewTextBoxColumn
        '
        Me.PRODcodigoDataGridViewTextBoxColumn.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.PRODcodigoDataGridViewTextBoxColumn.Name = "PRODcodigoDataGridViewTextBoxColumn"
        Me.PRODcodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODcodigoDataGridViewTextBoxColumn.Width = 80
        '
        'PRODnombreDataGridViewTextBoxColumn
        '
        Me.PRODnombreDataGridViewTextBoxColumn.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.Name = "PRODnombreDataGridViewTextBoxColumn"
        Me.PRODnombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODnombreDataGridViewTextBoxColumn.Width = 165
        '
        'PRODTnomDataGridViewTextBoxColumn
        '
        Me.PRODTnomDataGridViewTextBoxColumn.DataPropertyName = "PROD_T_nom"
        Me.PRODTnomDataGridViewTextBoxColumn.HeaderText = "PROD_T_nom"
        Me.PRODTnomDataGridViewTextBoxColumn.Name = "PRODTnomDataGridViewTextBoxColumn"
        Me.PRODTnomDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODTnomDataGridViewTextBoxColumn.Visible = False
        '
        'PRODcondialmDataGridViewTextBoxColumn
        '
        Me.PRODcondialmDataGridViewTextBoxColumn.DataPropertyName = "PROD_condi_alm"
        Me.PRODcondialmDataGridViewTextBoxColumn.HeaderText = "PROD_condi_alm"
        Me.PRODcondialmDataGridViewTextBoxColumn.Name = "PRODcondialmDataGridViewTextBoxColumn"
        Me.PRODcondialmDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODcondialmDataGridViewTextBoxColumn.Visible = False
        '
        'PRODcanttotalDataGridViewTextBoxColumn
        '
        Me.PRODcanttotalDataGridViewTextBoxColumn.DataPropertyName = "PROD_cant_total"
        Me.PRODcanttotalDataGridViewTextBoxColumn.HeaderText = "PROD_cant_total"
        Me.PRODcanttotalDataGridViewTextBoxColumn.Name = "PRODcanttotalDataGridViewTextBoxColumn"
        Me.PRODcanttotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODcanttotalDataGridViewTextBoxColumn.Visible = False
        '
        'MarcanomDataGridViewTextBoxColumn
        '
        Me.MarcanomDataGridViewTextBoxColumn.DataPropertyName = "Marca_nom"
        Me.MarcanomDataGridViewTextBoxColumn.HeaderText = "Marca_nom"
        Me.MarcanomDataGridViewTextBoxColumn.Name = "MarcanomDataGridViewTextBoxColumn"
        Me.MarcanomDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcanomDataGridViewTextBoxColumn.Visible = False
        '
        'PRODestadoDataGridViewTextBoxColumn
        '
        Me.PRODestadoDataGridViewTextBoxColumn.DataPropertyName = "PROD_estado"
        Me.PRODestadoDataGridViewTextBoxColumn.HeaderText = "PROD_estado"
        Me.PRODestadoDataGridViewTextBoxColumn.Name = "PRODestadoDataGridViewTextBoxColumn"
        Me.PRODestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODestadoDataGridViewTextBoxColumn.Visible = False
        '
        'PRODivaDataGridViewTextBoxColumn
        '
        Me.PRODivaDataGridViewTextBoxColumn.DataPropertyName = "PROD_iva"
        Me.PRODivaDataGridViewTextBoxColumn.HeaderText = "PROD_iva"
        Me.PRODivaDataGridViewTextBoxColumn.Name = "PRODivaDataGridViewTextBoxColumn"
        Me.PRODivaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODivaDataGridViewTextBoxColumn.Visible = False
        '
        'PRODtotalUivaDataGridViewTextBoxColumn
        '
        Me.PRODtotalUivaDataGridViewTextBoxColumn.DataPropertyName = "PROD_totalU_iva"
        Me.PRODtotalUivaDataGridViewTextBoxColumn.HeaderText = "PROD_totalU_iva"
        Me.PRODtotalUivaDataGridViewTextBoxColumn.Name = "PRODtotalUivaDataGridViewTextBoxColumn"
        Me.PRODtotalUivaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODtotalUivaDataGridViewTextBoxColumn.Visible = False
        '
        'PRODtotalivaDataGridViewTextBoxColumn
        '
        Me.PRODtotalivaDataGridViewTextBoxColumn.DataPropertyName = "PROD_total_iva"
        Me.PRODtotalivaDataGridViewTextBoxColumn.HeaderText = "PROD_total_iva"
        Me.PRODtotalivaDataGridViewTextBoxColumn.Name = "PRODtotalivaDataGridViewTextBoxColumn"
        Me.PRODtotalivaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODtotalivaDataGridViewTextBoxColumn.Visible = False
        '
        'PROD_presentacion
        '
        Me.PROD_presentacion.DataPropertyName = "PROD_presentacion"
        Me.PROD_presentacion.HeaderText = "PROD_presentacion"
        Me.PROD_presentacion.Name = "PROD_presentacion"
        Me.PROD_presentacion.ReadOnly = True
        Me.PROD_presentacion.Visible = False
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Recepcion_ds
        '
        'Recepcion_ds
        '
        Me.Recepcion_ds.DataSetName = "Recepcion_ds"
        Me.Recepcion_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Lb_cantidadtotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Lb_presentacion)
        Me.GroupBox2.Controls.Add(Me.label4)
        Me.GroupBox2.Controls.Add(Me.lb_código)
        Me.GroupBox2.Controls.Add(Me.Lb_nombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 82)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Cantidad total en stock:"
        '
        'Lb_cantidadtotal
        '
        Me.Lb_cantidadtotal.AutoSize = True
        Me.Lb_cantidadtotal.BackColor = System.Drawing.Color.Transparent
        Me.Lb_cantidadtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cantidadtotal.Location = New System.Drawing.Point(445, 35)
        Me.Lb_cantidadtotal.Name = "Lb_cantidadtotal"
        Me.Lb_cantidadtotal.Size = New System.Drawing.Size(15, 15)
        Me.Lb_cantidadtotal.TabIndex = 37
        Me.Lb_cantidadtotal.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Presentación:"
        '
        'Lb_presentacion
        '
        Me.Lb_presentacion.AutoSize = True
        Me.Lb_presentacion.BackColor = System.Drawing.Color.Transparent
        Me.Lb_presentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_presentacion.Location = New System.Drawing.Point(106, 61)
        Me.Lb_presentacion.Name = "Lb_presentacion"
        Me.Lb_presentacion.Size = New System.Drawing.Size(259, 15)
        Me.Lb_presentacion.TabIndex = 35
        Me.Lb_presentacion.Text = "..............................................................."
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(3, 35)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 15)
        Me.label4.TabIndex = 34
        Me.label4.Text = "Código:"
        '
        'lb_código
        '
        Me.lb_código.AutoSize = True
        Me.lb_código.BackColor = System.Drawing.Color.Transparent
        Me.lb_código.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_código.Location = New System.Drawing.Point(61, 35)
        Me.lb_código.Name = "lb_código"
        Me.lb_código.Size = New System.Drawing.Size(39, 15)
        Me.lb_código.TabIndex = 33
        Me.lb_código.Text = "0000"
        '
        'Lb_nombre
        '
        Me.Lb_nombre.AutoSize = True
        Me.Lb_nombre.BackColor = System.Drawing.Color.Transparent
        Me.Lb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nombre.Location = New System.Drawing.Point(165, 7)
        Me.Lb_nombre.Name = "Lb_nombre"
        Me.Lb_nombre.Size = New System.Drawing.Size(199, 15)
        Me.Lb_nombre.TabIndex = 32
        Me.Lb_nombre.Text = "................................................"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Resumen del producto:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODDETidDataGridViewTextBoxColumn, Me.PRODDETcodigorecepcionDataGridViewTextBoxColumn, Me.PRODidDataGridViewTextBoxColumn1, Me.PRODDETfechasistemaDataGridViewTextBoxColumn, Me.PRODDETnroloteDataGridViewTextBoxColumn, Me.PRODDETcantidadDataGridViewTextBoxColumn, Me.PRODDETfechavencimientoDataGridViewTextBoxColumn, Me.PRODDETnrofacturaDataGridViewTextBoxColumn, Me.PRODDETfechafacturaDataGridViewTextBoxColumn, Me.ProvidDataGridViewTextBoxColumn, Me.PRODDETestadoDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridView2.DataSource = Me.ProductodetalleBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(533, 322)
        Me.DataGridView2.TabIndex = 1
        '
        'PRODDETidDataGridViewTextBoxColumn
        '
        Me.PRODDETidDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_id"
        Me.PRODDETidDataGridViewTextBoxColumn.HeaderText = "PRODDET_id"
        Me.PRODDETidDataGridViewTextBoxColumn.Name = "PRODDETidDataGridViewTextBoxColumn"
        Me.PRODDETidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODDETidDataGridViewTextBoxColumn.Visible = False
        '
        'PRODDETcodigorecepcionDataGridViewTextBoxColumn
        '
        Me.PRODDETcodigorecepcionDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_codigorecepcion"
        Me.PRODDETcodigorecepcionDataGridViewTextBoxColumn.HeaderText = "Nº de recepcion"
        Me.PRODDETcodigorecepcionDataGridViewTextBoxColumn.Name = "PRODDETcodigorecepcionDataGridViewTextBoxColumn"
        Me.PRODDETcodigorecepcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODDETcodigorecepcionDataGridViewTextBoxColumn.Width = 120
        '
        'PRODidDataGridViewTextBoxColumn1
        '
        Me.PRODidDataGridViewTextBoxColumn1.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn1.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn1.Name = "PRODidDataGridViewTextBoxColumn1"
        Me.PRODidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn1.Visible = False
        '
        'PRODDETfechasistemaDataGridViewTextBoxColumn
        '
        Me.PRODDETfechasistemaDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_fecha_sistema"
        Me.PRODDETfechasistemaDataGridViewTextBoxColumn.HeaderText = "Fecha de sistema"
        Me.PRODDETfechasistemaDataGridViewTextBoxColumn.Name = "PRODDETfechasistemaDataGridViewTextBoxColumn"
        Me.PRODDETfechasistemaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODDETfechasistemaDataGridViewTextBoxColumn.Visible = False
        '
        'PRODDETnroloteDataGridViewTextBoxColumn
        '
        Me.PRODDETnroloteDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_nrolote"
        Me.PRODDETnroloteDataGridViewTextBoxColumn.HeaderText = "Nº lote"
        Me.PRODDETnroloteDataGridViewTextBoxColumn.Name = "PRODDETnroloteDataGridViewTextBoxColumn"
        Me.PRODDETnroloteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODDETcantidadDataGridViewTextBoxColumn
        '
        Me.PRODDETcantidadDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PRODDETcantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PRODDETcantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad en Stock"
        Me.PRODDETcantidadDataGridViewTextBoxColumn.Name = "PRODDETcantidadDataGridViewTextBoxColumn"
        Me.PRODDETcantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODDETcantidadDataGridViewTextBoxColumn.Width = 120
        '
        'PRODDETfechavencimientoDataGridViewTextBoxColumn
        '
        Me.PRODDETfechavencimientoDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_fechavencimiento"
        Me.PRODDETfechavencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha vto."
        Me.PRODDETfechavencimientoDataGridViewTextBoxColumn.Name = "PRODDETfechavencimientoDataGridViewTextBoxColumn"
        Me.PRODDETfechavencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODDETfechavencimientoDataGridViewTextBoxColumn.Visible = False
        '
        'PRODDETnrofacturaDataGridViewTextBoxColumn
        '
        Me.PRODDETnrofacturaDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_nrofactura"
        Me.PRODDETnrofacturaDataGridViewTextBoxColumn.HeaderText = "PRODDET_nrofactura"
        Me.PRODDETnrofacturaDataGridViewTextBoxColumn.Name = "PRODDETnrofacturaDataGridViewTextBoxColumn"
        Me.PRODDETnrofacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODDETnrofacturaDataGridViewTextBoxColumn.Visible = False
        '
        'PRODDETfechafacturaDataGridViewTextBoxColumn
        '
        Me.PRODDETfechafacturaDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_fechafactura"
        Me.PRODDETfechafacturaDataGridViewTextBoxColumn.HeaderText = "PRODDET_fechafactura"
        Me.PRODDETfechafacturaDataGridViewTextBoxColumn.Name = "PRODDETfechafacturaDataGridViewTextBoxColumn"
        Me.PRODDETfechafacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODDETfechafacturaDataGridViewTextBoxColumn.Visible = False
        '
        'ProvidDataGridViewTextBoxColumn
        '
        Me.ProvidDataGridViewTextBoxColumn.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.Name = "ProvidDataGridViewTextBoxColumn"
        Me.ProvidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvidDataGridViewTextBoxColumn.Visible = False
        '
        'PRODDETestadoDataGridViewTextBoxColumn
        '
        Me.PRODDETestadoDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_estado"
        Me.PRODDETestadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.PRODDETestadoDataGridViewTextBoxColumn.Name = "PRODDETestadoDataGridViewTextBoxColumn"
        Me.PRODDETestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODDETestadoDataGridViewTextBoxColumn.Width = 140
        '
        'Column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Ver"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = ". . ."
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 50
        '
        'ProductodetalleBindingSource
        '
        Me.ProductodetalleBindingSource.DataMember = "Producto_detalle"
        Me.ProductodetalleBindingSource.DataSource = Me.Recepcion_ds
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Consulta de productos en Stock"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(740, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 26
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TX_buscar_codigo
        '
        Me.TX_buscar_codigo.Location = New System.Drawing.Point(543, 59)
        Me.TX_buscar_codigo.Name = "TX_buscar_codigo"
        Me.TX_buscar_codigo.Size = New System.Drawing.Size(191, 20)
        Me.TX_buscar_codigo.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(401, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 15)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Código de producto:"
        '
        'BO_ape
        '
        Me.BO_ape.Image = CType(resources.GetObject("BO_ape.Image"), System.Drawing.Image)
        Me.BO_ape.Location = New System.Drawing.Point(356, 53)
        Me.BO_ape.Name = "BO_ape"
        Me.BO_ape.Size = New System.Drawing.Size(30, 30)
        Me.BO_ape.TabIndex = 23
        Me.BO_ape.UseVisualStyleBackColor = True
        '
        'TX_buscar_nombre
        '
        Me.TX_buscar_nombre.Location = New System.Drawing.Point(145, 59)
        Me.TX_buscar_nombre.Name = "TX_buscar_nombre"
        Me.TX_buscar_nombre.Size = New System.Drawing.Size(205, 20)
        Me.TX_buscar_nombre.TabIndex = 21
        '
        'lb_ape_modif
        '
        Me.lb_ape_modif.AutoSize = True
        Me.lb_ape_modif.BackColor = System.Drawing.Color.Transparent
        Me.lb_ape_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ape_modif.Location = New System.Drawing.Point(17, 62)
        Me.lb_ape_modif.Name = "lb_ape_modif"
        Me.lb_ape_modif.Size = New System.Drawing.Size(122, 15)
        Me.lb_ape_modif.TabIndex = 22
        Me.lb_ape_modif.Text = "Nombre producto:"
        '
        'Recepcion_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 569)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TX_buscar_codigo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BO_ape)
        Me.Controls.Add(Me.TX_buscar_nombre)
        Me.Controls.Add(Me.lb_ape_modif)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Recepcion_consulta"
        Me.Text = "Consulta de productos en stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Recepcion_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductodetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TX_buscar_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BO_ape As System.Windows.Forms.Button
    Friend WithEvents TX_buscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lb_ape_modif As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Recepcion_ds As Aplicacion.Recepcion_ds
    Friend WithEvents ProductodetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODTnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcondialmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcanttotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcanomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODtotalUivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODtotalivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROD_presentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lb_cantidadtotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lb_presentacion As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents lb_código As System.Windows.Forms.Label
    Friend WithEvents Lb_nombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PRODDETidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETcodigorecepcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETfechasistemaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETnroloteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETcantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETfechavencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETnrofacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETfechafacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
End Class
