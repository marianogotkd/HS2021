<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipo_nuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipo_nuevo))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_sucursal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_subtipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_equipo_denominacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_equipo_descripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bo_nuevosector = New System.Windows.Forms.Button()
        Me.cb_sector = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BO_cancelar = New System.Windows.Forms.Button()
        Me.bo_guardar = New System.Windows.Forms.Button()
        Me.dg_atributos = New System.Windows.Forms.DataGridView()
        Me.EquipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat2_caract_atributo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat2_caract_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Atributo_detalle_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipoatributodetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Equipos_cat_DS = New Aplicacion.Equipos_cat_DS()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg_atributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipoatributodetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Equipos_cat_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'txt_sucursal
        '
        Me.txt_sucursal.BackColor = System.Drawing.SystemColors.Info
        Me.txt_sucursal.Location = New System.Drawing.Point(63, 51)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(373, 20)
        Me.txt_sucursal.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sucursal:"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.SystemColors.Info
        Me.txt_cliente.Location = New System.Drawing.Point(54, 25)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(382, 20)
        Me.txt_cliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Bo_nuevosector)
        Me.GroupBox2.Controls.Add(Me.cb_sector)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 265)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ingrese la siguiente infomación:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_equipo_denominacion)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_equipo_descripcion)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(427, 202)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EQUIPO"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_subtipo)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.cb_tipo)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 93)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(385, 96)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Categoría"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(401, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "?"
        '
        'txt_equipo_denominacion
        '
        Me.txt_equipo_denominacion.Location = New System.Drawing.Point(85, 56)
        Me.txt_equipo_denominacion.Name = "txt_equipo_denominacion"
        Me.txt_equipo_denominacion.Size = New System.Drawing.Size(310, 20)
        Me.txt_equipo_denominacion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Denominación:"
        '
        'txt_equipo_descripcion
        '
        Me.txt_equipo_descripcion.Location = New System.Drawing.Point(79, 23)
        Me.txt_equipo_descripcion.Name = "txt_equipo_descripcion"
        Me.txt_equipo_descripcion.Size = New System.Drawing.Size(316, 20)
        Me.txt_equipo_descripcion.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripción:"
        '
        'Bo_nuevosector
        '
        Me.Bo_nuevosector.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bo_nuevosector.Image = CType(resources.GetObject("Bo_nuevosector.Image"), System.Drawing.Image)
        Me.Bo_nuevosector.Location = New System.Drawing.Point(283, 22)
        Me.Bo_nuevosector.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_nuevosector.Name = "Bo_nuevosector"
        Me.Bo_nuevosector.Size = New System.Drawing.Size(33, 28)
        Me.Bo_nuevosector.TabIndex = 13
        Me.Bo_nuevosector.TabStop = False
        Me.Bo_nuevosector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_nuevosector.UseVisualStyleBackColor = True
        '
        'cb_sector
        '
        Me.cb_sector.BackColor = System.Drawing.SystemColors.Info
        Me.cb_sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sector.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_sector.FormattingEnabled = True
        Me.cb_sector.Location = New System.Drawing.Point(54, 25)
        Me.cb_sector.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_sector.Name = "cb_sector"
        Me.cb_sector.Size = New System.Drawing.Size(221, 21)
        Me.cb_sector.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sector:"
        '
        'BO_cancelar
        '
        Me.BO_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.BO_cancelar.Location = New System.Drawing.Point(48, 551)
        Me.BO_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cancelar.Name = "BO_cancelar"
        Me.BO_cancelar.Size = New System.Drawing.Size(115, 49)
        Me.BO_cancelar.TabIndex = 274
        Me.BO_cancelar.Text = "Cancelar"
        Me.BO_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cancelar.UseVisualStyleBackColor = True
        '
        'bo_guardar
        '
        Me.bo_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bo_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.bo_guardar.Location = New System.Drawing.Point(336, 551)
        Me.bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.bo_guardar.Name = "bo_guardar"
        Me.bo_guardar.Size = New System.Drawing.Size(115, 49)
        Me.bo_guardar.TabIndex = 273
        Me.bo_guardar.Text = "Guardar"
        Me.bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bo_guardar.UseVisualStyleBackColor = True
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
        Me.dg_atributos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EquipoidDataGridViewTextBoxColumn, Me.Cat2_caract_atributo, Me.Cat2_caract_id, Me.Atributo_detalle_valor})
        Me.dg_atributos.DataSource = Me.EquipoatributodetalleBindingSource
        Me.dg_atributos.Location = New System.Drawing.Point(12, 376)
        Me.dg_atributos.Margin = New System.Windows.Forms.Padding(4)
        Me.dg_atributos.MultiSelect = False
        Me.dg_atributos.Name = "dg_atributos"
        Me.dg_atributos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_atributos.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_atributos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_atributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dg_atributos.Size = New System.Drawing.Size(459, 154)
        Me.dg_atributos.StandardTab = True
        Me.dg_atributos.TabIndex = 275
        '
        'EquipoidDataGridViewTextBoxColumn
        '
        Me.EquipoidDataGridViewTextBoxColumn.DataPropertyName = "Equipo_id"
        Me.EquipoidDataGridViewTextBoxColumn.HeaderText = "Equipo_id"
        Me.EquipoidDataGridViewTextBoxColumn.Name = "EquipoidDataGridViewTextBoxColumn"
        Me.EquipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EquipoidDataGridViewTextBoxColumn.Visible = False
        '
        'Cat2_caract_atributo
        '
        Me.Cat2_caract_atributo.DataPropertyName = "Cat2_caract_atributo"
        Me.Cat2_caract_atributo.HeaderText = "Caracteristicas"
        Me.Cat2_caract_atributo.Name = "Cat2_caract_atributo"
        Me.Cat2_caract_atributo.ReadOnly = True
        '
        'Cat2_caract_id
        '
        Me.Cat2_caract_id.DataPropertyName = "Cat2_caract_id"
        Me.Cat2_caract_id.HeaderText = "Cat2_caract_id"
        Me.Cat2_caract_id.Name = "Cat2_caract_id"
        Me.Cat2_caract_id.ReadOnly = True
        Me.Cat2_caract_id.Visible = False
        '
        'Atributo_detalle_valor
        '
        Me.Atributo_detalle_valor.DataPropertyName = "Atributo_detalle_valor"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Atributo_detalle_valor.DefaultCellStyle = DataGridViewCellStyle1
        Me.Atributo_detalle_valor.HeaderText = "Valor"
        Me.Atributo_detalle_valor.Name = "Atributo_detalle_valor"
        '
        'EquipoatributodetalleBindingSource
        '
        Me.EquipoatributodetalleBindingSource.DataMember = "Equipo_atributo_detalle"
        Me.EquipoatributodetalleBindingSource.DataSource = Me.Equipos_cat_DS
        '
        'Equipos_cat_DS
        '
        Me.Equipos_cat_DS.DataSetName = "Equipos_cat_DS"
        Me.Equipos_cat_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button4.Location = New System.Drawing.Point(171, 551)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 49)
        Me.Button4.TabIndex = 276
        Me.Button4.Text = "Reporte Informacion Actual"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Equipo_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(505, 625)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dg_atributos)
        Me.Controls.Add(Me.BO_cancelar)
        Me.Controls.Add(Me.bo_guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Equipo_nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo equipo del cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dg_atributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipoatributodetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Equipos_cat_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_sector As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_subtipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_equipo_denominacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_equipo_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Bo_nuevosector As System.Windows.Forms.Button
    Friend WithEvents BO_cancelar As System.Windows.Forms.Button
    Friend WithEvents bo_guardar As System.Windows.Forms.Button
    Friend WithEvents dg_atributos As System.Windows.Forms.DataGridView
    Friend WithEvents EquipoatributodetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Equipos_cat_DS As Aplicacion.Equipos_cat_DS
    Friend WithEvents EquipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat2_caract_atributo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat2_caract_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Atributo_detalle_valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
