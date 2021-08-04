Public Class Equipo_QR_msj

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            'solo items seleccionados
            'Equipo_consulta.generar_qr_solo_seleccionados()
            Msj_espere_reporte.procedencia = "Equipo_consulta_generar_qr_solo_seleccionados"
            Msj_espere_reporte.Show()
        Else
            'toda los items de la grilla.
            'Equipo_consulta.generar_qr_consulta_Actual()
            Msj_espere_reporte.procedencia = "Equipo_consulta.generar_qr_consulta_Actual"
            Msj_espere_reporte.Show()
        End If
        Me.Close()
    End Sub
End Class