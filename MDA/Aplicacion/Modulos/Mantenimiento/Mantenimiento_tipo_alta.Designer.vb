<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento_tipo_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mantenimiento_tipo_alta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_dias = New System.Windows.Forms.NumericUpDown()
        Me.label_dias = New System.Windows.Forms.Label()
        Me.label_desc = New System.Windows.Forms.Label()
        Me.txt_periodicidad_desc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DG_PERIODICIDAD = New System.Windows.Forms.DataGridView()
        Me.MantperiodicidadidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantperiodicidaddescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PeriodicidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mantenimiento_ds = New Aplicacion.mantenimiento_ds()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BO_cancelar = New System.Windows.Forms.Button()
        Me.bo_guardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_dias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_PERIODICIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodicidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 123)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese la siguiente información:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tipo de Mantenimiento:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt_dias)
        Me.GroupBox2.Controls.Add(Me.label_dias)
        Me.GroupBox2.Controls.Add(Me.label_desc)
        Me.GroupBox2.Controls.Add(Me.txt_periodicidad_desc)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 63)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese periodicidad:"
        '
        'txt_dias
        '
        Me.txt_dias.BackColor = System.Drawing.SystemColors.Info
        Me.txt_dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_dias.Location = New System.Drawing.Point(321, 21)
        Me.txt_dias.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.txt_dias.Name = "txt_dias"
        Me.txt_dias.ReadOnly = True
        Me.txt_dias.Size = New System.Drawing.Size(56, 26)
        Me.txt_dias.TabIndex = 1
        Me.txt_dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_dias
        '
        Me.label_dias.AutoSize = True
        Me.label_dias.Location = New System.Drawing.Point(282, 28)
        Me.label_dias.Name = "label_dias"
        Me.label_dias.Size = New System.Drawing.Size(33, 13)
        Me.label_dias.TabIndex = 19
        Me.label_dias.Text = "Días:"
        '
        'label_desc
        '
        Me.label_desc.AutoSize = True
        Me.label_desc.Location = New System.Drawing.Point(17, 28)
        Me.label_desc.Name = "label_desc"
        Me.label_desc.Size = New System.Drawing.Size(66, 13)
        Me.label_desc.TabIndex = 18
        Me.label_desc.Text = "Descripción:"
        '
        'txt_periodicidad_desc
        '
        Me.txt_periodicidad_desc.Location = New System.Drawing.Point(89, 25)
        Me.txt_periodicidad_desc.Name = "txt_periodicidad_desc"
        Me.txt_periodicidad_desc.Size = New System.Drawing.Size(180, 20)
        Me.txt_periodicidad_desc.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(395, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Agregar nuevo")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(141, 25)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(292, 20)
        Me.txt_descripcion.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button4.Location = New System.Drawing.Point(385, 162)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 27)
        Me.Button4.TabIndex = 276
        Me.Button4.Text = "Quitar"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button4, "Quitar atributo")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(295, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 27)
        Me.Button2.TabIndex = 277
        Me.Button2.Text = "Editar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Editar subtipo")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.DG_PERIODICIDAD)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 195)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregados:"
        '
        'DG_PERIODICIDAD
        '
        Me.DG_PERIODICIDAD.AllowUserToAddRows = False
        Me.DG_PERIODICIDAD.AllowUserToDeleteRows = False
        Me.DG_PERIODICIDAD.AllowUserToResizeRows = False
        Me.DG_PERIODICIDAD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_PERIODICIDAD.AutoGenerateColumns = False
        Me.DG_PERIODICIDAD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_PERIODICIDAD.BackgroundColor = System.Drawing.Color.White
        Me.DG_PERIODICIDAD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_PERIODICIDAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PERIODICIDAD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MantperiodicidadidDataGridViewTextBoxColumn, Me.MantperiodicidaddescDataGridViewTextBoxColumn, Me.MantperiodicidaddiasDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.item})
        Me.DG_PERIODICIDAD.DataSource = Me.PeriodicidadBindingSource
        Me.DG_PERIODICIDAD.Location = New System.Drawing.Point(8, 20)
        Me.DG_PERIODICIDAD.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_PERIODICIDAD.MultiSelect = False
        Me.DG_PERIODICIDAD.Name = "DG_PERIODICIDAD"
        Me.DG_PERIODICIDAD.ReadOnly = True
        Me.DG_PERIODICIDAD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_PERIODICIDAD.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_PERIODICIDAD.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_PERIODICIDAD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_PERIODICIDAD.Size = New System.Drawing.Size(457, 135)
        Me.DG_PERIODICIDAD.StandardTab = True
        Me.DG_PERIODICIDAD.TabIndex = 0
        '
        'MantperiodicidadidDataGridViewTextBoxColumn
        '
        Me.MantperiodicidadidDataGridViewTextBoxColumn.DataPropertyName = "Mant_periodicidad_id"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.HeaderText = "Mant_periodicidad_id"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.Name = "MantperiodicidadidDataGridViewTextBoxColumn"
        Me.MantperiodicidadidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MantperiodicidadidDataGridViewTextBoxColumn.Visible = False
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
        Me.MantperiodicidaddiasDataGridViewTextBoxColumn.Width = 80
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = ""
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 20
        '
        'PeriodicidadBindingSource
        '
        Me.PeriodicidadBindingSource.DataMember = "periodicidad"
        Me.PeriodicidadBindingSource.DataSource = Me.Mantenimiento_ds
        '
        'Mantenimiento_ds
        '
        Me.Mantenimiento_ds.DataSetName = "mantenimiento_ds"
        Me.Mantenimiento_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_cancelar
        '
        Me.BO_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.BO_cancelar.Location = New System.Drawing.Point(242, 336)
        Me.BO_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cancelar.Name = "BO_cancelar"
        Me.BO_cancelar.Size = New System.Drawing.Size(115, 38)
        Me.BO_cancelar.TabIndex = 1
        Me.BO_cancelar.Text = "Cancelar"
        Me.BO_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cancelar.UseVisualStyleBackColor = True
        '
        'bo_guardar
        '
        Me.bo_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bo_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.bo_guardar.Location = New System.Drawing.Point(365, 336)
        Me.bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.bo_guardar.Name = "bo_guardar"
        Me.bo_guardar.Size = New System.Drawing.Size(115, 38)
        Me.bo_guardar.TabIndex = 0
        Me.bo_guardar.Text = "Guardar"
        Me.bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bo_guardar.UseVisualStyleBackColor = True
        '
        'Mantenimiento_tipo_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(496, 387)
        Me.Controls.Add(Me.BO_cancelar)
        Me.Controls.Add(Me.bo_guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mantenimiento_tipo_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar tipo de mantenimiento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_dias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG_PERIODICIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodicidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_periodicidad_desc As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_PERIODICIDAD As System.Windows.Forms.DataGridView
    Friend WithEvents txt_dias As System.Windows.Forms.NumericUpDown
    Friend WithEvents label_dias As System.Windows.Forms.Label
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents PeriodicidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mantenimiento_ds As Aplicacion.mantenimiento_ds
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_cancelar As System.Windows.Forms.Button
    Friend WithEvents bo_guardar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MantperiodicidadidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantperiodicidaddescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MantperiodicidaddiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
