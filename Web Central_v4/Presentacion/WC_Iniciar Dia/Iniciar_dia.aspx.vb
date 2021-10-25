Public Class Iniciar_dia
    Inherits System.Web.UI.Page
    Dim DArecorrido As New Capa_Datos.WC_recorridos_zonas
    Dim DAparametro As New Capa_Datos.WC_parametro

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Dim fecha As Date = Today
            Txt_fecha.Text = fecha.ToString("yyyy-MM-dd")


            Select Case fecha.DayOfWeek
                Case DayOfWeek.Sunday 'domingo
                    txt_dia.Text = 1
                Case DayOfWeek.Monday 'lunes
                    txt_dia.Text = 2
                Case DayOfWeek.Tuesday 'martes
                    txt_dia.Text = 3
                Case DayOfWeek.Wednesday 'miercoles
                    txt_dia.Text = 4
                Case DayOfWeek.Thursday 'jueves
                    txt_dia.Text = 5
                Case DayOfWeek.Friday 'viernes
                    txt_dia.Text = 6
                Case DayOfWeek.Saturday 'sabado
                    txt_dia.Text = 7
            End Select

            Txt_fecha.Focus()



            'colocar por defecto el dia en base a la fecha actua "today"


        End If


    End Sub
    Private Sub limpiar()
        lb_error_fecha.Visible = False
    End Sub

    Private Sub btn_ok_error_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok_error.ServerClick
        Txt_fecha.Focus()
    End Sub

    Private Sub btn_close_error_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_close_error.ServerClick
        Txt_fecha.Focus()
    End Sub

    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Private Sub btn_grabar_close_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_grabar_close.ServerClick
        Txt_fecha.Focus()
    End Sub

    Private Sub btn_grabar_mdl_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_grabar_mdl_cancelar.ServerClick
        Txt_fecha.Focus()
    End Sub

    Private Sub btn_grabar_mdl_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_grabar_mdl.ServerClick
        limpiar()
        Dim valido_ingreso As String = "si"
        Dim fecha As Date
        If Txt_fecha.Text = "" Then
            valido_ingreso = "no"
            lb_error_fecha.Visible = True
        Else
            Try
                fecha = CDate(Txt_fecha.Text)
            Catch ex As Exception
                valido_ingreso = "no"
                lb_error_fecha.Visible = True
            End Try
        End If

        Dim dia As Integer
        Try
            dia = CInt(txt_dia.Text)
        Catch ex As Exception
            valido_ingreso = "no"

        End Try

        If valido_ingreso = "si" Then

            Dim ds_recorridos As DataSet = DArecorrido.recorridos_zonas_consultar_dia(dia)
            Dim recorrido As String = ""
            Dim i As Integer = 0
            While i < ds_recorridos.Tables(0).Rows.Count
                If ds_recorridos.Tables(0).Rows(i).Item("Habilitada") <> "0" Then
                    recorrido = recorrido + CStr(ds_recorridos.Tables(0).Rows(i).Item("Codigo"))
                End If

                i = i + 1
            End While

            'consulto que no exista ya datos cargados para dicha fecha.
            Dim ds_info As DataSet = DAparametro.Parametro_consultar_fecha(fecha)
            If ds_info.Tables(0).Rows.Count = 0 Then
                'alta
                DAparametro.Parametro_Iniciar_dia(fecha, dia, recorrido)
                'mensaje para notificar que se guardó correctamente.
                ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_OKGRABADO", "$(document).ready(function () {$('#modal-sm_OKGRABADO').modal();});", True)
            Else
                'mensaje para confirmar modificación.
                Dim Parametro_id As Integer = ds_info.Tables(0).Rows(0).Item("Parametro_id")
                Session("Parametro_id") = Parametro_id
                Session("recorrido") = recorrido
                ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "Mdl_modif", "$(document).ready(function () {$('#Mdl_modif').modal();});", True)

            End If
        Else
            ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_error", "$(document).ready(function () {$('#modal-sm_error').modal();});", True)
        End If


    End Sub

    Private Sub btn_ok_close_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok_close.ServerClick
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Private Sub btn_ok_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok.ServerClick
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Private Sub btn_modif_close_mdl_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modif_close_mdl.ServerClick
        Txt_fecha.Focus()
    End Sub

    Private Sub btn_modif_cancelar_mdl_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modif_cancelar_mdl.ServerClick
        Txt_fecha.Focus()
    End Sub

    Private Sub btn_modif_confirmar_mdl_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modif_confirmar_mdl.ServerClick
        limpiar()
        Dim valido_ingreso As String = "si"
        Dim fecha As Date
        If Txt_fecha.Text = "" Then
            valido_ingreso = "no"
            lb_error_fecha.Visible = True
        Else
            Try
                fecha = CDate(Txt_fecha.Text)
            Catch ex As Exception
                valido_ingreso = "no"
                lb_error_fecha.Visible = True
            End Try
        End If

        Dim dia As Integer
        Try
            dia = CInt(txt_dia.Text)
        Catch ex As Exception
            valido_ingreso = "no"

        End Try

        If valido_ingreso = "si" Then
            DAparametro.Parametro_modificar_dia(Session("Parametro_id"), fecha, dia, Session("recorrido"))
            Session("recorrido") = ""
            Session("Parametro_id") = ""
            'mensaje para notificar que se guardó correctamente.
            ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_OKGRABADO", "$(document).ready(function () {$('#modal-sm_OKGRABADO').modal();});", True)
        Else
            ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_error", "$(document).ready(function () {$('#modal-sm_error').modal();});", True)
        End If
    End Sub
End Class