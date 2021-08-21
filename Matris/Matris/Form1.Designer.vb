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
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dt_matris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.dt_matris.Location = New System.Drawing.Point(12, 80)
        Me.dt_matris.Name = "dt_matris"
        Me.dt_matris.ReadOnly = True
        Me.dt_matris.Size = New System.Drawing.Size(974, 637)
        Me.dt_matris.TabIndex = 0
        '
        'btn_Crear
        '
        Me.btn_Crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Crear.Location = New System.Drawing.Point(379, 13)
        Me.btn_Crear.Name = "btn_Crear"
        Me.btn_Crear.Size = New System.Drawing.Size(141, 40)
        Me.btn_Crear.TabIndex = 1
        Me.btn_Crear.Text = "GENERAR MATRIZ"
        Me.btn_Crear.UseVisualStyleBackColor = True
        '
        'tb_fila
        '
        Me.tb_fila.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fila.Location = New System.Drawing.Point(83, 13)
        Me.tb_fila.Name = "tb_fila"
        Me.tb_fila.Size = New System.Drawing.Size(81, 40)
        Me.tb_fila.TabIndex = 2
        Me.tb_fila.Text = "10"
        '
        'tb_Col
        '
        Me.tb_Col.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Col.Location = New System.Drawing.Point(292, 13)
        Me.tb_Col.Name = "tb_Col"
        Me.tb_Col.Size = New System.Drawing.Size(81, 40)
        Me.tb_Col.TabIndex = 3
        Me.tb_Col.Text = "10"
        '
        'lbl_fila
        '
        Me.lbl_fila.AutoSize = True
        Me.lbl_fila.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fila.Location = New System.Drawing.Point(14, 23)
        Me.lbl_fila.Name = "lbl_fila"
        Me.lbl_fila.Size = New System.Drawing.Size(63, 25)
        Me.lbl_fila.TabIndex = 4
        Me.lbl_fila.Text = "Filas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(170, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Columnas"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(599, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "REALIZAR RECORRIDO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tb_fila)
        Me.Panel1.Controls.Add(Me.tb_Col)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lbl_fila)
        Me.Panel1.Controls.Add(Me.btn_Crear)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 62)
        Me.Panel1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dt_matris)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriz"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dt_matris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt_matris As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Crear As System.Windows.Forms.Button
    Friend WithEvents tb_fila As System.Windows.Forms.TextBox
    Friend WithEvents tb_Col As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fila As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
