Public Class Cliente_alta
    Inherits System.Web.UI.Page
    Dim daGrupos As New Capa_Datos.WC_grupos
    Dim daClientes As New Capa_Datos.WB_clientes
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            limpiar_campos()
            Grupos() 'recupero todos los grupos

            If Session("clientes_op") = "modificar" Then
                Txt_cliente_id.Text = Session("cliente_id") 'aqui va el id del cliente
                Dim ds_info As DataSet = daClientes.Clientes_buscar_id(CInt(Session("cliente_id")))
                If ds_info.Tables(0).Rows.Count <> 0 Then
                    Txt_cliente_nomb.Text = ds_info.Tables(0).Rows(0).Item("Nombre")
                    Txt_dni.Text = ds_info.Tables(0).Rows(0).Item("Dni")
                    'grupo
                    DropDownList_grupos.SelectedValue = ds_info.Tables(0).Rows(0).Item("Grupo_id")
                    Txt_comision.Text = ds_info.Tables(0).Rows(0).Item("Comision")
                    Txt_regalo.Text = ds_info.Tables(0).Rows(0).Item("Regalo")
                    Txt_comision1.Text = ds_info.Tables(0).Rows(0).Item("Comision1")
                    Txt_regalo1.Text = ds_info.Tables(0).Rows(0).Item("Regalo1")
                    Txt_proceso.Text = ds_info.Tables(0).Rows(0).Item("Proceso").ToString.ToUpper
                    Txt_calculo.Text = CInt(ds_info.Tables(0).Rows(0).Item("Sincalculo"))
                    Txt_factor.Text = CInt(ds_info.Tables(0).Rows(0).Item("Factor"))
                    Txt_imprimecalculo.Text = CInt(ds_info.Tables(0).Rows(0).Item("Imprime"))
                    Txt_recorrido.Text = ds_info.Tables(0).Rows(0).Item("Recorrido")
                    Txt_orden.Text = ds_info.Tables(0).Rows(0).Item("Orden")
                    Txt_variable.Text = CInt(ds_info.Tables(0).Rows(0).Item("Variable"))
                    Txt_leyenda.Text = ds_info.Tables(0).Rows(0).Item("Leyenda1")
                    Txt_variable1.Text = CInt(ds_info.Tables(0).Rows(0).Item("Variable1"))
                    Txt_leyenda1.Text = ds_info.Tables(0).Rows(0).Item("Leyenda2")
                End If
            Else
                Session("clientes_op") = "alta"

            End If

        End If
    End Sub

    Private Sub Grupos()
        Try
            Dim ds_grupos As DataSet = daGrupos.Grupos_obtenertodos
            DropDownList_grupos.DataSource = ds_grupos.Tables(0)
            DropDownList_grupos.DataTextField = "Nombre"
            DropDownList_grupos.DataValueField = "Grupo_id"
            DropDownList_grupos.DataBind()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btn_graba_modal_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_graba_modal.ServerClick
        lb_errores_blanqueo()
        Try
            Dim valido_ingreso As String = "si"

            If Txt_cliente_nomb.Text = "" Then
                valido_ingreso = "no"
                lb_error_nombre.Visible = True
            End If

            Try
                Dim dni As Integer = CInt(Txt_dni.Text)
            Catch ex As Exception
                lb_error_dni.Visible = True
                valido_ingreso = "no"
            End Try

            Dim comision As Decimal
            Try
                comision = CDec(Txt_comision.Text.Replace(".", ","))
            Catch ex As Exception
                valido_ingreso = "no"
                lb_error_comision.Visible = True
            End Try

            Dim regalo As Decimal
            Try
                regalo = CDec(Txt_regalo.Text.Replace(".", ","))
            Catch ex As Exception
                lb_error_regalo.Visible = True
                valido_ingreso = "no"
            End Try

            Dim comision1 As Decimal
            Try
                comision1 = CDec(Txt_comision1.Text.Replace(".", ","))
            Catch ex As Exception
                lb_error_comision1.Visible = True
                valido_ingreso = "no"
            End Try

            Dim regalo1 As Decimal
            Try
                regalo1 = CDec(Txt_regalo1.Text.Replace(".", ","))
            Catch ex As Exception
                lb_error_regalo1.Visible = True
                valido_ingreso = "no"
            End Try


            If Txt_proceso.Text = "" Then
                valido_ingreso = "no"
                lb_error_proceso.Visible = True
            Else
                If Txt_proceso.Text.ToString.ToUpper = "D" Or Txt_proceso.Text.ToString.ToUpper = "S" Or Txt_proceso.Text.ToString.ToUpper = "M" Then
                    'valido
                Else
                    valido_ingreso = "no"
                    lb_error_proceso.Visible = True
                End If
            End If

            If Txt_calculo.Text = "" Then
                valido_ingreso = "no"
                lb_error_calculo.Visible = True
            Else
                If Txt_calculo.Text = 0 Or Txt_calculo.Text = 1 Then
                Else
                    valido_ingreso = "no"
                    lb_error_calculo.Visible = True
                End If
            End If

            If Txt_factor.Text = "" Then
                valido_ingreso = "no"
                lb_error_factor.Visible = True
            Else
                If Txt_factor.Text = 0 Or Txt_factor.Text = 1 Then
                    'valido
                Else
                    valido_ingreso = "no"
                    lb_error_factor.Visible = True
                End If
            End If

            If Txt_imprimecalculo.Text = "" Then
                valido_ingreso = "no"
                lb_error_imprimecalculo.Visible = True
            Else
                If Txt_imprimecalculo.Text = 0 Or Txt_imprimecalculo.Text = 1 Then
                Else
                    valido_ingreso = "no"
                    lb_error_imprimecalculo.Visible = True
                End If
            End If

            If Txt_recorrido.Text = "" Then
                valido_ingreso = "no"
                lb_error_recorrido.Visible = True
            End If

            If Txt_orden.Text = "" Then
                valido_ingreso = "no"
                lb_error_orden.Visible = True
            End If

            If Txt_variable.Text = "" Then
                valido_ingreso = "no"
                lb_error_variable.Visible = True
            Else
                If Txt_variable.Text = 0 Or Txt_variable.Text = 1 Then
                Else
                    valido_ingreso = "no"
                    lb_error_variable.Visible = True
                End If
            End If

            If Txt_leyenda.Text = "" Then
                valido_ingreso = "no"
                lb_error_leyenda.Visible = True
            End If

            If Txt_variable1.Text = "" Then
                valido_ingreso = "no"
                lb_error_variable1.Visible = True
            Else
                If Txt_variable1.Text = 0 Or Txt_variable1.Text = 1 Then
                Else
                    valido_ingreso = "no"
                    lb_error_variable1.Visible = True
                End If
            End If

            If Txt_leyenda1.Text = "" Then
                valido_ingreso = "no"
                lb_error_leyenda1.Visible = True
            End If

            If valido_ingreso = "si" Then
                Select Case Session("clientes_op")
                    Case "alta"
                        If Session("clientes_op") = "alta" Then
                            '1) valido que no exista.
                            Dim ds_info As DataSet = daClientes.Clientes_buscar_dni(CInt(Txt_dni.Text))
                            If ds_info.Tables(0).Rows.Count = 0 Then 'no existe
                                '2) guardo en bd
                                Dim Leyenda As String = Txt_leyenda.Text + Txt_leyenda1.Text
                                daClientes.Clientes_alta(Txt_cliente_nomb.Text, CInt(Txt_dni.Text),
                                                         DropDownList_grupos.SelectedValue, comision, regalo,
                                                         comision1, regalo1, Txt_proceso.Text, CInt(Txt_calculo.Text),
                                                         CInt(Txt_factor.Text), CInt(Txt_imprimecalculo.Text), Txt_recorrido.Text, Txt_orden.Text,
                                                         CInt(Txt_variable.Text), Leyenda, CInt(Txt_variable1.Text), Txt_leyenda.Text, Txt_leyenda1.Text, "", CDec(0), CDec(0))

                                limpiar_campos()
                                Response.Redirect("Cliente_abm.aspx")
                            Else
                                'aqui muestro mensaje notificando que existe.
                                Lb_error_validacion.Text = "Error! El Cliente ya existe, modifique los datos ingresados."
                                Lb_error_validacion.Visible = True
                                lb_error_dni.Visible = True
                            End If
                        End If
                    Case "modificar"
                        If Session("clientes_op") = "modificar" Then
                            '1) valido que el nombre q ingreso, ya no exista con otro id
                            Dim ds_info As DataSet = daClientes.Clientes_buscar_dni(CInt(Txt_dni.Text))
                            Dim existe = "no"
                            If ds_info.Tables(0).Rows.Count <> 0 Then
                                Dim i As Integer = 0
                                While i < ds_info.Tables(0).Rows.Count
                                    If (CInt(Txt_cliente_id.Text) <> ds_info.Tables(0).Rows(i).Item("Cliente")) And (Txt_dni.Text = ds_info.Tables(0).Rows(i).Item("Dni")) Then
                                        existe = "si"
                                    End If
                                    i = i + 1
                                End While
                            Else
                                'puedo guardar
                            End If
                            If existe = "no" Then
                                Dim Leyenda As String = Txt_leyenda.Text + Txt_leyenda1.Text
                                daClientes.Clientes_modificar(CInt(Txt_cliente_id.Text), Txt_cliente_nomb.Text, CInt(Txt_dni.Text),
                                                         DropDownList_grupos.SelectedValue, comision, regalo,
                                                         comision1, regalo1, Txt_proceso.Text, CInt(Txt_calculo.Text),
                                                         CInt(Txt_factor.Text), CInt(Txt_imprimecalculo.Text), Txt_recorrido.Text, Txt_orden.Text,
                                                         CInt(Txt_variable.Text), Leyenda, CInt(Txt_variable1.Text), Txt_leyenda.Text, Txt_leyenda1.Text)
                                limpiar_campos()
                                'regresar al form que lista clientes.
                                Response.Redirect("Cliente_abm.aspx")
                            Else
                                'aqui muestro mensaje notificando que existe.
                                Lb_error_validacion.Text = "Error! El Cliente ya existe, modifique los datos ingresados."
                                Lb_error_validacion.Visible = True
                                lb_error_dni.Visible = True
                            End If
                        End If
                End Select
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

    End Sub

    Private Sub limpiar_campos()
        Txt_cliente_nomb.Text = ""
        Txt_dni.Text = ""
        Txt_comision.Text = CDec(0)
        Txt_regalo.Text = CDec(0)
        Txt_comision1.Text = CDec(0)
        Txt_regalo1.Text = CDec(0)
        Txt_proceso.Text = "D"
        Txt_calculo.Text = 0
        Txt_factor.Text = 0
        Txt_imprimecalculo.Text = 0
        Txt_recorrido.Text = ""
        Txt_orden.Text = ""
        Txt_variable.Text = 0
        Txt_leyenda.Text = ""
        Txt_variable1.Text = 0
        Txt_leyenda1.Text = ""
        Label_cliente_nomb.Focus()
        
    End Sub

    Private Sub lb_errores_blanqueo()
        '------lb errores------
        Lb_error_validacion.Text = ""
        Lb_error_validacion.Visible = False
        lb_error_nombre.Visible = False
        lb_error_dni.Visible = False
        lb_error_comision.Visible = False
        lb_error_regalo.Visible = False
        lb_error_comision1.Visible = False
        lb_error_regalo1.Visible = False
        lb_error_proceso.Visible = False
        lb_error_calculo.Visible = False
        lb_error_factor.Visible = False
        lb_error_imprimecalculo.Visible = False
        lb_error_recorrido.Visible = False
        lb_error_orden.Visible = False
        lb_error_variable.Visible = False
        lb_error_leyenda.Visible = False
        lb_error_variable1.Visible = False
        lb_error_leyenda1.Visible = False

    End Sub


    Private Sub btn_baja_modal_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_baja_modal.ServerClick
        Try
            If Txt_cliente_id.Text <> "" Then
                daClientes.Clientes_baja(CInt(Txt_cliente_id.Text))
                limpiar_campos()
                Txt_cliente_id.Text = ""
                'redireccionar al form abm clientes.
                Response.Redirect("Cliente_abm.aspx")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_retroceder_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_retroceder.ServerClick
        Response.Redirect("Cliente_abm.aspx")
    End Sub
End Class