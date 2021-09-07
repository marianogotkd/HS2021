Public Class Devolucion_consulta
    Dim DAdevoluciones As New Datos.Devolucion
    Private Sub Devolucion_consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Obtener_Todos()


    End Sub

    Private Sub BO_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
        Dim DS2 As New DataSet
        DS2 = DAdevoluciones.Devolucion_obtener_Producto(tx_cod_prod.Text)
        If DS2.Tables(0).Rows.Count <> 0 Then
            DG_dev_consulta.DataSource = DS2.Tables(0)
        Else
            MessageBox.Show("No existen Devoluciones Realizadas", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If
    End Sub


    Public Sub Obtener_Todos()
        Dim DS As New DataSet
        DS = DAdevoluciones.Devolucion_obtener_todo
        If DS.Tables(0).Rows.Count <> 0 Then
            DG_dev_consulta.DataSource = DS.Tables(0)
        Else
            MessageBox.Show("No existen Devoluciones Realizadas", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Obtener_Todos()

    End Sub

    Private Sub Bo_informe_dev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_informe_dev.Click
        If Me.DG_dev_consulta.CurrentRow IsNot Nothing Then
            Dim Dev_codigo As String = DG_dev_consulta.CurrentRow.Cells("Dev_codigo").Value
            Dim ds_informe As DataSet = DAdevoluciones.Devolucion_informe(Dev_codigo)
            If ds_informe.Tables(0).Rows.Count > 0 Then
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Informe Regional\CR_Informe_devolucion.rpt")

                CrReport.Database.Tables("Devolucion").SetDataSource(ds_informe.Tables(0))
               
                Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport

                Informe_Mostrar.Show()
            End If
        Else
            MessageBox.Show("Seleccione una devolucion", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If
    End Sub
End Class

