<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaRegional_lotesvendidos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_presentacion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_codigo = New System.Windows.Forms.Label()
        Me.lb_nombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PRODcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODpresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETnroloteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantloteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotesvendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_venta_regional = New Aplicacion.DS_venta_regional()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesvendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_venta_regional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 29)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Consulta de lotes vendidos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lb_presentacion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lb_codigo)
        Me.GroupBox1.Controls.Add(Me.lb_nombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 93)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles del producto vendido:"
        '
        'lb_presentacion
        '
        Me.lb_presentacion.AutoSize = True
        Me.lb_presentacion.Location = New System.Drawing.Point(84, 63)
        Me.lb_presentacion.Name = "lb_presentacion"
        Me.lb_presentacion.Size = New System.Drawing.Size(115, 13)
        Me.lb_presentacion.TabIndex = 35
        Me.lb_presentacion.Text = "...................................."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Presentación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Código:"
        '
        'lb_codigo
        '
        Me.lb_codigo.AutoSize = True
        Me.lb_codigo.Location = New System.Drawing.Point(55, 16)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(31, 13)
        Me.lb_codigo.TabIndex = 32
        Me.lb_codigo.Text = "0000"
        '
        'lb_nombre
        '
        Me.lb_nombre.AutoSize = True
        Me.lb_nombre.Location = New System.Drawing.Point(65, 39)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(106, 13)
        Me.lb_nombre.TabIndex = 34
        Me.lb_nombre.Text = "................................."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Producto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 277)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lotes"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODcodigoDataGridViewTextBoxColumn, Me.PRODnombreDataGridViewTextBoxColumn, Me.PRODpresentacionDataGridViewTextBoxColumn, Me.PRODDETnroloteDataGridViewTextBoxColumn, Me.CantloteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LotesvendidosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(306, 255)
        Me.DataGridView1.TabIndex = 0
        '
        'PRODcodigoDataGridViewTextBoxColumn
        '
        Me.PRODcodigoDataGridViewTextBoxColumn.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.HeaderText = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.Name = "PRODcodigoDataGridViewTextBoxColumn"
        Me.PRODcodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODcodigoDataGridViewTextBoxColumn.Visible = False
        '
        'PRODnombreDataGridViewTextBoxColumn
        '
        Me.PRODnombreDataGridViewTextBoxColumn.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.HeaderText = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.Name = "PRODnombreDataGridViewTextBoxColumn"
        Me.PRODnombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODnombreDataGridViewTextBoxColumn.Visible = False
        '
        'PRODpresentacionDataGridViewTextBoxColumn
        '
        Me.PRODpresentacionDataGridViewTextBoxColumn.DataPropertyName = "PROD_presentacion"
        Me.PRODpresentacionDataGridViewTextBoxColumn.HeaderText = "PROD_presentacion"
        Me.PRODpresentacionDataGridViewTextBoxColumn.Name = "PRODpresentacionDataGridViewTextBoxColumn"
        Me.PRODpresentacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODpresentacionDataGridViewTextBoxColumn.Visible = False
        '
        'PRODDETnroloteDataGridViewTextBoxColumn
        '
        Me.PRODDETnroloteDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_nrolote"
        Me.PRODDETnroloteDataGridViewTextBoxColumn.HeaderText = "Nº de lote"
        Me.PRODDETnroloteDataGridViewTextBoxColumn.Name = "PRODDETnroloteDataGridViewTextBoxColumn"
        Me.PRODDETnroloteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantloteDataGridViewTextBoxColumn
        '
        Me.CantloteDataGridViewTextBoxColumn.DataPropertyName = "Cant_lote"
        Me.CantloteDataGridViewTextBoxColumn.HeaderText = "Cantidad vendida"
        Me.CantloteDataGridViewTextBoxColumn.Name = "CantloteDataGridViewTextBoxColumn"
        Me.CantloteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantloteDataGridViewTextBoxColumn.Width = 150
        '
        'LotesvendidosBindingSource
        '
        Me.LotesvendidosBindingSource.DataMember = "Lotes_vendidos"
        Me.LotesvendidosBindingSource.DataSource = Me.DS_venta_regional
        '
        'DS_venta_regional
        '
        Me.DS_venta_regional.DataSetName = "DS_venta_regional"
        Me.DS_venta_regional.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaRegional_lotesvendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(343, 425)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VentaRegional_lotesvendidos"
        Me.Text = "Lotes vendidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesvendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_venta_regional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODpresentacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETnroloteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantloteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotesvendidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_venta_regional As Aplicacion.DS_venta_regional
    Friend WithEvents lb_presentacion As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents lb_nombre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
