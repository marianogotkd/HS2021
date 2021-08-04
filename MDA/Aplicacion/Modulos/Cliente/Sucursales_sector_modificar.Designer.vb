<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sucursales_sector_modificar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_sucursal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_sector = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClientesucsectoridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesucsectornroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesucsectordescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BO_equipo_nuevo = New System.Windows.Forms.Button()
        Me.BO_equipo_editar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_sector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sucursal:"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.SystemColors.Info
        Me.txt_cliente.Location = New System.Drawing.Point(81, 12)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(290, 20)
        Me.txt_cliente.TabIndex = 2
        '
        'txt_sucursal
        '
        Me.txt_sucursal.BackColor = System.Drawing.SystemColors.Info
        Me.txt_sucursal.Location = New System.Drawing.Point(81, 38)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(290, 20)
        Me.txt_sucursal.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DG_sector)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 199)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Sector disponibles"
        '
        'DG_sector
        '
        Me.DG_sector.AllowUserToAddRows = False
        Me.DG_sector.AllowUserToDeleteRows = False
        Me.DG_sector.AllowUserToResizeRows = False
        Me.DG_sector.AutoGenerateColumns = False
        Me.DG_sector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_sector.BackgroundColor = System.Drawing.Color.White
        Me.DG_sector.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_sector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_sector.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.ClientesucsectoridDataGridViewTextBoxColumn, Me.ClientesucsectornroDataGridViewTextBoxColumn, Me.ClientesucsectordescripcionDataGridViewTextBoxColumn, Me.ClientesucsectordenominacionDataGridViewTextBoxColumn, Me.SucxClieidDataGridViewTextBoxColumn})
        Me.DG_sector.DataSource = Me.SectoresBindingSource
        Me.DG_sector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_sector.Location = New System.Drawing.Point(3, 16)
        Me.DG_sector.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_sector.MultiSelect = False
        Me.DG_sector.Name = "DG_sector"
        Me.DG_sector.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_sector.RowHeadersVisible = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_sector.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_sector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_sector.Size = New System.Drawing.Size(441, 180)
        Me.DG_sector.StandardTab = True
        Me.DG_sector.TabIndex = 240
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.FillWeight = 76.14214!
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.Width = 50
        '
        'ClientesucsectoridDataGridViewTextBoxColumn
        '
        Me.ClientesucsectoridDataGridViewTextBoxColumn.DataPropertyName = "Cliente_suc_sector_id"
        Me.ClientesucsectoridDataGridViewTextBoxColumn.HeaderText = "Cliente_suc_sector_id"
        Me.ClientesucsectoridDataGridViewTextBoxColumn.Name = "ClientesucsectoridDataGridViewTextBoxColumn"
        Me.ClientesucsectoridDataGridViewTextBoxColumn.Visible = False
        '
        'ClientesucsectornroDataGridViewTextBoxColumn
        '
        Me.ClientesucsectornroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClientesucsectornroDataGridViewTextBoxColumn.DataPropertyName = "Cliente_suc_sector_nro"
        Me.ClientesucsectornroDataGridViewTextBoxColumn.HeaderText = "Cliente_suc_sector_nro"
        Me.ClientesucsectornroDataGridViewTextBoxColumn.Name = "ClientesucsectornroDataGridViewTextBoxColumn"
        Me.ClientesucsectornroDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientesucsectornroDataGridViewTextBoxColumn.Visible = False
        '
        'ClientesucsectordescripcionDataGridViewTextBoxColumn
        '
        Me.ClientesucsectordescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClientesucsectordescripcionDataGridViewTextBoxColumn.DataPropertyName = "Cliente_suc_sector_descripcion"
        Me.ClientesucsectordescripcionDataGridViewTextBoxColumn.FillWeight = 111.9289!
        Me.ClientesucsectordescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.ClientesucsectordescripcionDataGridViewTextBoxColumn.Name = "ClientesucsectordescripcionDataGridViewTextBoxColumn"
        Me.ClientesucsectordescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientesucsectordenominacionDataGridViewTextBoxColumn
        '
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.DataPropertyName = "Cliente_suc_sector_denominacion"
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.FillWeight = 111.9289!
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.HeaderText = "Denominación"
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.Name = "ClientesucsectordenominacionDataGridViewTextBoxColumn"
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucxClieidDataGridViewTextBoxColumn
        '
        Me.SucxClieidDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_id"
        Me.SucxClieidDataGridViewTextBoxColumn.HeaderText = "SucxClie_id"
        Me.SucxClieidDataGridViewTextBoxColumn.Name = "SucxClieidDataGridViewTextBoxColumn"
        Me.SucxClieidDataGridViewTextBoxColumn.Visible = False
        '
        'SectoresBindingSource
        '
        Me.SectoresBindingSource.DataMember = "Sectores"
        Me.SectoresBindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button2.Location = New System.Drawing.Point(91, 289)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 43)
        Me.Button2.TabIndex = 255
        Me.Button2.Text = "Quitar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BO_equipo_nuevo
        '
        Me.BO_equipo_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BO_equipo_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_equipo_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_equipo_nuevo.Location = New System.Drawing.Point(297, 288)
        Me.BO_equipo_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_equipo_nuevo.Name = "BO_equipo_nuevo"
        Me.BO_equipo_nuevo.Size = New System.Drawing.Size(95, 44)
        Me.BO_equipo_nuevo.TabIndex = 254
        Me.BO_equipo_nuevo.Text = "Nuevo"
        Me.BO_equipo_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_equipo_nuevo.UseVisualStyleBackColor = True
        '
        'BO_equipo_editar
        '
        Me.BO_equipo_editar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BO_equipo_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_equipo_editar.Image = Global.Aplicacion.My.Resources.Resources.Modificar
        Me.BO_equipo_editar.Location = New System.Drawing.Point(194, 288)
        Me.BO_equipo_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_equipo_editar.Name = "BO_equipo_editar"
        Me.BO_equipo_editar.Size = New System.Drawing.Size(95, 44)
        Me.BO_equipo_editar.TabIndex = 253
        Me.BO_equipo_editar.Text = "Editar"
        Me.BO_equipo_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_equipo_editar.UseVisualStyleBackColor = True
        '
        'Sucursales_sector_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(508, 343)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BO_equipo_nuevo)
        Me.Controls.Add(Me.BO_equipo_editar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_sucursal)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(514, 372)
        Me.Name = "Sucursales_sector_modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar sectores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_sector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_sector As System.Windows.Forms.DataGridView
    Friend WithEvents SectoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClientesucsectoridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientesucsectornroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientesucsectordescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientesucsectordenominacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BO_equipo_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_equipo_editar As System.Windows.Forms.Button
End Class
