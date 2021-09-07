Public Class Venta_detalle


    Public Venta_consulta As New DataSet

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim ds_cliente As DataSet = DAcliente.Informe_Cliente
        If Venta_consulta.Tables(0).Rows.Count > 0 Then
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_Informe_Venta_detalle_prod.rpt")
            CrReport.Database.Tables("Venta_consulta").SetDataSource(Venta_consulta.Tables(0))
            Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
            Informe_Mostrar.Show()
        End If

    End Sub
End Class