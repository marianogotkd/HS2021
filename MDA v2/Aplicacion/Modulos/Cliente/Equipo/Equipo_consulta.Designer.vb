<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipo_consulta
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
        Me.tb_idcli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cb_sucursal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.Cliente_suc_sector_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_suc_sector_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BO_equipo_nuevo = New System.Windows.Forms.Button()
        Me.BO_equipo_editar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.EquipoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipodescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipodenominacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtiquetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Equipos_ds = New Aplicacion.Equipos_ds()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Equipos_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tb_idcli)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cb_sucursal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1106, 82)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'tb_idcli
        '
        Me.tb_idcli.Location = New System.Drawing.Point(82, 16)
        Me.tb_idcli.Name = "tb_idcli"
        Me.tb_idcli.ReadOnly = True
        Me.tb_idcli.Size = New System.Drawing.Size(102, 20)
        Me.tb_idcli.TabIndex = 257
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 256
        Me.Label3.Text = "ID de Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(798, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox1.TabIndex = 255
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'cb_sucursal
        '
        Me.cb_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sucursal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_sucursal.FormattingEnabled = True
        Me.cb_sucursal.Items.AddRange(New Object() {"Fraccionable", "No Fraccionable"})
        Me.cb_sucursal.Location = New System.Drawing.Point(528, 45)
        Me.cb_sucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_sucursal.Name = "cb_sucursal"
        Me.cb_sucursal.Size = New System.Drawing.Size(403, 21)
        Me.cb_sucursal.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sucursal:"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(82, 45)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(382, 20)
        Me.txt_cliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente:"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button5.Image = Global.Aplicacion.My.Resources.Resources.facturacion1
        Me.Button5.Location = New System.Drawing.Point(34, 456)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 50)
        Me.Button5.TabIndex = 255
        Me.Button5.Text = "Reportes de Equipos"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.DG_clientes)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1105, 346)
        Me.GroupBox2.TabIndex = 247
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Equipos disponibles:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1079, 20)
        Me.TextBox1.TabIndex = 240
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
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EquipoidDataGridViewTextBoxColumn, Me.EquipodescripcionDataGridViewTextBoxColumn, Me.EquipodenominacionDataGridViewTextBoxColumn, Me.ClientesucsectordenominacionDataGridViewTextBoxColumn, Me.Cliente_suc_sector_descripcion, Me.EtiquetaDataGridViewTextBoxColumn, Me.Categoria, Me.Cliente_suc_sector_id, Me.item})
        Me.DG_clientes.DataSource = Me.EquipoBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(12, 52)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(1079, 273)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 239
        '
        'Cliente_suc_sector_descripcion
        '
        Me.Cliente_suc_sector_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cliente_suc_sector_descripcion.DataPropertyName = "Cliente_suc_sector_descripcion"
        Me.Cliente_suc_sector_descripcion.HeaderText = "Sector"
        Me.Cliente_suc_sector_descripcion.Name = "Cliente_suc_sector_descripcion"
        Me.Cliente_suc_sector_descripcion.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Categoria.DataPropertyName = "Categoria"
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Cliente_suc_sector_id
        '
        Me.Cliente_suc_sector_id.DataPropertyName = "Cliente_suc_sector_id"
        Me.Cliente_suc_sector_id.HeaderText = "Cliente_suc_sector_id"
        Me.Cliente_suc_sector_id.Name = "Cliente_suc_sector_id"
        Me.Cliente_suc_sector_id.ReadOnly = True
        Me.Cliente_suc_sector_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cliente_suc_sector_id.Visible = False
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.Width = 30
        '
        'BO_equipo_nuevo
        '
        Me.BO_equipo_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BO_equipo_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_equipo_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_equipo_nuevo.Location = New System.Drawing.Point(979, 455)
        Me.BO_equipo_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_equipo_nuevo.Name = "BO_equipo_nuevo"
        Me.BO_equipo_nuevo.Size = New System.Drawing.Size(124, 50)
        Me.BO_equipo_nuevo.TabIndex = 250
        Me.BO_equipo_nuevo.Text = "Nuevo equipo"
        Me.BO_equipo_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_equipo_nuevo.UseVisualStyleBackColor = True
        '
        'BO_equipo_editar
        '
        Me.BO_equipo_editar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BO_equipo_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_equipo_editar.Image = Global.Aplicacion.My.Resources.Resources.Modificar
        Me.BO_equipo_editar.Location = New System.Drawing.Point(847, 456)
        Me.BO_equipo_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_equipo_editar.Name = "BO_equipo_editar"
        Me.BO_equipo_editar.Size = New System.Drawing.Size(124, 49)
        Me.BO_equipo_editar.TabIndex = 249
        Me.BO_equipo_editar.Text = "Editar equipo"
        Me.BO_equipo_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_equipo_editar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button1.Location = New System.Drawing.Point(438, 456)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 49)
        Me.Button1.TabIndex = 251
        Me.Button1.Text = "Prog Mant"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button2.Location = New System.Drawing.Point(715, 455)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 50)
        Me.Button2.TabIndex = 252
        Me.Button2.Text = "Quitar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.Generar
        Me.Button3.Location = New System.Drawing.Point(306, 456)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 49)
        Me.Button3.TabIndex = 253
        Me.Button3.Text = "Sectores"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.codigo_qr1
        Me.Button4.Location = New System.Drawing.Point(174, 455)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 50)
        Me.Button4.TabIndex = 254
        Me.Button4.Text = "Generar QR"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button6.Image = Global.Aplicacion.My.Resources.Resources.facturacion1
        Me.Button6.Location = New System.Drawing.Point(570, 455)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(132, 50)
        Me.Button6.TabIndex = 256
        Me.Button6.Text = "Historial equipo"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'EquipoidDataGridViewTextBoxColumn
        '
        Me.EquipoidDataGridViewTextBoxColumn.DataPropertyName = "Equipo_id"
        Me.EquipoidDataGridViewTextBoxColumn.HeaderText = "ID del Equipo"
        Me.EquipoidDataGridViewTextBoxColumn.Name = "EquipoidDataGridViewTextBoxColumn"
        Me.EquipoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EquipoidDataGridViewTextBoxColumn.Visible = False
        '
        'EquipodescripcionDataGridViewTextBoxColumn
        '
        Me.EquipodescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EquipodescripcionDataGridViewTextBoxColumn.DataPropertyName = "Equipo_descripcion"
        Me.EquipodescripcionDataGridViewTextBoxColumn.HeaderText = "Equipo"
        Me.EquipodescripcionDataGridViewTextBoxColumn.Name = "EquipodescripcionDataGridViewTextBoxColumn"
        Me.EquipodescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EquipodenominacionDataGridViewTextBoxColumn
        '
        Me.EquipodenominacionDataGridViewTextBoxColumn.DataPropertyName = "Equipo_denominacion"
        Me.EquipodenominacionDataGridViewTextBoxColumn.HeaderText = "Equipo_denominacion"
        Me.EquipodenominacionDataGridViewTextBoxColumn.Name = "EquipodenominacionDataGridViewTextBoxColumn"
        Me.EquipodenominacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.EquipodenominacionDataGridViewTextBoxColumn.Visible = False
        '
        'ClientesucsectordenominacionDataGridViewTextBoxColumn
        '
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.DataPropertyName = "Cliente_suc_sector_denominacion"
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.HeaderText = "Cliente_suc_sector_denominacion"
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.Name = "ClientesucsectordenominacionDataGridViewTextBoxColumn"
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientesucsectordenominacionDataGridViewTextBoxColumn.Visible = False
        '
        'EtiquetaDataGridViewTextBoxColumn
        '
        Me.EtiquetaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EtiquetaDataGridViewTextBoxColumn.DataPropertyName = "etiqueta"
        Me.EtiquetaDataGridViewTextBoxColumn.HeaderText = "Etiqueta"
        Me.EtiquetaDataGridViewTextBoxColumn.Name = "EtiquetaDataGridViewTextBoxColumn"
        Me.EtiquetaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EquipoBindingSource
        '
        Me.EquipoBindingSource.DataMember = "Equipo"
        Me.EquipoBindingSource.DataSource = Me.Equipos_ds
        '
        'Equipos_ds
        '
        Me.Equipos_ds.DataSetName = "Equipos_ds"
        Me.Equipos_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Equipo_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1130, 512)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BO_equipo_nuevo)
        Me.Controls.Add(Me.BO_equipo_editar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Equipo_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipos disponibles de la sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Equipos_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents BO_equipo_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_equipo_editar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cb_sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents EquipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Equipos_ds As Aplicacion.Equipos_ds
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tb_idcli As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EquipoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EquipodescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EquipodenominacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientesucsectordenominacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente_suc_sector_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtiquetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente_suc_sector_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
