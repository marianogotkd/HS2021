<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaRegiona_busqueda
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BO_salir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PRODcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODprecioUvtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcanttotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODTidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcondialmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcanomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDET_nroloteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODtotalUivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODtotalivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosstockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_venta_regional = New Aplicacion.DS_venta_regional()
        Me.tx_Buscar = New System.Windows.Forms.TextBox()
        Me.BO_agregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tb_nrolote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label_preciototal = New System.Windows.Forms.Label()
        Me.Label_codinterno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosstockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_venta_regional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Listado Productos en Stock:"
        '
        'BO_salir
        '
        Me.BO_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_salir.Location = New System.Drawing.Point(456, 419)
        Me.BO_salir.Name = "BO_salir"
        Me.BO_salir.Size = New System.Drawing.Size(104, 47)
        Me.BO_salir.TabIndex = 5
        Me.BO_salir.Text = "Salir"
        Me.BO_salir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODidDataGridViewTextBoxColumn, Me.Item, Me.PRODcodigoDataGridViewTextBoxColumn, Me.PRODnombreDataGridViewTextBoxColumn, Me.PRODprecioUvtaDataGridViewTextBoxColumn, Me.PRODcanttotalDataGridViewTextBoxColumn, Me.PRODTidDataGridViewTextBoxColumn, Me.PRODcondialmDataGridViewTextBoxColumn, Me.MarcaidDataGridViewTextBoxColumn, Me.MarcanomDataGridViewTextBoxColumn, Me.PRODestadoDataGridViewTextBoxColumn, Me.PRODivaDataGridViewTextBoxColumn, Me.PRODDET_nroloteDataGridViewTextBoxColumn, Me.PRODtotalUivaDataGridViewTextBoxColumn, Me.PRODtotalivaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosstockBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(30, 84)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(912, 211)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 1
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        '
        'PRODcodigoDataGridViewTextBoxColumn
        '
        Me.PRODcodigoDataGridViewTextBoxColumn.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.PRODcodigoDataGridViewTextBoxColumn.Name = "PRODcodigoDataGridViewTextBoxColumn"
        Me.PRODcodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODnombreDataGridViewTextBoxColumn
        '
        Me.PRODnombreDataGridViewTextBoxColumn.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.Name = "PRODnombreDataGridViewTextBoxColumn"
        Me.PRODnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODprecioUvtaDataGridViewTextBoxColumn
        '
        Me.PRODprecioUvtaDataGridViewTextBoxColumn.DataPropertyName = "PROD_precioU_vta"
        Me.PRODprecioUvtaDataGridViewTextBoxColumn.HeaderText = "Precio Unitario"
        Me.PRODprecioUvtaDataGridViewTextBoxColumn.Name = "PRODprecioUvtaDataGridViewTextBoxColumn"
        Me.PRODprecioUvtaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODcanttotalDataGridViewTextBoxColumn
        '
        Me.PRODcanttotalDataGridViewTextBoxColumn.DataPropertyName = "PROD_cant_total"
        Me.PRODcanttotalDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.PRODcanttotalDataGridViewTextBoxColumn.Name = "PRODcanttotalDataGridViewTextBoxColumn"
        Me.PRODcanttotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODTidDataGridViewTextBoxColumn
        '
        Me.PRODTidDataGridViewTextBoxColumn.DataPropertyName = "PROD_T_id"
        Me.PRODTidDataGridViewTextBoxColumn.HeaderText = "PROD_T_id"
        Me.PRODTidDataGridViewTextBoxColumn.Name = "PRODTidDataGridViewTextBoxColumn"
        Me.PRODTidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODTidDataGridViewTextBoxColumn.Visible = False
        '
        'PRODcondialmDataGridViewTextBoxColumn
        '
        Me.PRODcondialmDataGridViewTextBoxColumn.DataPropertyName = "PROD_condi_alm"
        Me.PRODcondialmDataGridViewTextBoxColumn.HeaderText = "PROD_condi_alm"
        Me.PRODcondialmDataGridViewTextBoxColumn.Name = "PRODcondialmDataGridViewTextBoxColumn"
        Me.PRODcondialmDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODcondialmDataGridViewTextBoxColumn.Visible = False
        '
        'MarcaidDataGridViewTextBoxColumn
        '
        Me.MarcaidDataGridViewTextBoxColumn.DataPropertyName = "Marca_id"
        Me.MarcaidDataGridViewTextBoxColumn.HeaderText = "Marca_id"
        Me.MarcaidDataGridViewTextBoxColumn.Name = "MarcaidDataGridViewTextBoxColumn"
        Me.MarcaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaidDataGridViewTextBoxColumn.Visible = False
        '
        'MarcanomDataGridViewTextBoxColumn
        '
        Me.MarcanomDataGridViewTextBoxColumn.DataPropertyName = "Marca_nom"
        Me.MarcanomDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcanomDataGridViewTextBoxColumn.Name = "MarcanomDataGridViewTextBoxColumn"
        Me.MarcanomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODestadoDataGridViewTextBoxColumn
        '
        Me.PRODestadoDataGridViewTextBoxColumn.DataPropertyName = "PROD_estado"
        Me.PRODestadoDataGridViewTextBoxColumn.HeaderText = "Estado"
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
        'PRODDET_nroloteDataGridViewTextBoxColumn
        '
        Me.PRODDET_nroloteDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_nrolote"
        Me.PRODDET_nroloteDataGridViewTextBoxColumn.HeaderText = "N° de Lote"
        Me.PRODDET_nroloteDataGridViewTextBoxColumn.Name = "PRODDET_nroloteDataGridViewTextBoxColumn"
        Me.PRODDET_nroloteDataGridViewTextBoxColumn.ReadOnly = True
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
        'ProductosstockBindingSource
        '
        Me.ProductosstockBindingSource.DataMember = "Productos_stock"
        Me.ProductosstockBindingSource.DataSource = Me.DS_venta_regional
        '
        'DS_venta_regional
        '
        Me.DS_venta_regional.DataSetName = "DS_venta_regional"
        Me.DS_venta_regional.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tx_Buscar
        '
        Me.tx_Buscar.Location = New System.Drawing.Point(126, 18)
        Me.tx_Buscar.Name = "tx_Buscar"
        Me.tx_Buscar.Size = New System.Drawing.Size(720, 20)
        Me.tx_Buscar.TabIndex = 0
        '
        'BO_agregar
        '
        Me.BO_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_agregar.Location = New System.Drawing.Point(346, 419)
        Me.BO_agregar.Name = "BO_agregar"
        Me.BO_agregar.Size = New System.Drawing.Size(104, 47)
        Me.BO_agregar.TabIndex = 4
        Me.BO_agregar.Text = "Agregar"
        Me.BO_agregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre del Producto"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.tb_nrolote)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txt_precio)
        Me.GroupBox5.Controls.Add(Me.Label_preciototal)
        Me.GroupBox5.Controls.Add(Me.Label_codinterno)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txt_cantidad)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(15, 301)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(927, 112)
        Me.GroupBox5.TabIndex = 234
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Producto seleccionado: "
        '
        'tb_nrolote
        '
        Me.tb_nrolote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nrolote.ForeColor = System.Drawing.Color.DarkGreen
        Me.tb_nrolote.Location = New System.Drawing.Point(721, 64)
        Me.tb_nrolote.Name = "tb_nrolote"
        Me.tb_nrolote.Size = New System.Drawing.Size(162, 26)
        Me.tb_nrolote.TabIndex = 236
        Me.tb_nrolote.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(597, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 237
        Me.Label4.Text = "Nro. de Lote :"
        Me.Label4.Visible = False
        '
        'txt_precio
        '
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_precio.Location = New System.Drawing.Point(253, 22)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(116, 26)
        Me.txt_precio.TabIndex = 2
        Me.txt_precio.Text = "1"
        '
        'Label_preciototal
        '
        Me.Label_preciototal.AutoSize = True
        Me.Label_preciototal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_preciototal.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_preciototal.Location = New System.Drawing.Point(526, 73)
        Me.Label_preciototal.Name = "Label_preciototal"
        Me.Label_preciototal.Size = New System.Drawing.Size(54, 20)
        Me.Label_preciototal.TabIndex = 235
        Me.Label_preciototal.Text = "00,00"
        '
        'Label_codinterno
        '
        Me.Label_codinterno.AutoSize = True
        Me.Label_codinterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_codinterno.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_codinterno.Location = New System.Drawing.Point(511, 22)
        Me.Label_codinterno.Name = "Label_codinterno"
        Me.Label_codinterno.Size = New System.Drawing.Size(29, 20)
        Me.Label_codinterno.TabIndex = 234
        Me.Label_codinterno.Text = """  """
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(391, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 233
        Me.Label3.Text = "Cód. Interno:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(156, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Precio :  $"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(391, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 20)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Precio Total : $"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_cantidad.Location = New System.Drawing.Point(253, 70)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(116, 26)
        Me.txt_cantidad.TabIndex = 3
        Me.txt_cantidad.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label15.Location = New System.Drawing.Point(156, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 20)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Cantidad :"
        '
        'VentaRegiona_busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(954, 478)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BO_salir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tx_Buscar)
        Me.Controls.Add(Me.BO_agregar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VentaRegiona_busqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta - Agregar productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosstockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_venta_regional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BO_salir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents BO_agregar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label_preciototal As System.Windows.Forms.Label
    Friend WithEvents Label_codinterno As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ProductosstockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_venta_regional As Aplicacion.DS_venta_regional
    Friend WithEvents tb_nrolote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODprecioUvtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcanttotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODTidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcondialmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcanomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDET_nroloteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODtotalUivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODtotalivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
