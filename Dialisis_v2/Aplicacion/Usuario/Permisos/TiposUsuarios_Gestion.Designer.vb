<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiposUsuarios_Gestion
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
        Me.DG_TipoUs = New System.Windows.Forms.DataGridView()
        Me.UT_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UT_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiposUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_usuario = New Aplicacion.DS_usuario()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Agregar_Prod = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_DEP_Consulta = New System.Windows.Forms.CheckBox()
        Me.CheckBox_DEP_Baja = New System.Windows.Forms.CheckBox()
        Me.CheckBox_DEP_Mov = New System.Windows.Forms.CheckBox()
        Me.CheckBox_DEP_ingreso = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_OBRA_InfPAC = New System.Windows.Forms.CheckBox()
        Me.CheckBox_OBRA_actualizar = New System.Windows.Forms.CheckBox()
        Me.CheckBox_OBRA_nuevo = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_cli = New System.Windows.Forms.GroupBox()
        Me.CheckBox_MED_cons = New System.Windows.Forms.CheckBox()
        Me.CheckBox_MED_nuevo = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_Configuraciones = New System.Windows.Forms.GroupBox()
        Me.CheckBox_ENF_ConsSes = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ENF_InfDia = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ENF_NSD = New System.Windows.Forms.CheckBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_PAC_HC = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PAC_actualizar = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PAC_nuevo = New System.Windows.Forms.CheckBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_Stock = New System.Windows.Forms.GroupBox()
        Me.CheckBox_STOCK_Consultar = New System.Windows.Forms.CheckBox()
        Me.CheckBox_STOCK_Consumir = New System.Windows.Forms.CheckBox()
        Me.CheckBox_STOCK_Cat = New System.Windows.Forms.CheckBox()
        Me.CheckBox_STOCK_marca = New System.Windows.Forms.CheckBox()
        Me.CheckBox_STOCK_Prov = New System.Windows.Forms.CheckBox()
        Me.CheckBox_STOCK_insumo = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckBox_ENF_RevMov = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ENF_stock = New System.Windows.Forms.CheckBox()
        CType(Me.DG_TipoUs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_cli.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Configuraciones.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Stock.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_TipoUs
        '
        Me.DG_TipoUs.AllowUserToAddRows = False
        Me.DG_TipoUs.AllowUserToDeleteRows = False
        Me.DG_TipoUs.AllowUserToResizeRows = False
        Me.DG_TipoUs.AutoGenerateColumns = False
        Me.DG_TipoUs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_TipoUs.BackgroundColor = System.Drawing.Color.White
        Me.DG_TipoUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TipoUs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UT_id, Me.UT_desc})
        Me.DG_TipoUs.DataSource = Me.TiposUsuarioBindingSource
        Me.DG_TipoUs.Location = New System.Drawing.Point(43, 14)
        Me.DG_TipoUs.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_TipoUs.MultiSelect = False
        Me.DG_TipoUs.Name = "DG_TipoUs"
        Me.DG_TipoUs.ReadOnly = True
        Me.DG_TipoUs.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_TipoUs.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_TipoUs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_TipoUs.Size = New System.Drawing.Size(415, 383)
        Me.DG_TipoUs.StandardTab = True
        Me.DG_TipoUs.TabIndex = 10
        '
        'UT_id
        '
        Me.UT_id.DataPropertyName = "UT_id"
        Me.UT_id.HeaderText = "UT_id"
        Me.UT_id.Name = "UT_id"
        Me.UT_id.ReadOnly = True
        Me.UT_id.Visible = False
        '
        'UT_desc
        '
        Me.UT_desc.DataPropertyName = "UT_desc"
        Me.UT_desc.HeaderText = "Tipo de Usuarios"
        Me.UT_desc.Name = "UT_desc"
        Me.UT_desc.ReadOnly = True
        '
        'TiposUsuarioBindingSource
        '
        Me.TiposUsuarioBindingSource.DataMember = "Tipos_Usuario"
        Me.TiposUsuarioBindingSource.DataSource = Me.DS_usuario
        '
        'DS_usuario
        '
        Me.DS_usuario.DataSetName = "DS_usuario"
        Me.DS_usuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.Button1.Location = New System.Drawing.Point(79, 405)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.MinimumSize = New System.Drawing.Size(124, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 43)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Eliminar Tipo de Usuario"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Agregar_Prod
        '
        Me.btn_Agregar_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar_Prod.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_Agregar_Prod.Location = New System.Drawing.Point(259, 405)
        Me.btn_Agregar_Prod.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Agregar_Prod.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_Agregar_Prod.Name = "btn_Agregar_Prod"
        Me.btn_Agregar_Prod.Size = New System.Drawing.Size(177, 43)
        Me.btn_Agregar_Prod.TabIndex = 14
        Me.btn_Agregar_Prod.Text = "Nuevo Tipo de Usuario"
        Me.btn_Agregar_Prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Prod.UseVisualStyleBackColor = True
        Me.btn_Agregar_Prod.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CheckBox_DEP_Consulta)
        Me.GroupBox6.Controls.Add(Me.CheckBox_DEP_Baja)
        Me.GroupBox6.Controls.Add(Me.CheckBox_DEP_Mov)
        Me.GroupBox6.Controls.Add(Me.CheckBox_DEP_ingreso)
        Me.GroupBox6.Controls.Add(Me.PictureBox4)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(704, 154)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(397, 125)
        Me.GroupBox6.TabIndex = 36
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Deposito"
        '
        'CheckBox_DEP_Consulta
        '
        Me.CheckBox_DEP_Consulta.AutoCheck = False
        Me.CheckBox_DEP_Consulta.AutoSize = True
        Me.CheckBox_DEP_Consulta.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_DEP_Consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_DEP_Consulta.Location = New System.Drawing.Point(102, 86)
        Me.CheckBox_DEP_Consulta.Name = "CheckBox_DEP_Consulta"
        Me.CheckBox_DEP_Consulta.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_DEP_Consulta.TabIndex = 5
        Me.CheckBox_DEP_Consulta.Text = "Consultas"
        Me.CheckBox_DEP_Consulta.UseVisualStyleBackColor = False
        '
        'CheckBox_DEP_Baja
        '
        Me.CheckBox_DEP_Baja.AutoCheck = False
        Me.CheckBox_DEP_Baja.AutoSize = True
        Me.CheckBox_DEP_Baja.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_DEP_Baja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_DEP_Baja.Location = New System.Drawing.Point(102, 65)
        Me.CheckBox_DEP_Baja.Name = "CheckBox_DEP_Baja"
        Me.CheckBox_DEP_Baja.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox_DEP_Baja.TabIndex = 4
        Me.CheckBox_DEP_Baja.Text = "Baja de Stock"
        Me.CheckBox_DEP_Baja.UseVisualStyleBackColor = False
        '
        'CheckBox_DEP_Mov
        '
        Me.CheckBox_DEP_Mov.AutoCheck = False
        Me.CheckBox_DEP_Mov.AutoSize = True
        Me.CheckBox_DEP_Mov.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_DEP_Mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_DEP_Mov.Location = New System.Drawing.Point(102, 42)
        Me.CheckBox_DEP_Mov.Name = "CheckBox_DEP_Mov"
        Me.CheckBox_DEP_Mov.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox_DEP_Mov.TabIndex = 3
        Me.CheckBox_DEP_Mov.Text = "Movimiento de Stock"
        Me.CheckBox_DEP_Mov.UseVisualStyleBackColor = False
        '
        'CheckBox_DEP_ingreso
        '
        Me.CheckBox_DEP_ingreso.AutoCheck = False
        Me.CheckBox_DEP_ingreso.AutoSize = True
        Me.CheckBox_DEP_ingreso.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_DEP_ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_DEP_ingreso.Location = New System.Drawing.Point(102, 19)
        Me.CheckBox_DEP_ingreso.Name = "CheckBox_DEP_ingreso"
        Me.CheckBox_DEP_ingreso.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox_DEP_ingreso.TabIndex = 2
        Me.CheckBox_DEP_ingreso.Text = "Ingreso de Stock"
        Me.CheckBox_DEP_ingreso.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Aplicacion.My.Resources.Resources.Deposito
        Me.PictureBox4.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox_OBRA_InfPAC)
        Me.GroupBox2.Controls.Add(Me.CheckBox_OBRA_actualizar)
        Me.GroupBox2.Controls.Add(Me.CheckBox_OBRA_nuevo)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(465, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 125)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Obra Social"
        '
        'CheckBox_OBRA_InfPAC
        '
        Me.CheckBox_OBRA_InfPAC.AutoCheck = False
        Me.CheckBox_OBRA_InfPAC.AutoSize = True
        Me.CheckBox_OBRA_InfPAC.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_OBRA_InfPAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_OBRA_InfPAC.Location = New System.Drawing.Point(102, 65)
        Me.CheckBox_OBRA_InfPAC.Name = "CheckBox_OBRA_InfPAC"
        Me.CheckBox_OBRA_InfPAC.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox_OBRA_InfPAC.TabIndex = 4
        Me.CheckBox_OBRA_InfPAC.Text = "Informe de Pacientes"
        Me.CheckBox_OBRA_InfPAC.UseVisualStyleBackColor = False
        '
        'CheckBox_OBRA_actualizar
        '
        Me.CheckBox_OBRA_actualizar.AutoCheck = False
        Me.CheckBox_OBRA_actualizar.AutoSize = True
        Me.CheckBox_OBRA_actualizar.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_OBRA_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_OBRA_actualizar.Location = New System.Drawing.Point(102, 42)
        Me.CheckBox_OBRA_actualizar.Name = "CheckBox_OBRA_actualizar"
        Me.CheckBox_OBRA_actualizar.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_OBRA_actualizar.TabIndex = 3
        Me.CheckBox_OBRA_actualizar.Text = "Actualizar"
        Me.CheckBox_OBRA_actualizar.UseVisualStyleBackColor = False
        '
        'CheckBox_OBRA_nuevo
        '
        Me.CheckBox_OBRA_nuevo.AutoCheck = False
        Me.CheckBox_OBRA_nuevo.AutoSize = True
        Me.CheckBox_OBRA_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_OBRA_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_OBRA_nuevo.Location = New System.Drawing.Point(102, 19)
        Me.CheckBox_OBRA_nuevo.Name = "CheckBox_OBRA_nuevo"
        Me.CheckBox_OBRA_nuevo.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox_OBRA_nuevo.TabIndex = 2
        Me.CheckBox_OBRA_nuevo.Text = "Nuevo"
        Me.CheckBox_OBRA_nuevo.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Aplicacion.My.Resources.Resources.signofhealth_medical_10742
        Me.PictureBox3.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'GroupBox_cli
        '
        Me.GroupBox_cli.Controls.Add(Me.CheckBox_MED_cons)
        Me.GroupBox_cli.Controls.Add(Me.CheckBox_MED_nuevo)
        Me.GroupBox_cli.Controls.Add(Me.PictureBox1)
        Me.GroupBox_cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_cli.Location = New System.Drawing.Point(926, 14)
        Me.GroupBox_cli.Name = "GroupBox_cli"
        Me.GroupBox_cli.Size = New System.Drawing.Size(175, 134)
        Me.GroupBox_cli.TabIndex = 31
        Me.GroupBox_cli.TabStop = False
        Me.GroupBox_cli.Text = "Medicos"
        '
        'CheckBox_MED_cons
        '
        Me.CheckBox_MED_cons.AutoCheck = False
        Me.CheckBox_MED_cons.AutoSize = True
        Me.CheckBox_MED_cons.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_MED_cons.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_MED_cons.Location = New System.Drawing.Point(102, 42)
        Me.CheckBox_MED_cons.Name = "CheckBox_MED_cons"
        Me.CheckBox_MED_cons.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox_MED_cons.TabIndex = 3
        Me.CheckBox_MED_cons.Text = "Consulta"
        Me.CheckBox_MED_cons.UseVisualStyleBackColor = False
        '
        'CheckBox_MED_nuevo
        '
        Me.CheckBox_MED_nuevo.AutoCheck = False
        Me.CheckBox_MED_nuevo.AutoSize = True
        Me.CheckBox_MED_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_MED_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_MED_nuevo.Location = New System.Drawing.Point(102, 19)
        Me.CheckBox_MED_nuevo.Name = "CheckBox_MED_nuevo"
        Me.CheckBox_MED_nuevo.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox_MED_nuevo.TabIndex = 2
        Me.CheckBox_MED_nuevo.Text = "Nuevo"
        Me.CheckBox_MED_nuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplicacion.My.Resources.Resources.medical_29_icon_icons_com_73943
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox_Configuraciones
        '
        Me.GroupBox_Configuraciones.Controls.Add(Me.CheckBox_ENF_RevMov)
        Me.GroupBox_Configuraciones.Controls.Add(Me.CheckBox_ENF_stock)
        Me.GroupBox_Configuraciones.Controls.Add(Me.CheckBox_ENF_ConsSes)
        Me.GroupBox_Configuraciones.Controls.Add(Me.CheckBox_ENF_InfDia)
        Me.GroupBox_Configuraciones.Controls.Add(Me.CheckBox_ENF_NSD)
        Me.GroupBox_Configuraciones.Controls.Add(Me.PictureBox6)
        Me.GroupBox_Configuraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Configuraciones.Location = New System.Drawing.Point(672, 14)
        Me.GroupBox_Configuraciones.Name = "GroupBox_Configuraciones"
        Me.GroupBox_Configuraciones.Size = New System.Drawing.Size(248, 134)
        Me.GroupBox_Configuraciones.TabIndex = 34
        Me.GroupBox_Configuraciones.TabStop = False
        Me.GroupBox_Configuraciones.Text = "Enfermeria"
        '
        'CheckBox_ENF_ConsSes
        '
        Me.CheckBox_ENF_ConsSes.AutoCheck = False
        Me.CheckBox_ENF_ConsSes.AutoSize = True
        Me.CheckBox_ENF_ConsSes.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_ENF_ConsSes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_ENF_ConsSes.Location = New System.Drawing.Point(102, 65)
        Me.CheckBox_ENF_ConsSes.Name = "CheckBox_ENF_ConsSes"
        Me.CheckBox_ENF_ConsSes.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox_ENF_ConsSes.TabIndex = 6
        Me.CheckBox_ENF_ConsSes.Text = "Consulta de Sesiones"
        Me.CheckBox_ENF_ConsSes.UseVisualStyleBackColor = False
        '
        'CheckBox_ENF_InfDia
        '
        Me.CheckBox_ENF_InfDia.AutoCheck = False
        Me.CheckBox_ENF_InfDia.AutoSize = True
        Me.CheckBox_ENF_InfDia.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_ENF_InfDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_ENF_InfDia.Location = New System.Drawing.Point(102, 42)
        Me.CheckBox_ENF_InfDia.Name = "CheckBox_ENF_InfDia"
        Me.CheckBox_ENF_InfDia.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox_ENF_InfDia.TabIndex = 5
        Me.CheckBox_ENF_InfDia.Text = "Informe de Dialisis"
        Me.CheckBox_ENF_InfDia.UseVisualStyleBackColor = False
        '
        'CheckBox_ENF_NSD
        '
        Me.CheckBox_ENF_NSD.AutoCheck = False
        Me.CheckBox_ENF_NSD.AutoSize = True
        Me.CheckBox_ENF_NSD.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_ENF_NSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_ENF_NSD.Location = New System.Drawing.Point(102, 19)
        Me.CheckBox_ENF_NSD.Name = "CheckBox_ENF_NSD"
        Me.CheckBox_ENF_NSD.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox_ENF_NSD.TabIndex = 4
        Me.CheckBox_ENF_NSD.Text = "Nueva Sesion de Dialisis"
        Me.CheckBox_ENF_NSD.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Aplicacion.My.Resources.Resources.hospital_2_icon_icons_com_66067_64x64
        Me.PictureBox6.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox_PAC_HC)
        Me.GroupBox1.Controls.Add(Me.CheckBox_PAC_actualizar)
        Me.GroupBox1.Controls.Add(Me.CheckBox_PAC_nuevo)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(465, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 134)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pacientes"
        '
        'CheckBox_PAC_HC
        '
        Me.CheckBox_PAC_HC.AutoCheck = False
        Me.CheckBox_PAC_HC.AutoSize = True
        Me.CheckBox_PAC_HC.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_PAC_HC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_PAC_HC.Location = New System.Drawing.Point(102, 65)
        Me.CheckBox_PAC_HC.Name = "CheckBox_PAC_HC"
        Me.CheckBox_PAC_HC.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox_PAC_HC.TabIndex = 6
        Me.CheckBox_PAC_HC.Text = "Historia Clinica"
        Me.CheckBox_PAC_HC.UseVisualStyleBackColor = False
        '
        'CheckBox_PAC_actualizar
        '
        Me.CheckBox_PAC_actualizar.AutoCheck = False
        Me.CheckBox_PAC_actualizar.AutoSize = True
        Me.CheckBox_PAC_actualizar.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_PAC_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_PAC_actualizar.Location = New System.Drawing.Point(102, 42)
        Me.CheckBox_PAC_actualizar.Name = "CheckBox_PAC_actualizar"
        Me.CheckBox_PAC_actualizar.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_PAC_actualizar.TabIndex = 5
        Me.CheckBox_PAC_actualizar.Text = "Actualizar"
        Me.CheckBox_PAC_actualizar.UseVisualStyleBackColor = False
        '
        'CheckBox_PAC_nuevo
        '
        Me.CheckBox_PAC_nuevo.AutoCheck = False
        Me.CheckBox_PAC_nuevo.AutoSize = True
        Me.CheckBox_PAC_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_PAC_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_PAC_nuevo.Location = New System.Drawing.Point(102, 19)
        Me.CheckBox_PAC_nuevo.Name = "CheckBox_PAC_nuevo"
        Me.CheckBox_PAC_nuevo.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox_PAC_nuevo.TabIndex = 4
        Me.CheckBox_PAC_nuevo.Text = "Nuevo"
        Me.CheckBox_PAC_nuevo.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Aplicacion.My.Resources.Resources.paciente64x64
        Me.PictureBox5.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'GroupBox_Stock
        '
        Me.GroupBox_Stock.Controls.Add(Me.CheckBox_STOCK_Consultar)
        Me.GroupBox_Stock.Controls.Add(Me.CheckBox_STOCK_Consumir)
        Me.GroupBox_Stock.Controls.Add(Me.CheckBox_STOCK_Cat)
        Me.GroupBox_Stock.Controls.Add(Me.CheckBox_STOCK_marca)
        Me.GroupBox_Stock.Controls.Add(Me.CheckBox_STOCK_Prov)
        Me.GroupBox_Stock.Controls.Add(Me.CheckBox_STOCK_insumo)
        Me.GroupBox_Stock.Controls.Add(Me.PictureBox2)
        Me.GroupBox_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Stock.Location = New System.Drawing.Point(465, 286)
        Me.GroupBox_Stock.Name = "GroupBox_Stock"
        Me.GroupBox_Stock.Size = New System.Drawing.Size(636, 121)
        Me.GroupBox_Stock.TabIndex = 32
        Me.GroupBox_Stock.TabStop = False
        Me.GroupBox_Stock.Text = "Gestion de Insumos"
        '
        'CheckBox_STOCK_Consultar
        '
        Me.CheckBox_STOCK_Consultar.AutoCheck = False
        Me.CheckBox_STOCK_Consultar.AutoSize = True
        Me.CheckBox_STOCK_Consultar.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_STOCK_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_STOCK_Consultar.Location = New System.Drawing.Point(191, 42)
        Me.CheckBox_STOCK_Consultar.Name = "CheckBox_STOCK_Consultar"
        Me.CheckBox_STOCK_Consultar.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox_STOCK_Consultar.TabIndex = 32
        Me.CheckBox_STOCK_Consultar.Text = "Consultar Consumos"
        Me.CheckBox_STOCK_Consultar.UseVisualStyleBackColor = False
        '
        'CheckBox_STOCK_Consumir
        '
        Me.CheckBox_STOCK_Consumir.AutoCheck = False
        Me.CheckBox_STOCK_Consumir.AutoSize = True
        Me.CheckBox_STOCK_Consumir.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_STOCK_Consumir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_STOCK_Consumir.Location = New System.Drawing.Point(191, 19)
        Me.CheckBox_STOCK_Consumir.Name = "CheckBox_STOCK_Consumir"
        Me.CheckBox_STOCK_Consumir.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox_STOCK_Consumir.TabIndex = 31
        Me.CheckBox_STOCK_Consumir.Text = "Consumir Insumos"
        Me.CheckBox_STOCK_Consumir.UseVisualStyleBackColor = False
        '
        'CheckBox_STOCK_Cat
        '
        Me.CheckBox_STOCK_Cat.AutoCheck = False
        Me.CheckBox_STOCK_Cat.AutoSize = True
        Me.CheckBox_STOCK_Cat.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_STOCK_Cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_STOCK_Cat.Location = New System.Drawing.Point(102, 88)
        Me.CheckBox_STOCK_Cat.Name = "CheckBox_STOCK_Cat"
        Me.CheckBox_STOCK_Cat.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox_STOCK_Cat.TabIndex = 10
        Me.CheckBox_STOCK_Cat.Text = "Categoria"
        Me.CheckBox_STOCK_Cat.UseVisualStyleBackColor = False
        '
        'CheckBox_STOCK_marca
        '
        Me.CheckBox_STOCK_marca.AutoCheck = False
        Me.CheckBox_STOCK_marca.AutoSize = True
        Me.CheckBox_STOCK_marca.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_STOCK_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_STOCK_marca.Location = New System.Drawing.Point(102, 65)
        Me.CheckBox_STOCK_marca.Name = "CheckBox_STOCK_marca"
        Me.CheckBox_STOCK_marca.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox_STOCK_marca.TabIndex = 9
        Me.CheckBox_STOCK_marca.Text = "Marca"
        Me.CheckBox_STOCK_marca.UseVisualStyleBackColor = False
        '
        'CheckBox_STOCK_Prov
        '
        Me.CheckBox_STOCK_Prov.AutoCheck = False
        Me.CheckBox_STOCK_Prov.AutoSize = True
        Me.CheckBox_STOCK_Prov.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_STOCK_Prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_STOCK_Prov.Location = New System.Drawing.Point(102, 42)
        Me.CheckBox_STOCK_Prov.Name = "CheckBox_STOCK_Prov"
        Me.CheckBox_STOCK_Prov.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox_STOCK_Prov.TabIndex = 8
        Me.CheckBox_STOCK_Prov.Text = "Proveedor"
        Me.CheckBox_STOCK_Prov.UseVisualStyleBackColor = False
        '
        'CheckBox_STOCK_insumo
        '
        Me.CheckBox_STOCK_insumo.AutoCheck = False
        Me.CheckBox_STOCK_insumo.AutoSize = True
        Me.CheckBox_STOCK_insumo.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_STOCK_insumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_STOCK_insumo.Location = New System.Drawing.Point(102, 19)
        Me.CheckBox_STOCK_insumo.Name = "CheckBox_STOCK_insumo"
        Me.CheckBox_STOCK_insumo.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox_STOCK_insumo.TabIndex = 7
        Me.CheckBox_STOCK_insumo.Text = "Insumo"
        Me.CheckBox_STOCK_insumo.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Aplicacion.My.Resources.Resources.Stock
        Me.PictureBox2.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'CheckBox_ENF_RevMov
        '
        Me.CheckBox_ENF_RevMov.AutoSize = True
        Me.CheckBox_ENF_RevMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_ENF_RevMov.Location = New System.Drawing.Point(102, 108)
        Me.CheckBox_ENF_RevMov.Name = "CheckBox_ENF_RevMov"
        Me.CheckBox_ENF_RevMov.Size = New System.Drawing.Size(144, 17)
        Me.CheckBox_ENF_RevMov.TabIndex = 10
        Me.CheckBox_ENF_RevMov.Text = "Revision de Movimientos"
        Me.CheckBox_ENF_RevMov.UseVisualStyleBackColor = True
        '
        'CheckBox_ENF_stock
        '
        Me.CheckBox_ENF_stock.AutoSize = True
        Me.CheckBox_ENF_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_ENF_stock.Location = New System.Drawing.Point(102, 86)
        Me.CheckBox_ENF_stock.Name = "CheckBox_ENF_stock"
        Me.CheckBox_ENF_stock.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox_ENF_stock.TabIndex = 9
        Me.CheckBox_ENF_stock.Text = "Consulta de Stock"
        Me.CheckBox_ENF_stock.UseVisualStyleBackColor = True
        '
        'TiposUsuarios_Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 482)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox_cli)
        Me.Controls.Add(Me.GroupBox_Configuraciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox_Stock)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Agregar_Prod)
        Me.Controls.Add(Me.DG_TipoUs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TiposUsuarios_Gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Usuarios del Sistema"
        CType(Me.DG_TipoUs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_cli.ResumeLayout(False)
        Me.GroupBox_cli.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Configuraciones.ResumeLayout(False)
        Me.GroupBox_Configuraciones.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Stock.ResumeLayout(False)
        Me.GroupBox_Stock.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_TipoUs As System.Windows.Forms.DataGridView
    Friend WithEvents TiposUsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_usuario As Aplicacion.DS_usuario
    Friend WithEvents btn_Agregar_Prod As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UT_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UT_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_DEP_Consulta As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_DEP_Baja As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_DEP_Mov As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_DEP_ingreso As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_OBRA_InfPAC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_OBRA_actualizar As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_OBRA_nuevo As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox_cli As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_MED_cons As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_MED_nuevo As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox_Configuraciones As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_ENF_InfDia As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_ENF_NSD As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_PAC_HC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_PAC_actualizar As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_PAC_nuevo As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox_Stock As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_STOCK_Consultar As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_STOCK_Consumir As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_STOCK_Cat As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_STOCK_marca As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_STOCK_Prov As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_STOCK_insumo As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox_ENF_ConsSes As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_ENF_RevMov As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_ENF_stock As System.Windows.Forms.CheckBox
End Class
