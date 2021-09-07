<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recepcion_gestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recepcion_gestion))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DateTime_fechfactura = New System.Windows.Forms.DateTimePicker()
        Me.Bo_agregarcat = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tx_nrofactura = New System.Windows.Forms.TextBox()
        Me.tx_cantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_codigo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BO_cancelar = New System.Windows.Forms.Button()
        Me.BO_registrar = New System.Windows.Forms.Button()
        Me.DateTime_fechsistema = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_proveedores = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_marca = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RB_freezer = New System.Windows.Forms.RadioButton()
        Me.RB_heladera = New System.Windows.Forms.RadioButton()
        Me.RB_ambiente = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tx_nrolote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTime_fechvto = New System.Windows.Forms.DateTimePicker()
        Me.cb_tipoproducto = New System.Windows.Forms.ComboBox()
        Me.tx_codproducto = New System.Windows.Forms.TextBox()
        Me.tx_nombreproducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(6, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(862, 544)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DateTime_fechfactura)
        Me.TabPage1.Controls.Add(Me.Bo_agregarcat)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.tx_nrofactura)
        Me.TabPage1.Controls.Add(Me.tx_cantidad)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lb_codigo)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.BO_cancelar)
        Me.TabPage1.Controls.Add(Me.BO_registrar)
        Me.TabPage1.Controls.Add(Me.DateTime_fechsistema)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cb_proveedores)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cb_marca)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.tx_nrolote)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.DateTime_fechvto)
        Me.TabPage1.Controls.Add(Me.cb_tipoproducto)
        Me.TabPage1.Controls.Add(Me.tx_codproducto)
        Me.TabPage1.Controls.Add(Me.tx_nombreproducto)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(854, 518)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Recepción de productos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DateTime_fechfactura
        '
        Me.DateTime_fechfactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_fechfactura.Location = New System.Drawing.Point(127, 360)
        Me.DateTime_fechfactura.Name = "DateTime_fechfactura"
        Me.DateTime_fechfactura.Size = New System.Drawing.Size(92, 20)
        Me.DateTime_fechfactura.TabIndex = 7
        '
        'Bo_agregarcat
        '
        Me.Bo_agregarcat.Image = CType(resources.GetObject("Bo_agregarcat.Image"), System.Drawing.Image)
        Me.Bo_agregarcat.Location = New System.Drawing.Point(712, 243)
        Me.Bo_agregarcat.Name = "Bo_agregarcat"
        Me.Bo_agregarcat.Size = New System.Drawing.Size(30, 30)
        Me.Bo_agregarcat.TabIndex = 281
        Me.ToolTip1.SetToolTip(Me.Bo_agregarcat, "Agregar proveedor")
        Me.Bo_agregarcat.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(253, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 30)
        Me.Button3.TabIndex = 259
        Me.ToolTip1.SetToolTip(Me.Button3, "Buscar cliente")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tx_nrofactura
        '
        Me.tx_nrofactura.Location = New System.Drawing.Point(128, 316)
        Me.tx_nrofactura.Name = "tx_nrofactura"
        Me.tx_nrofactura.Size = New System.Drawing.Size(155, 20)
        Me.tx_nrofactura.TabIndex = 6
        '
        'tx_cantidad
        '
        Me.tx_cantidad.Location = New System.Drawing.Point(209, 184)
        Me.tx_cantidad.Name = "tx_cantidad"
        Me.tx_cantidad.Size = New System.Drawing.Size(40, 20)
        Me.tx_cantidad.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 13)
        Me.Label7.TabIndex = 256
        Me.Label7.Text = "Cantidad de unid. del producto"
        '
        'lb_codigo
        '
        Me.lb_codigo.AutoSize = True
        Me.lb_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_codigo.Location = New System.Drawing.Point(271, 7)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(54, 22)
        Me.lb_codigo.TabIndex = 255
        Me.lb_codigo.Text = "0000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(260, 22)
        Me.Label14.TabIndex = 254
        Me.Label14.Text = "Recepción de productos Nº:"
        '
        'BO_cancelar
        '
        Me.BO_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cancelar.Location = New System.Drawing.Point(622, 459)
        Me.BO_cancelar.Name = "BO_cancelar"
        Me.BO_cancelar.Size = New System.Drawing.Size(106, 35)
        Me.BO_cancelar.TabIndex = 11
        Me.BO_cancelar.Text = "Cancelar"
        Me.BO_cancelar.UseVisualStyleBackColor = True
        '
        'BO_registrar
        '
        Me.BO_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_registrar.Location = New System.Drawing.Point(734, 459)
        Me.BO_registrar.Name = "BO_registrar"
        Me.BO_registrar.Size = New System.Drawing.Size(106, 35)
        Me.BO_registrar.TabIndex = 10
        Me.BO_registrar.Text = "Registrar"
        Me.BO_registrar.UseVisualStyleBackColor = True
        '
        'DateTime_fechsistema
        '
        Me.DateTime_fechsistema.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_fechsistema.Location = New System.Drawing.Point(741, 12)
        Me.DateTime_fechsistema.Name = "DateTime_fechsistema"
        Me.DateTime_fechsistema.Size = New System.Drawing.Size(92, 20)
        Me.DateTime_fechsistema.TabIndex = 251
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(582, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 13)
        Me.Label13.TabIndex = 250
        Me.Label13.Text = "Fecha de alta del sistema:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(663, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 13)
        Me.Label12.TabIndex = 246
        Me.Label12.Text = "Destino directamenta a stock:"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 245
        Me.Label11.Text = "Fecha de factura:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 244
        Me.Label10.Text = "Númer de factura:"
        '
        'cb_proveedores
        '
        Me.cb_proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_proveedores.FormattingEnabled = True
        Me.cb_proveedores.Location = New System.Drawing.Point(544, 249)
        Me.cb_proveedores.Name = "cb_proveedores"
        Me.cb_proveedores.Size = New System.Drawing.Size(162, 21)
        Me.cb_proveedores.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(401, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 13)
        Me.Label9.TabIndex = 242
        Me.Label9.Text = "Proveedor del producto:"
        '
        'cb_marca
        '
        Me.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Items.AddRange(New Object() {"Productos para distribución", "Productos Importados", "Otros productos"})
        Me.cb_marca.Location = New System.Drawing.Point(149, 273)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(134, 21)
        Me.cb_marca.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "Marca del producto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(401, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 13)
        Me.Label8.TabIndex = 239
        Me.Label8.Text = "Indique condiciones de almacenamiento"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(404, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 102)
        Me.GroupBox3.TabIndex = 238
        Me.GroupBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_freezer)
        Me.Panel2.Controls.Add(Me.RB_heladera)
        Me.Panel2.Controls.Add(Me.RB_ambiente)
        Me.Panel2.Location = New System.Drawing.Point(6, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(172, 74)
        Me.Panel2.TabIndex = 234
        '
        'RB_freezer
        '
        Me.RB_freezer.AutoSize = True
        Me.RB_freezer.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_freezer.Location = New System.Drawing.Point(3, 49)
        Me.RB_freezer.Name = "RB_freezer"
        Me.RB_freezer.Size = New System.Drawing.Size(60, 17)
        Me.RB_freezer.TabIndex = 2
        Me.RB_freezer.Text = "Freezer"
        Me.RB_freezer.UseVisualStyleBackColor = True
        '
        'RB_heladera
        '
        Me.RB_heladera.AutoSize = True
        Me.RB_heladera.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_heladera.Location = New System.Drawing.Point(3, 26)
        Me.RB_heladera.Name = "RB_heladera"
        Me.RB_heladera.Size = New System.Drawing.Size(68, 17)
        Me.RB_heladera.TabIndex = 1
        Me.RB_heladera.Text = "Heladera"
        Me.RB_heladera.UseVisualStyleBackColor = True
        '
        'RB_ambiente
        '
        Me.RB_ambiente.AutoSize = True
        Me.RB_ambiente.Checked = True
        Me.RB_ambiente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_ambiente.Location = New System.Drawing.Point(3, 3)
        Me.RB_ambiente.Name = "RB_ambiente"
        Me.RB_ambiente.Size = New System.Drawing.Size(69, 17)
        Me.RB_ambiente.TabIndex = 0
        Me.RB_ambiente.TabStop = True
        Me.RB_ambiente.Text = "Ambiente"
        Me.RB_ambiente.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(401, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 237
        Me.Label6.Text = "Indique tipo de producto"
        '
        'tx_nrolote
        '
        Me.tx_nrolote.Location = New System.Drawing.Point(147, 146)
        Me.tx_nrolote.Name = "tx_nrolote"
        Me.tx_nrolote.Size = New System.Drawing.Size(100, 20)
        Me.tx_nrolote.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha de Vencimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Número de lote:"
        '
        'DateTime_fechvto
        '
        Me.DateTime_fechvto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_fechvto.Location = New System.Drawing.Point(157, 227)
        Me.DateTime_fechvto.Name = "DateTime_fechvto"
        Me.DateTime_fechvto.Size = New System.Drawing.Size(92, 20)
        Me.DateTime_fechvto.TabIndex = 4
        '
        'cb_tipoproducto
        '
        Me.cb_tipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipoproducto.FormattingEnabled = True
        Me.cb_tipoproducto.Location = New System.Drawing.Point(559, 74)
        Me.cb_tipoproducto.Name = "cb_tipoproducto"
        Me.cb_tipoproducto.Size = New System.Drawing.Size(183, 21)
        Me.cb_tipoproducto.TabIndex = 8
        '
        'tx_codproducto
        '
        Me.tx_codproducto.Location = New System.Drawing.Point(147, 71)
        Me.tx_codproducto.Name = "tx_codproducto"
        Me.tx_codproducto.Size = New System.Drawing.Size(100, 20)
        Me.tx_codproducto.TabIndex = 0
        '
        'tx_nombreproducto
        '
        Me.tx_nombreproducto.Location = New System.Drawing.Point(148, 108)
        Me.tx_nombreproducto.Name = "tx_nombreproducto"
        Me.tx_nombreproducto.Size = New System.Drawing.Size(100, 20)
        Me.tx_nombreproducto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de producto"
        '
        'Recepcion_gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(873, 553)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Recepcion_gestion"
        Me.Text = "Recepcion_gestion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tx_nrolote As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTime_fechvto As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_tipoproducto As System.Windows.Forms.ComboBox
    Friend WithEvents tx_codproducto As System.Windows.Forms.TextBox
    Friend WithEvents tx_nombreproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTime_fechsistema As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cb_proveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_freezer As System.Windows.Forms.RadioButton
    Friend WithEvents RB_heladera As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ambiente As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_registrar As System.Windows.Forms.Button
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BO_cancelar As System.Windows.Forms.Button
    Friend WithEvents tx_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tx_nrofactura As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Bo_agregarcat As System.Windows.Forms.Button
    Friend WithEvents DateTime_fechfactura As System.Windows.Forms.DateTimePicker
End Class
