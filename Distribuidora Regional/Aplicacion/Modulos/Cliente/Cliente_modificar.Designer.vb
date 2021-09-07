<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente_modificar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.BO_Cargar = New System.Windows.Forms.Button()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DG_cliente = New System.Windows.Forms.DataGridView()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIcelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdirecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.LB_ERROR_cliente = New System.Windows.Forms.Label()
        Me.IM_ERROR_cliente = New System.Windows.Forms.PictureBox()
        Me.BO_ape = New System.Windows.Forms.Button()
        Me.TX_ape = New System.Windows.Forms.TextBox()
        Me.lb_ape_modif = New System.Windows.Forms.Label()
        Me.BO_doc = New System.Windows.Forms.Button()
        Me.TX_doc = New System.Windows.Forms.TextBox()
        Me.lb_dni_modif = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GP_Cliente = New System.Windows.Forms.GroupBox()
        Me.Tb_dir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_cel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_obser = New System.Windows.Forms.TextBox()
        Me.ERROR_tx_dni_clie = New System.Windows.Forms.PictureBox()
        Me.tx_tel_clie = New System.Windows.Forms.TextBox()
        Me.tx_mail_clie = New System.Windows.Forms.TextBox()
        Me.lb_nom = New System.Windows.Forms.Label()
        Me.tx_nom_clie = New System.Windows.Forms.TextBox()
        Me.lb_mail = New System.Windows.Forms.Label()
        Me.lb_tel = New System.Windows.Forms.Label()
        Me.BO_Guardar = New System.Windows.Forms.Button()
        Me.BO_Cancelar = New System.Windows.Forms.Button()
        Me.DataGrid_cliente = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IM_ERROR_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GP_Cliente.SuspendLayout()
        CType(Me.ERROR_tx_dni_clie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(866, 475)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Btn_Nuevo)
        Me.TabPage1.Controls.Add(Me.BO_Cargar)
        Me.TabPage1.Controls.Add(Me.BO_Eliminar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(858, 449)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Cliente: Buscar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Image = Global.Aplicacion.My.Resources.Resources.clipboard_32
        Me.Btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Nuevo.Location = New System.Drawing.Point(622, 372)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(69, 54)
        Me.Btn_Nuevo.TabIndex = 3
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Btn_Nuevo, "Nuevo")
        Me.Btn_Nuevo.UseVisualStyleBackColor = True
        '
        'BO_Cargar
        '
        Me.BO_Cargar.Image = CType(resources.GetObject("BO_Cargar.Image"), System.Drawing.Image)
        Me.BO_Cargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Cargar.Location = New System.Drawing.Point(697, 372)
        Me.BO_Cargar.Name = "BO_Cargar"
        Me.BO_Cargar.Size = New System.Drawing.Size(82, 54)
        Me.BO_Cargar.TabIndex = 0
        Me.BO_Cargar.Text = "Ir a Modificar"
        Me.BO_Cargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_Cargar, "Ir a Modificar")
        Me.BO_Cargar.UseVisualStyleBackColor = True
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Enabled = False
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Eliminar.Location = New System.Drawing.Point(785, 372)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(66, 54)
        Me.BO_Eliminar.TabIndex = 1
        Me.BO_Eliminar.Text = "Eliminar"
        Me.BO_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Eliminar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.LB_ERROR_cliente)
        Me.GroupBox1.Controls.Add(Me.IM_ERROR_cliente)
        Me.GroupBox1.Controls.Add(Me.BO_ape)
        Me.GroupBox1.Controls.Add(Me.TX_ape)
        Me.GroupBox1.Controls.Add(Me.lb_ape_modif)
        Me.GroupBox1.Controls.Add(Me.BO_doc)
        Me.GroupBox1.Controls.Add(Me.TX_doc)
        Me.GroupBox1.Controls.Add(Me.lb_dni_modif)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 346)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DG_cliente)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(33, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(806, 255)
        Me.GroupBox3.TabIndex = 237
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'DG_cliente
        '
        Me.DG_cliente.AllowUserToAddRows = False
        Me.DG_cliente.AllowUserToDeleteRows = False
        Me.DG_cliente.AutoGenerateColumns = False
        Me.DG_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_cliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIidDataGridViewTextBoxColumn, Me.Column1, Me.CLInomDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLIcelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn, Me.CLIdirecDataGridViewTextBoxColumn, Me.CLIobservacionesDataGridViewTextBoxColumn})
        Me.DG_cliente.DataSource = Me.ClienteBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_cliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_cliente.Location = New System.Drawing.Point(3, 16)
        Me.DG_cliente.Name = "DG_cliente"
        Me.DG_cliente.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_cliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_cliente.Size = New System.Drawing.Size(800, 236)
        Me.DG_cliente.TabIndex = 7
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Width = 150
        '
        'CLItelDataGridViewTextBoxColumn
        '
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIcelDataGridViewTextBoxColumn
        '
        Me.CLIcelDataGridViewTextBoxColumn.DataPropertyName = "CLI_cel"
        Me.CLIcelDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CLIcelDataGridViewTextBoxColumn.Name = "CLIcelDataGridViewTextBoxColumn"
        Me.CLIcelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIdirecDataGridViewTextBoxColumn
        '
        Me.CLIdirecDataGridViewTextBoxColumn.DataPropertyName = "CLI_direc"
        Me.CLIdirecDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.CLIdirecDataGridViewTextBoxColumn.Name = "CLIdirecDataGridViewTextBoxColumn"
        Me.CLIdirecDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIdirecDataGridViewTextBoxColumn.Width = 120
        '
        'CLIobservacionesDataGridViewTextBoxColumn
        '
        Me.CLIobservacionesDataGridViewTextBoxColumn.DataPropertyName = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.Name = "CLIobservacionesDataGridViewTextBoxColumn"
        Me.CLIobservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIobservacionesDataGridViewTextBoxColumn.Width = 120
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LB_ERROR_cliente
        '
        Me.LB_ERROR_cliente.AutoSize = True
        Me.LB_ERROR_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR_cliente.ForeColor = System.Drawing.Color.Red
        Me.LB_ERROR_cliente.Location = New System.Drawing.Point(617, 36)
        Me.LB_ERROR_cliente.Name = "LB_ERROR_cliente"
        Me.LB_ERROR_cliente.Size = New System.Drawing.Size(59, 15)
        Me.LB_ERROR_cliente.TabIndex = 236
        Me.LB_ERROR_cliente.Text = "No Existe"
        Me.LB_ERROR_cliente.Visible = False
        '
        'IM_ERROR_cliente
        '
        Me.IM_ERROR_cliente.Image = CType(resources.GetObject("IM_ERROR_cliente.Image"), System.Drawing.Image)
        Me.IM_ERROR_cliente.Location = New System.Drawing.Point(596, 34)
        Me.IM_ERROR_cliente.Name = "IM_ERROR_cliente"
        Me.IM_ERROR_cliente.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR_cliente.TabIndex = 235
        Me.IM_ERROR_cliente.TabStop = False
        Me.IM_ERROR_cliente.Visible = False
        '
        'BO_ape
        '
        Me.BO_ape.Image = CType(resources.GetObject("BO_ape.Image"), System.Drawing.Image)
        Me.BO_ape.Location = New System.Drawing.Point(288, 29)
        Me.BO_ape.Name = "BO_ape"
        Me.BO_ape.Size = New System.Drawing.Size(30, 30)
        Me.BO_ape.TabIndex = 5
        Me.BO_ape.UseVisualStyleBackColor = True
        '
        'TX_ape
        '
        Me.TX_ape.Location = New System.Drawing.Point(145, 34)
        Me.TX_ape.Name = "TX_ape"
        Me.TX_ape.Size = New System.Drawing.Size(124, 20)
        Me.TX_ape.TabIndex = 0
        '
        'lb_ape_modif
        '
        Me.lb_ape_modif.AutoSize = True
        Me.lb_ape_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ape_modif.Location = New System.Drawing.Point(79, 37)
        Me.lb_ape_modif.Name = "lb_ape_modif"
        Me.lb_ape_modif.Size = New System.Drawing.Size(52, 15)
        Me.lb_ape_modif.TabIndex = 3
        Me.lb_ape_modif.Text = "Nombre"
        '
        'BO_doc
        '
        Me.BO_doc.Image = CType(resources.GetObject("BO_doc.Image"), System.Drawing.Image)
        Me.BO_doc.Location = New System.Drawing.Point(560, 28)
        Me.BO_doc.Name = "BO_doc"
        Me.BO_doc.Size = New System.Drawing.Size(30, 30)
        Me.BO_doc.TabIndex = 2
        Me.BO_doc.UseVisualStyleBackColor = True
        '
        'TX_doc
        '
        Me.TX_doc.Location = New System.Drawing.Point(430, 34)
        Me.TX_doc.Name = "TX_doc"
        Me.TX_doc.Size = New System.Drawing.Size(124, 20)
        Me.TX_doc.TabIndex = 1
        '
        'lb_dni_modif
        '
        Me.lb_dni_modif.AutoSize = True
        Me.lb_dni_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni_modif.Location = New System.Drawing.Point(352, 37)
        Me.lb_dni_modif.Name = "lb_dni_modif"
        Me.lb_dni_modif.Size = New System.Drawing.Size(71, 15)
        Me.lb_dni_modif.TabIndex = 0
        Me.lb_dni_modif.Text = "Documento"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GP_Cliente)
        Me.TabPage2.Controls.Add(Me.BO_Guardar)
        Me.TabPage2.Controls.Add(Me.BO_Cancelar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 449)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Cliente: Datos Personales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GP_Cliente
        '
        Me.GP_Cliente.Controls.Add(Me.Tb_dir)
        Me.GP_Cliente.Controls.Add(Me.Label4)
        Me.GP_Cliente.Controls.Add(Me.Tb_cel)
        Me.GP_Cliente.Controls.Add(Me.Label3)
        Me.GP_Cliente.Controls.Add(Me.Label2)
        Me.GP_Cliente.Controls.Add(Me.tx_obser)
        Me.GP_Cliente.Controls.Add(Me.ERROR_tx_dni_clie)
        Me.GP_Cliente.Controls.Add(Me.tx_tel_clie)
        Me.GP_Cliente.Controls.Add(Me.tx_mail_clie)
        Me.GP_Cliente.Controls.Add(Me.lb_nom)
        Me.GP_Cliente.Controls.Add(Me.tx_nom_clie)
        Me.GP_Cliente.Controls.Add(Me.lb_mail)
        Me.GP_Cliente.Controls.Add(Me.lb_tel)
        Me.GP_Cliente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Cliente.Location = New System.Drawing.Point(86, 18)
        Me.GP_Cliente.Name = "GP_Cliente"
        Me.GP_Cliente.Size = New System.Drawing.Size(691, 271)
        Me.GP_Cliente.TabIndex = 5
        Me.GP_Cliente.TabStop = False
        Me.GP_Cliente.Text = "Datos Personales"
        '
        'Tb_dir
        '
        Me.Tb_dir.Location = New System.Drawing.Point(453, 162)
        Me.Tb_dir.Name = "Tb_dir"
        Me.Tb_dir.Size = New System.Drawing.Size(207, 20)
        Me.Tb_dir.TabIndex = 254
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(369, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 255
        Me.Label4.Text = "Direccion"
        '
        'Tb_cel
        '
        Me.Tb_cel.Location = New System.Drawing.Point(99, 205)
        Me.Tb_cel.Name = "Tb_cel"
        Me.Tb_cel.Size = New System.Drawing.Size(207, 20)
        Me.Tb_cel.TabIndex = 252
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(15, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 253
        Me.Label3.Text = "Celular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(365, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 251
        Me.Label2.Text = "Observaciones"
        '
        'tx_obser
        '
        Me.tx_obser.Location = New System.Drawing.Point(456, 118)
        Me.tx_obser.Name = "tx_obser"
        Me.tx_obser.Size = New System.Drawing.Size(190, 20)
        Me.tx_obser.TabIndex = 250
        '
        'ERROR_tx_dni_clie
        '
        Me.ERROR_tx_dni_clie.Image = CType(resources.GetObject("ERROR_tx_dni_clie.Image"), System.Drawing.Image)
        Me.ERROR_tx_dni_clie.Location = New System.Drawing.Point(296, 78)
        Me.ERROR_tx_dni_clie.Name = "ERROR_tx_dni_clie"
        Me.ERROR_tx_dni_clie.Size = New System.Drawing.Size(20, 20)
        Me.ERROR_tx_dni_clie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_dni_clie.TabIndex = 245
        Me.ERROR_tx_dni_clie.TabStop = False
        Me.ERROR_tx_dni_clie.Visible = False
        '
        'tx_tel_clie
        '
        Me.tx_tel_clie.Location = New System.Drawing.Point(100, 162)
        Me.tx_tel_clie.Name = "tx_tel_clie"
        Me.tx_tel_clie.Size = New System.Drawing.Size(207, 20)
        Me.tx_tel_clie.TabIndex = 5
        '
        'tx_mail_clie
        '
        Me.tx_mail_clie.Location = New System.Drawing.Point(100, 120)
        Me.tx_mail_clie.Name = "tx_mail_clie"
        Me.tx_mail_clie.Size = New System.Drawing.Size(207, 20)
        Me.tx_mail_clie.TabIndex = 4
        '
        'lb_nom
        '
        Me.lb_nom.AutoSize = True
        Me.lb_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nom.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_nom.Location = New System.Drawing.Point(31, 79)
        Me.lb_nom.Name = "lb_nom"
        Me.lb_nom.Size = New System.Drawing.Size(52, 15)
        Me.lb_nom.TabIndex = 234
        Me.lb_nom.Text = "Nombre"
        '
        'tx_nom_clie
        '
        Me.tx_nom_clie.Location = New System.Drawing.Point(100, 78)
        Me.tx_nom_clie.Name = "tx_nom_clie"
        Me.tx_nom_clie.Size = New System.Drawing.Size(190, 20)
        Me.tx_nom_clie.TabIndex = 1
        '
        'lb_mail
        '
        Me.lb_mail.AutoSize = True
        Me.lb_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mail.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_mail.Location = New System.Drawing.Point(16, 121)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(43, 15)
        Me.lb_mail.TabIndex = 239
        Me.lb_mail.Text = "E-mail"
        '
        'lb_tel
        '
        Me.lb_tel.AutoSize = True
        Me.lb_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_tel.Location = New System.Drawing.Point(16, 163)
        Me.lb_tel.Name = "lb_tel"
        Me.lb_tel.Size = New System.Drawing.Size(55, 15)
        Me.lb_tel.TabIndex = 241
        Me.lb_tel.Text = "Telefono"
        '
        'BO_Guardar
        '
        Me.BO_Guardar.Enabled = False
        Me.BO_Guardar.Image = CType(resources.GetObject("BO_Guardar.Image"), System.Drawing.Image)
        Me.BO_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Guardar.Location = New System.Drawing.Point(710, 295)
        Me.BO_Guardar.Name = "BO_Guardar"
        Me.BO_Guardar.Size = New System.Drawing.Size(57, 51)
        Me.BO_Guardar.TabIndex = 2
        Me.BO_Guardar.Text = "Guardar"
        Me.BO_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_Guardar, "Guardar")
        Me.BO_Guardar.UseVisualStyleBackColor = True
        '
        'BO_Cancelar
        '
        Me.BO_Cancelar.Enabled = False
        Me.BO_Cancelar.Image = CType(resources.GetObject("BO_Cancelar.Image"), System.Drawing.Image)
        Me.BO_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_Cancelar.Location = New System.Drawing.Point(773, 295)
        Me.BO_Cancelar.Name = "BO_Cancelar"
        Me.BO_Cancelar.Size = New System.Drawing.Size(63, 51)
        Me.BO_Cancelar.TabIndex = 0
        Me.BO_Cancelar.Text = "Cancelar"
        Me.BO_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BO_Cancelar.UseVisualStyleBackColor = True
        '
        'DataGrid_cliente
        '
        Me.DataGrid_cliente.AllowUserToAddRows = False
        Me.DataGrid_cliente.AllowUserToDeleteRows = False
        Me.DataGrid_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_cliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrid_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_cliente.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrid_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid_cliente.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid_cliente.Name = "DataGrid_cliente"
        Me.DataGrid_cliente.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_cliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrid_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_cliente.Size = New System.Drawing.Size(623, 236)
        Me.DataGrid_cliente.TabIndex = 7
        '
        'Cliente_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Cliente_modificar"
        Me.Text = "Gestión de Clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IM_ERROR_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GP_Cliente.ResumeLayout(False)
        Me.GP_Cliente.PerformLayout()
        CType(Me.ERROR_tx_dni_clie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_ape As System.Windows.Forms.Button
    Friend WithEvents TX_ape As System.Windows.Forms.TextBox
    Friend WithEvents lb_ape_modif As System.Windows.Forms.Label
    Friend WithEvents BO_doc As System.Windows.Forms.Button
    Friend WithEvents TX_doc As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni_modif As System.Windows.Forms.Label
    Friend WithEvents BO_Cargar As System.Windows.Forms.Button
    Friend WithEvents BO_Cancelar As System.Windows.Forms.Button
    Friend WithEvents BO_Guardar As System.Windows.Forms.Button
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents LB_ERROR_cliente As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR_cliente As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents DataGrid_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents GP_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents ERROR_tx_dni_clie As System.Windows.Forms.PictureBox
    Friend WithEvents tx_tel_clie As System.Windows.Forms.TextBox
    Friend WithEvents tx_mail_clie As System.Windows.Forms.TextBox
    Friend WithEvents lb_nom As System.Windows.Forms.Label
    Friend WithEvents tx_nom_clie As System.Windows.Forms.TextBox
    Friend WithEvents lb_mail As System.Windows.Forms.Label
    Friend WithEvents lb_tel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_obser As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Tb_dir As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tb_cel As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIcelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdirecDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
End Class
