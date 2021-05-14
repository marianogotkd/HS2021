<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mant_consulta
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_fantasia = New System.Windows.Forms.TextBox()
        Me.txt_sucursal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MantenimientoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantrealizadosidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantrealizadodetalleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat2caractatributoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat2caractidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantdetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantrealizadosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MANT_ds = New Aplicacion.MANT_ds()
        Me.txt_tipomantenimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_etiqueta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mantenimiento_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mant_realizados_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipo_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Etiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipomantenimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MantlistadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Categorias_DS = New Aplicacion.Categorias_DS()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantrealizadosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANT_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantlistadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_dni)
        Me.GroupBox1.Controls.Add(Me.txt_fantasia)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SUCURSAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FANTASIA O RAZON SOCIAL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DNI/CUIT:"
        '
        'txt_dni
        '
        Me.txt_dni.BackColor = System.Drawing.SystemColors.Info
        Me.txt_dni.Location = New System.Drawing.Point(85, 19)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.ReadOnly = True
        Me.txt_dni.Size = New System.Drawing.Size(154, 20)
        Me.txt_dni.TabIndex = 1
        '
        'txt_fantasia
        '
        Me.txt_fantasia.BackColor = System.Drawing.SystemColors.Info
        Me.txt_fantasia.Location = New System.Drawing.Point(431, 19)
        Me.txt_fantasia.Name = "txt_fantasia"
        Me.txt_fantasia.ReadOnly = True
        Me.txt_fantasia.Size = New System.Drawing.Size(363, 20)
        Me.txt_fantasia.TabIndex = 2
        '
        'txt_sucursal
        '
        Me.txt_sucursal.BackColor = System.Drawing.SystemColors.Info
        Me.txt_sucursal.Location = New System.Drawing.Point(93, 45)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(319, 20)
        Me.txt_sucursal.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.DG_clientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(811, 395)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTADO DE MANTENIMIENTOS PROGRAMADOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.txt_tipomantenimiento)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_etiqueta)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(797, 238)
        Me.GroupBox3.TabIndex = 241
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item seleccionado"
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(644, 179)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 242
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Aceptar, "Guardar cambios")
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MantenimientoidDataGridViewTextBoxColumn, Me.MantrealizadosidDataGridViewTextBoxColumn, Me.MantrealizadodetalleidDataGridViewTextBoxColumn, Me.Cat2caractatributoDataGridViewTextBoxColumn, Me.Cat2caractidDataGridViewTextBoxColumn, Me.MantdetalleDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MantrealizadosdetalleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 50)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(764, 122)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 241
        '
        'MantenimientoidDataGridViewTextBoxColumn
        '
        Me.MantenimientoidDataGridViewTextBoxColumn.DataPropertyName = "Mantenimiento_id"
        Me.MantenimientoidDataGridViewTextBoxColumn.HeaderText = "Mantenimiento_id"
        Me.MantenimientoidDataGridViewTextBoxColumn.Name = "MantenimientoidDataGridViewTextBoxColumn"
        Me.MantenimientoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantenimientoidDataGridViewTextBoxColumn.Visible = False
        '
        'MantrealizadosidDataGridViewTextBoxColumn
        '
        Me.MantrealizadosidDataGridViewTextBoxColumn.DataPropertyName = "Mant_realizados_id"
        Me.MantrealizadosidDataGridViewTextBoxColumn.HeaderText = "Mant_realizados_id"
        Me.MantrealizadosidDataGridViewTextBoxColumn.Name = "MantrealizadosidDataGridViewTextBoxColumn"
        Me.MantrealizadosidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantrealizadosidDataGridViewTextBoxColumn.Visible = False
        '
        'MantrealizadodetalleidDataGridViewTextBoxColumn
        '
        Me.MantrealizadodetalleidDataGridViewTextBoxColumn.DataPropertyName = "Mant_realizado_detalle_id"
        Me.MantrealizadodetalleidDataGridViewTextBoxColumn.HeaderText = "Mant_realizado_detalle_id"
        Me.MantrealizadodetalleidDataGridViewTextBoxColumn.Name = "MantrealizadodetalleidDataGridViewTextBoxColumn"
        Me.MantrealizadodetalleidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantrealizadodetalleidDataGridViewTextBoxColumn.Visible = False
        '
        'Cat2caractatributoDataGridViewTextBoxColumn
        '
        Me.Cat2caractatributoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cat2caractatributoDataGridViewTextBoxColumn.DataPropertyName = "Cat2_caract_atributo"
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        Me.Cat2caractatributoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cat2caractatributoDataGridViewTextBoxColumn.HeaderText = "Atributo"
        Me.Cat2caractatributoDataGridViewTextBoxColumn.Name = "Cat2caractatributoDataGridViewTextBoxColumn"
        Me.Cat2caractatributoDataGridViewTextBoxColumn.ReadOnly = True
        Me.Cat2caractatributoDataGridViewTextBoxColumn.Width = 200
        '
        'Cat2caractidDataGridViewTextBoxColumn
        '
        Me.Cat2caractidDataGridViewTextBoxColumn.DataPropertyName = "Cat2_caract_id"
        Me.Cat2caractidDataGridViewTextBoxColumn.HeaderText = "Cat2_caract_id"
        Me.Cat2caractidDataGridViewTextBoxColumn.Name = "Cat2caractidDataGridViewTextBoxColumn"
        Me.Cat2caractidDataGridViewTextBoxColumn.ReadOnly = True
        Me.Cat2caractidDataGridViewTextBoxColumn.Visible = False
        '
        'MantdetalleDataGridViewTextBoxColumn
        '
        Me.MantdetalleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MantdetalleDataGridViewTextBoxColumn.DataPropertyName = "Mant_detalle"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        Me.MantdetalleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MantdetalleDataGridViewTextBoxColumn.HeaderText = "Ingrese resultado"
        Me.MantdetalleDataGridViewTextBoxColumn.Name = "MantdetalleDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        '
        'MantrealizadosdetalleBindingSource
        '
        Me.MantrealizadosdetalleBindingSource.DataMember = "mant_realizados_detalle"
        Me.MantrealizadosdetalleBindingSource.DataSource = Me.MANT_ds
        '
        'MANT_ds
        '
        Me.MANT_ds.DataSetName = "MANT_ds"
        Me.MANT_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_tipomantenimiento
        '
        Me.txt_tipomantenimiento.BackColor = System.Drawing.SystemColors.Info
        Me.txt_tipomantenimiento.Location = New System.Drawing.Point(525, 23)
        Me.txt_tipomantenimiento.Name = "txt_tipomantenimiento"
        Me.txt_tipomantenimiento.ReadOnly = True
        Me.txt_tipomantenimiento.Size = New System.Drawing.Size(262, 20)
        Me.txt_tipomantenimiento.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(402, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo de mantenimiento:"
        '
        'txt_etiqueta
        '
        Me.txt_etiqueta.BackColor = System.Drawing.SystemColors.Info
        Me.txt_etiqueta.Location = New System.Drawing.Point(75, 23)
        Me.txt_etiqueta.Name = "txt_etiqueta"
        Me.txt_etiqueta.ReadOnly = True
        Me.txt_etiqueta.Size = New System.Drawing.Size(321, 20)
        Me.txt_etiqueta.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Etiqueta:"
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Equipo, Me.Mantenimiento_id, Me.Mant_realizados_id, Me.Equipo_id, Me.Sector, Me.Etiqueta, Me.Tipomantenimiento, Me.Estado, Me.item})
        Me.DG_clientes.DataSource = Me.MantlistadosBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(7, 20)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(797, 102)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 240
        '
        'Equipo
        '
        Me.Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Equipo.DataPropertyName = "Equipo"
        Me.Equipo.HeaderText = "Equipo"
        Me.Equipo.Name = "Equipo"
        Me.Equipo.ReadOnly = True
        '
        'Mantenimiento_id
        '
        Me.Mantenimiento_id.DataPropertyName = "Mantenimiento_id"
        Me.Mantenimiento_id.HeaderText = "Mantenimiento_id"
        Me.Mantenimiento_id.Name = "Mantenimiento_id"
        Me.Mantenimiento_id.ReadOnly = True
        '
        'Mant_realizados_id
        '
        Me.Mant_realizados_id.DataPropertyName = "Mant_realizados_id"
        Me.Mant_realizados_id.HeaderText = "Mant_realizados_id"
        Me.Mant_realizados_id.Name = "Mant_realizados_id"
        Me.Mant_realizados_id.ReadOnly = True
        '
        'Equipo_id
        '
        Me.Equipo_id.DataPropertyName = "Equipo_id"
        Me.Equipo_id.HeaderText = "Equipo_id"
        Me.Equipo_id.Name = "Equipo_id"
        Me.Equipo_id.ReadOnly = True
        '
        'Sector
        '
        Me.Sector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Sector.DataPropertyName = "Sector"
        Me.Sector.HeaderText = "Sector"
        Me.Sector.Name = "Sector"
        Me.Sector.ReadOnly = True
        '
        'Etiqueta
        '
        Me.Etiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Etiqueta.DataPropertyName = "Etiqueta"
        Me.Etiqueta.HeaderText = "Etiqueta"
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.ReadOnly = True
        '
        'Tipomantenimiento
        '
        Me.Tipomantenimiento.DataPropertyName = "Tipo_mantenimiento"
        Me.Tipomantenimiento.HeaderText = "Tipo de mantenimiento"
        Me.Tipomantenimiento.Name = "Tipomantenimiento"
        Me.Tipomantenimiento.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Estado.DataPropertyName = "estado"
        Me.Estado.HeaderText = "estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 50
        '
        'MantlistadosBindingSource
        '
        Me.MantlistadosBindingSource.DataMember = "mant_listados"
        Me.MantlistadosBindingSource.DataSource = Me.MANT_ds
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(604, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FECHA:"
        '
        'fecha
        '
        Me.fecha.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder
        Me.fecha.Enabled = False
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(695, 12)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(128, 30)
        Me.fecha.TabIndex = 3
        '
        'Categorias_DS
        '
        Me.Categorias_DS.DataSetName = "Categorias_DS"
        Me.Categorias_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mant_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(857, 554)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Mant_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mant_consulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantrealizadosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANT_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantlistadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents txt_fantasia As System.Windows.Forms.TextBox
    Friend WithEvents txt_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents MantlistadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MANT_ds As Aplicacion.MANT_ds
    Friend WithEvents Categorias_DS As Aplicacion.Categorias_DS
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_tipomantenimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_etiqueta As System.Windows.Forms.TextBox
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Equipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mantenimiento_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mant_realizados_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Equipo_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Etiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipomantenimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MantrealizadosdetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MantenimientoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantrealizadosidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantrealizadodetalleidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat2caractatributoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat2caractidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantdetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
