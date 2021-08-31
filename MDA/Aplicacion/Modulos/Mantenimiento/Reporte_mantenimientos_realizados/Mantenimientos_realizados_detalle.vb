Public Class Mantenimientos_realizados_detalle

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        generar_reporte()
    End Sub
    Dim Mant_2_ds As New MANT_2_ds
    Dim DAventa As New Datos.Venta

    Public Mantenimiento_id As Integer
    Public Mant_realizados_id As Integer
    Public Equipo_id As Integer

    Public Sub generar_reporte()
        '//////////EMPRESA/////////////////////////////
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            MANT_2_ds.Tables("Empresa").Rows.Clear()
            MANT_2_ds.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If
        '/////////////////////////////////////////////

        Mant_2_ds.Tables("Report_mantenimiento").Rows.Clear()
        'MANT_2_ds1.Tables("Report_mantenimiento").Rows.Clear()
        Dim filass As DataRow = Mant_2_ds.Tables("Report_mantenimiento").NewRow
        filass("id_revision") = 0
        filass("cliente") = txt_cliente.Text + ", Suc: " + txt_sucursal.Text
        filass("direccion") = "" 'no tengo
        filass("Sucursal") = txt_sucursal.Text
        filass("fecha") = Today.Date
        filass("diagnostico_previo") = ""
        filass("Equipo") = ""
        Mant_2_ds.Tables("Report_mantenimiento").Rows.Add(filass)

        'cargo el dataset para el reporte
        Dim i As Integer = 0
        Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Clear()

        Dim fila As DataRow = Ds_mant_realizados.Tables("reporte_mant_listados").NewRow
        fila("Equipo") = txt_equipo.Text
        fila("Sector") = txt_sector.Text
        fila("Etiqueta") = txt_etiqueta.Text
        fila("Tipo_mantenimiento") = txt_mantenimiento.Text
        fila("Mantenimiento_id") = Mantenimiento_id
        fila("Mant_realizados_id") = Mant_realizados_id
        fila("Equipo_id") = Equipo_id
        fila("periodicidad") = txt_periodicidad.Text
        fila("Fecha") = txt_fecha.Text
        fila("Categoria") = txt_categoria.Text
        Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Add(fila)


        'ahora cargo las tareas
        Ds_mant_realizados.Tables("reporte_tares").Rows.Clear()
        Dim j As Integer = 0

        While i < DataGridView1.Rows.Count
            Dim fila2 As DataRow = Ds_mant_realizados.Tables("reporte_tares").NewRow
            fila2("Mant_realizados_id") = Mant_realizados_id
            fila2("Tareas") = DataGridView1.Rows(i).Cells("TareasDataGridViewTextBoxColumn").Value
            fila2("Valor") = DataGridView1.Rows(i).Cells("ValorDataGridViewTextBoxColumn").Value
            Ds_mant_realizados.Tables("reporte_tares").Rows.Add(fila2)
            i = i + 1
        End While

        If Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Count <> 0 Then
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Mantenimiento\Reporte_mantenimientos_realizados\CR_mant_realizado_consulta.rpt")

            CrReport.Database.Tables("Empresa").SetDataSource(Mant_2_ds.Tables("Empresa"))
            CrReport.Database.Tables("Revision").SetDataSource(Mant_2_ds.Tables("Report_mantenimiento"))
            CrReport.Database.Tables("reporte_mant_listados").SetDataSource(Ds_mant_realizados.Tables("reporte_mant_listados"))
            CrReport.Database.Tables("reporte_tares").SetDataSource(Ds_mant_realizados.Tables("reporte_tares"))


            Dim visor As New Facturacion_report_show
            visor.CrystalReportViewer1.ReportSource = CrReport

            visor.Text = "Mantenimientos realizados. Imprimir."
            visor.Show()
        Else

        End If


    End Sub
End Class