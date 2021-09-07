Public Class Usuario_alta

    Dim dausuario As New Datos.Usuario
    Dim ds_usuariotipo As DataSet

    Public Sub usuario_inicio()
        ds_usuariotipo = dausuario.UsuarioTipo_obtener
        COM_UT_dep.DataSource = ds_usuariotipo.Tables(0)
        COM_UT_dep.DisplayMember = "UT_desc"
        COM_UT_dep.ValueMember = "UT_id"
    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta al Usuario?", "La Santa Fe.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim UT_id As String = ds_usuariotipo.Tables(0).Rows(COM_UT_dep.SelectedIndex).Item("UT_id").ToString
            dausuario.Usuario_alta(UT_id, TX_USU_ape.Text, TX_USU_nom.Text, TX_USU_usuario.Text, TX_USU_contr.Text)
            Usuario_AltaLimpiar()
            MessageBox.Show("El Usuario fue dado de alta correctamente.", "La Santa Fe")
        End If
    End Sub

    Public Sub Usuario_AltaLimpiar()
        TX_USU_ape.Text = Nothing
        TX_USU_nom.Text = Nothing
        TX_USU_usuario.Text = Nothing
        TX_USU_contr.Text = Nothing
    End Sub

    Private Sub Usuario_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        usuario_inicio()

        Usuario_AltaLimpiar()
        Usuario_AltaHabilitar()
    End Sub



    Private Sub TX_USU_ape_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_USU_ape.TextChanged
        Usuario_AltaHabilitar()
    End Sub

    Private Sub TX_USU_nom_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_USU_nom.TextChanged
        Usuario_AltaHabilitar()
    End Sub

    Private Sub TX_USU_usuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_USU_usuario.TextChanged
        Usuario_AltaHabilitar()
    End Sub

    Private Sub TX_USU_contr_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_USU_contr.TextChanged
        Usuario_AltaHabilitar()
    End Sub

    Public Sub Usuario_AltaHabilitar()
        If TX_USU_ape.Text <> Nothing And TX_USU_contr.Text <> Nothing And TX_USU_nom.Text <> Nothing And TX_USU_usuario.Text <> Nothing Then
            Bo_guardar.Enabled = True
        Else
            Bo_guardar.Enabled = False
        End If
    End Sub


    Private Sub BO_Limpiar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Limpiar.Click
        Usuario_AltaLimpiar()
    End Sub


End Class