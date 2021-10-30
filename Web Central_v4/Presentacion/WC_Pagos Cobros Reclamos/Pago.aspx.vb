Public Class Pago
    Inherits System.Web.UI.Page
    Dim Dacliente As New Capa_Datos.WB_clientes
    Dim DAparametro As New Capa_Datos.WC_parametro
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Txt_cliente_codigo.Focus()
            Txt_nombre.ReadOnly = True
            Txt_saldo.ReadOnly = True



        End If
    End Sub

    Private Sub btn_buscar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_buscar.ServerClick
        Try

            Dim ds_validar As DataSet = Dacliente.Clientes_buscar_codigo(Txt_cliente_codigo.Text)
            If ds_validar.Tables(0).Rows.Count <> 0 Then
                Txt_nombre.Text = ds_validar.Tables(0).Rows(0).Item("Nombre")
                Txt_saldo.Text = ds_validar.Tables(0).Rows(0).Item("Saldo")
                Txt_importe.Focus()
            Else
                'mensaje la busqueda no arrojo resultados.
                Txt_nombre.Text = ""
                Txt_saldo.Text = ""
                ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_error_noexiste", "$(document).ready(function () {$('#modal-sm_error_noexiste').modal();});", True)
            End If

        Catch ex As Exception

        End Try
    End Sub

#Region "modal-sm_error_noexiste"
    Private Sub btn_close_error_noexiste_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_close_error_noexiste.ServerClick
        Txt_cliente_codigo.Focus()
    End Sub

    Private Sub btn_ok_error_noexiste_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok_error_noexiste.ServerClick
        Txt_cliente_codigo.Focus()
    End Sub
#End Region

    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("~/WC_Pagos Cobros Reclamos/PagosCobrosReclamos.aspx")
    End Sub

    Private Sub Txt_cliente_codigo_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_cliente_codigo.Init
        Txt_cliente_codigo.Attributes.Add("onfocus", "seleccionarTexto(this);")
    End Sub

    Private Sub Txt_nombre_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_nombre.Init
        Txt_nombre.Attributes.Add("onfocus", "seleccionarTexto(this);")
    End Sub

    Private Sub Txt_saldo_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_saldo.Init
        Txt_saldo.Attributes.Add("onfocus", "seleccionarTexto(this);")
    End Sub

    Private Sub Txt_importe_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_importe.Init
        Txt_importe.Attributes.Add("onfocus", "seleccionarTexto(this);")
    End Sub

#Region "Mdl_graba"
    Private Sub btn_graba_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_graba_cancelar.ServerClick
        Txt_importe.Focus()
    End Sub

    Private Sub btn_graba_close_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_graba_close.ServerClick
        Txt_importe.Focus()
    End Sub

    Private Sub btn_graba_confirmar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_graba_confirmar.ServerClick
        'aqui guardo y abro el mensaje siguiente


        ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "modal-sm_OKGRABADO", "$(document).ready(function () {$('#modal-sm_OKGRABADO').modal();});", True)
    End Sub
#End Region


    Private Sub btn_ok_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok.ServerClick
        Response.Redirect("~/WC_Pagos Cobros Reclamos/PagosCobrosReclamos.aspx")
    End Sub

    Private Sub btn_ok_close_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ok_close.ServerClick
        Response.Redirect("~/WC_Pagos Cobros Reclamos/PagosCobrosReclamos.aspx")
    End Sub

    Private Sub BOTON_GRABA_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOTON_GRABA.ServerClick
        ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "Mdl_graba", "$(document).ready(function () {$('#Mdl_graba').modal();});", True)
    End Sub

End Class