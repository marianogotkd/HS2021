<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnoFijo_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurnoFijo_alta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BO_TurnoReservado = New System.Windows.Forms.Button()
        Me.IM_ERROR_moroso = New System.Windows.Forms.PictureBox()
        Me.GP_Horario = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NU_hora = New System.Windows.Forms.NumericUpDown()
        Me.NU_minuto = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DG_TurnoDisponible = New System.Windows.Forms.DataGridView()
        Me.TURNOdesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhastaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOduracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoDisponibleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turno_ds = New Aplicacion.Turno_ds()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DG_Turno = New System.Windows.Forms.DataGridView()
        Me.TURNOidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOcantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLI_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_OK_deuda = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GP_cancha = New System.Windows.Forms.GroupBox()
        Me.COM_CANCHA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.COM_CANCHA_T = New System.Windows.Forms.ComboBox()
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.GP_duracion = New System.Windows.Forms.GroupBox()
        Me.NU_DUR_hora = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NU_DUR_minuto = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GP_fecha = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.COM_dia = New System.Windows.Forms.ComboBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.BO_Cliente = New System.Windows.Forms.Button()
        Me.LB_cancha = New System.Windows.Forms.Label()
        Me.GP_cliente = New System.Windows.Forms.GroupBox()
        Me.LB_ERROR_cliente = New System.Windows.Forms.Label()
        Me.IM_ERROR_cliente = New System.Windows.Forms.PictureBox()
        Me.GP_Producto = New System.Windows.Forms.GroupBox()
        Me.DG_Cliente = New System.Windows.Forms.DataGridView()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.BO_doc = New System.Windows.Forms.Button()
        Me.TX_doc = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.BO_ape = New System.Windows.Forms.Button()
        Me.TX_ape = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.LB_turno = New System.Windows.Forms.Label()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.IM_ERROR_moroso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Horario.SuspendLayout()
        CType(Me.NU_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_minuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DG_TurnoDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoDisponibleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IM_OK_deuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GP_cancha.SuspendLayout()
        Me.GP_duracion.SuspendLayout()
        CType(Me.NU_DUR_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_DUR_minuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_fecha.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GP_cliente.SuspendLayout()
        CType(Me.IM_ERROR_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Producto.SuspendLayout()
        CType(Me.DG_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 526)
        Me.TabControl2.TabIndex = 2
        Me.TabControl2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 500)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Turno: Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BO_TurnoReservado)
        Me.GroupBox3.Controls.Add(Me.IM_ERROR_moroso)
        Me.GroupBox3.Controls.Add(Me.GP_Horario)
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.IM_OK_deuda)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(3, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(848, 383)
        Me.GroupBox3.TabIndex = 231
        Me.GroupBox3.TabStop = False
        '
        'BO_TurnoReservado
        '
        Me.BO_TurnoReservado.Enabled = False
        Me.BO_TurnoReservado.Image = CType(resources.GetObject("BO_TurnoReservado.Image"), System.Drawing.Image)
        Me.BO_TurnoReservado.Location = New System.Drawing.Point(789, 332)
        Me.BO_TurnoReservado.Name = "BO_TurnoReservado"
        Me.BO_TurnoReservado.Size = New System.Drawing.Size(40, 40)
        Me.BO_TurnoReservado.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BO_TurnoReservado, "Turno Reservado")
        Me.BO_TurnoReservado.UseVisualStyleBackColor = True
        '
        'IM_ERROR_moroso
        '
        Me.IM_ERROR_moroso.Image = CType(resources.GetObject("IM_ERROR_moroso.Image"), System.Drawing.Image)
        Me.IM_ERROR_moroso.Location = New System.Drawing.Point(531, 342)
        Me.IM_ERROR_moroso.Name = "IM_ERROR_moroso"
        Me.IM_ERROR_moroso.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR_moroso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR_moroso.TabIndex = 248
        Me.IM_ERROR_moroso.TabStop = False
        Me.IM_ERROR_moroso.Visible = False
        '
        'GP_Horario
        '
        Me.GP_Horario.Controls.Add(Me.Label7)
        Me.GP_Horario.Controls.Add(Me.Label8)
        Me.GP_Horario.Controls.Add(Me.NU_hora)
        Me.GP_Horario.Controls.Add(Me.NU_minuto)
        Me.GP_Horario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Horario.Location = New System.Drawing.Point(557, 327)
        Me.GP_Horario.Name = "GP_Horario"
        Me.GP_Horario.Size = New System.Drawing.Size(226, 48)
        Me.GP_Horario.TabIndex = 250
        Me.GP_Horario.TabStop = False
        Me.GP_Horario.Text = "Hora de Inicio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(120, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 252
        Me.Label7.Text = "(Min)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(14, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 251
        Me.Label8.Text = "(Hora)"
        '
        'NU_hora
        '
        Me.NU_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_hora.Location = New System.Drawing.Point(62, 18)
        Me.NU_hora.Name = "NU_hora"
        Me.NU_hora.Size = New System.Drawing.Size(52, 22)
        Me.NU_hora.TabIndex = 249
        '
        'NU_minuto
        '
        Me.NU_minuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_minuto.Location = New System.Drawing.Point(162, 18)
        Me.NU_minuto.Name = "NU_minuto"
        Me.NU_minuto.Size = New System.Drawing.Size(52, 22)
        Me.NU_minuto.TabIndex = 250
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DG_TurnoDisponible)
        Me.GroupBox8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox8.Location = New System.Drawing.Point(517, 10)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(315, 314)
        Me.GroupBox8.TabIndex = 249
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Turno Disponible"
        '
        'DG_TurnoDisponible
        '
        Me.DG_TurnoDisponible.AllowUserToAddRows = False
        Me.DG_TurnoDisponible.AllowUserToDeleteRows = False
        Me.DG_TurnoDisponible.AutoGenerateColumns = False
        Me.DG_TurnoDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TurnoDisponible.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOdesdeDataGridViewTextBoxColumn, Me.TURNOhastaDataGridViewTextBoxColumn, Me.TURNOduracionDataGridViewTextBoxColumn})
        Me.DG_TurnoDisponible.DataSource = Me.TurnoDisponibleBindingSource
        Me.DG_TurnoDisponible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_TurnoDisponible.Location = New System.Drawing.Point(3, 16)
        Me.DG_TurnoDisponible.Name = "DG_TurnoDisponible"
        Me.DG_TurnoDisponible.ReadOnly = True
        Me.DG_TurnoDisponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_TurnoDisponible.Size = New System.Drawing.Size(309, 295)
        Me.DG_TurnoDisponible.TabIndex = 0
        '
        'TURNOdesdeDataGridViewTextBoxColumn
        '
        Me.TURNOdesdeDataGridViewTextBoxColumn.DataPropertyName = "TURNO_desde"
        Me.TURNOdesdeDataGridViewTextBoxColumn.HeaderText = "Hs. Desde"
        Me.TURNOdesdeDataGridViewTextBoxColumn.Name = "TURNOdesdeDataGridViewTextBoxColumn"
        Me.TURNOdesdeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOdesdeDataGridViewTextBoxColumn.Width = 80
        '
        'TURNOhastaDataGridViewTextBoxColumn
        '
        Me.TURNOhastaDataGridViewTextBoxColumn.DataPropertyName = "TURNO_hasta"
        Me.TURNOhastaDataGridViewTextBoxColumn.HeaderText = "Hs. Hasta"
        Me.TURNOhastaDataGridViewTextBoxColumn.Name = "TURNOhastaDataGridViewTextBoxColumn"
        Me.TURNOhastaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOhastaDataGridViewTextBoxColumn.Width = 80
        '
        'TURNOduracionDataGridViewTextBoxColumn
        '
        Me.TURNOduracionDataGridViewTextBoxColumn.DataPropertyName = "TURNO_duracion"
        Me.TURNOduracionDataGridViewTextBoxColumn.HeaderText = "Tiempo"
        Me.TURNOduracionDataGridViewTextBoxColumn.Name = "TURNOduracionDataGridViewTextBoxColumn"
        Me.TURNOduracionDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOduracionDataGridViewTextBoxColumn.Width = 80
        '
        'TurnoDisponibleBindingSource
        '
        Me.TurnoDisponibleBindingSource.DataMember = "TurnoDisponible"
        Me.TurnoDisponibleBindingSource.DataSource = Me.Turno_ds
        '
        'Turno_ds
        '
        Me.Turno_ds.DataSetName = "Turno_ds"
        Me.Turno_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DG_Turno)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox6.Location = New System.Drawing.Point(15, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(499, 367)
        Me.GroupBox6.TabIndex = 248
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Turno Reservado"
        '
        'DG_Turno
        '
        Me.DG_Turno.AllowUserToAddRows = False
        Me.DG_Turno.AllowUserToDeleteRows = False
        Me.DG_Turno.AutoGenerateColumns = False
        Me.DG_Turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Turno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn, Me.CANCHAidDataGridViewTextBoxColumn, Me.TURNOfechaDataGridViewTextBoxColumn, Me.TURNOhoraDataGridViewTextBoxColumn, Me.TURNOfinDataGridViewTextBoxColumn, Me.TURNOcantDataGridViewTextBoxColumn, Me.CLI_nom, Me.TURNOTDataGridViewTextBoxColumn})
        Me.DG_Turno.DataSource = Me.TurnoBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Turno.DefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Turno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Turno.Enabled = False
        Me.DG_Turno.Location = New System.Drawing.Point(3, 16)
        Me.DG_Turno.Name = "DG_Turno"
        Me.DG_Turno.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Turno.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Turno.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Turno.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Turno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Turno.Size = New System.Drawing.Size(493, 348)
        Me.DG_Turno.TabIndex = 0
        '
        'TURNOidDataGridViewTextBoxColumn
        '
        Me.TURNOidDataGridViewTextBoxColumn.DataPropertyName = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn.HeaderText = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn.Name = "TURNOidDataGridViewTextBoxColumn"
        Me.TURNOidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOidDataGridViewTextBoxColumn.Visible = False
        '
        'CANCHAidDataGridViewTextBoxColumn
        '
        Me.CANCHAidDataGridViewTextBoxColumn.DataPropertyName = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn.HeaderText = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn.Name = "CANCHAidDataGridViewTextBoxColumn"
        Me.CANCHAidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CANCHAidDataGridViewTextBoxColumn.Visible = False
        '
        'TURNOfechaDataGridViewTextBoxColumn
        '
        Me.TURNOfechaDataGridViewTextBoxColumn.DataPropertyName = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn.HeaderText = "Dia"
        Me.TURNOfechaDataGridViewTextBoxColumn.Name = "TURNOfechaDataGridViewTextBoxColumn"
        Me.TURNOfechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOfechaDataGridViewTextBoxColumn.Width = 80
        '
        'TURNOhoraDataGridViewTextBoxColumn
        '
        Me.TURNOhoraDataGridViewTextBoxColumn.DataPropertyName = "TURNO_hora"
        Me.TURNOhoraDataGridViewTextBoxColumn.HeaderText = "Inicio"
        Me.TURNOhoraDataGridViewTextBoxColumn.Name = "TURNOhoraDataGridViewTextBoxColumn"
        Me.TURNOhoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOhoraDataGridViewTextBoxColumn.Width = 60
        '
        'TURNOfinDataGridViewTextBoxColumn
        '
        Me.TURNOfinDataGridViewTextBoxColumn.DataPropertyName = "TURNO_fin"
        Me.TURNOfinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.TURNOfinDataGridViewTextBoxColumn.Name = "TURNOfinDataGridViewTextBoxColumn"
        Me.TURNOfinDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOfinDataGridViewTextBoxColumn.Width = 60
        '
        'TURNOcantDataGridViewTextBoxColumn
        '
        Me.TURNOcantDataGridViewTextBoxColumn.DataPropertyName = "TURNO_cant"
        Me.TURNOcantDataGridViewTextBoxColumn.HeaderText = "Tiempo"
        Me.TURNOcantDataGridViewTextBoxColumn.Name = "TURNOcantDataGridViewTextBoxColumn"
        Me.TURNOcantDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOcantDataGridViewTextBoxColumn.Width = 60
        '
        'CLI_nom
        '
        Me.CLI_nom.DataPropertyName = "CLI_nom"
        Me.CLI_nom.HeaderText = "Cliente"
        Me.CLI_nom.Name = "CLI_nom"
        Me.CLI_nom.ReadOnly = True
        Me.CLI_nom.Width = 160
        '
        'TURNOTDataGridViewTextBoxColumn
        '
        Me.TURNOTDataGridViewTextBoxColumn.DataPropertyName = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TURNOTDataGridViewTextBoxColumn.Name = "TURNOTDataGridViewTextBoxColumn"
        Me.TURNOTDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOTDataGridViewTextBoxColumn.Width = 70
        '
        'TurnoBindingSource
        '
        Me.TurnoBindingSource.DataMember = "Turno"
        Me.TurnoBindingSource.DataSource = Me.Turno_ds
        '
        'IM_OK_deuda
        '
        Me.IM_OK_deuda.Image = CType(resources.GetObject("IM_OK_deuda.Image"), System.Drawing.Image)
        Me.IM_OK_deuda.Location = New System.Drawing.Point(531, 342)
        Me.IM_OK_deuda.Name = "IM_OK_deuda"
        Me.IM_OK_deuda.Size = New System.Drawing.Size(20, 20)
        Me.IM_OK_deuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_OK_deuda.TabIndex = 250
        Me.IM_OK_deuda.TabStop = False
        Me.IM_OK_deuda.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GP_cancha)
        Me.GroupBox4.Controls.Add(Me.BO_buscar)
        Me.GroupBox4.Controls.Add(Me.GP_duracion)
        Me.GroupBox4.Controls.Add(Me.GP_fecha)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(845, 102)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar Turno"
        '
        'GP_cancha
        '
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA)
        Me.GP_cancha.Controls.Add(Me.Label10)
        Me.GP_cancha.Controls.Add(Me.Label5)
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA_T)
        Me.GP_cancha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_cancha.Location = New System.Drawing.Point(410, 22)
        Me.GP_cancha.Name = "GP_cancha"
        Me.GP_cancha.Size = New System.Drawing.Size(385, 61)
        Me.GP_cancha.TabIndex = 248
        Me.GP_cancha.TabStop = False
        Me.GP_cancha.Text = "Cancha"
        '
        'COM_CANCHA
        '
        Me.COM_CANCHA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_CANCHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_CANCHA.FormattingEnabled = True
        Me.COM_CANCHA.Location = New System.Drawing.Point(266, 24)
        Me.COM_CANCHA.Name = "COM_CANCHA"
        Me.COM_CANCHA.Size = New System.Drawing.Size(111, 23)
        Me.COM_CANCHA.TabIndex = 246
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(212, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 245
        Me.Label10.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(10, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 244
        Me.Label5.Text = "Tipo"
        '
        'COM_CANCHA_T
        '
        Me.COM_CANCHA_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_CANCHA_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_CANCHA_T.FormattingEnabled = True
        Me.COM_CANCHA_T.Location = New System.Drawing.Point(47, 24)
        Me.COM_CANCHA_T.Name = "COM_CANCHA_T"
        Me.COM_CANCHA_T.Size = New System.Drawing.Size(155, 23)
        Me.COM_CANCHA_T.TabIndex = 7
        '
        'BO_buscar
        '
        Me.BO_buscar.Image = CType(resources.GetObject("BO_buscar.Image"), System.Drawing.Image)
        Me.BO_buscar.Location = New System.Drawing.Point(801, 42)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(30, 30)
        Me.BO_buscar.TabIndex = 16
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'GP_duracion
        '
        Me.GP_duracion.Controls.Add(Me.NU_DUR_hora)
        Me.GP_duracion.Controls.Add(Me.Label1)
        Me.GP_duracion.Controls.Add(Me.NU_DUR_minuto)
        Me.GP_duracion.Controls.Add(Me.Label6)
        Me.GP_duracion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_duracion.Location = New System.Drawing.Point(209, 22)
        Me.GP_duracion.Name = "GP_duracion"
        Me.GP_duracion.Size = New System.Drawing.Size(195, 61)
        Me.GP_duracion.TabIndex = 246
        Me.GP_duracion.TabStop = False
        Me.GP_duracion.Text = "Duración"
        '
        'NU_DUR_hora
        '
        Me.NU_DUR_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_DUR_hora.Location = New System.Drawing.Point(55, 25)
        Me.NU_DUR_hora.Name = "NU_DUR_hora"
        Me.NU_DUR_hora.Size = New System.Drawing.Size(40, 22)
        Me.NU_DUR_hora.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 247
        Me.Label1.Text = "(Hora)"
        '
        'NU_DUR_minuto
        '
        Me.NU_DUR_minuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_DUR_minuto.Location = New System.Drawing.Point(143, 25)
        Me.NU_DUR_minuto.Name = "NU_DUR_minuto"
        Me.NU_DUR_minuto.Size = New System.Drawing.Size(40, 22)
        Me.NU_DUR_minuto.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(104, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 243
        Me.Label6.Text = "(Min)"
        '
        'GP_fecha
        '
        Me.GP_fecha.Controls.Add(Me.Label2)
        Me.GP_fecha.Controls.Add(Me.COM_dia)
        Me.GP_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_fecha.Location = New System.Drawing.Point(8, 22)
        Me.GP_fecha.Name = "GP_fecha"
        Me.GP_fecha.Size = New System.Drawing.Size(195, 61)
        Me.GP_fecha.TabIndex = 245
        Me.GP_fecha.TabStop = False
        Me.GP_fecha.Text = "Día"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(9, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 250
        Me.Label2.Text = "Día"
        '
        'COM_dia
        '
        Me.COM_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_dia.FormattingEnabled = True
        Me.COM_dia.Location = New System.Drawing.Point(41, 24)
        Me.COM_dia.Name = "COM_dia"
        Me.COM_dia.Size = New System.Drawing.Size(144, 23)
        Me.COM_dia.TabIndex = 249
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.BO_Cliente)
        Me.TabPage9.Controls.Add(Me.LB_cancha)
        Me.TabPage9.Controls.Add(Me.GP_cliente)
        Me.TabPage9.Controls.Add(Me.LB_turno)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(858, 500)
        Me.TabPage9.TabIndex = 5
        Me.TabPage9.Text = "Cliente: Buscar"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'BO_Cliente
        '
        Me.BO_Cliente.Image = CType(resources.GetObject("BO_Cliente.Image"), System.Drawing.Image)
        Me.BO_Cliente.Location = New System.Drawing.Point(772, 317)
        Me.BO_Cliente.Name = "BO_Cliente"
        Me.BO_Cliente.Size = New System.Drawing.Size(40, 40)
        Me.BO_Cliente.TabIndex = 231
        Me.ToolTip1.SetToolTip(Me.BO_Cliente, "Agregar Cliente")
        Me.BO_Cliente.UseVisualStyleBackColor = True
        '
        'LB_cancha
        '
        Me.LB_cancha.AutoSize = True
        Me.LB_cancha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_cancha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_cancha.Location = New System.Drawing.Point(98, 432)
        Me.LB_cancha.Name = "LB_cancha"
        Me.LB_cancha.Size = New System.Drawing.Size(54, 16)
        Me.LB_cancha.TabIndex = 252
        Me.LB_cancha.Text = "Cancha"
        '
        'GP_cliente
        '
        Me.GP_cliente.Controls.Add(Me.LB_ERROR_cliente)
        Me.GP_cliente.Controls.Add(Me.IM_ERROR_cliente)
        Me.GP_cliente.Controls.Add(Me.GP_Producto)
        Me.GP_cliente.Controls.Add(Me.BO_doc)
        Me.GP_cliente.Controls.Add(Me.TX_doc)
        Me.GP_cliente.Controls.Add(Me.Label35)
        Me.GP_cliente.Controls.Add(Me.BO_ape)
        Me.GP_cliente.Controls.Add(Me.TX_ape)
        Me.GP_cliente.Controls.Add(Me.Label38)
        Me.GP_cliente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_cliente.Location = New System.Drawing.Point(80, 17)
        Me.GP_cliente.Name = "GP_cliente"
        Me.GP_cliente.Size = New System.Drawing.Size(672, 370)
        Me.GP_cliente.TabIndex = 230
        Me.GP_cliente.TabStop = False
        Me.GP_cliente.Text = "Buscar Cliente"
        '
        'LB_ERROR_cliente
        '
        Me.LB_ERROR_cliente.AutoSize = True
        Me.LB_ERROR_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR_cliente.ForeColor = System.Drawing.Color.Red
        Me.LB_ERROR_cliente.Location = New System.Drawing.Point(598, 29)
        Me.LB_ERROR_cliente.Name = "LB_ERROR_cliente"
        Me.LB_ERROR_cliente.Size = New System.Drawing.Size(59, 15)
        Me.LB_ERROR_cliente.TabIndex = 234
        Me.LB_ERROR_cliente.Text = "No Existe"
        Me.LB_ERROR_cliente.Visible = False
        '
        'IM_ERROR_cliente
        '
        Me.IM_ERROR_cliente.Image = CType(resources.GetObject("IM_ERROR_cliente.Image"), System.Drawing.Image)
        Me.IM_ERROR_cliente.Location = New System.Drawing.Point(577, 27)
        Me.IM_ERROR_cliente.Name = "IM_ERROR_cliente"
        Me.IM_ERROR_cliente.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR_cliente.TabIndex = 233
        Me.IM_ERROR_cliente.TabStop = False
        Me.IM_ERROR_cliente.Visible = False
        '
        'GP_Producto
        '
        Me.GP_Producto.Controls.Add(Me.DG_Cliente)
        Me.GP_Producto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Producto.Location = New System.Drawing.Point(21, 58)
        Me.GP_Producto.Name = "GP_Producto"
        Me.GP_Producto.Size = New System.Drawing.Size(622, 285)
        Me.GP_Producto.TabIndex = 103
        Me.GP_Producto.TabStop = False
        Me.GP_Producto.Text = "Cliente"
        '
        'DG_Cliente
        '
        Me.DG_Cliente.AllowUserToAddRows = False
        Me.DG_Cliente.AllowUserToDeleteRows = False
        Me.DG_Cliente.AutoGenerateColumns = False
        Me.DG_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIidDataGridViewTextBoxColumn, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.CLIfnacDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn})
        Me.DG_Cliente.DataSource = Me.ClienteBindingSource
        Me.DG_Cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Cliente.Location = New System.Drawing.Point(3, 16)
        Me.DG_Cliente.Name = "DG_Cliente"
        Me.DG_Cliente.ReadOnly = True
        Me.DG_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Cliente.Size = New System.Drawing.Size(616, 266)
        Me.DG_Cliente.TabIndex = 0
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'CLIapeDataGridViewTextBoxColumn
        '
        Me.CLIapeDataGridViewTextBoxColumn.DataPropertyName = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.CLIapeDataGridViewTextBoxColumn.Name = "CLIapeDataGridViewTextBoxColumn"
        Me.CLIapeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIapeDataGridViewTextBoxColumn.Width = 110
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Width = 110
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "Documento"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIdniDataGridViewTextBoxColumn.Width = 90
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
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLItelDataGridViewTextBoxColumn.Width = 120
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLImailDataGridViewTextBoxColumn.Width = 120
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
        'BO_doc
        '
        Me.BO_doc.Image = CType(resources.GetObject("BO_doc.Image"), System.Drawing.Image)
        Me.BO_doc.Location = New System.Drawing.Point(527, 21)
        Me.BO_doc.Name = "BO_doc"
        Me.BO_doc.Size = New System.Drawing.Size(30, 30)
        Me.BO_doc.TabIndex = 99
        Me.BO_doc.UseVisualStyleBackColor = True
        '
        'TX_doc
        '
        Me.TX_doc.Location = New System.Drawing.Point(393, 27)
        Me.TX_doc.Name = "TX_doc"
        Me.TX_doc.Size = New System.Drawing.Size(128, 20)
        Me.TX_doc.TabIndex = 97
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label35.Location = New System.Drawing.Point(316, 28)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 15)
        Me.Label35.TabIndex = 98
        Me.Label35.Text = "Documento"
        '
        'BO_ape
        '
        Me.BO_ape.Image = CType(resources.GetObject("BO_ape.Image"), System.Drawing.Image)
        Me.BO_ape.Location = New System.Drawing.Point(264, 21)
        Me.BO_ape.Name = "BO_ape"
        Me.BO_ape.Size = New System.Drawing.Size(30, 30)
        Me.BO_ape.TabIndex = 96
        Me.BO_ape.UseVisualStyleBackColor = True
        '
        'TX_ape
        '
        Me.TX_ape.Location = New System.Drawing.Point(170, 27)
        Me.TX_ape.Name = "TX_ape"
        Me.TX_ape.Size = New System.Drawing.Size(88, 20)
        Me.TX_ape.TabIndex = 94
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label38.Location = New System.Drawing.Point(111, 29)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(51, 15)
        Me.Label38.TabIndex = 95
        Me.Label38.Text = "Apellido"
        '
        'LB_turno
        '
        Me.LB_turno.AutoSize = True
        Me.LB_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_turno.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_turno.Location = New System.Drawing.Point(98, 406)
        Me.LB_turno.Name = "LB_turno"
        Me.LB_turno.Size = New System.Drawing.Size(43, 16)
        Me.LB_turno.TabIndex = 251
        Me.LB_turno.Text = "Turno"
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(788, 544)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Eliminar.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Cancelar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'BO_guardar
        '
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(834, 544)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_guardar.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Guardar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'TurnoFijo_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 591)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "TurnoFijo_alta"
        Me.Text = "TurnoFijo_alta"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.IM_ERROR_moroso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Horario.ResumeLayout(False)
        Me.GP_Horario.PerformLayout()
        CType(Me.NU_hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_minuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DG_TurnoDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoDisponibleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IM_OK_deuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GP_cancha.ResumeLayout(False)
        Me.GP_cancha.PerformLayout()
        Me.GP_duracion.ResumeLayout(False)
        Me.GP_duracion.PerformLayout()
        CType(Me.NU_DUR_hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_DUR_minuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_fecha.ResumeLayout(False)
        Me.GP_fecha.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.GP_cliente.ResumeLayout(False)
        Me.GP_cliente.PerformLayout()
        CType(Me.IM_ERROR_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Producto.ResumeLayout(False)
        CType(Me.DG_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LB_cancha As System.Windows.Forms.Label
    Friend WithEvents LB_turno As System.Windows.Forms.Label
    Friend WithEvents IM_OK_deuda As System.Windows.Forms.PictureBox
    Friend WithEvents IM_ERROR_moroso As System.Windows.Forms.PictureBox
    Friend WithEvents GP_Horario As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NU_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents NU_minuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_TurnoDisponible As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Turno As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_cancha As System.Windows.Forms.GroupBox
    Friend WithEvents COM_CANCHA As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COM_CANCHA_T As System.Windows.Forms.ComboBox
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents GP_duracion As System.Windows.Forms.GroupBox
    Friend WithEvents NU_DUR_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NU_DUR_minuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GP_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents GP_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents LB_ERROR_cliente As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR_cliente As System.Windows.Forms.PictureBox
    Friend WithEvents GP_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Cliente As System.Windows.Forms.DataGridView
    Friend WithEvents BO_doc As System.Windows.Forms.Button
    Friend WithEvents TX_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents BO_ape As System.Windows.Forms.Button
    Friend WithEvents TX_ape As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents COM_dia As System.Windows.Forms.ComboBox
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents TurnoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Turno_ds As Aplicacion.Turno_ds
    Friend WithEvents TurnoDisponibleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TURNOdesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOduracionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BO_Cliente As System.Windows.Forms.Button
    Friend WithEvents BO_TurnoReservado As System.Windows.Forms.Button
    Friend WithEvents TURNOidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOcantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLI_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
