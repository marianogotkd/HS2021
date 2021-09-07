Public Class Turno_alta

    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha
    Dim DAcliente As New Datos.Cliente
    Dim NEturno As New Turno


    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener

    Private Sub Turno_alta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NEturno.Turno_CrearTabla()

        DT_fecha.MinDate = Now
        NU_hora.TextAlign = HorizontalAlignment.Center
        NU_hora.Increment = 1
        NU_hora.Maximum = 23
        NU_hora.Minimum = 0
        NU_minuto.TextAlign = HorizontalAlignment.Center
        NU_minuto.Increment = 15
        NU_minuto.Maximum = 45
        NU_minuto.Minimum = 0
        NU_DUR_minuto.TextAlign = HorizontalAlignment.Center
        NU_DUR_minuto.Increment = 15
        NU_DUR_minuto.Maximum = 45
        NU_DUR_minuto.Minimum = 0
        NU_DUR_hora.TextAlign = HorizontalAlignment.Center
        NU_DUR_hora.Increment = 1
        NU_DUR_hora.Maximum = 10
        NU_DUR_hora.Minimum = 1

        GP_cancha.Enabled = False

        COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T.ValueMember = "CANCHA_T_id"
        Cancha_obtener()

        TX_ape.TextAlign = HorizontalAlignment.Center
        TX_doc.TextAlign = HorizontalAlignment.Center
        TX_doc.MaxLength = 8
        BO_doc.Enabled = False

        BO_guardar.Enabled = False
    End Sub

    Dim ds_CANCHA As DataSet
    Private Sub COM_CANCHA_T_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_T.SelectedIndexChanged
        Cancha_obtener()
        If GP_cancha.Enabled = True Then
            Turno_Buscar()
            GP_cancha.Enabled = True
            GP_duracion.Enabled = False
            GP_fecha.Enabled = False
        End If
    End Sub

    Private Sub COM_CANCHA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA.SelectedIndexChanged
        If GP_cancha.Enabled = True Then
            Turno_Buscar()
            GP_cancha.Enabled = True
            GP_duracion.Enabled = False
            GP_fecha.Enabled = False
        End If
    End Sub

    Public Sub Cancha_obtener()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString)
        COM_CANCHA.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA.DisplayMember = "CANCHA_nom"
        COM_CANCHA.ValueMember = "CANCHA_id"
    End Sub


    'Buscar Turno //////////////////////////////////////////////////////////////////////////////////////
    Private Sub BO_buscar_Click(sender As System.Object, e As System.EventArgs) Handles BO_buscar.Click
        Turno_Buscar()
        GP_duracion.Enabled = False
        GP_fecha.Enabled = False
        GP_cancha.Enabled = True
    End Sub

    Dim TURNO_CONF_desde As DateTime
    Dim TURNO_CONF_hasta As DateTime

    Public Sub Turno_Buscar()
        Turno_Limpiar()
        NEturno.Turno_LimpiarTabla()

        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(DT_fecha.Value, CANCHA_T_id)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde")
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta")

        'DG_Turno
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_Obtener(DT_fecha.Text, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString,
                                                                 TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then
            'Existen Turnos
            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_Turno.DataSource = ds_Turno.Tables(0)
            DG_Turno.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)


            'DG_Turno TurnoFijo de Color
            Dim B As Integer = 0
            For Each row As DataGridViewRow In DG_Turno.Rows
                Select Case (row.Cells("TURNOTDataGridViewTextBoxColumn").Value)
                    Case ("Normal")
                        DG_Turno.Rows(B).DefaultCellStyle.BackColor = Color.AliceBlue
                    Case ("Fijo")
                        DG_Turno.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                End Select
                B = B + 1
            Next
            DG_Turno.ClearSelection()

            'Turno Disponible
            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_Turno.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            NEturno.Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, NU_DUR_hora.Value, NU_DUR_minuto.Value)

            'Turno Medio
            While B < DG_Turno.Rows.Count

                Dim newCustomersRow As DataRow = Turno_ds.Tables("TurnoDisponible").NewRow()
                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Turno.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn").Value And
                       A.Item("TURNO_T") = DG_Turno.Rows(B - 1).Cells("TURNOTDataGridViewTextBoxColumn").Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Turno.Rows(B).Cells("TURNOidDataGridViewTextBoxColumn").Value And
                        A.Item("TURNO_T") = DG_Turno.Rows(B).Cells("TURNOTDataGridViewTextBoxColumn").Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                NEturno.Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, NU_DUR_hora.Value, NU_DUR_minuto.Value)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_Turno.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_Turno.Rows(ultimo).Cells("TURNOfinDataGridViewTextBoxColumn").Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            NEturno.Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, NU_DUR_hora.Value, NU_DUR_minuto.Value)      
        Else
            'No Existen Turnos
            Dim newCustomersRow As DataRow = Turno_ds.Tables("TurnoDisponible").NewRow()
            Dim DISP_desde As DateTime = Now.Date
            DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            Dim DISP_hasta As DateTime = Now.Date
            If TURNO_CONF_hasta < TURNO_CONF_desde Then
                DISP_hasta = DISP_hasta.AddDays(1)
            End If
            DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            NEturno.Turno_ConfTurnoDisponible(DISP_desde, DISP_hasta, NU_DUR_hora.Value, NU_DUR_minuto.Value)

        End If
        Dim Turnos As DataSet = NEturno.Turno_ObtenerTabla
        DG_TurnoDisponible.DataSource = Turnos.Tables("TurnoDisp")
    End Sub

    Public Sub Turno_Limpiar()
        DG_Turno.DataSource = Nothing
        DG_TurnoDisponible.DataSource = Nothing
        Turno_ds.Tables("TurnoDisponible").Clear()

        LB_turno.Text = ""
        LB_cancha.Text = ""
        NU_hora.Value = 0
        NU_minuto.Value = 0
    End Sub

    Private Sub DG_TurnoDisponible_SelectionChanged(sender As Object, e As EventArgs) Handles DG_TurnoDisponible.SelectionChanged
        If ((DG_TurnoDisponible.CurrentRow Is Nothing) OrElse (DG_TurnoDisponible.SelectedRows.Count <> 0)) And DG_TurnoDisponible.Rows.Count > 0 Then
            GP_Horario.Enabled = True
            Dim hora As String = DG_TurnoDisponible.SelectedRows(0).Cells("TURNO_desde").Value
            NU_hora.Value = (hora.Substring(0, 2))
            NU_minuto.Value = (hora.Substring(3, 2))
            Turno_validar()
        Else
            GP_Horario.Enabled = False
        End If
    End Sub


    'Turno Guardar /////////////////////////////////////////////////////////////////////////////////////

    Private Sub NU_hora_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_hora.ValueChanged
        Turno_validar()
    End Sub

    Private Sub NU_minuto_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_minuto.ValueChanged
        Turno_validar()
    End Sub

    Dim Turno_H As Integer = 0

    Public Sub Turno_validar()
        If GP_Horario.Enabled = True Then
            Dim Turno_desde As DateTime = DT_fecha.Value.Date

            If NU_hora.Value < TURNO_CONF_desde.Hour Then
                Turno_desde = Turno_desde.AddDays(1)
            End If
            Turno_desde = Turno_desde.AddHours(NU_hora.Value)
            Turno_desde = Turno_desde.AddMinutes(NU_minuto.Value)

            Dim Turno_hasta As DateTime = Turno_desde.AddHours(NU_DUR_hora.Value)
            Turno_hasta = Turno_hasta.AddMinutes(NU_DUR_minuto.Value)

            Dim Disponible_Desde As DateTime = DT_fecha.Value.Date
            Dim Hora_Desde As DateTime = DG_TurnoDisponible.SelectedRows(0).Cells("TURNO_desde").Value.ToString
            Hora_Desde = Hora_Desde.ToString("HH:mm")
            If Hora_Desde.ToString("HH:mm") < TURNO_CONF_desde Then
                Disponible_Desde = Disponible_Desde.AddDays(1)
            End If
            Disponible_Desde = Disponible_Desde.AddHours(Hora_Desde.ToString("HH"))
            Disponible_Desde = Disponible_Desde.AddMinutes(Hora_Desde.ToString("mm"))

            Dim Disponible_hasta As DateTime = DT_fecha.Value.Date
            Dim Hora_hasta As DateTime = DG_TurnoDisponible.SelectedRows(0).Cells("TURNO_hasta").Value.ToString
            Hora_hasta = Hora_hasta.ToString("HH:mm")
            If Hora_hasta.ToString("HH:mm") < TURNO_CONF_desde Then
                Disponible_hasta = Disponible_hasta.AddDays(1)
            End If
            Disponible_hasta = Disponible_hasta.AddHours(Hora_hasta.ToString("HH"))
            Disponible_hasta = Disponible_hasta.AddMinutes(Hora_hasta.ToString("mm"))

            If (Turno_desde >= Disponible_Desde And Turno_hasta <= Disponible_hasta) Then
                IM_OK_deuda.Visible = True
                IM_ERROR_moroso.Visible = False
                LB_turno.Text = "Turno: Desde el " + Turno_desde.ToString("dddd") + " a las hs." + Turno_desde.ToString("HH:mm") +
                                " Hasta el " + Turno_hasta.ToString("dddd") + " a las hs." + Turno_hasta.ToString("HH:mm")
                LB_cancha.Text = "Cancha : " + ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_nom").ToString + ". " +
                            ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_nom").ToString
                Turno_H = 1
            Else
                IM_OK_deuda.Visible = False
                IM_ERROR_moroso.Visible = True
                LB_turno.Text = ""
                LB_cancha.Text = ""
                Turno_H = 0
            End If

            Turno_habilitar()
        End If
       
    End Sub

    'Turno Limpiar /////////////////////////////////////////////////////////////////////////////////////

    Private Sub BO_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Eliminar.Click
        Limpiar()
      
    End Sub

    Public Sub Limpiar()
        Turno_Limpiar()
        GP_duracion.Enabled = True
        GP_fecha.Enabled = True
        GP_cancha.Enabled = False

        DG_Turno.DataSource = Nothing
        DG_TurnoDisponible.DataSource = Nothing
        Turno_ds.Tables("TurnoDisponible").Clear()

        GP_Horario.Enabled = False
        IM_ERROR_moroso.Visible = False
        IM_OK_deuda.Visible = False
        LB_turno.Text = ""
        LB_cancha.Text = ""
        NU_hora.Value = 0
        NU_minuto.Value = 0

        DG_Cliente.DataSource = Nothing
        DG_Cliente.Enabled = False
        TX_ape.Text = Nothing
        TX_doc.Text = Nothing

        TX_VENTA_TURNO_monto.Text = Nothing
        RB_PAGO_no.Checked = True

        TabControl2.SelectedTab = TabPage2
    End Sub

  
    'CLIENTE BUSCAR ///////////////////////////////////////////////////////////////////////////////////////
   
    Dim ds_CLI As DataSet

    Private Sub TX_doc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_doc.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TX_ape_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_ape.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TX_doc_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_doc.TextChanged
        If TX_doc.Text = Nothing Then
            BO_doc.Enabled = False
        Else
            BO_doc.Enabled = True
        End If
    End Sub

    Private Sub BO_ape_Click(sender As System.Object, e As System.EventArgs) Handles BO_ape.Click
        Cliente_ObtenerNombre()
    End Sub

    Private Sub BO_doc_Click(sender As System.Object, e As System.EventArgs) Handles BO_doc.Click
        Cliente_ObtenerDNI()
    End Sub

    Public Sub Cliente_ObtenerDNI()
        ds_CLI = DAcliente.Cliente_ObtenerDni(TX_doc.Text)
        With ds_CLI.Tables(0).Rows
            If .Count > 0 Then
                DG_Cliente.Enabled = True
                DG_Cliente.DataSource = ds_CLI.Tables(0)
                IM_ERROR_cliente.Visible = False
                LB_ERROR_cliente.Visible = False
            Else
                DG_Cliente.Enabled = False
                DG_Cliente.DataSource = Nothing
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
        End With
        TX_ape.Text = Nothing
    End Sub

    Public Sub Cliente_ObtenerNombre()
        ds_CLI = DAcliente.Cliente_ObtenerApe(TX_ape.Text)
        With ds_CLI.Tables(0).Rows
            If .Count > 0 Then
                DG_Cliente.Enabled = True
                DG_Cliente.DataSource = ds_CLI.Tables(0)
                IM_ERROR_cliente.Visible = False
                LB_ERROR_cliente.Visible = False
            Else
                DG_Cliente.Enabled = False
                DG_Cliente.DataSource = Nothing
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
        End With
        TX_doc.Text = Nothing
    End Sub

    Private Sub DG_Cliente_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Cliente.SelectionChanged
        Turno_habilitar()
    End Sub

    'TURNO ALTA //////////////////////////////////////////////////////////////////////////////////////////

    Public Sub Turno_habilitar()
        If ((DG_Cliente.CurrentRow Is Nothing) OrElse (DG_Cliente.SelectedRows.Count <> 0)) And DG_Cliente.Rows.Count > 0 And Turno_H = 1 Then
            BO_guardar.Enabled = True
        Else
            BO_guardar.Enabled = False
        End If
    End Sub

    Dim DAcaja As New Datos.Caja

    Private Sub BO_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BO_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim CANCHA_id As String = ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString

            Dim Turno_desde As DateTime = DT_fecha.Value.Date
            If NU_hora.Value < TURNO_CONF_desde.Hour Then
                Turno_desde = Turno_desde.AddDays(1)
            End If

            Dim TURNO_cant As String = NU_DUR_hora.Text + ":" + NU_DUR_minuto.Text
            Dim TURNO_hora As String = NU_hora.Text + ":" + NU_minuto.Text
            Dim CLI_id As String = DG_Cliente.SelectedRows(0).Cells("CLIidDataGridViewTextBoxColumn").Value.ToString

            Turno_desde = Turno_desde.AddHours(NU_hora.Value)
            Turno_desde = Turno_desde.AddMinutes(NU_minuto.Value)

            Dim TURNO_fechahasta As DateTime = Turno_desde
            TURNO_fechahasta = TURNO_fechahasta.AddHours(NU_DUR_hora.Value)
            TURNO_fechahasta = TURNO_fechahasta.AddMinutes(NU_DUR_minuto.Value)

            Dim ds_TurnoReservaado As DataSet = DAturno.TurnoReservado_alta(CANCHA_id, Turno_desde, TURNO_cant, TURNO_hora, TURNO_fechahasta, CLI_id, Inicio.USU_id)
            Dim Texto As String = LB_turno.Text + " " + LB_cancha.Text
            NEturno.Turno_EnviarEmail(Texto)

            If RB_PAGO_si.Checked = True Then
                Dim TURNO_id As Integer = ds_TurnoReservaado.Tables(0).Rows(0).Item("TURNO_id")
                DAturno.VentaTurnoReservado_Alta(TURNO_id, 1, Now, TX_VENTA_TURNO_monto.Text, Inicio.USU_id, Inicio.CAJA_id)
                DAcaja.Caja_Actualizar(TX_VENTA_TURNO_monto.Text, Inicio.USU_id)
            End If


            Limpiar()
            MessageBox.Show("El Turno fue dado de alta correctamente.", "Sistema de Gestion.")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Message As New System.Net.Mail.MailMessage()
        Dim SMTP As New System.Net.Mail.SmtpClient

        'CONFIGURACIÓN DEL STMP
        'SMTP.Credentials = New System.Net.NetworkCredential("hamersoftpablo@gmail.com", "123choco")
        'SMTP.Host = "smtp.gmail.com"
        'SMTP.Port = 587
        'SMTP.EnableSsl = True

        SMTP.Credentials = New System.Net.NetworkCredential("nico_qkrch@hotmail.com", "1OTRAvezelnuevoI")
        SMTP.Host = "smtp.live.com"
        SMTP.Port = 587
        SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        Message.[To].Add("nicopaztrotta@gmail.com") 'Cuenta de Correo al que se le quiere enviar el e-mail
        'Message.From = New System.Net.Mail.MailAddress("hamersoftpablo@gmail.com", "Pablo", System.Text.Encoding.UTF8) 'Quien lo envía
        Message.From = New System.Net.Mail.MailAddress("nico_qkrch@hotmail.com", "Nico", System.Text.Encoding.UTF8) 'Quien lo envía
        Message.Subject = "Turno" 'Sujeto del e-mail
        Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        Message.Body = "Anda el mail" 'contenido del mail
        Message.BodyEncoding = System.Text.Encoding.UTF8
        Message.Priority = System.Net.Mail.MailPriority.Normal
        Message.IsBodyHtml = False

        'ENVIO
        Try
            SMTP.Send(Message)
            MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub BO_Cliente_Click(sender As System.Object, e As System.EventArgs) Handles BO_Cliente.Click
        Cliente_alta.Turno_Cliente(2)
        Cliente_alta.Show()
    End Sub

    '///////////////////////////////////////////////

    Private Sub TX_VENTA_TURNO_monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_VENTA_TURNO_monto.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not TX_VENTA_TURNO_monto.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub RB_PAGO_si_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PAGO_si.CheckedChanged
        TX_VENTA_TURNO_monto.Enabled = True
    End Sub

    Private Sub RB_PAGO_no_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PAGO_no.CheckedChanged
        TX_VENTA_TURNO_monto.Enabled = False
    End Sub
End Class