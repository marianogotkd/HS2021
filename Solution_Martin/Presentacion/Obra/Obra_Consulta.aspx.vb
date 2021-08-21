Public Class Obra_Consulta
    Inherits System.Web.UI.Page
    Dim DAobra As New Capa_Datos.Obra
    Dim ds_Obras As DataSet
    Dim DatasetObra As New Ds_Obra
    Dim DaVehiObra As New Capa_Datos.VehiculoObra
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            obtener_datos()
        End If

    End Sub
    Private Sub obtener_datos()
        ds_Obras = DAobra.Obra_Obtener_todo()
        If ds_Obras.Tables(0).Rows.Count <> 0 Then

            DatasetObra.Obtener_todo.Merge(ds_Obras.Tables(0))
            GridView1.DataSource = DatasetObra
            GridView1.DataBind()

            If Session("Selec") <> 0 Then


                Me.GridView1.HeaderRow.Cells(8).Visible = False
                For x = 0 To GridView1.Rows.Count - 1
                    Me.GridView1.Rows(x).Cells(8).Visible = False
                Next

                Me.GridView1.HeaderRow.Cells(9).Visible = False
                For x = 0 To GridView1.Rows.Count - 1
                    Me.GridView1.Rows(x).Cells(9).Visible = False
                Next

            End If


        End If

    End Sub

    Public Sub Buscar(ByVal parametro As String)
        Dim ds = DAobra.Obra_Obtener_todo
        Dim i As Integer = 0
        While i < ds.Tables(0).Rows.Count
            Dim buscaraqui As String = CStr(ds.Tables(0).Rows(i).Item("ObraNombre")).ToUpper
            Dim buscaresto As String = CStr(tb_Buscar.Text).ToUpper
            Dim primer_caracter_encontrado As Integer = buscaraqui.IndexOf(buscaresto)
            If CStr(ds.Tables(0).Rows(i).Item("ObraId")) = CStr(tb_Buscar.Text) Or primer_caracter_encontrado <> -1 Then
                'si lo encuentro lo agrego

                Dim row As DataRow = DatasetObra.Tables("Obtener_todo").NewRow()

                row("ObraId") = ds.Tables(0).Rows(i).Item("ObraId")
                row("ObraNombre") = ds.Tables(0).Rows(i).Item("ObraNombre")
                row("ObraDescripcion") = ds.Tables(0).Rows(i).Item("ObraDescripcion")
                row("ObraDomicilio") = ds.Tables(0).Rows(i).Item("ObraDomicilio")
                row("ObraLocalidad") = ds.Tables(0).Rows(i).Item("ObraLocalidad")
                row("ObraFechaInicio") = ds.Tables(0).Rows(i).Item("ObraFechaInicio")
                row("ObraFechaFinal") = ds.Tables(0).Rows(i).Item("ObraFechaFinal")


                DatasetObra.Tables("Obtener_todo").Rows.Add(row)

            End If


            i = i + 1
        End While

    End Sub
    Private Sub btn_Agregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        Session("ObraId") = ""
        Response.Redirect("../Obra/Obra_Nueva.aspx")
    End Sub

    Private Sub Btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_buscar.Click
        DatasetObra.Tables("Obtener_todo").Rows.Clear()
        Buscar(tb_Buscar.Text)
        

        GridView1.DataSource = DatasetObra.Tables("Obtener_todo")
        GridView1.DataBind()

    End Sub

    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand

        If (e.CommandName = "Ver_vehi" Or e.CommandName = "Articulos") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Session("ID_Obra_OCV") = GridView1.Rows(index).Cells(0).Text
            Session("ObraNombre") = GridView1.Rows(index).Cells(1).Text
            Session("ObraDir") = GridView1.Rows(index).Cells(3).Text
            Session("ObraFecha") = GridView1.Rows(index).Cells(5).Text
            If e.CommandName = "Ver_vehi" Then
                Response.Redirect("../Obra/Obra_Consulta_Vehiculos.aspx")
            End If
            If e.CommandName = "Articulos" Then
                Response.Redirect("../Articulos/Articulos_x_Obra.aspx")
            End If
        End If

        If (e.CommandName = "Eliminar") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())


            Dim ds_vehiculos = DaVehiObra.VehiculoObra_Obtener_X_Obra(GridView1.Rows(index).Cells(0).Text)

            If ds_vehiculos.Tables(0).Rows.Count = 0 Then
                DAobra.Obra_Eliminar(GridView1.Rows(index).Cells(0).Text)
                Response.Redirect("Obra_Consulta.aspx")
            Else
                Div_Elim.Visible = True
            End If
        End If

    End Sub



    Private Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Session("ObraId") = GridView1.SelectedRow.Cells(0).Text
        Response.Redirect("Obra_Nueva.aspx")

    End Sub


    Private Sub Agregar2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Agregar2.Click
        Session("ObraId") = ""
        Response.Redirect("../Obra/Obra_Nueva.aspx")
    End Sub

    Protected Sub GridView1_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        Dim var = (CType(sender, GridView)).Rows(e.RowIndex).Cells(0).Text

    End Sub

    Private Sub DropDownList_obra_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList_obra.SelectedIndexChanged
        Dim ds = DAobra.Obra_Obtener_todo
        If ds.Tables(0).Rows.Count <> 0 Then
            Dim i = 0


            If DropDownList_obra.SelectedValue = "Finalizadas" Then
                DatasetObra.Tables("Obtener_todo").Rows.Clear()
                While i < ds.Tables(0).Rows.Count
                    If Not IsDBNull(ds.Tables(0).Rows(i).Item("ObraFechaFinal")) Then

                        Dim row As DataRow = DatasetObra.Tables("Obtener_todo").NewRow()

                        row("ObraId") = ds.Tables(0).Rows(i).Item("ObraId")
                        row("ObraNombre") = ds.Tables(0).Rows(i).Item("ObraNombre")
                        row("ObraDescripcion") = ds.Tables(0).Rows(i).Item("ObraDescripcion")
                        row("ObraDomicilio") = ds.Tables(0).Rows(i).Item("ObraDomicilio")
                        row("ObraLocalidad") = ds.Tables(0).Rows(i).Item("ObraLocalidad")
                        row("ObraFechaInicio") = ds.Tables(0).Rows(i).Item("ObraFechaInicio")
                        row("ObraFechaFinal") = ds.Tables(0).Rows(i).Item("ObraFechaFinal")


                        DatasetObra.Tables("Obtener_todo").Rows.Add(row)

                    End If
                    i = i + 1
                End While

                GridView1.DataSource = DatasetObra.Tables("Obtener_todo")
                GridView1.DataBind()

            End If

            If DropDownList_obra.SelectedValue = "Sin Finalizar" Then
                DatasetObra.Tables("Obtener_todo").Rows.Clear()
                i = 0
                While i < ds.Tables(0).Rows.Count
                    If Not IsDBNull(ds.Tables(0).Rows(i).Item("ObraFechaFinal")) Then

                    Else
                        Dim row As DataRow = DatasetObra.Tables("Obtener_todo").NewRow()

                        row("ObraId") = ds.Tables(0).Rows(i).Item("ObraId")
                        row("ObraNombre") = ds.Tables(0).Rows(i).Item("ObraNombre")
                        row("ObraDescripcion") = ds.Tables(0).Rows(i).Item("ObraDescripcion")
                        row("ObraDomicilio") = ds.Tables(0).Rows(i).Item("ObraDomicilio")
                        row("ObraLocalidad") = ds.Tables(0).Rows(i).Item("ObraLocalidad")
                        row("ObraFechaInicio") = ds.Tables(0).Rows(i).Item("ObraFechaInicio")
                        row("ObraFechaFinal") = ds.Tables(0).Rows(i).Item("ObraFechaFinal")


                        DatasetObra.Tables("Obtener_todo").Rows.Add(row)


                    End If
                    i = i + 1
                End While

                GridView1.DataSource = DatasetObra.Tables("Obtener_todo")
                GridView1.DataBind()
            End If

            If DropDownList_obra.SelectedValue = "Todos" Then
                DatasetObra.Tables("Obtener_todo").Rows.Clear()
                obtener_datos()
            End If


        End If
    End Sub
End Class