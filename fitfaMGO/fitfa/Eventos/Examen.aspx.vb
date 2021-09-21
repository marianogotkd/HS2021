﻿
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



    Dim DAinscripciones As New Capa_de_datos.Inscripciones
    Dim DAeventos As New Capa_de_datos.Eventos
    Dim dataset_examen As New Examen_ds 'LO USO EN LA PRIMERA PESTAÑA
    Dim dataset_examen_b As New Examen_ds 'LO USO EN LA PESTAÑA DE TURNOS
    Dim dataset_examen_c_sinevaluar As New Examen_ds 'LO USO EN LA PESTAÑA DE resultados "sin evaluar"
    Dim dataset_examen_c_desaprobados As New Examen_ds 'LO USO EN LA PESTAÑA DE resultados "desaprobados"
    Dim dataset_examen_c_aprobados As New Examen_ds 'LO USO EN LA PESTAÑA DE resultados "aprobados"
    Dim dataset_examen_c_doblepromo As New Examen_ds 'LO USO EN LA PESTAÑA DE resultados "doble promo"
    Dim DAinstructor As New Capa_de_datos.Instructor

    Private Sub CARGA_INICIAL_TABLA_PESTAÑA_TURNOS(ByVal ds_inscriptos As DataSet)
        Dim evento_id As Integer = CInt(Session("evento_id"))

        If ds_inscriptos.Tables(0).Rows.Count <> 0 Then
            'entonces los muestro en el gridview 1
            dataset_examen_b.inscriptos.Merge(ds_inscriptos.Tables(0))
            GridView2.DataSource = dataset_examen_b.inscriptos
            GridView2.DataBind()

            'cargamos en el gridview la info q faltaba (instructor, nro., fecha de examen anterior)
            Dim i As Integer = 0
            While i < GridView2.Rows.Count
                GridView2.Rows(i).Cells(0).Text = i + 1 'Nro.
                'vemos cual es la graduacion a rendir
                Dim dni = GridView2.Rows(i).Cells(2).Text 'dni
                Dim graduacion_id_actual As Integer = 0
                obtener_graduacion(dni, graduacion_id_actual)
                '---------------------------------------------------------------------------------------------------------------------------------------
                'veo en la tabla recuperada de la bd, cual es la graduacion siguiente.
                graduacion_id_actual = graduacion_id_actual + 1 'al sumarle 1 voy a buscar la graduacion siguiente, es decir la que esta x rendir.
                Dim j As Integer = 0
                While j < ds_inscriptos.Tables(1).Rows.Count
                    If graduacion_id_actual = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_id") Then
                        GridView2.Rows(i).Cells(4).Text = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_desc") 'columna 4 es graduacion a rendir 
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
                    GridView2.Rows(i).Cells(7).Text = instructor
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
                            GridView2.Rows(i).Cells(6).Text = fecha_anterior.Date
                            Exit While
                        End If
                        ii = ii + 1
                    End While
                Catch ex As Exception

                End Try
                i = i + 1
            End While


        End If

        Dim fila_totales As DataRow = dataset_examen_b.Tables("info_turnos").NewRow
        fila_totales("Info") = "Total de Inscriptos: " + CStr(GridView2.Rows.Count)
        dataset_examen_b.Tables("info_turnos").Rows.Add(fila_totales)

        If GridView2.Rows.Count <> 0 Then
            Dim i As Integer = 0

            While i < GridView2.Rows.Count
                Dim turno As String = GridView2.Rows(i).Cells(13).Text  '13 es turno
                Dim j As Integer = 1
                Dim cont As Integer = 0
                While j < dataset_examen_b.Tables("info_turnos").Rows.Count
                    If turno = dataset_examen_b.Tables("info_turnos").Rows(j).Item("Info") Then
                        cont = CInt(dataset_examen_b.Tables("info_turnos").Rows(j).Item("contador")) + 1
                        dataset_examen_b.Tables("info_turnos").Rows(j).Item("contador") = cont
                        Exit While
                    End If
                    j = j + 1
                End While
                If cont = 0 Then 'quiere decir q no esta en la tabla info_turnos
                    Dim fila_turno As DataRow = dataset_examen_b.info_turnos.NewRow
                    fila_turno("Info") = GridView2.Rows(i).Cells(13).Text
                    fila_turno("contador") = 1
                    dataset_examen_b.info_turnos.Rows.Add(fila_turno)
                End If
                i = i + 1
            End While
            If dataset_examen_b.info_turnos.Rows.Count > 1 Then
                'ahora le agrego los string para q sea mas descriptivo
                Dim k As Integer = 1
                While k < dataset_examen_b.info_turnos.Rows.Count
                    dataset_examen_b.info_turnos.Rows(k).Item("Info") = "Total en turno " + dataset_examen_b.info_turnos.Rows(k).Item("Info") + ": " + CStr(dataset_examen_b.info_turnos.Rows(k).Item("contador")) + "."
                    k = k + 1
                End While
            End If
        End If

        GridView3.DataSource = dataset_examen_b.info_turnos
        GridView3.DataBind()


    End Sub

    Private Sub Carga_inicial_LOAD()
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
            '/////////////////LISTADO DEL EXAMEN//////////////////
            Label_evento.Text = "Evento: " + CStr(ds_inscriptos.Tables(3).Rows(0).Item("evento_descripcion"))
            Dim fecha As Date = ds_inscriptos.Tables(3).Rows(0).Item("evento_fecha")
            Label_evento_fecha.Text = "Fecha: " + CStr(fecha.Date)
            Label_evento_direccion.Text = "Dirección: " + CStr(ds_inscriptos.Tables(3).Rows(0).Item("evento_direccion"))
            Label_evento_cant_inscriptos.Text = "Cantidad de inscriptos: " + CStr(GridView1.Rows.Count)
            '///////////////TURNOS/////////////////////
            Label_evento_b.Text = "Evento: " + CStr(ds_inscriptos.Tables(3).Rows(0).Item("evento_descripcion"))
            'Dim fecha As Date = ds_inscriptos.Tables(3).Rows(0).Item("evento_fecha")
            Label_evento_fecha_b.Text = "Fecha: " + CStr(fecha.Date)
            Label_evento_direccion_b.Text = "Dirección: " + CStr(ds_inscriptos.Tables(3).Rows(0).Item("evento_direccion"))
            Label_evento_cant_inscriptos_b.Text = "Cantidad de inscriptos: " + CStr(GridView1.Rows.Count)
            'cargo en un combobox los turnos creados para el evento actual

            DropDownList_turnos.DataSource = ds_inscriptos.Tables(2)
            DropDownList_turnos.DataTextField = "ExamenTurno_desc"
            DropDownList_turnos.DataValueField = "ExamenTurno_id"
            DropDownList_turnos.DataBind()


            '///////////////RESULTADOS/////////////////////
            Label_evento_c.Text = "Evento: " + CStr(ds_inscriptos.Tables(3).Rows(0).Item("evento_descripcion"))
            'Dim fecha As Date = ds_inscriptos.Tables(3).Rows(0).Item("evento_fecha")
            Label_evento_fecha_c.Text = "Fecha: " + CStr(fecha.Date)
            Label_evento_direccion_c.Text = "Dirección: " + CStr(ds_inscriptos.Tables(3).Rows(0).Item("evento_direccion"))
            Label_evento_cant_inscriptos_c.Text = "Cantidad de inscriptos: " + CStr(GridView1.Rows.Count)
        Catch ex As Exception

        End Try


        CARGA_INICIAL_TABLA_PESTAÑA_TURNOS(ds_inscriptos) 'carga de la pestaña 2, turnos
        CARGA_INICIAL_TABLA_PESTAÑA_RESULTADOS_sinevaluar(ds_inscriptos) 'carga la pestaña 3, resultados sin evaluar
        CARGA_INICIAL_TABLA_PESTAÑA_RESULTADOS_desaprobados(ds_inscriptos) 'carga la pestaña 3, resultados desaprobados
        CARGA_INICIAL_TABLA_PESTAÑA_RESULTADOS_aprobado(ds_inscriptos) 'carga la pestaña 3, resultados aprobados
        CARGA_INICIAL_TABLA_PESTAÑA_RESULTADOS_doblepromo(ds_inscriptos) 'carga la pestaña 3, resultados doble promo
    End Sub

    Private Sub CARGA_INICIAL_TABLA_PESTAÑA_RESULTADOS_desaprobados(ByVal ds_inscriptos As DataSet)
        'cargo primero los alumnos sin calificar.
        Dim evento_id As Integer = CInt(Session("evento_id"))

        If ds_inscriptos.Tables(5).Rows.Count <> 0 Then
            grupo_desaprobados.Visible = True
            'entonces los muestro en el gridview 1
            dataset_examen_c_desaprobados.inscriptos.Merge(ds_inscriptos.Tables(5))
            GridView_desaprobados.DataSource = dataset_examen_c_desaprobados.inscriptos
            GridView_desaprobados.DataBind()

            'cargamos en el gridview la info q faltaba (instructor, nro., fecha de examen anterior)
            Dim i As Integer = 0
            While i < GridView_desaprobados.Rows.Count
                GridView_desaprobados.Rows(i).Cells(0).Text = i + 1 'Nro.
                'vemos cual es la graduacion a rendir
                Dim dni = GridView_desaprobados.Rows(i).Cells(2).Text 'dni
                Dim graduacion_id_actual As Integer = 0
                obtener_graduacion(dni, graduacion_id_actual)
                '---------------------------------------------------------------------------------------------------------------------------------------
                'veo en la tabla recuperada de la bd, cual es la graduacion siguiente.
                graduacion_id_actual = graduacion_id_actual + 1 'al sumarle 1 voy a buscar la graduacion siguiente, es decir la que esta x rendir.
                Dim j As Integer = 0
                While j < ds_inscriptos.Tables(1).Rows.Count
                    If graduacion_id_actual = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_id") Then
                        GridView_desaprobados.Rows(i).Cells(4).Text = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_desc") 'columna 4 es graduacion a rendir 
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
                    GridView_desaprobados.Rows(i).Cells(7).Text = instructor
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
                            GridView_desaprobados.Rows(i).Cells(6).Text = fecha_anterior.Date
                            Exit While
                        End If
                        ii = ii + 1
                    End While
                Catch ex As Exception

                End Try
                i = i + 1
            End While
        Else
            grupo_desaprobados.Visible = False
        End If
    End Sub

    Private Sub CARGA_INICIAL_TABLA_PESTAÑA_RESULTADOS_aprobado(ByVal ds_inscriptos As DataSet)
        'cargo primero los alumnos sin calificar.
        Dim evento_id As Integer = CInt(Session("evento_id"))

        If ds_inscriptos.Tables(6).Rows.Count <> 0 Then
            grupo_aprobados.Visible = True
            'entonces los muestro en el gridview 1
            dataset_examen_c_aprobados.inscriptos.Merge(ds_inscriptos.Tables(6))
            GridView_aprobados.DataSource = dataset_examen_c_aprobados.inscriptos
            GridView_aprobados.DataBind()

            'cargamos en el gridview la info q faltaba (instructor, nro., fecha de examen anterior)
            Dim i As Integer = 0
            While i < GridView_aprobados.Rows.Count
                GridView_aprobados.Rows(i).Cells(0).Text = i + 1 'Nro.
                'vemos cual es la graduacion a rendir
                Dim dni = GridView_aprobados.Rows(i).Cells(2).Text 'dni
                Dim graduacion_id_actual As Integer = 0
                obtener_graduacion(dni, graduacion_id_actual)
                '---------------------------------------------------------------------------------------------------------------------------------------
                'veo en la tabla recuperada de la bd, cual es la graduacion siguiente.
                graduacion_id_actual = graduacion_id_actual + 1 'al sumarle 1 voy a buscar la graduacion siguiente, es decir la que esta x rendir.
                Dim j As Integer = 0
                While j < ds_inscriptos.Tables(1).Rows.Count
                    If graduacion_id_actual = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_id") Then
                        GridView_aprobados.Rows(i).Cells(4).Text = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_desc") 'columna 4 es graduacion a rendir 
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
                    GridView_aprobados.Rows(i).Cells(7).Text = instructor
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
                            GridView_aprobados.Rows(i).Cells(6).Text = fecha_anterior.Date
                            Exit While
                        End If
                        ii = ii + 1
                    End While
                Catch ex As Exception

                End Try
                i = i + 1
            End While
        Else
            grupo_aprobados.Visible = False
        End If
    End Sub

    Private Sub CARGA_INICIAL_TABLA_PESTAÑA_RESULTADOS_doblepromo(ByVal ds_inscriptos As DataSet)
        'cargo primero los alumnos sin calificar.
        Dim evento_id As Integer = CInt(Session("evento_id"))

        If ds_inscriptos.Tables(7).Rows.Count <> 0 Then
            grupo_doblepromo.Visible = True
            'entonces los muestro en el gridview 1
            dataset_examen_c_sinevaluar.inscriptos.Merge(ds_inscriptos.Tables(7))
            GridView_doblepromo.DataSource = dataset_examen_c_sinevaluar.inscriptos
            GridView_doblepromo.DataBind()

            'cargamos en el gridview la info q faltaba (instructor, nro., fecha de examen anterior)
            Dim i As Integer = 0
            While i < GridView_doblepromo.Rows.Count
                GridView_doblepromo.Rows(i).Cells(0).Text = i + 1 'Nro.
                'vemos cual es la graduacion a rendir
                Dim dni = GridView_doblepromo.Rows(i).Cells(2).Text 'dni
                Dim graduacion_id_actual As Integer = 0
                obtener_graduacion(dni, graduacion_id_actual)
                '---------------------------------------------------------------------------------------------------------------------------------------
                'veo en la tabla recuperada de la bd, cual es la graduacion siguiente.
                graduacion_id_actual = graduacion_id_actual + 1 'al sumarle 1 voy a buscar la graduacion siguiente, es decir la que esta x rendir.
                Dim j As Integer = 0
                While j < ds_inscriptos.Tables(1).Rows.Count
                    If graduacion_id_actual = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_id") Then
                        GridView_doblepromo.Rows(i).Cells(4).Text = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_desc") 'columna 4 es graduacion a rendir 
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
                    GridView_doblepromo.Rows(i).Cells(7).Text = instructor
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
                            GridView_doblepromo.Rows(i).Cells(6).Text = fecha_anterior.Date
                            Exit While
                        End If
                        ii = ii + 1
                    End While
                Catch ex As Exception

                End Try
                i = i + 1
            End While
        Else
            grupo_doblepromo.Visible = False
        End If
    End Sub

    Private Sub CARGA_INICIAL_TABLA_PESTAÑA_RESULTADOS_sinevaluar(ByVal ds_inscriptos As DataSet)
        'cargo primero los alumnos sin calificar.
        Dim evento_id As Integer = CInt(Session("evento_id"))

        If ds_inscriptos.Tables(4).Rows.Count <> 0 Then
            grupo_sin_evaluar.Visible = True
            'entonces los muestro en el gridview 1
            dataset_examen_c_sinevaluar.inscriptos.Merge(ds_inscriptos.Tables(4))
            GridView_sinevaluar.DataSource = dataset_examen_c_sinevaluar.inscriptos
            GridView_sinevaluar.DataBind()

            'cargamos en el gridview la info q faltaba (instructor, nro., fecha de examen anterior)
            Dim i As Integer = 0
            While i < GridView_sinevaluar.Rows.Count
                GridView_sinevaluar.Rows(i).Cells(0).Text = i + 1 'Nro.
                'vemos cual es la graduacion a rendir
                Dim dni = GridView_sinevaluar.Rows(i).Cells(2).Text 'dni
                Dim graduacion_id_actual As Integer = 0
                obtener_graduacion(dni, graduacion_id_actual)
                '---------------------------------------------------------------------------------------------------------------------------------------
                'veo en la tabla recuperada de la bd, cual es la graduacion siguiente.
                graduacion_id_actual = graduacion_id_actual + 1 'al sumarle 1 voy a buscar la graduacion siguiente, es decir la que esta x rendir.
                Dim j As Integer = 0
                While j < ds_inscriptos.Tables(1).Rows.Count
                    If graduacion_id_actual = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_id") Then
                        GridView_sinevaluar.Rows(i).Cells(4).Text = ds_inscriptos.Tables(1).Rows(j).Item("graduacion_desc") 'columna 4 es graduacion a rendir 
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
                    GridView_sinevaluar.Rows(i).Cells(7).Text = instructor
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
                            GridView_sinevaluar.Rows(i).Cells(6).Text = fecha_anterior.Date
                            Exit While
                        End If
                        ii = ii + 1
                    End While
                Catch ex As Exception

                End Try
                i = i + 1
            End While
        Else
            grupo_sin_evaluar.Visible = False
        End If

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Session("evento_id")
        If Not IsPostBack Then
            Carga_inicial_LOAD()

            'div_msj_error_eliminar.Visible = False


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

  
    

    Public Overloads Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)

    End Sub

    'Public Overrides Sub VerifyRenderingInServerForm(ByVal control As System.Web.UI.Control)
    '    ' Do NOT call MyBase.VerifyRenderingInServerForm
    'End Sub


    Private Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        If (e.CommandName = "op_eliminar") Then
            ' Retrieve the row index stored in the CommandArgument property.
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = Integer.Parse(e.CommandArgument.ToString()) 'este es el id de la inscripcion = Inscexamen_id
            'solo se elimina si aun no está calificado.
            'luego de eliminar debo volver a cargar todas las grillas.
            div_msj_error_eliminar.Visible = True

        End If
    End Sub
    Dim ChkMover As CheckBox
    Private Sub Btn_confirmar_cambio_turno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_confirmar_cambio_turno.Click
        Dim evento_id As Integer = CInt(Session("evento_id"))

        'recupero inscriptos
        Dim ds_inscriptos As DataSet = DAeventos.Examen_recuperar_inscriptos(evento_id)

        Dim cabios_efectuados As String = "no"

        Dim i As Integer = 0
        While i < GridView2.Rows.Count
            ChkMover = CType(Me.GridView2.Rows(i).FindControl("chk_mover"), CheckBox)
            If ChkMover.Checked = True Then
                Dim dni As Integer = CInt(GridView2.Rows(i).Cells(2).Text)
                Dim Inscexamen_id As Integer = 0



                Dim ii As Integer = 0
                While ii < ds_inscriptos.Tables(0).Rows.Count
                    If CInt(dni) = CInt(ds_inscriptos.Tables(0).Rows(ii).Item("Dni")) Then
                        Inscexamen_id = CInt(ds_inscriptos.Tables(0).Rows(ii).Item("Inscexamen_id"))
                        Exit While
                    End If
                    ii = ii + 1
                End While

                Dim ExamenTurno_id As Integer = CInt(DropDownList_turnos.SelectedValue)

                DAinscripciones.inscripciones_x_examen_modificar(Inscexamen_id, ExamenTurno_id)
                cabios_efectuados = "si"
            End If
            i = i + 1
        End While
        If cabios_efectuados = "si" Then
            'actualizo el form con los cambios efectuados.
            Carga_inicial_LOAD()

            'aqui va mensaje de que se efectuaron los cambios
        Else
            'aqui va mensaje de que se debe seleccionar al menos un item del gridview.
        End If
    End Sub

    Dim Drop_resultados As DropDownList
    Dim DAusuario As New Capa_de_datos.usuario
    Dim chk_calificar As CheckBox
    Private Sub Btn_confirmar_resultados_evaluacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_confirmar_resultados_evaluacion.Click
        Dim evento_id As Integer = CInt(Session("evento_id"))

        'recupero inscriptos
        Dim ds_inscriptos As DataSet = DAeventos.Examen_recuperar_inscriptos(evento_id)

        Dim cabios_efectuados As String = "no"

        Dim i As Integer = 0
        While i < GridView_sinevaluar.Rows.Count
            chk_calificar = CType(Me.GridView_sinevaluar.Rows(i).FindControl("chk_calificar"), CheckBox)

            If chk_calificar.Checked = True Then



                Drop_resultados = CType(Me.GridView_sinevaluar.Rows(i).FindControl("Drop_resultado"), DropDownList)

                'ChkMover = CType(Me.GridView2.Rows(i).FindControl("chk_mover"), CheckBox)
                If Drop_resultados.SelectedValue <> "Sin Evaluar" Then
                    Dim dni As Integer = CInt(GridView_sinevaluar.Rows(i).Cells(2).Text)
                    Dim Inscexamen_id As Integer = 0
                    Dim graduacion_id As Integer = 0
                    Dim ii As Integer = 0
                    Dim usuario_id As Integer = 0
                    While ii < ds_inscriptos.Tables(0).Rows.Count
                        If CInt(dni) = CInt(ds_inscriptos.Tables(0).Rows(ii).Item("Dni")) Then
                            Inscexamen_id = CInt(ds_inscriptos.Tables(0).Rows(ii).Item("Inscexamen_id"))
                            graduacion_id = CInt(ds_inscriptos.Tables(0).Rows(ii).Item("graduacion_id"))
                            usuario_id = CInt(ds_inscriptos.Tables(0).Rows(ii).Item("usuario_id"))
                            Exit While
                        End If
                        ii = ii + 1
                    End While

                    Dim ExamenTurno_id As Integer = CInt(DropDownList_turnos.SelectedValue)

                    'tambien lo que voy a hacer es pasar de graduacion dependiendo la calificacion.
                    '1) recupero el id de la graduación.
                    Select Case Drop_resultados.SelectedValue
                        Case "Aprobado"
                            '///////////////si es aprobado se le sube la graduacion en 1
                            graduacion_id = graduacion_id + 1
                            DAinscripciones.inscripciones_x_examen_modificar_resultado(Inscexamen_id, ExamenTurno_id, Drop_resultados.SelectedValue, graduacion_id)
                            cabios_efectuados = "si"
                            DAusuario.Usuario_modificar_graduacion(usuario_id, graduacion_id)
                            certificacion_registrar(graduacion_id, usuario_id)
                        Case "Doble Promoción"
                            '////////////si es doble promocion se le sube la graduacion x 2
                            graduacion_id = graduacion_id + 2
                            DAinscripciones.inscripciones_x_examen_modificar_resultado(Inscexamen_id, ExamenTurno_id, Drop_resultados.SelectedValue, graduacion_id)
                            cabios_efectuados = "si"
                            DAusuario.Usuario_modificar_graduacion(usuario_id, graduacion_id)
                            certificacion_registrar(graduacion_id, usuario_id)
                        Case "Desaprobado"
                            DAinscripciones.inscripciones_x_examen_modificar_resultado(Inscexamen_id, ExamenTurno_id, Drop_resultados.SelectedValue, graduacion_id)
                            cabios_efectuados = "si"
                    End Select

                End If
            End If
            i = i + 1
        End While
        If cabios_efectuados = "si" Then
            'actualizo el form con los cambios efectuados.
            Carga_inicial_LOAD()


            'aqui va mensaje de que se efectuaron los cambios
        Else
            'aqui va mensaje de que se debe seleccionar al menos un item del gridview.
        End If
    End Sub

    Private Sub certificacion_registrar(ByVal graduacion_id As Integer, ByVal usuario_id As Integer)
        Select Case graduacion_id
            Case 2 'Blanco
                'Certificacion_registrar_b(graduacion_id, usuario_id)
            Case 4 'Amarillo
                Certificacion_registrar_b(graduacion_id, usuario_id)
            Case 6 'Verde
                Certificacion_registrar_b(graduacion_id, usuario_id)
            Case 8 'Azul
                Certificacion_registrar_b(graduacion_id, usuario_id)
            Case 10 'Rojo
                Certificacion_registrar_b(graduacion_id, usuario_id)
            Case 12 'Primer Dan
            Case 13 'Segundo Dan
            Case 14 'Tercer Dan
            Case 15 'Cuarto Dan
            Case 16 'Quinto Dan
            Case 17 'Sexto Dan
            Case 18 'Septimo Dan
            Case 19 'Octavo Dan
            Case 20 'Noveno Dan
        End Select

    End Sub
    Private Sub Certificacion_registrar_b(ByVal graduacion_id As Integer, ByVal usuario_id As Integer)
        Dim evento_id As Integer = CInt(Session("evento_id"))
        DAinscripciones.ExamenCertificacion_alta(usuario_id, graduacion_id, evento_id)
    End Sub

End Class