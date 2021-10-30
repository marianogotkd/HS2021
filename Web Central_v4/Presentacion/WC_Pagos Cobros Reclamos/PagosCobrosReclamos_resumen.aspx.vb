Public Class PagosCobrosReclamos_resumen
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("~/WC_Pagos Cobros Reclamos/PagosCobrosReclamos.aspx")
    End Sub
End Class