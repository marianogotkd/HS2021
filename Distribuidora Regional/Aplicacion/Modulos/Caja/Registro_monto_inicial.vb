Public Class Registro_monto_inicial

    Dim APcaja As New Aplicacion.Caja
    Dim DAcaja As New Datos.Caja

    Private Sub Registro_monto_inicial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Habilitar()
        Me.Show()
        tx_parcial.Focus()
    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Registro_inicio_cierre.Show()
        Me.Close()
    End Sub

    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        tx_parcial.Text = CDec(tx_parcial.Text)
        DAcaja.Caja_abrir(Now, 1, tx_parcial.Text, CDec(0), CDec(0), Inicio.USU_id)

        MessageBox.Show("Caja abierta correctamente por el usuario:" & LB_nombre_usu.Text, "Sistema de Gestion.")

        APcaja.Caja_Validar()
        Me.Close()

    End Sub

    Private Sub TX_parcial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_parcial.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not tx_parcial.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tx_parcial_TextChanged(sender As System.Object, e As System.EventArgs) Handles tx_parcial.TextChanged
        Habilitar()
    End Sub

    Public Sub Habilitar()
        If tx_parcial.Text <> Nothing Then
            BO_guardar.Enabled = True
        Else
            BO_guardar.Enabled = False
        End If

    End Sub


End Class