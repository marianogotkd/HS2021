﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orden_Revision_nueva
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_diag = New System.Windows.Forms.TextBox()
        Me.lb_error_diagnostico = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_serv_id = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_dni = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.lb_error_cliente = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Button_imprimir = New System.Windows.Forms.Button()
        Me.Button_trabajo = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.combo_sucursal = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_serv_id)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 328)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Complete la información"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_diag)
        Me.GroupBox6.Controls.Add(Me.lb_error_diagnostico)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(7, 215)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(530, 105)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Diagnóstico previo:"
        '
        'txt_diag
        '
        Me.txt_diag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_diag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diag.Location = New System.Drawing.Point(3, 18)
        Me.txt_diag.Multiline = True
        Me.txt_diag.Name = "txt_diag"
        Me.txt_diag.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_diag.Size = New System.Drawing.Size(524, 84)
        Me.txt_diag.TabIndex = 0
        '
        'lb_error_diagnostico
        '
        Me.lb_error_diagnostico.AutoSize = True
        Me.lb_error_diagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error_diagnostico.ForeColor = System.Drawing.Color.Red
        Me.lb_error_diagnostico.Location = New System.Drawing.Point(129, -3)
        Me.lb_error_diagnostico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_error_diagnostico.Name = "lb_error_diagnostico"
        Me.lb_error_diagnostico.Size = New System.Drawing.Size(26, 31)
        Me.lb_error_diagnostico.TabIndex = 18
        Me.lb_error_diagnostico.Text = "*"
        Me.lb_error_diagnostico.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha:"
        '
        'txt_serv_id
        '
        Me.txt_serv_id.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_serv_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serv_id.Location = New System.Drawing.Point(148, 53)
        Me.txt_serv_id.Name = "txt_serv_id"
        Me.txt_serv_id.ReadOnly = True
        Me.txt_serv_id.Size = New System.Drawing.Size(238, 22)
        Me.txt_serv_id.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(402, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Número de orden:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.combo_sucursal)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox_dni)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox_Nombre)
        Me.GroupBox2.Controls.Add(Me.lb_error_cliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 124)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente "
        '
        'Button1
        '
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Buscar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(395, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 53)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Buscar Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DNI / CUIT:"
        '
        'TextBox_dni
        '
        Me.TextBox_dni.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TextBox_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_dni.Location = New System.Drawing.Point(141, 33)
        Me.TextBox_dni.Name = "TextBox_dni"
        Me.TextBox_dni.ReadOnly = True
        Me.TextBox_dni.Size = New System.Drawing.Size(238, 22)
        Me.TextBox_dni.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre / R. Social:"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TextBox_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(141, 60)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.ReadOnly = True
        Me.TextBox_Nombre.Size = New System.Drawing.Size(238, 22)
        Me.TextBox_Nombre.TabIndex = 0
        '
        'lb_error_cliente
        '
        Me.lb_error_cliente.AutoSize = True
        Me.lb_error_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error_cliente.ForeColor = System.Drawing.Color.Red
        Me.lb_error_cliente.Location = New System.Drawing.Point(386, 33)
        Me.lb_error_cliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_error_cliente.Name = "lb_error_cliente"
        Me.lb_error_cliente.Size = New System.Drawing.Size(26, 31)
        Me.lb_error_cliente.TabIndex = 19
        Me.lb_error_cliente.Text = "*"
        Me.lb_error_cliente.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.floppy_disk30x30
        Me.btn_guardar.Location = New System.Drawing.Point(401, 338)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(116, 43)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_guardar, "Guardar cambios")
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Button_imprimir
        '
        Me.Button_imprimir.BackColor = System.Drawing.SystemColors.Info
        Me.Button_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_imprimir.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button_imprimir.Location = New System.Drawing.Point(277, 337)
        Me.Button_imprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_imprimir.Name = "Button_imprimir"
        Me.Button_imprimir.Size = New System.Drawing.Size(116, 43)
        Me.Button_imprimir.TabIndex = 314
        Me.Button_imprimir.Text = "Imprimir orden"
        Me.Button_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_imprimir, "Imprimir orden de revisión")
        Me.Button_imprimir.UseVisualStyleBackColor = False
        '
        'Button_trabajo
        '
        Me.Button_trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_trabajo.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_trabajo.Location = New System.Drawing.Point(154, 337)
        Me.Button_trabajo.Name = "Button_trabajo"
        Me.Button_trabajo.Size = New System.Drawing.Size(116, 43)
        Me.Button_trabajo.TabIndex = 315
        Me.Button_trabajo.Text = "Ir a orden de trabajo"
        Me.Button_trabajo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_trabajo, "Ir a orden de trabajo")
        Me.Button_trabajo.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button4.Location = New System.Drawing.Point(49, 337)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 43)
        Me.Button4.TabIndex = 316
        Me.Button4.Text = "Volver"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button4, "Volver a calendario")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'combo_sucursal
        '
        Me.combo_sucursal.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.combo_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_sucursal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.combo_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_sucursal.FormattingEnabled = True
        Me.combo_sucursal.Location = New System.Drawing.Point(141, 90)
        Me.combo_sucursal.Name = "combo_sucursal"
        Me.combo_sucursal.Size = New System.Drawing.Size(238, 24)
        Me.combo_sucursal.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Sucursal:"
        '
        'Orden_Revision_nueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(571, 387)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button_trabajo)
        Me.Controls.Add(Me.Button_imprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_guardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Orden_Revision_nueva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva orden de revisión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_serv_id As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_dni As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_diag As System.Windows.Forms.TextBox
    Friend WithEvents lb_error_diagnostico As System.Windows.Forms.Label
    Friend WithEvents lb_error_cliente As System.Windows.Forms.Label
    Friend WithEvents Button_imprimir As System.Windows.Forms.Button
    Friend WithEvents Button_trabajo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents combo_sucursal As System.Windows.Forms.ComboBox
End Class
