Public Class Curso
    Inherits System.Web.UI.Page
    Dim DAinscripciones As New Capa_de_datos.Inscripciones
    Dim DAeventos As New Capa_de_datos.Eventos
    Dim Curso_DS As New Curso_DS

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Carga_inicial_LOAD()

            'div_msj_error_eliminar.Visible = False

           

        End If
    End Sub

    Private Sub Carga_inicial_LOAD()
        Curso_DS.Curso_recuperar_inscriptos.Rows.Clear()
        GridView2.DataSource = ""
        GridView2.DataBind()

        Dim evento_id As Integer = CInt(Session("evento_id"))

        'recupero inscriptos
        Dim ds_inscriptos As DataSet = DAeventos.Curso_recuperar_inscriptos(evento_id)
        If ds_inscriptos.Tables(0).Rows.Count <> 0 Then
            'entonces los muestro en el gridview 1
            Curso_DS.Curso_recuperar_inscriptos.Merge(ds_inscriptos.Tables(0))
            GridView2.DataSource = Curso_DS.Curso_recuperar_inscriptos
            GridView2.DataBind()

        End If



    End Sub

End Class