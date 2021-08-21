Imports System.Drawing
Imports System.IO
Public Class Obra_Nueva
    Inherits System.Web.UI.Page
    Dim DAobra As New Capa_Datos.Obra



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            If Session("ObraId") = "" Then
                div_fechafin.Visible = False
            Else

                Dim ds_Actu As DataSet = DAobra.Obra_Obtener_x_Id(Session("ObraId"))
                If ds_Actu.Tables(0).Rows.Count Then
                    tb_nombre.Text = ds_Actu.Tables(0).Rows(0).Item("ObraNombre")
                    tb_Desc.Text = ds_Actu.Tables(0).Rows(0).Item("ObraDescripcion")
                    tb_Domicilio.Text = ds_Actu.Tables(0).Rows(0).Item("ObraDomicilio")
                    tb_Localidad.Text = ds_Actu.Tables(0).Rows(0).Item("ObraLocalidad")
                    ' Tb_fechaFin.Value = CDate(ds_Actu.Tables(0).Rows(0).Item("ObraFechaFinal"))
                    Tb_fechaIn.Value = CDate(ds_Actu.Tables(0).Rows(0).Item("ObraFechaInicio"))

                    btn_Guardar.Visible = False
                    Btn_Actualizar.Visible = True

                End If
            End If
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        lbl_Err.Visible = False
        card_OK.Visible = False

        If tb_Desc.Text <> "" And tb_Domicilio.Text <> "" And Tb_fechaIn.Value <> "" And tb_Localidad.Text <> "" And tb_nombre.Text <> "" Then
            DAobra.Obra_Alta(tb_nombre.Text, tb_Desc.Text, tb_Domicilio.Text, tb_Localidad.Text, Tb_fechaIn.Value)
                card_OK.Visible = True
                limpiar()

        Else
            Campos.Visible = True
            lbl_Err.Visible = True
        End If

    End Sub
    Private Sub limpiar()
        tb_Desc.Text = ""
        tb_Domicilio.Text = ""
        Tb_fechaFin.Value = ""
        Tb_fechaIn.Value = ""
        tb_Localidad.Text = ""
        tb_nombre.Text = ""

        lbl_Err.Visible = False

    End Sub

   

    Private Sub Btn_Actualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Actualizar.Click
        lbl_Err.Visible = False
        card_OK.Visible = False

        If tb_Desc.Text <> "" And tb_Domicilio.Text <> "" And Tb_fechaIn.Value <> "" And Tb_fechaFin.Value <> "" And tb_Localidad.Text <> "" And tb_nombre.Text <> "" Then

            If CDate(Tb_fechaIn.Value) <= CDate(Tb_fechaFin.Value) Then

                DAobra.Obra_modificar(Session("ObraID"), tb_nombre.Text, tb_Desc.Text, tb_Domicilio.Text, tb_Localidad.Text, Tb_fechaIn.Value, Tb_fechaFin.Value)
                card_OK.Visible = True
                limpiar()

            Else
                Campos.Visible = False
                fechas.Visible = True
                lbl_Err.Visible = True
            End If



        Else
            fechas.Visible = False
            Campos.Visible = True
            lbl_Err.Visible = True
        End If
    End Sub

    Private Sub btn_volver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Response.Redirect("../obra/Obra_Consulta.aspx")
    End Sub
End Class