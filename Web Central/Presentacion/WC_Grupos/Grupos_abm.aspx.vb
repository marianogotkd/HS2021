Public Class Grupos_abm
    Inherits System.Web.UI.Page
    Dim DAgrupos As New Capa_Datos.WC_grupos
    Dim DS_grupos As New DS_grupos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ds_grup As DataSet = DAgrupos.Grupos_obtenertodos
            DS_grupos.Grupos_todos.Rows.Clear()
            GridView1.DataSource = ""
            'GridView1.DataBind()
            If ds_grup.Tables(0).Rows.Count <> 0 Then
                DS_grupos.Grupos_todos.Merge(ds_grup.Tables(0))
                GridView1.DataSource = DS_grupos.Grupos_todos
                GridView1.DataBind()
            End If

        End If
    End Sub

    Private Sub btn_ir_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ir.ServerClick

        Response.Redirect("Grupos_alta.aspx")

    End Sub
End Class