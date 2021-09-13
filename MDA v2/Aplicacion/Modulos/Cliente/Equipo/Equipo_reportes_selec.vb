Public Class Equipo_reportes_selec

    Public Cli_id As Integer
    Dim dacliete As New Datos.Cliente
    Dim DAsector As New Datos.Sucursal_sector
    Dim DAventa As New Datos.Venta
    Dim DAequipo As New Datos.Equipo
    Private Sub Equipo_reportes_selec_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_info_cliente()
    End Sub

    Private Sub recuperar_info_cliente()
        Dim ds_clie As DataSet = dacliete.Cliente_obtener_info(Cli_id)

        If ds_clie.Tables(0).Rows.Count <> 0 Then
            txt_cliente.Text = ds_clie.Tables(0).Rows(0).Item("CLI_Fan")
            txt_cliente_id.Text = ds_clie.Tables(0).Rows(0).Item("CLI_id")
            'txt_cliente.ReadOnly = True
        End If
        If ds_clie.Tables(3).Rows.Count <> 0 Then
            cb_sucursal.DataSource = ds_clie.Tables(3) 'contiene las sucursales cuyo SucxClie_estado= 'ACTIVO'
            cb_sucursal.DisplayMember = "SucxClie_nombre"
            cb_sucursal.ValueMember = "SucxClie_id"
            'ahora cargo en el gridview de abajo los sectores existentes para esa sucursal
            SucxClie_id = cb_sucursal.SelectedValue
            recuperar_sectores()
        End If
    End Sub
    Public SucxClie_id

    Public Sub recuperar_sectores()
        cb_sector.DataSource = Nothing
        Dim ds_sector As DataSet = DAsector.Cliente_suc_sector_recuperar_todos(SucxClie_id)
        If ds_sector.Tables(0).Rows.Count <> 0 Then
            cb_sector.DataSource = ds_sector.Tables(0)
            cb_sector.DisplayMember = "Cliente_suc_sector_descripcion"
            cb_sector.ValueMember = "Cliente_suc_sector_id"
        End If
    End Sub

    Private Sub cb_sucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_sucursal.SelectedIndexChanged
        cb_sector.DataSource = Nothing
        Try
            SucxClie_id = cb_sucursal.SelectedValue
            recuperar_sectores()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If rb_todos_suc.Checked = True Then
            reporte()
        Else
            reporte_2()
        End If


    End Sub

    Dim Equipos_ds As New Equipos_ds
    Private Sub reporte_2()
        Try


            Equipos_ds.Tables("Equipo").Rows.Clear()
            Equipos_ds.Tables("CR_equipo_info").Rows.Clear()
            Equipos_ds.Tables("CR_equipo_info_caracteristicas").Rows.Clear()

            '////////EMPRESA///////////
            Dim usuario_id As String
            usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
            Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
            If ds_usuario.Tables(1).Rows.Count <> 0 Then
                Equipos_ds.Tables("Empresa").Rows.Clear()
                Equipos_ds.Tables("Empresa").Merge(ds_usuario.Tables(1))
            End If
            '////////////////////////////////////////////////////////


            If rb_solo_sector.Checked = True Then
                'traer todos los equipos ordenados por sector de una sucursal.
                Dim ds_equipos As DataSet = DAequipo.Equipo_buscar_x_sector(cb_sector.SelectedValue)
                If ds_equipos.Tables(0).Rows.Count <> 0 Then
                    Dim ii As Integer = 0
                    While ii < ds_equipos.Tables(0).Rows.Count
                        Dim fila_a As DataRow = Equipos_ds.Tables("CR_equipo_info").NewRow
                        fila_a("Cliente") = txt_cliente.Text
                        fila_a("Sucursal") = cb_sucursal.Text
                        fila_a("Sector") = ds_equipos.Tables(0).Rows(ii).Item("Sector").ToString
                        fila_a("Equipo_descripcion") = ds_equipos.Tables(0).Rows(ii).Item("Equipo_descripcion").ToString
                        fila_a("Equipo_Denominacion") = ds_equipos.Tables(0).Rows(ii).Item("Equipo_denominacion").ToString
                        fila_a("Categoria_tipo") = ds_equipos.Tables(0).Rows(ii).Item("Categoria_tipo").ToString
                        fila_a("Categoria_subtipo") = ds_equipos.Tables(0).Rows(ii).Item("Categoria_subtipo").ToString
                        fila_a("Equipo_id") = ds_equipos.Tables(0).Rows(ii).Item("Equipo_id")
                        Equipos_ds.Tables("CR_equipo_info").Rows.Add(fila_a)
                        ii = ii + 1
                    End While
                End If
            End If

            If rb_detalles_no.Checked = True Then
                If Equipos_ds.Tables("CR_equipo_info").Rows.Count <> 0 Then
                    'como no lleva detalles, procedemos directamente a generar el reporte.
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Reporte\CR_equipo_todos_no_detalle.rpt")
                    CrReport.Database.Tables("Empresa").SetDataSource(Equipos_ds.Tables("Empresa"))
                    CrReport.Database.Tables("CR_equipo_info").SetDataSource(Equipos_ds.Tables("CR_equipo_info"))
                    'CrReport.Database.Tables("CR_equipo_info_caracteristicas").SetDataSource(Equipos_ds.Tables("CR_equipo_info_caracteristicas"))
                    'CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))
                    Dim visor As New Facturacion_report_show
                    visor.CrystalReportViewer1.ReportSource = CrReport
                    visor.Text = "Reporte de Equipos ordenados por Sector. Imprimir."
                    visor.Show()
                Else
                    MessageBox.Show("No hay equipos disponibles para listar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                

            Else
                'ahora recupero los atributos de cada equipo.
                Dim ds_equipos As DataSet = DAequipo.Equipo_buscar_x_sector(cb_sector.SelectedValue)
                If ds_equipos.Tables(0).Rows.Count <> 0 Then
                    Dim i As Integer = 0
                    While i < ds_equipos.Tables(0).Rows.Count
                        Dim Equipo_id As Integer = ds_equipos.Tables(0).Rows(i).Item("Equipo_id")
                        Dim ds_atributos As DataSet = DAequipo.Equipo_atributo_buscar(Equipo_id)
                        If ds_atributos.Tables(0).Rows.Count <> 0 Then
                            Dim j As Integer = 0
                            While j < ds_atributos.Tables(0).Rows.Count
                                Dim fila As DataRow = Equipos_ds.CR_equipo_info_caracteristicas.NewRow
                                fila("Caracteristicas") = ds_atributos.Tables(0).Rows(j).Item("Cat2_caract_atributo").ToString
                                fila("Valor") = ds_atributos.Tables(0).Rows(j).Item("Atributo_detalle_valor").ToString
                                fila("Equipo_id") = Equipo_id
                                Equipos_ds.Tables("CR_equipo_info_caracteristicas").Rows.Add(fila)
                                j = j + 1
                            End While
                        End If
                        i = i + 1
                    End While
                End If

                If (Equipos_ds.Tables("CR_equipo_info").Rows.Count <> 0) And (Equipos_ds.Tables("CR_equipo_info_caracteristicas").Rows.Count <> 0) Then
                    'procedemos a generar el reporte con los detalles de atributos.
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Reporte\CR_equipo_todos_si_detalle.rpt")
                    CrReport.Database.Tables("Empresa").SetDataSource(Equipos_ds.Tables("Empresa"))
                    CrReport.Database.Tables("CR_equipo_info").SetDataSource(Equipos_ds.Tables("CR_equipo_info"))
                    CrReport.Database.Tables("CR_equipo_info_caracteristicas").SetDataSource(Equipos_ds.Tables("CR_equipo_info_caracteristicas"))
                    'CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))
                    Dim visor As New Facturacion_report_show
                    visor.CrystalReportViewer1.ReportSource = CrReport
                    visor.Text = "Reporte de Equipos ordenados por Sector. Imprimir."
                    visor.Show()
                Else
                    MessageBox.Show("No hay equipos disponibles para listar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If



            'Dim i As Integer = 0
            'While i < dg_atributos.Rows.Count
            '    Dim fila2 As DataRow = Equipos_ds.Tables("CR_equipo_info_caracteristicas").NewRow
            '    fila2("Caracteristicas") = dg_atributos.Rows(i).Cells("Cat2_caract_atributo").Value
            '    fila2("Valor") = dg_atributos.Rows(i).Cells("Atributo_detalle_valor").Value
            '    fila2("Equipo_id") = Equipo_id
            '    Equipos_ds.Tables("CR_equipo_info_caracteristicas").Rows.Add(fila2)
            '    i = i + 1
            'End While

            'Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Reporte\CR_equipo_info.rpt")
            'CrReport.Database.Tables("Empresa").SetDataSource(Equipos_ds.Tables("Empresa"))
            'CrReport.Database.Tables("CR_equipo_info").SetDataSource(Equipos_ds.Tables("CR_equipo_info"))
            'CrReport.Database.Tables("CR_equipo_info_caracteristicas").SetDataSource(Equipos_ds.Tables("CR_equipo_info_caracteristicas"))
            ''CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))

            'Dim visor As New Facturacion_report_show
            'visor.CrystalReportViewer1.ReportSource = CrReport

            'visor.Text = "Reporte Equipo. Imprimir."
            'visor.Show()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub reporte()
        Try


            Equipos_ds.Tables("Equipo").Rows.Clear()
            Equipos_ds.Tables("CR_equipo_info").Rows.Clear()
            Equipos_ds.Tables("CR_equipo_info_caracteristicas").Rows.Clear()

            '////////EMPRESA///////////
            Dim usuario_id As String
            usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
            Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
            If ds_usuario.Tables(1).Rows.Count <> 0 Then
                Equipos_ds.Tables("Empresa").Rows.Clear()
                Equipos_ds.Tables("Empresa").Merge(ds_usuario.Tables(1))
            End If
            '////////////////////////////////////////////////////////


            If rb_todos_suc.Checked = True Then
                'traer todos los equipos ordenados por sector de una sucursal.
                Dim ds_equipos As DataSet = DAequipo.Equipo_obtener_todos_de_sucursal(cb_sucursal.SelectedValue)
                If ds_equipos.Tables(0).Rows.Count <> 0 Then
                    Dim ii As Integer = 0
                    While ii < ds_equipos.Tables(0).Rows.Count
                        Dim fila_a As DataRow = Equipos_ds.Tables("CR_equipo_info").NewRow
                        fila_a("Cliente") = txt_cliente.Text
                        fila_a("Sucursal") = cb_sucursal.Text
                        fila_a("Sector") = ds_equipos.Tables(0).Rows(ii).Item("Sector").ToString
                        fila_a("Equipo_descripcion") = ds_equipos.Tables(0).Rows(ii).Item("Equipo_descripcion").ToString
                        fila_a("Equipo_Denominacion") = ds_equipos.Tables(0).Rows(ii).Item("Equipo_denominacion").ToString
                        fila_a("Categoria_tipo") = ds_equipos.Tables(0).Rows(ii).Item("Categoria_tipo").ToString
                        fila_a("Categoria_subtipo") = ds_equipos.Tables(0).Rows(ii).Item("Categoria_subtipo").ToString
                        fila_a("Equipo_id") = ds_equipos.Tables(0).Rows(ii).Item("Equipo_id")
                        Equipos_ds.Tables("CR_equipo_info").Rows.Add(fila_a)
                        ii = ii + 1
                    End While
                End If
            End If

            If rb_detalles_no.Checked = True Then
                If Equipos_ds.Tables("CR_equipo_info").Rows.Count <> 0 Then
                    'como no lleva detalles, procedemos directamente a generar el reporte.
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Reporte\CR_equipo_todos_no_detalle.rpt")
                    CrReport.Database.Tables("Empresa").SetDataSource(Equipos_ds.Tables("Empresa"))
                    CrReport.Database.Tables("CR_equipo_info").SetDataSource(Equipos_ds.Tables("CR_equipo_info"))
                    'CrReport.Database.Tables("CR_equipo_info_caracteristicas").SetDataSource(Equipos_ds.Tables("CR_equipo_info_caracteristicas"))
                    'CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))
                    Dim visor As New Facturacion_report_show
                    visor.CrystalReportViewer1.ReportSource = CrReport
                    visor.Text = "Reporte de Equipos ordenados por Sector. Imprimir."
                    visor.Show()
                Else
                    MessageBox.Show("No hay equipos disponibles para listar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                

            Else
                'ahora recupero los atributos de cada equipo.
                Dim ds_equipos As DataSet = DAequipo.Equipo_obtener_todos_de_sucursal(cb_sucursal.SelectedValue)
                If ds_equipos.Tables(0).Rows.Count <> 0 Then
                    Dim i As Integer = 0
                    While i < ds_equipos.Tables(0).Rows.Count
                        Dim Equipo_id As Integer = ds_equipos.Tables(0).Rows(i).Item("Equipo_id")
                        Dim ds_atributos As DataSet = DAequipo.Equipo_atributo_buscar(Equipo_id)
                        If ds_atributos.Tables(0).Rows.Count <> 0 Then
                            Dim j As Integer = 0
                            While j < ds_atributos.Tables(0).Rows.Count
                                Dim fila As DataRow = Equipos_ds.CR_equipo_info_caracteristicas.NewRow
                                fila("Caracteristicas") = ds_atributos.Tables(0).Rows(j).Item("Cat2_caract_atributo").ToString
                                fila("Valor") = ds_atributos.Tables(0).Rows(j).Item("Atributo_detalle_valor").ToString
                                fila("Equipo_id") = Equipo_id
                                Equipos_ds.Tables("CR_equipo_info_caracteristicas").Rows.Add(fila)
                                j = j + 1
                            End While
                        End If
                        i = i + 1
                    End While
                End If
                If (Equipos_ds.Tables("CR_equipo_info").Rows.Count <> 0) And (Equipos_ds.Tables("CR_equipo_info_caracteristicas").Rows.Count <> 0) Then
                    'procedemos a generar el reporte con los detalles de atributos.
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Reporte\CR_equipo_todos_si_detalle.rpt")
                    CrReport.Database.Tables("Empresa").SetDataSource(Equipos_ds.Tables("Empresa"))
                    CrReport.Database.Tables("CR_equipo_info").SetDataSource(Equipos_ds.Tables("CR_equipo_info"))
                    CrReport.Database.Tables("CR_equipo_info_caracteristicas").SetDataSource(Equipos_ds.Tables("CR_equipo_info_caracteristicas"))
                    'CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))
                    Dim visor As New Facturacion_report_show
                    visor.CrystalReportViewer1.ReportSource = CrReport
                    visor.Text = "Reporte de Equipos ordenados por Sector. Imprimir."
                    visor.Show()
                Else
                    MessageBox.Show("No hay equipos disponibles para listar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                
            End If



            'Dim i As Integer = 0
            'While i < dg_atributos.Rows.Count
            '    Dim fila2 As DataRow = Equipos_ds.Tables("CR_equipo_info_caracteristicas").NewRow
            '    fila2("Caracteristicas") = dg_atributos.Rows(i).Cells("Cat2_caract_atributo").Value
            '    fila2("Valor") = dg_atributos.Rows(i).Cells("Atributo_detalle_valor").Value
            '    fila2("Equipo_id") = Equipo_id
            '    Equipos_ds.Tables("CR_equipo_info_caracteristicas").Rows.Add(fila2)
            '    i = i + 1
            'End While

            'Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Reporte\CR_equipo_info.rpt")
            'CrReport.Database.Tables("Empresa").SetDataSource(Equipos_ds.Tables("Empresa"))
            'CrReport.Database.Tables("CR_equipo_info").SetDataSource(Equipos_ds.Tables("CR_equipo_info"))
            'CrReport.Database.Tables("CR_equipo_info_caracteristicas").SetDataSource(Equipos_ds.Tables("CR_equipo_info_caracteristicas"))
            ''CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))

            'Dim visor As New Facturacion_report_show
            'visor.CrystalReportViewer1.ReportSource = CrReport

            'visor.Text = "Reporte Equipo. Imprimir."
            'visor.Show()

        Catch ex As Exception

        End Try

    End Sub
End Class