
'////////todo esto para que funcione las exportaciones a pdf,word,pdf//////
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html
Imports iTextSharp.text.html.simpleparser
'nota: si no tiene el dll de itextsharp, debe agregar en referencias, previamente con archivo descargado de internet. 
'////////////////////////////////////////////////////////////////////////////

Public Class Examen

    Inherits System.Web.UI.Page




    Dim DAeventos As New Capa_de_datos.Eventos
    Dim dataset_examen As New Examen_ds
    Dim DAinstructor As New Capa_de_datos.Instructor

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Session("evento_id")
        If Not IsPostBack Then
            Dim evento_id As Integer = CInt(Session("evento_id"))

            'recupero inscriptos
            Dim ds_inscriptos As DataSet = DAeventos.Examen_recuperar_inscriptos(evento_id)
            If ds_inscriptos.Tables(0).Rows.Count <> 0 Then
                'entonces los muestro en el gridview 1
                dataset_examen.inscriptos.Merge(ds_inscriptos.Tables(0))
                GridView1.DataSource = dataset_examen.inscriptos
                GridView1.DataBind()

                'cargamos en el gridview la info q faltaba (instructor, nro., fecha de examen anterior)
                Dim i As Integer = 0
                While i < GridView1.Rows.Count
                    GridView1.Rows(i).Cells(0).Text = i + 1 'Nro.
                    'vemos cual es la graduacion a rendir
                    Dim dni = GridView1.Rows(i).Cells(2).Text 'dni
                    Dim graduacion_id_actual As Integer = 0
                    obtener_graduacion(dni, graduacion_id_actual)
                    '---------------------------------------------------------------------------------------------------------------------------------------
                    'veo en la tabla recuperada de la bd, cual es la graduacion siguiente.
                    graduacion_id_actual = graduacion_id_actual + 1 'al sumarle 1 voy a buscar la graduacion siguiente, es decir la que esta x rendir.
                    Dim j As Integer = 0
                    While j < ds_inscriptos.Tables(1).Rows.Count
                        If graduacion_id_actual = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_id") Then
                            GridView1.Rows(i).Cells(4).Text = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_desc") 'columna 4 es graduacion a rendir 
                            Exit While
                        End If
                        j = j + 1
                    End While
                    '---------------------------------------------------------------------------------------------------------------------------------------
                    'recupero info del instructor
                    Dim instructor_id As Integer = 0
                    obtener_instructor_id(dni, instructor_id)

                    Dim ds_info_instructor As DataSet = DAinstructor.Instructor_obtener_INFO(instructor_id)
                    Try
                        'columna 7 es el instructor
                        Dim instructor As String = ds_info_instructor.Tables(0).Rows(0).Item("ApellidoyNombre").ToString + "(dni:" + ds_info_instructor.Tables(0).Rows(0).Item("usuario_doc").ToString + ")"
                        GridView1.Rows(i).Cells(7).Text = instructor
                    Catch ex As Exception

                    End Try
                    '---------------------------------------------------------------------------------------------------------------------------------------
                    Dim usuario_id As Integer = 0
                    'Dim evento_id As Integer = ds_inscriptos.Tables(3).Rows(0).Item("evento_id")
                    Dim fecha_examen_Actual As Date = ds_inscriptos.Tables(3).Rows(0).Item("evento_fecha")
                    obtener_usuario_id(dni, usuario_id)
                    Try
                        'columna 6 es la es fecha anterior
                        Dim ds_fecha As DataSet = DAeventos.Examen_recuperar_fecha(usuario_id)
                        Dim ii As Integer = 0
                        While ii < ds_fecha.Tables(0).Rows.Count
                            Dim fecha_anterior As Date = ds_fecha.Tables(0).Rows(ii).Item("evento_fecha")
                            Dim evento_id_anterior As Integer = ds_fecha.Tables(0).Rows(ii).Item("evento_id")
                            If (fecha_anterior.Date < fecha_examen_Actual) And (evento_id <> evento_id_anterior) Then
                                GridView1.Rows(i).Cells(6).Text = fecha_anterior.Date
                                Exit While
                            End If
                            ii = ii + 1
                        End While
                    Catch ex As Exception

                    End Try
                    i = i + 1
                End While


            End If
            Try
                Label_evento.Text = "Evento: " + CStr(ds_inscriptos.Tables(3).Rows(0).Item("evento_descripcion"))
                Dim fecha As Date = ds_inscriptos.Tables(3).Rows(0).Item("evento_fecha")
                Label_evento_fecha.Text = "Fecha: " + CStr(fecha.Date)
                Label_evento_direccion.Text = "Dirección: " + CStr(ds_inscriptos.Tables(3).Rows(0).Item("evento_direccion"))
                Label_evento_cant_inscriptos.Text = "Cantidad de inscriptos: " + CStr(GridView1.Rows.Count)
            Catch ex As Exception

            End Try




        End If


    End Sub

    Private Function obtener_graduacion(ByVal dni As Integer, ByRef graduacion_id As Integer)
        Dim i As Integer = 0
        While i < dataset_examen.inscriptos.Rows.Count
            If dni = dataset_examen.inscriptos.Rows(i).Item("Dni") Then
                'lo encontre
                graduacion_id = dataset_examen.inscriptos.Rows(i).Item("graduacion_id")
                Exit While
            End If
            i = i + 1
        End While

        Return graduacion_id
    End Function

    Private Function obtener_instructor_id(ByVal dni As Integer, ByRef instructor_id As Integer)
        Dim i As Integer = 0
        While i < dataset_examen.inscriptos.Rows.Count
            If dni = dataset_examen.inscriptos.Rows(i).Item("Dni") Then
                'lo encontre
                instructor_id = dataset_examen.inscriptos.Rows(i).Item("instructor_id")
                Exit While
            End If
            i = i + 1
        End While

        Return instructor_id
    End Function

    Private Function obtener_usuario_id(ByVal dni As Integer, ByRef usuario_id As Integer)
        Dim i As Integer = 0
        While i < dataset_examen.inscriptos.Rows.Count
            If dni = dataset_examen.inscriptos.Rows(i).Item("Dni") Then
                'lo encontre
                usuario_id = dataset_examen.inscriptos.Rows(i).Item("usuario_id")
                Exit While
            End If
            i = i + 1
        End While

        Return usuario_id
    End Function


    Private Sub btn_exportar_excel1_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_exportar_excel1.ServerClick
        'Response.Clear()
        'Response.Buffer = True
        'Response.Charset = ""
        'Response.AddHeader("content-disposition", "attachment, filename=Examen_inscriptos.xls")
        'Response.ContentType = "application/ms-excel "
        'Dim sw As StringWriter = New StringWriter()
        'Dim hw As HtmlTextWriter = New HtmlTextWriter(sw)
        'GridView1.AllowPaging = False
        'GridView1.DataBind()
        'GridView1.RenderControl(hw)
        'Response.Output.Write(sw.ToString())
        'Response.Flush()
        'Response.End()

    End Sub

  
    Private Sub Boton_exportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton_exportar.Click
        

    End Sub

    Public Overloads Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)

    End Sub

    'Public Overrides Sub VerifyRenderingInServerForm(ByVal control As System.Web.UI.Control)
    '    ' Do NOT call MyBase.VerifyRenderingInServerForm
    'End Sub


End Class