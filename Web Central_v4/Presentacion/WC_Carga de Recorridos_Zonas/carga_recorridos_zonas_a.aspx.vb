Public Class carga_recorridos_zonas_a
    Inherits System.Web.UI.Page
    Dim DAparametro As New Capa_Datos.WC_parametro
    Dim DArecorrido As New Capa_Datos.WC_recorridos_zonas
    Dim DApuntos As New Capa_Datos.WC_puntos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            'AQUI VALIDO, SI NO HAY NINGUNA FECHA EN LA TABLA PARAMETRO, PONGO UN MENSAJE MODAL QUE DIGA:
            'ERROR, PRIMERO DEBE INICIAR DIA.
            Dim ds_info As DataSet = DAparametro.Parametro_obtener_dia
            If ds_info.Tables(0).Rows.Count <> 0 Then
                'cargo la fecha y el dia en los textbox
                HF_parametro_id.Value = ds_info.Tables(0).Rows(0).Item("Parametro_id")
                Dim FECHA As Date = CDate(ds_info.Tables(0).Rows(0).Item("Fecha"))
                Txt_fecha.Text = FECHA.ToString("yyyy-MM-dd")
                Dim dia As Integer = CInt(ds_info.Tables(0).Rows(0).Item("Dia"))
                HF_dia_id.Value = dia
                Select Case dia
                    Case 1
                        Label_dia.Text = "DIA: DOMINGO."
                    Case 2
                        Label_dia.Text = "DIA: LUNES."
                    Case 3
                        Label_dia.Text = "DIA: MARTES."
                    Case 4
                        Label_dia.Text = "DIA: MIERCOLES."
                    Case 5
                        Label_dia.Text = "DIA: JUEVES."
                    Case 6
                        Label_dia.Text = "DIA: VIERNES."
                    Case 7
                        Label_dia.Text = "DIA: SABADO."
                End Select
                mostrar_zonas_habilitadas(dia)


            Else
                'AQUI MENSAJE Y QUE CON EL BOTON "OK" U "CLOSE" VUELVA AL MENU PRINCIPAL.
                ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-ok_error", "$(document).ready(function () {$('#modal-ok_error').modal();});", True)
            End If
            Txt_fecha.Enabled = False
            txt_zona.Focus()
        End If
    End Sub

    Private Sub verificar_puntos_guardados(ByVal dia As Integer, ByVal codigo As String)

        Dim ds_info As DataSet = DApuntos.Puntos_obtener_cargados(Txt_fecha.Text, dia, codigo)
        If ds_info.Tables(0).Rows.Count <> 0 Then
            Select Case codigo
                Case "1A"
                    Lb_1A.ForeColor = Drawing.Color.ForestGreen

                Case "1B"
                    Lb_1B.ForeColor = Drawing.Color.ForestGreen

                Case "1C"
                    Lb_1C.ForeColor = Drawing.Color.ForestGreen
                Case "1D"
                    Lb_1D.ForeColor = Drawing.Color.ForestGreen
                Case "1E"
                    Lb_1E.ForeColor = Drawing.Color.ForestGreen
                Case "1F"
                    Lb_1F.ForeColor = Drawing.Color.ForestGreen
                Case "1G"
                    Lb_1G.ForeColor = Drawing.Color.ForestGreen
                Case "1H"
                    Lb_1H.ForeColor = Drawing.Color.ForestGreen
                Case "1I"
                    Lb_1I.ForeColor = Drawing.Color.ForestGreen
                Case "IJ"
                    Lb_1J.ForeColor = Drawing.Color.ForestGreen


                Case "2A"
                    Lb_2A.ForeColor = Drawing.Color.ForestGreen
                Case "2B"
                    Lb_2B.ForeColor = Drawing.Color.ForestGreen
                Case "2C"
                    Lb_2C.ForeColor = Drawing.Color.ForestGreen
                Case "2D"
                    Lb_2D.ForeColor = Drawing.Color.ForestGreen
                Case "2E"
                    Lb_2E.ForeColor = Drawing.Color.ForestGreen
                Case "2F"
                    Lb_2F.ForeColor = Drawing.Color.ForestGreen
                Case "2G"
                    Lb_2G.ForeColor = Drawing.Color.ForestGreen
                Case "2H"
                    Lb_2H.ForeColor = Drawing.Color.ForestGreen
                Case "2I"
                    Lb_2I.ForeColor = Drawing.Color.ForestGreen
                Case "2J"
                    Lb_2J.ForeColor = Drawing.Color.ForestGreen

                Case "3A"
                    Lb_3A.ForeColor = Drawing.Color.ForestGreen
                Case "3B"
                    Lb_3B.ForeColor = Drawing.Color.ForestGreen
                Case "3C"
                    Lb_3C.ForeColor = Drawing.Color.ForestGreen
                Case "3D"
                    Lb_3D.ForeColor = Drawing.Color.ForestGreen
                Case "3E"
                    Lb_3E.ForeColor = Drawing.Color.ForestGreen
                Case "3F"
                    Lb_3F.ForeColor = Drawing.Color.ForestGreen
                Case "3G"
                    Lb_3G.ForeColor = Drawing.Color.ForestGreen
                Case "3H"
                    Lb_3H.ForeColor = Drawing.Color.ForestGreen
                Case "3I"
                    Lb_3I.ForeColor = Drawing.Color.ForestGreen
                Case "3J"
                    Lb_3J.ForeColor = Drawing.Color.ForestGreen

                Case "4A"
                    Lb_4A.ForeColor = Drawing.Color.ForestGreen
                Case "4B"
                    Lb_4B.ForeColor = Drawing.Color.ForestGreen
                Case "4C"
                    Lb_4C.ForeColor = Drawing.Color.ForestGreen
                Case "4D"
                    Lb_4D.ForeColor = Drawing.Color.ForestGreen
                Case "4E"
                    Lb_4E.ForeColor = Drawing.Color.ForestGreen
                Case "4F"
                    Lb_4F.ForeColor = Drawing.Color.ForestGreen
                Case "4G"
                    Lb_4G.ForeColor = Drawing.Color.ForestGreen
                Case "4H"
                    Lb_4H.ForeColor = Drawing.Color.ForestGreen
                Case "4I"
                    Lb_4I.ForeColor = Drawing.Color.ForestGreen
                Case "4J"
                    Lb_4J.ForeColor = Drawing.Color.ForestGreen
            End Select
        End If

    End Sub



    Private Sub mostrar_zonas_habilitadas(ByVal dia As Integer)
        Dim DS_Recorridos As DataSet = DArecorrido.recorridos_zonas_obtener_habilitados_x_dia(dia)
        'inicialmente tengo los label de zonas en "visible=false"
        Dim i As Integer = 0
        While i < DS_Recorridos.Tables(0).Rows.Count
            Dim codigo As String = DS_Recorridos.Tables(0).Rows(i).Item("Codigo")
            Select Case codigo
                Case "1A"
                    Div_1A.Visible = True

                Case "1B"
                    Div_1B.Visible = True
                Case "1C"
                    Div_1C.Visible = True
                Case "1D"
                    Div_1D.Visible = True
                Case "1E"
                    Div_1E.Visible = True
                Case "1F"
                    Div_1F.Visible = True
                Case "1G"
                    Div_1G.Visible = True
                Case "1H"
                    Div_1H.Visible = True
                Case "1I"
                    Div_1I.Visible = True
                Case "IJ"
                    Div_1J.Visible = True


                Case "2A"
                    Div_2A.Visible = True
                Case "2B"
                    Div_2B.Visible = True
                Case "2C"
                    Div_2C.Visible = True
                Case "2D"
                    Div_2D.Visible = True
                Case "2E"
                    Div_2E.Visible = True
                Case "2F"
                    Div_2F.Visible = True
                Case "2G"
                    Div_2G.Visible = True
                Case "2H"
                    Div_2H.Visible = True
                Case "2I"
                    Div_2I.Visible = True
                Case "2J"
                    Div_2J.Visible = True


                Case "3A"
                    Div_3A.Visible = True
                Case "3B"
                    Div_3B.Visible = True
                Case "3C"
                    Div_3C.Visible = True
                Case "3D"
                    Div_3D.Visible = True
                Case "3E"
                    Div_3E.Visible = True
                Case "3F"
                    Div_3F.Visible = True
                Case "3G"
                    Div_3G.Visible = True
                Case "3H"
                    Div_3H.Visible = True
                Case "3I"
                    Div_3I.Visible = True
                Case "3J"
                    Div_3J.Visible = True

                Case "4A"
                    Div_4A.Visible = True
                Case "4B"
                    Div_4B.Visible = True
                Case "4C"
                    Div_4C.Visible = True
                Case "4D"
                    Div_4D.Visible = True
                Case "4E"
                    Div_4E.Visible = True
                Case "4F"
                    Div_4F.Visible = True
                Case "4G"
                    Div_4G.Visible = True
                Case "4H"
                    Div_4H.Visible = True
                Case "4I"
                    Div_4I.Visible = True
                Case "4J"
                    Div_4J.Visible = True
            End Select
            verificar_puntos_guardados(dia, codigo)
            i = i + 1
        End While




    End Sub

    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Private Sub BOTON_GRABAR_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOTON_GRABAR.ServerClick

        Dim ds_validar As DataSet = DArecorrido.recorridos_zonas_buscar_codigo(txt_zona.Text.ToUpper, HF_dia_id.Value)
        If ds_validar.Tables(0).Rows.Count <> 0 Then
            Session("fecha") = Txt_fecha.Text
            Session("id_recorrido") = ds_validar.Tables(0).Rows(0).Item("Idrecorrido")
            Response.Redirect("~/WC_Carga de Recorridos_Zonas/carga_recorridos_zonas_b.aspx")
        Else
            ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal_ok_error_op", "$(document).ready(function () {$('#modal_ok_error_op').modal();});", True)
        End If



        
    End Sub

    Private Sub btn_error_close_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_error_close.ServerClick
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Private Sub btn_ok_error_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok_error.ServerClick
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Private Sub btn_error_op_close_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_error_op_close.ServerClick
        txt_zona.Focus()
    End Sub

    Private Sub btn_ok_error_op_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok_error_op.ServerClick
        txt_zona.Focus()
    End Sub
End Class