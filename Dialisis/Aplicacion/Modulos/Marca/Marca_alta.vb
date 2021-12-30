Public Class Marca_alta
    Dim DAmarca As New Datos.Marca
    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        guardar()
    End Sub

    Private Sub guardar()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta la Marca?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If tx_nom_marca.Text <> "" Then
                DAmarca.Marca_alta(tx_nom_marca.Text)
                'Producto_alta.Cargarcombo_marca()
                Producto_alta_New.Cargarcombo_marca()
                MessageBox.Show("La Marca fue dada de alta correctamente.", "Sistema de Gestion.")
                Me.Close()
            Else

            End If

        End If
    End Sub

    Private Sub Marca_alta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'NOTA: DEBE ESTAR LA PROPIEDAD DEL FORM "KEYPREVIEW = TRUE" para q se ejecute el evento keydown.

        If e.KeyCode = Keys.Escape Then 'ESC
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea salir del formulario?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.F2 Then 'F2 EJECUTA CODIGO DE GUARDAR
            guardar()
        End If

    End Sub
End Class