Public Class Vehiculo_Consulta
    Inherits System.Web.UI.Page
    Dim DAvehiculos As New Capa_Datos.Vehiculo
    Dim ds_vehiculos As DataSet
    Dim DatasetVisual_Vehiculos As New DS_Vehiculo

    Dim DAobra As New Capa_Datos.Obra
    Dim ds_Obras As DataSet
    Dim DatasetObra As New Ds_Obra

    Dim DaVehiObra As New Capa_Datos.VehiculoObra
    Public ObraId As Integer
    Dim dsVehiObra As DataSet


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ds_vehiculos = DAvehiculos.Vehiculo_ObtenerTodo
        If ds_vehiculos.Tables(0).Rows.Count <> 0 Then

            Traer_vehiculos()

            GridView1.DataSource = DatasetVisual_Vehiculos.Tables("Vehiculo")
            GridView1.DataBind()
        End If

    End Sub
    Private Sub Traer_vehiculos()

        Dim i As Integer = 0

        While i < ds_vehiculos.Tables(0).Rows.Count
            Dim Ds = DaVehiObra.Vehiculo_Verficiar(ds_vehiculos.Tables(0).Rows(i).Item("VehiculoId"))
            Dim row As DataRow = DatasetVisual_Vehiculos.Tables("Vehiculo").NewRow()

            row("VehiculoId") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoId")
            row("VehiculoPatente") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoPatente")
            row("VehiculoMarca") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoMarca")
            row("VehiculoModelo") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoModelo")
            row("VehiculoAño") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoAño")
            row("VehiculoTipo") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoTipo")
            row("VehiculoEstado") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoEstado")

            If Ds.Tables(0).Rows.Count = 0 Then
                row("Obra") = "Sin Asignar"
            Else
                If Ds.Tables(0).Rows(0).Item("ObraId") = 0 Then
                    row("Obra") = "Sin Asignar"
                Else
                    row("Obra") = "Asignado"
                End If
            End If

            DatasetVisual_Vehiculos.Tables("Vehiculo").Rows.Add(row)
            i = i + 1

        End While
    End Sub
    
    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        'en HTML SOLO DEFINIO EL COMMANDNAME PARA USAR EL IF 
        'EL TIPO DE BOTON DE LA GRILLA ES BUTTONFILD

        If (e.CommandName = "Asignar") Then
            card_OK.Visible = False
            Div_Elim.Visible = False

            lbl_Err.Visible = False
            ' Retrieve the row index stored in the CommandArgument property.
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Session("ID_Vehi") = GridView1.Rows(index).Cells(0).Text
            GridView1.Rows(index).BackColor = Drawing.Color.Aquamarine

            ds_Obras = DAobra.Obra_Obtener_Fecha
            DatasetObra.Obtener_todo.Merge(ds_Obras.Tables(0))
            GridView2.DataSource = DatasetObra
            GridView2.DataBind()

            div_BuscarO.Visible = True
            Titulo_Obra.Visible = True




            'Response.Redirect("Mensaje_Datos_Personales.aspx")
            'obtener_datos_alumno(id)
            'popupdatospersonales.Visible = True
            'ModalPopupExtender_DApersonales.Show()
        End If

        If (e.CommandName = "Historial") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
            Session("ID_Vehi_hist") = GridView1.Rows(index).Cells(0).Text
            Response.Redirect("Vehiculo_Historico.aspx")
        End If

        If (e.CommandName = "Eliminar") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())

            Dim var = GridView1.Rows(index).Cells(0).Text

            Dim Ds = DaVehiObra.Vehiculo_Verficiar(GridView1.Rows(index).Cells(0).Text)
            If Ds.Tables(0).Rows.Count = 0 Then
                DAvehiculos.Vehiculo_Eliminar(GridView1.Rows(index).Cells(0).Text)
                Response.Redirect("Vehiculo_Consulta.aspx")
            Else
                Div_Elim.Visible = True
            End If


        End If

    End Sub

    Private Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Session("VehiculoId") = GridView1.SelectedRow.Cells(0).Text
        Response.Redirect("Vehiculo_Nuevo.aspx")
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        Session("VehiculoId") = ""
        Response.Redirect("Vehiculo_Nuevo.aspx")
    End Sub

    Private Sub Btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_buscar.Click
        DatasetVisual_Vehiculos.Tables("Vehiculo").Rows.Clear()
        Buscar(tb_Buscar.Text)


        GridView1.DataSource = DatasetVisual_Vehiculos.Tables("Vehiculo")
        GridView1.DataBind()
    End Sub

    Public Sub Buscar(ByVal parametro As String)

        Dim i As Integer = 0
        While i < ds_vehiculos.Tables(0).Rows.Count
            Dim buscaraqui As String = CStr(ds_vehiculos.Tables(0).Rows(i).Item("VehiculoMarca")).ToUpper
            Dim buscaresto As String = CStr(tb_Buscar.Text).ToUpper
            Dim primer_caracter_encontrado As Integer = buscaraqui.IndexOf(buscaresto)
            If CStr(ds_vehiculos.Tables(0).Rows(i).Item("VehiculoPatente")) = CStr(tb_Buscar.Text) Or primer_caracter_encontrado <> -1 Then
                'si lo encuentro lo agrego
                Dim Ds = DaVehiObra.Vehiculo_Verficiar(ds_vehiculos.Tables(0).Rows(i).Item("VehiculoId"))
                Dim row As DataRow = DatasetVisual_Vehiculos.Tables("Vehiculo").NewRow()

                row("VehiculoId") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoId")
                row("VehiculoPatente") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoPatente")
                row("VehiculoMarca") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoMarca")
                row("VehiculoModelo") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoModelo")
                row("VehiculoAño") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoAño")
                row("VehiculoTipo") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoTipo")
                row("VehiculoEstado") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoEstado")
                If Ds.Tables(0).Rows.Count = 0 Then
                    row("Obra") = "Sin Asignar"
                Else
                    row("Obra") = "Asignado"
                End If

                DatasetVisual_Vehiculos.Tables("Vehiculo").Rows.Add(row)

            End If


            i = i + 1
        End While

    End Sub

    Private Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())
        ObraId = GridView2.Rows(index).Cells(0).Text


        If Session("ID_Vehi") <> 0 Then
            'dsVehiObra = DaVehiObra.VehiculoObra_Verficiar(Session("ID_Vehi"), ObraId)
            'If dsVehiObra.Tables(0).Rows.Count = 0 Then

            'Libero El Vehiculo
            'If dsVehiObra.Tables(1).Rows.Count <> 0 Then
            '    DaVehiObra.Vehiculo_Liberar(Session("ID_Vehi"), dsVehiObra.Tables(1).Rows(0).Item("VehiculoId"))
            'End If


            'Asigno la Nueva Obra
            DaVehiObra.Asignar_vehiculo(Session("ID_Vehi"), ObraId, Now)

            Response.Redirect("Vehiculo_Consulta.aspx")
            'GridView1.Visible = False
            'GridView2.Visible = False
            'btn_Agregar.Visible = False
            'btn_Agregar2.Visible = False
            'tb_Buscar.Visible = False
            'Btn_buscar.Visible = False
            'div_BuscarO.Visible = False

            card_OK.Visible = True

            'Div_ErrVehi.Visible = False
            'Div_Div_ErrVehi_text.Visible = False

            'lbl_Err.Visible = False
            'Campos.Visible = False

            'Else

            '    lbl_Err.Visible = True
            '    Campos.Visible = True

            '    Div_ErrVehi.Visible = False
            '    Div_Div_ErrVehi_text.Visible = False
            'End If
            Session("ID_Vehi") = 0
        Else
            Div_ErrVehi.Visible = True
            Div_Div_ErrVehi_text.Visible = True

            lbl_Err.Visible = False
            Campos.Visible = False

        End If


    End Sub
    Private Sub BuscarObra(ByVal parametro As String)
        Dim i As Integer = 0
        While i < ds_Obras.Tables(0).Rows.Count
            Dim buscaraqui As String = CStr(ds_Obras.Tables(0).Rows(i).Item("ObraNombre")).ToUpper
            Dim buscaresto As String = CStr(Tb_BuscarObra.Text).ToUpper
            Dim primer_caracter_encontrado As Integer = buscaraqui.IndexOf(buscaresto)
            If CStr(ds_Obras.Tables(0).Rows(i).Item("ObraId")) = CStr(Tb_BuscarObra.Text) Or primer_caracter_encontrado <> -1 Then
                'si lo encuentro lo agrego

                Dim row As DataRow = DatasetObra.Tables("Obtener_todo").NewRow()

                row("ObraId") = ds_Obras.Tables(0).Rows(i).Item("ObraId")
                row("ObraNombre") = ds_Obras.Tables(0).Rows(i).Item("ObraNombre")
                row("ObraDescripcion") = ds_Obras.Tables(0).Rows(i).Item("ObraDescripcion")
                row("ObraDomicilio") = ds_Obras.Tables(0).Rows(i).Item("ObraDomicilio")
                row("ObraLocalidad") = ds_Obras.Tables(0).Rows(i).Item("ObraLocalidad")
                row("ObraFechaInicio") = ds_Obras.Tables(0).Rows(i).Item("ObraFechaInicio")
                row("ObraFechaFinal") = ds_Obras.Tables(0).Rows(i).Item("ObraFechaFinal")


                DatasetObra.Tables("Obtener_todo").Rows.Add(row)

            End If


            i = i + 1
        End While
    End Sub
    Private Sub btn_BuscarObra_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_BuscarObra.Click
        ds_Obras = DAobra.Obra_Obtener_todo()
        DatasetObra.Tables("Obtener_todo").Rows.Clear()
        BuscarObra(Tb_BuscarObra.Text)


        GridView2.DataSource = DatasetObra.Tables("Obtener_todo")
        GridView2.DataBind()
    End Sub
    Private Sub Filtrar_Vehiculos(ByVal Drop As String)
        Dim i As Integer = 0
        While i < ds_vehiculos.Tables(0).Rows.Count

            If ds_vehiculos.Tables(0).Rows(i).Item("VehiculoEstado") = Drop Then

                Dim row As DataRow = DatasetVisual_Vehiculos.Tables("Vehiculo").NewRow()
                Dim Ds = DaVehiObra.Vehiculo_Verficiar(ds_vehiculos.Tables(0).Rows(i).Item("VehiculoId"))
                row("VehiculoId") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoId")
                row("VehiculoPatente") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoPatente")
                row("VehiculoMarca") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoMarca")
                row("VehiculoModelo") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoModelo")
                row("VehiculoAño") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoAño")
                row("VehiculoTipo") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoTipo")
                row("VehiculoEstado") = ds_vehiculos.Tables(0).Rows(i).Item("VehiculoEstado")
                If Ds.Tables(0).Rows.Count = 0 Then
                    row("Obra") = "Sin Asignar"
                Else
                    row("Obra") = "Asignado"
                End If

                DatasetVisual_Vehiculos.Tables("Vehiculo").Rows.Add(row)

            End If

            i = i + 1

        End While

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        DatasetVisual_Vehiculos.Tables("Vehiculo").Rows.Clear()
        If DropDownList1.SelectedValue = "Todos" Then
            Traer_vehiculos()
        Else
            Filtrar_Vehiculos(DropDownList1.SelectedValue)
        End If


        GridView1.DataSource = DatasetVisual_Vehiculos.Tables("Vehiculo")
        GridView1.DataBind()




    End Sub
End Class