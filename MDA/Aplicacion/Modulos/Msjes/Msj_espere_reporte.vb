Public Class Msj_espere_reporte
    Public procedencia As String = ""


    Private Sub Msj_espere_reporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub



    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label2.Text = ProgressBar1.Value & (" %")
        If ProgressBar1.Value = 70 Then
            If procedencia = "Equipo_consulta_generar_qr_solo_seleccionados" Then
                Equipo_consulta.generar_qr_solo_seleccionados()
                'Me.Close()
            End If
            If procedencia = "Equipo_consulta.generar_qr_consulta_Actual" Then
                Equipo_consulta.generar_qr_consulta_Actual()
                'Me.Close()
            End If
        End If
    End Sub
End Class