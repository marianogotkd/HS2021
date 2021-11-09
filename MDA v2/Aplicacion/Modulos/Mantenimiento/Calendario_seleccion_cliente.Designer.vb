<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendario_seleccion_cliente
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BO_equipos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.Cliente1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DG_sucursales = New System.Windows.Forms.DataGridView()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIFanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClienombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieLocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnBDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClietelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxCliemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxCliedirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieCPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_sucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(858, 503)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.BO_equipos)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(850, 474)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Clientes registrados"
        '
        'BO_equipos
        '
        Me.BO_equipos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_equipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_equipos.Location = New System.Drawing.Point(709, 415)
        Me.BO_equipos.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_equipos.Name = "BO_equipos"
        Me.BO_equipos.Size = New System.Drawing.Size(124, 43)
        Me.BO_equipos.TabIndex = 249
        Me.BO_equipos.Text = "Siguiente"
        Me.BO_equipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_equipos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DG_clientes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(833, 391)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar (Fantasía o Razón Social / DNI/CUIT): "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 16)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "* Seleccione un cliente del listado para continuar."
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(12, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(807, 22)
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
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIidDataGridViewTextBoxColumn, Me.CLIFanDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIfnacDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn, Me.CLIobservacionesDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.Cliente1BindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(12, 78)
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
        Me.DG_clientes.Size = New System.Drawing.Size(807, 291)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 239
        '
        'Cliente1BindingSource
        '
        Me.Cliente1BindingSource.DataMember = "Cliente1"
        Me.Cliente1BindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(850, 474)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Selección de sucursal"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(577, 415)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 43)
        Me.Button2.TabIndex = 251
        Me.Button2.Text = "Atras"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(709, 415)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 250
        Me.Button1.Text = "Siguiente"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DG_sucursales)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(833, 391)
        Me.GroupBox2.TabIndex = 247
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sucursales disponibles del cliente: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(9, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 16)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "* Seleccione un sucursal del listado para continuar."
        '
        'DG_sucursales
        '
        Me.DG_sucursales.AllowUserToAddRows = False
        Me.DG_sucursales.AllowUserToDeleteRows = False
        Me.DG_sucursales.AllowUserToResizeRows = False
        Me.DG_sucursales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_sucursales.AutoGenerateColumns = False
        Me.DG_sucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_sucursales.BackgroundColor = System.Drawing.Color.White
        Me.DG_sucursales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_sucursales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SucxClieidDataGridViewTextBoxColumn, Me.SucxClienombreDataGridViewTextBoxColumn, Me.SucxClieProvDataGridViewTextBoxColumn, Me.SucxClieLocDataGridViewTextBoxColumn, Me.EnBDDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.SucxClietelDataGridViewTextBoxColumn, Me.SucxCliemailDataGridViewTextBoxColumn, Me.SucxCliedirDataGridViewTextBoxColumn, Me.SucxClieCPDataGridViewTextBoxColumn})
        Me.DG_sucursales.DataSource = Me.SucursalesBindingSource
        Me.DG_sucursales.Location = New System.Drawing.Point(12, 57)
        Me.DG_sucursales.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_sucursales.MultiSelect = False
        Me.DG_sucursales.Name = "DG_sucursales"
        Me.DG_sucursales.ReadOnly = True
        Me.DG_sucursales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_sucursales.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_sucursales.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_sucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_sucursales.Size = New System.Drawing.Size(807, 312)
        Me.DG_sucursales.StandardTab = True
        Me.DG_sucursales.TabIndex = 239
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.Cliente_ds
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIFanDataGridViewTextBoxColumn
        '
        Me.CLIFanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIFanDataGridViewTextBoxColumn.DataPropertyName = "CLI_Fan"
        Me.CLIFanDataGridViewTextBoxColumn.HeaderText = "Fantasía o Razón Social"
        Me.CLIFanDataGridViewTextBoxColumn.Name = "CLIFanDataGridViewTextBoxColumn"
        Me.CLIFanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "DNI/CUIT"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIapeDataGridViewTextBoxColumn
        '
        Me.CLIapeDataGridViewTextBoxColumn.DataPropertyName = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.HeaderText = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.Name = "CLIapeDataGridViewTextBoxColumn"
        Me.CLIapeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIapeDataGridViewTextBoxColumn.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Visible = False
        '
        'CLIfnacDataGridViewTextBoxColumn
        '
        Me.CLIfnacDataGridViewTextBoxColumn.DataPropertyName = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.HeaderText = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.Name = "CLIfnacDataGridViewTextBoxColumn"
        Me.CLIfnacDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIfnacDataGridViewTextBoxColumn.Visible = False
        '
        'CLItelDataGridViewTextBoxColumn
        '
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLItelDataGridViewTextBoxColumn.Visible = False
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLImailDataGridViewTextBoxColumn.Visible = False
        '
        'CLIobservacionesDataGridViewTextBoxColumn
        '
        Me.CLIobservacionesDataGridViewTextBoxColumn.DataPropertyName = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.HeaderText = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.Name = "CLIobservacionesDataGridViewTextBoxColumn"
        Me.CLIobservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIobservacionesDataGridViewTextBoxColumn.Visible = False
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClieidDataGridViewTextBoxColumn
        '
        Me.SucxClieidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SucxClieidDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_id"
        Me.SucxClieidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.SucxClieidDataGridViewTextBoxColumn.Name = "SucxClieidDataGridViewTextBoxColumn"
        Me.SucxClieidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucxClienombreDataGridViewTextBoxColumn
        '
        Me.SucxClienombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SucxClienombreDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_nombre"
        Me.SucxClienombreDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucxClienombreDataGridViewTextBoxColumn.Name = "SucxClienombreDataGridViewTextBoxColumn"
        Me.SucxClienombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucxClieProvDataGridViewTextBoxColumn
        '
        Me.SucxClieProvDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_Prov"
        Me.SucxClieProvDataGridViewTextBoxColumn.HeaderText = "SucxClie_Prov"
        Me.SucxClieProvDataGridViewTextBoxColumn.Name = "SucxClieProvDataGridViewTextBoxColumn"
        Me.SucxClieProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucxClieProvDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClieLocDataGridViewTextBoxColumn
        '
        Me.SucxClieLocDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_Loc"
        Me.SucxClieLocDataGridViewTextBoxColumn.HeaderText = "SucxClie_Loc"
        Me.SucxClieLocDataGridViewTextBoxColumn.Name = "SucxClieLocDataGridViewTextBoxColumn"
        Me.SucxClieLocDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucxClieLocDataGridViewTextBoxColumn.Visible = False
        '
        'EnBDDataGridViewTextBoxColumn
        '
        Me.EnBDDataGridViewTextBoxColumn.DataPropertyName = "EnBD"
        Me.EnBDDataGridViewTextBoxColumn.HeaderText = "EnBD"
        Me.EnBDDataGridViewTextBoxColumn.Name = "EnBDDataGridViewTextBoxColumn"
        Me.EnBDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnBDDataGridViewTextBoxColumn.Visible = False
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucxClietelDataGridViewTextBoxColumn
        '
        Me.SucxClietelDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_tel"
        Me.SucxClietelDataGridViewTextBoxColumn.HeaderText = "SucxClie_tel"
        Me.SucxClietelDataGridViewTextBoxColumn.Name = "SucxClietelDataGridViewTextBoxColumn"
        Me.SucxClietelDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucxClietelDataGridViewTextBoxColumn.Visible = False
        '
        'SucxCliemailDataGridViewTextBoxColumn
        '
        Me.SucxCliemailDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_mail"
        Me.SucxCliemailDataGridViewTextBoxColumn.HeaderText = "SucxClie_mail"
        Me.SucxCliemailDataGridViewTextBoxColumn.Name = "SucxCliemailDataGridViewTextBoxColumn"
        Me.SucxCliemailDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucxCliemailDataGridViewTextBoxColumn.Visible = False
        '
        'SucxCliedirDataGridViewTextBoxColumn
        '
        Me.SucxCliedirDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_dir"
        Me.SucxCliedirDataGridViewTextBoxColumn.HeaderText = "SucxClie_dir"
        Me.SucxCliedirDataGridViewTextBoxColumn.Name = "SucxCliedirDataGridViewTextBoxColumn"
        Me.SucxCliedirDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucxCliedirDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClieCPDataGridViewTextBoxColumn
        '
        Me.SucxClieCPDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_CP"
        Me.SucxClieCPDataGridViewTextBoxColumn.HeaderText = "SucxClie_CP"
        Me.SucxClieCPDataGridViewTextBoxColumn.Name = "SucxClieCPDataGridViewTextBoxColumn"
        Me.SucxClieCPDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucxClieCPDataGridViewTextBoxColumn.Visible = False
        '
        'Calendario_seleccion_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 529)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Calendario_seleccion_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario de Mantenimientos: Selección de cliente."
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_sucursales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_equipos As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Cliente1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DG_sucursales As System.Windows.Forms.DataGridView
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIFanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClienombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieProvDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieLocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnBDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClietelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxCliemailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxCliedirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieCPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
