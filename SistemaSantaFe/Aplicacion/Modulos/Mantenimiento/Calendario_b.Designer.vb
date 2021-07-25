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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.DOMINGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LUNES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARTES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIERCOLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JUEVES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIERNES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SABADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel3.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
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
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.DimGray
        Me.DG_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.ColumnHeadersVisible = False
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DOMINGO, Me.LUNES, Me.MARTES, Me.MIERCOLES, Me.JUEVES, Me.VIERNES, Me.SABADO})
        Me.DG_clientes.Location = New System.Drawing.Point(6, 72)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DG_clientes.Size = New System.Drawing.Size(1254, 498)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 241
        '
        'DOMINGO
        '
        Me.DOMINGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DOMINGO.HeaderText = "DOMINGO"
        Me.DOMINGO.Name = "DOMINGO"
        Me.DOMINGO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DOMINGO.Width = 176
        '
        'LUNES
        '
        Me.LUNES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LUNES.HeaderText = "LUNES"
        Me.LUNES.Name = "LUNES"
        Me.LUNES.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LUNES.Width = 176
        '
        'MARTES
        '
        Me.MARTES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MARTES.HeaderText = "MARTES"
        Me.MARTES.Name = "MARTES"
        Me.MARTES.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MARTES.Width = 176
        '
        'MIERCOLES
        '
        Me.MIERCOLES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MIERCOLES.HeaderText = "MIERCOLES"
        Me.MIERCOLES.Name = "MIERCOLES"
        Me.MIERCOLES.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MIERCOLES.Width = 176
        '
        'JUEVES
        '
        Me.JUEVES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.JUEVES.HeaderText = "JUEVES"
        Me.JUEVES.Name = "JUEVES"
        Me.JUEVES.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.JUEVES.Width = 176
        '
        'VIERNES
        '
        Me.VIERNES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.VIERNES.HeaderText = "VIERNES"
        Me.VIERNES.Name = "VIERNES"
        Me.VIERNES.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VIERNES.Width = 176
        '
        'SABADO
        '
        Me.SABADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SABADO.HeaderText = "SABADO"
        Me.SABADO.Name = "SABADO"
        Me.SABADO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SABADO.Width = 176
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
        Me.Panel2.Size = New System.Drawing.Size(1264, 72)
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
        Me.Panel4.Location = New System.Drawing.Point(979, 0)
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
        'Calendario_b
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Calendario_b"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario_b"
        Me.Panel3.ResumeLayout(False)
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DOMINGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LUNES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARTES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MIERCOLES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JUEVES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VIERNES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SABADO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
