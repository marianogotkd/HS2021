<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipo_reportes_selec
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_detalles_no = New System.Windows.Forms.RadioButton()
        Me.rb_detalles_si = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_sector = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rb_solo_sector = New System.Windows.Forms.RadioButton()
        Me.rb_todos_suc = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_sucursal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cliente_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_cliente_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 418)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button4.Location = New System.Drawing.Point(197, 368)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 43)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Generar Reporte"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_detalles_no)
        Me.GroupBox4.Controls.Add(Me.rb_detalles_si)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 276)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(499, 89)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "3. Indique si desea incluir la información detallada de cada equipo."
        '
        'rb_detalles_no
        '
        Me.rb_detalles_no.AutoSize = True
        Me.rb_detalles_no.Checked = True
        Me.rb_detalles_no.Location = New System.Drawing.Point(22, 37)
        Me.rb_detalles_no.Name = "rb_detalles_no"
        Me.rb_detalles_no.Size = New System.Drawing.Size(42, 17)
        Me.rb_detalles_no.TabIndex = 0
        Me.rb_detalles_no.TabStop = True
        Me.rb_detalles_no.Text = "No."
        Me.rb_detalles_no.UseVisualStyleBackColor = True
        '
        'rb_detalles_si
        '
        Me.rb_detalles_si.AutoSize = True
        Me.rb_detalles_si.Location = New System.Drawing.Point(22, 60)
        Me.rb_detalles_si.Name = "rb_detalles_si"
        Me.rb_detalles_si.Size = New System.Drawing.Size(37, 17)
        Me.rb_detalles_si.TabIndex = 1
        Me.rb_detalles_si.Text = "Si."
        Me.rb_detalles_si.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_sector)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.rb_solo_sector)
        Me.GroupBox3.Controls.Add(Me.rb_todos_suc)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(499, 127)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "2. Seleccione tipo de reporte."
        '
        'cb_sector
        '
        Me.cb_sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sector.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_sector.FormattingEnabled = True
        Me.cb_sector.Items.AddRange(New Object() {"Fraccionable", "No Fraccionable"})
        Me.cb_sector.Location = New System.Drawing.Point(162, 92)
        Me.cb_sector.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_sector.Name = "cb_sector"
        Me.cb_sector.Size = New System.Drawing.Size(263, 21)
        Me.cb_sector.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sectores disponibles:"
        '
        'rb_solo_sector
        '
        Me.rb_solo_sector.AutoSize = True
        Me.rb_solo_sector.Location = New System.Drawing.Point(22, 63)
        Me.rb_solo_sector.Name = "rb_solo_sector"
        Me.rb_solo_sector.Size = New System.Drawing.Size(221, 17)
        Me.rb_solo_sector.TabIndex = 1
        Me.rb_solo_sector.Text = "Reporte con equipos del Sector indicado."
        Me.rb_solo_sector.UseVisualStyleBackColor = True
        '
        'rb_todos_suc
        '
        Me.rb_todos_suc.AutoSize = True
        Me.rb_todos_suc.Checked = True
        Me.rb_todos_suc.Location = New System.Drawing.Point(22, 29)
        Me.rb_todos_suc.Name = "rb_todos_suc"
        Me.rb_todos_suc.Size = New System.Drawing.Size(240, 17)
        Me.rb_todos_suc.TabIndex = 0
        Me.rb_todos_suc.TabStop = True
        Me.rb_todos_suc.Text = "Reporte con todos los equipos de la sucursal."
        Me.rb_todos_suc.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_sucursal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 59)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "1. Seleccione una sucursal."
        '
        'cb_sucursal
        '
        Me.cb_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sucursal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_sucursal.FormattingEnabled = True
        Me.cb_sucursal.Items.AddRange(New Object() {"Fraccionable", "No Fraccionable"})
        Me.cb_sucursal.Location = New System.Drawing.Point(143, 24)
        Me.cb_sucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_sucursal.Name = "cb_sucursal"
        Me.cb_sucursal.Size = New System.Drawing.Size(337, 21)
        Me.cb_sucursal.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sucursales disponibles:"
        '
        'txt_cliente_id
        '
        Me.txt_cliente_id.BackColor = System.Drawing.Color.White
        Me.txt_cliente_id.Location = New System.Drawing.Point(75, 13)
        Me.txt_cliente_id.Name = "txt_cliente_id"
        Me.txt_cliente_id.ReadOnly = True
        Me.txt_cliente_id.Size = New System.Drawing.Size(111, 20)
        Me.txt_cliente_id.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.Color.White
        Me.txt_cliente.Location = New System.Drawing.Point(75, 40)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(441, 20)
        Me.txt_cliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLIENTE:"
        '
        'Equipo_reportes_selec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(542, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Equipo_reportes_selec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de Reporte de Equipos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cliente_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_detalles_no As System.Windows.Forms.RadioButton
    Friend WithEvents rb_detalles_si As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_sector As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rb_solo_sector As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todos_suc As System.Windows.Forms.RadioButton
    Friend WithEvents cb_sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
