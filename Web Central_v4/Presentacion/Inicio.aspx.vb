Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            txt_opcion.Focus()
        End If


    End Sub

    Private Sub btn_opcion_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_opcion.ServerClick


        Select Case txt_opcion.Text.ToUpper
            Case "A"
                Response.Redirect("~/WC_Grupos/Grupos_abm.aspx")
            Case "B"
                Response.Redirect("~/WC_Cliente/Cliente_abm.aspx")
            Case Else
                ''aqui va mensaje de error.
                'no existe
                ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_error", "$(document).ready(function () {$('#modal-sm_error').modal();});", True)

        End Select




    End Sub

    Private Sub btn_ok_error_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok_error.ServerClick
        txt_opcion.Focus()
    End Sub

    Private Sub btn_close_error_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_close_error.ServerClick
        txt_opcion.Focus()
    End Sub
End Class