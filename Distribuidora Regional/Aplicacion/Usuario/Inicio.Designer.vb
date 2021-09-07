<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.BO_USU_sesion = New System.Windows.Forms.Button()
        Me.BO_USU_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_USU_cont = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_USU_usu = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.LB_USU_inv = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BO_USU_sesion
        '
        Me.BO_USU_sesion.Image = CType(resources.GetObject("BO_USU_sesion.Image"), System.Drawing.Image)
        Me.BO_USU_sesion.Location = New System.Drawing.Point(380, 28)
        Me.BO_USU_sesion.Name = "BO_USU_sesion"
        Me.BO_USU_sesion.Size = New System.Drawing.Size(30, 30)
        Me.BO_USU_sesion.TabIndex = 91
        Me.BO_USU_sesion.Tag = ""
        Me.ToolTip1.SetToolTip(Me.BO_USU_sesion, "Ingresar")
        Me.BO_USU_sesion.UseVisualStyleBackColor = True
        '
        'BO_USU_cerrar
        '
        Me.BO_USU_cerrar.Image = CType(resources.GetObject("BO_USU_cerrar.Image"), System.Drawing.Image)
        Me.BO_USU_cerrar.Location = New System.Drawing.Point(380, 64)
        Me.BO_USU_cerrar.Name = "BO_USU_cerrar"
        Me.BO_USU_cerrar.Size = New System.Drawing.Size(30, 30)
        Me.BO_USU_cerrar.TabIndex = 92
        Me.ToolTip1.SetToolTip(Me.BO_USU_cerrar, "Salir")
        Me.BO_USU_cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TB_USU_cont)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TB_USU_usu)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(112, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 100)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sesión de Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(19, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Contraseña"
        '
        'TB_USU_cont
        '
        Me.TB_USU_cont.Location = New System.Drawing.Point(101, 63)
        Me.TB_USU_cont.Name = "TB_USU_cont"
        Me.TB_USU_cont.Size = New System.Drawing.Size(137, 20)
        Me.TB_USU_cont.TabIndex = 2
        Me.TB_USU_cont.Tag = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label21.Location = New System.Drawing.Point(19, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 15)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Usuario"
        '
        'TB_USU_usu
        '
        Me.TB_USU_usu.Location = New System.Drawing.Point(101, 24)
        Me.TB_USU_usu.Name = "TB_USU_usu"
        Me.TB_USU_usu.Size = New System.Drawing.Size(137, 20)
        Me.TB_USU_usu.TabIndex = 0
        Me.TB_USU_usu.Tag = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'IM_ERROR
        '
        Me.IM_ERROR.BackColor = System.Drawing.Color.Transparent
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(134, 114)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 237
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'LB_USU_inv
        '
        Me.LB_USU_inv.AutoSize = True
        Me.LB_USU_inv.BackColor = System.Drawing.Color.Transparent
        Me.LB_USU_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_USU_inv.ForeColor = System.Drawing.Color.Red
        Me.LB_USU_inv.Location = New System.Drawing.Point(153, 117)
        Me.LB_USU_inv.Name = "LB_USU_inv"
        Me.LB_USU_inv.Size = New System.Drawing.Size(171, 15)
        Me.LB_USU_inv.TabIndex = 236
        Me.LB_USU_inv.Text = "Usuario o Contraseña Invalida"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(427, 143)
        Me.Controls.Add(Me.IM_ERROR)
        Me.Controls.Add(Me.LB_USU_inv)
        Me.Controls.Add(Me.BO_USU_sesion)
        Me.Controls.Add(Me.BO_USU_cerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(435, 177)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(435, 177)
        Me.Name = "Inicio"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion - Distribuidora Regional"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BO_USU_sesion As System.Windows.Forms.Button
    Friend WithEvents BO_USU_cerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_USU_cont As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TB_USU_usu As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_USU_inv As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
