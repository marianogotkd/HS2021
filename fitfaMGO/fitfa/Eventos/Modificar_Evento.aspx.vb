Imports System.Drawing
Imports System.IO

Public Class Modificar_Evento
    Inherits System.Web.UI.Page
    Public Cambio_foto As String = "no"
    Dim DAevento As New Capa_de_datos.Eventos
    Dim tamanio As Integer
    Dim ImagenOriginal As Byte()
    Dim ImagenOriginalBinaria As Bitmap
    Dim ImagenDataURL64 As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lbl_errFecCier.Visible = False
        lbl_errNom.Visible = False
        lbl_costo.Visible = False
        lbl_errfechaini.Visible = False
        lbl_horaCierre.Visible = False
        lbl_errImg.Visible = False


        Page.Form.Attributes.Add("enctype", "multipart/form-data")

        If Not IsPostBack Then
            Ocultar.Visible = False
            Session("imagen") = ""
            Session("foto_subido") = "no"

            ObetenerEventos()
            Cargar_Evento()

        End If

    End Sub

    Public Sub ObetenerEventos()
        Dim ds_Eventos As DataSet = DAevento.Evento_ObetenerEventos()
        If ds_Eventos.Tables(0).Rows.Count <> 0 Then
            drop_evento.DataSource = ds_Eventos.Tables(0)
            drop_evento.DataTextField = "evento_descripcion"
            drop_evento.DataValueField = "evento_id"
            drop_evento.DataBind()
        End If



    End Sub

    Public Function ImageControlToByteArray(ByVal foto)
        Return File.ReadAllBytes(Server.MapPath(foto.ImageUrl))
    End Function

    Private Sub btn_guardar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_guardar.ServerClick

        System.Threading.Thread.Sleep(5000)

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
        If Image1.Visible = False Then
            lbl_errImg.Visible = True
            lbl_errImg.InnerText = "Debe Seleccionar una Foto"
            Vacio = True
        End If

        Dim FechaHoraCierre = tb_fechaCierre.Value + " " + tb_horaCierre.Value

        If Session("foto_subido") = "no" Then 'nota: esto valido en caso que quiera dejar la foto con la imagen generica de LOGO
            Dim imagebytes As Byte() = ImageControlToByteArray(Image1)
            Session("imagen") = imagebytes
            Session("foto_subido") = "si"
        Else
            If Session("foto_subido") = "img_recuperadaBD" Then
                Session("imagen") = Session("imagen_ModEvnt")
            End If

        End If

        If Cambio_foto = "no" Then
            Session("imagen") = Session("imagen_ModEvnt")
        End If


        If Vacio = False Then
            If costo = "" Then
                DAevento.Evento_Actualizar(drop_evento.SelectedValue, tb_nombre.Value, Session("imagen"), tb_fechainicio.Value, FechaHoraCierre, combo_TipoEvento.SelectedValue, IsDBNull(costo))
            Else
                DAevento.Evento_Actualizar(drop_evento.SelectedValue, tb_nombre.Value, Session("imagen"), tb_fechainicio.Value, FechaHoraCierre, combo_TipoEvento.SelectedValue, costo)
            End If
            Ocultar.Visible = True
            ModalPopupExtender1.Show()

            'lbl_ok.Visible = True
            tb_nombre.Value = ""
            tb_fechainicio.Value = ""
            tb_fechaCierre.Value = ""
            tb_horaCierre.Value = ""
            textbox_Costo.Text = ""
            FileUpload1.Attributes.Clear()
            Image1.Visible = False
            btn_quitar.Visible = False
            btn_Examinar.Visible = True
        End If
    End Sub

    Private Sub Subir_Foto_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Subir_Foto.ServerClick


        System.Threading.Thread.Sleep(5000)

        If FileUpload1.HasFile Then
            Dim fileExt As String = System.IO.Path.GetExtension(FileUpload1.FileName)
            If fileExt = ".jpeg" Or fileExt = ".bmp" Or fileExt = ".png" Or fileExt = ".jpg" Or fileExt = ".JPG" Or fileExt = ".PNG" Or fileExt = ".JPEG" Or fileExt = ".BMP" Then
                Session("foto_subido") = "si"
                tamanio = FileUpload1.PostedFile.ContentLength
                'int Tamanio = fuploadImagen.PostedFile.ContentLength;
                'choco
                ImagenOriginal = New Byte(tamanio - 1) {}
                'byte[] ImagenOriginal = new byte[Tamanio];
                'choco
                FileUpload1.PostedFile.InputStream.Read(ImagenOriginal, 0, tamanio)
                'fuploadImagen.PostedFile.InputStream.Read(ImagenOriginal, 0, Tamanio);
                'choco
                ImagenOriginalBinaria = New Bitmap(FileUpload1.PostedFile.InputStream)
                'Bitmap ImagenOriginalBinaria = new Bitmap(fuploadImagen.PostedFile.InputStream);
                'choco
                ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImagenOriginal)
                'string ImagenDataURL64 = "data:image/jpg;base64." + Convert.ToBase64String(ImagenOriginal);

                Session("imagen") = ImagenOriginal
                Image1.ImageUrl = ImagenDataURL64

                Image1.Visible = True
                lbl_errImg.Visible = False
                'btn_Examinar.Visible = False
                'btn_quitar.Visible = True
                Cambio_foto = "si"
            Else
                lbl_errImg.Visible = True
                lbl_errImg.InnerText = "Solo Archivos de Tipo Imagen"
            End If

        End If

    End Sub

    Private Sub btn_quitar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_quitar.ServerClick
        FileUpload1.Attributes.Clear()
        Image1.ImageUrl = "~/Eventos/imagen/logo_evento.jpg"
        Session("imagen") = ""
        Session("foto_subido") = "no"

        'Image1.Visible = False
        'btn_quitar.Visible = False
        'btn_Examinar.Visible = True

    End Sub

    Private Sub drop_evento_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles drop_evento.Init
    End Sub

    Public Sub Cargar_Evento()

        Dim ds_Eventos As DataSet = DAevento.Evento_ObetenerEvento_ID(drop_evento.SelectedValue)
        If ds_Eventos.Tables(0).Rows.Count <> 0 Then
            tb_nombre.Value = ds_Eventos.Tables(0).Rows(0).Item("evento_descripcion")
            tb_fechainicio.Value = ds_Eventos.Tables(0).Rows(0).Item("evento_fecha")
            tb_fechaCierre.Value = ds_Eventos.Tables(0).Rows(0).Item("fechacierre")
            tb_horaCierre.Value = ds_Eventos.Tables(0).Rows(0).Item("horacierre")
            textbox_Costo.Text = ds_Eventos.Tables(0).Rows(0).Item("evento_costo")
            Dim ImagenBD As Byte() = ds_Eventos.Tables(0).Rows(0).Item("evento_foto")
            Dim ImagenDataURL64 As String = "data:image/jpg;base64," + Convert.ToBase64String(ImagenBD)
            'string ImagenDataURL64 = "data:image/jpg;base64." + Convert.ToBase64String(ImagenOriginal);
            'choco
            'image1.ImageUrl = ImagenDataURL64
            Image1.ImageUrl = ImagenDataURL64

            Image1.Visible = True
            lbl_errImg.Visible = False
            'btn_Examinar.Visible = False
            'btn_quitar.Visible = True
            Session("imagen_ModEvnt") = ImagenBD 'esta variable tiene la foto de la bd
            Session("foto_subido") = "img_recuperadaBD"
        End If

    End Sub

    Private Sub drop_evento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drop_evento.SelectedIndexChanged
       
        Cargar_Evento()


    End Sub

    Private Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick

        System.Threading.Thread.Sleep(5000)

        DAevento.Evento_eliminar(drop_evento.SelectedValue)

        Ocultar.Visible = True
        ModalPopupExtender1.Show()
        Label2.Text = "Evento Eliminado"
        ObetenerEventos()
        Cargar_Evento()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Response.Redirect("~/Inicio_Blanco.aspx")
    End Sub
End Class


