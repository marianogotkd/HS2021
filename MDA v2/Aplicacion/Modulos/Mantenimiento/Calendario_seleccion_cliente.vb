Imports System.IO
Imports System.Data.OleDb
Public Class Calendario_seleccion_cliente
    Dim DAcliente As New Datos.Cliente

    Dim busqueda As String = ""
    Dim busqueda_parametro As String = ""
    Public procedencia = ""



    Private Sub Calendario_seleccion_cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Clientes()
        TabPage2.Parent = Nothing
    End Sub

    '--------choco 19-10-2018---------
    Dim ds_clie As DataSet
    'recupero todos los clientes
    Public Sub Obtener_Clientes()
        ds_clie = DAcliente.Cliente_obtenertodo()
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            Cliente_ds.Tables("Cliente1").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Cliente_ds.Tables("Cliente1").Merge(ds_clie.Tables(0)) '' al combinarla con el dataset "cliente" ya puedo filtrar
            'DG_clientes.DataSource = ds_clie.Tables(0)
            'DG_clientes_old.DataSource = ds_clie.Tables(0)
        End If
    End Sub


    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.SelectAll()
        TextBox1.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_Fan", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        Cliente1BindingSource.Filter = Filtro

        If DG_clientes.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(CLI_dni, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            Cliente1BindingSource.Filter = Filtro
        End If

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabPage1.Parent = TabControl1 'lo vuelvo a unir
        TabPage2.Parent = Nothing 'oculto 
        TabControl1.SelectedTab = TabPage1 'selecciono
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If procedencia = "" Then
            If DG_sucursales.Rows.Count <> 0 Then
                'aqui tendria q ocultar el formulario y abrir el form del calendario que va a mostrar las citas solo de 1 sucursal. la seleccionada.

                Dim calendario As New Calendario_Mantenimiento
                calendario.sucursal_id = DG_sucursales.CurrentRow.Cells("SucxClieidDataGridViewTextBoxColumn").Value
                calendario.Text = "Calendario de mantenimientos para el cliente: " + CStr(DG_clientes.CurrentRow.Cells("CLIFanDataGridViewTextBoxColumn").Value) +
                    ", sucursal: " + CStr(DG_sucursales.CurrentRow.Cells("SucxClienombreDataGridViewTextBoxColumn").Value)

                calendario.Show()
                Me.Hide() 'oculto este formulario 
            Else
                MessageBox.Show("Error, debe seleccionar una sucursal del listado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        If procedencia = "mantenimientos realizados" Then
            If DG_sucursales.Rows.Count <> 0 Then
                'Dim formulario As New Mantenimientos_realizados_consulta
                Mantenimientos_realizados_consulta.Close()
                Mantenimientos_realizados_consulta.txt_cliente.Text = CStr(DG_clientes.CurrentRow.Cells("CLIFanDataGridViewTextBoxColumn").Value)
                Mantenimientos_realizados_consulta.txt_sucursal.Text = CStr(DG_sucursales.CurrentRow.Cells("SucxClienombreDataGridViewTextBoxColumn").Value)
                Mantenimientos_realizados_consulta.SucxClie_id = DG_sucursales.CurrentRow.Cells("SucxClieidDataGridViewTextBoxColumn").Value
                Mantenimientos_realizados_consulta.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error, debe seleccionar una sucursal del listado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub BO_equipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_equipos.Click
        If DG_clientes.Rows.Count <> 0 Then
            TabPage1.Parent = Nothing 'oculto 
            TabPage2.Parent = TabControl1 'vuelvo a unir
            TabControl1.SelectedTab = TabPage2 'selecciono
            GroupBox2.Text = GroupBox2.Text + CStr(DG_clientes.CurrentRow.Cells("CLIFanDataGridViewTextBoxColumn").Value)
            'tengo que recuperar las sucursales para ese cliente.
            Dim CLI_ID As Integer = DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value
            recuperar_sucursales(CLI_ID)
        Else
            MessageBox.Show("Error, debe seleccionar un cliente del listado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub recuperar_sucursales(ByVal cliente_id As Integer)
        Cliente_ds.Tables("Sucursales").Rows.Clear()
        Dim ds_clie_recu As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
        Dim a As Integer = 0
        If ds_clie_recu.Tables(3).Rows.Count <> 0 Then
            While a < ds_clie_recu.Tables(3).Rows.Count
                Dim fila As DataRow = Cliente_ds.Tables("Sucursales").NewRow
                fila("SucxClie_id") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_id")
                fila("SucxClie_nombre") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_nombre")
                fila("SucxClie_Prov") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_Prov")
                fila("SucxClie_Loc") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_Loc")
                fila("EnBD") = "si"
                fila("Provincia") = ds_clie_recu.Tables(3).Rows(a).Item("provincia")
                fila("Localidad") = ds_clie_recu.Tables(3).Rows(a).Item("Localidad")
                fila("SucxClie_tel") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_tel")
                fila("SucxClie_mail") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_mail")
                fila("SucxClie_dir") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_dir")
                fila("SucxClie_CP") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_CP")
                Cliente_ds.Tables("Sucursales").Rows.Add(fila)
                a = a + 1
            End While
        Else
            MessageBox.Show("El cliente no posee sucursal, por favor asigne uno en la sección correspondiente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

End Class