Public Class Permisos
    Inherits System.Web.UI.Page
    Dim DAUsuario As New Capa_Datos.Usuario
    Dim DT_Usuario As New DS_Usuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Dim ds_rol = DAUsuario.Rol_obtenerTodos

            If ds_rol.Tables(0).Rows.Count <> 0 Then
                DropDownList_Rol.DataSource = ds_rol.Tables(0)
                DropDownList_Rol.DataTextField = "RolDesc"
                DropDownList_Rol.DataValueField = "RolId"
                DropDownList_Rol.DataBind()
            End If

            Dim ds_Usu = DAUsuario.Usuario_ObtenerTodos

            If ds_Usu.Tables(0).Rows.Count <> 0 Then
                DropDown_Usuario.DataSource = ds_Usu.Tables(0)
                DropDown_Usuario.DataTextField = "NomApe"
                DropDown_Usuario.DataValueField = "UsuId"
                DropDown_Usuario.DataBind()
            End If




        End If
    End Sub

    Private Sub _btn_AgrUsuario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btn_AgrUsuario.Click
        lbl_nom.Text = DropDown_Usuario.SelectedItem.Text
        div_titulo.Visible = True
        DT_Usuario.Tables("Rol").Rows.Clear()
        Dim var = 0
        If GridView1.Rows.Count <> 0 Then
            Dim i = 0


            While i < GridView1.Rows.Count
                If DropDownList_Rol.SelectedValue = GridView1.Rows(i).Cells(0).Text Then
                    var = 1
                    Exit While
                Else
                    Dim row As DataRow = DT_Usuario.Tables("Rol").NewRow()
                    row("RolId") = GridView1.Rows(i).Cells(0).Text
                    row("RolDesc") = GridView1.Rows(i).Cells(1).Text


                    DT_Usuario.Tables("Rol").Rows.Add(row)

                End If

                i = i + 1
            End While


        End If

        If var = 0 Then



            Dim row As DataRow = DT_Usuario.Tables("Rol").NewRow()
            row("RolId") = DropDownList_Rol.SelectedValue
            row("RolDesc") = DropDownList_Rol.SelectedItem.Text



            DT_Usuario.Tables("Rol").Rows.Add(row)

            GridView1.DataSource = DT_Usuario.Tables("Rol")
            GridView1.DataBind()

        Else

        End If



    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If GridView1.Rows.Count <> 0 Then
            Dim i = 0
            While i < GridView1.Rows.Count
                DAUsuario.UsuarioRol_Alta(DropDown_Usuario.SelectedValue, GridView1.Rows(i).Cells(0).Text)
                i = i + 1
                card_OK.Visible = True
            End While

        End If
    End Sub

    Private Sub DropDown_Usuario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDown_Usuario.SelectedIndexChanged
        Dim ds_ObtenerGrid = DAUsuario.UsuarioRol_Obtener(DropDown_Usuario.SelectedValue)

        If ds_ObtenerGrid.Tables(0).Rows.Count <> 0 Then
            div_titulo.Visible = True
            Dim i = 0
            DT_Usuario.Tables("Rol").Rows.Clear()

            While i < ds_ObtenerGrid.Tables(0).Rows.Count
                Dim row As DataRow = DT_Usuario.Tables("Rol").NewRow()
                row("RolId") = ds_ObtenerGrid.Tables(0).Rows(i).Item("RolId")
                row("RolDesc") = ds_ObtenerGrid.Tables(0).Rows(i).Item("RolDesc")
                DT_Usuario.Tables("Rol").Rows.Add(row)


                i = i + 1
            End While


            GridView1.DataSource = DT_Usuario.Tables("Rol")
            GridView1.DataBind()




        Else
            div_titulo.Visible = False
            GridView1.DataBind()
        End If
    End Sub

    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If (e.CommandName = "Eliminar") Then

            Dim index = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Dim Cod = GridView1.Rows(index).Cells(0).Text
            Dim i = 0
            DT_Usuario.Tables("Rol").Rows.Clear()


            While i < GridView1.Rows.Count
                If Cod = GridView1.Rows(i).Cells(0).Text Then

                Else
                     Dim row As DataRow = DT_Usuario.Tables("Rol").NewRow()
                    row("RolId") = DropDownList_Rol.SelectedValue
                    row("RolDesc") = DropDownList_Rol.SelectedItem.Text

                    DT_Usuario.Tables("Rol").Rows.Add(row)

                   

                End If

                i = i + 1
            End While

             GridView1.DataSource = DT_Usuario.Tables("Rol")
            GridView1.DataBind()


            'ds.Tables(0).Rows.RemoveAt(GridView2.Rows(index).Cells(0).Text)
            'DataVisualArt.Tables("Pedido_Art").Rows.RemoveAt(GridView2.Rows(index).Cells(0).Text)
            'GridView2.DataSource = DataVisualArt.Tables("Pedido_Art")
            'GridView2.DataBind()
        End If
    End Sub
End Class