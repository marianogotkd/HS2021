Public Class Vehiculo_Historico
    Inherits System.Web.UI.Page
    Dim DaVehiObra As New Capa_Datos.VehiculoObra
    Dim dsHistorial As New DS_Vehiculo
    Dim ds As New DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds = DaVehiObra.Vehiculo_historial(Session("ID_Vehi_hist"))
        If ds.Tables(0).Rows.Count <> 0 Then
            tb_marca.Text = ds.Tables(0).Rows(0).Item("VehiculoMarca")
            tb_modelo.Text = ds.Tables(0).Rows(0).Item("VehiculoModelo")
            tb_patente.Text = ds.Tables(0).Rows(0).Item("VehiculoPatente")

            GridView1.DataSource = ds.Tables(0)
            GridView1.DataBind()

        End If
      
    End Sub

    Private Sub Volver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Volver.Click
        Response.Redirect("Vehiculo_Consulta.aspx")
    End Sub
End Class