<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastos_Consulta
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_gasto = New System.Windows.Forms.DataGridView()
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Costo_Ind = New Aplicacion.Costo_Ind()
        Me.btn_agre = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_selec = New System.Windows.Forms.Button()
        Me.tb_desc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_monto = New System.Windows.Forms.TextBox()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_gasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Costo_Ind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_gasto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 242)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos:"
        '
        'DG_gasto
        '
        Me.DG_gasto.AllowUserToAddRows = False
        Me.DG_gasto.AllowUserToDeleteRows = False
        Me.DG_gasto.AllowUserToResizeColumns = False
        Me.DG_gasto.AllowUserToResizeRows = False
        Me.DG_gasto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_gasto.BackgroundColor = System.Drawing.Color.White
        Me.DG_gasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_gasto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.desc, Me.Monto})
        Me.DG_gasto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_gasto.Location = New System.Drawing.Point(3, 16)
        Me.DG_gasto.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_gasto.MultiSelect = False
        Me.DG_gasto.Name = "DG_gasto"
        Me.DG_gasto.ReadOnly = True
        Me.DG_gasto.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        Me.DG_gasto.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_gasto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_gasto.Size = New System.Drawing.Size(407, 223)
        Me.DG_gasto.TabIndex = 1
        '
        'GastosBindingSource
        '
        Me.GastosBindingSource.DataMember = "Gastos"
        Me.GastosBindingSource.DataSource = Me.Costo_Ind
        '
        'Costo_Ind
        '
        Me.Costo_Ind.DataSetName = "Costo_Ind"
        Me.Costo_Ind.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_agre
        '
        Me.btn_agre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agre.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_agre.Location = New System.Drawing.Point(301, 23)
        Me.btn_agre.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agre.Name = "btn_agre"
        Me.btn_agre.Size = New System.Drawing.Size(124, 53)
        Me.btn_agre.TabIndex = 250
        Me.btn_agre.Text = "Agregar"
        Me.btn_agre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_agre.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.btn_guardar.Location = New System.Drawing.Point(15, 356)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(124, 43)
        Me.btn_guardar.TabIndex = 249
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_selec
        '
        Me.btn_selec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_selec.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selec.Image = Global.Aplicacion.My.Resources.Resources.Guardar2
        Me.btn_selec.Location = New System.Drawing.Point(298, 354)
        Me.btn_selec.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_selec.Name = "btn_selec"
        Me.btn_selec.Size = New System.Drawing.Size(124, 43)
        Me.btn_selec.TabIndex = 251
        Me.btn_selec.Text = "Seleccionar"
        Me.btn_selec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_selec.UseVisualStyleBackColor = True
        '
        'tb_desc
        '
        Me.tb_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_desc.Location = New System.Drawing.Point(98, 23)
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.Size = New System.Drawing.Size(196, 22)
        Me.tb_desc.TabIndex = 252
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 253
        Me.Label1.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 255
        Me.Label2.Text = "Monto"
        '
        'tb_monto
        '
        Me.tb_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_monto.Location = New System.Drawing.Point(98, 54)
        Me.tb_monto.Name = "tb_monto"
        Me.tb_monto.Size = New System.Drawing.Size(196, 22)
        Me.tb_monto.TabIndex = 254
        '
        'desc
        '
        Me.desc.HeaderText = "Descripcion"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Gastos_Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 440)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_monto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_desc)
        Me.Controls.Add(Me.btn_selec)
        Me.Controls.Add(Me.btn_agre)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Gastos_Consulta"
        Me.Text = "Gastos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_gasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Costo_Ind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_gasto As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agre As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_selec As System.Windows.Forms.Button
    Friend WithEvents tb_desc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_monto As System.Windows.Forms.TextBox
    Friend WithEvents GastosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Costo_Ind As Aplicacion.Costo_Ind
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
