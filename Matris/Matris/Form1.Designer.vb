<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dt_matris = New System.Windows.Forms.DataGridView()
        Me.btn_Crear = New System.Windows.Forms.Button()
        Me.tb_fila = New System.Windows.Forms.TextBox()
        Me.tb_Col = New System.Windows.Forms.TextBox()
        Me.lbl_fila = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dt_matris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt_matris
        '
        Me.dt_matris.AllowUserToAddRows = False
        Me.dt_matris.AllowUserToDeleteRows = False
        Me.dt_matris.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_matris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_matris.Location = New System.Drawing.Point(12, 72)
        Me.dt_matris.Name = "dt_matris"
        Me.dt_matris.ReadOnly = True
        Me.dt_matris.Size = New System.Drawing.Size(1025, 394)
        Me.dt_matris.TabIndex = 0
        '
        'btn_Crear
        '
        Me.btn_Crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Crear.Location = New System.Drawing.Point(710, 12)
        Me.btn_Crear.Name = "btn_Crear"
        Me.btn_Crear.Size = New System.Drawing.Size(102, 46)
        Me.btn_Crear.TabIndex = 1
        Me.btn_Crear.Text = "CREAR"
        Me.btn_Crear.UseVisualStyleBackColor = True
        '
        'tb_fila
        '
        Me.tb_fila.Location = New System.Drawing.Point(255, 33)
        Me.tb_fila.Name = "tb_fila"
        Me.tb_fila.Size = New System.Drawing.Size(102, 20)
        Me.tb_fila.TabIndex = 2
        '
        'tb_Col
        '
        Me.tb_Col.Location = New System.Drawing.Point(442, 33)
        Me.tb_Col.Name = "tb_Col"
        Me.tb_Col.Size = New System.Drawing.Size(102, 20)
        Me.tb_Col.TabIndex = 3
        '
        'lbl_fila
        '
        Me.lbl_fila.AutoSize = True
        Me.lbl_fila.Location = New System.Drawing.Point(226, 40)
        Me.lbl_fila.Name = "lbl_fila"
        Me.lbl_fila.Size = New System.Drawing.Size(23, 13)
        Me.lbl_fila.TabIndex = 4
        Me.lbl_fila.Text = "Fila"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Columna"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(818, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CAMINO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 478)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_fila)
        Me.Controls.Add(Me.tb_Col)
        Me.Controls.Add(Me.tb_fila)
        Me.Controls.Add(Me.btn_Crear)
        Me.Controls.Add(Me.dt_matris)
        Me.Name = "Form1"
        Me.Text = "Matris"
        CType(Me.dt_matris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dt_matris As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Crear As System.Windows.Forms.Button
    Friend WithEvents tb_fila As System.Windows.Forms.TextBox
    Friend WithEvents tb_Col As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fila As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
