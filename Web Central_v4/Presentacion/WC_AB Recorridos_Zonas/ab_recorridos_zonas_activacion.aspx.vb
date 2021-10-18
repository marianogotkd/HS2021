Public Class ab_recorridos_zonas_activacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim dia As Integer = CInt(Session("dia_seleccionado"))
            Select Case dia
                Case 1
                    Label_dia.Text = "DIA: DOMINGO"
                Case 2
                    Label_dia.Text = "DIA: LUNES"
                Case 3
                    Label_dia.Text = "DIA: MARTES"
                Case 4
                    Label_dia.Text = "DIA: MIERCOLES"
                Case 5
                    Label_dia.Text = "DIA: JUEVES"
                Case 6
                    Label_dia.Text = "DIA: VIERNES"
                Case 7
                    Label_dia.Text = "DIA: SABADO"
            End Select

            txt_1a.Focus()

        End If
    End Sub

    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("~/WC_AB Recorridos_Zonas/ab_recorridos_zonas.aspx")
    End Sub
End Class