Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging
Public Class Articulos_x_Obra
    Inherits System.Web.UI.Page
    Dim daArticulo As New Capa_Datos.Articulo
    Dim ds_art As DataSet
    Dim DataVisualArt As New DS_Articulos
    Dim ds_art2 As DataSet
    Dim tb_cant As TextBox

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            tb_Domicilio.Text = Session("ObraDir")
            tb_fecha.Text = Session("ObraFecha")
            tb_nombre.Text = Session("ObraNombre")
            tb_Domicilio.Enabled = False
            tb_fecha.Enabled = False
            tb_nombre.Enabled = False
            Obtener_articulos()

        End If

    End Sub

    Private Sub Obtener_articulos()
        ds_art = daArticulo.Articulo_Obtener_Todo
        If ds_art.Tables(0).Rows.Count <> 0 Then



            GridView1.DataSource = ds_art.Tables(0)
            GridView1.DataBind()

            Cargar_Art_en_Obra()

        End If
    End Sub

    Private Sub Cargar_Art_en_Obra()
        ds_art2 = daArticulo.ObraArticulo_MostrarCant(Session("ID_Obra_OCV"))
        If ds_art2.Tables(0).Rows.Count <> 0 Then

            '    Dim i = 0
            '    While i < ds_art.Tables(0).Rows.Count
            '        ds_art2 = daArticulo.ObraArticulo_MostrarCant(Session("ID_Obra_OCV"), ds_art.Tables(0).Rows(i).Item("ArticuloId"))

            '        If ds_art2.Tables(0).Rows.Count <> 0 Then


            '            Dim row As DataRow = DataVisualArt.Tables("Articulos").NewRow()

            '            row("ArticuloId") = ds_art2.Tables(0).Rows(i).Item("ArticuloId")
            '            row("ArticuloNombre") = ds_art2.Tables(0).Rows(i).Item("ArticuloNombre")
            '            row("ArticuloRubro") = ds_art2.Tables(0).Rows(i).Item("ArticuloRubro")
            '            row("ObrArtCantidad") = ds_art2.Tables(0).Rows(i).Item("ObrArtCantidad")


            '            DataVisualArt.Tables("Articulos").Rows.Add(row)
            '            Exit While
            '        End If

            '        i = i + 1

            '    End While

            GridView2.DataSource = ds_art2.Tables(0)
            GridView2.DataBind()
        End If

       

    End Sub
    Private Sub btn_guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If GridView1.Rows.Count <> 0 Then
            Dim i = 0
            While i < GridView1.Rows.Count
                tb_cant = CType(Me.GridView1.Rows.Item(i).FindControl("txt_cant"), TextBox)
                Dim cant As String = tb_cant.Text
                If tb_cant.Text <> "" Then
                    'VERIFICO SI ESTA Y SI ESTA LO ELIMINO PARA ACTULIZAR EL REGISTRO
                    Dim ds_verif As DataSet = daArticulo.ObraArticulo_Verificar(Session("ID_Obra_OCV"), GridView1.Rows(i).Cells(0).Text)
                    If ds_verif.Tables(0).Rows.Count <> 0 Then

                        daArticulo.ObraArticulo_eliminar(Session("ID_Obra_OCV"), GridView1.Rows(i).Cells(0).Text)

                    End If

                    'GUARDO EN OBRAARTICULO
                    daArticulo.ObraArticulo_Alta(Session("ID_Obra_OCV"), GridView1.Rows(i).Cells(0).Text, tb_cant.Text)
                End If
                i = i + 1
            End While

        End If

        Response.Redirect("Articulos_x_Obra.aspx")

    End Sub

    Private Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
        Dim artid = GridView2.Rows(index).Cells(0).Text
        daArticulo.ObraArticulo_eliminar(Session("ID_Obra_OCV"), artid)
        Response.Redirect("Articulos_x_Obra.aspx")
    End Sub

    Private Sub btn_Volver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Volver.Click
        Response.Redirect("../obra/Obra_Consulta.aspx")
    End Sub
End Class