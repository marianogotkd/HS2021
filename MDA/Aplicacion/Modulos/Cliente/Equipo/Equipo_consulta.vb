Imports ZXing
Imports System.IO
Imports ZXing.QrCode

Public Class Equipo_consulta
    Dim dacliete As New Datos.Cliente
    Dim daequipo As New Datos.Equipo
    Public Cli_id As Integer 'me lo envia el formulario Cliente_modificar
    Private Sub BO_equipo_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_equipo_nuevo.Click
        Equipo_nuevo.Close()

        'pasar id de la sucursal para recuperar los sectores

        Equipo_nuevo.txt_cliente.Text = txt_cliente.Text
        Equipo_nuevo.txt_sucursal.Text = cb_sucursal.Text
        Equipo_nuevo.SucxClie_id = cb_sucursal.SelectedValue
        Equipo_nuevo.procedencia = "alta"
        Equipo_nuevo.Show()
        Me.Hide()
    End Sub

    Private Sub BO_equipo_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_equipo_editar.Click
        'tengo q enviar el id del equipo
        If DG_clientes.Rows.Count <> 0 Then
            Equipo_nuevo.Close()
            Dim Equipo_id As Integer = DG_clientes.CurrentRow.Cells("EquipoidDataGridViewTextBoxColumn").Value
            Equipo_nuevo.Equipo_id = Equipo_id
            Equipo_nuevo.txt_cliente.Text = txt_cliente.Text
            Equipo_nuevo.txt_sucursal.Text = cb_sucursal.Text
            Equipo_nuevo.SucxClie_id = cb_sucursal.SelectedValue
            Equipo_nuevo.procedencia = "modificar"
            Equipo_nuevo.Text = "Modificar Equipo"
            Equipo_nuevo.Show()

        Else
            MessageBox.Show("Debe seleccionar un equipo para editar.", "Sistema de Gestión.", MessageBoxButtons.OK)
        End If


    End Sub

    Private Sub Equipo_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'recuperar todas las sucursales y poner en el combo
        recuperar_info_cliente()
    End Sub


    Dim SucxClie_id As Integer = 0
    Private Sub recuperar_info_cliente()
        Dim ds_clie As DataSet = dacliete.Cliente_obtener_info(Cli_id)

        If ds_clie.Tables(0).Rows.Count <> 0 Then
            txt_cliente.Text = ds_clie.Tables(0).Rows(0).Item("CLI_Fan")
            tb_idcli.Text = ds_clie.Tables(0).Rows(0).Item("CLI_id")
            txt_cliente.ReadOnly = True
        End If



        If ds_clie.Tables(3).Rows.Count <> 0 Then
            cb_sucursal.DataSource = ds_clie.Tables(3) 'contiene las sucursales cuyo SucxClie_estado= 'ACTIVO'
            cb_sucursal.DisplayMember = "SucxClie_nombre"
            cb_sucursal.ValueMember = "SucxClie_id"
            'ahora cargo en el gridview de abajo los equipos existentes para esa sucursal
            SucxClie_id = cb_sucursal.SelectedValue
            recuperar_equipos()
        End If
    End Sub

    Private Sub etiqueta_grid_generar()
        If Equipos_ds.Tables("Equipo").Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < Equipos_ds.Tables("Equipo").Rows.Count
                Dim etiqueta As String = ""
                etiqueta = etiqueta + CStr(Cli_id) + "-" 'id cliente - cliente
                etiqueta = etiqueta + CStr(cb_sucursal.SelectedValue) + "-" 'sucursal
                etiqueta = etiqueta + CStr(Equipos_ds.Tables("Equipo").Rows(i).Item("Cat2_equipo_id")) + "-" 'id del subtipo de equipo (categoria)
                etiqueta = etiqueta + CStr(Equipos_ds.Tables("Equipo").Rows(i).Item("Cliente_suc_sector_denominacion")) + "-" 'sector
                etiqueta = etiqueta + CStr(Equipos_ds.Tables("Equipo").Rows(i).Item("Equipo_denominacion")) 'equipo
                Equipos_ds.Tables("Equipo").Rows(i).Item("etiqueta") = etiqueta
                i = i + 1
            End While


        End If
    End Sub


    Public Sub recuperar_equipos()
        Equipos_ds.Tables("Equipo").Rows.Clear()
        If SucxClie_id <> 0 Then
            SucxClie_id = cb_sucursal.SelectedValue

            'recupera todos los equipos de la sucursal seleccionada cuyo estado Equipo_activo = "si"
            Dim ds_equipos As DataSet = daequipo.Equipo_buscar_x_sucursal(SucxClie_id)
            If ds_equipos.Tables(0).Rows.Count <> 0 Then
                Equipos_ds.Tables("Equipo").Merge(ds_equipos.Tables(0))
                'DG_clientes.DataSource = ds_equipos.Tables(0)

                'modifico el campo etiqueta: necesito que traiga los id de todas las tablas q se vinculan
                etiqueta_grid_generar()
            Else
                MessageBox.Show("no hay equipos para la sucursal: " + cb_sucursal.Text + ".", "Sistema de Gestión.", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub cb_sucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_sucursal.SelectedIndexChanged
        recuperar_equipos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DG_clientes.Rows.Count <> 0 Then
            Mantenimiento_config_alta.Close()
            Dim equipo_id As Integer = DG_clientes.CurrentRow.Cells("EquipoidDataGridViewTextBoxColumn").Value
            Mantenimiento_config_alta.Equipo_id = equipo_id
            Me.WindowState = FormWindowState.Minimized
            Mantenimiento_config_alta.Show()
        Else
            MessageBox.Show("Error, debe seleccionar un equipo para continuar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DG_clientes.Rows.Count <> 0 Then
            'Dim pregunta As String = "no"
            If MsgBox("¿Esta seguro que quiere eliminar definitivamente el item seleccionado, etiqueta: " + CStr(DG_clientes.CurrentRow.Cells("EtiquetaDataGridViewTextBoxColumn").Value) + "?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                Dim equipo_id As Integer = DG_clientes.CurrentRow.Cells("EquipoidDataGridViewTextBoxColumn").Value
                'aqui lo borro pero logicamente. por eso necesito un campo estado. como el de la tabla mantenimiento
                daequipo.Equipo_eliminar(equipo_id)
                'tengo q reflejar los cambios en el gridview
                recuperar_equipos()

            End If
        Else
            MessageBox.Show("Error, debe seleccionar un equipo del listado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Sucursales_sector_modificar.Close()
        Sucursales_sector_modificar.SucxClie_id = cb_sucursal.SelectedValue
        Sucursales_sector_modificar.txt_cliente.Text = txt_cliente.Text
        Sucursales_sector_modificar.txt_sucursal.Text = cb_sucursal.Text
        Sucursales_sector_modificar.Show()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "Categoria", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        EquipoBindingSource.Filter = Filtro
        If DG_clientes.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(etiqueta, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            EquipoBindingSource.Filter = Filtro
            If DG_clientes.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(Cliente_suc_sector_descripcion, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
                EquipoBindingSource.Filter = Filtro
                If DG_clientes.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(Equipo_descripcion, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
                    EquipoBindingSource.Filter = Filtro
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DG_clientes.Rows.Count <> 0 Then
            Equipo_QR_msj.Close()
            Equipo_QR_msj.Show()
        End If
    End Sub
    Private Sub crear_qr()
        ''se crea a partir de una cadena que se toma del TextBox1
        'If RichTextBox1.Text <> "" Then
        '    Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'inicializa el generador

        '    GENERADOR.Format = BarcodeFormat.QR_CODE

        '    Try
        '        Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(RichTextBox1.Text), PictureBox1.Width, PictureBox1.Height)
        '        PictureBox1.Image = IMAGEN
        '    Catch ex As Exception
        '        MessageBox.Show("Error, el código QR no se generó correctamente. Intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.Close()
        '    End Try
        'End If
    End Sub




#Region "Generacion QR"
    Public Sub generar_qr_consulta_Actual() 'es decir toda lo que se este mostrando en el gridview
        Try
            If DG_clientes.Rows.Count <> 0 Then
                Equipos_ds.Tables("Equipo_QR").Rows.Clear()
                'Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'inicializa el generador
                Dim GENERADOR As BarcodeWriter = New BarcodeWriter With {
        .Format = BarcodeFormat.QR_CODE,
                .Options = New QrCodeEncodingOptions With {
                    .Width = 1000,
                    .Height = 1000,
                    .PureBarcode = True,
                    .Margin = 0}
                }



                'GENERADOR.Format = BarcodeFormat.QR_CODE

                Dim j As Integer = 0
                While j < DG_clientes.Rows.Count
                    Dim cadena As String = "" 'esta es la cadena que se convierte en QR
                    cadena = "Cliente: " + txt_cliente.Text + "."
                    cadena += Environment.NewLine 'esto hace un salto de linea.
                    cadena = cadena + "Sucursal: " + cb_sucursal.Text + "."
                    cadena += Environment.NewLine
                    cadena = cadena + "Sector: " + CStr(DG_clientes.Rows(j).Cells("Cliente_suc_sector_descripcion").Value) + "."
                    cadena += Environment.NewLine
                    cadena = cadena + "Equipo: " + CStr(DG_clientes.Rows(j).Cells("EquipodescripcionDataGridViewTextBoxColumn").Value) + "."
                    'recupero los atributos (caracteristicas del equipo.)
                    '*****************************************************************************
                    Dim equipo_id As Integer = DG_clientes.Rows(j).Cells("EquipoidDataGridViewTextBoxColumn").Value
                    Dim ds_info As DataSet = daequipo.Equipo_recuperar_info(equipo_id)
                    If ds_info.Tables(1).Rows.Count <> 0 Then
                        cadena += Environment.NewLine
                        cadena = cadena + "Atributos:"
                        'tiene atributos
                        Dim i As Integer = 0
                        While i < ds_info.Tables(1).Rows.Count
                            cadena += Environment.NewLine
                            cadena = cadena + "  -" + CStr(ds_info.Tables(1).Rows(i).Item("Cat2_caract_atributo")) + ": " + CStr(ds_info.Tables(1).Rows(i).Item("Atributo_detalle_valor")) + "."
                            i = i + 1
                        End While
                    End If
                    '*****************************************************************************
                    'Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(DG_clientes.Rows(j).Cells("EtiquetaDataGridViewTextBoxColumn").Value), 300, 300)
                    Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(cadena))
                    PictureBox1.Image = IMAGEN
                    Clipboard.SetDataObject(Me.PictureBox1.Image)
                    Dim data As IDataObject
                    data = Clipboard.GetDataObject
                    Dim bmap As Bitmap
                    If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                        bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
                        Me.PictureBox1.Image = bmap
                    End If

                    '///////////////////////////////////////////
                    Dim foto_byte As Byte()
                    foto_byte = Nothing
                    Dim ms = New MemoryStream
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    foto_byte = ms.GetBuffer
                    ms.Flush()
                    '//////////////////////////////////////////
                    Dim fila As DataRow = Equipos_ds.Tables("Equipo_QR").NewRow
                    fila("etiqueta") = DG_clientes.Rows(j).Cells("EtiquetaDataGridViewTextBoxColumn").Value
                    fila("foto") = foto_byte
                    'PictureBox1.Image = IMAGEN
                    Equipos_ds.Tables("Equipo_QR").Rows.Add(fila)



                    j = j + 1
                End While
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                ' Asigno el reporte
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Equipo_QR\CR_Equipo_QR.rpt")
                CrReport.Database.Tables("Equipo_QR").SetDataSource(Equipos_ds.Tables("Equipo_QR"))
                'CrReport.Database.Tables("Sucursal").SetDataSource(Facturacion_ds_report.Tables("Sucursal"))
                'CrReport.Database.Tables("Empresa").SetDataSource(Facturacion_ds_report.Tables("Empresa"))
                'CrReport.Database.Tables("venta").SetDataSource(Facturacion_ds_report.Tables("venta"))
                'CrReport.Database.Tables("Producto_agregado").SetDataSource(Facturacion_ds_report.Tables("Producto_agregado"))
                'CrReport.Database.Tables("Totales_aplicados").SetDataSource(Facturacion_ds_report.Tables("Totales_aplicados"))
                Dim visor As New Facturacion_report_show
                visor.CrystalReportViewer1.ReportSource = CrReport
                'Facturacion_report_show.Text = "Comprobante Nº: " + CStr(numerofactura) + " - Imprimir."
                visor.Text = "Etiquetas generadas."
                visor.Show()
            Else
                MessageBox.Show("Error, no hay equipos en la consulta actual.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error, el código QR no se generó correctamente. Intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.Close()
        End Try
        Msj_espere_reporte.Close()
    End Sub
    Public Sub generar_qr_solo_seleccionados()
        Try
            If DG_clientes.Rows.Count <> 0 Then
                Equipos_ds.Tables("Equipo_QR").Rows.Clear()
                'inicializa el generador
                Dim GENERADOR As BarcodeWriter = New BarcodeWriter With {
        .Format = BarcodeFormat.QR_CODE,
                .Options = New QrCodeEncodingOptions With {
                    .Width = 1000,
                    .Height = 1000,
                    .PureBarcode = True,
                    .Margin = 0}
                }

                'GENERADOR.Format = BarcodeFormat.QR_CODE
                'GENERADOR.Options = New QrCode.QrCodeEncodingOptions


                Dim cont_select As Integer = 0
                Dim j As Integer = 0
                While j < DG_clientes.Rows.Count

                    If DG_clientes.Rows(j).Cells("item").Value = True Then
                        cont_select = cont_select + 1
                        Dim cadena As String = "" 'esta es la cadena que se convierte en QR
                        cadena = "Cliente: " + txt_cliente.Text + "."
                        cadena += Environment.NewLine 'esto hace un salto de linea.
                        cadena = cadena + "Sucursal: " + cb_sucursal.Text + "."
                        cadena += Environment.NewLine
                        cadena = cadena + "Sector: " + CStr(DG_clientes.Rows(j).Cells("Cliente_suc_sector_descripcion").Value) + "."
                        cadena += Environment.NewLine
                        cadena = cadena + "Equipo: " + CStr(DG_clientes.Rows(j).Cells("EquipodescripcionDataGridViewTextBoxColumn").Value) + "."
                        'recupero los atributos (caracteristicas del equipo.)
                        '*****************************************************************************
                        Dim equipo_id As Integer = DG_clientes.Rows(j).Cells("EquipoidDataGridViewTextBoxColumn").Value
                        Dim ds_info As DataSet = daequipo.Equipo_recuperar_info(equipo_id)
                        If ds_info.Tables(1).Rows.Count <> 0 Then
                            cadena += Environment.NewLine
                            cadena = cadena + "Atributos:"
                            'tiene atributos
                            Dim i As Integer = 0
                            While i < ds_info.Tables(1).Rows.Count
                                cadena += Environment.NewLine
                                cadena = cadena + "  -" + CStr(ds_info.Tables(1).Rows(i).Item("Cat2_caract_atributo")) + ": " + CStr(ds_info.Tables(1).Rows(i).Item("Atributo_detalle_valor")) + "."
                                i = i + 1
                            End While
                        End If
                        '*****************************************************************************
                        'Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(DG_clientes.Rows(j).Cells("EtiquetaDataGridViewTextBoxColumn").Value), 300, 300)
                        Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(cadena))
                        PictureBox1.Image = IMAGEN
                        Clipboard.SetDataObject(Me.PictureBox1.Image)
                        Dim data As IDataObject
                        data = Clipboard.GetDataObject
                        Dim bmap As Bitmap
                        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
                            Me.PictureBox1.Image = bmap
                        End If

                        '///////////////////////////////////////////
                        Dim foto_byte As Byte()
                        foto_byte = Nothing
                        Dim ms = New MemoryStream
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        foto_byte = ms.GetBuffer
                        ms.Flush()
                        '//////////////////////////////////////////
                        Dim fila As DataRow = Equipos_ds.Tables("Equipo_QR").NewRow
                        fila("etiqueta") = DG_clientes.Rows(j).Cells("EtiquetaDataGridViewTextBoxColumn").Value
                        fila("foto") = foto_byte
                        'PictureBox1.Image = IMAGEN
                        Equipos_ds.Tables("Equipo_QR").Rows.Add(fila)

                    End If

                    j = j + 1
                End While
                If cont_select > 0 Then
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    ' Asigno el reporte
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Equipo_QR\CR_Equipo_QR.rpt")
                    CrReport.Database.Tables("Equipo_QR").SetDataSource(Equipos_ds.Tables("Equipo_QR"))
                    'CrReport.Database.Tables("Sucursal").SetDataSource(Facturacion_ds_report.Tables("Sucursal"))
                    'CrReport.Database.Tables("Empresa").SetDataSource(Facturacion_ds_report.Tables("Empresa"))
                    'CrReport.Database.Tables("venta").SetDataSource(Facturacion_ds_report.Tables("venta"))
                    'CrReport.Database.Tables("Producto_agregado").SetDataSource(Facturacion_ds_report.Tables("Producto_agregado"))
                    'CrReport.Database.Tables("Totales_aplicados").SetDataSource(Facturacion_ds_report.Tables("Totales_aplicados"))
                    Dim visor As New Facturacion_report_show
                    visor.CrystalReportViewer1.ReportSource = CrReport
                    'Facturacion_report_show.Text = "Comprobante Nº: " + CStr(numerofactura) + " - Imprimir."
                    visor.Text = "Etiquetas generadas."
                    visor.Show()
                Else
                    MessageBox.Show("Debe seleccionar un item para generar el código.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error, el código QR no se generó correctamente. Intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.Close()
        End Try

        Msj_espere_reporte.Close()

    End Sub

#End Region

End Class