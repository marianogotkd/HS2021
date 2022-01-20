﻿Imports System.IO
Imports System.Data.OleDb

Public Class Cliente_alta
    Dim DAcliente As New Datos.Cliente

    Private Sub Cliente_alta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        tx_ape_clie.Focus()

        tx_ape_clie.TextAlign = HorizontalAlignment.Center
        tx_nom_clie.TextAlign = HorizontalAlignment.Center
        tx_dni_clie.TextAlign = HorizontalAlignment.Center
        tx_dni_clie.MaxLength = 8
        tx_tel_clie.TextAlign = HorizontalAlignment.Center
        tx_mail_clie.TextAlign = HorizontalAlignment.Center
        'Habilitar()
    End Sub

    Dim Turno As Integer = 0

    Public Sub Turno_Cliente(ByVal B As Integer)
        Turno = B
    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta al Cliente?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            DAcliente.Cliente_Alta(tx_ape_clie.Text, tx_nom_clie.Text, tx_dni_clie.Text, DT_fecha.Value, tx_tel_clie.Text, tx_mail_clie.Text, tx_obser.Text, ComboBox1.Text)

            Select Case (Turno)
                Case (0)
                    limpiar_deshabilitar()
                    MessageBox.Show("El Cliente fue dado de alta correctamente.", "Sistema de Gestion.")
                Case (1)

                    If tx_dni_clie.Text = Nothing Then
                        If tx_ape_clie.Text <> Nothing Then
                            TurnoFijo_alta.TX_ape.Text = tx_ape_clie.Text + " " + tx_nom_clie.Text
                        Else
                            TurnoFijo_alta.TX_ape.Text = tx_nom_clie.Text
                        End If
                        TurnoFijo_alta.Cliente_ObtenerNombre()
                    Else
                        TurnoFijo_alta.TX_doc.Text = tx_dni_clie.Text
                        TurnoFijo_alta.Cliente_ObtenerDNI()
                    End If
                    Me.Close()

                Case (2)

                    If tx_dni_clie.Text = Nothing Then
                        If tx_ape_clie.Text <> Nothing Then
                            Turno_alta.TX_ape.Text = tx_ape_clie.Text + " " + tx_nom_clie.Text
                        Else
                            Turno_alta.TX_ape.Text = tx_nom_clie.Text
                        End If

                        Turno_alta.Cliente_ObtenerNombre()
                    Else

                        Turno_alta.TX_doc.Text = tx_dni_clie.Text
                        Turno_alta.Cliente_ObtenerDNI()
                    End If
                    Me.Close()

            End Select

        End If
    End Sub

    Private Sub tx_dni_clie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_dni_clie.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

            If Me.tx_dni_clie.Text <> "" Then
                If Me.tx_dni_clie.Text > 99999999 Then
                    e.Handled = True
                End If
            End If

        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                    e.Handled = True
                End If


            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If
    End Sub

    'Private Sub tx_dni_clie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_dni_clie.TextChanged
    '    Verificar()
    'End Sub

    'Private Sub tx_ape_clie_TextChanged(sender As System.Object, e As System.EventArgs) Handles tx_ape_clie.TextChanged
    '    Verificar()
    'End Sub

    'Private Sub tx_nom_clie_TextChanged(sender As System.Object, e As System.EventArgs) Handles tx_nom_clie.TextChanged
    '    Verificar()
    'End Sub

    'Public Sub Verificar()
    '    Dim ds_CLI_dni As DataSet = DAcliente.Cliente_VerificarDni(tx_dni_clie.Text)
    '    With ds_CLI_dni.Tables(0).Rows
    '        If .Count = 0 Then
    '            tx_dni_clie.ForeColor = Color.Black
    '            ERROR_dni.Visible = False

    '        Else
    '            ERROR_dni.Visible = True
    '            tx_dni_clie.ForeColor = Color.Red
    '        End If
    '    End With
    '    Habilitar()
    'End Sub

    'Public Sub Habilitar()
    '    If tx_dni_clie.ForeColor = Color.Black And tx_dni_clie.TextLength >= 7 And tx_ape_clie.Text <> Nothing And tx_nom_clie.Text <> Nothing Then
    '        Bo_guardar.Enabled = True
    '    Else
    '        Bo_guardar.Enabled = False
    '    End If
    'End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        limpiar_deshabilitar()
    End Sub

    Public Sub limpiar_deshabilitar()
        'datos personales///////////////////////////////////////////////////////////////////////////////////////////////////
        'botones de error
        ERROR_tx_ape_clie.Visible = False
        ERROR_dni.Visible = False
        ERROR_tx_dni_clie.Visible = False

        'datos personales
        tx_ape_clie.Text = Nothing
        tx_nom_clie.Text = Nothing
        tx_dni_clie.Text = Nothing
        tx_tel_clie.Text = Nothing
        tx_mail_clie.Text = Nothing
        DT_fecha.Value = Now

        Me.Show()
        tx_ape_clie.Focus()
        'Habilitar()
    End Sub


    Private Sub tx_dni_clie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_dni_clie.TextChanged

    End Sub
End Class