Public Class Pedido_Consulta
    Inherits System.Web.UI.Page
    Dim dapedido As New Capa_Datos.Pedido

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds = dapedido.Pedido_ObtenerTodo_detallado

        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub



    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If (e.CommandName = "Ver") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Session("PedidoId") = GridView1.Rows(index).Cells(0).Text
            Response.Redirect("../Pedido/Pedido_Nuevo.aspx")
        End If
        If (e.CommandName = "Recibir") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Session("PedidoId") = GridView1.Rows(index).Cells(0).Text
            Div_Fecha.Visible = True

        End If

        If (e.CommandName = "Eliminar") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Session("PedidoId") = GridView1.Rows(index).Cells(0).Text
            dapedido.Pedido_Eliminar(Session("PedidoId"))
            Session("PedidoId") = ""
            Response.Redirect("../Pedido/Pedido_Consulta.aspx")
        End If


    End Sub

    Private Sub Btn_guardarFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_guardarFecha.Click
        If Tb_fecha.Text <> "" Then
            dapedido.Pedido_Recibir(Session("PedidoId"), Tb_fecha.Text)
            Session("PedidoId") = ""
            Response.Redirect("../Pedido/Pedido_Consulta.aspx")
        End If

    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        Response.Redirect("../Pedido/Pedido_Nuevo.aspx")
    End Sub

    Private Sub btn_Agregar2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Agregar2.Click
        Response.Redirect("../Pedido/Pedido_Consulta.aspx")
    End Sub
End Class