<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_cierre_caja
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_cierre_caja))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_ingresos_tarjeta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_montoinicial = New System.Windows.Forms.TextBox()
        Me.LB_fecha = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_usuario = New System.Windows.Forms.Label()
        Me.TextBox_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label_sucursal = New System.Windows.Forms.Label()
        Me.TextBox_egresos_subtotal = New System.Windows.Forms.TextBox()
        Me.DG_caja = New System.Windows.Forms.DataGridView()
        Me.CAJAdetalleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleegreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CierrecajadetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caja_ds = New Aplicacion.Caja_ds()
        Me.TextBox_ingresos_efectivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CierrecajadetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_ingresos_tarjeta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_montoinicial)
        Me.GroupBox1.Controls.Add(Me.LB_fecha)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label_usuario)
        Me.GroupBox1.Controls.Add(Me.TextBox_TOTAL)
        Me.GroupBox1.Controls.Add(Me.Label_sucursal)
        Me.GroupBox1.Controls.Add(Me.TextBox_egresos_subtotal)
        Me.GroupBox1.Controls.Add(Me.DG_caja)
        Me.GroupBox1.Controls.Add(Me.TextBox_ingresos_efectivo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1126, 515)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextBox_ingresos_tarjeta
        '
        Me.TextBox_ingresos_tarjeta.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_ingresos_tarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ingresos_tarjeta.Location = New System.Drawing.Point(175, 462)
        Me.TextBox_ingresos_tarjeta.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ingresos_tarjeta.Name = "TextBox_ingresos_tarjeta"
        Me.TextBox_ingresos_tarjeta.ReadOnly = True
        Me.TextBox_ingresos_tarjeta.Size = New System.Drawing.Size(175, 23)
        Me.TextBox_ingresos_tarjeta.TabIndex = 251
        Me.TextBox_ingresos_tarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(5, 468)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 17)
        Me.Label9.TabIndex = 250
        Me.Label9.Text = "TOTAL TARJETAS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(8, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Apertura:"
        '
        'TextBox_montoinicial
        '
        Me.TextBox_montoinicial.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_montoinicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_montoinicial.Location = New System.Drawing.Point(175, 403)
        Me.TextBox_montoinicial.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_montoinicial.Name = "TextBox_montoinicial"
        Me.TextBox_montoinicial.ReadOnly = True
        Me.TextBox_montoinicial.Size = New System.Drawing.Size(175, 23)
        Me.TextBox_montoinicial.TabIndex = 249
        Me.TextBox_montoinicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LB_fecha
        '
        Me.LB_fecha.AutoSize = True
        Me.LB_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LB_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_fecha.Location = New System.Drawing.Point(176, 61)
        Me.LB_fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_fecha.Name = "LB_fecha"
        Me.LB_fecha.Size = New System.Drawing.Size(99, 20)
        Me.LB_fecha.TabIndex = 1
        Me.LB_fecha.Text = "00/00/2014"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(5, 409)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 17)
        Me.Label11.TabIndex = 248
        Me.Label11.Text = "MONTO INICIAL:"
        '
        'Label_usuario
        '
        Me.Label_usuario.AutoSize = True
        Me.Label_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_usuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_usuario.Location = New System.Drawing.Point(508, 61)
        Me.Label_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_usuario.Name = "Label_usuario"
        Me.Label_usuario.Size = New System.Drawing.Size(76, 20)
        Me.Label_usuario.TabIndex = 246
        Me.Label_usuario.Text = "Usuario:"
        '
        'TextBox_TOTAL
        '
        Me.TextBox_TOTAL.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TOTAL.Location = New System.Drawing.Point(832, 432)
        Me.TextBox_TOTAL.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_TOTAL.Name = "TextBox_TOTAL"
        Me.TextBox_TOTAL.ReadOnly = True
        Me.TextBox_TOTAL.Size = New System.Drawing.Size(239, 31)
        Me.TextBox_TOTAL.TabIndex = 245
        Me.TextBox_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_sucursal
        '
        Me.Label_sucursal.AutoSize = True
        Me.Label_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_sucursal.ForeColor = System.Drawing.Color.Blue
        Me.Label_sucursal.Location = New System.Drawing.Point(8, 19)
        Me.Label_sucursal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_sucursal.Name = "Label_sucursal"
        Me.Label_sucursal.Size = New System.Drawing.Size(84, 20)
        Me.Label_sucursal.TabIndex = 247
        Me.Label_sucursal.Text = "Sucursal:"
        '
        'TextBox_egresos_subtotal
        '
        Me.TextBox_egresos_subtotal.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_egresos_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_egresos_subtotal.Location = New System.Drawing.Point(541, 403)
        Me.TextBox_egresos_subtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_egresos_subtotal.Name = "TextBox_egresos_subtotal"
        Me.TextBox_egresos_subtotal.ReadOnly = True
        Me.TextBox_egresos_subtotal.Size = New System.Drawing.Size(175, 23)
        Me.TextBox_egresos_subtotal.TabIndex = 244
        Me.TextBox_egresos_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DG_caja
        '
        Me.DG_caja.AllowUserToAddRows = False
        Me.DG_caja.AllowUserToDeleteRows = False
        Me.DG_caja.AllowUserToResizeRows = False
        Me.DG_caja.AutoGenerateColumns = False
        Me.DG_caja.BackgroundColor = System.Drawing.Color.White
        Me.DG_caja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_caja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CAJAdetalleidDataGridViewTextBoxColumn, Me.CAJAIDDataGridViewTextBoxColumn, Me.CAJAdetalledescripcionDataGridViewTextBoxColumn, Me.CAJAdetalleingreso, Me.CAJAdetalleegreso, Me.CajaTipoMovintDataGridViewTextBoxColumn, Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn})
        Me.DG_caja.DataSource = Me.CierrecajadetalleBindingSource
        Me.DG_caja.Location = New System.Drawing.Point(11, 107)
        Me.DG_caja.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_caja.MultiSelect = False
        Me.DG_caja.Name = "DG_caja"
        Me.DG_caja.ReadOnly = True
        Me.DG_caja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_caja.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_caja.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_caja.Size = New System.Drawing.Size(1108, 271)
        Me.DG_caja.StandardTab = True
        Me.DG_caja.TabIndex = 240
        '
        'CAJAdetalleidDataGridViewTextBoxColumn
        '
        Me.CAJAdetalleidDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_id"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.HeaderText = "CAJAdetalle_id"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.Name = "CAJAdetalleidDataGridViewTextBoxColumn"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAdetalleidDataGridViewTextBoxColumn.Visible = False
        Me.CAJAdetalleidDataGridViewTextBoxColumn.Width = 89
        '
        'CAJAIDDataGridViewTextBoxColumn
        '
        Me.CAJAIDDataGridViewTextBoxColumn.DataPropertyName = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.HeaderText = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.Name = "CAJAIDDataGridViewTextBoxColumn"
        Me.CAJAIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAIDDataGridViewTextBoxColumn.Visible = False
        Me.CAJAIDDataGridViewTextBoxColumn.Width = 125
        '
        'CAJAdetalledescripcionDataGridViewTextBoxColumn
        '
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_descripcion"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.Name = "CAJAdetalledescripcionDataGridViewTextBoxColumn"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.Width = 500
        '
        'CAJAdetalleingreso
        '
        Me.CAJAdetalleingreso.DataPropertyName = "CAJAdetalle_ingreso"
        Me.CAJAdetalleingreso.HeaderText = "Importe de Ingreso"
        Me.CAJAdetalleingreso.Name = "CAJAdetalleingreso"
        Me.CAJAdetalleingreso.ReadOnly = True
        Me.CAJAdetalleingreso.Width = 200
        '
        'CAJAdetalleegreso
        '
        Me.CAJAdetalleegreso.DataPropertyName = "CAJAdetalle_egreso"
        Me.CAJAdetalleegreso.HeaderText = "Importe de Egreso"
        Me.CAJAdetalleegreso.Name = "CAJAdetalleegreso"
        Me.CAJAdetalleegreso.ReadOnly = True
        Me.CAJAdetalleegreso.Width = 200
        '
        'CajaTipoMovintDataGridViewTextBoxColumn
        '
        Me.CajaTipoMovintDataGridViewTextBoxColumn.DataPropertyName = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.HeaderText = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Name = "CajaTipoMovintDataGridViewTextBoxColumn"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.ReadOnly = True
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Visible = False
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Width = 90
        '
        'CajaTipoMovdescripcionDataGridViewTextBoxColumn
        '
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.DataPropertyName = "CajaTipoMov_descripcion"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.HeaderText = "Tipo Movimiento"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.Name = "CajaTipoMovdescripcionDataGridViewTextBoxColumn"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CierrecajadetalleBindingSource
        '
        Me.CierrecajadetalleBindingSource.DataMember = "Cierre_caja_detalle"
        Me.CierrecajadetalleBindingSource.DataSource = Me.Caja_ds
        '
        'Caja_ds
        '
        Me.Caja_ds.DataSetName = "Caja_ds"
        Me.Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox_ingresos_efectivo
        '
        Me.TextBox_ingresos_efectivo.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_ingresos_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ingresos_efectivo.Location = New System.Drawing.Point(541, 462)
        Me.TextBox_ingresos_efectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ingresos_efectivo.Name = "TextBox_ingresos_efectivo"
        Me.TextBox_ingresos_efectivo.ReadOnly = True
        Me.TextBox_ingresos_efectivo.Size = New System.Drawing.Size(175, 23)
        Me.TextBox_ingresos_efectivo.TabIndex = 243
        Me.TextBox_ingresos_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(373, 468)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "TOTAL EFECTIVO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(855, 397)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "TOTAL NETO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(373, 406)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "TOTAL EGRESOS:"
        '
        'BO_guardar
        '
        Me.BO_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(995, 527)
        Me.BO_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(137, 49)
        Me.BO_guardar.TabIndex = 30
        Me.BO_guardar.Text = "Confirmar"
        Me.BO_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Confirmar cierre de caja")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(808, 531)
        Me.BO_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Eliminar.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Volver")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        Me.BO_Eliminar.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1154, 629)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BO_guardar)
        Me.TabPage1.Controls.Add(Me.BO_Eliminar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1146, 600)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Caja: Registro de Cierre"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1146, 600)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Caja: resumen venta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1126, 515)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "Fecha Apertura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(175, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 248
        Me.Label4.Text = "00/00/2014"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(507, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 250
        Me.Label5.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(7, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 251
        Me.Label6.Text = "Sucursal:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 127)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1108, 271)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 252
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(7, 103)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(326, 17)
        Me.Label10.TabIndex = 253
        Me.Label10.Text = "Listado de ventas agrupadas por categoría:"
        '
        'Registro_cierre_caja
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1447, 714)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(693, 321)
        Me.Name = "Registro_cierre_caja"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de cierre de caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CierrecajadetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LB_fecha As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DG_caja As System.Windows.Forms.DataGridView
    Friend WithEvents CierrecajadetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caja_ds As Aplicacion.Caja_ds
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_sucursal As System.Windows.Forms.Label
    Friend WithEvents Label_usuario As System.Windows.Forms.Label
    Friend WithEvents TextBox_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_egresos_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ingresos_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_montoinicial As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox_ingresos_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CAJAdetalleidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalledescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleegreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovintDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
