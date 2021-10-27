Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            txt_opcion.Focus()
        End If


    End Sub

    Private Sub btn_opcion_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_opcion.ServerClick


        Select Case txt_opcion.Text.ToUpper
            Case "1"
                Response.Redirect("~/WC_Iniciar Dia/Iniciar_dia.aspx")
            Case "2"
                Response.Redirect("~/WC_Carga de Recorridos_Zonas/carga_recorridos_zonas_a.aspx")
            Case "A"
                Response.Redirect("~/WC_Grupos/Grupos_abm.aspx")
            Case "B"
                Response.Redirect("~/WC_Cliente/Cliente_abm.aspx")
            Case "C"
                Response.Redirect("~/WC_ABML Prestamos_Creditos/abml_prestamoscreditos.aspx")
            Case "D"
                Response.Redirect("~/WC_ACL Gastos/acl_gastos.aspx")
            Case "E"
                Response.Redirect("~/WC_AB Recorridos_Zonas/ab_recorridos_zonas.aspx")
            
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