Public Class Articulos
    Inherits System.Web.UI.Page
    Dim DAobra As New Capa_Datos.Obra
    Dim ds_Obras As DataSet
    Dim DatasetObra As New Ds_Obra

    Dim daArticulo As New Capa_Datos.Articulo
    Dim ds_art As DataSet
    Dim DataVisualArt As New DataSet

    Dim VarEditar

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Articulos()


    End Sub
    Private Sub Obtener_articulos()
        ds_art = daArticulo.Articulo_Obtener_Todo
        If ds_art.Tables(0).Rows.Count <> 0 Then



            GridView1.DataSource = ds_art.Tables(0)
            GridView1.DataBind()

        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If tb_nombre.Text <> "" Then
            If Session(" VarEditar") = "si" Then
                daArticulo.Articulo_modificar(Session("IDArt_INT"), tb_nombre.Text, DropDownList_Rubro.SelectedValue)
                Session("IDArt_INT") = ""
                Session(" VarEditar") = ""
                Response.Redirect("Articulos.aspx")
            Else
                daArticulo.Articulo_Alta(tb_nombre.Text, DropDownList_Rubro.SelectedValue)
                Response.Redirect("Articulos.aspx")
            End If
           
        End If
    End Sub

    
    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If (e.CommandName = "Eliminar") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Dim idart = GridView1.Rows(index).Cells(0).Text

            Dim ds_verf As DataSet = daArticulo.ObraArticulo_Verificar_ART(idart)



            If ds_verf.Tables(0).Rows.Count = 0 Then
                daArticulo.Articulos_Eliminar(idart)
                Response.Redirect("Articulos.aspx")
            Else
                Div_Elim.Visible = True
            End If



        End If

        If (e.CommandName = "Editar") Then
            Session(" VarEditar") = "si"
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            tb_nombre.Text = GridView1.Rows(index).Cells(1).Text
            btn_Agregar.Text = "Guardar Cambios"
            Session("IDArt_INT") = GridView1.Rows(index).Cells(0).Text
        End If

    End Sub
End Class