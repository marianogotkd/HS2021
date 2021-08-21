Imports System.IO
Imports System.Data.OleDb
Public Class Pedido_Nuevo
    Inherits System.Web.UI.Page
    Dim daObra As New Capa_Datos.Obra
    Dim daVehi As New Capa_Datos.Vehiculo
    Dim dapedido As New Capa_Datos.Pedido
    Dim daArticulo As New Capa_Datos.Articulo
    Dim ds_art As DataSet
    Dim DataVisualArt As New DS_Articulos
    Dim ds_art2 As DataSet
    Dim tb_cant As TextBox
    Dim tb_obs As TextBox
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Dim ds_pedido

            'Obtener_articulos()
            Obtener_Combos()
            If Session("PedidoId") = "" Then
                ds_pedido = dapedido.Pedido_ObtenerTodo()
                tb_numped.Text = ds_pedido.Tables(0).Rows.Count + 1
                Tb_fecha.Text = Today
            Else


                Obtener_Datos()


            End If
           

        End If
    End Sub

    Private Sub Obtener_Datos()
        Dim ds = dapedido.Pedido_Obtener_con_Det_X_ID(Session("PedidoId"))
        Dim i = 0
        DataVisualArt.Tables("Pedido_Art").Rows.Clear()

        While i < ds.Tables(0).Rows.Count

            Dim row As DataRow = DataVisualArt.Tables("Pedido_Art").NewRow()
            row("ArticuloId") = ds.Tables(0).Rows(i).Item("ArticuloId")
            row("ArticuloNombre") = ds.Tables(0).Rows(i).Item("ArticuloNombre")
            row("ArticuloRubro") = ds.Tables(0).Rows(i).Item("ArticuloRubro")
            row("ObrArtCantidad") = ds.Tables(0).Rows(i).Item("PedidoDetCant")
            row("Obs") = ds.Tables(0).Rows(i).Item("PedidoDetObs")

            DataVisualArt.Tables("Pedido_Art").Rows.Add(row)

            i = i + 1

        End While

        GridView2.DataSource = DataVisualArt.Tables("Pedido_Art")
        GridView2.DataBind()

        '''''
        tb_Nombre.Text = ds.Tables(0).Rows(0).Item("Usuario")
        tb_numped.Text = Session("PedidoId")
        DropDownList_obra.SelectedValue = ds.Tables(0).Rows(0).Item("ObraId")
        DropDownList_vehi.SelectedValue = ds.Tables(0).Rows(0).Item("VehiculoId")
        Tb_fecha.Text = ds.Tables(0).Rows(0).Item("PedidoFecha")
        tb_FechaRecep.Visible = True

        If Not IsDBNull(ds.Tables(0).Rows(0).Item("PedidoReciboFecha")) Then
            tb_FechaRecep.Text = ds.Tables(0).Rows(0).Item("PedidoReciboFecha")
        End If




    End Sub
    Private Sub Obtener_Combos()
        Dim ds_Obra = daObra.Obra_Obtener_todo

        If ds_Obra.Tables(0).Rows.Count <> 0 Then
            DropDownList_obra.DataSource = ds_Obra.Tables(0)
            DropDownList_obra.DataTextField = "ObraNombre"
            DropDownList_obra.DataValueField = "ObraId"
            DropDownList_obra.DataBind()
        End If


        Dim ds_Vehi = daVehi.Vehiculo_Obtener_Juntos_Activos

        If ds_Vehi.Tables(0).Rows.Count <> 0 Then
            DropDownList_vehi.DataSource = ds_Vehi.Tables(0)
            DropDownList_vehi.DataTextField = "Auto"
            DropDownList_vehi.DataValueField = "VehiculoId"
            DropDownList_vehi.DataBind()
        End If

    End Sub



    Private Sub Obtener_articulos()
        ds_art = daArticulo.Articulo_Obtener_Todo
        If ds_art.Tables(0).Rows.Count <> 0 Then



            GridView1.DataSource = ds_art.Tables(0)
            GridView1.DataBind()



        End If
    End Sub

    Private Sub Btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_buscar.Click
        ds_art = daArticulo.Articulo_Obtener_Todo
        DataVisualArt.Tables("Articulos").Rows.Clear()

        Dim i As Integer = 0
        While i < ds_art.Tables(0).Rows.Count
            Dim buscaraqui As String = CStr(ds_art.Tables(0).Rows(i).Item("ArticuloNombre")).ToUpper
            Dim buscaresto As String = CStr(tb_Buscar.Text).ToUpper
            Dim primer_caracter_encontrado As Integer = buscaraqui.IndexOf(buscaresto)
            If CStr(ds_art.Tables(0).Rows(i).Item("ArticuloId")) = CStr(tb_Buscar.Text) Or primer_caracter_encontrado <> -1 Then
                'si lo encuentro lo agrego

                Dim row As DataRow = DataVisualArt.Tables("Articulos").NewRow()

                row("ArticuloId") = ds_art.Tables(0).Rows(i).Item("ArticuloId")
                row("ArticuloNombre") = ds_art.Tables(0).Rows(i).Item("ArticuloNombre")
                row("ArticuloRubro") = ds_art.Tables(0).Rows(i).Item("ArticuloRubro")

               


                DataVisualArt.Tables("Articulos").Rows.Add(row)

            End If


            i = i + 1
        End While

        GridView1.DataSource = DataVisualArt.Tables("Articulos")
        GridView1.DataBind()


    End Sub

    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If (e.CommandName = "Select") Then

            ''var variable para saber si el art ya esta en el listado

            Div_Elim.Visible = False
            Dim var = 0
            Dim i = 0
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())

            tb_cant = CType(Me.GridView1.Rows.Item(index).FindControl("txt_cant"), TextBox)
            Dim cant As String = tb_cant.Text
            tb_obs = CType(Me.GridView1.Rows.Item(index).FindControl("tb_Obs"), TextBox)

            DataVisualArt.Tables("Pedido_Art").Rows.Clear()
            If GridView2.Rows.Count <> 0 Then


                While i < GridView2.Rows.Count
                    If GridView1.Rows(index).Cells(0).Text = GridView2.Rows(i).Cells(0).Text Then
                        var = 1
                        Exit While
                    Else
                        Dim row As DataRow = DataVisualArt.Tables("Pedido_Art").NewRow()
                        row("ArticuloId") = GridView2.Rows(i).Cells(0).Text
                        row("ArticuloNombre") = GridView2.Rows(i).Cells(1).Text
                        row("ArticuloRubro") = GridView2.Rows(i).Cells(2).Text
                        row("ObrArtCantidad") = GridView2.Rows(i).Cells(3).Text
                        row("Obs") = GridView2.Rows(i).Cells(4).Text

                        DataVisualArt.Tables("Pedido_Art").Rows.Add(row)

                    End If
                   
                    i = i + 1
                End While

            End If

            If tb_cant.Text <> "" And var = 0 Then



                Dim row As DataRow = DataVisualArt.Tables("Pedido_Art").NewRow()
                row("ArticuloId") = GridView1.Rows(index).Cells(0).Text
                row("ArticuloNombre") = GridView1.Rows(index).Cells(1).Text
                row("ArticuloRubro") = GridView1.Rows(index).Cells(2).Text
                row("ObrArtCantidad") = tb_cant.Text
                row("Obs") = tb_obs.Text


                DataVisualArt.Tables("Pedido_Art").Rows.Add(row)

                GridView2.DataSource = DataVisualArt.Tables("Pedido_Art")
                GridView2.DataBind()
                div_titulo.Visible = True
            Else
                If var = 1 Then
                    Div_Elim.Visible = True
                    lbl_err.Text = "El Articulo ya se encuentra en el listado"
                Else
                    Div_Elim.Visible = True
                    lbl_err.Text = "Debe colocar la Cantidad en el Articulo"
                End If

            End If

           

        End If



    End Sub
    Dim index As Integer
    Private Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        If (e.CommandName = "Eliminar") Then
            index = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Dim Cod = GridView2.Rows(index).Cells(0).Text
            Dim i = 0



            While i < GridView2.Rows.Count
                If Cod = GridView2.Rows(i).Cells(0).Text Then
                  
                Else
                    Dim row As DataRow = DataVisualArt.Tables("Pedido_Art").NewRow()
                    row("ArticuloId") = GridView2.Rows(i).Cells(0).Text
                    row("ArticuloNombre") = GridView2.Rows(i).Cells(1).Text
                    row("ArticuloRubro") = GridView2.Rows(i).Cells(2).Text
                    row("ObrArtCantidad") = GridView2.Rows(i).Cells(3).Text
                    row("Obs") = GridView2.Rows(i).Cells(4).Text

                    DataVisualArt.Tables("Pedido_Art").Rows.Add(row)

                End If

                i = i + 1
            End While

            GridView2.DataSource = DataVisualArt.Tables("Pedido_Art")
            GridView2.DataBind()



            'ds.Tables(0).Rows.RemoveAt(GridView2.Rows(index).Cells(0).Text)
            'DataVisualArt.Tables("Pedido_Art").Rows.RemoveAt(GridView2.Rows(index).Cells(0).Text)
            'GridView2.DataSource = DataVisualArt.Tables("Pedido_Art")
            'GridView2.DataBind()
        End If


    End Sub

    
    Private Sub GridView2_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles GridView2.RowDeleting

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If Session("PedidoId") = "" Then


            If GridView2.Rows.Count <> 0 Then
                Dim i = 0
                Dim ds = dapedido.Pedido_Alta(DropDownList_obra.SelectedValue, DropDownList_vehi.SelectedValue, Tb_fecha.Text, tb_Nombre.Text)
                Dim PedidoId = ds.Tables(0).Rows(0).Item("PedidoId")

                While i < GridView2.Rows.Count

                    dapedido.PedidoDetalle_Alta(PedidoId, GridView2.Rows(i).Cells(0).Text, GridView2.Rows(i).Cells(3).Text, GridView2.Rows(i).Cells(4).Text)


                    i = i + 1
                End While
                Div_err2.Visible = False
                card_OK.Visible = True


            Else
                Div_err2.Visible = True
                Label1.Text = "El Pedido Debe Tener al Menos un Articulo"

            End If

        Else
            Dim i = 0
            If Tb_fecha.Text <> "" And tb_FechaRecep.Text <> "" And tb_Nombre.Text <> "" Then

                dapedido.Pedido_Actualizar(Session("PedidoId"), DropDownList_obra.SelectedValue, DropDownList_vehi.SelectedValue, Tb_fecha.Text, tb_Nombre.Text, tb_FechaRecep.Text)

                While i < GridView2.Rows.Count

                    dapedido.PedidoDetalle_Alta(Session("PedidoId"), GridView2.Rows(i).Cells(0).Text, GridView2.Rows(i).Cells(3).Text, GridView2.Rows(i).Cells(4).Text)


                    i = i + 1
                End While
                Div_err2.Visible = False
                card_OK.Visible = True


            Else
                Div_err2.Visible = True
                Label1.Text = "Debe Completar todos Los Campos"
            End If

        End If


    End Sub

    Private Sub btn_Volver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Volver.Click
        Response.Redirect("../Pedido/Pedido_Consulta.aspx")
    End Sub
End Class