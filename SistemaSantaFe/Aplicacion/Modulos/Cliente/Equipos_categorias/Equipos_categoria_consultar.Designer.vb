<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipos_categoria_consultar
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.TipodescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat1equipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtiposconcatenadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriasconsultarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Equipos_cat_DS = New Aplicacion.Equipos_cat_DS()
        Me.BO_cliente_nuevo = New System.Windows.Forms.Button()
        Me.BO_cliente_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasconsultarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Equipos_cat_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DG_clientes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(748, 253)
        Me.GroupBox1.TabIndex = 247
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione la categoría editar:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Location = New System.Drawing.Point(12, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(722, 20)
        Me.TextBox1.TabIndex = 240
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipodescDataGridViewTextBoxColumn, Me.Cat1equipoidDataGridViewTextBoxColumn, Me.SubtiposconcatenadosDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.CategoriasconsultarBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(12, 57)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(722, 188)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 239
        '
        'TipodescDataGridViewTextBoxColumn
        '
        Me.TipodescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TipodescDataGridViewTextBoxColumn.DataPropertyName = "Tipo_desc"
        Me.TipodescDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipodescDataGridViewTextBoxColumn.Name = "TipodescDataGridViewTextBoxColumn"
        Me.TipodescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cat1equipoidDataGridViewTextBoxColumn
        '
        Me.Cat1equipoidDataGridViewTextBoxColumn.DataPropertyName = "Cat1_equipo_id"
        Me.Cat1equipoidDataGridViewTextBoxColumn.HeaderText = "Cat1_equipo_id"
        Me.Cat1equipoidDataGridViewTextBoxColumn.Name = "Cat1equipoidDataGridViewTextBoxColumn"
        Me.Cat1equipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.Cat1equipoidDataGridViewTextBoxColumn.Visible = False
        '
        'SubtiposconcatenadosDataGridViewTextBoxColumn
        '
        Me.SubtiposconcatenadosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SubtiposconcatenadosDataGridViewTextBoxColumn.DataPropertyName = "Subtipos_concatenados"
        Me.SubtiposconcatenadosDataGridViewTextBoxColumn.HeaderText = "Subtipos"
        Me.SubtiposconcatenadosDataGridViewTextBoxColumn.Name = "SubtiposconcatenadosDataGridViewTextBoxColumn"
        Me.SubtiposconcatenadosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriasconsultarBindingSource
        '
        Me.CategoriasconsultarBindingSource.DataMember = "Categorias_consultar"
        Me.CategoriasconsultarBindingSource.DataSource = Me.Equipos_cat_DS
        '
        'Equipos_cat_DS
        '
        Me.Equipos_cat_DS.DataSetName = "Equipos_cat_DS"
        Me.Equipos_cat_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_cliente_nuevo
        '
        Me.BO_cliente_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BO_cliente_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_cliente_nuevo.Location = New System.Drawing.Point(463, 273)
        Me.BO_cliente_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_nuevo.Name = "BO_cliente_nuevo"
        Me.BO_cliente_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_nuevo.TabIndex = 250
        Me.BO_cliente_nuevo.Text = "Agregar"
        Me.BO_cliente_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_nuevo.UseVisualStyleBackColor = True
        '
        'BO_cliente_modificar
        '
        Me.BO_cliente_modificar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BO_cliente_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_cliente_modificar.Location = New System.Drawing.Point(595, 274)
        Me.BO_cliente_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_modificar.Name = "BO_cliente_modificar"
        Me.BO_cliente_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_modificar.TabIndex = 249
        Me.BO_cliente_modificar.Text = "Editar"
        Me.BO_cliente_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_modificar.UseVisualStyleBackColor = True
        '
        'Equipos_categoria_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 325)
        Me.Controls.Add(Me.BO_cliente_nuevo)
        Me.Controls.Add(Me.BO_cliente_modificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Equipos_categoria_consultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorías de Equipos disponibles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasconsultarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Equipos_cat_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents BO_cliente_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_cliente_modificar As System.Windows.Forms.Button
    Friend WithEvents TipodescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat1equipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtiposconcatenadosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriasconsultarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Equipos_cat_DS As Aplicacion.Equipos_cat_DS
End Class
