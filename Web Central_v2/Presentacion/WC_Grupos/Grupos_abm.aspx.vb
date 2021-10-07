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

    Private Sub recuperar_grupos()
        Dim ds_grup As DataSet = DAgrupos.Grupos_obtenertodos
        DS_grupos.Grupos_todos.Rows.Clear()
        GridView1.DataSource = ""
        'GridView1.DataBind()
        If ds_grup.Tables(0).Rows.Count <> 0 Then
            DS_grupos.Grupos_todos.Merge(ds_grup.Tables(0))
            GridView1.DataSource = DS_grupos.Grupos_todos
            GridView1.DataBind()
        End If
    End Sub



    Private Sub btn_nuevo_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_nuevo.ServerClick
        Session("grupos_op") = "alta"
        Response.Redirect("Grupos_alta.aspx")
    End Sub

    Private Sub btn_modificar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modificar.ServerClick
        Try
            Dim grupo_id As Integer = CInt(Txt_grupo_id.Text)
            Dim ds_info As DataSet = DAgrupos.Grupos_buscar_id(grupo_id)
            If ds_info.Tables(0).Rows.Count <> 0 Then
                Session("grupos_op") = "modificar"
                'pasar ademas el ID del grupo.
                Session("grupo_id") = CInt(Txt_grupo_id.Text)
                Response.Redirect("Grupos_alta.aspx")
            Else
                'no existe
            End If
        Catch ex As Exception
            'significa q la cadena ingresada no es entera.
        End Try

    End Sub

    Private Sub btn_baja_modal_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_baja_modal.ServerClick
        'NO SE USA YA
        DAgrupos.Grupos_baja(Session("id_eliminar"))
        recuperar_grupos()
    End Sub

    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        'If (e.CommandName = "op_modificar") Then 'es mostrar info de alumnos
        '    ' Retrieve the row index stored in the CommandArgument property.
        '    Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        '    Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
        '    Session("grupos_op") = "modificar"
        '    'pasar ademas el ID del grupo.
        '    Session("grupo_id") = id
        '    Response.Redirect("Grupos_alta.aspx")
        'End If
        'If (e.CommandName = "op_eliminar") Then 'es mostrar info de alumnos
        '    ' Retrieve the row index stored in the CommandArgument property.
        '    Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        '    Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
        '    Session("id_eliminar") = id
        'End If
    End Sub
End Class