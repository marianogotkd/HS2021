<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario_modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario_modificar))
        Me.Bo_cambiar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DG_bloqueados = New System.Windows.Forms.DataGridView()
        Me.USUidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUapeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUnomDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UTdescDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_usuario1 = New Aplicacion.DS_usuario()
        Me.Bo_bloquear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_usuario = New System.Windows.Forms.DataGridView()
        Me.USUidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UTdescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.COM_UT_dep = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Bo_desbloq = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_bloqueados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_usuario1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bo_cambiar
        '
        Me.Bo_cambiar.Image = CType(resources.GetObject("Bo_cambiar.Image"), System.Drawing.Image)
        Me.Bo_cambiar.Location = New System.Drawing.Point(777, 221)
        Me.Bo_cambiar.Name = "Bo_cambiar"
        Me.Bo_cambiar.Size = New System.Drawing.Size(40, 40)
        Me.Bo_cambiar.TabIndex = 132
        Me.ToolTip1.SetToolTip(Me.Bo_cambiar, "Cambiar tipo de usuario")
        Me.Bo_cambiar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DG_bloqueados)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(222, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 159)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuarios Bloqueados"
        '
        'DG_bloqueados
        '
        Me.DG_bloqueados.AllowUserToAddRows = False
        Me.DG_bloqueados.AllowUserToDeleteRows = False
        Me.DG_bloqueados.AutoGenerateColumns = False
        Me.DG_bloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_bloqueados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USUidDataGridViewTextBoxColumn1, Me.USUapeDataGridViewTextBoxColumn1, Me.USUnomDataGridViewTextBoxColumn1, Me.UTdescDataGridViewTextBoxColumn1})
        Me.DG_bloqueados.DataSource = Me.UsuariosBindingSource2
        Me.DG_bloqueados.Location = New System.Drawing.Point(6, 12)
        Me.DG_bloqueados.Name = "DG_bloqueados"
        Me.DG_bloqueados.ReadOnly = True
        Me.DG_bloqueados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_bloqueados.Size = New System.Drawing.Size(415, 134)
        Me.DG_bloqueados.TabIndex = 1
        '
        'USUidDataGridViewTextBoxColumn1
        '
        Me.USUidDataGridViewTextBoxColumn1.DataPropertyName = "USU_id"
        Me.USUidDataGridViewTextBoxColumn1.HeaderText = "USU_id"
        Me.USUidDataGridViewTextBoxColumn1.Name = "USUidDataGridViewTextBoxColumn1"
        Me.USUidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.USUidDataGridViewTextBoxColumn1.Visible = False
        '
        'USUapeDataGridViewTextBoxColumn1
        '
        Me.USUapeDataGridViewTextBoxColumn1.DataPropertyName = "USU_ape"
        Me.USUapeDataGridViewTextBoxColumn1.HeaderText = "Apellido"
        Me.USUapeDataGridViewTextBoxColumn1.Name = "USUapeDataGridViewTextBoxColumn1"
        Me.USUapeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'USUnomDataGridViewTextBoxColumn1
        '
        Me.USUnomDataGridViewTextBoxColumn1.DataPropertyName = "USU_nom"
        Me.USUnomDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.USUnomDataGridViewTextBoxColumn1.Name = "USUnomDataGridViewTextBoxColumn1"
        Me.USUnomDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UTdescDataGridViewTextBoxColumn1
        '
        Me.UTdescDataGridViewTextBoxColumn1.DataPropertyName = "UT_desc"
        Me.UTdescDataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.UTdescDataGridViewTextBoxColumn1.Name = "UTdescDataGridViewTextBoxColumn1"
        Me.UTdescDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UsuariosBindingSource2
        '
        Me.UsuariosBindingSource2.DataMember = "Usuarios"
        Me.UsuariosBindingSource2.DataSource = Me.DS_usuario1
        '
        'DS_usuario1
        '
        Me.DS_usuario1.DataSetName = "DS_usuario"
        Me.DS_usuario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bo_bloquear
        '
        Me.Bo_bloquear.Image = CType(resources.GetObject("Bo_bloquear.Image"), System.Drawing.Image)
        Me.Bo_bloquear.Location = New System.Drawing.Point(823, 221)
        Me.Bo_bloquear.Name = "Bo_bloquear"
        Me.Bo_bloquear.Size = New System.Drawing.Size(40, 40)
        Me.Bo_bloquear.TabIndex = 128
        Me.ToolTip1.SetToolTip(Me.Bo_bloquear, "Bloquear usuario")
        Me.Bo_bloquear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DG_usuario)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 159)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'DG_usuario
        '
        Me.DG_usuario.AllowUserToAddRows = False
        Me.DG_usuario.AllowUserToDeleteRows = False
        Me.DG_usuario.AutoGenerateColumns = False
        Me.DG_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_usuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USUidDataGridViewTextBoxColumn, Me.USUapeDataGridViewTextBoxColumn, Me.USUnomDataGridViewTextBoxColumn, Me.UTdescDataGridViewTextBoxColumn})
        Me.DG_usuario.DataSource = Me.UsuariosBindingSource1
        Me.DG_usuario.GridColor = System.Drawing.Color.DarkSlateGray
        Me.DG_usuario.Location = New System.Drawing.Point(6, 19)
        Me.DG_usuario.Name = "DG_usuario"
        Me.DG_usuario.ReadOnly = True
        Me.DG_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_usuario.Size = New System.Drawing.Size(415, 134)
        Me.DG_usuario.TabIndex = 0
        '
        'USUidDataGridViewTextBoxColumn
        '
        Me.USUidDataGridViewTextBoxColumn.DataPropertyName = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.HeaderText = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.Name = "USUidDataGridViewTextBoxColumn"
        Me.USUidDataGridViewTextBoxColumn.ReadOnly = True
        Me.USUidDataGridViewTextBoxColumn.Visible = False
        '
        'USUapeDataGridViewTextBoxColumn
        '
        Me.USUapeDataGridViewTextBoxColumn.DataPropertyName = "USU_ape"
        Me.USUapeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.USUapeDataGridViewTextBoxColumn.Name = "USUapeDataGridViewTextBoxColumn"
        Me.USUapeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USUnomDataGridViewTextBoxColumn
        '
        Me.USUnomDataGridViewTextBoxColumn.DataPropertyName = "USU_nom"
        Me.USUnomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.USUnomDataGridViewTextBoxColumn.Name = "USUnomDataGridViewTextBoxColumn"
        Me.USUnomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UTdescDataGridViewTextBoxColumn
        '
        Me.UTdescDataGridViewTextBoxColumn.DataPropertyName = "UT_desc"
        Me.UTdescDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.UTdescDataGridViewTextBoxColumn.Name = "UTdescDataGridViewTextBoxColumn"
        Me.UTdescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuariosBindingSource1
        '
        Me.UsuariosBindingSource1.DataMember = "Usuarios"
        Me.UsuariosBindingSource1.DataSource = Me.DS_usuario1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.COM_UT_dep)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Location = New System.Drawing.Point(485, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(283, 58)
        Me.GroupBox3.TabIndex = 131
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Usuario"
        '
        'COM_UT_dep
        '
        Me.COM_UT_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_UT_dep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_UT_dep.FormattingEnabled = True
        Me.COM_UT_dep.Location = New System.Drawing.Point(98, 19)
        Me.COM_UT_dep.Name = "COM_UT_dep"
        Me.COM_UT_dep.Size = New System.Drawing.Size(165, 24)
        Me.COM_UT_dep.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label21.Location = New System.Drawing.Point(14, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 16)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Tipo"
        '
        'Bo_desbloq
        '
        Me.Bo_desbloq.Image = CType(resources.GetObject("Bo_desbloq.Image"), System.Drawing.Image)
        Me.Bo_desbloq.Location = New System.Drawing.Point(823, 476)
        Me.Bo_desbloq.Name = "Bo_desbloq"
        Me.Bo_desbloq.Size = New System.Drawing.Size(40, 40)
        Me.Bo_desbloq.TabIndex = 130
        Me.ToolTip1.SetToolTip(Me.Bo_desbloq, "Desbloquear usuario")
        Me.Bo_desbloq.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(415, 134)
        Me.DataGridView1.TabIndex = 0
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.DS_usuario1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(24, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(850, 203)
        Me.TabControl1.TabIndex = 135
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(842, 177)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Usuario: Bloquear"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(24, 267)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(850, 203)
        Me.TabControl2.TabIndex = 136
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(842, 177)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Usuario: Desbloquear"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Usuario_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Bo_desbloq)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Bo_bloquear)
        Me.Controls.Add(Me.Bo_cambiar)
        Me.Name = "Usuario_modificar"
        Me.Text = "Usuario_modificar"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_bloqueados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_usuario1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bo_cambiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Bo_bloquear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents COM_UT_dep As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Bo_desbloq As System.Windows.Forms.Button
    Friend WithEvents DG_bloqueados As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_usuario1 As Aplicacion.DS_usuario
    Friend WithEvents UsuariosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DG_usuario As System.Windows.Forms.DataGridView
    Friend WithEvents USUidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UTdescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUapeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUnomDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UTdescDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuariosBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
