<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento_config_agregar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_tipo_mant = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_periodicidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dg_tareas = New System.Windows.Forms.DataGridView()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg_tareas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TareasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cb_tipo_mant)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 58)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Seleccione tipo de Mantenimiento"
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cb_periodicidad)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 61)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "2. Seleccione periodicidad:"
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
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.dg_tareas)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(686, 205)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "3. Seleccione tareas a realizar:"
        '
        'dg_tareas
        '
        Me.dg_tareas.AllowUserToAddRows = False
        Me.dg_tareas.AllowUserToDeleteRows = False
        Me.dg_tareas.AllowUserToResizeRows = False
        Me.dg_tareas.AutoGenerateColumns = False
        Me.dg_tareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_tareas.BackgroundColor = System.Drawing.Color.White
        Me.dg_tareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TareasidDataGridViewTextBoxColumn, Me.TareasdescDataGridViewTextBoxColumn, Me.ManttipoidDataGridViewTextBoxColumn, Me.MantenimientotipoDataGridViewTextBoxColumn, Me.MantperiodicidadidDataGridViewTextBoxColumn, Me.PeriodicidadDataGridViewTextBoxColumn, Me.Cat1equipoidDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.Cat2equipoidDataGridViewTextBoxColumn, Me.SubtipoDataGridViewTextBoxColumn, Me.item})
        Me.dg_tareas.DataSource = Me.TareasBindingSource
        Me.dg_tareas.Location = New System.Drawing.Point(9, 20)
        Me.dg_tareas.Margin = New System.Windows.Forms.Padding(4)
        Me.dg_tareas.MultiSelect = False
        Me.dg_tareas.Name = "dg_tareas"
        Me.dg_tareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_tareas.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_tareas.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_tareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_tareas.Size = New System.Drawing.Size(665, 173)
        Me.dg_tareas.StandardTab = True
        Me.dg_tareas.TabIndex = 7
        '
        'TareasidDataGridViewTextBoxColumn
        '
        Me.TareasidDataGridViewTextBoxColumn.DataPropertyName = "Tareas_id"
        Me.TareasidDataGridViewTextBoxColumn.HeaderText = "Tareas_id"
        Me.TareasidDataGridViewTextBoxColumn.Name = "TareasidDataGridViewTextBoxColumn"
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
        Me.Cat1equipoidDataGridViewTextBoxColumn.Visible = False
        '
        'TipoDataGridViewTextBoxColumn
        '
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
        Me.Cat2equipoidDataGridViewTextBoxColumn.Visible = False
        '
        'SubtipoDataGridViewTextBoxColumn
        '
        Me.SubtipoDataGridViewTextBoxColumn.DataPropertyName = "Subtipo"
        Me.SubtipoDataGridViewTextBoxColumn.HeaderText = "Subtipo"
        Me.SubtipoDataGridViewTextBoxColumn.Name = "SubtipoDataGridViewTextBoxColumn"
        Me.SubtipoDataGridViewTextBoxColumn.Visible = False
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.fecha)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 58)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "4. Indique fecha de inicio:"
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(44, 19)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(152, 30)
        Me.fecha.TabIndex = 0
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(561, 360)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 16
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Mantenimiento_config_agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(707, 420)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mantenimiento_config_agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar nuevo mantenimiento de equipo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg_tareas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TareasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_tipo_mant As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_periodicidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_tareas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents TareasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mantenimiento_ds As Aplicacion.mantenimiento_ds
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
