﻿Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging
Public Class Evento_datos_b
    Inherits System.Web.UI.Page
    Dim DAeventos As New Capa_de_datos.Eventos
    Dim DAinscripciones As New Capa_de_datos.Inscripciones

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Form.Attributes.Add("enctype", "multipart/form-data")

        If Not IsPostBack Then
            popupMsjError.Visible = False
            popupMsjGuardado.Visible = False
            popupMsjError_turno.Visible = False 'choco 19-08-2021
            obtener_usuario()

            Dim ds_evento As DataSet = DAinscripciones.Inscripcion_consultar_evento(Session("evento_id"))
            Dim tipo_evento As String = ds_evento.Tables(0).Rows(0).Item("tipo_evento")
            If tipo_evento <> "Torneo" Then
                'no muestro la seccion de "Datos de competencia"
                seccion_competencia.Visible = False
                Label1.Text = ""
                DropDownList_graduacion.Enabled = False
            End If

            If tipo_evento = "Examen" Then
                seccion_examen.Visible = True
                Label_nombre_examen.Text = ds_evento.Tables(1).Rows(0).Item("evento_descripcion").ToString
                Label_fecha_examen.Text = ds_evento.Tables(1).Rows(0).Item("evento_fecha")
                Label_direccion_examen.Text = ds_evento.Tables(1).Rows(0).Item("evento_direccion").ToString
                'recupero los turnos para este examen puntual
                Try
                    DropDownList_examen_turno.DataSource = ds_evento.Tables(2)
                    DropDownList_examen_turno.DataTextField = "ExamenTurno_desc"
                    DropDownList_examen_turno.DataValueField = "ExamenTurno_id"
                    DropDownList_examen_turno.DataBind()
                Catch ex As Exception

                End Try

                'Session("evento_id") con este parametro obtengo los turnos del examen.

            End If



        End If
    End Sub


    Private Sub obtener_usuario()
        'OJO---ESTO FUNCIONA SIEMPRE QUE EL USUARIO ESTE EN RELACION DE DEPENDENCIA DE OTRO INSTRUCTOR...JERARQUICAMENTE HABLANDO. EL 9 DAN PUEDE FALLAR
        Lb_evento.Text = Session("evento_desc")
        Dim ds_usuario As DataSet = DAeventos.Evento_inscripcion_cargar(Session("Us_id"))
        If ds_usuario.Tables(0).Rows.Count <> 0 Then
            'aqui cargo en los label
            'DATOS PERSONALES
            Lb_dni.Text = ds_usuario.Tables(0).Rows(0).Item("dni")
            Lb_apenombre.Text = ds_usuario.Tables(0).Rows(0).Item("apenom")
            Lb_sexo.Text = ds_usuario.Tables(0).Rows(0).Item("sexo")
            Lb_edad.Text = ds_usuario.Tables(0).Rows(0).Item("Edad")
            'DATOS INSTITUCIONALES
            Lb_provincia.Text = ds_usuario.Tables(1).Rows(0).Item("provincia")
            Lb_institucion.Text = ds_usuario.Tables(1).Rows(0).Item("institucion") + "(" + ds_usuario.Tables(1).Rows(0).Item("abreviacion") + ")"
            Lb_instructor.Text = ds_usuario.Tables(1).Rows(0).Item("instructor")
            Dim graduacion_id As String = ds_usuario.Tables(3).Rows(0).Item("graduacion_id")
            ds_usuario.Tables(2).Merge(ds_usuario.Tables(3))
            'ds_usuario.Tables(2).Merge(ds_usuario.Tables(4)) ESTE ES UTIL, MUESTRA TAMBIEN LA GRADUACION SIGUIENTE
            DropDownList_graduacion.DataSource = ds_usuario.Tables(2)
            DropDownList_graduacion.DataTextField = "graduacion_desc"
            DropDownList_graduacion.DataValueField = "graduacion_id"
            DropDownList_graduacion.DataBind()
            DropDownList_graduacion.SelectedValue = graduacion_id
        End If
    End Sub

    Private Sub Obtener_graduaciones()
        'Dim ds_graduaciones As DataSet = DAusuario.Usuario_ObtenerGraduaciones()
        'If ds_graduaciones.Tables(0).Rows.Count <> 0 Then
        '    DropDownList_graduacion.DataSource = ds_graduaciones.Tables(0)
        '    DropDownList_graduacion.DataTextField = "graduacion_desc"
        '    DropDownList_graduacion.DataValueField = "graduacion_id"
        '    DropDownList_graduacion.DataBind()
        'End If
    End Sub

    Private Sub CodigoQR(ByVal inscripcion_id As Integer)

        Try
            Dim Encoder As New QRCodeEncoder

            Dim img As Bitmap = Encoder.Encode(inscripcion_id)
            Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) ' Use appropriate format here
            Dim byteImage As Byte() = ms.ToArray()

            DAinscripciones.inscripcion_imagenQR_Alta(inscripcion_id, byteImage)
        Catch ex As Exception

        End Try


    End Sub


    Private Sub Rotura_especial(ByVal inscripcion_id As Integer)
        If RadioButton_tecnica_si.Checked = True Then
            Dim ds_cat As DataSet = DAinscripciones.Inscripcion_obtener_categoria_roturaespecial()
            Dim i As Integer = 0
            While i < ds_cat.Tables(0).Rows.Count
                Dim edad_ini As Integer = CInt(ds_cat.Tables(0).Rows(i).Item("categoria_edadinicial"))
                Dim edad_fin As Integer = CInt(ds_cat.Tables(0).Rows(i).Item("categoria_edadfinal"))
                Dim graduaccion_selec As Integer = DropDownList_graduacion.SelectedValue
                Dim grad_inicial As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_gradinicial")
                Dim grad_final As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_gradfinal")
                Dim cat_sexo As String = ds_cat.Tables(0).Rows(i).Item("categoria_sexo").ToString
                Dim Categoria_id As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_id")
                If graduaccion_selec >= grad_inicial And graduaccion_selec <= grad_final Then
                    If CInt(Lb_edad.Text) >= CInt(edad_ini) And CInt(Lb_edad.Text) <= CInt(edad_fin) Then
                        Dim sexo_selec As String = Lb_sexo.Text
                        If cat_sexo = sexo_selec Then
                            'aqui guardo
                            DAinscripciones.Inscripcion_alta_categorias(inscripcion_id, Categoria_id)
                            i = ds_cat.Tables(0).Rows.Count
                        End If
                    End If
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub Rotura_Poder(ByVal inscripcion_id As Integer)
        If RadioButton_poder_si.Checked = True Then
            Dim ds_cat As DataSet = DAinscripciones.Inscripcion_obtener_categoria_roturapoder()
            Dim i As Integer = 0
            While i < ds_cat.Tables(0).Rows.Count
                Dim edad_ini As Integer = CInt(ds_cat.Tables(0).Rows(i).Item("categoria_edadinicial"))
                Dim edad_fin As Integer = CInt(ds_cat.Tables(0).Rows(i).Item("categoria_edadfinal"))
                Dim graduaccion_selec As Integer = DropDownList_graduacion.SelectedValue
                Dim grad_inicial As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_gradinicial")
                Dim grad_final As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_gradfinal")
                Dim cat_sexo As String = ds_cat.Tables(0).Rows(i).Item("categoria_sexo").ToString
                Dim Categoria_id As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_id")
                If graduaccion_selec >= grad_inicial And graduaccion_selec <= grad_final Then
                    If CInt(Lb_edad.Text) >= CInt(edad_ini) And CInt(Lb_edad.Text) <= CInt(edad_fin) Then

                        Dim sexo_selec As String = Lb_sexo.Text
                        If cat_sexo = sexo_selec Then
                            'aqui guardo
                            DAinscripciones.Inscripcion_alta_categorias(inscripcion_id, Categoria_id)
                            i = ds_cat.Tables(0).Rows.Count
                        End If
                    End If
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub forma(ByVal inscripcion_id As Integer)
        If RadioButton_formas_si.Checked = True Then
            'recupero las categorias de forma.
            Dim ds_cat As DataSet = DAinscripciones.Inscripcion_obtener_categoria()
            Dim i As Integer = 0
            While i < ds_cat.Tables(1).Rows.Count
                Dim edad_ini As Integer = CInt(ds_cat.Tables(1).Rows(i).Item("categoria_edadinicial"))
                Dim edad_fin As Integer = CInt(ds_cat.Tables(1).Rows(i).Item("categoria_edadfinal"))
                Dim graduaccion_selec As Integer = DropDownList_graduacion.SelectedValue
                Dim grad_inicial As Integer = ds_cat.Tables(1).Rows(i).Item("categoria_gradinicial")
                Dim grad_final As Integer = ds_cat.Tables(1).Rows(i).Item("categoria_gradfinal")
                Dim cat_sexo As String = ds_cat.Tables(1).Rows(i).Item("categoria_sexo").ToString
                Dim Categoria_id As Integer = ds_cat.Tables(1).Rows(i).Item("categoria_id")
                If graduaccion_selec >= grad_inicial And graduaccion_selec <= grad_final Then
                    If CInt(Lb_edad.Text) >= CInt(edad_ini) And CInt(Lb_edad.Text) <= CInt(edad_fin) Then
                        If cat_sexo <> "AMBOS SEXOS" Then
                            Dim sexo_selec As String = Lb_sexo.Text
                            If cat_sexo = sexo_selec Then
                                'aqui guardo
                                DAinscripciones.Inscripcion_alta_categorias(inscripcion_id, Categoria_id)
                                i = ds_cat.Tables(1).Rows.Count
                            End If
                        Else
                            'como no me importa el sexo guardo
                            Dim sexo_selec As String = Lb_sexo.Text
                            DAinscripciones.Inscripcion_alta_categorias(inscripcion_id, Categoria_id)
                            i = ds_cat.Tables(1).Rows.Count
                        End If
                    End If
                End If
                i = i + 1
            End While
        End If
    End Sub
    Private Sub Lucha(ByVal inscripcion_id As Integer)
        If RadioButton_lucha_si.Checked = True Then
            'recupero las categorias de lucha.
            Dim ds_cat As DataSet = DAinscripciones.Inscripcion_obtener_categoria()
            Dim i As Integer = 0
            While i < ds_cat.Tables(0).Rows.Count
                Dim edad_ini As Integer = CInt(ds_cat.Tables(0).Rows(i).Item("categoria_edadinicial"))
                Dim edad_fin As Integer = CInt(ds_cat.Tables(0).Rows(i).Item("categoria_edadfinal"))
                Dim graduaccion_selec As Integer = DropDownList_graduacion.SelectedValue
                Dim grad_inicial As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_gradinicial")
                Dim grad_final As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_gradfinal")
                Dim cat_sexo As String = ds_cat.Tables(0).Rows(i).Item("categoria_sexo").ToString
                Dim Categoria_id As Integer = ds_cat.Tables(0).Rows(i).Item("categoria_id")
                Dim peso_ini As Decimal = ds_cat.Tables(0).Rows(i).Item("categoria_peso_inical")
                Dim peso_final As Decimal = ds_cat.Tables(0).Rows(i).Item("categoria_peso_Final")
                If graduaccion_selec >= grad_inicial And graduaccion_selec <= grad_final Then
                    If CInt(Lb_edad.Text) >= CInt(edad_ini) And CInt(Lb_edad.Text) <= CInt(edad_fin) Then
                        If CDec(txt_peso.Text) > peso_ini And CDec(txt_peso.Text) <= peso_final Then
                            If cat_sexo <> "AMBOS SEXOS" Then
                                Dim sexo_selec As String = Lb_sexo.Text
                                If cat_sexo = sexo_selec Then
                                    'aqui guardo
                                    DAinscripciones.Inscripcion_alta_categorias(inscripcion_id, Categoria_id)
                                    i = ds_cat.Tables(0).Rows.Count
                                End If
                            Else
                                'como no me importa el sexo guardo
                                Dim sexo_selec As String = Lb_sexo.Text
                                DAinscripciones.Inscripcion_alta_categorias(inscripcion_id, Categoria_id)
                                i = ds_cat.Tables(0).Rows.Count
                            End If
                        End If
                    End If
                End If
                i = i + 1
            End While
        End If
    End Sub


