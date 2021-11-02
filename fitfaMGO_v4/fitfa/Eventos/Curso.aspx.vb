Public Class Curso
    Inherits System.Web.UI.Page
    Dim DAinscripciones As New Capa_de_datos.Inscripciones
    Dim DAeventos As New Capa_de_datos.Eventos
    Dim dataset_examen As New Examen_ds

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Carga_inicial_LOAD()

            'div_msj_error_eliminar.Visible = False

           

        End If
    End Sub

    Private Sub Carga_inicial_LOAD()
        dataset_examen.inscriptos.Rows.Clear()
        GridView2.DataSource = ""
        GridView2.DataBind()

        Dim evento_id As Integer = CInt(Session("evento_id"))

        'recupero inscriptos
        Dim ds_inscriptos As DataSet = DAeventos.Curso_recuperar_inscriptos(evento_id)
        If ds_inscriptos.Tables(0).Rows.Count <> 0 Then
            'entonces los muestro en el gridview 1
            dataset_examen.inscriptos.Merge(ds_inscriptos.Tables(0))
            GridView2.DataSource = dataset_examen.inscriptos
            GridView2.DataBind()

        End If



    End Sub

End Class