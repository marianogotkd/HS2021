<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendario_b
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
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.CalendariobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mantenimiento_ds = New Aplicacion.mantenimiento_ds()
        Me.dia_sabado_nro = New System.Windows.Forms.Label()
        Me.dia_viernes_nro = New System.Windows.Forms.Label()
        Me.dia_jueves_numero = New System.Windows.Forms.Label()
        Me.dia_miercoles_nro = New System.Windows.Forms.Label()
        Me.dia_martes_nro = New System.Windows.Forms.Label()
        Me.dia_lunes_nro = New System.Windows.Forms.Label()
        Me.dia_domingo_nro = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMonthAndYear = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.btnNextMonth = New System.Windows.Forms.Button()
        Me.btnPrevMonth = New System.Windows.Forms.Button()
        Me.Domingo_a = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Lunes_a = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Martes_a = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Miercoles_a = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Jueves_a = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Viernes_a = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Sabado_a = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.id_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendariobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.SlateGray
        Me.Panel3.Controls.Add(Me.DG_clientes)
        Me.Panel3.Controls.Add(Me.dia_sabado_nro)
        Me.Panel3.Controls.Add(Me.dia_viernes_nro)
        Me.Panel3.Controls.Add(Me.dia_jueves_numero)
        Me.Panel3.Controls.Add(Me.dia_miercoles_nro)
        Me.Panel3.Controls.Add(Me.dia_martes_nro)
        Me.Panel3.Controls.Add(Me.dia_lunes_nro)
        Me.Panel3.Controls.Add(Me.dia_domingo_nro)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1264, 574)
        Me.Panel3.TabIndex = 8
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
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.DimGray
        Me.DG_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.ColumnHeadersVisible = False
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Domingo_a, Me.Lunes_a, Me.Martes_a, Me.Miercoles_a, Me.Jueves_a, Me.Viernes_a, Me.Sabado_a, Me.id_item})
        Me.DG_clientes.DataSource = Me.CalendariobBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(6, 72)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle32
        Me.DG_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DG_clientes.Size = New System.Drawing.Size(1254, 498)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 241
        '
        'CalendariobBindingSource
        '
        Me.CalendariobBindingSource.DataMember = "Calendario_b"
        Me.CalendariobBindingSource.DataSource = Me.Mantenimiento_ds
        '
        'Mantenimiento_ds
        '
        Me.Mantenimiento_ds.DataSetName = "mantenimiento_ds"
        Me.Mantenimiento_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dia_sabado_nro
        '
        Me.dia_sabado_nro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dia_sabado_nro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia_sabado_nro.Location = New System.Drawing.Point(1065, 38)
        Me.dia_sabado_nro.Name = "dia_sabado_nro"
        Me.dia_sabado_nro.Size = New System.Drawing.Size(176, 30)
        Me.dia_sabado_nro.TabIndex = 13
        Me.dia_sabado_nro.Text = "7"
        Me.dia_sabado_nro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dia_viernes_nro
        '
        Me.dia_viernes_nro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dia_viernes_nro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia_viernes_nro.Location = New System.Drawing.Point(889, 38)
        Me.dia_viernes_nro.Name = "dia_viernes_nro"
        Me.dia_viernes_nro.Size = New System.Drawing.Size(175, 30)
        Me.dia_viernes_nro.TabIndex = 12
        Me.dia_viernes_nro.Text = "6"
        Me.dia_viernes_nro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dia_jueves_numero
        '
        Me.dia_jueves_numero.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dia_jueves_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia_jueves_numero.Location = New System.Drawing.Point(712, 38)
        Me.dia_jueves_numero.Name = "dia_jueves_numero"
        Me.dia_jueves_numero.Size = New System.Drawing.Size(176, 30)
        Me.dia_jueves_numero.TabIndex = 11
        Me.dia_jueves_numero.Text = "5"
        Me.dia_jueves_numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dia_miercoles_nro
        '
        Me.dia_miercoles_nro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dia_miercoles_nro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia_miercoles_nro.Location = New System.Drawing.Point(536, 38)
        Me.dia_miercoles_nro.Name = "dia_miercoles_nro"
        Me.dia_miercoles_nro.Size = New System.Drawing.Size(175, 30)
        Me.dia_miercoles_nro.TabIndex = 10
        Me.dia_miercoles_nro.Text = "4"
        Me.dia_miercoles_nro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dia_martes_nro
        '
        Me.dia_martes_nro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dia_martes_nro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia_martes_nro.Location = New System.Drawing.Point(361, 38)
        Me.dia_martes_nro.Name = "dia_martes_nro"
        Me.dia_martes_nro.Size = New System.Drawing.Size(174, 30)
        Me.dia_martes_nro.TabIndex = 9
        Me.dia_martes_nro.Text = "3"
        Me.dia_martes_nro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dia_lunes_nro
        '
        Me.dia_lunes_nro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dia_lunes_nro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia_lunes_nro.Location = New System.Drawing.Point(184, 38)
        Me.dia_lunes_nro.Name = "dia_lunes_nro"
        Me.dia_lunes_nro.Size = New System.Drawing.Size(176, 30)
        Me.dia_lunes_nro.TabIndex = 8
        Me.dia_lunes_nro.Text = "2"
        Me.dia_lunes_nro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dia_domingo_nro
        '
        Me.dia_domingo_nro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dia_domingo_nro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia_domingo_nro.Location = New System.Drawing.Point(7, 38)
        Me.dia_domingo_nro.Name = "dia_domingo_nro"
        Me.dia_domingo_nro.Size = New System.Drawing.Size(176, 30)
        Me.dia_domingo_nro.TabIndex = 7
        Me.dia_domingo_nro.Text = "1"
        Me.dia_domingo_nro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1065, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 30)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sabado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(889, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Viernes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(712, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 30)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Jueves"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Miercoles"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(361, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Martes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lunes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Domingo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblMonthAndYear)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1274, 72)
        Me.Panel2.TabIndex = 9
        '
        'lblMonthAndYear
        '
        Me.lblMonthAndYear.AutoSize = True
        Me.lblMonthAndYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthAndYear.ForeColor = System.Drawing.Color.Blue
        Me.lblMonthAndYear.Location = New System.Drawing.Point(12, 18)
        Me.lblMonthAndYear.Name = "lblMonthAndYear"
        Me.lblMonthAndYear.Size = New System.Drawing.Size(269, 42)
        Me.lblMonthAndYear.TabIndex = 1
        Me.lblMonthAndYear.Text = "January, 2018"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.btnToday)
        Me.Panel4.Controls.Add(Me.btnNextMonth)
        Me.Panel4.Controls.Add(Me.btnPrevMonth)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(989, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(285, 72)
        Me.Panel4.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.CargarDato
        Me.Button3.Location = New System.Drawing.Point(185, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 43)
        Me.Button3.TabIndex = 270
        Me.Button3.Text = "Volver"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'btnToday
        '
        Me.btnToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToday.Location = New System.Drawing.Point(65, 14)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(52, 43)
        Me.btnToday.TabIndex = 2
        Me.btnToday.Text = "Hoy"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'btnNextMonth
        '
        Me.btnNextMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextMonth.Location = New System.Drawing.Point(123, 14)
        Me.btnNextMonth.Name = "btnNextMonth"
        Me.btnNextMonth.Size = New System.Drawing.Size(56, 43)
        Me.btnNextMonth.TabIndex = 1
        Me.btnNextMonth.Text = ">"
        Me.btnNextMonth.UseVisualStyleBackColor = True
        '
        'btnPrevMonth
        '
        Me.btnPrevMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevMonth.Location = New System.Drawing.Point(3, 14)
        Me.btnPrevMonth.Name = "btnPrevMonth"
        Me.btnPrevMonth.Size = New System.Drawing.Size(56, 43)
        Me.btnPrevMonth.TabIndex = 0
        Me.btnPrevMonth.Text = "<"
        Me.btnPrevMonth.UseVisualStyleBackColor = True
        '
        'Domingo_a
        '
        Me.Domingo_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Domingo_a.DataPropertyName = "domingo"
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Domingo_a.DefaultCellStyle = DataGridViewCellStyle25
        Me.Domingo_a.HeaderText = "domingo"
        Me.Domingo_a.LinkColor = System.Drawing.Color.White
        Me.Domingo_a.Name = "Domingo_a"
        Me.Domingo_a.ReadOnly = True
        Me.Domingo_a.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Domingo_a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Domingo_a.VisitedLinkColor = System.Drawing.Color.White
        Me.Domingo_a.Width = 176
        '
        'Lunes_a
        '
        Me.Lunes_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Lunes_a.DataPropertyName = "lunes"
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lunes_a.DefaultCellStyle = DataGridViewCellStyle26
        Me.Lunes_a.HeaderText = "lunes"
        Me.Lunes_a.LinkColor = System.Drawing.Color.White
        Me.Lunes_a.Name = "Lunes_a"
        Me.Lunes_a.ReadOnly = True
        Me.Lunes_a.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lunes_a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Lunes_a.VisitedLinkColor = System.Drawing.Color.White
        Me.Lunes_a.Width = 176
        '
        'Martes_a
        '
        Me.Martes_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Martes_a.DataPropertyName = "martes"
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Martes_a.DefaultCellStyle = DataGridViewCellStyle27
        Me.Martes_a.HeaderText = "martes"
        Me.Martes_a.LinkColor = System.Drawing.Color.White
        Me.Martes_a.Name = "Martes_a"
        Me.Martes_a.ReadOnly = True
        Me.Martes_a.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Martes_a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Martes_a.VisitedLinkColor = System.Drawing.Color.White
        Me.Martes_a.Width = 176
        '
        'Miercoles_a
        '
        Me.Miercoles_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Miercoles_a.DataPropertyName = "miercoles"
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Miercoles_a.DefaultCellStyle = DataGridViewCellStyle28
        Me.Miercoles_a.HeaderText = "miercoles"
        Me.Miercoles_a.LinkColor = System.Drawing.Color.White
        Me.Miercoles_a.Name = "Miercoles_a"
        Me.Miercoles_a.ReadOnly = True
        Me.Miercoles_a.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Miercoles_a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Miercoles_a.VisitedLinkColor = System.Drawing.Color.White
        Me.Miercoles_a.Width = 176
        '
        'Jueves_a
        '
        Me.Jueves_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Jueves_a.DataPropertyName = "jueves"
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jueves_a.DefaultCellStyle = DataGridViewCellStyle29
        Me.Jueves_a.HeaderText = "jueves"
        Me.Jueves_a.LinkColor = System.Drawing.Color.White
        Me.Jueves_a.Name = "Jueves_a"
        Me.Jueves_a.ReadOnly = True
        Me.Jueves_a.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Jueves_a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Jueves_a.VisitedLinkColor = System.Drawing.Color.White
        Me.Jueves_a.Width = 176
        '
        'Viernes_a
        '
        Me.Viernes_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Viernes_a.DataPropertyName = "viernes"
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Viernes_a.DefaultCellStyle = DataGridViewCellStyle30
        Me.Viernes_a.HeaderText = "viernes"
        Me.Viernes_a.LinkColor = System.Drawing.Color.White
        Me.Viernes_a.Name = "Viernes_a"
        Me.Viernes_a.ReadOnly = True
        Me.Viernes_a.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Viernes_a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Viernes_a.VisitedLinkColor = System.Drawing.Color.White
        Me.Viernes_a.Width = 176
        '
        'Sabado_a
        '
        Me.Sabado_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Sabado_a.DataPropertyName = "sabado"
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sabado_a.DefaultCellStyle = DataGridViewCellStyle31
        Me.Sabado_a.HeaderText = "sabado"
        Me.Sabado_a.LinkColor = System.Drawing.Color.White
        Me.Sabado_a.Name = "Sabado_a"
        Me.Sabado_a.ReadOnly = True
        Me.Sabado_a.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sabado_a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sabado_a.VisitedLinkColor = System.Drawing.Color.White
        Me.Sabado_a.Width = 176
        '
        'id_item
        '
        Me.id_item.DataPropertyName = "id_item"
        Me.id_item.HeaderText = "id_item"
        Me.id_item.Name = "id_item"
        Me.id_item.ReadOnly = True
        Me.id_item.Visible = False
        '
        'Calendario_b
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Calendario_b"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CALENDARIO"
        Me.Panel3.ResumeLayout(False)
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendariobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mantenimiento_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dia_sabado_nro As System.Windows.Forms.Label
    Friend WithEvents dia_viernes_nro As System.Windows.Forms.Label
    Friend WithEvents dia_jueves_numero As System.Windows.Forms.Label
    Friend WithEvents dia_miercoles_nro As System.Windows.Forms.Label
    Friend WithEvents dia_martes_nro As System.Windows.Forms.Label
    Friend WithEvents dia_lunes_nro As System.Windows.Forms.Label
    Friend WithEvents dia_domingo_nro As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblMonthAndYear As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnToday As System.Windows.Forms.Button
    Friend WithEvents btnNextMonth As System.Windows.Forms.Button
    Friend WithEvents btnPrevMonth As System.Windows.Forms.Button
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents CalendariobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mantenimiento_ds As Aplicacion.mantenimiento_ds
    Friend WithEvents Domingo_a As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Lunes_a As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Martes_a As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Miercoles_a As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Jueves_a As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Viernes_a As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Sabado_a As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents id_item As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
