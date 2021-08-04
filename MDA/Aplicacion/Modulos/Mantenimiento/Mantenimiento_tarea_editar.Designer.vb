<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento_tarea_editar
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label_desc = New System.Windows.Forms.Label()
        Me.txt_tarea = New System.Windows.Forms.TextBox()
        Me.bo_guardar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.label_desc)
        Me.GroupBox2.Controls.Add(Me.txt_tarea)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 70)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modifique la siguiente información:"
        '
        'label_desc
        '
        Me.label_desc.AutoSize = True
        Me.label_desc.Location = New System.Drawing.Point(17, 28)
        Me.label_desc.Name = "label_desc"
        Me.label_desc.Size = New System.Drawing.Size(46, 13)
        Me.label_desc.TabIndex = 18
        Me.label_desc.Text = "TAREA:"
        '
        'txt_tarea
        '
        Me.txt_tarea.Location = New System.Drawing.Point(69, 25)
        Me.txt_tarea.Name = "txt_tarea"
        Me.txt_tarea.Size = New System.Drawing.Size(200, 20)
        Me.txt_tarea.TabIndex = 0
        '
        'bo_guardar
        '
        Me.bo_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bo_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.bo_guardar.Location = New System.Drawing.Point(184, 89)
        Me.bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.bo_guardar.Name = "bo_guardar"
        Me.bo_guardar.Size = New System.Drawing.Size(97, 38)
        Me.bo_guardar.TabIndex = 272
        Me.bo_guardar.Text = "Guardar"
        Me.bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bo_guardar.UseVisualStyleBackColor = True
        '
        'Mantenimiento_tarea_editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(310, 133)
        Me.Controls.Add(Me.bo_guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mantenimiento_tarea_editar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar tarea seleccionada"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents txt_tarea As System.Windows.Forms.TextBox
    Friend WithEvents bo_guardar As System.Windows.Forms.Button
End Class
