﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaRegional_nuevodiseño
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaRegional_nuevodiseño))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTime_fechsistema = New System.Windows.Forms.DateTimePicker()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lb_codigo = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTime_fechfactura = New System.Windows.Forms.DateTimePicker()
        Me.tx_nrofactura = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BO_Nuevo = New System.Windows.Forms.Button()
        Me.BO_Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_buscar_clie = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIcelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdirecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_venta_regional = New Aplicacion.DS_venta_regional()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lb_pagoparcial = New System.Windows.Forms.Label()
        Me.BO_editar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox_prodagregados = New System.Windows.Forms.GroupBox()
        Me.DG_PRODAGREGADOS = New System.Windows.Forms.DataGridView()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PRODcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODprecioUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta_Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcanomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosagregadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_venta_regional1 = New Aplicacion.DS_venta_regional()
        Me.BO_Quitar = New System.Windows.Forms.Button()
        Me.BO_cancelar = New System.Windows.Forms.Button()
        Me.BO_Guardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_venta_regional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox_prodagregados.SuspendLayout()
        CType(Me.DG_PRODAGREGADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosagregadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_venta_regional1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(218, 22)
        Me.Label14.TabIndex = 256
        Me.Label14.Text = "Venta de productos Nº:"
        '
        'DateTime_fechsistema
        '
        Me.DateTime_fechsistema.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_fechsistema.Location = New System.Drawing.Point(771, 12)
        Me.DateTime_fechsistema.Name = "DateTime_fechsistema"
        Me.DateTime_fechsistema.Size = New System.Drawing.Size(92, 20)
        Me.DateTime_fechsistema.TabIndex = 254
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lb_codigo)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.DateTime_fechsistema)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.DateTime_fechfactura)
        Me.TabPage1.Controls.Add(Me.tx_nrofactura)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.BO_Nuevo)
        Me.TabPage1.Controls.Add(Me.BO_Aceptar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(874, 541)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Venta: Cliente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lb_codigo
        '
        Me.lb_codigo.AutoSize = True
        Me.lb_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_codigo.Location = New System.Drawing.Point(234, 16)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(54, 22)
        Me.lb_codigo.TabIndex = 257
        Me.lb_codigo.Text = "0000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(612, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 13)
        Me.Label13.TabIndex = 253
        Me.Label13.Text = "Fecha de alta del sistema:"
        '
        'DateTime_fechfactura
        '
        Me.DateTime_fechfactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_fechfactura.Location = New System.Drawing.Point(504, 57)
        Me.DateTime_fechfactura.Name = "DateTime_fechfactura"
        Me.DateTime_fechfactura.Size = New System.Drawing.Size(114, 20)
        Me.DateTime_fechfactura.TabIndex = 250
        '
        'tx_nrofactura
        '
        Me.tx_nrofactura.Location = New System.Drawing.Point(183, 58)
        Me.tx_nrofactura.Name = "tx_nrofactura"
        Me.tx_nrofactura.Size = New System.Drawing.Size(190, 20)
        Me.tx_nrofactura.TabIndex = 249
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(390, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 252
        Me.Label11.Text = "Fecha de factura:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 13)
        Me.Label10.TabIndex = 251
        Me.Label10.Text = "Número de factura de venta:"
        '
        'BO_Nuevo
        '
        Me.BO_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Nuevo.Image = CType(resources.GetObject("BO_Nuevo.Image"), System.Drawing.Image)
        Me.BO_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Nuevo.Location = New System.Drawing.Point(8, 472)
        Me.BO_Nuevo.Name = "BO_Nuevo"
        Me.BO_Nuevo.Size = New System.Drawing.Size(132, 63)
        Me.BO_Nuevo.TabIndex = 247
        Me.BO_Nuevo.Text = "Nuevo Cliente"
        Me.BO_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_Nuevo, "Registrar nuevo cliente")
        Me.BO_Nuevo.UseVisualStyleBackColor = True
        '
        'BO_Aceptar
        '
        Me.BO_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Aceptar.Image = CType(resources.GetObject("BO_Aceptar.Image"), System.Drawing.Image)
        Me.BO_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Aceptar.Location = New System.Drawing.Point(404, 472)
        Me.BO_Aceptar.Name = "BO_Aceptar"
        Me.BO_Aceptar.Size = New System.Drawing.Size(108, 60)
        Me.BO_Aceptar.TabIndex = 246
        Me.BO_Aceptar.Text = "Aceptar"
        Me.BO_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BO_Aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_buscar_clie)
        Me.GroupBox1.Controls.Add(Me.DG_clientes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(858, 373)
        Me.GroupBox1.TabIndex = 245
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar cliente : "
        '
        'Txt_buscar_clie
        '
        Me.Txt_buscar_clie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_buscar_clie.Location = New System.Drawing.Point(9, 21)
        Me.Txt_buscar_clie.Name = "Txt_buscar_clie"
        Me.Txt_buscar_clie.Size = New System.Drawing.Size(843, 26)
        Me.Txt_buscar_clie.TabIndex = 238
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIidDataGridViewTextBoxColumn, Me.Column1, Me.CLInomDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLIcelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn, Me.CLIdirecDataGridViewTextBoxColumn, Me.CLIobservacionesDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.ClienteBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_clientes.DefaultCellStyle = DataGridViewCellStyle6
        Me.DG_clientes.Location = New System.Drawing.Point(9, 54)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(843, 307)
        Me.DG_clientes.TabIndex = 237
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Width = 200
        '
        'CLItelDataGridViewTextBoxColumn
        '
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIcelDataGridViewTextBoxColumn
        '
        Me.CLIcelDataGridViewTextBoxColumn.DataPropertyName = "CLI_cel"
        Me.CLIcelDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CLIcelDataGridViewTextBoxColumn.Name = "CLIcelDataGridViewTextBoxColumn"
        Me.CLIcelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIdirecDataGridViewTextBoxColumn
        '
        Me.CLIdirecDataGridViewTextBoxColumn.DataPropertyName = "CLI_direc"
        Me.CLIdirecDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.CLIdirecDataGridViewTextBoxColumn.Name = "CLIdirecDataGridViewTextBoxColumn"
        Me.CLIdirecDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIdirecDataGridViewTextBoxColumn.Width = 120
        '
        'CLIobservacionesDataGridViewTextBoxColumn
        '
        Me.CLIobservacionesDataGridViewTextBoxColumn.DataPropertyName = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.Name = "CLIobservacionesDataGridViewTextBoxColumn"
        Me.CLIobservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIobservacionesDataGridViewTextBoxColumn.Width = 150
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DS_venta_regional
        '
        'DS_venta_regional
        '
        Me.DS_venta_regional.DataSetName = "DS_venta_regional"
        Me.DS_venta_regional.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Lb_pagoparcial)
        Me.TabPage2.Controls.Add(Me.BO_editar)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.GroupBox_prodagregados)
        Me.TabPage2.Controls.Add(Me.BO_Quitar)
        Me.TabPage2.Controls.Add(Me.BO_cancelar)
        Me.TabPage2.Controls.Add(Me.BO_Guardar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(874, 541)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Venta: Productos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(606, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 46)
        Me.Button1.TabIndex = 260
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Agregar item seleccionado")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lb_pagoparcial
        '
        Me.Lb_pagoparcial.AutoSize = True
        Me.Lb_pagoparcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_pagoparcial.Location = New System.Drawing.Point(152, 484)
        Me.Lb_pagoparcial.Name = "Lb_pagoparcial"
        Me.Lb_pagoparcial.Size = New System.Drawing.Size(66, 25)
        Me.Lb_pagoparcial.TabIndex = 272
        Me.Lb_pagoparcial.Text = "00,00"
        '
        'BO_editar
        '
        Me.BO_editar.Enabled = False
        Me.BO_editar.Image = CType(resources.GetObject("BO_editar.Image"), System.Drawing.Image)
        Me.BO_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_editar.Location = New System.Drawing.Point(536, 483)
        Me.BO_editar.Name = "BO_editar"
        Me.BO_editar.Size = New System.Drawing.Size(64, 47)
        Me.BO_editar.TabIndex = 240
        Me.BO_editar.Text = "Editar"
        Me.BO_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_editar, "Editar productos agregados")
        Me.BO_editar.UseVisualStyleBackColor = True
        Me.BO_editar.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 485)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 25)
        Me.Label6.TabIndex = 271
        Me.Label6.Text = "Monto total: $"
        '
        'GroupBox_prodagregados
        '
        Me.GroupBox_prodagregados.Controls.Add(Me.DG_PRODAGREGADOS)
        Me.GroupBox_prodagregados.Enabled = False
        Me.GroupBox_prodagregados.Location = New System.Drawing.Point(11, 32)
        Me.GroupBox_prodagregados.Name = "GroupBox_prodagregados"
        Me.GroupBox_prodagregados.Size = New System.Drawing.Size(853, 446)
        Me.GroupBox_prodagregados.TabIndex = 239
        Me.GroupBox_prodagregados.TabStop = False
        Me.GroupBox_prodagregados.Text = "Productos agregados"
        '
        'DG_PRODAGREGADOS
        '
        Me.DG_PRODAGREGADOS.AllowUserToAddRows = False
        Me.DG_PRODAGREGADOS.AllowUserToDeleteRows = False
        Me.DG_PRODAGREGADOS.AllowUserToResizeRows = False
        Me.DG_PRODAGREGADOS.AutoGenerateColumns = False
        Me.DG_PRODAGREGADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_PRODAGREGADOS.BackgroundColor = System.Drawing.Color.White
        Me.DG_PRODAGREGADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PRODAGREGADOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODidDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.PRODcodigoDataGridViewTextBoxColumn, Me.PRODnombreDataGridViewTextBoxColumn, Me.PRODprecioUDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.Venta_Lote, Me.MarcanomDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.DG_PRODAGREGADOS.DataSource = Me.ProductosagregadosBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_PRODAGREGADOS.DefaultCellStyle = DataGridViewCellStyle7
        Me.DG_PRODAGREGADOS.Location = New System.Drawing.Point(4, 19)
        Me.DG_PRODAGREGADOS.MultiSelect = False
        Me.DG_PRODAGREGADOS.Name = "DG_PRODAGREGADOS"
        Me.DG_PRODAGREGADOS.RowHeadersVisible = False
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_PRODAGREGADOS.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DG_PRODAGREGADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_PRODAGREGADOS.Size = New System.Drawing.Size(844, 410)
        Me.DG_PRODAGREGADOS.StandardTab = True
        Me.DG_PRODAGREGADOS.TabIndex = 258
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 106.599!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PRODcodigoDataGridViewTextBoxColumn
        '
        Me.PRODcodigoDataGridViewTextBoxColumn.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.PRODcodigoDataGridViewTextBoxColumn.Name = "PRODcodigoDataGridViewTextBoxColumn"
        '
        'PRODnombreDataGridViewTextBoxColumn
        '
        Me.PRODnombreDataGridViewTextBoxColumn.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.Name = "PRODnombreDataGridViewTextBoxColumn"
        '
        'PRODprecioUDataGridViewTextBoxColumn
        '
        Me.PRODprecioUDataGridViewTextBoxColumn.DataPropertyName = "PROD_precioU"
        Me.PRODprecioUDataGridViewTextBoxColumn.HeaderText = "Precio U."
        Me.PRODprecioUDataGridViewTextBoxColumn.Name = "PRODprecioUDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'Venta_Lote
        '
        Me.Venta_Lote.DataPropertyName = "Venta_Lote"
        Me.Venta_Lote.HeaderText = "Nro. de Lote"
        Me.Venta_Lote.Name = "Venta_Lote"
        '
        'MarcanomDataGridViewTextBoxColumn
        '
        Me.MarcanomDataGridViewTextBoxColumn.DataPropertyName = "Marca_nom"
        Me.MarcanomDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcanomDataGridViewTextBoxColumn.Name = "MarcanomDataGridViewTextBoxColumn"
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        '
        'ProductosagregadosBindingSource
        '
        Me.ProductosagregadosBindingSource.DataMember = "Productos_agregados"
        Me.ProductosagregadosBindingSource.DataSource = Me.DS_venta_regional1
        '
        'DS_venta_regional1
        '
        Me.DS_venta_regional1.DataSetName = "DS_venta_regional"
        Me.DS_venta_regional1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_Quitar
        '
        Me.BO_Quitar.Enabled = False
        Me.BO_Quitar.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.BO_Quitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Quitar.Location = New System.Drawing.Point(670, 484)
        Me.BO_Quitar.Name = "BO_Quitar"
        Me.BO_Quitar.Size = New System.Drawing.Size(64, 47)
        Me.BO_Quitar.TabIndex = 3
        Me.BO_Quitar.Text = "Quitar"
        Me.BO_Quitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_Quitar, "Quitar item seleccionado")
        Me.BO_Quitar.UseVisualStyleBackColor = True
        '
        'BO_cancelar
        '
        Me.BO_cancelar.Enabled = False
        Me.BO_cancelar.Image = CType(resources.GetObject("BO_cancelar.Image"), System.Drawing.Image)
        Me.BO_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_cancelar.Location = New System.Drawing.Point(740, 484)
        Me.BO_cancelar.Name = "BO_cancelar"
        Me.BO_cancelar.Size = New System.Drawing.Size(61, 47)
        Me.BO_cancelar.TabIndex = 4
        Me.BO_cancelar.Text = "Cancelar"
        Me.BO_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_cancelar, "Cancelar")
        Me.BO_cancelar.UseVisualStyleBackColor = True
        '
        'BO_Guardar
        '
        Me.BO_Guardar.Enabled = False
        Me.BO_Guardar.Image = CType(resources.GetObject("BO_Guardar.Image"), System.Drawing.Image)
        Me.BO_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Guardar.Location = New System.Drawing.Point(807, 484)
        Me.BO_Guardar.Name = "BO_Guardar"
        Me.BO_Guardar.Size = New System.Drawing.Size(55, 47)
        Me.BO_Guardar.TabIndex = 5
        Me.BO_Guardar.Text = "Guardar"
        Me.BO_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_Guardar, "Guardar")
        Me.BO_Guardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(882, 567)
        Me.TabControl1.TabIndex = 2
        '
        'VentaRegional_nuevodiseño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(882, 566)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "VentaRegional_nuevodiseño"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentaRegional_nuevodiseño"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_venta_regional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox_prodagregados.ResumeLayout(False)
        CType(Me.DG_PRODAGREGADOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosagregadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_venta_regional1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DateTime_fechsistema As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateTime_fechfactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents tx_nrofactura As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_Nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_Aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_buscar_clie As System.Windows.Forms.TextBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BO_editar As System.Windows.Forms.Button
    Friend WithEvents GroupBox_prodagregados As System.Windows.Forms.GroupBox
    Friend WithEvents DG_PRODAGREGADOS As System.Windows.Forms.DataGridView
    Friend WithEvents BO_Quitar As System.Windows.Forms.Button
    Friend WithEvents BO_cancelar As System.Windows.Forms.Button
    Friend WithEvents BO_Guardar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_venta_regional As Aplicacion.DS_venta_regional
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIcelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdirecDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductosagregadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_venta_regional1 As Aplicacion.DS_venta_regional
    Friend WithEvents Lb_pagoparcial As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODprecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venta_Lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcanomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
