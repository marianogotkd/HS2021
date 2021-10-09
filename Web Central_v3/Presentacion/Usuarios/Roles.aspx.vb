Public Class Roles
    Inherits System.Web.UI.Page

    Dim DAUsuario As New Capa_Datos.Usuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Dim ds = DAUsuario.Modulo_ObtenerTodos
            If ds.Tables(0).Rows.Count <> 0 Then



                GridView1.DataSource = ds.Tables(0)
                GridView1.DataBind()

            End If


            Dim ds_rol = DAUsuario.Rol_obtenerTodos

            If ds_rol.Tables(0).Rows.Count <> 0 Then
                DropDownList_obra.DataSource = ds_rol.Tables(0)
                DropDownList_obra.DataTextField = "RolDesc"
                DropDownList_obra.DataValueField = "RolId"
                DropDownList_obra.DataBind()
            End If
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim indice As Integer = 0
        Dim SELECCIONADO As CheckBox
        Dim Var = "no"

        Do While indice < Me.GridView1.Rows.Count
            SELECCIONADO = CType(Me.GridView1.Rows.Item(indice).FindControl("CheckBox1"), CheckBox)
            If SELECCIONADO.Checked = True Then
                Var = "si"
            Else

            End If
            indice = indice + 1
        Loop

        indice = 0


        If tb_nombre.Text <> "" And Var = "si" Then
            Dim ds = DAUsuario.Rol_Nuevo(tb_nombre.Text)


            Do While indice < Me.GridView1.Rows.Count
                SELECCIONADO = CType(Me.GridView1.Rows.Item(indice).FindControl("CheckBox1"), CheckBox)
                If SELECCIONADO.Checked = True Then
                    Dim moduloid = GridView1.Rows(indice).Cells(0).Text
                    DAUsuario.RolModulos_Alta(ds.Tables(0).Rows(0).Item("RolId"), CInt(moduloid))
                Else

                End If
                indice = indice + 1
            Loop
            Response.Redirect("Roles.aspx")
        Else

            If Var = "no" Then
                lbl_Err.Visible = True
            Else
                Div_Err.Visible = True

            End If
        End If

    End Sub

    Private Sub DropDownList_obra_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList_obra.SelectedIndexChanged



        Dim indice As Integer = 0
        Dim i = 0
        Dim SELECCIONADO As CheckBox
        Dim Var = "no"
        Dim ds = DAUsuario.Rol_Modulos(DropDownList_obra.SelectedValue)

        ''While para Blanquear la Grilla
        Do While indice < Me.GridView1.Rows.Count
            SELECCIONADO = CType(Me.GridView1.Rows.Item(indice).FindControl("CheckBox1"), CheckBox)
            SELECCIONADO.Checked = False
            indice = indice + 1
        Loop

        indice = 0

        While i < ds.Tables(0).Rows.Count
            Dim Modulo = ds.Tables(0).Rows(i).Item("ModuloId")
            Do While indice < Me.GridView1.Rows.Count

                If Modulo = GridView1.Rows(indice).Cells(0).Text Then
                    SELECCIONADO = CType(Me.GridView1.Rows.Item(indice).FindControl("CheckBox1"), CheckBox)
                    SELECCIONADO.Checked = True
                End If

                indice = indice + 1

            Loop
            indice = 0

            i = i + 1

        End While

        
    End Sub
End Class