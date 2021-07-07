Public Class Equipo_consulta
    Dim dacliete As New Datos.Cliente
    Dim daequipo As New Datos.Equipo
    Public Cli_id As Integer 'me lo envia el formulario Cliente_modificar
    Private Sub BO_equipo_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_equipo_nuevo.Click
        Equipo_nuevo.Close()

        'pasar id de la sucursal para recuperar los sectores

        Equipo_nuevo.txt_cliente.Text = txt_cliente.Text
        Equipo_nuevo.txt_sucursal.Text = cb_sucursal.Text
        Equipo_nuevo.SucxClie_id = cb_sucursal.SelectedValue
        Equipo_nuevo.procedencia = "alta"
        Equipo_nuevo.Show()
        Me.Hide()
    End Sub

    Private Sub BO_equipo_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_equipo_editar.Click
        'tengo q enviar el id del equipo
        If DG_clientes.Rows.Count <> 0 Then
            Equipo_nuevo.Close()
            Dim Equipo_id As Integer = DG_clientes.CurrentRow.Cells("EquipoidDataGridViewTextBoxColumn").Value

            Equipo_nuevo.Equipo_id = Equipo_id
            Equipo_nuevo.txt_cliente.Text = txt_cliente.Text
            Equipo_nuevo.txt_sucursal.Text = cb_sucursal.Text
            Equipo_nuevo.SucxClie_id = cb_sucursal.SelectedValue
            Equipo_nuevo.procedencia = "modificar"
            Equipo_nuevo.Text = "Modificar Equipo"
            Equipo_nuevo.Show()
            Me.Hide()
        Else
            MessageBox.Show("Debe seleccionar un equipo para editar.", "Sistema de Gestión.", MessageBoxButtons.OK)
        End If


    End Sub

    Private Sub Equipo_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'recuperar todas las sucursales y poner en el combo
        recuperar_info_cliente()
    End Sub


    Dim SucxClie_id As Integer = 0
    Private Sub recuperar_info_cliente()
        Dim ds_clie As DataSet = dacliete.Cliente_obtener_info(Cli_id)

        If ds_clie.Tables(0).Rows.Count <> 0 Then
            txt_cliente.Text = ds_clie.Tables(0).Rows(0).Item("CLI_Fan")
            txt_cliente.ReadOnly = True
        End If



        If ds_clie.Tables(3).Rows.Count <> 0 Then
            cb_sucursal.DataSource = ds_clie.Tables(3) 'contiene las sucursales cuyo SucxClie_estado= 'ACTIVO'
            cb_sucursal.DisplayMember = "SucxClie_nombre"
            cb_sucursal.ValueMember = "SucxClie_id"
            'ahora cargo en el gridview de abajo los equipos existentes para esa sucursal
            SucxClie_id = cb_sucursal.SelectedValue
            recuperar_equipos()
        End If
    End Sub

    Public Sub recuperar_equipos()
        Equipos_ds.Tables("Equipo").Rows.Clear()
        If SucxClie_id <> 0 Then
            SucxClie_id = cb_sucursal.SelectedValue

            'recupera todos los equipos de la sucursal seleccionada
            Dim ds_equipos As DataSet = daequipo.Equipo_buscar_x_sucursal(SucxClie_id)
            If ds_equipos.Tables(0).Rows.Count <> 0 Then
                Equipos_ds.Tables("Equipo").Merge(ds_equipos.Tables(0))
                'DG_clientes.DataSource = ds_equipos.Tables(0)
            Else
                MessageBox.Show("no hay equipos para la sucursal:" + cb_sucursal.Text + ".", "Sistema de Gestión.", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub cb_sucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_sucursal.SelectedIndexChanged
        recuperar_equipos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DG_clientes.Rows.Count <> 0 Then
            Mantenimiento_config_alta.Close()
            Dim equipo_id As Integer = DG_clientes.CurrentRow.Cells("EquipoidDataGridViewTextBoxColumn").Value
            Mantenimiento_config_alta.Equipo_id = equipo_id
            Me.WindowState = FormWindowState.Minimized
            Mantenimiento_config_alta.Show()
        Else
            MessageBox.Show("Error, debe seleccionar un equipo para continuar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DG_clientes.Rows.Count <> 0 Then

        End If
    End Sub
End Class