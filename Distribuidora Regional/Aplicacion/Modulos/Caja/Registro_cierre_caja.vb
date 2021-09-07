Public Class Registro_cierre_caja
    Dim DAcaja As New Datos.Caja
    Dim APcaja As New Aplicacion.Caja

    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click

        'tx_parcial.Text = CDec(tx_parcial.Text)
        DAcaja.Caja_cierre(CDec(tx_total.Text), CDec(tx_neto.Text), Inicio.USU_id, Now)

        MessageBox.Show("Caja Cerrada correctamente por el usuario:" & LB_nombre_usu.Text, "Sistema de Gestion.")
        APcaja.Caja_Validar()
        Me.Close()

    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Registro_inicio_cierre.Show()
        Me.Close()
    End Sub
End Class