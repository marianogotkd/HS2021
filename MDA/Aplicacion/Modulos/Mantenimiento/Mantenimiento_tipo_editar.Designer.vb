<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento_tipo_editar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mantenimiento_tipo_editar))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_dias = New System.Windows.Forms.NumericUpDown()
        Me.label_dias = New System.Windows.Forms.Label()
        Me.label_desc = New System.Windows.Forms.Label()
        Me.txt_periodicidad_desc = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_dias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.txt_dias)
        Me.GroupBox2.Controls.Add(Me.label_dias)
        Me.GroupBox2.Controls.Add(Me.label_desc)
        Me.GroupBox2.Controls.Add(Me.txt_periodicidad_desc)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 95)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modifique la siguiente información:"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(226, 61)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 27)
        Me.Button5.TabIndex = 277
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_dias
        '
        Me.txt_dias.BackColor = System.Drawing.SystemColors.Info
        Me.txt_dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_dias.Location = New System.Drawing.Point(56, 62)
        Me.txt_dias.Name = "txt_dias"
        Me.txt_dias.ReadOnly = True
        Me.txt_dias.Size = New System.Drawing.Size(56, 26)
        Me.txt_dias.TabIndex = 1
        Me.txt_dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_dias
        '
        Me.label_dias.AutoSize = True
        Me.label_dias.Location = New System.Drawing.Point(17, 69)
        Me.label_dias.Name = "label_dias"
        Me.label_dias.Size = New System.Drawing.Size(33, 13)
        Me.label_dias.TabIndex = 19
        Me.label_dias.Text = "Días:"
        '
        'label_desc
        '
        Me.label_desc.AutoSize = True
        Me.label_desc.Location = New System.Drawing.Point(17, 28)
        Me.label_desc.Name = "label_desc"
        Me.label_desc.Size = New System.Drawing.Size(66, 13)
        Me.label_desc.TabIndex = 18
        Me.label_desc.Text = "Descripción:"
        '
        'txt_periodicidad_desc
        '
        Me.txt_periodicidad_desc.Location = New System.Drawing.Point(89, 25)
        Me.txt_periodicidad_desc.Name = "txt_periodicidad_desc"
        Me.txt_periodicidad_desc.Size = New System.Drawing.Size(180, 20)
        Me.txt_periodicidad_desc.TabIndex = 0
        '
        'Mantenimiento_tipo_editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(312, 115)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mantenimiento_tipo_editar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar periodicidad."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_dias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_dias As System.Windows.Forms.NumericUpDown
    Friend WithEvents label_dias As System.Windows.Forms.Label
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents txt_periodicidad_desc As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
