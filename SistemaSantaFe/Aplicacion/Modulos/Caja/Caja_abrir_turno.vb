﻿Public Class Caja_abrir_turno
    Dim DAcaja As New Datos.Caja
    Dim DAusuario As New Datos.Usuario
    Dim APcaja As New Aplicacion.Caja
    Private Sub BO_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Abrir.Click
        obtener_usuario_caja()
    End Sub

    Private Sub obtener_usuario_caja()
        Select Case (BO_Abrir.Text)
            Case ("INICIAR CAJA")
                'aqui valido q no haya una caja abierta....
                Dim ds_caja As DataSet = DAcaja.Caja_validad_Apertura(Inicio.suc_id, Inicio.USU_id, Inicio.terminal_id)
                If ds_caja.Tables(0).Rows.Count = 0 Then
                    'entonces estoy x abrir la primera caja.
                    Registro_monto_inicial.Show()
                    Dim ds_usuario As DataSet = DAusuario.Usuario_obtener()
                    Dim i As Integer = 0
                    Dim nombre_usu As String = ""
                    While i < ds_usuario.Tables(0).Rows.Count
                        If Inicio.USU_id = ds_usuario.Tables(0).Rows(i).Item("USU_id") Then
                            nombre_usu = ds_usuario.Tables(0).Rows(i).Item("USU_ape") + " " + ds_usuario.Tables(0).Rows(i).Item("USU_nom")
                        End If
                        i = i + 1
                    End While

                    Registro_monto_inicial.LB_nombre_usu.Text = nombre_usu
                    Registro_monto_inicial.LB_fecha.Text = Today

                    Me.Close()
                    'Else
                    '    'recorro la tabla y me fijo si hay un abierta.
                    '    Dim ultimo_row As Integer = ds_caja.Tables(0).Rows.Count - 1
                    '    If ds_caja.Tables(0).Rows(ultimo_row).Item("CAJA_estado") = "1" Then
                    '        Dim usuario As String = ds_caja.Tables(0).Rows(ultimo_row).Item("USU_ape") + " " + ds_caja.Tables(0).Rows(ultimo_row).Item("USU_nom")
                    '        MessageBox.Show("Error! La caja ya ha sido abierta por el usuario:" & usuario, "Sistema de Gestion.")
                    '    Else
                    '        Registro_monto_inicial.Show()
                    '        Dim usuario As String = ds_caja.Tables(0).Rows(ultimo_row).Item("USU_ape") + " " + ds_caja.Tables(0).Rows(ultimo_row).Item("USU_nom")
                    '        Registro_monto_inicial.LB_nombre_usu.Text = usuario
                    '        Registro_monto_inicial.LB_fecha.Text = Today
                    '        Me.Close()
                    '    End If
                End If
            Case ("INICIAR TURNO")
                Dim ds_usuario As DataSet = DAusuario.Usuario_obtener()
                Dim i As Integer = 0
                Dim nombre_usu As String = ""
                While i < ds_usuario.Tables(0).Rows.Count
                    If Inicio.USU_id = ds_usuario.Tables(0).Rows(i).Item("USU_id") Then
                        nombre_usu = ds_usuario.Tables(0).Rows(i).Item("USU_ape") + " " + ds_usuario.Tables(0).Rows(i).Item("USU_nom")
                    End If
                    i = i + 1
                End While

                Dim ds_terminal As DataSet = DAcaja.Consultar_estado_terminal(Inicio.terminal_id)

                If ds_terminal.Tables(0).Rows(0).Item("Terminales_estado") = "En espera de turno" Then
                    DAcaja.Caja_turno_cambio(Inicio.USU_id, Inicio.suc_id, Now, CDec(0), Inicio.terminal_id)
                    MessageBox.Show("Turno iniciado correctamente por el usuario:" & nombre_usu, "Sistema de Gestión.")
                    APcaja.Caja_Validar()
                    Me.Close()
                End If


        End Select
        
    End Sub

    Private Sub Caja_abrir_turno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'aqui valido si ya hay una caja abierta, el siguiente turno solamente tendra que iniciar turno, no ingresar el monto inicial de caja.
        Dim ds_terminal As DataSet = DAcaja.Consultar_estado_terminal(Inicio.terminal_id)
        TextBox1.Text = ds_terminal.Tables(0).Rows(0).Item("Terminales_desc")
            If ds_terminal.Tables(0).Rows(0).Item("Terminales_estado") = "En espera de turno" Then
            BO_Abrir.Text = "INICIAR TURNO"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = True
    End Sub
End Class