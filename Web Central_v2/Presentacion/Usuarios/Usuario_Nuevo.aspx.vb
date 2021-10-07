Public Class Usuario_Nuevo
    Inherits System.Web.UI.Page
    Dim DAUsuario As New Capa_Datos.Usuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds = DAUsuario.Usuario_ObtenerTodos
        If ds.Tables(0).Rows.Count <> 0 Then



            GridView1.DataSource = ds.Tables(0)
            GridView1.DataBind()

        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If tb_nombre.Text <> "" And Tb_Apellido.Text <> "" And tb_pass.Text <> "" And tb_usu.Text <> "" Then
            If Session(" VarEditar") = "si" Then
                DAUsuario.Usuario_Modificar(Session("ID"), tb_nombre.Text, Tb_Apellido.Text, tb_usu.Text, tb_pass.Text)
                Session("ID") = ""
                Session(" VarEditar") = ""
                Response.Redirect("Usuario_Nuevo.aspx")
            Else
                DAUsuario.Usuario_Nuevo(tb_nombre.Text, Tb_Apellido.Text, tb_usu.Text, tb_pass.Text)
                Response.Redirect("Usuario_Nuevo.aspx")
            End If
        Else
            lbl_Err.Visible = True
        End If
    End Sub

    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If (e.CommandName = "Eliminar") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Dim idUsu = GridView1.Rows(index).Cells(0).Text


            DAUsuario.Usuario_Bloquear(idUsu)
            Response.Redirect("Usuario_Nuevo.aspx")


        End If

        If (e.CommandName = "Editar") Then
            Session(" VarEditar") = "si"
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            tb_nombre.Text = GridView1.Rows(index).Cells(1).Text
            Tb_Apellido.Text = GridView1.Rows(index).Cells(2).Text
            tb_usu.Text = GridView1.Rows(index).Cells(3).Text
            btn_Agregar.Text = "Guardar Cambios"
            Session("ID") = GridView1.Rows(index).Cells(0).Text
        End If
    End Sub
End Class