#Region "cheks"
    Private Sub RadioButton_poder_si_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_poder_si.CheckedChanged
        RadioButton_poder_si.Checked = True
        RadioButton_poder_no.Checked = False
    End Sub
    Private Sub RadioButton_tecnica_si_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_tecnica_si.CheckedChanged
        RadioButton_tecnica_si.Checked = True
        RadioButton_tecnica_no.Checked = False
    End Sub
    Private Sub RadioButton_poder_no_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_poder_no.CheckedChanged
        RadioButton_poder_no.Checked = True
        RadioButton_poder_si.Checked = False
    End Sub
    Private Sub RadioButton_tecnica_no_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_tecnica_no.CheckedChanged
        RadioButton_tecnica_no.Checked = True
        RadioButton_tecnica_si.Checked = False
    End Sub
    Protected Sub RadioButton_lucha_si_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton_lucha_si.CheckedChanged
        RadioButton_lucha_si.Checked = True
        RadioButton_lucha_no.Checked = False
    End Sub
    Protected Sub RadioButton_lucha_no_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton_lucha_no.CheckedChanged
        RadioButton_lucha_no.Checked = True
        RadioButton_lucha_si.Checked = False
    End Sub
    Private Sub RadioButton_formas_si_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_formas_si.CheckedChanged
        RadioButton_formas_si.Checked = True
        RadioButton_formas_no.Checked = False
    End Sub
    Private Sub RadioButton_formas_no_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_formas_no.CheckedChanged
        RadioButton_formas_no.Checked = True
        RadioButton_formas_si.Checked = False
    End Sub
