﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consumos_consulta_detalle
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.TextBox_origen = New System.Windows.Forms.TextBox()
        Me.TextBox_usuario = New System.Windows.Forms.TextBox()
        Me.TextBox_fecha = New System.Windows.Forms.TextBox()
        Me.TextBox_concepto = New System.Windows.Forms.TextBox()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Lb_origen = New System.Windows.Forms.Label()
        Me.Lb_id = New System.Windows.Forms.Label()
        Me.Lb_concepto = New System.Windows.Forms.Label()
        Me.Lb_fecha = New System.Windows.Forms.Label()
        Me.Lb_usuario = New System.Windows.Forms.Label()
        Me.Caja_ds = New Aplicacion.Caja_ds()
        Me.CajadsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajadsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.TextBox_origen)
        Me.GroupBox2.Controls.Add(Me.TextBox_usuario)
        Me.GroupBox2.Controls.Add(Me.TextBox_fecha)
        Me.GroupBox2.Controls.Add(Me.TextBox_concepto)
        Me.GroupBox2.Controls.Add(Me.TextBox_ID)
        Me.GroupBox2.Controls.Add(Me.Lb_origen)
        Me.GroupBox2.Controls.Add(Me.Lb_id)
        Me.GroupBox2.Controls.Add(Me.Lb_concepto)
        Me.GroupBox2.Controls.Add(Me.Lb_fecha)
        Me.GroupBox2.Controls.Add(Me.Lb_usuario)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(821, 405)
        Me.GroupBox2.TabIndex = 256
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consumo seleccionado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Listado de productos:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ConsumosdetalleBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(25, 146)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(779, 252)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 34
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn
        '
        Me.ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn.DataPropertyName = "Consumo_mercaderiadetalle_cantidad"
        Me.ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn.Name = "ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn"
        Me.ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsumosdetalleBindingSource
        '
        Me.ConsumosdetalleBindingSource.DataMember = "consumos_detalle"
        Me.ConsumosdetalleBindingSource.DataSource = Me.Mov_DS
        '
        'Mov_DS
        '
        Me.Mov_DS.DataSetName = "Mov_DS"
        Me.Mov_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox_origen
        '
        Me.TextBox_origen.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_origen.Location = New System.Drawing.Point(536, 54)
        Me.TextBox_origen.Name = "TextBox_origen"
        Me.TextBox_origen.ReadOnly = True
        Me.TextBox_origen.Size = New System.Drawing.Size(254, 20)
        Me.TextBox_origen.TabIndex = 32
        '
        'TextBox_usuario
        '
        Me.TextBox_usuario.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_usuario.Location = New System.Drawing.Point(536, 32)
        Me.TextBox_usuario.Name = "TextBox_usuario"
        Me.TextBox_usuario.ReadOnly = True
        Me.TextBox_usuario.Size = New System.Drawing.Size(254, 20)
        Me.TextBox_usuario.TabIndex = 31
        '
        'TextBox_fecha
        '
        Me.TextBox_fecha.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_fecha.Location = New System.Drawing.Point(120, 76)
        Me.TextBox_fecha.Name = "TextBox_fecha"
        Me.TextBox_fecha.ReadOnly = True
        Me.TextBox_fecha.Size = New System.Drawing.Size(265, 20)
        Me.TextBox_fecha.TabIndex = 30
        '
        'TextBox_concepto
        '
        Me.TextBox_concepto.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_concepto.Location = New System.Drawing.Point(120, 54)
        Me.TextBox_concepto.Name = "TextBox_concepto"
        Me.TextBox_concepto.ReadOnly = True
        Me.TextBox_concepto.Size = New System.Drawing.Size(265, 20)
        Me.TextBox_concepto.TabIndex = 29
        '
        'TextBox_ID
        '
        Me.TextBox_ID.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_ID.Location = New System.Drawing.Point(120, 32)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(130, 20)
        Me.TextBox_ID.TabIndex = 28
        '
        'Lb_origen
        '
        Me.Lb_origen.AutoSize = True
        Me.Lb_origen.Location = New System.Drawing.Point(396, 58)
        Me.Lb_origen.Name = "Lb_origen"
        Me.Lb_origen.Size = New System.Drawing.Size(100, 13)
        Me.Lb_origen.TabIndex = 26
        Me.Lb_origen.Text = "Sucursal de Origen:"
        '
        'Lb_id
        '
        Me.Lb_id.AutoSize = True
        Me.Lb_id.Location = New System.Drawing.Point(25, 36)
        Me.Lb_id.Name = "Lb_id"
        Me.Lb_id.Size = New System.Drawing.Size(21, 13)
        Me.Lb_id.TabIndex = 22
        Me.Lb_id.Text = "ID:"
        '
        'Lb_concepto
        '
        Me.Lb_concepto.AutoSize = True
        Me.Lb_concepto.Location = New System.Drawing.Point(25, 58)
        Me.Lb_concepto.Name = "Lb_concepto"
        Me.Lb_concepto.Size = New System.Drawing.Size(56, 13)
        Me.Lb_concepto.TabIndex = 23
        Me.Lb_concepto.Text = "Concepto:"
        '
        'Lb_fecha
        '
        Me.Lb_fecha.AutoSize = True
        Me.Lb_fecha.Location = New System.Drawing.Point(25, 80)
        Me.Lb_fecha.Name = "Lb_fecha"
        Me.Lb_fecha.Size = New System.Drawing.Size(74, 13)
        Me.Lb_fecha.TabIndex = 24
        Me.Lb_fecha.Text = "Fecha y Hora:"
        '
        'Lb_usuario
        '
        Me.Lb_usuario.AutoSize = True
        Me.Lb_usuario.Location = New System.Drawing.Point(396, 36)
        Me.Lb_usuario.Name = "Lb_usuario"
        Me.Lb_usuario.Size = New System.Drawing.Size(46, 13)
        Me.Lb_usuario.TabIndex = 25
        Me.Lb_usuario.Text = "Usuario:"
        '
        'Caja_ds
        '
        Me.Caja_ds.DataSetName = "Caja_ds"
        Me.Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CajadsBindingSource
        '
        Me.CajadsBindingSource.DataSource = Me.Caja_ds
        Me.CajadsBindingSource.Position = 0
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button4.Location = New System.Drawing.Point(711, 415)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 43)
        Me.Button4.TabIndex = 257
        Me.Button4.Text = "Volver"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(579, 415)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 260
        Me.Button1.Text = "Generar reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Consumos_consulta_detalle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(830, 465)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Consumos_consulta_detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle del consumo seleccionado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajadsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents TextBox_origen As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_usuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_fecha As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_concepto As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lb_origen As System.Windows.Forms.Label
    Friend WithEvents Lb_id As System.Windows.Forms.Label
    Friend WithEvents Lb_concepto As System.Windows.Forms.Label
    Friend WithEvents Lb_fecha As System.Windows.Forms.Label
    Friend WithEvents Lb_usuario As System.Windows.Forms.Label
    Friend WithEvents Caja_ds As Aplicacion.Caja_ds
    Friend WithEvents CajadsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ConsumosdetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
