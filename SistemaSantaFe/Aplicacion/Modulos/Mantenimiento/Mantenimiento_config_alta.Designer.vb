<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento_config_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mantenimiento_config_alta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_categoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_etiqueta = New System.Windows.Forms.TextBox()
        Me.txt_sector = New System.Windows.Forms.TextBox()
        Me.txt_equipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TareasasignadasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TareasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantenimientoidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TareasdescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TareasasignadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mantenimiento_ds = New Aplicacion.mantenimiento_ds()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.MantenimientoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantperiodicidadidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantenimientofechainicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantperiodicidaddescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManttipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManttipodescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MantenimientoprogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TareasasignadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantenimientoprogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_categoria)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_etiqueta)
        Me.GroupBox1.Controls.Add(Me.txt_sector)
        Me.GroupBox1.Controls.Add(Me.txt_equipo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION DEL EQUIPO"
        '
        'txt_categoria
        '
        Me.txt_categoria.BackColor = System.Drawing.SystemColors.Info
        Me.txt_categoria.Location = New System.Drawing.Point(182, 97)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.ReadOnly = True
        Me.txt_categoria.Size = New System.Drawing.Size(276, 20)
        Me.txt_categoria.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pertenece a la categoría:"
        '
        'txt_etiqueta
        '
        Me.txt_etiqueta.BackColor = System.Drawing.SystemColors.Info
        Me.txt_etiqueta.Location = New System.Drawing.Point(75, 70)
        Me.txt_etiqueta.Name = "txt_etiqueta"
        Me.txt_etiqueta.ReadOnly = True
        Me.txt_etiqueta.Size = New System.Drawing.Size(247, 20)
        Me.txt_etiqueta.TabIndex = 5
        '
        'txt_sector
        '
        Me.txt_sector.BackColor = System.Drawing.SystemColors.Info
        Me.txt_sector.Location = New System.Drawing.Point(75, 46)
        Me.txt_sector.Name = "txt_sector"
        Me.txt_sector.ReadOnly = True
        Me.txt_sector.Size = New System.Drawing.Size(247, 20)
        Me.txt_sector.TabIndex = 4
        '
        'txt_equipo
        '
        Me.txt_equipo.BackColor = System.Drawing.SystemColors.Info
        Me.txt_equipo.Location = New System.Drawing.Point(75, 22)
        Me.txt_equipo.Name = "txt_equipo"
        Me.txt_equipo.ReadOnly = True
        Me.txt_equipo.Size = New System.Drawing.Size(247, 20)
        Me.txt_equipo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Etiqueta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sector:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.DG_clientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(789, 262)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTADO DE MANTENIMIENTOS YA PROGRAMADOS:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(479, 221)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 27)
        Me.Button1.TabIndex = 282
        Me.Button1.TabStop = False
        Me.Button1.Text = "Agregar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(579, 221)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 27)
        Me.Button3.TabIndex = 281
        Me.Button3.Text = "Editar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button4.Location = New System.Drawing.Point(678, 221)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 27)
        Me.Button4.TabIndex = 280
        Me.Button4.Text = "Quitar"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(474, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 193)
        Me.GroupBox3.TabIndex = 241
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tareas del mantenimiento seleccionado:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TareasasignadasidDataGridViewTextBoxColumn, Me.TareasidDataGridViewTextBoxColumn, Me.MantenimientoidDataGridViewTextBoxColumn1, Me.TareasdescDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TareasasignadasBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(298, 174)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 243
        '
        'TareasasignadasidDataGridViewTextBoxColumn
        '
        Me.TareasasignadasidDataGridViewTextBoxColumn.DataPropertyName = "Tareas_asignadas_id"
        Me.TareasasignadasidDataGridViewTextBoxColumn.HeaderText = "Tareas_asignadas_id"
        Me.TareasasignadasidDataGridViewTextBoxColumn.Name = "TareasasignadasidDataGridViewTextBoxColumn"
        Me.TareasasignadasidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TareasasignadasidDataGridViewTextBoxColumn.Visible = False
        '
        'TareasidDataGridViewTextBoxColumn
        '
        Me.TareasidDataGridViewTextBoxColumn.DataPropertyName = "Tareas_id"
        Me.TareasidDataGridViewTextBoxColumn.HeaderText = "Tareas_id"
        Me.TareasidDataGridViewTextBoxColumn.Name = "TareasidDataGridViewTextBoxColumn"
        Me.TareasidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TareasidDataGridViewTextBoxColumn.Visible = False
        '
        'MantenimientoidDataGridViewTextBoxColumn1
        '
        Me.MantenimientoidDataGridViewTextBoxColumn1.DataPropertyName = "Mantenimiento_id"
        Me.MantenimientoidDataGridViewTextBoxColumn1.HeaderText = "Mantenimiento_id"
        Me.MantenimientoidDataGridViewTextBoxColumn1.Name = "MantenimientoidDataGridViewTextBoxColumn1"
        Me.MantenimientoidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MantenimientoidDataGridViewTextBoxColumn1.Visible = False
        '
        'TareasdescDataGridViewTextBoxColumn
        '
        Me.TareasdescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TareasdescDataGridViewTextBoxColumn.DataPropertyName = "Tareas_desc"
        Me.TareasdescDataGridViewTextBoxColumn.HeaderText = "Tareas"
        Me.TareasdescDataGridViewTextBoxColumn.Name = "TareasdescDataGridViewTextBoxColumn"
        Me.TareasdescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TareasasignadasBindingSource
        '
        Me.TareasasignadasBindingSource.DataMember = "Tareas_asignadas"
        Me.TareasasignadasBindingSource.DataSource = Me.Mantenimiento_ds
        '
        'Mantenimiento_ds
        '
        Me.Mantenimiento_ds.DataSetName = "mantenimiento_ds"
        Me.Mantenimiento_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MantenimientoidDataGridViewTextBoxColumn, Me.EquipoidDataGridViewTextBoxColumn, Me.MantperiodicidadidDataGridViewTextBoxColumn, Me.MantenimientofechainicioDataGridViewTextBoxColumn, Me.MantperiodicidaddescDataGridViewTextBoxColumn, Me.MantperiodicidaddiasDataGridViewTextBoxColumn, Me.ManttipoidDataGridViewTextBoxColumn, Me.ManttipodescrDataGridViewTextBoxColumn, Me.item})
        Me.DG_clientes.DataSource = Me.MantenimientoprogBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(7, 20)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(460, 232)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 240
        '
        'MantenimientoidDataGridViewTextBoxColumn
        '
        Me.MantenimientoidDataGridViewTextBoxColumn.DataPropertyName = "Mantenimiento_id"
        Me.MantenimientoidDataGridViewTextBoxColumn.HeaderText = "Mantenimiento_id"
        Me.MantenimientoidDataGridViewTextBoxColumn.Name = "MantenimientoidDataGridViewTextBoxColumn"
        Me.MantenimientoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantenimientoidDataGridViewTextBoxColumn.Visible = False
        '
        'EquipoidDataGridViewTextBoxColumn
        '
        Me.EquipoidDataGridViewTextBoxColumn.DataPropertyName = "Equipo_id"
        Me.EquipoidDataGridViewTextBoxColumn.HeaderText = "Equipo_id"
        Me.EquipoidDataGridViewTextBoxColumn.Name = "EquipoidDataGridViewTextBoxColumn"
        Me.EquipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EquipoidDataGridViewTextBoxColumn.Visible = False
        '
        'MantperiodicidadidDataGridViewTextBoxColumn
        '
        Me.MantperiodicidadidDataGridViewTextBoxColumn.DataPropertyName = "Mant_periodicidad_id"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.HeaderText = "Mant_periodicidad_id"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.Name = "MantperiodicidadidDataGridViewTextBoxColumn"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantperiodicidadidDataGridViewTextBoxColumn.Visible = False
        '
        'MantenimientofechainicioDataGridViewTextBoxColumn
        '
        Me.MantenimientofechainicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MantenimientofechainicioDataGridViewTextBoxColumn.DataPropertyName = "Mantenimiento_fecha_inicio"
        Me.MantenimientofechainicioDataGridViewTextBoxColumn.HeaderText = "Fecha de inicio"
        Me.MantenimientofechainicioDataGridViewTextBoxColumn.Name = "MantenimientofechainicioDataGridViewTextBoxColumn"
        Me.MantenimientofechainicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantenimientofechainicioDataGridViewTextBoxColumn.Width = 70
        '
        'MantperiodicidaddescDataGridViewTextBoxColumn
        '
        Me.MantperiodicidaddescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MantperiodicidaddescDataGridViewTextBoxColumn.DataPropertyName = "Mant_periodicidad_desc"
        Me.MantperiodicidaddescDataGridViewTextBoxColumn.HeaderText = "Periodicidad"
        Me.MantperiodicidaddescDataGridViewTextBoxColumn.Name = "MantperiodicidaddescDataGridViewTextBoxColumn"
        Me.MantperiodicidaddescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MantperiodicidaddiasDataGridViewTextBoxColumn
        '
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn.DataPropertyName = "Mant_periodicidad_dias"
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn.HeaderText = "Días"
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn.Name = "MantperiodicidaddiasDataGridViewTextBoxColumn"
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn.Width = 50
        '
        'ManttipoidDataGridViewTextBoxColumn
        '
        Me.ManttipoidDataGridViewTextBoxColumn.DataPropertyName = "Mant_tipo_id"
        Me.ManttipoidDataGridViewTextBoxColumn.HeaderText = "Mant_tipo_id"
        Me.ManttipoidDataGridViewTextBoxColumn.Name = "ManttipoidDataGridViewTextBoxColumn"
        Me.ManttipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ManttipoidDataGridViewTextBoxColumn.Visible = False
        '
        'ManttipodescrDataGridViewTextBoxColumn
        '
        Me.ManttipodescrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ManttipodescrDataGridViewTextBoxColumn.DataPropertyName = "Mant_tipo_descr"
        Me.ManttipodescrDataGridViewTextBoxColumn.HeaderText = "Tipo de mantenimiento"
        Me.ManttipodescrDataGridViewTextBoxColumn.Name = "ManttipodescrDataGridViewTextBoxColumn"
        Me.ManttipodescrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 30
        '
        'MantenimientoprogBindingSource
        '
        Me.MantenimientoprogBindingSource.DataMember = "Mantenimiento_prog"
        Me.MantenimientoprogBindingSource.DataSource = Me.Mantenimiento_ds
        '
        'Mantenimiento_config_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 423)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(824, 462)
        Me.Name = "Mantenimiento_config_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento del equipo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TareasasignadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantenimientoprogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_etiqueta As System.Windows.Forms.TextBox
    Friend WithEvents txt_sector As System.Windows.Forms.TextBox
    Friend WithEvents txt_equipo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_categoria As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents MantenimientoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EquipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantperiodicidadidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantenimientofechainicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantperiodicidaddescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantperiodicidaddiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManttipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManttipodescrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MantenimientoprogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mantenimiento_ds As Aplicacion.mantenimiento_ds
    Friend WithEvents TareasasignadasidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TareasidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantenimientoidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TareasdescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TareasasignadasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
