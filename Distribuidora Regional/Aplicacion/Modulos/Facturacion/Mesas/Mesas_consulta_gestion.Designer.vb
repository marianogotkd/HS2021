<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mesas_consulta_gestion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SectornombreusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MESAnumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoparcialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MESAidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectoridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectornombrefijoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesasAsignadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mesas_ds = New Aplicacion.Mesas_ds()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tx_buscar = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesasAsignadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mesas_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SectornombreusuarioDataGridViewTextBoxColumn, Me.MESAnumeroDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.ImporteTotalDataGridViewTextBoxColumn, Me.PagoparcialDataGridViewTextBoxColumn, Me.MESAidDataGridViewTextBoxColumn, Me.VentaprodidDataGridViewTextBoxColumn, Me.SectoridDataGridViewTextBoxColumn, Me.SectornombrefijoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MesasAsignadasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 37)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(665, 218)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 1
        '
        'SectornombreusuarioDataGridViewTextBoxColumn
        '
        Me.SectornombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "Sector_nombre_usuario"
        Me.SectornombreusuarioDataGridViewTextBoxColumn.HeaderText = "Sector"
        Me.SectornombreusuarioDataGridViewTextBoxColumn.Name = "SectornombreusuarioDataGridViewTextBoxColumn"
        Me.SectornombreusuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectornombreusuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MESAnumeroDataGridViewTextBoxColumn
        '
        Me.MESAnumeroDataGridViewTextBoxColumn.DataPropertyName = "MESA_numero"
        Me.MESAnumeroDataGridViewTextBoxColumn.HeaderText = "Nro mesa"
        Me.MESAnumeroDataGridViewTextBoxColumn.Name = "MESAnumeroDataGridViewTextBoxColumn"
        Me.MESAnumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.MESAnumeroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ImporteTotalDataGridViewTextBoxColumn
        '
        Me.ImporteTotalDataGridViewTextBoxColumn.DataPropertyName = "Importe_Total"
        Me.ImporteTotalDataGridViewTextBoxColumn.HeaderText = "Importe Total"
        Me.ImporteTotalDataGridViewTextBoxColumn.Name = "ImporteTotalDataGridViewTextBoxColumn"
        Me.ImporteTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteTotalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PagoparcialDataGridViewTextBoxColumn
        '
        Me.PagoparcialDataGridViewTextBoxColumn.DataPropertyName = "Pago_parcial"
        Me.PagoparcialDataGridViewTextBoxColumn.HeaderText = "Pago parcial"
        Me.PagoparcialDataGridViewTextBoxColumn.Name = "PagoparcialDataGridViewTextBoxColumn"
        Me.PagoparcialDataGridViewTextBoxColumn.ReadOnly = True
        Me.PagoparcialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MESAidDataGridViewTextBoxColumn
        '
        Me.MESAidDataGridViewTextBoxColumn.DataPropertyName = "MESA_id"
        Me.MESAidDataGridViewTextBoxColumn.HeaderText = "MESA_id"
        Me.MESAidDataGridViewTextBoxColumn.Name = "MESAidDataGridViewTextBoxColumn"
        Me.MESAidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MESAidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MESAidDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodidDataGridViewTextBoxColumn
        '
        Me.VentaprodidDataGridViewTextBoxColumn.DataPropertyName = "Ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.HeaderText = "Ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.Name = "VentaprodidDataGridViewTextBoxColumn"
        Me.VentaprodidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.VentaprodidDataGridViewTextBoxColumn.Visible = False
        '
        'SectoridDataGridViewTextBoxColumn
        '
        Me.SectoridDataGridViewTextBoxColumn.DataPropertyName = "Sector_id"
        Me.SectoridDataGridViewTextBoxColumn.HeaderText = "Sector_id"
        Me.SectoridDataGridViewTextBoxColumn.Name = "SectoridDataGridViewTextBoxColumn"
        Me.SectoridDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SectoridDataGridViewTextBoxColumn.Visible = False
        '
        'SectornombrefijoDataGridViewTextBoxColumn
        '
        Me.SectornombrefijoDataGridViewTextBoxColumn.DataPropertyName = "Sector_nombre_fijo"
        Me.SectornombrefijoDataGridViewTextBoxColumn.HeaderText = "Sector_nombre_fijo"
        Me.SectornombrefijoDataGridViewTextBoxColumn.Name = "SectornombrefijoDataGridViewTextBoxColumn"
        Me.SectornombrefijoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectornombrefijoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SectornombrefijoDataGridViewTextBoxColumn.Visible = False
        '
        'MesasAsignadasBindingSource
        '
        Me.MesasAsignadasBindingSource.DataMember = "MesasAsignadas"
        Me.MesasAsignadasBindingSource.DataSource = Me.Mesas_ds
        '
        'Mesas_ds
        '
        Me.Mesas_ds.DataSetName = "Mesas_ds"
        Me.Mesas_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Asignar"
        Me.ToolTip1.SetToolTip(Me.Button1, "Asignar mesa")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cargar - Cobrar"
        Me.ToolTip1.SetToolTip(Me.Button2, "Cargar y/o cobrar mesa")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(398, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Liberar"
        Me.ToolTip1.SetToolTip(Me.Button3, "Liberar mesa")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(575, 258)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Cambiar"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'tx_buscar
        '
        Me.tx_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_buscar.Location = New System.Drawing.Point(12, 12)
        Me.tx_buscar.Name = "tx_buscar"
        Me.tx_buscar.Size = New System.Drawing.Size(664, 20)
        Me.tx_buscar.TabIndex = 0
        '
        'Mesas_consulta_gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(688, 287)
        Me.Controls.Add(Me.tx_buscar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Mesas_consulta_gestion"
        Me.Text = "Mesas consulta gestion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesasAsignadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mesas_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MesasAsignadasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mesas_ds As Aplicacion.Mesas_ds
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SectornombreusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MESAnumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagoparcialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MESAidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectoridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectornombrefijoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tx_buscar As System.Windows.Forms.TextBox
End Class
