<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor_modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor_modificar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BO_buscar_nom = New System.Windows.Forms.Button()
        Me.tx_nombre_modif = New System.Windows.Forms.TextBox()
        Me.lb_ape_modif = New System.Windows.Forms.Label()
        Me.BO_Buscar_Cod = New System.Windows.Forms.Button()
        Me.tx_cod_modif = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.BO_proveedor_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGrid_proveedor = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cód_Interno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dirección = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Teléfono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_dni_modif = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GP_proveedor = New System.Windows.Forms.GroupBox()
        Me.ERROR_tx_nombre = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_codinterno = New System.Windows.Forms.PictureBox()
        Me.tx_obs = New System.Windows.Forms.TextBox()
        Me.tx_mail = New System.Windows.Forms.TextBox()
        Me.tx_celular = New System.Windows.Forms.TextBox()
        Me.tx_telefono = New System.Windows.Forms.TextBox()
        Me.tx_direccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_responsable = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_codinterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GP_proveedor.SuspendLayout()
        CType(Me.ERROR_tx_nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_codinterno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BO_buscar_nom
        '
        Me.BO_buscar_nom.Image = CType(resources.GetObject("BO_buscar_nom.Image"), System.Drawing.Image)
        Me.BO_buscar_nom.Location = New System.Drawing.Point(500, 28)
        Me.BO_buscar_nom.Name = "BO_buscar_nom"
        Me.BO_buscar_nom.Size = New System.Drawing.Size(30, 30)
        Me.BO_buscar_nom.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BO_buscar_nom, "Buscar")
        Me.BO_buscar_nom.UseVisualStyleBackColor = True
        '
        'tx_nombre_modif
        '
        Me.tx_nombre_modif.Location = New System.Drawing.Point(370, 33)
        Me.tx_nombre_modif.Name = "tx_nombre_modif"
        Me.tx_nombre_modif.Size = New System.Drawing.Size(124, 20)
        Me.tx_nombre_modif.TabIndex = 4
        '
        'lb_ape_modif
        '
        Me.lb_ape_modif.AutoSize = True
        Me.lb_ape_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ape_modif.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_ape_modif.Location = New System.Drawing.Point(304, 36)
        Me.lb_ape_modif.Name = "lb_ape_modif"
        Me.lb_ape_modif.Size = New System.Drawing.Size(52, 15)
        Me.lb_ape_modif.TabIndex = 3
        Me.lb_ape_modif.Text = "Nombre"
        '
        'BO_Buscar_Cod
        '
        Me.BO_Buscar_Cod.Image = CType(resources.GetObject("BO_Buscar_Cod.Image"), System.Drawing.Image)
        Me.BO_Buscar_Cod.Location = New System.Drawing.Point(230, 27)
        Me.BO_Buscar_Cod.Name = "BO_Buscar_Cod"
        Me.BO_Buscar_Cod.Size = New System.Drawing.Size(30, 30)
        Me.BO_Buscar_Cod.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BO_Buscar_Cod, "Buscar")
        Me.BO_Buscar_Cod.UseVisualStyleBackColor = True
        '
        'tx_cod_modif
        '
        Me.tx_cod_modif.Location = New System.Drawing.Point(100, 33)
        Me.tx_cod_modif.Name = "tx_cod_modif"
        Me.tx_cod_modif.Size = New System.Drawing.Size(124, 20)
        Me.tx_cod_modif.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(605, 492)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Btn_Nuevo)
        Me.TabPage1.Controls.Add(Me.BO_proveedor_modificar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(597, 466)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Proveedor: Buscar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Image = CType(resources.GetObject("Btn_Nuevo.Image"), System.Drawing.Image)
        Me.Btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Nuevo.Location = New System.Drawing.Point(443, 374)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(69, 53)
        Me.Btn_Nuevo.TabIndex = 4
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Btn_Nuevo, "Nuevo")
        Me.Btn_Nuevo.UseVisualStyleBackColor = True
        '
        'BO_proveedor_modificar
        '
        Me.BO_proveedor_modificar.Image = CType(resources.GetObject("BO_proveedor_modificar.Image"), System.Drawing.Image)
        Me.BO_proveedor_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_proveedor_modificar.Location = New System.Drawing.Point(524, 374)
        Me.BO_proveedor_modificar.Name = "BO_proveedor_modificar"
        Me.BO_proveedor_modificar.Size = New System.Drawing.Size(64, 53)
        Me.BO_proveedor_modificar.TabIndex = 1
        Me.BO_proveedor_modificar.Text = "Modificar"
        Me.BO_proveedor_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BO_proveedor_modificar, "Ir a Ver Datos")
        Me.BO_proveedor_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.BO_buscar_nom)
        Me.GroupBox1.Controls.Add(Me.tx_nombre_modif)
        Me.GroupBox1.Controls.Add(Me.lb_ape_modif)
        Me.GroupBox1.Controls.Add(Me.BO_Buscar_Cod)
        Me.GroupBox1.Controls.Add(Me.tx_cod_modif)
        Me.GroupBox1.Controls.Add(Me.lb_dni_modif)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 362)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Proveedor"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGrid_proveedor)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(22, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(547, 269)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proveedor"
        '
        'DataGrid_proveedor
        '
        Me.DataGrid_proveedor.AllowUserToAddRows = False
        Me.DataGrid_proveedor.AllowUserToDeleteRows = False
        Me.DataGrid_proveedor.BackgroundColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_proveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Cód_Interno, Me.Nombre, Me.Responsable, Me.Dirección, Me.Teléfono, Me.Celular, Me.Mail, Me.Observaciones})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_proveedor.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid_proveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid_proveedor.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid_proveedor.Name = "DataGrid_proveedor"
        Me.DataGrid_proveedor.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_proveedor.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_proveedor.Size = New System.Drawing.Size(541, 250)
        Me.DataGrid_proveedor.TabIndex = 7
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Cód_Interno
        '
        Me.Cód_Interno.HeaderText = "Cód. Interno"
        Me.Cód_Interno.Name = "Cód_Interno"
        Me.Cód_Interno.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 120
        '
        'Responsable
        '
        Me.Responsable.HeaderText = "Responsable"
        Me.Responsable.Name = "Responsable"
        Me.Responsable.ReadOnly = True
        Me.Responsable.Width = 120
        '
        'Dirección
        '
        Me.Dirección.HeaderText = "Dirección"
        Me.Dirección.Name = "Dirección"
        Me.Dirección.ReadOnly = True
        Me.Dirección.Width = 140
        '
        'Teléfono
        '
        Me.Teléfono.HeaderText = "Teléfono"
        Me.Teléfono.Name = "Teléfono"
        Me.Teléfono.ReadOnly = True
        Me.Teléfono.Visible = False
        '
        'Celular
        '
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        Me.Celular.Visible = False
        '
        'Mail
        '
        Me.Mail.HeaderText = "Mail"
        Me.Mail.Name = "Mail"
        Me.Mail.ReadOnly = True
        Me.Mail.Visible = False
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Visible = False
        '
        'lb_dni_modif
        '
        Me.lb_dni_modif.AutoSize = True
        Me.lb_dni_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni_modif.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_dni_modif.Location = New System.Drawing.Point(22, 36)
        Me.lb_dni_modif.Name = "lb_dni_modif"
        Me.lb_dni_modif.Size = New System.Drawing.Size(73, 15)
        Me.lb_dni_modif.TabIndex = 0
        Me.lb_dni_modif.Text = "Cód. Interno"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GP_proveedor)
        Me.TabPage2.Controls.Add(Me.Bo_guardar)
        Me.TabPage2.Controls.Add(Me.Bo_cancelar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(597, 466)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Datos del Proveedor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GP_proveedor
        '
        Me.GP_proveedor.Controls.Add(Me.ERROR_tx_nombre)
        Me.GP_proveedor.Controls.Add(Me.ERROR_tx_codinterno)
        Me.GP_proveedor.Controls.Add(Me.tx_obs)
        Me.GP_proveedor.Controls.Add(Me.tx_mail)
        Me.GP_proveedor.Controls.Add(Me.tx_celular)
        Me.GP_proveedor.Controls.Add(Me.tx_telefono)
        Me.GP_proveedor.Controls.Add(Me.tx_direccion)
        Me.GP_proveedor.Controls.Add(Me.Label8)
        Me.GP_proveedor.Controls.Add(Me.Label7)
        Me.GP_proveedor.Controls.Add(Me.Label6)
        Me.GP_proveedor.Controls.Add(Me.Label5)
        Me.GP_proveedor.Controls.Add(Me.Label4)
        Me.GP_proveedor.Controls.Add(Me.tx_responsable)
        Me.GP_proveedor.Controls.Add(Me.Label3)
        Me.GP_proveedor.Controls.Add(Me.tx_nombre)
        Me.GP_proveedor.Controls.Add(Me.Label1)
        Me.GP_proveedor.Controls.Add(Me.tx_codinterno)
        Me.GP_proveedor.Controls.Add(Me.Label2)
        Me.GP_proveedor.Enabled = False
        Me.GP_proveedor.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_proveedor.Location = New System.Drawing.Point(50, 26)
        Me.GP_proveedor.Name = "GP_proveedor"
        Me.GP_proveedor.Size = New System.Drawing.Size(447, 324)
        Me.GP_proveedor.TabIndex = 1
        Me.GP_proveedor.TabStop = False
        Me.GP_proveedor.Text = "Datos del proveedor"
        '
        'ERROR_tx_nombre
        '
        Me.ERROR_tx_nombre.Image = CType(resources.GetObject("ERROR_tx_nombre.Image"), System.Drawing.Image)
        Me.ERROR_tx_nombre.Location = New System.Drawing.Point(400, 60)
        Me.ERROR_tx_nombre.Name = "ERROR_tx_nombre"
        Me.ERROR_tx_nombre.Size = New System.Drawing.Size(20, 20)
        Me.ERROR_tx_nombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_nombre.TabIndex = 288
        Me.ERROR_tx_nombre.TabStop = False
        Me.ERROR_tx_nombre.Visible = False
        '
        'ERROR_tx_codinterno
        '
        Me.ERROR_tx_codinterno.Image = CType(resources.GetObject("ERROR_tx_codinterno.Image"), System.Drawing.Image)
        Me.ERROR_tx_codinterno.Location = New System.Drawing.Point(400, 27)
        Me.ERROR_tx_codinterno.Name = "ERROR_tx_codinterno"
        Me.ERROR_tx_codinterno.Size = New System.Drawing.Size(20, 20)
        Me.ERROR_tx_codinterno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_codinterno.TabIndex = 287
        Me.ERROR_tx_codinterno.TabStop = False
        Me.ERROR_tx_codinterno.Visible = False
        '
        'tx_obs
        '
        Me.tx_obs.Location = New System.Drawing.Point(146, 280)
        Me.tx_obs.Name = "tx_obs"
        Me.tx_obs.Size = New System.Drawing.Size(248, 20)
        Me.tx_obs.TabIndex = 7
        Me.tx_obs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_mail
        '
        Me.tx_mail.Location = New System.Drawing.Point(146, 243)
        Me.tx_mail.Name = "tx_mail"
        Me.tx_mail.Size = New System.Drawing.Size(248, 20)
        Me.tx_mail.TabIndex = 6
        Me.tx_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_celular
        '
        Me.tx_celular.Location = New System.Drawing.Point(146, 209)
        Me.tx_celular.Name = "tx_celular"
        Me.tx_celular.Size = New System.Drawing.Size(248, 20)
        Me.tx_celular.TabIndex = 5
        Me.tx_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_telefono
        '
        Me.tx_telefono.Location = New System.Drawing.Point(146, 168)
        Me.tx_telefono.Name = "tx_telefono"
        Me.tx_telefono.Size = New System.Drawing.Size(248, 20)
        Me.tx_telefono.TabIndex = 4
        Me.tx_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_direccion
        '
        Me.tx_direccion.Location = New System.Drawing.Point(146, 134)
        Me.tx_direccion.Name = "tx_direccion"
        Me.tx_direccion.Size = New System.Drawing.Size(248, 20)
        Me.tx_direccion.TabIndex = 3
        Me.tx_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(42, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 281
        Me.Label8.Text = "Observaciones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(42, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 280
        Me.Label7.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(42, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Celular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(42, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 278
        Me.Label5.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(42, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 277
        Me.Label4.Text = "Direccion"
        '
        'tx_responsable
        '
        Me.tx_responsable.Location = New System.Drawing.Point(146, 99)
        Me.tx_responsable.Name = "tx_responsable"
        Me.tx_responsable.Size = New System.Drawing.Size(248, 20)
        Me.tx_responsable.TabIndex = 2
        Me.tx_responsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(42, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 275
        Me.Label3.Text = "Resposable"
        '
        'tx_nombre
        '
        Me.tx_nombre.Location = New System.Drawing.Point(146, 60)
        Me.tx_nombre.Name = "tx_nombre"
        Me.tx_nombre.Size = New System.Drawing.Size(248, 20)
        Me.tx_nombre.TabIndex = 1
        Me.tx_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(42, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 273
        Me.Label1.Text = "Nombre"
        '
        'tx_codinterno
        '
        Me.tx_codinterno.Location = New System.Drawing.Point(146, 27)
        Me.tx_codinterno.Name = "tx_codinterno"
        Me.tx_codinterno.Size = New System.Drawing.Size(248, 20)
        Me.tx_codinterno.TabIndex = 0
        Me.tx_codinterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(42, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Código interno"
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Enabled = False
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(457, 356)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(40, 40)
        Me.Bo_guardar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Bo_guardar, "Guardar")
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Enabled = False
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(411, 356)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.Bo_cancelar.TabIndex = 4
        Me.Bo_cancelar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Bo_cancelar, "Cancelar")
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'Proveedor_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(627, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Proveedor_modificar"
        Me.Text = "Gestión de proveedores"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GP_proveedor.ResumeLayout(False)
        Me.GP_proveedor.PerformLayout()
        CType(Me.ERROR_tx_nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_codinterno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BO_buscar_nom As System.Windows.Forms.Button
    Friend WithEvents tx_nombre_modif As System.Windows.Forms.TextBox
    Friend WithEvents lb_ape_modif As System.Windows.Forms.Label
    Friend WithEvents BO_Buscar_Cod As System.Windows.Forms.Button
    Friend WithEvents tx_cod_modif As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_proveedor_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_dni_modif As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents GP_proveedor As System.Windows.Forms.GroupBox
    Friend WithEvents ERROR_tx_nombre As System.Windows.Forms.PictureBox
    Friend WithEvents ERROR_tx_codinterno As System.Windows.Forms.PictureBox
    Friend WithEvents tx_obs As System.Windows.Forms.TextBox
    Friend WithEvents tx_mail As System.Windows.Forms.TextBox
    Friend WithEvents tx_celular As System.Windows.Forms.TextBox
    Friend WithEvents tx_telefono As System.Windows.Forms.TextBox
    Friend WithEvents tx_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tx_responsable As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tx_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tx_codinterno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cód_Interno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Responsable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dirección As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Teléfono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Nuevo As System.Windows.Forms.Button
End Class
