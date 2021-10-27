Public Class ab_recorridos_zonas_activacion
    Inherits System.Web.UI.Page
    Dim DA_recorridos As New Capa_Datos.WC_recorridos_zonas
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim dia As Integer = CInt(Session("dia_seleccionado"))
            HF_dia_nro.Value = dia
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
            obtener_estado_recorridos(dia)

            txt_1a.Focus()

        End If
    End Sub

    Public Function conv_bit(ByRef estado As Integer)
        If estado = -1 Then
            estado = 1
        Else
            If estado = 0 Then

            End If
        End If
        Return estado
    End Function

    Private Sub obtener_estado_recorridos(ByVal Dia_id As Integer)
        Dim ds_recorridos As DataSet = DA_recorridos.recorridos_zonas_consultar_dia(Dia_id)
        If ds_recorridos.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < ds_recorridos.Tables(0).Rows.Count
                Dim codigo As String = ds_recorridos.Tables(0).Rows(i).Item("Codigo")
                Select Case codigo
                    Case "1A"
                        txt_1a.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1B"
                        txt_1b.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1C"
                        txt_1c.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1D"
                        txt_1d.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1E"
                        txt_1e.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1F"
                        txt_1f.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1G"
                        txt_1g.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1H"
                        txt_1h.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1I"
                        txt_1i.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "1J"
                        txt_1j.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2A"
                        txt_2a.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2B"
                        txt_2b.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2C"
                        txt_2c.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2D"
                        txt_2d.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2E"
                        txt_2e.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2F"
                        txt_2f.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2G"
                        txt_2g.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2H"
                        txt_2h.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2I"
                        txt_2i.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "2J"
                        txt_2j.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))

                    Case "3A"
                        txt_3a.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3B"
                        txt_3b.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3C"
                        txt_3c.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3D"
                        txt_3d.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3E"
                        txt_3e.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3F"
                        txt_3f.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3G"
                        txt_3g.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3H"
                        txt_3h.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3I"
                        txt_3i.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "3J"
                        txt_3j.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))

                    Case "4A"
                        txt_4a.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4B"
                        txt_4b.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4C"
                        txt_4c.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4D"
                        txt_4d.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4E"
                        txt_4e.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4F"
                        txt_4f.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4G"
                        txt_4g.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4H"
                        txt_4h.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4I"
                        txt_4i.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                    Case "4J"
                        txt_4j.Text = conv_bit(CInt(ds_recorridos.Tables(0).Rows(i).Item("Habilitada")))
                End Select

                i = i + 1
            End While
        End If


    End Sub



    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("~/WC_AB Recorridos_Zonas/ab_recorridos_zonas.aspx")
    End Sub


    Private Sub BOTON_GRABAR_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOTON_GRABAR.ServerClick
        Try
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1A", CInt(txt_1a.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1B", CInt(txt_1b.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1C", CInt(txt_1c.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1D", CInt(txt_1d.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1E", CInt(txt_1e.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1F", CInt(txt_1f.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1G", CInt(txt_1g.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1H", CInt(txt_1h.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1I", CInt(txt_1i.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "1J", CInt(txt_1j.Text))

            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2A", CInt(txt_2a.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2B", CInt(txt_2b.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2C", CInt(txt_2c.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2D", CInt(txt_2d.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2E", CInt(txt_2e.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2F", CInt(txt_2f.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2G", CInt(txt_2g.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2H", CInt(txt_2h.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2I", CInt(txt_2i.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "2J", CInt(txt_2j.Text))

            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3A", CInt(txt_3a.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3B", CInt(txt_3b.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3C", CInt(txt_3c.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3D", CInt(txt_3d.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3E", CInt(txt_3e.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3F", CInt(txt_3f.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3G", CInt(txt_3g.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3H", CInt(txt_3h.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3I", CInt(txt_3i.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "3J", CInt(txt_3j.Text))

            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4A", CInt(txt_4a.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4B", CInt(txt_4b.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4C", CInt(txt_4c.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4D", CInt(txt_4d.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4E", CInt(txt_4e.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4F", CInt(txt_4f.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4G", CInt(txt_4g.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4H", CInt(txt_4h.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4I", CInt(txt_4i.Text))
            DA_recorridos.recorridos_zonas_activacion(CInt(HF_dia_nro.Value), "4J", CInt(txt_4j.Text))
            ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_OKGRABADO", "$(document).ready(function () {$('#modal-sm_OKGRABADO').modal();});", True)

        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_error", "$(document).ready(function () {$('#modal-sm_error').modal();});", True)

        End Try

        



    End Sub

    Private Sub btn_ok_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok.ServerClick
        Response.Redirect("~/WC_AB Recorridos_Zonas/ab_recorridos_zonas.aspx")
    End Sub

    Private Sub btn_graba_close_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_graba_close.ServerClick
        Response.Redirect("~/WC_AB Recorridos_Zonas/ab_recorridos_zonas.aspx")
    End Sub

    Private Sub btn_close_error_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_close_error.ServerClick
        txt_1a.Focus()
    End Sub

    Private Sub btn_ok_error_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok_error.ServerClick
        txt_1a.Focus()
    End Sub
End Class