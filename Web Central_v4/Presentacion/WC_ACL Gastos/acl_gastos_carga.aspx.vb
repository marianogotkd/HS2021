Public Class acl_gastos_carga
    Inherits System.Web.UI.Page
    Dim DAgastos As New Capa_Datos.WC_gastos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            motivos_obtener()
            Dim fecha As Date = Today
            Txt_fecha.Text = fecha.ToString("yyyy-MM-dd")
            Txt_fecha.Focus()
        End If
    End Sub

    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("~/WC_ACL Gastos/acl_gastos.aspx")
    End Sub

    Private Sub motivos_obtener()
        Dim ds_motivos As DataSet = DAgastos.GastosTipo_obtener_todos
        If ds_motivos.Tables(0).Rows.Count <> 0 Then
            DropDownList_motivo.DataSource = ds_motivos.Tables(0)
            DropDownList_motivo.DataTextField = "Motivo"
            DropDownList_motivo.DataValueField = "Gastotipo_id"
            DropDownList_motivo.DataBind()
        End If


    End Sub

End Class