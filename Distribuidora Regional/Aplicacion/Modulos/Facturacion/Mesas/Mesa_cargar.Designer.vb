<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mesa_cargar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mesa_cargar))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Lb_pagoparcial = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_mesa = New System.Windows.Forms.Label()
        Me.Label_sector = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RB_CodBarra = New System.Windows.Forms.RadioButton()
        Me.RB_CodInterno = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_busc_codibarra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_cantidad = New System.Windows.Forms.TextBox()
        Me.TX_busc_codinterno = New System.Windows.Forms.TextBox()
        Me.BO_promocion = New System.Windows.Forms.Button()
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.Quitar = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataG_listaTotal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataG_lista = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciounitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciosubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodbarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoagregadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds = New Aplicacion.Venta_Caja_ds()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataG_listaTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataG_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox12.Controls.Add(Me.Lb_pagoparcial)
        Me.GroupBox12.Controls.Add(Me.Label6)
        Me.GroupBox12.Controls.Add(Me.Label_mesa)
        Me.GroupBox12.Controls.Add(Me.Label_sector)
        Me.GroupBox12.Controls.Add(Me.Label4)
        Me.GroupBox12.Controls.Add(Me.Label5)
        Me.GroupBox12.Controls.Add(Me.GroupBox7)
        Me.GroupBox12.Controls.Add(Me.Label1)
        Me.GroupBox12.Controls.Add(Me.TX_busc_codibarra)
        Me.GroupBox12.Controls.Add(Me.Label3)
        Me.GroupBox12.Controls.Add(Me.Label2)
        Me.GroupBox12.Controls.Add(Me.tx_cantidad)
        Me.GroupBox12.Controls.Add(Me.TX_busc_codinterno)
        Me.GroupBox12.Controls.Add(Me.BO_promocion)
        Me.GroupBox12.Controls.Add(Me.BO_buscar)
        Me.GroupBox12.Controls.Add(Me.Quitar)
        Me.GroupBox12.Controls.Add(Me.Guardar)
        Me.GroupBox12.Controls.Add(Me.Button1)
        Me.GroupBox12.Controls.Add(Me.DataG_listaTotal)
        Me.GroupBox12.Controls.Add(Me.DataG_lista)
        Me.GroupBox12.Enabled = False
        Me.GroupBox12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox12.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(788, 429)
        Me.GroupBox12.TabIndex = 239
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Productos agregados"
        '
        'Lb_pagoparcial
        '
        Me.Lb_pagoparcial.AutoSize = True
        Me.Lb_pagoparcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_pagoparcial.Location = New System.Drawing.Point(265, 395)
        Me.Lb_pagoparcial.Name = "Lb_pagoparcial"
        Me.Lb_pagoparcial.Size = New System.Drawing.Size(66, 25)
        Me.Lb_pagoparcial.TabIndex = 270
        Me.Lb_pagoparcial.Text = "00,00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 25)
        Me.Label6.TabIndex = 269
        Me.Label6.Text = "Pago parcial registrado: $"
        '
        'Label_mesa
        '
        Me.Label_mesa.AutoSize = True
        Me.Label_mesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mesa.Location = New System.Drawing.Point(710, 35)
        Me.Label_mesa.Name = "Label_mesa"
        Me.Label_mesa.Size = New System.Drawing.Size(67, 15)
        Me.Label_mesa.TabIndex = 268
        Me.Label_mesa.Text = "nro mesa"
        '
        'Label_sector
        '
        Me.Label_sector.AutoSize = True
        Me.Label_sector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_sector.Location = New System.Drawing.Point(685, 16)
        Me.Label_sector.Name = "Label_sector"
        Me.Label_sector.Size = New System.Drawing.Size(99, 15)
        Me.Label_sector.TabIndex = 267
        Me.Label_sector.Text = "nombre sector"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(623, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 266
        Me.Label4.Text = "Nro. Mesa :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(623, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 265
        Me.Label5.Text = "Sector :"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RB_CodBarra)
        Me.GroupBox7.Controls.Add(Me.RB_CodInterno)
        Me.GroupBox7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox7.Location = New System.Drawing.Point(374, 29)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(226, 40)
        Me.GroupBox7.TabIndex = 257
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Tipo de búsqueda"
        '
        'RB_CodBarra
        '
        Me.RB_CodBarra.AutoSize = True
        Me.RB_CodBarra.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_CodBarra.Location = New System.Drawing.Point(94, 17)
        Me.RB_CodBarra.Name = "RB_CodBarra"
        Me.RB_CodBarra.Size = New System.Drawing.Size(75, 17)
        Me.RB_CodBarra.TabIndex = 224
        Me.RB_CodBarra.Text = "Cód. Barra"
        Me.RB_CodBarra.UseVisualStyleBackColor = True
        '
        'RB_CodInterno
        '
        Me.RB_CodInterno.AutoSize = True
        Me.RB_CodInterno.Checked = True
        Me.RB_CodInterno.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_CodInterno.Location = New System.Drawing.Point(6, 17)
        Me.RB_CodInterno.Name = "RB_CodInterno"
        Me.RB_CodInterno.Size = New System.Drawing.Size(83, 17)
        Me.RB_CodInterno.TabIndex = 223
        Me.RB_CodInterno.TabStop = True
        Me.RB_CodInterno.Text = "Cód. Interno"
        Me.RB_CodInterno.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 256
        Me.Label1.Text = "Cód. Barra :"
        '
        'TX_busc_codibarra
        '
        Me.TX_busc_codibarra.Enabled = False
        Me.TX_busc_codibarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_busc_codibarra.Location = New System.Drawing.Point(308, 76)
        Me.TX_busc_codibarra.Name = "TX_busc_codibarra"
        Me.TX_busc_codibarra.Size = New System.Drawing.Size(292, 26)
        Me.TX_busc_codibarra.TabIndex = 255
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 254
        Me.Label3.Text = "Cantidad :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 253
        Me.Label2.Text = "Cód. Interno :"
        '
        'tx_cantidad
        '
        Me.tx_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_cantidad.Location = New System.Drawing.Point(99, 43)
        Me.tx_cantidad.Name = "tx_cantidad"
        Me.tx_cantidad.Size = New System.Drawing.Size(113, 26)
        Me.tx_cantidad.TabIndex = 1
        '
        'TX_busc_codinterno
        '
        Me.TX_busc_codinterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_busc_codinterno.Location = New System.Drawing.Point(99, 76)
        Me.TX_busc_codinterno.Name = "TX_busc_codinterno"
        Me.TX_busc_codinterno.Size = New System.Drawing.Size(114, 26)
        Me.TX_busc_codinterno.TabIndex = 0
        '
        'BO_promocion
        '
        Me.BO_promocion.Location = New System.Drawing.Point(542, 381)
        Me.BO_promocion.Name = "BO_promocion"
        Me.BO_promocion.Size = New System.Drawing.Size(96, 40)
        Me.BO_promocion.TabIndex = 7
        Me.BO_promocion.Text = "Busc.promo (F2)"
        Me.ToolTip1.SetToolTip(Me.BO_promocion, "Buscar promoción")
        Me.BO_promocion.UseVisualStyleBackColor = True
        '
        'BO_buscar
        '
        Me.BO_buscar.Location = New System.Drawing.Point(440, 381)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(96, 40)
        Me.BO_buscar.TabIndex = 6
        Me.BO_buscar.Text = "Busc.prod (F1)"
        Me.ToolTip1.SetToolTip(Me.BO_buscar, "Buscar producto")
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'Quitar
        '
        Me.Quitar.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Quitar.Location = New System.Drawing.Point(644, 381)
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Size = New System.Drawing.Size(40, 40)
        Me.Quitar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Quitar, "Quitar item")
        Me.Quitar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.Location = New System.Drawing.Point(736, 381)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(40, 40)
        Me.Guardar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Guardar, "Registrar venta")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(690, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancelar venta")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataG_listaTotal
        '
        Me.DataG_listaTotal.AllowUserToAddRows = False
        Me.DataG_listaTotal.AllowUserToDeleteRows = False
        Me.DataG_listaTotal.BackgroundColor = System.Drawing.Color.White
        Me.DataG_listaTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataG_listaTotal.ColumnHeadersVisible = False
        Me.DataG_listaTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataG_listaTotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataG_listaTotal.Location = New System.Drawing.Point(3, 350)
        Me.DataG_listaTotal.Name = "DataG_listaTotal"
        Me.DataG_listaTotal.ReadOnly = True
        Me.DataG_listaTotal.RowHeadersVisible = False
        Me.DataG_listaTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataG_listaTotal.Size = New System.Drawing.Size(773, 25)
        Me.DataG_listaTotal.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_descripcion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 640
        '
        'DataG_lista
        '
        Me.DataG_lista.AllowUserToAddRows = False
        Me.DataG_lista.AllowUserToResizeRows = False
        Me.DataG_lista.AutoGenerateColumns = False
        Me.DataG_lista.BackgroundColor = System.Drawing.Color.White
        Me.DataG_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataG_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.PRODidDataGridViewTextBoxColumn, Me.CodinternoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PreciounitarioDataGridViewTextBoxColumn, Me.PreciosubtotalDataGridViewTextBoxColumn, Me.CodbarraDataGridViewTextBoxColumn})
        Me.DataG_lista.DataSource = Me.ProductoagregadoBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataG_lista.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataG_lista.Location = New System.Drawing.Point(3, 112)
        Me.DataG_lista.MultiSelect = False
        Me.DataG_lista.Name = "DataG_lista"
        Me.DataG_lista.ReadOnly = True
        Me.DataG_lista.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataG_lista.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataG_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataG_lista.Size = New System.Drawing.Size(773, 232)
        Me.DataG_lista.StandardTab = True
        Me.DataG_lista.TabIndex = 0
        '
        'Item
        '
        Me.Item.FillWeight = 106.599!
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 50
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        Me.PRODidDataGridViewTextBoxColumn.Width = 91
        '
        'CodinternoDataGridViewTextBoxColumn
        '
        Me.CodinternoDataGridViewTextBoxColumn.DataPropertyName = "codinterno"
        Me.CodinternoDataGridViewTextBoxColumn.HeaderText = "Cód. Interno"
        Me.CodinternoDataGridViewTextBoxColumn.Name = "CodinternoDataGridViewTextBoxColumn"
        Me.CodinternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodinternoDataGridViewTextBoxColumn.Width = 90
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 250
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleDataGridViewTextBoxColumn.Visible = False
        Me.DetalleDataGridViewTextBoxColumn.Width = 90
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciounitarioDataGridViewTextBoxColumn
        '
        Me.PreciounitarioDataGridViewTextBoxColumn.DataPropertyName = "precio_unitario"
        Me.PreciounitarioDataGridViewTextBoxColumn.HeaderText = "Precio U."
        Me.PreciounitarioDataGridViewTextBoxColumn.Name = "PreciounitarioDataGridViewTextBoxColumn"
        Me.PreciounitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciosubtotalDataGridViewTextBoxColumn
        '
        Me.PreciosubtotalDataGridViewTextBoxColumn.DataPropertyName = "precio_subtotal"
        Me.PreciosubtotalDataGridViewTextBoxColumn.HeaderText = "Precio Subtotal"
        Me.PreciosubtotalDataGridViewTextBoxColumn.Name = "PreciosubtotalDataGridViewTextBoxColumn"
        Me.PreciosubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PreciosubtotalDataGridViewTextBoxColumn.Width = 150
        '
        'CodbarraDataGridViewTextBoxColumn
        '
        Me.CodbarraDataGridViewTextBoxColumn.DataPropertyName = "codbarra"
        Me.CodbarraDataGridViewTextBoxColumn.HeaderText = "codbarra"
        Me.CodbarraDataGridViewTextBoxColumn.Name = "CodbarraDataGridViewTextBoxColumn"
        Me.CodbarraDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodbarraDataGridViewTextBoxColumn.Visible = False
        '
        'ProductoagregadoBindingSource
        '
        Me.ProductoagregadoBindingSource.DataMember = "Producto_agregado"
        Me.ProductoagregadoBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'Venta_Caja_ds
        '
        Me.Venta_Caja_ds.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mesa_cargar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(799, 438)
        Me.Controls.Add(Me.GroupBox12)
        Me.KeyPreview = True
        Me.Name = "Mesa_cargar"
        Me.Text = "Cargar productos en mesa"
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DataG_listaTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataG_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_CodBarra As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CodInterno As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TX_busc_codibarra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents TX_busc_codinterno As System.Windows.Forms.TextBox
    Friend WithEvents BO_promocion As System.Windows.Forms.Button
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents Quitar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataG_listaTotal As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataG_lista As System.Windows.Forms.DataGridView
    Friend WithEvents Venta_Caja_ds As Aplicacion.Venta_Caja_ds
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreciounitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreciosubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodbarraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoagregadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label_mesa As System.Windows.Forms.Label
    Friend WithEvents Label_sector As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Lb_pagoparcial As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
