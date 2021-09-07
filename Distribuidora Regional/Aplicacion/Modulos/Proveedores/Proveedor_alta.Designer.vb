<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor_alta))
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_codinterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ERROR_tx_nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_codinterno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ERROR_tx_nombre
        '
        Me.ERROR_tx_nombre.Image = CType(resources.GetObject("ERROR_tx_nombre.Image"), System.Drawing.Image)
        Me.ERROR_tx_nombre.Location = New System.Drawing.Point(392, 59)
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
        Me.ERROR_tx_codinterno.Location = New System.Drawing.Point(392, 26)
        Me.ERROR_tx_codinterno.Name = "ERROR_tx_codinterno"
        Me.ERROR_tx_codinterno.Size = New System.Drawing.Size(20, 20)
        Me.ERROR_tx_codinterno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_codinterno.TabIndex = 287
        Me.ERROR_tx_codinterno.TabStop = False
        Me.ERROR_tx_codinterno.Visible = False
        '
        'tx_obs
        '
        Me.tx_obs.Location = New System.Drawing.Point(138, 279)
        Me.tx_obs.Name = "tx_obs"
        Me.tx_obs.Size = New System.Drawing.Size(248, 20)
        Me.tx_obs.TabIndex = 7
        '
        'tx_mail
        '
        Me.tx_mail.Location = New System.Drawing.Point(138, 242)
        Me.tx_mail.Name = "tx_mail"
        Me.tx_mail.Size = New System.Drawing.Size(248, 20)
        Me.tx_mail.TabIndex = 6
        '
        'tx_celular
        '
        Me.tx_celular.Location = New System.Drawing.Point(138, 208)
        Me.tx_celular.Name = "tx_celular"
        Me.tx_celular.Size = New System.Drawing.Size(248, 20)
        Me.tx_celular.TabIndex = 5
        '
        'tx_telefono
        '
        Me.tx_telefono.Location = New System.Drawing.Point(138, 167)
        Me.tx_telefono.Name = "tx_telefono"
        Me.tx_telefono.Size = New System.Drawing.Size(248, 20)
        Me.tx_telefono.TabIndex = 4
        '
        'tx_direccion
        '
        Me.tx_direccion.Location = New System.Drawing.Point(138, 133)
        Me.tx_direccion.Name = "tx_direccion"
        Me.tx_direccion.Size = New System.Drawing.Size(248, 20)
        Me.tx_direccion.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(41, 279)
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
        Me.Label7.Location = New System.Drawing.Point(41, 243)
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
        Me.Label6.Location = New System.Drawing.Point(41, 206)
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
        Me.Label5.Location = New System.Drawing.Point(41, 170)
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
        Me.Label4.Location = New System.Drawing.Point(41, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 277
        Me.Label4.Text = "Direccion"
        '
        'tx_responsable
        '
        Me.tx_responsable.Location = New System.Drawing.Point(138, 98)
        Me.tx_responsable.Name = "tx_responsable"
        Me.tx_responsable.Size = New System.Drawing.Size(248, 20)
        Me.tx_responsable.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(41, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 275
        Me.Label3.Text = "Resposable"
        '
        'tx_nombre
        '
        Me.tx_nombre.Location = New System.Drawing.Point(138, 59)
        Me.tx_nombre.Name = "tx_nombre"
        Me.tx_nombre.Size = New System.Drawing.Size(248, 20)
        Me.tx_nombre.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(866, 375)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(858, 349)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Proveedor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_nombre)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_codinterno)
        Me.GroupBox1.Controls.Add(Me.tx_obs)
        Me.GroupBox1.Controls.Add(Me.tx_mail)
        Me.GroupBox1.Controls.Add(Me.tx_celular)
        Me.GroupBox1.Controls.Add(Me.tx_telefono)
        Me.GroupBox1.Controls.Add(Me.tx_direccion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tx_responsable)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tx_nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tx_codinterno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(205, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 317)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedor datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(41, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 273
        Me.Label1.Text = "Nombre"
        '
        'tx_codinterno
        '
        Me.tx_codinterno.Location = New System.Drawing.Point(138, 26)
        Me.tx_codinterno.Name = "tx_codinterno"
        Me.tx_codinterno.Size = New System.Drawing.Size(248, 20)
        Me.tx_codinterno.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(41, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Código interno"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(788, 389)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 40)
        Me.Button3.TabIndex = 0
        Me.Button3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Button3, "Cancelar")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(834, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button2, "Guardar")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Proveedor_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Proveedor_alta"
        Me.Text = "Proveedor_alta"
        CType(Me.ERROR_tx_nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_codinterno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tx_codinterno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
