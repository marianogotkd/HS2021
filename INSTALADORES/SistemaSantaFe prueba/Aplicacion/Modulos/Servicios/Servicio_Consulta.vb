Public Class Servicio_Consulta
    Dim DAservicio As New Datos.Servicio
    Dim DS_Obtener As New Servicio_DS
    Dim DAsucursal As New Datos.Sucursal
    Dim Obtenido = "no"
    Public serv_id = 0
    Public usuario_id
    Public sucursal_id
    Dim DAventa As New Datos.Venta

    Private Sub Servicio_Consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LOAD_FORM()
    End Sub

    Public Sub LOAD_FORM()
        Sucursales_Obtener()
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        sucursal_id = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")

        ComboBox_suc.SelectedValue = sucursal_id
        obtener_Servicio(ComboBox_suc.SelectedValue)

        ComboBox_buscar.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0

        If Inicio.UT_id <> 1 Then
            ComboBox_suc.Enabled = False
        End If
    End Sub



    Private Sub obtener_Servicio(ByVal suc As Integer)
        DS_Obtener.Tables("Servicio_Obtener").Rows.Clear()
        Servicio_DS.Tables("ordentrabajo").Rows.Clear()
        Servicio_DS.Tables("Servicio_Obtener").Rows.Clear()
        Dim ds_servicio As DataSet = DAservicio.Servicio_Obterner_X_Sucursal_MDA(suc)
        If ds_servicio.Tables(0).Rows.Count <> 0 Then
            Dim cant_servicios As Integer = ds_servicio.Tables(0).Rows.Count
            Servicio_DS.Tables("Servicio_Obtener").Rows.Clear()
            Servicio_DS.Tables("Servicio_Obtener").Merge(ds_servicio.Tables(0))
            Servicio_DS.Tables("ordentrabajo").Rows.Clear()
            Servicio_DS.Tables("ordentrabajo").Merge(ds_servicio.Tables(1))
            'DS_Obtener.Tables("Servicio_Obtener").Merge(ds_servicio.Tables(0))
            'DG_Servicio.DataSource = DS_Obtener.Tables("Servicio_Obtener")
        End If
        If ds_servicio.Tables(1).Rows.Count <> 0 Then
            Servicio_DS.Tables("ordentrabajo").Rows.Clear()
            Servicio_DS.Tables("ordentrabajo").Merge(ds_servicio.Tables(1))
        End If

        pedidos_formato_estado()
    End Sub
    Private Sub Sucursales_Obtener()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        ComboBox_suc.DataSource = ds.Tables(0)
        ComboBox_suc.DisplayMember = "sucursal_nombre"
        ComboBox_suc.ValueMember = "sucursal_id"
        Obtenido = "si"


    End Sub
    Private Sub Button_Detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Detalle.Click
        If DG_Servicio.Rows.Count <> 0 Then
            serv_id = DG_Servicio.SelectedCells(0).Value
            Servicio_nuevo.Close()
            Servicio_nuevo.Cliente_ID = DG_Servicio.SelectedCells(1).Value
            Servicio_nuevo.serv_id = serv_id
            Servicio_nuevo.Show()
            'Me.Close()
        End If
    End Sub

    Private Sub ComboBox_suc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_suc.SelectedIndexChanged
        If Obtenido = "si" Then
            obtener_Servicio(ComboBox_suc.SelectedValue)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Anular.Click
        If DG_Servicio.Rows.Count <> 0 Then
            If DG_Servicio.CurrentRow.Cells("Servicio_Estado").Value = "PENDIENTE" Then

                Dim result As Integer = MessageBox.Show("¿Está seguro que desea Anular el Servicio?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    DAservicio.Servicio_ActualizarEstado(DG_Servicio.SelectedCells(0).Value, "ANULADO")
                    DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, DG_Servicio.SelectedCells(0).Value, Now, "ANULADO")
                End If
            Else
                MessageBox.Show("No se puede cambiar el estado del Servicio seleccionado", "Sistema de Gestión", MessageBoxButtons.OK)
            End If
            obtener_Servicio(ComboBox_suc.SelectedValue)
        End If
        
    End Sub

    Private Sub pedidos_formato_estado()
        'Dim style As New DataGridViewCellStyle
        'style.Font = New Font(DG_Servicio.Font, FontStyle.Bold)
        'DG_Servicio.Columns("Servicio_Estado").DefaultCellStyle = style

        'If DG_Servicio.Rows.Count <> 0 Then
        '    Dim i As Integer = 0
        '    While i < DG_Servicio.Rows.Count
        '        Dim estado As String = DG_Servicio.Rows(i).Cells("Servicio_Estado").Value
        '        If estado = "PENDIENTE" Then
        '            DG_Servicio.Rows(i).Cells("Servicio_Estado").Style.ForeColor = Color.YellowGreen

        '        End If
        '        If estado = "FINALIZADO" Then
        '            DG_Servicio.Rows(i).Cells("Servicio_Estado").Style.ForeColor = Color.Green
        '        End If
        '        If estado = "ANULADO" Then
        '            DG_Servicio.Rows(i).Cells("Servicio_Estado").Style.ForeColor = Color.Red
        '        End If
        '        i = i + 1
        '    End While
        'End If

        'Dim style2 As New DataGridViewCellStyle
        'style2.Font = New Font(DG_OrdenTrabajo.Font, FontStyle.Bold)
        'DG_OrdenTrabajo.Columns("ServicioEstado").DefaultCellStyle = style2
        'If DG_OrdenTrabajo.Rows.Count <> 0 Then
        '    Dim i As Integer = 0
        '    While i < DG_OrdenTrabajo.Rows.Count
        '        Dim estado As String = DG_OrdenTrabajo.Rows(i).Cells("ServicioEstado").Value
        '        If estado = "PENDIENTE" Then
        '            DG_OrdenTrabajo.Rows(i).Cells("ServicioEstado").Style.ForeColor = Color.YellowGreen
        '            DG_OrdenTrabajo.Rows(i).Cells("ServicioEstado").Style.SelectionForeColor = Color.YellowGreen

        '        End If
        '        If estado = "FINALIZADO" Then
        '            DG_OrdenTrabajo.Rows(i).Cells("ServicioEstado").Style.ForeColor = Color.Green
        '            DG_OrdenTrabajo.Rows(i).Cells("ServicioEstado").Style.SelectionForeColor = Color.Green
        '        End If
        '        If estado = "ANULADO" Then
        '            DG_OrdenTrabajo.Rows(i).Cells("ServicioEstado").Style.ForeColor = Color.Red
        '            DG_OrdenTrabajo.Rows(i).Cells("ServicioEstado").Style.SelectionForeColor = Color.Red
        '        End If
        '        i = i + 1
        '    End While
        'End If

    End Sub

    Private Sub DG_Servicio_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DG_Servicio.CellFormatting
        If DG_Servicio.Columns(e.ColumnIndex).Name = "Servicio_Estado" Then
            Dim estado As String = e.Value
            Select Case estado
                Case "PENDIENTE"
                    e.CellStyle.ForeColor = Color.DarkOrange
                    e.CellStyle.SelectionForeColor = Color.DarkOrange
                Case "ASIGNADO"
                    e.CellStyle.ForeColor = Color.Blue
                    e.CellStyle.SelectionForeColor = Color.Blue
                Case "REPARADO"
                    e.CellStyle.ForeColor = Color.Black
                    e.CellStyle.SelectionForeColor = Color.Black
                Case "FINALIZADO"
                    e.CellStyle.ForeColor = Color.Green
                    e.CellStyle.SelectionForeColor = Color.Green
                    'e.CellStyle.Font.Bold = True
                Case "ANULADO"
                    e.CellStyle.ForeColor = Color.Red
                    e.CellStyle.SelectionForeColor = Color.Red
                    'e.CellStyle.Font.Bold = True
            End Select
        End If
    End Sub

    Private Sub DG_Servicio_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DG_Servicio.ColumnHeaderMouseClick
        'pedidos_formato_estado()
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If ComboBox_buscar.SelectedIndex = 1 Then 'cliente
            Dim Filtro
            Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_fan", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            ServicioObtenerBindingSource.Filter = Filtro
            pedidos_formato_estado()
        Else
            Dim Filtro
            'Filtro = String.Format("{0} = {1}", "Servicio_id", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            Filtro = String.Format("CONVERT(Servicio_id, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            ServicioObtenerBindingSource.Filter = Filtro
            pedidos_formato_estado()
        End If
    End Sub

  
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DG_OrdenTrabajo.Rows.Count <> 0 Then
            serv_id = DG_OrdenTrabajo.CurrentRow.Cells("ServicioidDataGridViewTextBoxColumn1").Value
            Servicio_nuevo.Close()
            Servicio_nuevo.Cliente_ID = DG_OrdenTrabajo.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn1").Value
            Servicio_nuevo.serv_id = serv_id
            Servicio_nuevo.Show()
            'Me.Close()
        End If

        

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If ComboBox1.SelectedIndex = 1 Then 'cliente
            Dim Filtro
            Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_fan", TextBox2.Text) 'esto para campos strings, FUNCIONA PERFECTO
            OrdentrabajoBindingSource.Filter = Filtro
            pedidos_formato_estado()
        Else
            Dim Filtro
            'Filtro = String.Format("{0} = {1}", "Servicio_id", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            Filtro = String.Format("CONVERT(Orden_trabajo_id, System.String) LIKE '%{0}%'", TextBox2.Text) 'esto para campos strings, FUNCIONA PERFECTO
            OrdentrabajoBindingSource.Filter = Filtro
            pedidos_formato_estado()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DG_OrdenTrabajo.CurrentRow.Cells("ServicioEstado").Value <> "FINALIZADO" Then
            Dim result As Integer = MessageBox.Show("¿Está seguro que desea Anular el Servicio?", "Sistema de Gestión", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DAservicio.Servicio_ActualizarEstado(DG_OrdenTrabajo.CurrentRow.Cells("ServicioidDataGridViewTextBoxColumn1").Value, "ANULADO")
                DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, DG_OrdenTrabajo.CurrentRow.Cells("ServicioidDataGridViewTextBoxColumn1").Value, Now, "ANULADO")
            End If
        Else
            MessageBox.Show("No se puede cambiar el estado del Servicio seleccionado", "Sistema de Gestión", MessageBoxButtons.OK)
        End If
        obtener_Servicio(ComboBox_suc.SelectedValue)
    End Sub

    Private Sub DG_OrdenTrabajo_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DG_OrdenTrabajo.CellFormatting
        If DG_OrdenTrabajo.Columns(e.ColumnIndex).Name = "ServicioEstado" Then
            Dim estado As String = e.Value
            Select Case estado
                Case "PENDIENTE"
                    e.CellStyle.ForeColor = Color.DarkOrange
                    e.CellStyle.SelectionForeColor = Color.DarkOrange
                Case "ASIGNADO"
                    e.CellStyle.ForeColor = Color.Blue
                    e.CellStyle.SelectionForeColor = Color.Blue
                Case "REPARADO"
                    e.CellStyle.ForeColor = Color.Black
                    e.CellStyle.SelectionForeColor = Color.Black
                Case "FINALIZADO"
                    e.CellStyle.ForeColor = Color.Green
                    e.CellStyle.SelectionForeColor = Color.Green
                    'e.CellStyle.Font.Bold = True
                Case "ANULADO"
                    e.CellStyle.ForeColor = Color.Red
                    e.CellStyle.SelectionForeColor = Color.Red
                    'e.CellStyle.Font.Bold = True
            End Select
        End If
    End Sub

End Class