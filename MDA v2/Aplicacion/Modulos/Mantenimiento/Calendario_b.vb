Public Class Calendario_b
    Private currentDate As DateTime = DateTime.Today



    Private Sub Calendario_b_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        limpiar_nro_dias()
        'currentDate = CDate("31/08/2021") 'esto es para pruebas de fechas concretas
        DisplayCurrentDate()

        'recupero las citas para el mes y de ahi ciclo y solo muestro los de la semana.
        cargar_citas() 'lleno el datatable con el mes completo
        cargar_gridview() 'solo la semana

        rellenar_gridview() 'agrego filas en blanco
    End Sub

    Private Sub rellenar_gridview()
        'x cosas de diseño quiero tener filas, no importa si estan vacias
        If Mantenimiento_ds.Tables("Calendario_b").Rows.Count = 0 Then
            Dim contador = 0
            While Mantenimiento_ds.Tables("Calendario_b").Rows.Count < 20
                Mantenimiento_ds.Tables("Calendario_b").Rows.Add()
                'contador = contador + 1
            End While
        Else
            While Mantenimiento_ds.Tables("Calendario_b").Rows.Count < 20
                Mantenimiento_ds.Tables("Calendario_b").Rows.Add()
            End While
        End If
    End Sub

    Private Sub DisplayCurrentDate()

        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        'Dim firstDayAtFlNumber As Integer = 1
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate() 'recupera el total de dias para el mes actual
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        'AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Dim nuevo_mes As String = ""
    Private Sub validad_dias(ByRef dia As Label, ByVal totaldiasenelmes As Integer, ByVal valor As Integer, ByVal operacion As String)
        If operacion = "sumar" Then
            Dim suma As Date = currentDate.AddDays(valor)
            


            If currentDate.Day + valor <= totaldiasenelmes Then
                dia.Text = suma.Day

            Else
                'en una variable aviso que se termino el mes. asi el mes siguiente empieza bien el conteo.
                nuevo_mes = "si"
                dia.Text = suma.Day 'choco 01-11-2021
            End If
        End If
        If operacion = "restar" Then
            Dim resta As Date = currentDate.AddDays(-valor)
            If currentDate.Day - valor <= totaldiasenelmes And ((currentDate.Day - valor) > 0) Then
                dia.Text = resta.Day
            Else
                nuevo_mes = "si"
                dia.Text = resta.Day  'choco 01-11-2021
            End If
        End If


    End Sub


    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        'For Each fl As FlowLayoutPanel In listFlDay
        '    fl.Controls.Clear()
        '    fl.Tag = 0
        '    fl.BackColor = Color.WhiteSmoke
        '    'fl.HorizontalScroll.Enabled = True
        '    'fl.VerticalScroll.Enabled = True
        '    'fl.AutoScroll = True
        'Next
        Dim diactual As Integer = CInt(currentDate.Day)


        Select Case currentDate.DayOfWeek
            Case DayOfWeek.Sunday  'es domingo
                dia_domingo_nro.Text = currentDate.Day
                dia_domingo_nro.ForeColor = Color.Blue
                validad_dias(dia_lunes_nro, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 2, "sumar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 3, "sumar")
                'dia_miercoles_nro.Text = currentDate.Day + 3
                validad_dias(dia_jueves_numero, totalDaysInMonth, 4, "sumar")
                'dia_jueves_numero.Text = currentDate.Day + 4
                validad_dias(dia_viernes_nro, totalDaysInMonth, 5, "sumar")
                'dia_viernes_nro.Text = currentDate.Day + 5
                validad_dias(dia_sabado_nro, totalDaysInMonth, 6, "sumar")
                'dia_sabado_nro.Text = currentDate.Day + 6


                

            Case DayOfWeek.Monday  'es lunes
                
                '-----original
                validad_dias(dia_domingo_nro, totalDaysInMonth, 1, "restar")
                dia_lunes_nro.Text = currentDate.Day
                dia_lunes_nro.ForeColor = Color.Blue
                validad_dias(dia_martes_nro, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 2, "sumar")
                validad_dias(dia_jueves_numero, totalDaysInMonth, 3, "sumar")
                validad_dias(dia_viernes_nro, totalDaysInMonth, 4, "sumar")
                validad_dias(dia_sabado_nro, totalDaysInMonth, 5, "sumar")

                '----choco 01-11-2021
                currentDate = currentDate.AddDays(-1)

            Case DayOfWeek.Tuesday   'es martes
                validad_dias(dia_domingo_nro, totalDaysInMonth, 2, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 1, "restar")
                dia_martes_nro.Text = currentDate.Day
                dia_martes_nro.ForeColor = Color.Blue
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_jueves_numero, totalDaysInMonth, 2, "sumar")
                validad_dias(dia_viernes_nro, totalDaysInMonth, 3, "sumar")
                validad_dias(dia_sabado_nro, totalDaysInMonth, 4, "sumar")

                '----choco 01-11-2021
                currentDate = currentDate.AddDays(-2)
            Case DayOfWeek.Wednesday    'es miercoles
                validad_dias(dia_domingo_nro, totalDaysInMonth, 3, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 2, "restar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 1, "restar")
                dia_miercoles_nro.Text = currentDate.Day
                dia_miercoles_nro.ForeColor = Color.Blue
                validad_dias(dia_jueves_numero, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_viernes_nro, totalDaysInMonth, 2, "sumar")
                validad_dias(dia_sabado_nro, totalDaysInMonth, 3, "sumar")

                '----choco 01-11-2021
                currentDate = currentDate.AddDays(-3)
            Case DayOfWeek.Thursday     'es jueves
                validad_dias(dia_domingo_nro, totalDaysInMonth, 4, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 3, "restar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 2, "restar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 1, "restar")
                dia_jueves_numero.Text = currentDate.Day
                dia_jueves_numero.ForeColor = Color.Blue
                validad_dias(dia_viernes_nro, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_sabado_nro, totalDaysInMonth, 2, "sumar")

                '----choco 01-11-2021
                currentDate = currentDate.AddDays(-4)
            Case DayOfWeek.Friday      'es viernes
                validad_dias(dia_domingo_nro, totalDaysInMonth, 5, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 4, "restar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 3, "restar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 2, "restar")
                validad_dias(dia_jueves_numero, totalDaysInMonth, 1, "restar")
                dia_viernes_nro.Text = currentDate.Day
                dia_viernes_nro.ForeColor = Color.Blue
                validad_dias(dia_sabado_nro, totalDaysInMonth, 1, "sumar")


                '----choco 01-11-2021
                currentDate = currentDate.AddDays(-5)
            Case DayOfWeek.Saturday       'es sabado
                validad_dias(dia_domingo_nro, totalDaysInMonth, 6, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 5, "restar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 4, "restar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 3, "restar")
                validad_dias(dia_jueves_numero, totalDaysInMonth, 2, "restar")
                validad_dias(dia_viernes_nro, totalDaysInMonth, 1, "restar")
                dia_sabado_nro.Text = currentDate.Day
                dia_sabado_nro.ForeColor = Color.Blue

                '----choco 01-11-2021
                currentDate = currentDate.AddDays(-6)
        End Select









        'For i As Integer = 1 To totalDaysInMonth
        '    Dim lbl As New Label
        '    'lbl.Name = $"lblDay{i}"
        '    'lbl.Name = "choco"
        '    lbl.AutoSize = False
        '    lbl.TextAlign = ContentAlignment.MiddleRight
        '    lbl.Size = New Size(110, 22)
        '    lbl.Text = i
        '    lbl.Font = New Font("Microsoft Sans Serif", 12)
        '    listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
        '    listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

        '    If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
        '        listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.NavajoWhite 'este es el color de el dia actual.
        '        'listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Blue

        '    End If

        'Next
    End Sub

    Private Sub btnToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click
        hoy()
        'recupero las citas para el mes y de ahi ciclo y solo muestro los de la semana.
        cargar_citas() 'lleno el datatable con el mes completo
        cargar_gridview() 'solo la semana
        rellenar_gridview() 'agrego filas en blanco
    End Sub

    Private Sub limpiar_nro_dias()
        dia_domingo_nro.ForeColor = Color.Black
        dia_lunes_nro.ForeColor = Color.Black
        dia_martes_nro.ForeColor = Color.Black
        dia_miercoles_nro.ForeColor = Color.Black
        dia_jueves_numero.ForeColor = Color.Black
        dia_viernes_nro.ForeColor = Color.Black
        dia_sabado_nro.ForeColor = Color.Black

        dia_domingo_nro.Text = ""
        dia_lunes_nro.Text = ""
        dia_martes_nro.Text = ""
        dia_miercoles_nro.Text = ""
        dia_jueves_numero.Text = ""
        dia_viernes_nro.Text = ""
        dia_sabado_nro.Text = ""
    End Sub

    Private Sub hoy()
        limpiar_nro_dias()
        currentDate = DateTime.Today
        DisplayCurrentDate()


    End Sub

    Private Sub btnPrevMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevMonth.Click
        limpiar_nro_dias()
        PrevMonth()
        'recupero las citas para el mes y de ahi ciclo y solo muestro los de la semana.
        cargar_citas() 'lleno el datatable con el mes completo
        cargar_gridview() 'solo la semana
        rellenar_gridview() 'agrego filas en blanco
    End Sub

    Private Sub PrevMonth()

        Dim fecha_calculada As DateTime
        'primero intento quitarle solamente 7 dias.
        Select Case currentDate.DayOfWeek
            Case DayOfWeek.Sunday  'es domingo
                fecha_calculada = currentDate.AddDays(-1)
            Case DayOfWeek.Monday  'es lunes
                fecha_calculada = currentDate.AddDays(-2)
            Case DayOfWeek.Tuesday   'es martes
                fecha_calculada = currentDate.AddDays(-3)

            Case DayOfWeek.Wednesday    'es miercoles
                fecha_calculada = currentDate.AddDays(-4)
            Case DayOfWeek.Thursday     'es jueves
                fecha_calculada = currentDate.AddDays(-5)
            Case DayOfWeek.Friday      'es viernes
                fecha_calculada = currentDate.AddDays(-6)

            Case DayOfWeek.Saturday       'es sabado
                fecha_calculada = currentDate.AddDays(-7)
        End Select
        If nuevo_mes = "si" And fecha_calculada.Month <> currentDate.Month Then

            currentDate = New Date(currentDate.Year, currentDate.Month, 1) 'obtengo el primer dia
            Dim ultimo_dia As Integer = currentDate.AddDays(-1).Day
            currentDate = currentDate.AddMonths(-1)
            currentDate = New Date(currentDate.Year, currentDate.Month, ultimo_dia)

            'choco: 01-11-2021
            Select Case fecha_calculada.DayOfWeek
                Case DayOfWeek.Saturday
                    currentDate = fecha_calculada.AddDays(-6)
            End Select



            nuevo_mes = ""
        Else
            currentDate = fecha_calculada
        End If


        'currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()

        '////////////////////////////////////////////////////////
        Dim dia_DEL_sistema As Date = Today

        Dim rango_a As DateTime
        Dim rango_b As DateTime
        Select Case currentDate.DayOfWeek
            Case DayOfWeek.Sunday
                rango_a = currentDate
                rango_b = currentDate.AddDays(6)

                'If currentDate.Month = dia_DEL_sistema.Month Then
                '    If currentDate <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(6) Then
                '        currentDate = DateTime.Today
                '    End If
                'End If


            Case DayOfWeek.Monday
                'If currentDate.Month = dia_DEL_sistema.Month Then
                '    If currentDate.AddDays(-1) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(5) Then
                '        currentDate = DateTime.Today
                '    End If
                'End If
                currentDate = currentDate.AddDays(-1)
            Case DayOfWeek.Tuesday
                'If currentDate.Month = dia_DEL_sistema.Month Then
                '    If currentDate.AddDays(-2) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(4) Then
                '        currentDate = DateTime.Today
                '    End If
                'End If
                currentDate = currentDate.AddDays(-2)
            Case DayOfWeek.Wednesday
                'If currentDate.Month = dia_DEL_sistema.Month Then
                '    If currentDate.AddDays(-3) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(3) Then
                '        currentDate = DateTime.Today
                '    End If
                'End If
                currentDate = currentDate.AddDays(-3)
            Case DayOfWeek.Thursday
                'If currentDate.Month = dia_DEL_sistema.Month Then
                '    If currentDate.AddDays(-4) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(2) Then
                '        currentDate = DateTime.Today
                '    End If
                'End If
                currentDate = currentDate.AddDays(-4)
            Case DayOfWeek.Friday
                'If currentDate.Month = dia_DEL_sistema.Month Then
                '    If currentDate.AddDays(-5) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(1) Then
                '        currentDate = DateTime.Today
                '    End If
                'End If
                currentDate = currentDate.AddDays(-5)
            Case DayOfWeek.Saturday
                'If currentDate.Month = dia_DEL_sistema.Month Then
                '    If currentDate.AddDays(-6) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate Then
                '        currentDate = DateTime.Today
                '    End If
                'End If
                currentDate = currentDate.AddDays(-6)
        End Select

        limpiar_nro_dias()

        DisplayCurrentDate()


    End Sub

    Private Sub btnNextMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextMonth.Click
        dia_domingo_nro.ForeColor = Color.Black
        dia_lunes_nro.ForeColor = Color.Black
        dia_martes_nro.ForeColor = Color.Black
        dia_miercoles_nro.ForeColor = Color.Black
        dia_jueves_numero.ForeColor = Color.Black
        dia_viernes_nro.ForeColor = Color.Black
        dia_sabado_nro.ForeColor = Color.Black
        NextMonth()
        'recupero las citas para el mes y de ahi ciclo y solo muestro los de la semana.
        cargar_citas() 'lleno el datatable con el mes completo
        cargar_gridview() 'solo la semana
        rellenar_gridview() 'agrego filas en blanco

    End Sub
    Private Sub NextMonth()
        Dim fecha_calculada As DateTime

        Select Case currentDate.DayOfWeek
            Case DayOfWeek.Sunday  'es domingo
                fecha_calculada = currentDate.AddDays(7)
            Case DayOfWeek.Monday  'es lunes
                fecha_calculada = currentDate.AddDays(6)
            Case DayOfWeek.Tuesday   'es martes
                fecha_calculada = currentDate.AddDays(5)

            Case DayOfWeek.Wednesday    'es miercoles
                fecha_calculada = currentDate.AddDays(4)
            Case DayOfWeek.Thursday     'es jueves
                fecha_calculada = currentDate.AddDays(3)
            Case DayOfWeek.Friday      'es viernes
                fecha_calculada = currentDate.AddDays(2)

            Case DayOfWeek.Saturday       'es sabado
                fecha_calculada = currentDate.AddDays(1)
        End Select
        'If nuevo_mes = "si" And fecha_calculada.Month <> currentDate.Month Then
        '    currentDate = currentDate.AddMonths(1)
        '    currentDate = New Date(currentDate.Year, currentDate.Month, 1)
        '    nuevo_mes = ""
        'Else
        '    currentDate = fecha_calculada
        'End If


        'currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()

        '////////////////////////////////////////////////////////
        Dim dia_DEL_sistema As DateTime = Today
        Dim rango_a As DateTime
        Dim rango_b As DateTime
        Select Case currentDate.DayOfWeek
            Case DayOfWeek.Sunday
                rango_a = currentDate
                rango_b = currentDate.AddDays(6)
                'If currentDate <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(6) Then
                '    currentDate = DateTime.Today
                'End If

                currentDate = currentDate.AddDays(7)

            Case DayOfWeek.Monday
                'If currentDate.AddDays(-1) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(5) Then
                '    currentDate = DateTime.Today
                'End If

                currentDate = currentDate.AddDays(6)
            Case DayOfWeek.Tuesday
                'If currentDate.AddDays(-2) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(4) Then
                '    currentDate = DateTime.Today
                'End If
                currentDate = currentDate.AddDays(5)
            Case DayOfWeek.Wednesday
                'If currentDate.AddDays(-3) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(3) Then
                '    currentDate = DateTime.Today
                'End If
                currentDate = currentDate.AddDays(4)
            Case DayOfWeek.Thursday
                'If currentDate.AddDays(-4) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(2) Then
                '    currentDate = DateTime.Today
                'End If
                currentDate = currentDate.AddDays(3)
            Case DayOfWeek.Friday
                'If currentDate.AddDays(-5) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(1) Then
                '    currentDate = DateTime.Today
                'End If
                currentDate = currentDate.AddDays(2)
            Case DayOfWeek.Saturday
                'If currentDate.AddDays(-6) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate Then
                '    currentDate = DateTime.Today
                'End If
                currentDate = currentDate.AddDays(1)
        End Select

        limpiar_nro_dias()
        DisplayCurrentDate()


    End Sub



    Private Sub cargar_citas()
        Dim startDate As DateTime = New Date(currentDate.Year, 1, 1)
        Dim fecha_inicio As DateTime = New Date(currentDate.Year, currentDate.Month, 1)

        Dim endDate As DateTime = startDate.AddMonths(12).AddDays(-1)
        Dim fecha_final As DateTime = startDate.AddMonths(1).AddDays(-1)

        'STARTDATE ES EL PRIMER DIA DEL MES
        'ENDDATE ES EL ULTIMO DIA DEL MES
        'CON ESTE INTERVALO TENGO QUE VALIDAR LOS MANTENIMIENTOS INICIALES.
        Dim daMantenimiento As New Datos.Mantenimiento
        'Dim ds_info As DataSet = daMantenimiento.Mantenimiento_iniciales_obtener(sucursal_id) 'usaba para probar el id 19
        Dim ds_info As DataSet = daMantenimiento.Mantenimiento_iniciales_obtener_todo
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows.Clear()
        '**********************************************************************************************************************************
        If ds_info.Tables(0).Rows.Count <> 0 Then
            Dim ii As Integer = 0
            While ii < ds_info.Tables(0).Rows.Count
                'valido q la fecha del mant inicial esta dentro del intervalo.
                Dim fecha As Date = ds_info.Tables(0).Rows(ii).Item("Mantenimiento_fecha_inicio")
                If (startDate.ToShortDateString <= fecha) And (fecha <= endDate.ToShortDateString) Then
                    'lo agrego
                    Dim fila As DataRow = Mantenimiento_ds.Tables("MANTENIMIENTOS1").NewRow
                    fila("ID") = ds_info.Tables(0).Rows(ii).Item("Mantenimiento_id")
                    Dim Mantenimiento_id As Integer = ds_info.Tables(0).Rows(ii).Item("Mantenimiento_id")
                    fila("DESCRIPCION") = ds_info.Tables(0).Rows(ii).Item("etiqueta")
                    fila("FECHA") = ds_info.Tables(0).Rows(ii).Item("Mantenimiento_fecha_inicio")
                    fila("Equipo_id") = ds_info.Tables(0).Rows(ii).Item("Equipo_id")
                    fila("TIPO_OP") = "mantenimiento inicial"
                    Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows.Add(fila)
                End If
                'aqui veo cuantas veces lo voy a agregar, dependiendo el campo "DIA" y siempre y cuando este dentro del rango de fechas indicado.
                '********************************************************************
                Dim dias As Integer = ds_info.Tables(0).Rows(ii).Item("Mant_periodicidad_dias")
                Dim valido As String = "si"
                If dias <> 0 Then
                    While valido = "si"


                        If fecha <= endDate.ToShortDateString Then
                            'aplico el calculo de los dias
                            fecha = fecha.AddDays(dias)
                            'si la fecha cuando le agrego los dias cae un sabado o domingo lo paso para el siguiente dia laboral.
                            '//////////////////comente el 01-11-2021---choco/////////////////////////////////////////////////
                            If (fecha.DayOfWeek = DayOfWeek.Saturday) Then
                                If fecha.AddDays(2) <= endDate.ToShortDateString Then
                                    fecha = fecha.AddDays(2) 'sabado le sumo 2 'le sumo 2 si y solo si es el fin de semana previo a la fecha q se selecciono en el calendario
                                Else
                                    'si es mayor a la fecha limite, entonces no lo agrego
                                    'Exit While
                                End If
                            Else
                                If fecha.DayOfWeek = DayOfWeek.Sunday Then
                                    If fecha.AddDays(1) <= endDate.ToShortDateString Then
                                        fecha = fecha.AddDays(1) 'domingo le sumo 1, sumo 1 si y solo si es el fin de semana previ a la fecha q se selecciono en el calendario
                                    Else
                                        'Exit While 'no lo agrego
                                    End If
                                End If
                            End If
                            '//////////////////comente el 01-11-2021---choco//////////////////////fin///////////////////////////
                            'ahora: si la fecha calculada esta dentro del mes actua, lo agrego. sino sigo ciclando
                            If (startDate.ToShortDateString <= fecha) And (fecha <= endDate.ToShortDateString) Then
                                Dim fila As DataRow = Mantenimiento_ds.Tables("MANTENIMIENTOS1").NewRow
                                'fila("ID") = 0
                                fila("ID") = ds_info.Tables(0).Rows(ii).Item("Mantenimiento_id")
                                fila("DESCRIPCION") = ds_info.Tables(0).Rows(ii).Item("etiqueta")
                                fila("FECHA") = fecha.Date
                                fila("Equipo_id") = ds_info.Tables(0).Rows(ii).Item("Equipo_id")
                                fila("TIPO_OP") = "mantenimientos programados"
                                Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows.Add(fila)
                            End If
                        Else
                            Exit While 'si es mayor no lo agrego al dataset Calendario_mant_DS.Tables("MANTENIMIENTOS")
                        End If
                    End While
                    '********************************************************************
                End If

                '****************prueba choco, agrego todos los mantenimientos programados




                ii = ii + 1
            End While
        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        'aqui cargo los mantenimientos ya realizados, esos que no se pueden eliminar.
        If ds_info.Tables(1).Rows.Count <> 0 Then
            Dim jj As Integer = 0
            While jj < ds_info.Tables(1).Rows.Count
                'valido q la fecha del mant inicial esta dentro del intervalo.
                Dim fecha As Date = ds_info.Tables(1).Rows(jj).Item("Mant_realizados_fecha")
                If (startDate.ToShortDateString <= fecha) And (fecha <= endDate.ToShortDateString) Then
                    'lo agrego si y solo si no esta ya en mantenimiento_ds.Tables("MANTENIMIENTOS")
                    Dim ee As Integer = 0
                    Dim esta_en_bd As String = "no"
                    While ee < Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows.Count
                        Dim mantenimiento_id As Integer = ds_info.Tables(1).Rows(jj).Item("Mantenimiento_id")
                        Dim Equipo_id As Integer = ds_info.Tables(1).Rows(jj).Item("Equipo_id")
                        If (Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(ee).Item("FECHA") = ds_info.Tables(1).Rows(jj).Item("Mant_realizados_fecha")) And (Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(ee).Item("Equipo_id") = Equipo_id) And (Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(ee).Item("ID") = ds_info.Tables(1).Rows(jj).Item("Mantenimiento_id")) Then
                            esta_en_bd = "si"
                            Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(ee).Item("TIPO_OP") = "mantenimiento realizado"
                            Exit While 'tengo q romper el ciclo, x que si agrego una fila recien agregado no se llega nunca terminar el while.
                        End If
                        ee = ee + 1
                    End While
                    If esta_en_bd = "no" Then
                        'lo agrego
                        Dim fila As DataRow = Mantenimiento_ds.Tables("MANTENIMIENTOS1").NewRow
                        fila("ID") = ds_info.Tables(1).Rows(jj).Item("Mantenimiento_id")
                        fila("DESCRIPCION") = ds_info.Tables(1).Rows(jj).Item("etiqueta")
                        fila("FECHA") = ds_info.Tables(1).Rows(jj).Item("Mant_realizados_fecha")
                        fila("Equipo_id") = ds_info.Tables(1).Rows(jj).Item("Equipo_id")
                        fila("TIPO_OP") = "mantenimiento realizado"
                        'Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(ee).Item("TIPO_OP") = "mantenimiento realizado"
                        Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows.Add(fila)
                    End If
                End If
                jj = jj + 1
            End While
        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        'ahora agrego lo de servicios, es decir lo que mostraba en un principio en el calendario viejo.

        Dim dt_choco As DataSet = Daservicio.Servicio_calendario_consulta_todo(startDate.ToShortDateString, endDate.ToShortDateString)

        If dt_choco.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < dt_choco.Tables(0).Rows.Count
                Dim fila As DataRow = Mantenimiento_ds.Tables("MANTENIMIENTOS1").NewRow
                fila("ID") = dt_choco.Tables(0).Rows(i).Item("Servicio_id")
                If dt_choco.Tables(0).Rows(i).Item("Servicio_Estado") = "PENDIENTE" Then
                    fila("DESCRIPCION") = "Rev: " + CStr(dt_choco.Tables(0).Rows(i).Item("Servicio_id"))
                    fila("TIPO_OP") = "orden de revision"
                Else
                    fila("DESCRIPCION") = "OdT: " + CStr(dt_choco.Tables(0).Rows(i).Item("Orden_trabajo_id"))
                    fila("TIPO_OP") = "orden de trabajo"
                End If
                fila("FECHA") = dt_choco.Tables(0).Rows(i).Item("Servicio_fecha")
                fila("Equipo_id") = 0

                Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows.Add(fila)
                i = i + 1
            End While

        End If


    End Sub
    Dim Daservicio As New Datos.Servicio

    Private Sub cargar_gridview() 'solo cargo la semana
        Mantenimiento_ds.Tables("Calendario_b").Rows.Clear()
        Mantenimiento_ds.Tables("Calendario_b_detalle").Rows.Clear()
        If Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows.Count <> 0 Then
            'si el domingo esta en blanco, tengo que recuperar el primer dia del mes.
            Dim primer_dia_semana As Date
            If dia_domingo_nro.Text = "" Then
                primer_dia_semana = New Date(currentDate.Year, currentDate.Month, 1) 'primer dia del mes vigente
            Else
                primer_dia_semana = New Date(currentDate.Year, currentDate.Month, CInt(dia_domingo_nro.Text))
            End If

            Dim ultimo_dia_semana As Date

            ultimo_dia_semana = primer_dia_semana.AddDays(6)
            


            'If dia_sabado_nro.Text = "" Then
            '    Dim ultimo_dia As Integer = currentDate.AddDays(-1).Day
            '    ultimo_dia_semana = New Date(currentDate.Year, currentDate.Month, ultimo_dia) 'ultimo dia del mes vigente.
            'Else
            '    ultimo_dia_semana = New Date(currentDate.Year, currentDate.Month, CInt(dia_sabado_nro.Text))
            'End If

            Dim i As Integer = 0
            While i < Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows.Count
                Dim fecha As Date = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("FECHA")

                If (fecha >= primer_dia_semana) And (fecha <= ultimo_dia_semana) Then
                    ''lo agrego al datatable del gridview
                    'Dim fila As DataRow = Mantenimiento_ds.Tables("Calendario_b").NewRow
                    'Select Case fecha.DayOfWeek
                    '    Case DayOfWeek.Sunday  'es domingo
                    '        fila("domingo") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                    '    Case DayOfWeek.Monday  'es lunes
                    '        fila("lunes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                    '    Case DayOfWeek.Tuesday   'es martes
                    '        fila("martes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                    '    Case DayOfWeek.Wednesday    'es miercoles
                    '        fila("miercoles") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                    '    Case DayOfWeek.Thursday     'es jueves
                    '        fila("jueves") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                    '    Case DayOfWeek.Friday      'es viernes
                    '        fila("viernes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                    '    Case DayOfWeek.Saturday       'es sabado
                    '        fila("sabado") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                    'End Select
                    'Mantenimiento_ds.Tables("Calendario_b").Rows.Add(fila)

                    If Mantenimiento_ds.Tables("Calendario_b").Rows.Count = 0 Then
                        'como esta vacia la ingreso donde corresponda
                        Dim fila As DataRow = Mantenimiento_ds.Tables("Calendario_b").NewRow
                        fila("id_item") = Mantenimiento_ds.Tables("Calendario_b").Rows.Count
                        Select Case fecha.DayOfWeek
                            Case DayOfWeek.Sunday  'es domingo
                                fila("domingo") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                agregar_detalle(0, "domingo", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                            Case DayOfWeek.Monday  'es lunes
                                fila("lunes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                agregar_detalle(0, "lunes", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                            Case DayOfWeek.Tuesday   'es martes
                                fila("martes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                agregar_detalle(0, "martes", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                            Case DayOfWeek.Wednesday    'es miercoles
                                fila("miercoles") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                agregar_detalle(0, "miercoles", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                            Case DayOfWeek.Thursday     'es jueves
                                fila("jueves") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                agregar_detalle(0, "jueves", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                            Case DayOfWeek.Friday      'es viernes
                                fila("viernes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                agregar_detalle(0, "viernes", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                            Case DayOfWeek.Saturday       'es sabado
                                fila("sabado") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                agregar_detalle(0, "sabado", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                        End Select
                        Mantenimiento_ds.Tables("Calendario_b").Rows.Add(fila)
                    Else
                        Dim k As Integer = 0
                        Dim agregado As String = "no"
                        While k < Mantenimiento_ds.Tables("Calendario_b").Rows.Count
                            Select Case fecha.DayOfWeek
                                Case DayOfWeek.Sunday  'es domingo
                                    If Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("domingo").ToString = "" Then
                                        Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("domingo") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION") 'aqui va la etiqueta
                                        agregar_detalle(Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("id_item"), "domingo", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                                        agregado = "si"
                                        Exit While
                                    End If

                                Case DayOfWeek.Monday  'es lunes
                                    If Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("lunes").ToString = "" Then
                                        Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("lunes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION") 'aqui va la etiqueta
                                        agregar_detalle(Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("id_item"), "lunes", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                                        agregado = "si"
                                        Exit While
                                    End If
                                Case DayOfWeek.Tuesday   'es martes
                                    If Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("martes").ToString = "" Then
                                        Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("martes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION") 'aqui va la etiqueta
                                        agregar_detalle(Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("id_item"), "martes", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                                        agregado = "si"
                                        Exit While
                                    End If
                                Case DayOfWeek.Wednesday    'es miercoles
                                    If Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("miercoles").ToString = "" Then
                                        Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("miercoles") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION") 'aqui va la etiqueta
                                        agregar_detalle(Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("id_item"), "miercoles", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                                        agregado = "si"
                                        Exit While
                                    End If
                                Case DayOfWeek.Thursday     'es jueves
                                    If Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("jueves").ToString = "" Then
                                        Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("jueves") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION") 'aqui va la etiqueta
                                        agregar_detalle(Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("id_item"), "jueves", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                                        agregado = "si"
                                        Exit While
                                    End If
                                Case DayOfWeek.Friday      'es viernes
                                    If Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("viernes").ToString = "" Then
                                        Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("viernes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION") 'aqui va la etiqueta
                                        agregar_detalle(Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("id_item"), "viernes", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                                        agregado = "si"
                                        Exit While
                                    End If
                                Case DayOfWeek.Saturday       'es sabado
                                    If Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("sabado").ToString = "" Then
                                        Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("sabado") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION") 'aqui va la etiqueta
                                        agregar_detalle(Mantenimiento_ds.Tables("Calendario_b").Rows(k).Item("id_item"), "sabado", Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                                        agregado = "si"
                                        Exit While
                                    End If
                            End Select

                            k = k + 1
                        End While
                        If agregado = "no" Then
                            'lo agrego al final
                            Dim fila As DataRow = Mantenimiento_ds.Tables("Calendario_b").NewRow
                            fila("id_item") = Mantenimiento_ds.Tables("Calendario_b").Rows.Count
                            Dim dia As String = ""
                            Select Case fecha.DayOfWeek
                                Case DayOfWeek.Sunday  'es domingo
                                    fila("domingo") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                    dia = "domingo"
                                Case DayOfWeek.Monday  'es lunes
                                    fila("lunes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                    dia = "lunes"
                                Case DayOfWeek.Tuesday   'es martes
                                    fila("martes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                    dia = "martes"
                                Case DayOfWeek.Wednesday    'es miercoles
                                    fila("miercoles") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                    dia = "miercoles"
                                Case DayOfWeek.Thursday     'es jueves
                                    fila("jueves") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                    dia = "jueves"
                                Case DayOfWeek.Friday      'es viernes
                                    fila("viernes") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                    dia = "viernes"
                                Case DayOfWeek.Saturday       'es sabado
                                    fila("sabado") = Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("DESCRIPCION")
                                    dia = "sabado"
                            End Select
                            Mantenimiento_ds.Tables("Calendario_b").Rows.Add(fila)
                            agregar_detalle(Mantenimiento_ds.Tables("Calendario_b").Rows.Count - 1, dia, Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("TIPO_OP"), Mantenimiento_ds.Tables("MANTENIMIENTOS1").Rows(i).Item("ID"), fecha)
                        End If
                    End If
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub agregar_detalle(ByVal id_item As String, ByVal dia As String, ByVal tipo_op As String, ByVal id_tabla As String, ByVal fecha As Date)
        Dim fila_det As DataRow = Mantenimiento_ds.Tables("Calendario_b_detalle").NewRow
        fila_det("id_item") = id_item
        fila_det("DIA") = dia
        fila_det("TIPO_OP") = tipo_op
        fila_det("id_tabla") = id_tabla
        fila_det("fecha") = fecha
        Mantenimiento_ds.Tables("Calendario_b_detalle").Rows.Add(fila_det)
    End Sub


    Private Sub DG_clientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_clientes.CellClick
        Try
            If DG_clientes.CurrentCell.Value <> "" Then
                'lo busco en el table mantenimiento_ds.tables("Calendario_b_detalle")
                Dim id_item As String = DG_clientes.CurrentRow.Cells("id_item").Value
                Dim indice_columna As Integer = e.ColumnIndex

                Dim DIA As String = ""
                Select Case e.ColumnIndex
                    Case 0
                        DIA = "domingo"
                    Case 1
                        DIA = "lunes"
                    Case 2
                        DIA = "martes"
                    Case 3
                        DIA = "miercoles"
                    Case 4
                        DIA = "jueves"
                    Case 5
                        DIA = "viernes"
                    Case 6
                        DIA = "sabado"
                End Select

                'lo busco 
                Dim i As Integer = 0
                While i < Mantenimiento_ds.Tables("Calendario_b_detalle").Rows.Count
                    If (id_item = Mantenimiento_ds.Tables("Calendario_b_detalle").Rows(i).Item("id_item")) And (DIA = Mantenimiento_ds.Tables("Calendario_b_detalle").Rows(i).Item("DIA")) Then
                        Dim TIPO_OP As String = Mantenimiento_ds.Tables("Calendario_b_detalle").Rows(i).Item("TIPO_OP").ToString
                        If TIPO_OP = "orden de revision" Then
                            Dim serv_id As Integer = Mantenimiento_ds.Tables("Calendario_b_detalle").Rows(i).Item("id_tabla")
                            Orden_Revision_nueva.Close()
                            Orden_Revision_nueva.appID = serv_id
                            Orden_Revision_nueva.Show()
                        Else
                            If TIPO_OP = "orden de trabajo" Then
                                Dim serv_id As Integer = Mantenimiento_ds.Tables("Calendario_b_detalle").Rows(i).Item("id_tabla")
                                'con el serv_id recupero el cliente_id 
                                Dim ds_info As DataSet = Daservicio.Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(serv_id)
                                Dim cliente_id As Integer = 0
                                If ds_info.Tables(0).Rows.Count <> 0 Then
                                    cliente_id = CInt(ds_info.Tables(0).Rows(0).Item("CLI_id"))
                                End If
                                Servicio_nuevo.Close()
                                Servicio_nuevo.Cliente_ID = cliente_id
                                Servicio_nuevo.serv_id = serv_id
                                Servicio_nuevo.Show()

                            Else
                                'ES MANTENIMIENTO PROGRAMADO
                                Mante_consulta.Close()
                                Dim mantenimiento_id As Integer = Mantenimiento_ds.Tables("Calendario_b_detalle").Rows(i).Item("id_tabla")
                                Mante_consulta.procedencia = "calendario_b"
                                Mante_consulta.mantenimiento_id = mantenimiento_id
                                Mante_consulta.fecha.Text = Mantenimiento_ds.Tables("Calendario_b_detalle").Rows(i).Item("fecha")
                                Mante_consulta.Show()
                            End If

                        End If


                        Exit While
                    End If
                    i = i + 1
                End While

                'MessageBox.Show("hoy es:" + DIA)


            Else
                MessageBox.Show("no hay nada")

            End If
        Catch ex As Exception

        End Try
        
    End Sub
End Class