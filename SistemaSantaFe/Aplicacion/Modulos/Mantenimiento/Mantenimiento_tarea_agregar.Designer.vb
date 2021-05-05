<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento_tarea_agregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mantenimiento_tarea_agregar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cb_periodicidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_subtipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bo_nuevosector = New System.Windows.Forms.Button()
        Me.cb_tipo_mant = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dg_atributos = New System.Windows.Forms.DataGridView()
        Me.TareasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TareasdescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManttipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantenimientotipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantperiodicidadidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodicidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat1equipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat2equipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TareasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mantenimiento_ds = New Aplicacion.mantenimiento_ds()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dg_atributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TareasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_descripcion)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 304)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar tareas de Equipos:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(350, 267)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 28)
        Me.Button1.TabIndex = 21
        Me.Button1.TabStop = False
        Me.Button1.Text = "Agregar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(54, 273)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(289, 20)
        Me.txt_descripcion.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.cb_periodicidad)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(444, 61)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione periodicidad:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(358, 19)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 28)
        Me.Button2.TabIndex = 23
        Me.Button2.TabStop = False
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cb_periodicidad
        '
        Me.cb_periodicidad.BackColor = System.Drawing.SystemColors.Info
        Me.cb_periodicidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_periodicidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_periodicidad.FormattingEnabled = True
        Me.cb_periodicidad.Location = New System.Drawing.Point(80, 22)
        Me.cb_periodicidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_periodicidad.Name = "cb_periodicidad"
        Me.cb_periodicidad.Size = New System.Drawing.Size(270, 21)
        Me.cb_periodicidad.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Periodicidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Tarea:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cb_subtipo)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.cb_tipo)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 161)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(444, 96)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seleccione Categoría de Equipo"
        '
        'cb_subtipo
        '
        Me.cb_subtipo.BackColor = System.Drawing.SystemColors.Info
        Me.cb_subtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subtipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_subtipo.FormattingEnabled = True
        Me.cb_subtipo.Location = New System.Drawing.Point(97, 54)
        Me.cb_subtipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_subtipo.Name = "cb_subtipo"
        Me.cb_subtipo.Size = New System.Drawing.Size(253, 21)
        Me.cb_subtipo.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Subtipo:"
        '
        'cb_tipo
        '
        Me.cb_tipo.BackColor = System.Drawing.SystemColors.Info
        Me.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Location = New System.Drawing.Point(44, 25)
        Me.cb_tipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(306, 21)
        Me.cb_tipo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Tipo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Bo_nuevosector)
        Me.GroupBox1.Controls.Add(Me.cb_tipo_mant)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 58)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione tipo de Mantenimiento"
        '
        'Bo_nuevosector
        '
        Me.Bo_nuevosector.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bo_nuevosector.Image = CType(resources.GetObject("Bo_nuevosector.Image"), System.Drawing.Image)
        Me.Bo_nuevosector.Location = New System.Drawing.Point(358, 22)
        Me.Bo_nuevosector.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_nuevosector.Name = "Bo_nuevosector"
        Me.Bo_nuevosector.Size = New System.Drawing.Size(33, 28)
        Me.Bo_nuevosector.TabIndex = 14
        Me.Bo_nuevosector.TabStop = False
        Me.Bo_nuevosector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_nuevosector.UseVisualStyleBackColor = True
        '
        'cb_tipo_mant
        '
        Me.cb_tipo_mant.BackColor = System.Drawing.SystemColors.Info
        Me.cb_tipo_mant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo_mant.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_tipo_mant.FormattingEnabled = True
        Me.cb_tipo_mant.Location = New System.Drawing.Point(44, 25)
        Me.cb_tipo_mant.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_tipo_mant.Name = "cb_tipo_mant"
        Me.cb_tipo_mant.Size = New System.Drawing.Size(306, 21)
        Me.cb_tipo_mant.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.dg_atributos)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox5.Location = New System.Drawing.Point(473, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(712, 304)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TAREAS CREADAS PARA:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(505, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 27)
        Me.Button3.TabIndex = 279
        Me.Button3.Text = "Editar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dg_atributos
        '
        Me.dg_atributos.AllowUserToAddRows = False
        Me.dg_atributos.AllowUserToDeleteRows = False
        Me.dg_atributos.AllowUserToResizeRows = False
        Me.dg_atributos.AutoGenerateColumns = False
        Me.dg_atributos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_atributos.BackgroundColor = System.Drawing.Color.White
        Me.dg_atributos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_atributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_atributos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TareasidDataGridViewTextBoxColumn, Me.TareasdescDataGridViewTextBoxColumn, Me.ManttipoidDataGridViewTextBoxColumn, Me.MantenimientotipoDataGridViewTextBoxColumn, Me.MantperiodicidadidDataGridViewTextBoxColumn, Me.PeriodicidadDataGridViewTextBoxColumn, Me.Cat1equipoidDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.Cat2equipoidDataGridViewTextBoxColumn, Me.SubtipoDataGridViewTextBoxColumn, Me.item})
        Me.dg_atributos.DataSource = Me.TareasBindingSource
        Me.dg_atributos.Location = New System.Drawing.Point(7, 20)
        Me.dg_atributos.Margin = New System.Windows.Forms.Padding(4)
        Me.dg_atributos.MultiSelect = False
        Me.dg_atributos.Name = "dg_atributos"
        Me.dg_atributos.ReadOnly = True
        Me.dg_atributos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_atributos.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_atributos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_atributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_atributos.Size = New System.Drawing.Size(683, 237)
        Me.dg_atributos.StandardTab = True
        Me.dg_atributos.TabIndex = 4
        '
        'TareasidDataGridViewTextBoxColumn
        '
        Me.TareasidDataGridViewTextBoxColumn.DataPropertyName = "Tareas_id"
        Me.TareasidDataGridViewTextBoxColumn.HeaderText = "Tareas_id"
        Me.TareasidDataGridViewTextBoxColumn.Name = "TareasidDataGridViewTextBoxColumn"
        Me.TareasidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TareasidDataGridViewTextBoxColumn.Visible = False
        '
        'TareasdescDataGridViewTextBoxColumn
        '
        Me.TareasdescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TareasdescDataGridViewTextBoxColumn.DataPropertyName = "Tareas_desc"
        Me.TareasdescDataGridViewTextBoxColumn.HeaderText = "TAREA"
        Me.TareasdescDataGridViewTextBoxColumn.Name = "TareasdescDataGridViewTextBoxColumn"
        Me.TareasdescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ManttipoidDataGridViewTextBoxColumn
        '
        Me.ManttipoidDataGridViewTextBoxColumn.DataPropertyName = "Mant_tipo_id"
        Me.ManttipoidDataGridViewTextBoxColumn.HeaderText = "Mant_tipo_id"
        Me.ManttipoidDataGridViewTextBoxColumn.Name = "ManttipoidDataGridViewTextBoxColumn"
        Me.ManttipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ManttipoidDataGridViewTextBoxColumn.Visible = False
        '
        'MantenimientotipoDataGridViewTextBoxColumn
        '
        Me.MantenimientotipoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MantenimientotipoDataGridViewTextBoxColumn.DataPropertyName = "Mantenimiento_tipo"
        Me.MantenimientotipoDataGridViewTextBoxColumn.HeaderText = "MANTENIMIENTO"
        Me.MantenimientotipoDataGridViewTextBoxColumn.Name = "MantenimientotipoDataGridViewTextBoxColumn"
        Me.MantenimientotipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MantperiodicidadidDataGridViewTextBoxColumn
        '
        Me.MantperiodicidadidDataGridViewTextBoxColumn.DataPropertyName = "Mant_periodicidad_id"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.HeaderText = "Mant_periodicidad_id"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.Name = "MantperiodicidadidDataGridViewTextBoxColumn"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantperiodicidadidDataGridViewTextBoxColumn.Visible = False
        '
        'PeriodicidadDataGridViewTextBoxColumn
        '
        Me.PeriodicidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PeriodicidadDataGridViewTextBoxColumn.DataPropertyName = "Periodicidad"
        Me.PeriodicidadDataGridViewTextBoxColumn.HeaderText = "PERIODICIDAD"
        Me.PeriodicidadDataGridViewTextBoxColumn.Name = "PeriodicidadDataGridViewTextBoxColumn"
        Me.PeriodicidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cat1equipoidDataGridViewTextBoxColumn
        '
        Me.Cat1equipoidDataGridViewTextBoxColumn.DataPropertyName = "Cat1_equipo_id"
        Me.Cat1equipoidDataGridViewTextBoxColumn.HeaderText = "Cat1_equipo_id"
        Me.Cat1equipoidDataGridViewTextBoxColumn.Name = "Cat1equipoidDataGridViewTextBoxColumn"
        Me.Cat1equipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.Cat1equipoidDataGridViewTextBoxColumn.Visible = False
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Visible = False
        '
        'Cat2equipoidDataGridViewTextBoxColumn
        '
        Me.Cat2equipoidDataGridViewTextBoxColumn.DataPropertyName = "Cat2_equipo_id"
        Me.Cat2equipoidDataGridViewTextBoxColumn.HeaderText = "Cat2_equipo_id"
        Me.Cat2equipoidDataGridViewTextBoxColumn.Name = "Cat2equipoidDataGridViewTextBoxColumn"
        Me.Cat2equipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.Cat2equipoidDataGridViewTextBoxColumn.Visible = False
        '
        'SubtipoDataGridViewTextBoxColumn
        '
        Me.SubtipoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SubtipoDataGridViewTextBoxColumn.DataPropertyName = "Subtipo"
        Me.SubtipoDataGridViewTextBoxColumn.HeaderText = "Subtipo"
        Me.SubtipoDataGridViewTextBoxColumn.Name = "SubtipoDataGridViewTextBoxColumn"
        Me.SubtipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtipoDataGridViewTextBoxColumn.Visible = False
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 50
        '
        'TareasBindingSource
        '
        Me.TareasBindingSource.DataMember = "Tareas"
        Me.TareasBindingSource.DataSource = Me.Mantenimiento_ds
        '
        'Mantenimiento_ds
        '
        Me.Mantenimiento_ds.DataSetName = "mantenimiento_ds"
        Me.Mantenimiento_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button4.Location = New System.Drawing.Point(595, 267)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 27)
        Me.Button4.TabIndex = 278
        Me.Button4.Text = "Quitar"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Mantenimiento_tarea_agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1193, 313)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mantenimiento_tarea_agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento - Agregar tareas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dg_atributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TareasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_periodicidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_subtipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Bo_nuevosector As System.Windows.Forms.Button
    Friend WithEvents cb_tipo_mant As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_atributos As System.Windows.Forms.DataGridView
    Friend WithEvents TareasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mantenimiento_ds As Aplicacion.mantenimiento_ds
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TareasidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TareasdescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManttipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantenimientotipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantperiodicidadidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodicidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat1equipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat2equipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
