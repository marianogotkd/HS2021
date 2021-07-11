<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipos_subtipo_editar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipos_subtipo_editar))
        Me.Subtipo = New System.Windows.Forms.GroupBox()
        Me.bot_agregar_cat = New System.Windows.Forms.Button()
        Me.txt_subtipo = New System.Windows.Forms.TextBox()
        Me.Subtipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Subtipo
        '
        Me.Subtipo.BackColor = System.Drawing.Color.Transparent
        Me.Subtipo.Controls.Add(Me.bot_agregar_cat)
        Me.Subtipo.Controls.Add(Me.txt_subtipo)
        Me.Subtipo.Location = New System.Drawing.Point(12, 12)
        Me.Subtipo.Name = "Subtipo"
        Me.Subtipo.Size = New System.Drawing.Size(398, 57)
        Me.Subtipo.TabIndex = 270
        Me.Subtipo.TabStop = False
        Me.Subtipo.Text = "Subtipo"
        '
        'bot_agregar_cat
        '
        Me.bot_agregar_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.bot_agregar_cat.Image = CType(resources.GetObject("bot_agregar_cat.Image"), System.Drawing.Image)
        Me.bot_agregar_cat.Location = New System.Drawing.Point(340, 11)
        Me.bot_agregar_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.bot_agregar_cat.Name = "bot_agregar_cat"
        Me.bot_agregar_cat.Size = New System.Drawing.Size(43, 37)
        Me.bot_agregar_cat.TabIndex = 1
        Me.bot_agregar_cat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bot_agregar_cat.UseVisualStyleBackColor = True
        '
        'txt_subtipo
        '
        Me.txt_subtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_subtipo.Location = New System.Drawing.Point(7, 20)
        Me.txt_subtipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_subtipo.Name = "txt_subtipo"
        Me.txt_subtipo.Size = New System.Drawing.Size(321, 20)
        Me.txt_subtipo.TabIndex = 0
        Me.txt_subtipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Equipos_subtipo_editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(426, 78)
        Me.Controls.Add(Me.Subtipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Equipos_subtipo_editar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar subtipo"
        Me.Subtipo.ResumeLayout(False)
        Me.Subtipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Subtipo As System.Windows.Forms.GroupBox
    Friend WithEvents bot_agregar_cat As System.Windows.Forms.Button
    Friend WithEvents txt_subtipo As System.Windows.Forms.TextBox
End Class
