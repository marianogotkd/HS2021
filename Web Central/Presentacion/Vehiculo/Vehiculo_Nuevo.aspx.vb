Public Class Vehiculo_Nuevo
    Inherits System.Web.UI.Page
    Dim DAvehiculo As New Capa_Datos.Vehiculo

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            If Session("VehiculoId") = "" Then

            Else

                Dim ds_Actu As DataSet = DAvehiculo.Vehiculo_ObtenerTodo_X_ID(Session("VehiculoId"))
                If ds_Actu.Tables(0).Rows.Count Then
                    tb_patente.Text = ds_Actu.Tables(0).Rows(0).Item("VehiculoPatente")
                    tb_marca.Text = ds_Actu.Tables(0).Rows(0).Item("VehiculoMarca")
                    tb_modelo.Text = ds_Actu.Tables(0).Rows(0).Item("VehiculoModelo")
                    tb_año.Text = ds_Actu.Tables(0).Rows(0).Item("VehiculoAño")
                    tb_tipo.Text = ds_Actu.Tables(0).Rows(0).Item("VehiculoTipo")

                    If ds_Actu.Tables(0).Rows(0).Item("VehiculoEstado") = "Activo" Then
                        RadioButton_Activo.Checked = True
                    Else
                        RadioButton_Debaja.Checked = True
                    End If

                    btn_Guardar.Visible = False
                    Btn_Actualizar.Visible = True

                End If
            End If
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        lbl_Err.Visible = False
        card_OK.Visible = False

        If tb_año.Text <> "" And tb_marca.Text <> "" And tb_modelo.Text <> "" And tb_tipo.Text <> "" And tb_patente.Text <> "" Then

            Dim Estado = ""
            If RadioButton_Activo.Checked = True Then
                Estado = "Activo"
            End If
            If RadioButton_Debaja.Checked = True Then
                Estado = "De Baja"
            End If

            DAvehiculo.Vehiculo_Alta(tb_patente.Text, tb_marca.Text, tb_modelo.Text, tb_año.Text, tb_tipo.Text, Estado)
            card_OK.Visible = True
            limpiar()

        Else
            Campos.Visible = True
            lbl_Err.Visible = True
        End If

    End Sub

    Private Sub limpiar()
        tb_año.Text = ""
        tb_marca.Text = ""
        tb_modelo.Text = ""
        tb_patente.Text = ""
        tb_tipo.Text = ""

        lbl_Err.Visible = False

    End Sub

    Private Sub Btn_Actualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Actualizar.Click
        lbl_Err.Visible = False
        card_OK.Visible = False

        If tb_año.Text <> "" And tb_marca.Text <> "" And tb_modelo.Text <> "" And tb_patente.Text <> "" And tb_tipo.Text <> "" Then

            Dim Estado = ""
            If RadioButton_Activo.Checked = True Then
                Estado = "Activo"
            End If
            If RadioButton_Debaja.Checked = True Then
                Estado = "De Baja"
            End If

            DAvehiculo.Vehiculo_modificar((Session("VehiculoId")), tb_patente.Text, tb_marca.Text, tb_modelo.Text, tb_año.Text, tb_tipo.Text, Estado)
            card_OK.Visible = True
            limpiar()

        Else
            Campos.Visible = True
            lbl_Err.Visible = True
        End If
    End Sub

    Private Sub Valido_RB()
        If RadioButton_Activo.Checked = True Then
            tb_año.Enabled = True
            tb_marca.Enabled = True
            tb_modelo.Enabled = True
            tb_patente.Enabled = True
            tb_tipo.Enabled = True
        End If
        If RadioButton_Debaja.Checked = True Then
            tb_año.Enabled = False
            tb_marca.Enabled = False
            tb_modelo.Enabled = False
            tb_patente.Enabled = False
            tb_tipo.Enabled = False
        End If
    End Sub
    Private Sub RadioButton_Activo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Activo.CheckedChanged
        Valido_RB()

    End Sub

    Private Sub RadioButton_Debaja_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Debaja.CheckedChanged
        Valido_RB()
    End Sub

    Private Sub btn_volver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Response.Redirect("Vehiculo_Consulta.aspx")
    End Sub
End Class