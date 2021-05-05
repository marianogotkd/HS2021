Public Class Mantenimiento_config_alta
    Public Equipo_id As Integer 'me lo envia el formulario "Equipo_consulta.vb"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Mantenimiento_config_agregar.Close()

        Mantenimiento_config_agregar.Cat2_equipo_id = 1

        Mantenimiento_config_agregar.Show()
    End Sub
End Class