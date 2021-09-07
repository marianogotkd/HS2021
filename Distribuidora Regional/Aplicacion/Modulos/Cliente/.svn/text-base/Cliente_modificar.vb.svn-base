Imports System.IO
Imports System.Data.OleDb
Public Class Cliente_modificar
    Dim DAcliente As New Datos.Cliente

    Dim busqueda As String = ""
    Dim busqueda_parametro As String = ""

    Private Sub Cliente_modificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        TX_ape.Focus()

        TX_ape.TextAlign = HorizontalAlignment.Center
        TX_doc.TextAlign = HorizontalAlignment.Center
        TX_doc.MaxLength = 8

        BO_doc.Enabled = False
        BO_Cargar.Enabled = False

        GP_Cliente.Enabled = False
        'tx_ape_clie.Enabled = False
        'tx_nom_clie.Enabled = False
        'tx_dni_clie.Enabled = False

        BO_Guardar.Enabled = False
        '  BO_Eliminar.Enabled = False
        BO_Cancelar.Enabled = True
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
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            buscar_cliedni()
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
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_clieape()
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
        buscar_clieape()
    End Sub
    Public Sub buscar_clieape()
        ds_CLI = DAcliente.Cliente_ObtenerApe(TX_ape.Text)
        With ds_CLI.Tables(0).Rows
            If .Count > 0 Then
                DG_cliente.Enabled = True
                DG_cliente.DataSource = ds_CLI.Tables(0)
                IM_ERROR_cliente.Visible = False
                LB_ERROR_cliente.Visible = False
            Else
                DG_cliente.Enabled = False
                DG_cliente.DataSource = Nothing
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
        End With
        TX_doc.Text = Nothing
    End Sub
    Private Sub BO_doc_Click(sender As System.Object, e As System.EventArgs) Handles BO_doc.Click
        buscar_cliedni()
    End Sub
    Public Sub buscar_cliedni()
        ds_CLI = DAcliente.Cliente_ObtenerDni(TX_doc.Text)
        With ds_CLI.Tables(0).Rows
            If .Count > 0 Then
                DG_cliente.Enabled = True
                DG_cliente.DataSource = ds_CLI.Tables(0)
                IM_ERROR_cliente.Visible = False
                LB_ERROR_cliente.Visible = False
            Else
                DG_cliente.Enabled = False
                DG_cliente.DataSource = Nothing
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
        End With
        TX_ape.Text = Nothing
    End Sub

    Private Sub DG_Cliente_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DG_cliente.SelectionChanged
        If ((DG_cliente.CurrentRow Is Nothing) OrElse (DG_cliente.SelectedRows.Count <> 0)) And DG_cliente.Rows.Count > 0 Then
            BO_Cargar.Enabled = True
            BO_Eliminar.Enabled = True
        Else
            BO_Cargar.Enabled = False
            BO_Eliminar.Enabled = False
        End If
    End Sub


    Dim CLI_id As Integer
    Private Sub BO_Jugador_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cargar.Click

        CLI_id = DG_cliente.SelectedRows(0).Cells("CLIidDataGridViewTextBoxColumn").Value.ToString

        Dim ds_CLI_Tabla As DataTable = ds_CLI.Tables(0)
        For Each row As DataRow In ds_CLI_Tabla.Rows
            If Convert.ToString(row("CLI_id")) = CLI_id Then
                'tx_ape_clie.Text = Convert.ToString(row("CLI_ape"))
                tx_nom_clie.Text = Convert.ToString(row("CLI_nom"))
                'tx_dni_clie.Text = Convert.ToString(row("CLI_dni"))
                'DT_fecha.Value = Convert.ToString(row("CLI_fnac"))
                tx_tel_clie.Text = Convert.ToString(row("CLI_tel"))
                tx_mail_clie.Text = Convert.ToString(row("CLI_mail"))
                tx_obser.Text = Convert.ToString(row("CLI_observaciones"))
                Tb_dir.Text = Convert.ToString(row("CLI_direc"))
                Tb_cel.Text = Convert.ToString(row("CLI_cel"))

                GroupBox1.Enabled = False
                TabControl1.SelectedTab = TabPage2
                GP_Cliente.Enabled = True
                BO_Guardar.Enabled = True
                BO_Eliminar.Enabled = True
            End If
        Next

        VarElec = "modificar"

    End Sub


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

    Dim VarElec As String

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Guardar.Click
        If VarElec = "nuevo" Then
            Guardar_Nuevo()

        Else
            Modificar()

        End If

        VentaRegional_nuevodiseño.Obtener_Clientes()

    End Sub

    Private Sub BO_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Eliminar.Click
        If Me.DG_cliente.CurrentRow IsNot Nothing Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea Eliminar al Cliente?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                DAcliente.Cliente_eliminar(DG_cliente.SelectedRows(0).Cells("CLIidDataGridViewTextBoxColumn").Value.ToString)
                limpiar_deshabilitar()
                Me.TabControl1.SelectedTab = TabPage1
                MessageBox.Show("El Cliente fue Eliminado correctamente.", "Sistema de Gestion.")
                GroupBox1.Enabled = True
            End If
        Else
            MsgBox("Seleccione un dato en el cuadro", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cancelar.Click
        limpiar_deshabilitar()
        Me.TabControl1.SelectedTab = TabPage1
        GroupBox1.Enabled = True
    End Sub

    Public Sub limpiar_deshabilitar()
        'datos personales///////////////////////////////////////////////////////////////////////////////////////////////////
        'botones de error

        BO_Guardar.Enabled = False
        BO_Eliminar.Enabled = False
        'datos personales

        tx_nom_clie.Text = Nothing

        tx_tel_clie.Text = Nothing
        tx_mail_clie.Text = Nothing
        TX_ape.Text = Nothing
        TX_doc.Text = Nothing

        tx_obser.Text = Nothing
        DG_cliente.DataSource = Nothing
        GP_Cliente.Enabled = False
        Btn_Nuevo.Enabled = True

        Me.Show()
        TX_ape.Focus()
    End Sub

    Private Sub tx_dni_clie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ''aqui pongo el codigo para remplazar el punto por una coma
        'If e.KeyChar.ToString() = "." Then
        '    e.KeyChar = ","
        'End If
        ''a continuacion el codigo para impedir el ingreso de dos comas o letras
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False

        '    If Me.tx_dni_clie.Text <> "" Then
        '        If Me.tx_dni_clie.Text > 99999999 Then
        '            e.Handled = True
        '        End If
        '    End If

        'Else
        '    If Char.IsControl(e.KeyChar) Then
        '        e.Handled = False
        '    Else
        '        If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
        '            e.Handled = True
        '        End If


        '    End If
        '    If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
        '        e.Handled = True
        '    End If
        'End If
    End Sub

   
    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        Btn_Nuevo.Enabled = False
        GP_Cliente.Enabled = True
        BO_Guardar.Enabled = True
        VarElec = "nuevo"
        TabControl1.SelectedTab = TabPage2
    End Sub


    Public Sub Guardar_Nuevo()

        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta al Cliente?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            DAcliente.Cliente_Alta(tx_nom_clie.Text, tx_tel_clie.Text, tx_mail_clie.Text, tx_obser.Text, Tb_dir.Text, Tb_cel.Text)
            'DAcliente.Cliente_Modificar(CLI_id, tx_nom_clie.Text, tx_tel_clie.Text, tx_mail_clie.Text, tx_obser.Text, Tb_dir.Text, Tb_cel.Text)
            limpiar_deshabilitar()
            Me.TabControl1.SelectedTab = TabPage1
            MessageBox.Show("El Cliente fue Dado de Alta correctamente.", "Sistema de Gestion.")
        End If


    End Sub

    Public Sub Modificar()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Actualizar al Cliente?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            DAcliente.Cliente_Modificar(CLI_id, tx_nom_clie.Text, tx_tel_clie.Text, tx_mail_clie.Text, tx_obser.Text, Tb_cel.Text, Tb_dir.Text)
            limpiar_deshabilitar()
            Me.TabControl1.SelectedTab = TabPage1
            MessageBox.Show("El Cliente fue actualizado correctamente.", "Sistema de Gestion.")
            GroupBox1.Enabled = True

            VarElec = ""
        End If
    End Sub

End Class