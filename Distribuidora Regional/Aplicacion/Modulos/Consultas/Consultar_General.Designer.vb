<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_General
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_General))
        Me.Bo_informe_dev = New System.Windows.Forms.Button()
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.tx_cod_prod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DG_Recepcionado = New System.Windows.Forms.DataGridView()
        Me.RECEPCIONfechasistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECEPCIONpresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECEPCIONcantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECEPCION_nrolote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObtenerRecepcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaGeneral = New Aplicacion.ConsultaGeneral()
        Me.DG_Vendido = New System.Windows.Forms.DataGridView()
        Me.VentafechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODpresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta_Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLI_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObtenerVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_Devuelto = New System.Windows.Forms.DataGridView()
        Me.DevfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcodigoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODNombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODpresentacionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DevCantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DevcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECEPCIONnroloteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObtenerDevolucionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_Retirado = New System.Windows.Forms.DataGridView()
        Me.RetirofechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODcodigoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODpresentacionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODDETnroloteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObtenerRetirosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DG_Recepcionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenerRecepcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Vendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenerVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Devuelto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenerDevolucionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Retirado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenerRetirosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bo_informe_dev
        '
        Me.Bo_informe_dev.Image = CType(resources.GetObject("Bo_informe_dev.Image"), System.Drawing.Image)
        Me.Bo_informe_dev.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bo_informe_dev.Location = New System.Drawing.Point(505, 12)
        Me.Bo_informe_dev.Name = "Bo_informe_dev"
        Me.Bo_informe_dev.Size = New System.Drawing.Size(75, 57)
        Me.Bo_informe_dev.TabIndex = 23
        Me.Bo_informe_dev.Text = "Informe"
        Me.Bo_informe_dev.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bo_informe_dev.UseVisualStyleBackColor = True
        '
        'BO_buscar
        '
        Me.BO_buscar.Image = CType(resources.GetObject("BO_buscar.Image"), System.Drawing.Image)
        Me.BO_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BO_buscar.Location = New System.Drawing.Point(424, 12)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(75, 56)
        Me.BO_buscar.TabIndex = 22
        Me.BO_buscar.Text = "Busqueda"
        Me.BO_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'tx_cod_prod
        '
        Me.tx_cod_prod.Location = New System.Drawing.Point(136, 41)
        Me.tx_cod_prod.Name = "tx_cod_prod"
        Me.tx_cod_prod.Size = New System.Drawing.Size(272, 20)
        Me.tx_cod_prod.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(14, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Codigo de producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Consulta General"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Recepcionado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(13, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Vendido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(13, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Devuelto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(13, 510)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Retirado"
        '
        'DG_Recepcionado
        '
        Me.DG_Recepcionado.AutoGenerateColumns = False
        Me.DG_Recepcionado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Recepcionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Recepcionado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RECEPCIONfechasistemaDataGridViewTextBoxColumn, Me.PRODcodigoDataGridViewTextBoxColumn, Me.PRODnombreDataGridViewTextBoxColumn, Me.RECEPCIONpresentacionDataGridViewTextBoxColumn, Me.RECEPCIONcantidadDataGridViewTextBoxColumn, Me.RECEPCION_nrolote})
        Me.DG_Recepcionado.DataSource = Me.ObtenerRecepcionesBindingSource
        Me.DG_Recepcionado.Location = New System.Drawing.Point(11, 95)
        Me.DG_Recepcionado.Name = "DG_Recepcionado"
        Me.DG_Recepcionado.Size = New System.Drawing.Size(971, 120)
        Me.DG_Recepcionado.TabIndex = 28
        '
        'RECEPCIONfechasistemaDataGridViewTextBoxColumn
        '
        Me.RECEPCIONfechasistemaDataGridViewTextBoxColumn.DataPropertyName = "RECEPCION_fecha_sistema"
        Me.RECEPCIONfechasistemaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.RECEPCIONfechasistemaDataGridViewTextBoxColumn.Name = "RECEPCIONfechasistemaDataGridViewTextBoxColumn"
        '
        'PRODcodigoDataGridViewTextBoxColumn
        '
        Me.PRODcodigoDataGridViewTextBoxColumn.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn.Name = "PRODcodigoDataGridViewTextBoxColumn"
        '
        'PRODnombreDataGridViewTextBoxColumn
        '
        Me.PRODnombreDataGridViewTextBoxColumn.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.Name = "PRODnombreDataGridViewTextBoxColumn"
        '
        'RECEPCIONpresentacionDataGridViewTextBoxColumn
        '
        Me.RECEPCIONpresentacionDataGridViewTextBoxColumn.DataPropertyName = "RECEPCION_presentacion"
        Me.RECEPCIONpresentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion"
        Me.RECEPCIONpresentacionDataGridViewTextBoxColumn.Name = "RECEPCIONpresentacionDataGridViewTextBoxColumn"
        '
        'RECEPCIONcantidadDataGridViewTextBoxColumn
        '
        Me.RECEPCIONcantidadDataGridViewTextBoxColumn.DataPropertyName = "RECEPCION_cantidad"
        Me.RECEPCIONcantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.RECEPCIONcantidadDataGridViewTextBoxColumn.Name = "RECEPCIONcantidadDataGridViewTextBoxColumn"
        '
        'RECEPCION_nrolote
        '
        Me.RECEPCION_nrolote.DataPropertyName = "RECEPCION_nrolote"
        Me.RECEPCION_nrolote.HeaderText = "Nro. de Lote"
        Me.RECEPCION_nrolote.Name = "RECEPCION_nrolote"
        '
        'ObtenerRecepcionesBindingSource
        '
        Me.ObtenerRecepcionesBindingSource.DataMember = "Obtener_Recepciones"
        Me.ObtenerRecepcionesBindingSource.DataSource = Me.ConsultaGeneral
        '
        'ConsultaGeneral
        '
        Me.ConsultaGeneral.DataSetName = "ConsultaGeneral"
        Me.ConsultaGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DG_Vendido
        '
        Me.DG_Vendido.AutoGenerateColumns = False
        Me.DG_Vendido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Vendido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Vendido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VentafechaDataGridViewTextBoxColumn, Me.PRODcodigoDataGridViewTextBoxColumn1, Me.PRODnombreDataGridViewTextBoxColumn1, Me.PRODpresentacionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.Venta_Lote, Me.CLI_nom})
        Me.DG_Vendido.DataSource = Me.ObtenerVentasBindingSource
        Me.DG_Vendido.Location = New System.Drawing.Point(11, 241)
        Me.DG_Vendido.Name = "DG_Vendido"
        Me.DG_Vendido.Size = New System.Drawing.Size(971, 120)
        Me.DG_Vendido.TabIndex = 29
        '
        'VentafechaDataGridViewTextBoxColumn
        '
        Me.VentafechaDataGridViewTextBoxColumn.DataPropertyName = "Venta_fecha"
        Me.VentafechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.VentafechaDataGridViewTextBoxColumn.Name = "VentafechaDataGridViewTextBoxColumn"
        '
        'PRODcodigoDataGridViewTextBoxColumn1
        '
        Me.PRODcodigoDataGridViewTextBoxColumn1.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn1.Name = "PRODcodigoDataGridViewTextBoxColumn1"
        '
        'PRODnombreDataGridViewTextBoxColumn1
        '
        Me.PRODnombreDataGridViewTextBoxColumn1.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.PRODnombreDataGridViewTextBoxColumn1.Name = "PRODnombreDataGridViewTextBoxColumn1"
        '
        'PRODpresentacionDataGridViewTextBoxColumn
        '
        Me.PRODpresentacionDataGridViewTextBoxColumn.DataPropertyName = "PROD_presentacion"
        Me.PRODpresentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion"
        Me.PRODpresentacionDataGridViewTextBoxColumn.Name = "PRODpresentacionDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'Venta_Lote
        '
        Me.Venta_Lote.DataPropertyName = "Venta_Lote"
        Me.Venta_Lote.HeaderText = "Nro. de Lote"
        Me.Venta_Lote.Name = "Venta_Lote"
        '
        'CLI_nom
        '
        Me.CLI_nom.DataPropertyName = "CLI_nom"
        Me.CLI_nom.HeaderText = "Vendido a:"
        Me.CLI_nom.Name = "CLI_nom"
        '
        'ObtenerVentasBindingSource
        '
        Me.ObtenerVentasBindingSource.DataMember = "Obtener_Ventas"
        Me.ObtenerVentasBindingSource.DataSource = Me.ConsultaGeneral
        '
        'DG_Devuelto
        '
        Me.DG_Devuelto.AutoGenerateColumns = False
        Me.DG_Devuelto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Devuelto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Devuelto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DevfechaDataGridViewTextBoxColumn, Me.PRODcodigoDataGridViewTextBoxColumn2, Me.PRODNombreDataGridViewTextBoxColumn2, Me.PRODpresentacionDataGridViewTextBoxColumn1, Me.DevCantidadDataGridViewTextBoxColumn, Me.DevcodigoDataGridViewTextBoxColumn, Me.RECEPCIONnroloteDataGridViewTextBoxColumn})
        Me.DG_Devuelto.DataSource = Me.ObtenerDevolucionesBindingSource
        Me.DG_Devuelto.Location = New System.Drawing.Point(11, 387)
        Me.DG_Devuelto.Name = "DG_Devuelto"
        Me.DG_Devuelto.Size = New System.Drawing.Size(971, 120)
        Me.DG_Devuelto.TabIndex = 30
        '
        'DevfechaDataGridViewTextBoxColumn
        '
        Me.DevfechaDataGridViewTextBoxColumn.DataPropertyName = "Dev_fecha"
        Me.DevfechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.DevfechaDataGridViewTextBoxColumn.Name = "DevfechaDataGridViewTextBoxColumn"
        '
        'PRODcodigoDataGridViewTextBoxColumn2
        '
        Me.PRODcodigoDataGridViewTextBoxColumn2.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn2.Name = "PRODcodigoDataGridViewTextBoxColumn2"
        '
        'PRODNombreDataGridViewTextBoxColumn2
        '
        Me.PRODNombreDataGridViewTextBoxColumn2.DataPropertyName = "PROD_Nombre"
        Me.PRODNombreDataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.PRODNombreDataGridViewTextBoxColumn2.Name = "PRODNombreDataGridViewTextBoxColumn2"
        '
        'PRODpresentacionDataGridViewTextBoxColumn1
        '
        Me.PRODpresentacionDataGridViewTextBoxColumn1.DataPropertyName = "PROD_presentacion"
        Me.PRODpresentacionDataGridViewTextBoxColumn1.HeaderText = "Presentacion"
        Me.PRODpresentacionDataGridViewTextBoxColumn1.Name = "PRODpresentacionDataGridViewTextBoxColumn1"
        '
        'DevCantidadDataGridViewTextBoxColumn
        '
        Me.DevCantidadDataGridViewTextBoxColumn.DataPropertyName = "Dev_Cantidad"
        Me.DevCantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.DevCantidadDataGridViewTextBoxColumn.Name = "DevCantidadDataGridViewTextBoxColumn"
        '
        'DevcodigoDataGridViewTextBoxColumn
        '
        Me.DevcodigoDataGridViewTextBoxColumn.DataPropertyName = "Dev_codigo"
        Me.DevcodigoDataGridViewTextBoxColumn.HeaderText = "Codigo de Devolucion"
        Me.DevcodigoDataGridViewTextBoxColumn.Name = "DevcodigoDataGridViewTextBoxColumn"
        Me.DevcodigoDataGridViewTextBoxColumn.Visible = False
        '
        'RECEPCIONnroloteDataGridViewTextBoxColumn
        '
        Me.RECEPCIONnroloteDataGridViewTextBoxColumn.DataPropertyName = "RECEPCION_nrolote"
        Me.RECEPCIONnroloteDataGridViewTextBoxColumn.HeaderText = "Nro de Lote"
        Me.RECEPCIONnroloteDataGridViewTextBoxColumn.Name = "RECEPCIONnroloteDataGridViewTextBoxColumn"
        '
        'ObtenerDevolucionesBindingSource
        '
        Me.ObtenerDevolucionesBindingSource.DataMember = "Obtener_Devoluciones"
        Me.ObtenerDevolucionesBindingSource.DataSource = Me.ConsultaGeneral
        '
        'DG_Retirado
        '
        Me.DG_Retirado.AutoGenerateColumns = False
        Me.DG_Retirado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Retirado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Retirado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RetirofechaDataGridViewTextBoxColumn, Me.PRODcodigoDataGridViewTextBoxColumn3, Me.PRODnombreDataGridViewTextBoxColumn3, Me.PRODpresentacionDataGridViewTextBoxColumn2, Me.PRODDETnroloteDataGridViewTextBoxColumn})
        Me.DG_Retirado.DataSource = Me.ObtenerRetirosBindingSource
        Me.DG_Retirado.Location = New System.Drawing.Point(11, 533)
        Me.DG_Retirado.Name = "DG_Retirado"
        Me.DG_Retirado.Size = New System.Drawing.Size(971, 120)
        Me.DG_Retirado.TabIndex = 31
        '
        'RetirofechaDataGridViewTextBoxColumn
        '
        Me.RetirofechaDataGridViewTextBoxColumn.DataPropertyName = "Retiro_fecha"
        Me.RetirofechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.RetirofechaDataGridViewTextBoxColumn.Name = "RetirofechaDataGridViewTextBoxColumn"
        '
        'PRODcodigoDataGridViewTextBoxColumn3
        '
        Me.PRODcodigoDataGridViewTextBoxColumn3.DataPropertyName = "PROD_codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.PRODcodigoDataGridViewTextBoxColumn3.Name = "PRODcodigoDataGridViewTextBoxColumn3"
        '
        'PRODnombreDataGridViewTextBoxColumn3
        '
        Me.PRODnombreDataGridViewTextBoxColumn3.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.PRODnombreDataGridViewTextBoxColumn3.Name = "PRODnombreDataGridViewTextBoxColumn3"
        '
        'PRODpresentacionDataGridViewTextBoxColumn2
        '
        Me.PRODpresentacionDataGridViewTextBoxColumn2.DataPropertyName = "PROD_presentacion"
        Me.PRODpresentacionDataGridViewTextBoxColumn2.HeaderText = "Presentacion"
        Me.PRODpresentacionDataGridViewTextBoxColumn2.Name = "PRODpresentacionDataGridViewTextBoxColumn2"
        '
        'PRODDETnroloteDataGridViewTextBoxColumn
        '
        Me.PRODDETnroloteDataGridViewTextBoxColumn.DataPropertyName = "PRODDET_nrolote"
        Me.PRODDETnroloteDataGridViewTextBoxColumn.HeaderText = "Nro de Lote"
        Me.PRODDETnroloteDataGridViewTextBoxColumn.Name = "PRODDETnroloteDataGridViewTextBoxColumn"
        '
        'ObtenerRetirosBindingSource
        '
        Me.ObtenerRetirosBindingSource.DataMember = "Obtener_Retiros"
        Me.ObtenerRetirosBindingSource.DataSource = Me.ConsultaGeneral
        '
        'Consultar_General
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 729)
        Me.Controls.Add(Me.DG_Retirado)
        Me.Controls.Add(Me.DG_Devuelto)
        Me.Controls.Add(Me.DG_Vendido)
        Me.Controls.Add(Me.DG_Recepcionado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bo_informe_dev)
        Me.Controls.Add(Me.BO_buscar)
        Me.Controls.Add(Me.tx_cod_prod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consultar_General"
        Me.Text = "Consultar General"
        CType(Me.DG_Recepcionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenerRecepcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Vendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenerVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Devuelto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenerDevolucionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Retirado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenerRetirosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bo_informe_dev As System.Windows.Forms.Button
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents tx_cod_prod As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DG_Recepcionado As System.Windows.Forms.DataGridView
    Friend WithEvents DG_Vendido As System.Windows.Forms.DataGridView
    Friend WithEvents DG_Devuelto As System.Windows.Forms.DataGridView
    Friend WithEvents DG_Retirado As System.Windows.Forms.DataGridView
    Friend WithEvents ObtenerRecepcionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultaGeneral As Aplicacion.ConsultaGeneral
    Friend WithEvents ObtenerVentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObtenerDevolucionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObtenerRetirosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECEPCIONfechasistemaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONpresentacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONcantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentafechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODpresentacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetirofechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODpresentacionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODDETnroloteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCION_nrolote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venta_Lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DevfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODcodigoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODNombreDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODpresentacionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DevCantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DevcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEPCIONnroloteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLI_nom As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
