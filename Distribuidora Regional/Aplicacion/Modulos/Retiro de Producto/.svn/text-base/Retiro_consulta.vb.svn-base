Public Class Retiro_consulta
    Dim DAretiro As New Datos.Retiro

    Private Sub BO_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
        Buscar_codprod_nrolote()
    End Sub


    Private Sub Buscar_codprod_nrolote()
        If tx_cod_prod.Text <> "" And tx_cod_lote.Text <> "" Then

            Dim DS As New DataSet
            DS = DAretiro.Retiro_consulta(tx_cod_prod.Text, tx_cod_lote.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                If DS.Tables(0).Rows(0).Item(5) = "Retirado" Then
                    DG_retiro_consulta.DataSource = DS.Tables(0)
                Else
                    MessageBox.Show("El lote no fue retirado", "Sistema de Gestion.", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("No existe el lote o producto", "Sistema de Gestion.", MessageBoxButtons.OK)
            End If

        Else
            Consulta_obtenertodo()
        End If
    End Sub

    Public Sub Consulta_obtenertodo()
        Dim DS As New DataSet
        DS = DAretiro.Retiro_Consulta_todo()
        If DS.Tables(0).Rows.Count <> 0 Then
            If DS.Tables(0).Rows(0).Item(5) = "Retirado" Then
                DG_retiro_consulta.DataSource = DS.Tables(0)
            Else
                MessageBox.Show("No existen lotes retirados", "Sistema de Gestion.", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("No existen lotes retirados", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub tx_cod_lote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_cod_lote.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_codprod_nrolote()
        End If
    End Sub

  
    Private Sub Retiro_consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BO_Informe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Informe.Click

        If Me.DG_retiro_consulta.CurrentRow IsNot Nothing Then
            Dim retiro_codigo As String = DG_retiro_consulta.CurrentRow.Cells("RetirocodigoDataGridViewTextBoxColumn").Value
            Dim ds_informe As DataSet = DAretiro.Retiro_informe(retiro_codigo)
            If ds_informe.Tables(0).Rows.Count > 0 Then
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Informe Regional\CR_Informe_retiro.rpt")
                CrReport.Database.Tables("Retiro").SetDataSource(ds_informe.Tables(0))
                Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
                Informe_Mostrar.Show()
            End If
        Else
            MessageBox.Show("Seleccione un retiro", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If
    End Sub
End Class