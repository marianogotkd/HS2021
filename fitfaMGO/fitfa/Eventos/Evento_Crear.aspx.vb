Imports System.Drawing
Imports System.IO
Public Class Evento_Crear
    Inherits System.Web.UI.Page
    Dim DAevento As New Capa_de_datos.Eventos
    Dim tamanio As Integer
    Dim ImagenOriginal As Byte()
    Dim ImagenOriginalBinaria As Bitmap
    Dim ImagenDataURL64 As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Session("imagen") = ""
            Session("foto_subido") = "no"
            lbl_errFecCier.Visible = False
            lbl_errNom.Visible = False
            lbl_costo.Visible = False
            lbl_errfechaini.Visible = False
            lbl_horaCierre.Visible = False
            'lbl_errImg.Visible = False
            tb_fechainicio.Value = Today
            tb_fechaCierre.Value = Today
            textbox_Costo.Text = 0
            Page.Form.Attributes.Add("enctype", "multipart/form-data")
            div_modal_msjOK.Visible = False
            crear_tabla_turnos()
        End If


    End Sub

    Private Sub crear_tabla_turnos()
        GridView1.DataSource = Nothing
        Dim ds_eventos As New ds_eventos
        ds_eventos.Tables("Turnos").Rows.Clear()
        Dim cont = 0
        Dim horas As Integer = 8
        While cont < 14
            Dim row As DataRow = ds_eventos.Tables("Turnos").NewRow()
            row("Turno") = CStr(horas) + " hrs."

            ds_eventos.Tables("Turnos").Rows.Add(row)
            cont = cont + 1
            horas = horas + 1
        End While
        GridView1.DataSource = ds_eventos.Tables("Turnos")
        GridView1.DataBind()
    End Sub



#Region "manejo de foto"
    Public Function ImageControlToByteArray(ByVal foto)
        Return File.ReadAllBytes(Server.MapPath(foto.ImageUrl))
    End Function

#End Region

    Private Sub btn_guardar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_guardar.ServerClick

        Dim Vacio As Boolean

        If tb_nombre.Value = "" Then
            lbl_errNom.Visible = True
            Vacio = True
        End If

        If tb_fechainicio.Value = "" Then
            lbl_errfechaini.Visible = True
            Vacio = True
        End If

        If tb_fechaCierre.Value = "" Then
            lbl_errFecCier.Visible = True
            Vacio = True
        End If

        If tb_horaCierre.Value = "" Then
            lbl_horaCierre.Visible = True
            Vacio = True
        End If
        Dim costo = textbox_Costo.Text
        If Session("foto_subido") = "no" Then
            Dim imagebytes As Byte() = ImageControlToByteArray(Image1)
            Session("imagen") = imagebytes
        End If
        Dim FechaHoraCierre = tb_fechaCierre.Value + " " + tb_horaCierre.Value
        If Vacio = False Then

            If combo_TipoEvento.SelectedValue = "Examen" Then
                'aqui paso a otra web page para cargar los turnos de los examenes.

                Response.Redirect("~/Eventos/Examenes_turnos_agregar.aspx")

            Else
                'es un torneo o un curso
                If costo = "" Then
                    DAevento.Eventos_Alta(tb_nombre.Value, Session("imagen"), tb_fechainicio.Value, FechaHoraCierre, combo_TipoEvento.SelectedValue, CDec(0), tb_direccion.Value)
                Else
                    DAevento.Eventos_Alta(tb_nombre.Value, Session("imagen"), tb_fechainicio.Value, FechaHoraCierre, combo_TipoEvento.SelectedValue, CDec(costo), tb_direccion.Value)
                End If

                div_modal_msjOK.Visible = True
                Modal_msjOK.Show()
            End If

            

            'Response.Redirect("~/Eventos/Evento_Crear.aspx")

            'lbl_ok.Visible = True
            'tb_nombre.Value = ""
            'tb_fechainicio.Value = Today
            'tb_fechaCierre.Value = Today
            'tb_horaCierre.Value = ""
            'textbox_Costo.Text = 0
            'FileUpload1.Attributes.Clear()
            'Image1.Visible = False
            'btn_quitar.Visible = False
            'btn_Examinar.Visible = True
        End If



    End Sub

    Private Sub combo_TipoEvento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_TipoEvento.SelectedIndexChanged

        If combo_TipoEvento.SelectedValue = "Examen" Then
            Panel_examenes.Visible = True
        Else
            Panel_examenes.Visible = False
        End If

    End Sub
End Class