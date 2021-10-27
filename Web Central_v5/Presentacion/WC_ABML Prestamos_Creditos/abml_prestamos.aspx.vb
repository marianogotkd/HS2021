Public Class abml_prestamos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Txt_cliente_codigo.Focus()
        End If
    End Sub

    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("~/WC_ABML Prestamos_Creditos/abml_prestamoscreditos.aspx")
    End Sub
End Class