Public Class Calendario_b
    Private currentDate As DateTime = DateTime.Today



    Private Sub Calendario_b_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        limpiar_nro_dias()
        currentDate = CDate("31/08/2021")
        DisplayCurrentDate()
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
            If currentDate.Day + valor <= totaldiasenelmes Then
                dia.Text = currentDate.Day + valor

            Else
                'en una variable aviso que se termino el mes. asi el mes siguiente empieza bien el conteo.
                nuevo_mes = "si"
            End If
        End If
        If operacion = "restar" Then
            If currentDate.Day - valor <= totaldiasenelmes And ((currentDate.Day - valor) > 0) Then
                dia.Text = currentDate.Day - valor
            Else
                nuevo_mes = "si"
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
                validad_dias(dia_domingo_nro, totalDaysInMonth, 1, "restar")
                dia_lunes_nro.Text = currentDate.Day
                dia_lunes_nro.ForeColor = Color.Blue
                validad_dias(dia_martes_nro, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 2, "sumar")
                validad_dias(dia_jueves_numero, totalDaysInMonth, 3, "sumar")
                validad_dias(dia_viernes_nro, totalDaysInMonth, 4, "sumar")
                validad_dias(dia_sabado_nro, totalDaysInMonth, 5, "sumar")
            Case DayOfWeek.Tuesday   'es martes
                validad_dias(dia_domingo_nro, totalDaysInMonth, 2, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 1, "restar")
                dia_martes_nro.Text = currentDate.Day
                dia_martes_nro.ForeColor = Color.Blue
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_jueves_numero, totalDaysInMonth, 2, "sumar")
                validad_dias(dia_viernes_nro, totalDaysInMonth, 3, "sumar")
                validad_dias(dia_sabado_nro, totalDaysInMonth, 4, "sumar")
            Case DayOfWeek.Wednesday    'es miercoles
                validad_dias(dia_domingo_nro, totalDaysInMonth, 3, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 2, "restar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 1, "restar")
                dia_miercoles_nro.Text = currentDate.Day
                dia_miercoles_nro.ForeColor = Color.Blue
                validad_dias(dia_jueves_numero, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_viernes_nro, totalDaysInMonth, 2, "sumar")
                validad_dias(dia_sabado_nro, totalDaysInMonth, 3, "sumar")
            Case DayOfWeek.Thursday     'es jueves
                validad_dias(dia_domingo_nro, totalDaysInMonth, 4, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 3, "restar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 2, "restar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 1, "restar")
                dia_jueves_numero.Text = currentDate.Day
                dia_jueves_numero.ForeColor = Color.Blue
                validad_dias(dia_viernes_nro, totalDaysInMonth, 1, "sumar")
                validad_dias(dia_sabado_nro, totalDaysInMonth, 2, "sumar")
            Case DayOfWeek.Friday      'es viernes
                validad_dias(dia_domingo_nro, totalDaysInMonth, 5, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 4, "restar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 3, "restar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 2, "restar")
                validad_dias(dia_jueves_numero, totalDaysInMonth, 1, "restar")
                dia_viernes_nro.Text = currentDate.Day
                dia_viernes_nro.ForeColor = Color.Blue
                validad_dias(dia_sabado_nro, totalDaysInMonth, 1, "sumar")
            Case DayOfWeek.Saturday       'es sabado
                validad_dias(dia_domingo_nro, totalDaysInMonth, 6, "restar")
                validad_dias(dia_lunes_nro, totalDaysInMonth, 5, "restar")
                validad_dias(dia_martes_nro, totalDaysInMonth, 4, "restar")
                validad_dias(dia_miercoles_nro, totalDaysInMonth, 3, "restar")
                validad_dias(dia_jueves_numero, totalDaysInMonth, 2, "restar")
                validad_dias(dia_viernes_nro, totalDaysInMonth, 1, "restar")
                dia_sabado_nro.Text = currentDate.Day
                dia_sabado_nro.ForeColor = Color.Blue
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
            nuevo_mes = ""
        Else
            currentDate = fecha_calculada
        End If


        'currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()

        '////////////////////////////////////////////////////////
        Dim dia_DEL_sistema As DateTime = Today
        Dim rango_a As DateTime
        Dim rango_b As DateTime
        Select Case currentDate.DayOfWeek
            Case DayOfWeek.Sunday
                rango_a = currentDate
                rango_b = currentDate.AddDays(6)
                If currentDate <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(6) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Monday
                If currentDate.AddDays(-1) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(5) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Tuesday
                If currentDate.AddDays(-2) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(4) Then
                    currentDate = DateTime.Today
                End If

            Case DayOfWeek.Wednesday
                If currentDate.AddDays(-3) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(3) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Thursday
                If currentDate.AddDays(-4) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(2) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Friday
                If currentDate.AddDays(-5) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(1) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Saturday
                If currentDate.AddDays(-6) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate Then
                    currentDate = DateTime.Today
                End If
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
        If nuevo_mes = "si" And fecha_calculada.Month <> currentDate.Month Then
            currentDate = currentDate.AddMonths(1)
            currentDate = New Date(currentDate.Year, currentDate.Month, 1)
            nuevo_mes = ""
        Else
            currentDate = fecha_calculada
        End If


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
                If currentDate <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(6) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Monday
                If currentDate.AddDays(-1) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(5) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Tuesday
                If currentDate.AddDays(-2) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(4) Then
                    currentDate = DateTime.Today
                End If

            Case DayOfWeek.Wednesday
                If currentDate.AddDays(-3) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(3) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Thursday
                If currentDate.AddDays(-4) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(2) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Friday
                If currentDate.AddDays(-5) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate.AddDays(1) Then
                    currentDate = DateTime.Today
                End If
            Case DayOfWeek.Saturday
                If currentDate.AddDays(-6) <= dia_DEL_sistema And dia_DEL_sistema <= currentDate Then
                    currentDate = DateTime.Today
                End If
        End Select

        limpiar_nro_dias()
        DisplayCurrentDate()


    End Sub

End Class