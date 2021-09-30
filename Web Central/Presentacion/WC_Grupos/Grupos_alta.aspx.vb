Public Class Grupos_alta
    Inherits System.Web.UI.Page
    Dim DAgrupos As New Capa_Datos.WC_grupos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            If Session("grupos_op") = "modificar" Then
                Txt_grupo_id.Text = "" 'aqui va el id del grupo
            Else
                Session("grupos_op") = "alta"
            End If
            Txt_grupo_nomb.Focus()
            Dim fecha As Date = Today
            Txt_fechaproc.Text = fecha

        End If
    End Sub

    Private Sub btn_graba_modal_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_graba_modal.ServerClick
        Try
            Dim valido_ingreso As String = "si"

            If Txt_grupo_nomb.Text = "" Then
                valido_ingreso = "no"
            End If

            If Txt_tipo.Text = "" Or Txt_tipo.Text = 0 Then
                valido_ingreso = "no"
            End If

            Dim porcentaje As Decimal = CDec(Txt_porcentaje.Text)
            Dim clieporcentaje As Decimal = CDec(Txt_clieporcentaje.Text)
            If Txt_codcobro.Text = "" Or Txt_codcobro.Text = 0 Then
                valido_ingreso = "no"
            End If
            If Txt_fechaproc.Text = "" Then
                valido_ingreso = "no"
            End If

            If valido_ingreso = "si" Then
                If Session("grupos_op") = "alta" Then
                    '1) valido que no exista.
                    Dim ds_info As DataSet = DAgrupos.Grupos_buscar(Txt_grupo_nomb.Text)
                    If ds_info.Tables(0).Rows.Count = 0 Then 'no existe
                        '2) guardo en bd
                        DAgrupos.Grupos_alta(Txt_grupo_nomb.Text, Txt_tipo.Text, CDec(Txt_porcentaje.Text), CDec(Txt_clieporcentaje.Text), Txt_codcobro.Text, Txt_fechaproc.Text, CDec(0), CDec(0), CDec(0))
                        Limpiar_campos()
                    Else
                        'aqui muestro mensaje notificando que existe.
                        Lb_error_validacion.Text = "Error! El grupo ya existe, modifique los datos ingresados."
                        Lb_error_validacion.Visible = True
                    End If
                End If
                If Session("grupos_op") = "modificar" Then
                    '1) valido que el nombre q ingreso, ya no exista con otro id
                    Dim ds_info As DataSet = DAgrupos.Grupos_buscar(Txt_grupo_nomb.Text)
                    Dim existe = "no"
                    If ds_info.Tables(0).Rows.Count <> 0 Then 'no existe
                        Dim i As Integer = 0
                        While i < ds_info.Tables(0).Rows.Count
                            If (CInt(Txt_grupo_id.Text) <> ds_info.Tables(0).Rows(i).Item("Grupo_id")) And (Txt_grupo_nomb.Text.ToUpper = ds_info.Tables(0).Rows(i).Item("Nombre").ToString.ToUpper) Then
                                existe = "si"
                                Exit While
                            End If
                            i = i + 1
                        End While
                    Else
                        'puedo guardar.
                    End If
                    If existe = "no" Then
                        DAgrupos.Grupos_modificar(CInt(Txt_grupo_id.Text), Txt_grupo_nomb.Text, Txt_tipo.Text, CDec(Txt_porcentaje.Text), CDec(Txt_clieporcentaje.Text), Txt_codcobro.Text, Txt_fechaproc.Text)
                        Limpiar_campos()
                        'regresar al form que lista grupos.
                    Else
                        'aqui muestro mensaje notificando que existe.
                        Lb_error_validacion.Text = "Error! El grupo ya existe, modifique el Nombre ingresados."
                        Lb_error_validacion.Visible = True
                    End If
                End If
            Else
                'aqui mensaje de que cargue todos los paretros solicitados correctamente
                Lb_error_validacion.Text = "Error! Ingrese los datos solicitados correctamente."
                Lb_error_validacion.Visible = True
            End If
        Catch ex As Exception
            'aqui mensaje de que cargue todos los paretros solicitados correctamente
            Lb_error_validacion.Text = "Error! Ingrese los datos solicitados correctamente."
            Lb_error_validacion.Visible = True
        End Try

        '------------nota: en total tengo 3 modales con los mensajes:-------------------
        '---------------1 - datos registrados.------------------------------------------
        '---------------2 - error, existe en bd.----------------------------------------
        '---------------3 - error ingrese parametros validos.---------------------------
    End Sub

    Private Sub Limpiar_campos()
        Txt_grupo_nomb.Text = ""
        Txt_tipo.Text = ""
        Txt_porcentaje.Text = ""
        Txt_clieporcentaje.Text = ""
        Txt_codcobro.Text = ""
        Dim fecha As Date = Today
        Txt_fechaproc.Text = fecha
        Txt_grupo_nomb.Focus()
        Lb_error_validacion.Text = ""
        Lb_error_validacion.Visible = False
    End Sub

    Private Sub btn_baja_modal_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_baja_modal.ServerClick
        Try
            If Txt_grupo_id.Text <> "" Then
                DAgrupos.Grupos_baja(CDec(Txt_grupo_id.Text))
                Limpiar_campos()
                Txt_grupo_id.Text = ""
                'redireccionar a menu de grupos.
            End If
        Catch ex As Exception

        End Try
        
    End Sub
End Class