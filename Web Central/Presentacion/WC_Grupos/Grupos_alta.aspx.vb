Public Class Grupos_alta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            If Session("grupos_op") = "modificar" Then
                Txt_grupo_id.Text = "" 'aqui va el id del grupo
            End If
            Txt_grupo_nomb.Focus()

        End If
    End Sub

End Class