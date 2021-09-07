<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Productos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_Buscar = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_ds = New Aplicacion.Lista_ds()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescrilargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdpreciovtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdptorepoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosCombosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds = New Aplicacion.Venta_Caja_ds()
        Me.BO_agregar = New System.Windows.Forms.Button()
        Me.BO_salir = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioSubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CombodetallesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds3 = New Aplicacion.Venta_Caja_ds()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lb_combo = New System.Windows.Forms.Label()
        Me.ProductosCombosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoagregadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaCajadsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds1 = New Aplicacion.Venta_Caja_ds()
        Me.CombodetallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds2 = New Aplicacion.Venta_Caja_ds()
        Me.CombodetallesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CombodetallesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosCombosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombodetallesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosCombosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaCajadsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombodetallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombodetallesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombodetallesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Producto"
        '
        'tx_Buscar
        '
        Me.tx_Buscar.Location = New System.Drawing.Point(123, 13)
        Me.tx_Buscar.Name = "tx_Buscar"
        Me.tx_Buscar.Size = New System.Drawing.Size(266, 20)
        Me.tx_Buscar.TabIndex = 0
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Lista_ds
        '
        'Lista_ds
        '
        Me.Lista_ds.DataSetName = "Lista_ds"
        Me.Lista_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdidDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProddescrilargaDataGridViewTextBoxColumn, Me.ProdpreciovtaDataGridViewTextBoxColumn, Me.ProdstockDataGridViewTextBoxColumn, Me.ProdptorepoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosCombosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 79)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(377, 211)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 1
        '
        'ProdidDataGridViewTextBoxColumn
        '
        Me.ProdidDataGridViewTextBoxColumn.DataPropertyName = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.HeaderText = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.Name = "ProdidDataGridViewTextBoxColumn"
        Me.ProdidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdidDataGridViewTextBoxColumn.Visible = False
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Cód. Interno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdcodinternoDataGridViewTextBoxColumn.Width = 90
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn.Width = 180
        '
        'ProddescrilargaDataGridViewTextBoxColumn
        '
        Me.ProddescrilargaDataGridViewTextBoxColumn.DataPropertyName = "prod_descrilarga"
        Me.ProddescrilargaDataGridViewTextBoxColumn.HeaderText = "prod_descrilarga"
        Me.ProddescrilargaDataGridViewTextBoxColumn.Name = "ProddescrilargaDataGridViewTextBoxColumn"
        Me.ProddescrilargaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescrilargaDataGridViewTextBoxColumn.Visible = False
        '
        'ProdpreciovtaDataGridViewTextBoxColumn
        '
        Me.ProdpreciovtaDataGridViewTextBoxColumn.DataPropertyName = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.HeaderText = "Precio Venta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Name = "ProdpreciovtaDataGridViewTextBoxColumn"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdstockDataGridViewTextBoxColumn
        '
        Me.ProdstockDataGridViewTextBoxColumn.DataPropertyName = "prod_stock"
        Me.ProdstockDataGridViewTextBoxColumn.HeaderText = "prod_stock"
        Me.ProdstockDataGridViewTextBoxColumn.Name = "ProdstockDataGridViewTextBoxColumn"
        Me.ProdstockDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdstockDataGridViewTextBoxColumn.Visible = False
        '
        'ProdptorepoDataGridViewTextBoxColumn
        '
        Me.ProdptorepoDataGridViewTextBoxColumn.DataPropertyName = "prod_ptorepo"
        Me.ProdptorepoDataGridViewTextBoxColumn.HeaderText = "prod_ptorepo"
        Me.ProdptorepoDataGridViewTextBoxColumn.Name = "ProdptorepoDataGridViewTextBoxColumn"
        Me.ProdptorepoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdptorepoDataGridViewTextBoxColumn.Visible = False
        '
        'ProductosCombosBindingSource1
        '
        Me.ProductosCombosBindingSource1.DataMember = "Productos_Combos"
        Me.ProductosCombosBindingSource1.DataSource = Me.Venta_Caja_ds
        '
        'Venta_Caja_ds
        '
        Me.Venta_Caja_ds.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_agregar
        '
        Me.BO_agregar.Location = New System.Drawing.Point(233, 296)
        Me.BO_agregar.Name = "BO_agregar"
        Me.BO_agregar.Size = New System.Drawing.Size(75, 23)
        Me.BO_agregar.TabIndex = 2
        Me.BO_agregar.Text = "Agregar"
        Me.BO_agregar.UseVisualStyleBackColor = True
        '
        'BO_salir
        '
        Me.BO_salir.Location = New System.Drawing.Point(314, 296)
        Me.BO_salir.Name = "BO_salir"
        Me.BO_salir.Size = New System.Drawing.Size(75, 23)
        Me.BO_salir.TabIndex = 3
        Me.BO_salir.Text = "Salir"
        Me.BO_salir.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripciónDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioUDataGridViewTextBoxColumn, Me.PrecioSubtotalDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CombodetallesBindingSource3
        Me.DataGridView2.Location = New System.Drawing.Point(395, 79)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(437, 211)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 4
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripciónDataGridViewTextBoxColumn.Width = 150
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 60
        '
        'PrecioUDataGridViewTextBoxColumn
        '
        Me.PrecioUDataGridViewTextBoxColumn.DataPropertyName = "Precio U."
        Me.PrecioUDataGridViewTextBoxColumn.HeaderText = "Precio U."
        Me.PrecioUDataGridViewTextBoxColumn.Name = "PrecioUDataGridViewTextBoxColumn"
        Me.PrecioUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioSubtotalDataGridViewTextBoxColumn
        '
        Me.PrecioSubtotalDataGridViewTextBoxColumn.DataPropertyName = "Precio Subtotal"
        Me.PrecioSubtotalDataGridViewTextBoxColumn.HeaderText = "Precio Subtotal"
        Me.PrecioSubtotalDataGridViewTextBoxColumn.Name = "PrecioSubtotalDataGridViewTextBoxColumn"
        Me.PrecioSubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioSubtotalDataGridViewTextBoxColumn.Width = 120
        '
        'CombodetallesBindingSource3
        '
        Me.CombodetallesBindingSource3.DataMember = "Combo_detalles"
        Me.CombodetallesBindingSource3.DataSource = Me.Venta_Caja_ds3
        '
        'Venta_Caja_ds3
        '
        Me.Venta_Caja_ds3.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Listado Productos :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(392, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Detalla de combos :"
        '
        'Lb_combo
        '
        Me.Lb_combo.AutoSize = True
        Me.Lb_combo.BackColor = System.Drawing.Color.Transparent
        Me.Lb_combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_combo.Location = New System.Drawing.Point(499, 51)
        Me.Lb_combo.Name = "Lb_combo"
        Me.Lb_combo.Size = New System.Drawing.Size(131, 13)
        Me.Lb_combo.TabIndex = 8
        Me.Lb_combo.Text = "- - - - - - - - - - - - - - - -"
        '
        'ProductosCombosBindingSource
        '
        Me.ProductosCombosBindingSource.DataMember = "Productos_Combos"
        Me.ProductosCombosBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'ProductoagregadoBindingSource
        '
        Me.ProductoagregadoBindingSource.DataMember = "Producto_agregado"
        Me.ProductoagregadoBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'VentaCajadsBindingSource
        '
        Me.VentaCajadsBindingSource.DataSource = Me.Venta_Caja_ds
        Me.VentaCajadsBindingSource.Position = 0
        '
        'Venta_Caja_ds1
        '
        Me.Venta_Caja_ds1.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CombodetallesBindingSource
        '
        Me.CombodetallesBindingSource.DataMember = "Combo_detalles"
        Me.CombodetallesBindingSource.DataSource = Me.Venta_Caja_ds1
        '
        'Venta_Caja_ds2
        '
        Me.Venta_Caja_ds2.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CombodetallesBindingSource1
        '
        Me.CombodetallesBindingSource1.DataMember = "Combo_detalles"
        Me.CombodetallesBindingSource1.DataSource = Me.Venta_Caja_ds2
        '
        'CombodetallesBindingSource2
        '
        Me.CombodetallesBindingSource2.DataMember = "Combo_detalles"
        Me.CombodetallesBindingSource2.DataSource = Me.Venta_Caja_ds2
        '
        'Busqueda_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(842, 326)
        Me.Controls.Add(Me.Lb_combo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BO_salir)
        Me.Controls.Add(Me.BO_agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tx_Buscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Busqueda_Productos"
        Me.Text = "Busqueda_Productos"
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosCombosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombodetallesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosCombosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaCajadsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombodetallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombodetallesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombodetallesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents ProductoagregadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds As Aplicacion.Venta_Caja_ds
    Friend WithEvents VentaCajadsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_ds As Aplicacion.Lista_ds
    Friend WithEvents ProductosCombosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductosCombosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BO_agregar As System.Windows.Forms.Button
    Friend WithEvents BO_salir As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescrilargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdpreciovtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdptorepoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CombodetallesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds1 As Aplicacion.Venta_Caja_ds
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lb_combo As System.Windows.Forms.Label
    Friend WithEvents CombodetallesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds2 As Aplicacion.Venta_Caja_ds
    Friend WithEvents CombodetallesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioSubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CombodetallesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds3 As Aplicacion.Venta_Caja_ds
End Class
