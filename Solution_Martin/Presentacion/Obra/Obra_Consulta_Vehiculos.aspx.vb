Public Class Obra_Consulta_Vehiculos
    Inherits System.Web.UI.Page
    Dim DAvehiculos As New Capa_Datos.Vehiculo
    Dim ds_vehiculos As DataSet
    Dim DatasetVisual_Vehiculos As New DS_Vehiculo

    Dim DAobra As New Capa_Datos.Obra
    Dim ds_Obras As DataSet
    Dim DatasetObra As New Ds_Obra

    Dim DaVehiObra As New Capa_Datos.VehiculoObra

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb_Domicilio.Text = Session("ObraDir")
        tb_fecha.Text = Session("ObraFecha")
        tb_nombre.Text = Session("ObraNombre")
        tb_Domicilio.Enabled = False
        tb_fecha.Enabled = False
        tb_nombre.Enabled = False
        Dim i = 0

        Dim ds_vehiculos2 = DAvehiculos.Vehiculo_ObtenerTodo


        While i < ds_vehiculos2.Tables(0).Rows.Count
            Dim ds_Todo_vehi = DaVehiObra.Vehiculo_Verficiar(ds_vehiculos2.Tables(0).Rows(i).Item("VehiculoId"))
            Dim row As DataRow = DatasetVisual_Vehiculos.Tables("Vehiculo").NewRow()
            If ds_Todo_vehi.Tables(0).Rows(0).Item("ObraId") = Session("ID_Obra_OCV") Then

                row("VehiculoId") = ds_vehiculos2.Tables(0).Rows(i).Item("VehiculoId")
                row("VehiculoPatente") = ds_vehiculos2.Tables(0).Rows(i).Item("VehiculoPatente")
                row("VehiculoMarca") = ds_vehiculos2.Tables(0).Rows(i).Item("VehiculoMarca")
                row("VehiculoModelo") = ds_vehiculos2.Tables(0).Rows(i).Item("VehiculoModelo")
                row("VehiculoAño") = ds_vehiculos2.Tables(0).Rows(i).Item("VehiculoAño")
                row("VehiculoTipo") = ds_vehiculos2.Tables(0).Rows(i).Item("VehiculoTipo")
                row("VehiculoEstado") = ds_vehiculos2.Tables(0).Rows(i).Item("VehiculoEstado")

                DatasetVisual_Vehiculos.Tables("Vehiculo").Rows.Add(row)

            End If


            i = i + 1

        End While

        GridView1.DataSource = DatasetVisual_Vehiculos.Tables("Vehiculo")
        GridView1.DataBind()


        'Dim ds_vehiculos = DaVehiObra.VehiculoObra_Obtener_X_Obra(Session("ID_Obra_OCV"))

        'If ds_vehiculos.Tables(0).Rows.Count <> 0 Then


        '    DatasetVisual_Vehiculos.Vehiculo.Merge(ds_vehiculos.Tables(0))
        '    GridView1.DataSource = DatasetVisual_Vehiculos
        '    GridView1.DataBind()
        'End If

    End Sub

    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If (e.CommandName = "Liberar") Then
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString())

            DaVehiObra.Vehiculo_Liberar(GridView1.Rows(index).Cells(0).Text(), Now)
            Response.Redirect("../Obra/Obra_Consulta_Vehiculos.aspx")
        End If

    End Sub

    Private Sub btn_Volver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Volver.Click
        Response.Redirect("../Obra/Obra_Consulta.aspx")
    End Sub
End Class