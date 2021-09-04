Public Class Calendario_Mantenimiento
    Private Sub calc_() 'esto es de mariano supongo
        Dim fecha As Date = Now

        Dim dias_Sumar As Integer = 30

        Dim fechaResul = DateAdd("d", dias_Sumar, fecha)

        ' WEEKDAY--> si el valor es 7 sabado y si es 1 es domingo

        If Weekday(fechaResul) = 7 Then
            fechaResul = DateAdd("d", 2, fecha)
        End If

        If Weekday(fechaResul) = 1 Then
            fechaResul = DateAdd("d", 1, fecha)
        End If


    End Sub
    Dim Daservicio As New Datos.Servicio
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Dim DAventa As New Datos.Venta
    Public sucursal_id As Integer

    Private Sub Calendario_Mantenimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''primero me fijo en que sucursal estoy
        'Dim usuario_id As Integer = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        'Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        'sucursal_id = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
        'Me.Text = "Calendario de Servicios - Sucursal: " + CStr(ds_usuario.Tables(0).Rows(0).Item("sucursal_nombre"))
        Me.Text = "Calendario de Mantenimientos."
        GenerateDayPanel(42)
        DisplayCurrentDate()
       
    End Sub

    '1) genero el panel con los dias
    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            'fl.Name = $"flDay{i}"
            'fl.Name = "choco"
            If i = 1 Then
                fl.BackColor = Color.Red
            Else
                fl.BackColor = Color.White
            End If
            fl.Size = New Size(128, 99)
            'fl.Size = New Size(50, 50)

            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            'AddHandler fl.Click, AddressOf AddNewAppointment 'choco 16-12-2020 con esto activo el evento click. 
            AddHandler fl.Click, AddressOf click_izquierdo 'choco 
            AddHandler fl.MouseMove, AddressOf click_derecho
            AddHandler fl.MouseHover, AddressOf pasar_por_sobre_el_panel
            flDays.ContextMenuStrip = ContextMenuStrip1 'agrego menu contextual con 2 item "Nuevo" y "Ver"
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub






    Public choco_day As Integer
    Private Sub click_derecho(ByVal sender As Object, ByVal e As System.EventArgs)
        choco_day = CType(sender, FlowLayoutPanel).Tag
        If choco_day <> 0 Then

        End If
    End Sub

    Private Sub click_izquierdo(ByVal sender As Object, ByVal e As System.EventArgs)
        choco_day = CType(sender, FlowLayoutPanel).Tag

        If choco_day <> 0 Then
            Dim fecha As Date = New Date(currentDate.Year, currentDate.Month, choco_day)
            Mante_consulta.Close()
            Mante_consulta.fecha.Text = fecha
            Mante_consulta.SucxClie_id = sucursal_id
            Mante_consulta.Show()
        End If

    End Sub


    'pasar_por_sobre_el_panel
    Private Sub pasar_por_sobre_el_panel(ByVal sender As Object, ByVal e As System.EventArgs)
        choco_day = CType(sender, FlowLayoutPanel).Tag

        'choco lo que hace esto es que cuando pase x arriba de cada panel, recupere el nro de panel, que vendria a ser el DIA.
        'lo necesito porque cuando se dispare el evento link_click_izquierdo. necesito un valor distinto a 0 en la variable choco_day

        'If choco_day <> 0 Then
        '    Dim fecha As Date = New Date(currentDate.Year, currentDate.Month, choco_day)
        '    Mante_consulta.Close()
        '    Mante_consulta.fecha.Text = fecha
        '    Mante_consulta.SucxClie_id = sucursal_id
        '    Mante_consulta.Show()
        'End If

    End Sub

    Private Sub link_click_izquierdo(ByVal sender As Object, ByVal e As System.EventArgs) 'esto es para que cuando haga click sobre las citas se direccione al formulario que quiero
        'choco_day = CType(sender, FlowLayoutPanel).Tag

        If choco_day <> 0 Then
            Dim fecha As Date = New Date(currentDate.Year, currentDate.Month, choco_day)
            Mante_consulta.Close()
            Mante_consulta.fecha.Text = fecha
            Mante_consulta.SucxClie_id = sucursal_id
            Mante_consulta.Show()
        End If

    End Sub


    Private Sub AddNewAppointment(ByVal sender As Object, ByVal e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea generar una nueva orden de Revisión?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                'Orden_Revision_nueva.Close()
                'Orden_Revision_nueva.DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, day)
                'Orden_Revision_nueva.Show()

                With Orden_Revision_nueva
                    .appID = 0
                    .DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, day)
                    .ShowDialog()
                End With


                'With frmManageAppointment
                '    .AppID = 0
                '    .txtName.Text = ""
                '    .txtAddress.Text = ""
                '    .txtComment.Text = ""
                '    .dtpDate.Value = New Date(currentDate.Year, currentDate.Month, day)
                '    .ShowDialog()
                'End With
                'DisplayCurrentDate()
            End If

            DisplayCurrentDate()


        End If
    End Sub

    Private Sub ShowAppointmentDetail(ByVal sender As Object, ByVal e As EventArgs)
        Dim appID As Integer = CType(sender, LinkLabel).Tag
        Dim estado As String = CType(sender, LinkLabel).Name
        'Dim sql As String = $"select * from appointment where ID = {appID}"
        'Dim dt As DataTable = QueryAsDataTable(Sql)
        'If dt.Rows.Count > 0 Then
        '    Dim row As DataRow = dt.Rows(0)
        '    With frmManageAppointment
        '        .AppID = appID
        '        .txtName.Text = row("ContactName")
        '        .txtAddress.Text = row("Address")
        '        .txtComment.Text = row("Comment")
        '        .dtpDate.Value = row("AppDate")
        '        .ShowDialog()
        '    End With
        '    DisplayCurrentDate()
        'End If


        'Orden_Revision_nueva.Close()
        'Orden_Revision_nueva.appID = appID
        'Orden_Revision_nueva.Show()
        If estado = "PENDIENTE" Then
            With Orden_Revision_nueva
                .appID = appID
                '        .txtName.Text = row("ContactName")
                '        .txtAddress.Text = row("Address")
                '        .txtComment.Text = row("Comment")
                '        .dtpDate.Value = row("AppDate")
                .ShowDialog()
            End With
            DisplayCurrentDate()
        Else
            'como es una orden, independientemente del estado vamos a abrir el form
            With Servicio_nuevo
                .serv_id = appID
                '        .txtName.Text = row("ContactName")
                '        .txtAddress.Text = row("Address")
                '        .txtComment.Text = row("Comment")
                '        .dtpDate.Value = row("AppDate")
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If


        'Orden_Revision_nueva.Focus()
    End Sub

    Dim mantenimiento_ds As New mantenimiento_ds
    'agrega los mantenimientos en los paneles de los dias.
    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        'Dim sql As String = $"select * from appointment where AppDate between #{startDate.ToShortDateString()}# and #{endDate.ToShortDateString()}#"

        'Dim dt_choco As DataSet = Daservicio.Servicio_calendario_consulta(startDate.ToShortDateString, endDate.ToShortDateString, sucursal_id)

        'STARTDATE ES EL PRIMER DIA DEL MES
        'ENDDATE ES EL ULTIMO DIA DEL MES
        'CON ESTE INTERVALO TENGO QUE VALIDAR LOS MANTENIMIENTOS INICIALES.
        Dim daMantenimiento As New Datos.Mantenimiento
        'Dim ds_info As DataSet = daMantenimiento.Mantenimiento_iniciales_obtener(sucursal_id) 'usaba para probar el id 19
        Dim ds_info As DataSet = daMantenimiento.Mantenimiento_iniciales_obtener_todo
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        mantenimiento_ds.Tables("MANTENIMIENTOS").Rows.Clear()

        '**********************************************************************************************************************************
        If ds_info.Tables(0).Rows.Count <> 0 Then
            Dim ii As Integer = 0

            While ii < ds_info.Tables(0).Rows.Count
                'valido q la fecha del mant inicial esta dentro del intervalo.
                Dim fecha As Date = ds_info.Tables(0).Rows(ii).Item("Mantenimiento_fecha_inicio")
                If (startDate.ToShortDateString <= fecha) And (fecha <= endDate.ToShortDateString) Then
                    'lo agrego
                    Dim fila As DataRow = mantenimiento_ds.Tables("MANTENIMIENTOS").NewRow
                    fila("ID") = ds_info.Tables(0).Rows(ii).Item("Mantenimiento_id")
                    fila("DESCRIPCION") = ds_info.Tables(0).Rows(ii).Item("etiqueta")
                    fila("FECHA") = ds_info.Tables(0).Rows(ii).Item("Mantenimiento_fecha_inicio")
                    fila("Equipo_id") = ds_info.Tables(0).Rows(ii).Item("Equipo_id")
                    mantenimiento_ds.Tables("MANTENIMIENTOS").Rows.Add(fila)
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
                            If (fecha.DayOfWeek = DayOfWeek.Saturday) Then
                                If fecha.AddDays(2) <= endDate.ToShortDateString Then
                                    fecha = fecha.AddDays(2) 'sabado le sumo 2 'le sumo 2 si y solo si es el fin de semana previo a la fecha q se selecciono en el calendario
                                Else
                                    'si es mayor a la fecha limite, entonces no lo agrego
                                    Exit While
                                End If
                            Else
                                If fecha.DayOfWeek = DayOfWeek.Sunday Then
                                    If fecha.AddDays(1) <= endDate.ToShortDateString Then
                                        fecha = fecha.AddDays(1) 'domingo le sumo 1, sumo 1 si y solo si es el fin de semana previ a la fecha q se selecciono en el calendario
                                    Else
                                        Exit While 'no lo agrego
                                    End If
                                End If
                            End If

                            'ahora: si la fecha calculada esta dentro del mes actua, lo agrego. sino sigo ciclando
                            If (startDate.ToShortDateString <= fecha) And (fecha <= endDate.ToShortDateString) Then
                                Dim fila As DataRow = mantenimiento_ds.Tables("MANTENIMIENTOS").NewRow
                                fila("ID") = 0
                                fila("DESCRIPCION") = ds_info.Tables(0).Rows(ii).Item("etiqueta")
                                fila("FECHA") = fecha.Date
                                fila("Equipo_id") = ds_info.Tables(0).Rows(ii).Item("Equipo_id")
                                mantenimiento_ds.Tables("MANTENIMIENTOS").Rows.Add(fila)
                            End If
                        Else
                            Exit While 'si es mayor no lo agrego al dataset Calendario_mant_DS.Tables("MANTENIMIENTOS")
                        End If
                    End While
                    '********************************************************************
                End If
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
                    While ee < mantenimiento_ds.Tables("MANTENIMIENTOS").Rows.Count
                        Dim mantenimiento_id As Integer = ds_info.Tables(1).Rows(jj).Item("Mantenimiento_id")
                        Dim Equipo_id As Integer = ds_info.Tables(1).Rows(jj).Item("Equipo_id")
                        If (mantenimiento_ds.Tables("MANTENIMIENTOS").Rows(ee).Item("FECHA") = ds_info.Tables(1).Rows(jj).Item("Mant_realizados_fecha")) And (mantenimiento_ds.Tables("MANTENIMIENTOS").Rows(ee).Item("Equipo_id") = Equipo_id) Then
                            esta_en_bd = "si"
                            Exit While 'tengo q romper el ciclo, x que si agrego una fila recien agregado no se llega nunca terminar el while.
                        End If
                        ee = ee + 1
                    End While
                    If esta_en_bd = "no" Then
                        'lo agrego
                        Dim fila As DataRow = mantenimiento_ds.Tables("MANTENIMIENTOS").NewRow
                        fila("ID") = ds_info.Tables(1).Rows(jj).Item("Mantenimiento_id")
                        fila("DESCRIPCION") = ds_info.Tables(1).Rows(jj).Item("etiqueta")
                        fila("FECHA") = ds_info.Tables(1).Rows(jj).Item("Mant_realizados_fecha")
                        fila("Equipo_id") = ds_info.Tables(1).Rows(jj).Item("Equipo_id")
                        mantenimiento_ds.Tables("MANTENIMIENTOS").Rows.Add(fila)
                    End If
                End If
                jj = jj + 1
            End While
        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Dim dt As DataTable = mantenimiento_ds.Tables("MANTENIMIENTOS")
        Dim i As Integer = 0
        For Each row As DataRow In dt.Rows
            'Dim appDay As DateTime = DateTime.Parse(row("AppDate"))
            Dim appDay As DateTime = DateTime.Parse(row("FECHA"))
            Dim link As New LinkLabel
            'Dim link As New Label
            'link.Tag = row("ID")
            link.Tag = row("ID")
            'link.Name = $"link{row("ID")}"
            'link.Name = row("Servicio_Diagnostico")
            Dim name As String = CStr(i) + "-" + row("DESCRIPCION")
            link.Name = name
            'link.Text = row("ContactName")

            'link.Text = CStr(row("DESCRIPCION")) + " " + CStr(row("FECHA"))
            link.Text = CStr(row("DESCRIPCION"))
            link.LinkColor = Color.Orange

            'link.ForeColor = Color.Orange
            'Dim myfont As New Font(link.Font.FontFamily, 8)
            'link.Font = myfont

            'link.Visible = False 'choco 23-07-2021 no quiero q se vean. no se para q los agrego.

            'If CStr(row("Servicio_Estado")) = "PENDIENTE" Then
            '    link.Text = "Rev: " + CStr(row("Servicio_id"))
            '    link.LinkColor = Color.Orange
            'Else
            '    Select Case (CStr(row("Servicio_Estado")))
            '        Case "ASIGNADO"
            '            link.Text = "OdT: " + CStr(row("Orden_trabajo_id"))
            '            link.LinkColor = Color.Blue
            '        Case "REPARADO"
            '            link.Text = "OdT: " + CStr(row("Orden_trabajo_id"))
            '            link.LinkColor = Color.Black
            '        Case "FINALIZADO"
            '            link.Text = "OdT: " + CStr(row("Orden_trabajo_id"))
            '            link.LinkColor = Color.Green
            '    End Select
            'End If

            'AddHandler link.Click, AddressOf ShowAppointmentDetail 'este ya no uso, no quiero hacer clic en los item q me muestra el gridview
            AddHandler link.Click, AddressOf link_click_izquierdo

            'listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link) 'esta linea es para q se vean los link label con la etiqueta de cada item

            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).BackColor = Color.AliceBlue     'choco 23-07-2021 quiero que los dias q tienen citas se remarquen en verde
            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).BackgroundImage = My.Resources.GuardarChico
            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).BackgroundImageLayout = ImageLayout.Center
            i = i + 1
            'If dt.Rows.Count > 2 And i = 2 Then
            '    'si hay mas de 2 entonces agrego un item mas de esos "link" que diga "ver ..."
            '    Dim link2 As New LinkLabel
            '    link2.Text = "Ver mas..."
            '    link2.LinkColor = Color.Black
            '    listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link2)
            '    Exit For
            'End If
        Next
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        'Dim firstDayAtFlNumber As Integer = 1
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub


    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    


    'crea los paneles de los dias del calendario.
    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.WhiteSmoke
            'fl.HorizontalScroll.Enabled = True
            'fl.VerticalScroll.Enabled = True
            'fl.AutoScroll = True
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            'lbl.Name = $"lblDay{i}"
            'lbl.Name = "choco"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.NavajoWhite 'este es el color de el dia actual.
                'listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Blue

            End If

        Next
    End Sub




    Private Sub btnPrevMonth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevMonth.Click
        PrevMonth()
    End Sub

    Private Sub btnNextMonth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub

    Private Sub btnToday_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnToday.Click
        Today()
    End Sub

    'este uso con el menu contextua, es decir el que se abre cuando le doy boton derecho
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        'If choco_day <> 0 Then
        '    Dim result As DialogResult
        '    result = MessageBox.Show("¿Desea generar una nueva orden de Revisión?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        '    If result = DialogResult.OK Then
        '        'Orden_Revision_nueva.Close()
        '        'Orden_Revision_nueva.DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, day)
        '        'Orden_Revision_nueva.Show()

        '        With Orden_Revision_nueva
        '            .appID = 0
        '            .DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, choco_day)
        '            .ShowDialog()
        '        End With


        '        'With frmManageAppointment
        '        '    .AppID = 0
        '        '    .txtName.Text = ""
        '        '    .txtAddress.Text = ""
        '        '    .txtComment.Text = ""
        '        '    .dtpDate.Value = New Date(currentDate.Year, currentDate.Month, day)
        '        '    .ShowDialog()
        '        'End With
        '        'DisplayCurrentDate()
        '    End If

        '    DisplayCurrentDate()


        'End If
    End Sub

    Private Sub VerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If choco_day <> 0 Then
        '    Dim fecha As Date = New Date(currentDate.Year, currentDate.Month, choco_day)
        '    Mante_consulta.Close()
        '    Mante_consulta.fecha.Text = fecha
        '    Mante_consulta.SucxClie_id = 19
        '    Mante_consulta.Show()

        '    ''con la fecha del dia busco los servicios.
        '    'Dim dt_choco As DataSet = Daservicio.Servicio_calendario_consulta(New Date(currentDate.Year, currentDate.Month, choco_day), New Date(currentDate.Year, currentDate.Month, choco_day), sucursal_id)
        '    'If dt_choco.Tables(0).Rows.Count <> 0 Then
        '    '    'lo muestro en otro formulario, en un gridview bien detallado
        '    '    'MessageBox.Show("SE REGISTRARON:" + CStr(dt_choco.Tables(0).Rows.Count))
        '    '    Servicio_Consulta_b.Close()
        '    '    Servicio_Consulta_b.fecha = New Date(currentDate.Year, currentDate.Month, choco_day)
        '    '    Servicio_Consulta_b.Show()
        '    '    Me.Close()
        '    'Else
        '    '    'no hay citas registradas
        '    '    MessageBox.Show("No hay citas registradas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    'End If
        'End If
    End Sub

    Private Sub NuevaOrdenTrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        'If choco_day <> 0 Then
        '    Dim result As DialogResult
        '    result = MessageBox.Show("¿Desea generar una nueva orden de Trabajo?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        '    If result = DialogResult.OK Then
        '        'Orden_Revision_nueva.Close()
        '        'Orden_Revision_nueva.DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, day)
        '        'Orden_Revision_nueva.Show()

        '        With Orden_trabajo_selec_cliente
        '            .appID = 0
        '            .DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, choco_day)
        '            .ShowDialog()
        '        End With


        '        'With frmManageAppointment
        '        '    .AppID = 0
        '        '    .txtName.Text = ""
        '        '    .txtAddress.Text = ""
        '        '    .txtComment.Text = ""
        '        '    .dtpDate.Value = New Date(currentDate.Year, currentDate.Month, day)
        '        '    .ShowDialog()
        '        'End With
        '        'DisplayCurrentDate()
        '    End If

        '    DisplayCurrentDate()

        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Calendario_seleccion_cliente.Show()
    End Sub
End Class