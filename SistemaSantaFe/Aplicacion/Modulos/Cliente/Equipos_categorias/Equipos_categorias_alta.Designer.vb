<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipos_categorias_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipos_categorias_alta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_atributo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_subtipo_info = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_atributos = New System.Windows.Forms.DataGridView()
        Me.AtributosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Equipos_cat_DS = New Aplicacion.Equipos_cat_DS()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DG_subtipos = New System.Windows.Forms.DataGridView()
        Me.Cat2equipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SubtiposagregadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Subtipo = New System.Windows.Forms.GroupBox()
        Me.bot_agregar_cat = New System.Windows.Forms.Button()
        Me.txt_subtipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.bo_guardar = New System.Windows.Forms.Button()
        Me.BO_cancelar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cat2equipoidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat2caractidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat2caractatributoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_atributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtributosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Equipos_cat_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_subtipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubtiposagregadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Subtipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Subtipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_tipo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(923, 406)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los datos de la categoría"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.txt_atributo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_subtipo_info)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dg_atributos)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(531, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 277)
        Me.GroupBox3.TabIndex = 271
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Atributos (características) del Subtipo"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(199, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 27)
        Me.Button1.TabIndex = 275
        Me.Button1.Text = "Editar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Editar subtipo")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(326, 41)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 27)
        Me.Button5.TabIndex = 2
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button5, "Agregar atributo")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_atributo
        '
        Me.txt_atributo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_atributo.Location = New System.Drawing.Point(133, 45)
        Me.txt_atributo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_atributo.Name = "txt_atributo"
        Me.txt_atributo.Size = New System.Drawing.Size(185, 20)
        Me.txt_atributo.TabIndex = 1
        Me.txt_atributo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(74, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "Atributo:"
        '
        'txt_subtipo_info
        '
        Me.txt_subtipo_info.BackColor = System.Drawing.SystemColors.Info
        Me.txt_subtipo_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_subtipo_info.Location = New System.Drawing.Point(77, 19)
        Me.txt_subtipo_info.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_subtipo_info.Name = "txt_subtipo_info"
        Me.txt_subtipo_info.ReadOnly = True
        Me.txt_subtipo_info.Size = New System.Drawing.Size(292, 20)
        Me.txt_subtipo_info.TabIndex = 0
        Me.txt_subtipo_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 272
        Me.Label1.Text = "SUBTIPO:"
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
        Me.dg_atributos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cat2equipoidDataGridViewTextBoxColumn1, Me.Cat2caractidDataGridViewTextBoxColumn, Me.Cat2caractatributoDataGridViewTextBoxColumn, Me.estado_column, Me.DataGridViewTextBoxColumn1, Me.Column1})
        Me.dg_atributos.DataSource = Me.AtributosBindingSource
        Me.dg_atributos.Location = New System.Drawing.Point(7, 76)
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
        Me.dg_atributos.Size = New System.Drawing.Size(362, 154)
        Me.dg_atributos.StandardTab = True
        Me.dg_atributos.TabIndex = 3
        '
        'AtributosBindingSource
        '
        Me.AtributosBindingSource.DataMember = "Atributos"
        Me.AtributosBindingSource.DataSource = Me.Equipos_cat_DS
        '
        'Equipos_cat_DS
        '
        Me.Equipos_cat_DS.DataSetName = "Equipos_cat_DS"
        Me.Equipos_cat_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button4.Location = New System.Drawing.Point(289, 237)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 27)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Quitar"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button4, "Quitar atributo")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.DG_subtipos)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 277)
        Me.GroupBox2.TabIndex = 270
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subtipos agregados"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.CargarDato
        Me.Button3.Location = New System.Drawing.Point(395, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 43)
        Me.Button3.TabIndex = 272
        Me.Button3.Text = "Editar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button3, "Editar subtipo")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DG_subtipos
        '
        Me.DG_subtipos.AllowUserToAddRows = False
        Me.DG_subtipos.AllowUserToDeleteRows = False
        Me.DG_subtipos.AllowUserToResizeRows = False
        Me.DG_subtipos.AutoGenerateColumns = False
        Me.DG_subtipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_subtipos.BackgroundColor = System.Drawing.Color.White
        Me.DG_subtipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_subtipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_subtipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cat2equipoidDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.estado, Me.item})
        Me.DG_subtipos.DataSource = Me.SubtiposagregadosBindingSource
        Me.DG_subtipos.Location = New System.Drawing.Point(7, 20)
        Me.DG_subtipos.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_subtipos.MultiSelect = False
        Me.DG_subtipos.Name = "DG_subtipos"
        Me.DG_subtipos.ReadOnly = True
        Me.DG_subtipos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_subtipos.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_subtipos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_subtipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_subtipos.Size = New System.Drawing.Size(472, 202)
        Me.DG_subtipos.StandardTab = True
        Me.DG_subtipos.TabIndex = 0
        '
        'Cat2equipoidDataGridViewTextBoxColumn
        '
        Me.Cat2equipoidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cat2equipoidDataGridViewTextBoxColumn.DataPropertyName = "Cat2_equipo_id"
        Me.Cat2equipoidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.Cat2equipoidDataGridViewTextBoxColumn.Name = "Cat2equipoidDataGridViewTextBoxColumn"
        Me.Cat2equipoidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Subtipo"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Visible = False
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = ""
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 50
        '
        'SubtiposagregadosBindingSource
        '
        Me.SubtiposagregadosBindingSource.DataMember = "subtipos_agregados"
        Me.SubtiposagregadosBindingSource.DataSource = Me.Equipos_cat_DS
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button2.Location = New System.Drawing.Point(309, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 43)
        Me.Button2.TabIndex = 271
        Me.Button2.Text = "Quitar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Quitar subtipo")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Subtipo
        '
        Me.Subtipo.Controls.Add(Me.bot_agregar_cat)
        Me.Subtipo.Controls.Add(Me.txt_subtipo)
        Me.Subtipo.Location = New System.Drawing.Point(20, 58)
        Me.Subtipo.Name = "Subtipo"
        Me.Subtipo.Size = New System.Drawing.Size(492, 57)
        Me.Subtipo.TabIndex = 269
        Me.Subtipo.TabStop = False
        Me.Subtipo.Text = "Ingrese Subtipo:"
        '
        'bot_agregar_cat
        '
        Me.bot_agregar_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.bot_agregar_cat.Image = CType(resources.GetObject("bot_agregar_cat.Image"), System.Drawing.Image)
        Me.bot_agregar_cat.Location = New System.Drawing.Point(436, 11)
        Me.bot_agregar_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.bot_agregar_cat.Name = "bot_agregar_cat"
        Me.bot_agregar_cat.Size = New System.Drawing.Size(43, 37)
        Me.bot_agregar_cat.TabIndex = 1
        Me.bot_agregar_cat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.bot_agregar_cat, "Agregar subtipo")
        Me.bot_agregar_cat.UseVisualStyleBackColor = True
        '
        'txt_subtipo
        '
        Me.txt_subtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_subtipo.Location = New System.Drawing.Point(7, 20)
        Me.txt_subtipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_subtipo.Name = "txt_subtipo"
        Me.txt_subtipo.Size = New System.Drawing.Size(421, 20)
        Me.txt_subtipo.TabIndex = 0
        Me.txt_subtipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(17, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 268
        Me.Label2.Text = "TIPO:"
        '
        'txt_tipo
        '
        Me.txt_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_tipo.Location = New System.Drawing.Point(62, 31)
        Me.txt_tipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(386, 20)
        Me.txt_tipo.TabIndex = 0
        Me.txt_tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bo_guardar
        '
        Me.bo_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bo_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.bo_guardar.Location = New System.Drawing.Point(812, 422)
        Me.bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.bo_guardar.Name = "bo_guardar"
        Me.bo_guardar.Size = New System.Drawing.Size(115, 49)
        Me.bo_guardar.TabIndex = 271
        Me.bo_guardar.Text = "Guardar"
        Me.bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bo_guardar.UseVisualStyleBackColor = True
        '
        'BO_cancelar
        '
        Me.BO_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.BO_cancelar.Location = New System.Drawing.Point(689, 422)
        Me.BO_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cancelar.Name = "BO_cancelar"
        Me.BO_cancelar.Size = New System.Drawing.Size(115, 49)
        Me.BO_cancelar.TabIndex = 272
        Me.BO_cancelar.Text = "Cancelar"
        Me.BO_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cancelar.UseVisualStyleBackColor = True
        '
        'Cat2equipoidDataGridViewTextBoxColumn1
        '
        Me.Cat2equipoidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cat2equipoidDataGridViewTextBoxColumn1.DataPropertyName = "Cat2_equipo_id"
        Me.Cat2equipoidDataGridViewTextBoxColumn1.HeaderText = "Cat2_equipo_id"
        Me.Cat2equipoidDataGridViewTextBoxColumn1.Name = "Cat2equipoidDataGridViewTextBoxColumn1"
        Me.Cat2equipoidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.Cat2equipoidDataGridViewTextBoxColumn1.Visible = False
        '
        'Cat2caractidDataGridViewTextBoxColumn
        '
        Me.Cat2caractidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cat2caractidDataGridViewTextBoxColumn.DataPropertyName = "Cat2_caract_id"
        Me.Cat2caractidDataGridViewTextBoxColumn.HeaderText = "Cat2_caract_id"
        Me.Cat2caractidDataGridViewTextBoxColumn.Name = "Cat2caractidDataGridViewTextBoxColumn"
        Me.Cat2caractidDataGridViewTextBoxColumn.ReadOnly = True
        Me.Cat2caractidDataGridViewTextBoxColumn.Visible = False
        '
        'Cat2caractatributoDataGridViewTextBoxColumn
        '
        Me.Cat2caractatributoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cat2caractatributoDataGridViewTextBoxColumn.DataPropertyName = "Cat2_caract_atributo"
        Me.Cat2caractatributoDataGridViewTextBoxColumn.HeaderText = "Atributo"
        Me.Cat2caractatributoDataGridViewTextBoxColumn.Name = "Cat2caractatributoDataGridViewTextBoxColumn"
        Me.Cat2caractatributoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'estado_column
        '
        Me.estado_column.DataPropertyName = "estado"
        Me.estado_column.HeaderText = "estado"
        Me.estado_column.Name = "estado_column"
        Me.estado_column.ReadOnly = True
        Me.estado_column.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "subtipo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "subtipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Equipos_categorias_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(939, 484)
        Me.Controls.Add(Me.BO_cancelar)
        Me.Controls.Add(Me.bo_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Equipos_categorias_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear categoría de equipos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg_atributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtributosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Equipos_cat_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_subtipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubtiposagregadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Subtipo.ResumeLayout(False)
        Me.Subtipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Subtipo As System.Windows.Forms.GroupBox
    Friend WithEvents txt_subtipo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents bot_agregar_cat As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_subtipos As System.Windows.Forms.DataGridView
    Friend WithEvents SubtiposagregadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Equipos_cat_DS As Aplicacion.Equipos_cat_DS
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bo_guardar As System.Windows.Forms.Button
    Friend WithEvents BO_cancelar As System.Windows.Forms.Button
    Friend WithEvents Cat2equipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_atributo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_subtipo_info As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg_atributos As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents AtributosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cat2equipoidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat2caractidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat2caractatributoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
