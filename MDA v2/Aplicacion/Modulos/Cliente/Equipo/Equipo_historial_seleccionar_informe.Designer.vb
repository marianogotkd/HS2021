<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipo_historial_seleccionar_informe
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
        Me.RB_informe_simple = New System.Windows.Forms.RadioButton()
        Me.RB_informe_detallado = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_solo_seleccion = New System.Windows.Forms.RadioButton()
        Me.RB_todo = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_informe_detallado)
        Me.GroupBox1.Controls.Add(Me.RB_informe_simple)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione tipo de informe"
        '
        'RB_informe_simple
        '
        Me.RB_informe_simple.AutoSize = True
        Me.RB_informe_simple.Checked = True
        Me.RB_informe_simple.Cursor = System.Windows.Forms.Cursors.Default
        Me.RB_informe_simple.Location = New System.Drawing.Point(28, 27)
        Me.RB_informe_simple.Name = "RB_informe_simple"
        Me.RB_informe_simple.Size = New System.Drawing.Size(94, 17)
        Me.RB_informe_simple.TabIndex = 0
        Me.RB_informe_simple.TabStop = True
        Me.RB_informe_simple.Text = "Informe Simple"
        Me.RB_informe_simple.UseVisualStyleBackColor = True
        '
        'RB_informe_detallado
        '
        Me.RB_informe_detallado.AutoSize = True
        Me.RB_informe_detallado.Location = New System.Drawing.Point(28, 50)
        Me.RB_informe_detallado.Name = "RB_informe_detallado"
        Me.RB_informe_detallado.Size = New System.Drawing.Size(109, 17)
        Me.RB_informe_detallado.TabIndex = 1
        Me.RB_informe_detallado.Text = "Informe detallado."
        Me.RB_informe_detallado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_todo)
        Me.GroupBox2.Controls.Add(Me.RB_solo_seleccion)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 75)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'RB_solo_seleccion
        '
        Me.RB_solo_seleccion.AutoSize = True
        Me.RB_solo_seleccion.Checked = True
        Me.RB_solo_seleccion.Location = New System.Drawing.Point(28, 19)
        Me.RB_solo_seleccion.Name = "RB_solo_seleccion"
        Me.RB_solo_seleccion.Size = New System.Drawing.Size(144, 17)
        Me.RB_solo_seleccion.TabIndex = 0
        Me.RB_solo_seleccion.TabStop = True
        Me.RB_solo_seleccion.Text = "Solo items seleccionados"
        Me.RB_solo_seleccion.UseVisualStyleBackColor = True
        '
        'RB_todo
        '
        Me.RB_todo.AutoSize = True
        Me.RB_todo.Location = New System.Drawing.Point(28, 42)
        Me.RB_todo.Name = "RB_todo"
        Me.RB_todo.Size = New System.Drawing.Size(104, 17)
        Me.RB_todo.TabIndex = 1
        Me.RB_todo.Text = "Toda la consulta"
        Me.RB_todo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(50, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Equipo_historial_seleccionar_informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(228, 244)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Equipo_historial_seleccionar_informe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial, informe."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_informe_detallado As System.Windows.Forms.RadioButton
    Friend WithEvents RB_informe_simple As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_todo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_solo_seleccion As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
