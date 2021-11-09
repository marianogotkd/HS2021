Public Class Equipo_historial_seleccionar_informe

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RB_informe_simple.Checked = True Then
            If RB_solo_seleccion.Checked = True Then
                Equipo_historial.reporte("seleccion") 'pasar "seleccion"
            Else
                Equipo_historial.reporte("todo") 'pasar "todo"
            End If
        Else
            If RB_solo_seleccion.Checked = True Then
                Equipo_historial.REPORTE_DETALLADO("seleccion") 'pasar "seleccion" 
            Else
                Equipo_historial.REPORTE_DETALLADO("todo") 'pasar "todo"
            End If
        End If
        Me.Close()
    End Sub
End Class