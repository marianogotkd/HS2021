Public Class Turno_Gestion

    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha
    Dim NEturno As New Aplicacion.Turno

    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener
    Dim ds_CANCHA As DataSet

    Private Sub Turno_Gestion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T.ValueMember = "CANCHA_T_id"
        Cancha_obtener()

        COM_CANCHA_T_FIN.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T_FIN.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T_FIN.ValueMember = "CANCHA_T_id"
        COM_CANCHA_T_FIN.SelectedValue = ds_CANCHA_T.Tables(0).Rows(0).Item("CANCHA_T_id") 'SELECCIONA SINTETICO


        Cancha_obtener_Fin()

        NU_DUR_minuto.Increment = 15
        NU_DUR_minuto.Maximum = 45
        NU_DUR_minuto.Minimum = 0

        NU_DUR_hora.Increment = 1
        NU_DUR_hora.Maximum = 6
        NU_DUR_hora.Minimum = 0

        Habilitar_BO_iniciar()
        Habilitar_BO_Parar()
        Habilitar_BO_Finalizar()
        Habilitar_BO_AgregarTiempo()

        Turno_FinalizadoObtener()
    End Sub

    Public Sub Cancha_obtener()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString)
        COM_CANCHA.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA.DisplayMember = "CANCHA_nom"
        COM_CANCHA.ValueMember = "CANCHA_id"
    End Sub

    'TURNO RESERVADO OBTENER //////////////////////
    Dim TURNO_CONF_desde As DateTime
    Dim TURNO_CONF_hasta As DateTime
    Dim TURNO_CONF_id As String

    Private Sub COM_CANCHA_T_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_T.SelectedIndexChanged
        Cancha_obtener()
        TurnoReservado_obtener()
    End Sub

    Private Sub COM_CANCHA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA.SelectedIndexChanged
        TurnoReservado_obtener()
    End Sub

    Public Sub TurnoReservado_obtener()
        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(Now, CANCHA_T_id)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString
        Dim TURNO_CONF_precio As Decimal = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_precio").ToString
        TURNO_CONF_id = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_id").ToString

        'DG_Turno
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerSinIniciar(Now.Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString,
                                                                 TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"), TURNO_CONF_precio)

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then
            'Existen Turnos
            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_TurnoReservado.DataSource = ds_Turno.Tables(0)
            DG_TurnoReservado.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)

            'DG_Turno TurnoFijo de Color
            Dim B As Integer = 0
            For Each row As DataGridViewRow In DG_TurnoReservado.Rows
                Select Case (row.Cells("TURNOTDataGridViewTextBoxColumn").Value)
                    Case ("Normal")
                        DG_TurnoReservado.Rows(B).DefaultCellStyle.BackColor = Color.AliceBlue
                    Case ("Fijo")
                        DG_TurnoReservado.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                End Select
                B = B + 1
            Next
            DG_TurnoReservado.ClearSelection()
        Else
            DG_TurnoReservado.DataSource = Nothing
        End If
        DG_TurnoReservado.ClearSelection()
    End Sub

    'INICIAR TURNO RESERVADO //////////////////////
    Dim ds_Turno As DataSet

    Public Sub Turno_ObtenerIniciado()
        ds_Turno = DAturno.Turno_ObtenerIniciado

        If ds_Turno.Tables(0).Rows.Count > 0 Then
            DG_Turno.DataSource = ds_Turno.Tables(0)

            For Each row As DataGridViewRow In DG_Turno.Rows
                If row.Cells("TURNO_fechahasta").Value <= Now.AddMinutes(5) Then
                    If row.Cells("TURNO_fechahasta").Value <= Now Then
                        row.DefaultCellStyle.BackColor = Color.Firebrick
                        row.DefaultCellStyle.ForeColor = Color.White
                    Else
                        row.DefaultCellStyle.BackColor = Color.Yellow
                        row.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Else
                    row.DefaultCellStyle.BackColor = Color.YellowGreen()
                    row.DefaultCellStyle.ForeColor = Color.Black
                End If
            Next
            DG_Turno.ClearSelection()
            DG_TurnoReservado.ClearSelection()
        Else
            DG_Turno.DataSource = Nothing
        End If
    End Sub

    Private Sub DG_TurnoReservado_SelectionChanged(sender As Object, e As EventArgs) Handles DG_TurnoReservado.SelectionChanged
        Habilitar_BO_iniciar()
    End Sub

    Public Sub Habilitar_BO_iniciar()
        If ((DG_TurnoReservado.CurrentRow Is Nothing) OrElse (DG_TurnoReservado.SelectedRows.Count <> 0)) And DG_TurnoReservado.Rows.Count > 0 Then

            Dim CANCHA_nom As String = ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_nom").ToString
            Dim C As Integer = 0
            For Each row As DataGridViewRow In DG_Turno.Rows
                If row.Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = CANCHA_nom Then
                    C = 1
                End If
            Next
            If C = 0 Then
                BO_IniciarTurnoReservado.Enabled = True
            Else
                BO_IniciarTurnoReservado.Enabled = False
            End If
        Else
            BO_IniciarTurnoReservado.Enabled = False
        End If
    End Sub

    Private Sub BO_IniciarTurnoReservado_Click(sender As System.Object, e As System.EventArgs) Handles BO_IniciarTurnoReservado.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim CANCHA_id As String = ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString
            
            'Turno Alta
            Dim CLI_id As Integer = DG_TurnoReservado.SelectedRows(0).Cells("CLIEidDataGridViewTextBoxColumn").Value.ToString

            Dim TURNO_tiempo As String = DG_TurnoReservado.SelectedRows(0).Cells("TURNOcantDataGridViewTextBoxColumn").Value.ToString
            Dim TURNO_pago As Decimal = DG_TurnoReservado.SelectedRows(0).Cells("VENTATURNOmontoDataGridViewTextBoxColumn").Value.ToString
            Dim TURNO_saldo As Decimal = DG_TurnoReservado.SelectedRows(0).Cells("VENTA_TURNO_deuda").Value.ToString
            Dim TURNO_desde As String = Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString
                Dim FECHA_hasta As DateTime = Now
                FECHA_hasta = FECHA_hasta.AddHours(TURNO_tiempo.Substring(0, 2))
                FECHA_hasta = FECHA_hasta.AddMinutes(TURNO_tiempo.Substring(3, 2))
            Dim TURNO_hasta As String = FECHA_hasta.Hour.ToString + ":" + FECHA_hasta.Minute.ToString + ":" + FECHA_hasta.Second.ToString

            DAturno.Turno_alta(TURNO_CONF_id, CANCHA_id, Now, TURNO_desde, TURNO_hasta, TURNO_tiempo, CLI_id, FECHA_hasta, Inicio.USU_id, TURNO_pago, TURNO_saldo)

                'Turno Reservado
                Dim TURNO_id As String = DG_TurnoReservado.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn").Value.ToString
                If DG_TurnoReservado.SelectedRows(0).Cells("TURNOTDataGridViewTextBoxColumn").Value.ToString = "Fijo" Then
                    DAturno.TurnoReservadoFijo_ActualizarEstado(TURNO_id, 2)
                Else
                    DAturno.TurnoReservado_ActualizarEstado(TURNO_id, 2)
                End If

                TurnoReservado_obtener()
                Turno_ObtenerIniciado()


            MessageBox.Show("Asigne una mesa al turno en curso", "Sistema de Gestión La Santa Fe")
            If Inicio.tipo_usuario = "Administrador" Then
                US_administrador.llamar_Form(Mesas_gestion_2)
                Mesas_gestion_2.procedencia_turno = "si"
                Mesas_gestion_2.idclie_procendencia_turno = CLI_id
                US_administrador.Focus()

            Else
                'es empleado
                US_Empleado.llamar_Form(Mesas_gestion_2)
                Mesas_gestion_2.procedencia_turno = "si"
                Mesas_gestion_2.idclie_procendencia_turno = CLI_id
                US_Empleado.Focus()
            End If

            End If
    End Sub


    'TURNO INICIADO ////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub DG_Turno_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Turno.SelectionChanged
        Habilitar_BO_Finalizar()
        Habilitar_BO_AgregarTiempo()
        Habilitar_BO_Parar()
    End Sub

    Public Sub Habilitar_BO_Finalizar()
        If ((DG_Turno.CurrentRow Is Nothing) OrElse (DG_Turno.SelectedRows.Count <> 0)) And DG_Turno.Rows.Count > 0 Then
            Dim Turno_Fnalizar As DateTime = DG_Turno.SelectedRows(0).Cells("TURNO_fechahasta").Value
            If Turno_Fnalizar <= Now Then
                BO_Finalizar.Enabled = True
            Else
                BO_Finalizar.Enabled = False
            End If
        Else
            BO_Finalizar.Enabled = False
        End If
    End Sub

    Private Sub BO_Finalizar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Finalizar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Finalizar el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            'Turno Alta
            Dim TURNO_id As Integer = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn1").Value.ToString

            Dim TURNO_tiempo As String = DG_Turno.SelectedRows(0).Cells("TURNOtiempoDataGridViewTextBoxColumn").Value.ToString
            Dim TURNO_desde As String = DG_Turno.SelectedRows(0).Cells("TURNOdesdeDataGridViewTextBoxColumn").Value.ToString
            Dim FECHA_hasta As DateTime = DG_Turno.SelectedRows(0).Cells("TURNO_fechahasta").Value
            Dim TURNO_hasta As String = DG_Turno.SelectedRows(0).Cells("TURNOhastaDataGridViewTextBoxColumn").Value.ToString

            DAturno.Turno_modificar(TURNO_id, TURNO_desde, TURNO_hasta, TURNO_tiempo, FECHA_hasta, 2)

            Turno_ObtenerIniciado()
            Turno_FinalizadoObtener()
        End If
    End Sub

    Private Sub NU_DUR_hora_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_DUR_hora.ValueChanged
        Habilitar_BO_AgregarTiempo()
    End Sub

    Private Sub NU_DUR_minuto_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_DUR_minuto.ValueChanged
        Habilitar_BO_AgregarTiempo()
    End Sub

    Public Sub Habilitar_BO_AgregarTiempo()
        If ((DG_Turno.CurrentRow Is Nothing) OrElse (DG_Turno.SelectedRows.Count <> 0)) And DG_Turno.Rows.Count > 0 Then
            If NU_DUR_hora.Value > 0 Or NU_DUR_minuto.Value >= 15 Then
                BO_AgregarTiempo.Enabled = True
            Else
                BO_AgregarTiempo.Enabled = False
            End If
        Else
            BO_AgregarTiempo.Enabled = False
        End If
    End Sub

    Private Sub BO_AgregarTiempo_Click(sender As System.Object, e As System.EventArgs) Handles BO_AgregarTiempo.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Agregar Tiempo al Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim TURNO_id As Integer = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn1").Value.ToString

            Dim TURNO_desde As String = DG_Turno.SelectedRows(0).Cells("TURNOdesdeDataGridViewTextBoxColumn").Value.ToString
            Dim FECHA_hasta As DateTime = DG_Turno.SelectedRows(0).Cells("TURNO_fechahasta").Value.ToString

            FECHA_hasta = FECHA_hasta.AddHours(NU_DUR_hora.Value)
            FECHA_hasta = FECHA_hasta.AddMinutes(NU_DUR_minuto.Value)
            Dim TURNO_hasta As String = FECHA_hasta.Hour.ToString + ":" + FECHA_hasta.Minute.ToString

            Dim TURNO_tiempo As String = DG_Turno.SelectedRows(0).Cells("TURNOtiempoDataGridViewTextBoxColumn").Value.ToString
            Dim Hora As Integer = TURNO_tiempo.Substring(0, 2)
            Dim Minuto As Integer = TURNO_tiempo.Substring(3, 2)
            Hora = Hora + NU_DUR_hora.Value
            Minuto = Minuto + NU_DUR_minuto.Value
            Dim horas As String = Hora
            Dim minutos As String = Minuto
            Dim Tiempo As String = horas + ":" + minutos



            DAturno.Turno_modificar(TURNO_id, TURNO_desde, TURNO_hasta, Tiempo, FECHA_hasta, 1)

            NU_DUR_hora.Value = 0
            NU_DUR_minuto.Value = 0

            Turno_ObtenerIniciado()
        End If
    End Sub

    Public Sub Habilitar_BO_Parar()
        If ((DG_Turno.CurrentRow Is Nothing) OrElse (DG_Turno.SelectedRows.Count <> 0)) And DG_Turno.Rows.Count > 0 Then
            BO_Parar.Enabled = True
        Else
            BO_Parar.Enabled = False
        End If
    End Sub

    Private Sub BO_Parar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Parar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Parar el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim TURNO_id As Integer = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn1").Value.ToString


            'Dim FECHA_desde As DateTime = DG_Turno.SelectedRows(0).Cells(3).Value 'nico
            Dim FECHA_desde As DateTime = DG_Turno.SelectedRows(0).Cells("TURNO_fecha").Value 'choco
            'Dim FECHA_hasta As DateTime = DG_Turno.SelectedRows(0).Cells(4).Value 'choco
            Dim FECHA_hasta As DateTime = Now 'de nico
            Dim Diferencia As Integer = (DateDiff(DateInterval.Second, FECHA_desde, FECHA_hasta)).ToString

            Dim Turno_desde As String = FECHA_desde.Hour.ToString + ":" + FECHA_desde.Minute.ToString + ":" + FECHA_desde.Second.ToString
            Dim TURNO_hasta As String = FECHA_hasta.Hour.ToString + ":" + FECHA_hasta.Minute.ToString + ":" + FECHA_hasta.Second.ToString

            '----de nico
            Dim Hora As Integer = CInt(Diferencia / 3600)
            Dim minuto As Integer = CInt((Diferencia - (Hora * 3600)) / 60)
            Dim Segundo As Integer = Diferencia - ((minuto * 60) + (Hora * 3600))
            Segundo = Math.Abs(Segundo)
            Hora = Math.Abs(Hora)
            minuto = Math.Abs(minuto)
            Dim Tiempo As String = Hora.ToString + ":" + minuto.ToString + ":" + Segundo.ToString

            '----choco
            'Dim T_desde As DateTime = DG_Turno.SelectedRows(0).Cells(3).Value
            'Dim T_hasta As DateTime = DG_Turno.SelectedRows(0).Cells(4).Value

            'Dim tiempo As String = ""

            'If Now <= T_hasta Then
            '    Diferencia = (DateDiff(DateInterval.Second, T_desde, Now)).ToString()
            '    Dim Hora As Integer = CInt(Diferencia / 3600)
            '    Dim minuto As Integer = CInt((Diferencia - (Hora * 3600)) / 60)
            '    Dim Segundo As Integer = Diferencia - ((minuto * 60) + (Hora * 3600))
            '    tiempo = Hora.ToString + ":" + minuto.ToString + ":" + Segundo.ToString
            'Else
            '    Diferencia = (DateDiff(DateInterval.Second, T_desde, T_hasta)).ToString()
            '    Dim Hora As Integer = CInt(Diferencia / 3600)
            '    Dim minuto As Integer = CInt((Diferencia - (Hora * 3600)) / 60)
            '    Dim Segundo As Integer = Diferencia - ((minuto * 60) + (Hora * 3600))
            '    tiempo = Hora.ToString + ":" + minuto.ToString + ":" + Segundo.ToString
            'End If



            'Dim primercaracter As Integer = tiempo.IndexOf("-")
            'If primercaracter <> -1 Then

            '    Dim tiempo_a As DateTime = DG_Turno.SelectedRows(0).Cells(4).Value
            '    DAturno.Turno_modificar(TURNO_id, T_desde, T_hasta, tiempo_a, FECHA_hasta, 2)
            'Else
            '    DAturno.Turno_modificar(TURNO_id, T_desde, T_hasta, tiempo, FECHA_hasta, 2)
            'End If



            DAturno.Turno_modificar(TURNO_id, Turno_desde, TURNO_hasta, Tiempo, FECHA_hasta, 2) 'de nico


            Turno_ObtenerIniciado()
            Turno_FinalizadoObtener()
        End If
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Public Sub Cancha_obtener_Fin()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T_FIN.SelectedIndex).Item("CANCHA_T_id").ToString)
        'ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString) 'NICO
        COM_CANCHA_FIN.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA_FIN.DisplayMember = "CANCHA_nom"
        COM_CANCHA_FIN.ValueMember = "CANCHA_id"
        COM_CANCHA_FIN.SelectedValue = ds_CANCHA.Tables(0).Rows(0).Item("CANCHA_id")

    End Sub

    Private Sub COM_CANCHA_T_FIN_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_T_FIN.SelectedIndexChanged
        Cancha_obtener_Fin()
    End Sub

    Private Sub COM_CANCHA_FIN_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_FIN.SelectedIndexChanged
        Turno_FinalizadoObtener()
    End Sub

    Public Sub Turno_FinalizadoObtener()
        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(Now, CANCHA_T_id)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString
        TURNO_CONF_id = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_id").ToString

        'DG_Turno
        Dim ds_Turno As DataSet = DAturno.Turno_ObtenerFinalizado(Now.Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA_FIN.SelectedIndex).Item("CANCHA_id").ToString,
                                                                 TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))

        If ds_Turno.Tables(0).Rows.Count > 0 Then
            DG_TurnoFinalziado.DataSource = ds_Turno.Tables(0)
            'DG_TurnoFinalziado.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)


        Else
            DG_TurnoFinalziado.DataSource = Nothing
        End If
        DG_TurnoFinalziado.ClearSelection()
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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


    Private Sub DG_TurnoFinalizado_SelectionChanged(sender As Object, e As EventArgs) Handles DG_TurnoFinalziado.SelectionChanged
        If ((DG_TurnoFinalziado.CurrentRow Is Nothing) OrElse (DG_TurnoFinalziado.SelectedRows.Count <> 0)) And DG_TurnoFinalziado.Rows.Count > 0 Then
            If DG_TurnoFinalziado.SelectedRows(0).Cells("DataGridViewTextBoxColumn2").Value > 0 Then
                BO_Pagar.Enabled = True
                TX_VENTA_TURNO_monto.Text = DG_TurnoFinalziado.SelectedRows(0).Cells("DataGridViewTextBoxColumn2").Value
                TX_VENTA_TURNO_monto.Enabled = True
            Else
                BO_Pagar.Enabled = False
                TX_VENTA_TURNO_monto.Text = Nothing
                TX_VENTA_TURNO_monto.Enabled = False
            End If
        Else
            BO_Pagar.Enabled = False
            TX_VENTA_TURNO_monto.Text = Nothing
            TX_VENTA_TURNO_monto.Enabled = False
        End If
    End Sub

    Dim DAcaja As New Datos.Caja

    Private Sub BO_Pagar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Pagar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Parar el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim TURNO_id As Integer = DG_TurnoFinalziado.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn2").Value.ToString

            DAturno.Turno_modificarSaldo(TURNO_id, TX_VENTA_TURNO_monto.Text)
            DAturno.VentaTurno_Alta(TURNO_id, Now, TX_VENTA_TURNO_monto.Text, Inicio.USU_id, Inicio.CAJA_id)
            DAcaja.Caja_Actualizar(TX_VENTA_TURNO_monto.Text, Inicio.USU_id)
            Turno_FinalizadoObtener()
        End If
    End Sub
End Class