<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipo_historial
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipo_historial))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_etiqueta = New System.Windows.Forms.TextBox()
        Me.txt_sector = New System.Windows.Forms.TextBox()
        Me.txt_categoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_sucursal = New System.Windows.Forms.TextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.GroupBox5_A = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.EquipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtiquetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipomantenimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantenimientoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantrealizadosidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodicidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MantlistadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Equipos_ds = New Aplicacion.Equipos_ds()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5_A.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantlistadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Equipos_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_etiqueta)
        Me.GroupBox1.Controls.Add(Me.txt_sector)
        Me.GroupBox1.Controls.Add(Me.txt_categoria)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_cliente)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Equipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(420, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Categoría:"
        '
        'txt_etiqueta
        '
        Me.txt_etiqueta.BackColor = System.Drawing.SystemColors.Info
        Me.txt_etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_etiqueta.ForeColor = System.Drawing.Color.Blue
        Me.txt_etiqueta.Location = New System.Drawing.Point(483, 71)
        Me.txt_etiqueta.Name = "txt_etiqueta"
        Me.txt_etiqueta.ReadOnly = True
        Me.txt_etiqueta.Size = New System.Drawing.Size(298, 20)
        Me.txt_etiqueta.TabIndex = 10
        '
        'txt_sector
        '
        Me.txt_sector.BackColor = System.Drawing.SystemColors.Info
        Me.txt_sector.Location = New System.Drawing.Point(71, 71)
        Me.txt_sector.Name = "txt_sector"
        Me.txt_sector.ReadOnly = True
        Me.txt_sector.Size = New System.Drawing.Size(298, 20)
        Me.txt_sector.TabIndex = 9
        '
        'txt_categoria
        '
        Me.txt_categoria.BackColor = System.Drawing.SystemColors.Info
        Me.txt_categoria.Location = New System.Drawing.Point(483, 19)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.ReadOnly = True
        Me.txt_categoria.Size = New System.Drawing.Size(298, 20)
        Me.txt_categoria.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sucursal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Etiqueta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sector:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(430, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre:"
        '
        'txt_sucursal
        '
        Me.txt_sucursal.BackColor = System.Drawing.SystemColors.Info
        Me.txt_sucursal.Location = New System.Drawing.Point(71, 45)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(298, 20)
        Me.txt_sucursal.TabIndex = 2
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.SystemColors.Info
        Me.txt_cliente.Location = New System.Drawing.Point(71, 19)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(298, 20)
        Me.txt_cliente.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Info
        Me.txt_nombre.Location = New System.Drawing.Point(483, 45)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(298, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'GroupBox5_A
        '
        Me.GroupBox5_A.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5_A.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5_A.Controls.Add(Me.Button3)
        Me.GroupBox5_A.Controls.Add(Me.Button2)
        Me.GroupBox5_A.Controls.Add(Me.Button1)
        Me.GroupBox5_A.Controls.Add(Me.DG_clientes)
        Me.GroupBox5_A.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox5_A.Name = "GroupBox5_A"
        Me.GroupBox5_A.Size = New System.Drawing.Size(839, 326)
        Me.GroupBox5_A.TabIndex = 1
        Me.GroupBox5_A.TabStop = False
        Me.GroupBox5_A.Text = "Historial"
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button3.Location = New System.Drawing.Point(223, 265)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 43)
        Me.Button3.TabIndex = 249
        Me.Button3.Text = "Eliminar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button2.Location = New System.Drawing.Point(353, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 43)
        Me.Button2.TabIndex = 248
        Me.Button2.Text = "Ver detalle"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button1.Location = New System.Drawing.Point(483, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 247
        Me.Button1.Text = "Reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EquipoDataGridViewTextBoxColumn, Me.SectorDataGridViewTextBoxColumn, Me.EtiquetaDataGridViewTextBoxColumn, Me.TipomantenimientoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.MantenimientoidDataGridViewTextBoxColumn, Me.MantrealizadosidDataGridViewTextBoxColumn, Me.EquipoidDataGridViewTextBoxColumn, Me.PeriodicidadDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.Servicio_id, Me.diagnostico, Me.item})
        Me.DG_clientes.DataSource = Me.MantlistadosBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(17, 20)
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
        Me.DG_clientes.Size = New System.Drawing.Size(816, 218)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 242
        '
        'EquipoDataGridViewTextBoxColumn
        '
        Me.EquipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo"
        Me.EquipoDataGridViewTextBoxColumn.HeaderText = "Equipo"
        Me.EquipoDataGridViewTextBoxColumn.Name = "EquipoDataGridViewTextBoxColumn"
        Me.EquipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EquipoDataGridViewTextBoxColumn.Visible = False
        '
        'SectorDataGridViewTextBoxColumn
        '
        Me.SectorDataGridViewTextBoxColumn.DataPropertyName = "Sector"
        Me.SectorDataGridViewTextBoxColumn.HeaderText = "Sector"
        Me.SectorDataGridViewTextBoxColumn.Name = "SectorDataGridViewTextBoxColumn"
        Me.SectorDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectorDataGridViewTextBoxColumn.Visible = False
        '
        'EtiquetaDataGridViewTextBoxColumn
        '
        Me.EtiquetaDataGridViewTextBoxColumn.DataPropertyName = "Etiqueta"
        Me.EtiquetaDataGridViewTextBoxColumn.HeaderText = "Etiqueta"
        Me.EtiquetaDataGridViewTextBoxColumn.Name = "EtiquetaDataGridViewTextBoxColumn"
        Me.EtiquetaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtiquetaDataGridViewTextBoxColumn.Visible = False
        '
        'TipomantenimientoDataGridViewTextBoxColumn
        '
        Me.TipomantenimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TipomantenimientoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_mantenimiento"
        Me.TipomantenimientoDataGridViewTextBoxColumn.FillWeight = 60.17964!
        Me.TipomantenimientoDataGridViewTextBoxColumn.HeaderText = "Tipo de trabajo"
        Me.TipomantenimientoDataGridViewTextBoxColumn.Name = "TipomantenimientoDataGridViewTextBoxColumn"
        Me.TipomantenimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
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
        'EquipoidDataGridViewTextBoxColumn
        '
        Me.EquipoidDataGridViewTextBoxColumn.DataPropertyName = "Equipo_id"
        Me.EquipoidDataGridViewTextBoxColumn.HeaderText = "Equipo_id"
        Me.EquipoidDataGridViewTextBoxColumn.Name = "EquipoidDataGridViewTextBoxColumn"
        Me.EquipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EquipoidDataGridViewTextBoxColumn.Visible = False
        '
        'PeriodicidadDataGridViewTextBoxColumn
        '
        Me.PeriodicidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PeriodicidadDataGridViewTextBoxColumn.DataPropertyName = "periodicidad"
        Me.PeriodicidadDataGridViewTextBoxColumn.FillWeight = 60.17964!
        Me.PeriodicidadDataGridViewTextBoxColumn.HeaderText = "periodicidad"
        Me.PeriodicidadDataGridViewTextBoxColumn.Name = "PeriodicidadDataGridViewTextBoxColumn"
        Me.PeriodicidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.FillWeight = 179.6407!
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoriaDataGridViewTextBoxColumn.Visible = False
        '
        'Servicio_id
        '
        Me.Servicio_id.DataPropertyName = "Servicio_id"
        Me.Servicio_id.HeaderText = "Servicio_id"
        Me.Servicio_id.Name = "Servicio_id"
        Me.Servicio_id.ReadOnly = True
        Me.Servicio_id.Visible = False
        '
        'diagnostico
        '
        Me.diagnostico.DataPropertyName = "diagnostico"
        Me.diagnostico.HeaderText = "diagnostico"
        Me.diagnostico.Name = "diagnostico"
        Me.diagnostico.ReadOnly = True
        Me.diagnostico.Visible = False
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 30
        '
        'MantlistadosBindingSource
        '
        Me.MantlistadosBindingSource.DataMember = "mant_listados"
        Me.MantlistadosBindingSource.DataSource = Me.Equipos_ds
        '
        'Equipos_ds
        '
        Me.Equipos_ds.DataSetName = "Equipos_ds"
        Me.Equipos_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(839, 80)
        Me.GroupBox3.TabIndex = 248
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrar"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(73, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 248
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_buscar)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(515, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(309, 54)
        Me.GroupBox4.TabIndex = 249
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingrese parametro de busqueda:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(69, 24)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(217, 20)
        Me.txt_buscar.TabIndex = 250
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 249
        Me.Label7.Text = "BUSCAR:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_buscar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.fecha_hasta)
        Me.GroupBox2.Controls.Add(Me.fecha_desde)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(31, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 54)
        Me.GroupBox2.TabIndex = 248
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha"
        '
        'Button_buscar
        '
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.Location = New System.Drawing.Point(426, 18)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(41, 30)
        Me.Button_buscar.TabIndex = 251
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 250
        Me.Label8.Text = "HASTA:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 249
        Me.Label9.Text = "DESDE:"
        '
        'fecha_hasta
        '
        Me.fecha_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_hasta.Location = New System.Drawing.Point(291, 18)
        Me.fecha_hasta.Name = "fecha_hasta"
        Me.fecha_hasta.Size = New System.Drawing.Size(128, 30)
        Me.fecha_hasta.TabIndex = 249
        '
        'fecha_desde
        '
        Me.fecha_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_desde.Location = New System.Drawing.Point(68, 18)
        Me.fecha_desde.Name = "fecha_desde"
        Me.fecha_desde.Size = New System.Drawing.Size(128, 30)
        Me.fecha_desde.TabIndex = 248
        '
        'Equipo_historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 541)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5_A)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(875, 580)
        Me.Name = "Equipo_historial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial del Equipo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5_A.ResumeLayout(False)
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantlistadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Equipos_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_sector As System.Windows.Forms.TextBox
    Friend WithEvents txt_categoria As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_etiqueta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5_A As System.Windows.Forms.GroupBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents MantlistadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Equipos_ds As Aplicacion.Equipos_ds
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents EquipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtiquetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipomantenimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantenimientoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantrealizadosidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EquipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodicidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diagnostico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
