Public Class Usuario_modificar

    Dim DAusuario As New Datos.Usuario
    Dim ds_usuariotipo As DataSet
    Dim ds_usuario As DataSet

    Public Sub USU_baja_Configuracion()
        ds_usuariotipo = DAusuario.UsuarioTipo_obtener
        COM_UT_dep.DataSource = ds_usuariotipo.Tables(0)
        COM_UT_dep.DisplayMember = "UT_desc"
        COM_UT_dep.ValueMember = "UT_id"
        Cargar()

        
    End Sub

    Private Sub Bo_bloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_bloquear.Click

        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Bloquear al Usuario?", "La Santa Fe", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim USU_id As String = DG_usuario.SelectedRows(0).Cells(0).Value.ToString
            DAusuario.Usuario_bloquear(USU_id)
            Cargar()
            MessageBox.Show("El Usuario fue Bloqueado correctamente.", "La Santa Fe")
        End If
    End Sub


    Private Sub Bo_desbloq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_desbloq.Click

        If DG_bloqueados.Rows.Count <> 0 Then

            Dim result As DialogResult
            result = MessageBox.Show("¿Desea Desbloquear al Usuario?", "La Santa Fe", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Dim USU_id As String = DG_bloqueados.SelectedRows(0).Cells(0).Value.ToString
                DAusuario.Usuario_Desbloquear(USU_id)
                Cargar()
                MessageBox.Show("El Usuario fue Desbloqueado correctamente.", "La Santa Fe")
            End If
        Else
            MessageBox.Show("Seleccione un usuario bloqueado.", "La Santa Fe")
        End If
    End Sub


    Private Sub Bo_cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cambiar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cambiar el Tipo de Usuario?", "La Santa Fe", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim USU_id As String = DG_usuario.SelectedRows(0).Cells(0).Value.ToString
            Dim UT_id As String = ds_usuariotipo.Tables(0).Rows(COM_UT_dep.SelectedIndex).Item("UT_id").ToString
            DAusuario.Usuario_cambiar(USU_id, UT_id)
            Cargar()
            MessageBox.Show("El Cambio de Usuario fue correcto.", "La Santa Fe")
        End If
    End Sub

    Public Sub Cargar()
        ds_usuario = DAusuario.Usuario_obtener
        DG_usuario.DataSource = ds_usuario.Tables(0)
        DG_bloqueados.DataSource = ds_usuario.Tables(1)

        DG_bloqueados.ClearSelection()
        DG_usuario.ClearSelection()
    End Sub


    Private Sub DG_usuario_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DG_usuario.SelectionChanged
        If ((DG_usuario.CurrentRow Is Nothing) OrElse (DG_usuario.SelectedRows.Count <> 0)) Then
            Bo_bloquear.Enabled = True
            Bo_cambiar.Enabled = True
        Else
            Bo_bloquear.Enabled = False
            Bo_cambiar.Enabled = False
        End If
    End Sub

    Private Sub DG_bloqueados_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DG_bloqueados.SelectionChanged
        If ((DG_bloqueados.CurrentRow Is Nothing) OrElse (DG_bloqueados.SelectedRows.Count <> 0)) Then
            Bo_desbloq.Enabled = True
        Else
            Bo_desbloq.Enabled = False
        End If
    End Sub

    Private Sub Usuario_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        USU_baja_Configuracion()
    End Sub

End Class