#End Region

    Private Sub Btb_ok_inscripcion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btb_ok_inscripcion.Click
        Response.Redirect("Evento_seleccionar.aspx")
    End Sub


    Private Sub Btn_confirmar_submit2_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_confirmar_submit2.ServerClick
        'consulto tipo de evento
        Dim ds_evento As DataSet = DAinscripciones.Inscripcion_consultar_evento(Session("evento_id"))
        Dim tipo_evento As String = ds_evento.Tables(0).Rows(0).Item("tipo_evento")
        If tipo_evento = "Torneo" Then
            'valido q se haya seleccionado al menos una de las 4 opciones de inscripcion
            If (RadioButton_lucha_si.Checked = True Or RadioButton_formas_si.Checked = True Or RadioButton_tecnica_si.Checked = True Or RadioButton_poder_si.Checked = True) And txt_peso.Text <> "" Then
                Try
                    Dim ds_tipoevento As DataSet = DAinscripciones.Inscripcion_alta_usuario(Session("Us_id"), Session("evento_id"), Today, CDec(txt_peso.Text))
                    'ahora veo que tipo de evento es.
                    Dim inscripcion_id As Integer = ds_tipoevento.Tables(0).Rows(0).Item("inscripcion_id")
                    Session("SERVER_inscripcion_id") = inscripcion_id
                    Lucha(inscripcion_id)
                    forma(inscripcion_id)
                    Rotura_Poder(inscripcion_id)
                    Rotura_especial(inscripcion_id)
                    lb_guardado.Text = "guardado examen"
                    CodigoQR(inscripcion_id)
                    'deberia mostrar un cartel y salir del form
                    popupMsjGuardado.Visible = True
                    ModalPopupExtender_guardado.Show()
                    'aksjdhkasd
                Catch ex As Exception
                    lb_guardado.Text = "fallo try catch de torneo"
                End Try



            Else
                'mensaje seleccione al menos 1 categoria
                If txt_peso.Text = "" Then
                    lbl_Modal_err.Text = "Debe Ingresar el Pesos"
                Else
                    lbl_Modal_err.Text = "mensaje seleccione al menos 1 categoria"
                End If

                popupMsjError.Visible = True
                ModalPopupExtender_error_cat.Show()
            End If
        End If
        If tipo_evento = "Curso" Then
            Try
                'si es un curso, solo doy de alta en inscripcion
                Dim ds_tipoevento As DataSet = DAinscripciones.Inscripcion_alta_usuario(Session("Us_id"), Session("evento_id"), Today, 0)
                'Session("SERVER_inscripcion_id") = ds_tipoevento.Tables(0).Rows(0).Item("inscripcion_id")
                lb_guardado.Text = "guardado curso"
                'deberia mostrar un cartel y salir del form
                'popupMsjGuardado.Visible = True
                'ModalPopupExtender_guardado.Show()
            Catch ex As Exception
                lb_guardado.Text = "fallo try catch de curso, en instruccion alta"
            End Try

        End If

        If tipo_evento = "Examen" Then
            Try
                lb_guardado.Text = "guardado examen"
                'si es un examen debo validar que no supere el maximo de inscriptos para ese turno
                Dim ds_validar As DataSet = DAinscripciones.inscripciones_x_examen_validar(Session("evento_id"), DropDownList_examen_turno.SelectedValue)
                Dim cant_max_inscriptos_x_turno As Integer = ds_validar.Tables(0).Rows(0).Item("evento_cap_max_insc")
                Dim cant_real_inscriptos As Integer = ds_validar.Tables(1).Rows.Count
                Response.Redirect("Evento_seleccionar.aspx")
                'If cant_real_inscriptos < cant_max_inscriptos_x_turno Then 'si hay cupo lo inscribo
                '    Dim ds_tipoevento As DataSet = DAinscripciones.Inscripcion_alta_usuario(Session("Us_id"), Session("evento_id"), Now, 0)
                '    Dim inscripcion_id As Integer = ds_tipoevento.Tables(0).Rows(0).Item("inscripcion_id")
                '    'Session("SERVER_inscripcion_id") = ds_tipoevento.Tables(0).Rows(0).Item("inscripcion_id")
                '    DAinscripciones.inscripciones_x_examen_alta(inscripcion_id, DropDownList_examen_turno.SelectedValue, DropDownList_graduacion.SelectedValue)
                '    lb_guardado.Text = "guardado examen"
                '    Response.Redirect("Evento_seleccionar.aspx")
                '    'popupMsjGuardado.Visible = True
                '    'ModalPopupExtender_guardado.Show()

                'Else
                '    popupMsjError_turno.Visible = True 'choco 19-08-2021
                '    ModalPopupExtender_error_turno.Show() 'choco 19-08-2021
                'End If

            Catch ex As Exception
                lb_guardado.Text = "fallo try catch de examen _modif"
            End Try
        End If
    End Sub
End Class