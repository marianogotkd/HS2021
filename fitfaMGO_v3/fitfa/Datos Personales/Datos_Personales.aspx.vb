Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf


Public Class Datos_Personales
    Inherits System.Web.UI.Page
    Dim DAusuario As New Capa_de_datos.usuario
    Dim DAllave As New Capa_de_datos.Llave

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_errApe.Visible = False
        lbl_errCP.Visible = False
        lbl_errDir.Visible = False
        lbl_errFecNac.Visible = False
        lbl_errNac.Visible = False
        lbl_errNom.Visible = False
        lbl_errTel.Visible = False
        lbl_errMail.Visible = False
        lbl_err_libreta.Visible = False
        If Not IsPostBack Then
            Cargar_Datos()
            div_modalmsjOK.Visible = False


        End If
    End Sub

    Private Sub Cargar_Datos()
        Dim ds_Usuarios As DataSet = DAusuario.Datos_Personales_Obtener_Datos_Usuarios(Session("Us_id"))
        If ds_Usuarios.Tables(0).Rows.Count <> 0 Then
            tb_nombre.Value = ds_Usuarios.Tables(0).Rows(0).Item(0)
            tb_apellido.Value = ds_Usuarios.Tables(0).Rows(0).Item(1)
            tb_fechnacc.Value = ds_Usuarios.Tables(0).Rows(0).Item(2)
            tb_nacionalidad.Value = ds_Usuarios.Tables(0).Rows(0).Item(3)

            If ds_Usuarios.Tables(0).Rows(0).Item(4) = "Hombre" Then
                combo_Sexo.SelectedValue = "1"
            Else
                combo_Sexo.SelectedValue = "2"
            End If

            combo_EstCivil.SelectedValue = ds_Usuarios.Tables(0).Rows(0).Item(5)
            tb_profesion.Value = ds_Usuarios.Tables(0).Rows(0).Item(9)
            tb_dir.Value = ds_Usuarios.Tables(0).Rows(0).Item(8)
            'tb_CP.Value = ds_Usuarios.Tables(0).Rows(0).Item(10)
            textbox_CP.Text = ds_Usuarios.Tables(0).Rows(0).Item(10)
            Combo_provincia.SelectedValue = ds_Usuarios.Tables(0).Rows(0).Item(15)
            combo_ciudad.SelectedValue = ds_Usuarios.Tables(0).Rows(0).Item(16)
            tb_tel.Value = ds_Usuarios.Tables(0).Rows(0).Item(11)
            tb_Email.Value = ds_Usuarios.Tables(0).Rows(0).Item(12)
            tb_nrolibreta.Value = ds_Usuarios.Tables(0).Rows(0).Item("usuario_nrolibreta").ToString

            Dim graduacion_id As Integer = ds_Usuarios.Tables(0).Rows(0).Item("graduacion_id")
            'como en el evento init recupero la graduacion, solo tengo que seleccionarla
            Combo_graduacion.SelectedValue = graduacion_id
            tb_graduacion.Value = Combo_graduacion.SelectedItem.Text

        End If
    End Sub
    Private Sub obtener_graduaciones()
        Dim ds_graduaciones As DataSet = DAusuario.Usuario_ObtenerGraduaciones()
        If ds_graduaciones.Tables(0).Rows.Count <> 0 Then
            Combo_graduacion.DataSource = ds_graduaciones.Tables(0)
            Combo_graduacion.DataTextField = "graduacion_desc"
            Combo_graduacion.DataValueField = "graduacion_id"
            Combo_graduacion.DataBind()
        End If
    End Sub
    Private Sub obtener_estadocivil()
        Dim ds_estadocivil As DataSet = DAusuario.Estado_civil_obtener
        If ds_estadocivil.Tables(0).Rows.Count <> 0 Then
            combo_EstCivil.DataSource = ds_estadocivil.Tables(0)
            combo_EstCivil.DataTextField = "estadocivil_desc"
            combo_EstCivil.DataValueField = "estadocivil_id"
            combo_EstCivil.DataBind()
        End If

    End Sub
    Public Sub Obtener_provincias()
        Dim ds_provincias As DataSet = DAusuario.Usuario_ObtenerProvincias()

        If ds_provincias.Tables(0).Rows.Count <> 0 Then
            Combo_provincia.DataSource = ds_provincias.Tables(0)
            Combo_provincia.DataTextField = "provincia_desc"
            Combo_provincia.DataValueField = "provincia_id"
            Combo_provincia.DataBind()
        End If
    End Sub
    Private Sub Obtener_ciudad()
        'filtrar
        combo_ciudad.DataSource = ""
        combo_ciudad.DataBind()

        Dim ds_ciudades As DataSet = DAusuario.Usuario_filtrarciudades_x_Provincias(CInt(Combo_provincia.SelectedValue))
        If ds_ciudades.Tables(0).Rows.Count <> 0 Then
            combo_ciudad.DataSource = ds_ciudades.Tables(0)

            combo_ciudad.DataTextField = "ciudad_desc"
            combo_ciudad.DataValueField = "ciudad_id"
            combo_ciudad.DataBind()
        End If
    End Sub
    Private Sub Combo_provincia_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_provincia.Init
        Obtener_provincias()
        Obtener_ciudad()
        'recuperar las graduaciones
        obtener_graduaciones()
    End Sub
    Private Sub combo_EstCivil_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_EstCivil.Init
        obtener_estadocivil()

    End Sub

    Private Sub Combo_provincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_provincia.SelectedIndexChanged
        Obtener_ciudad()
    End Sub

    Private Sub btn_guardar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_guardar.ServerClick
        Dim Vacio As Boolean
        If tb_apellido.Value <> "" Then

        Else
            lbl_errApe.Visible = True
            Vacio = True
        End If

        If textbox_CP.Text <> "" Then

        Else
            lbl_errCP.Visible = True
            Vacio = True
        End If
        If tb_dir.Value <> "" Then

        Else
            lbl_errDir.Visible = True
            Vacio = True
        End If

        If tb_Email.Value <> "" Then

        Else
            lbl_errMail.Visible = True
            Vacio = True
        End If

        If tb_fechnacc.Value <> "" Then

        Else
            lbl_errFecNac.Visible = True
            Vacio = True
        End If

        If tb_nacionalidad.Value <> "" Then

        Else
            lbl_errNac.Visible = True
            Vacio = True
        End If

        If tb_nombre.Value <> "" Then

        Else
            lbl_errNom.Visible = True
            Vacio = True
        End If

        If tb_tel.Value <> "" Then

        Else
            lbl_errTel.Visible = True
            Vacio = True
        End If

        'If tb_nrolibreta.Value <> "" Then
        'Else
        '    lbl_err_libreta.Visible = True
        '    Vacio = True
        'End If

        If Vacio <> True Then
            DAusuario.Datos_Personales_Actualizar_Datos(CInt(Session("Us_id")), tb_nombre.Value, tb_apellido.Value, tb_fechnacc.Value, tb_nacionalidad.Value, combo_Sexo.SelectedValue, combo_EstCivil.SelectedValue, tb_profesion.Value, tb_dir.Value, textbox_CP.Text, Combo_provincia.SelectedValue, combo_ciudad.SelectedValue, tb_tel.Value, tb_Email.Value, tb_nrolibreta.Value, Combo_graduacion.SelectedValue)

            'esto es lo que estaba probando, en el form donde modifico los datos personales
            'en un label muestro el error

            'div_registro_guardado.Visible = True

            '++++++++++++++Esto hago para que se haga visible el cartel de "datos actualizados"++++++++++++++
            div_modalmsjOK.Visible = True
            Modal_msjOK.Show()
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        Else
            div_registro_guardado.Visible = False

        End If

    End Sub


    Dim nom1 As Integer = 1111
    Dim nom2 As Integer = 2222
    Dim nom3 As Integer = 3333
    Dim nom4 As Integer = 4444

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
    '    'Response.Clear()
    '    'Response.ContentType = "application/pdf"
    '    'Response.Cache.SetCacheability(HttpCacheability.NoCache)

    '    'Dim doc As New Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10)

    '    'Dim path As String = Me.Server.MapPath(".") + "\Miarchivo.pdf"

    '    'Dim file As New FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)

    '    'PdfWriter.GetInstance(doc, file)
    '    'doc.Open()


    '    'doc.Add(New Paragraph("Reporte:"))
    '    'doc.Add(New Paragraph("DATOS PERSONALES:"))
    '    'doc.Add(New Paragraph(" "))
    '    'doc.Add(New Paragraph("Apellido y nombre:"))

    '    'doc.NewPage()
    '    'doc.Add(New Paragraph("Hello world again"))



    '    'doc.Close()
    '    'Process.Start(path)

    '    ''Dim pdfDoc As New Document()
    '    ''Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Simple.pdf", FileMode.Create))
    '    ''pdfDoc.Open()
    '    ''pdfDoc.Add(New Paragraph("Hello world"))
    '    ''pdfDoc.NewPage()
    '    ''pdfDoc.Add(New Paragraph("Hello world again"))
    '    ''pdfDoc.Close()

    'End Sub
End Class