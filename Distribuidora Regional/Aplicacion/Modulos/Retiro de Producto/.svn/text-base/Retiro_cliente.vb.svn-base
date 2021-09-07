'Public Class Retiro_cliente
'    Dim DAretiro As New Datos.Retiro
'    Dim DAventa As New Datos.Venta_regional




'    Private Sub Retiro_cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Me.Focus()

'        Generar_cod_interno()
'    End Sub

'    Public Sub Generar_cod_interno()
'        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
'        Dim ds_generar As DataSet = DAretiro.Retiro_obtener_todo
'        If ds_generar.Tables(0).Rows.Count <> 0 Then
'            lb_codigo.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("Retiro_codigo") + 1
'        Else
'            lb_codigo.Text = "1"
'        End If
'    End Sub

'    Dim ds_recepciones As DataSet
'    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
'        Buscar_factura()
'    End Sub

'    Private Sub tx_busc_factura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_busc_factura.KeyPress
'        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
'            Buscar_factura()
'        End If
'    End Sub


'    Private Sub Buscar_factura()
'        If tx_busc_factura.Text <> "" Then
'            ds_recepciones = DAretiro.Retiro_Recepcion_obtener_Por_Fac_Venta(tx_busc_factura.Text)
'            If ds_recepciones.Tables(0).Rows.Count <> 0 Then
'                DataGridView1.DataSource = ds_recepciones.Tables(0)
'                GroupBox6.Text = "Productos de la factura: " + tx_busc_factura.Text
'            Else
'                DataGridView1.DataSource = ""
'                GroupBox6.Text = "Productos de la factura: "
'            End If
'        Else
'            DataGridView1.DataSource = ""
'            GroupBox6.Text = "Productos de la factura: "
'        End If
'    End Sub

'    Private Sub BO_cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
'        Limpiar_restablecer()
'    End Sub


'    Public Sub Limpiar_restablecer()
'        'GroupBox1.Enabled = True 'buscar cliente
'        'BO_Quitar.Enabled = False 'boton quitar
'        'BO_editar.Enabled = False 'boton editar
'        tx_busc_factura.Clear() 'textbox nombre de producto
'        Generar_cod_interno() 'genero nuevamente codigo nuevo de venta
'        tx_destino.Clear()
'        tx_motivo.Clear()
'        DateTime_fechsistema.Value = Today
'        DataGridView1.DataSource = ""

'    End Sub

'    Private Sub BO_guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_guardar.Click

'        'valido que este seleccionado por lo menos un producto de la grilla

'        Dim valido As String = "no"

'        Dim a As Integer = 0
'        While a < DataGridView1.Rows.Count
'            If DataGridView1.Rows(a).Cells(1).Value = True Then
'                valido = "si"

'            End If
'            a = a + 1
'        End While

'        If valido = "si" Then

'            If tx_destino.Text <> "" Then


'                '/////////////////////////////////////////GUARDO EN BASE DATOS////////////////////////////////////////////////////////////////////////////////////
'                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
'                'recupero todos los productos---para ver si resto stock o cambio de estado

'                Dim ds_venta As DataSet = DAretiro.Retiro_alta("Cliente", lb_codigo.Text, tx_motivo.Text, tx_destino.Text, DateTime_fechsistema.Value)
'                Dim retiro_id As Integer = ds_venta.Tables(0).Rows(0).Item("Retiro_id")
'                'ahora viene el alta del detalle de venta....
'                Dim i As Integer = 0
'                While i < DataGridView1.Rows.Count

'                    DAretiro.Retiro_detalle_alta(DataGridView1.Rows(i).Cells("RECEPCIONidDataGridViewTextBoxColumn").Value, retiro_id, DataGridView1.Rows(i).Cells("RECEPCIONcantidadDataGridViewTextBoxColumn").Value)
'                    DAventa.Venta_modificar_recepcion(DataGridView1.Rows(i).Cells("RECEPCIONidDataGridViewTextBoxColumn").Value, DataGridView1.Rows(i).Cells("RECEPCIONcantidadDataGridViewTextBoxColumn").Value, "Retirado")
'                    i = i + 1
'                End While
'                MessageBox.Show("Se registro correctamente", "Sistema de Gestion.")


'                Dim resulta As DialogResult
'                resulta = MessageBox.Show("¿Desea ver el informe?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
'                If resulta = DialogResult.OK Then


'                    Dim ds_informe As DataSet = DAretiro.Retiro_informe_cliente(retiro_id)
'                    If ds_informe.Tables(0).Rows.Count > 0 Then
'                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
'                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
'                        CrReport.Load(Application.StartupPath & "\..\..\Informe Regional\CR_Informe_retiro.rpt")

'                        CrReport.Database.Tables("Retiro").SetDataSource(ds_informe.Tables(0))
'                        CrReport.Database.Tables("Retiro_detalle").SetDataSource(ds_informe.Tables(1))
'                        'CrReport.SetDataSource(ds_Jugador.Tables(0))
'                        Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
'                        'ERROR_Socio.Visible = False
'                        Informe_Mostrar.Show()
'                    End If
'                End If


'                Limpiar_restablecer()
'                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
'                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
'                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

'            Else
'                MessageBox.Show("Error. ingrese el destino para registra", "Sistema de Gestion.")
'                tx_destino.SelectAll()
'                tx_destino.Focus()

'            End If
'        Else

'            MessageBox.Show("Error. seleccione un producto de la factura para registrar", "Sistema de Gestion.")
'            tx_busc_factura.SelectAll()
'            tx_busc_factura.Focus()
'        End If

'    End Sub

'    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
'        If e.ColumnIndex <> 1 Then Exit Sub
'        'primero quito la seleccion de los demas
'        Dim i = 0
'        'While i < DG_recepcion.Rows.Count
'        'DG_recepcion.Rows(i).Cells(1).Value = False
'        'i = i + 1
'        'End While
'        If e.RowIndex >= 0 Then
'            If DataGridView1.Rows(e.RowIndex).Cells(1).Value = True Then
'                DataGridView1.Rows(e.RowIndex).Cells(1).Value = False
'            Else
'                DataGridView1.Rows(e.RowIndex).Cells(1).Value = True
'            End If
'        End If
'    End Sub

'    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
'        'primero quito la seleccion de los demas
'        Dim i = 0
'        'While i < DG_recepcion.Rows.Count
'        '    DG_recepcion.Rows(i).Cells(1).Value = False
'        '    i = i + 1
'        'End While
'        If e.RowIndex >= 0 Then
'            If DataGridView1.Rows(e.RowIndex).Cells(1).Value = True Then
'                DataGridView1.Rows(e.RowIndex).Cells(1).Value = False
'            Else
'                DataGridView1.Rows(e.RowIndex).Cells(1).Value = True
'            End If
'        End If
'    End Sub
'End Class