Public Class Reporte_msj

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rb_si.Checked = True Then
            Mantenimientos_realizados_consulta.generar_reporte("si")

        Else
            Mantenimientos_realizados_consulta.generar_reporte("no")
        End If
        Me.Close()
    End Sub


End Class