Public Class Index
    Inherits System.Web.UI.Page
    Dim DAUsuario As New Capa_Datos.Usuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ds As DataSet = DAUsuario.Usuario_ObtenerUsuario(tb_us.Text, tb_pass.Text)
        If ds.Tables(0).Rows.Count <> 0 Then
            Session("UsuId") = ds.Tables(0).Rows(0).Item("UsuId")
            Session("Us") = tb_us.Text
            Session("Pass") = tb_pass.Text
            Response.Redirect("Inicio.aspx")
        Else
            lbl_Err2.Visible = True
        End If

       



    End Sub

    
End Class