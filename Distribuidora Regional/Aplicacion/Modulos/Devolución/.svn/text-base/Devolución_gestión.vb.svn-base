Imports System.IO
Imports System.Data.OleDb
Public Class Devolución_gestión
    Dim DAdevolucion As New Datos.Devolucion
    Dim DAventa As New Datos.Venta_regional
    Dim DAProductos As New Datos.Producto
    'Dim ds_devolucion As DataSet

    Private Sub BO_Buscar_Cod_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_Cod.Click

        Buscar_Producto_Lote()

        'Buscar_factura()
    End Sub

    Private Sub Buscar_Producto_Lote()
        If tx_CodProd.Text <> "" And Tx_CodLte.Text <> "" Then
            Dim DS As New DataSet
            DS = DAdevolucion.Devolucion_ObtenerProd_Por_CodyLte(tx_CodProd.Text, Tx_CodLte.Text)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.DataSource = DS.Tables(0)

            If DataGridView1.Rows.Count <> 0 Then

                BO_Buscar_Cod.Visible = False
                tx_CodProd.Enabled = False
                Tx_CodLte.Enabled = False
                BO_Cargar.Visible = True

            Else

                MessageBox.Show("No se Encontro Ningun Producto", "Sistema de Gestion.", MessageBoxButtons.OK)
                Tx_CodLte.Text = ""
                tx_CodProd.Text = ""
                tx_CodProd.Focus()

            End If

        Else
            MessageBox.Show("Complete los Datos en los 2 Campos", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If
    End Sub

    'Private Sub Buscar_factura()
    '    If tx_CodProd.Text <> "" Then
    '        'Me.DataGrid_Productos.Rows.Clear()

    '        Dim DS As New DataSet
    '        ds_devolucion = DAdevolucion.Recepcion_obtener_Por_Fac(tx_CodProd.Text)
    '        DataGrid_Productos.DataSource = ds_devolucion.Tables(0)

    '    End If
    'End Sub


    Public Sub Generar_cod_interno()

        Dim ds_generar As DataSet = DAdevolucion.Devolucion_obtener_todo()
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            Lb_cod_dev.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("Dev_codigo") + 1
        Else
            Lb_cod_dev.Text = "1"
        End If
    End Sub

   

    'Private Sub BO_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_registrar.Click

    '    If DataGrid_Productos.Rows.Count <> 0 Then
    '        If Tx_entidad.Text <> "" Then
    '            ERROR_tx_entidad.Visible = False

    '            Dim result As DialogResult
    '            result = MessageBox.Show("¿Desea registrar la devolucion?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
    '            If result = DialogResult.OK Then

    '                'Devolucion ALTA  //////////////////////////////////////////////////////////////////////////////////////////
    '                Dim ds_dev As DataSet
    '                ds_dev = DAdevolucion.Devolucion_alta("Proveedor", Lb_cod_dev.Text, Tx_motivo.Text, Tx_entidad.Text, DT_fecha.Value)
    '                Dim Dev_id As Integer = ds_dev.Tables(0).Rows(0).Item(0)

    '                'DevolucionDetalle Alta
    '                For Each row As DataGridViewRow In DataGrid_Productos.Rows
    '                    DAdevolucion.DevolucionDetalle_alta(row.Cells("RECEPCIONidDataGridViewTextBoxColumn").Value, Dev_id, row.Cells("RECEPCIONcantidadDataGridViewTextBoxColumn").Value)
    '                    DAventa.Venta_modificar_recepcion(row.Cells("RECEPCIONidDataGridViewTextBoxColumn").Value, row.Cells("RECEPCIONcantidadDataGridViewTextBoxColumn").Value, "Devuelto")
    '                Next

    '                MessageBox.Show("Se Cargo Correctamente la devolucion.", "Sistema de Gestion.")


    '                Dim resulta As DialogResult
    '                resulta = MessageBox.Show("¿Desea ver el informe?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
    '                If resulta = DialogResult.OK Then


    '                    Dim ds_informe As DataSet = DAdevolucion.Devolucion_informe(Dev_id)
    '                    If ds_informe.Tables(0).Rows.Count > 0 Then
    '                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
    '                        CrReport.Load(Application.StartupPath & "\..\..\Informe Regional\CR_Informe_devolucion.rpt")

    '                        CrReport.Database.Tables("Devolucion").SetDataSource(ds_informe.Tables(0))
    '                        CrReport.Database.Tables("Devolucion_detalle").SetDataSource(ds_informe.Tables(1))
    '                        'CrReport.SetDataSource(ds_Jugador.Tables(0))
    '                        Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
    '                        'ERROR_Socio.Visible = False
    '                        Informe_Mostrar.Show()
    '                    End If
    '                End If

    '                limpiar_deshabilitar()
    '                Generar_cod_interno()
    '            End If
    '        Else
    '            MessageBox.Show("Complete la información", "Sistema de Gestion.")
    '            ERROR_tx_entidad.Visible = True
    '            Tx_entidad.Focus()
    '            Me.Devolucion.SelectedTab = TabPage0
    '        End If
    '    Else
    '        MessageBox.Show("Realice la buscada de alguna factura", "Sistema de Gestion.")
    '        tx_CodProd.Focus()
    '    End If
    'End Sub

    'Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
    '    limpiar_deshabilitar()
    '    Me.Devolucion.SelectedTab = TabPage0
    '    BO_registrar.Enabled = True
    '    Bo_cancelar.Enabled = True
    'End Sub

    Public Sub limpiar_deshabilitar()

        'botones de error
        ERROR_tx_entidad.Visible = False
        BO_Buscar_Cod.Visible = True
        BO_Cargar.Visible = False

        'datos 
        Tx_entidad.Text = ""
        Tx_motivo.Text = ""
        DT_fecha.Value = Today
        tx_CodProd.Text = ""
        DataGridView1.DataSource = ""
        tx_CodProd.Enabled = True
        Tx_CodLte.Enabled = True
        Tx_CodLte.Text = ""


    End Sub

    Private Sub tx_Numfac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_CodProd.KeyPress
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
        'If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
        '    Buscar_factura()
        'End If
    End Sub

    
    Private Sub Devolución_gestión_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Generar_cod_interno()
        Combo_Stock.SelectedIndex = 1

    End Sub

    Private Sub BO_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_registrar.Click

        If DataGridView1.Rows.Count <> 0 Then
            If tx_Cant.Text <> "" Then
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea registrar la devolucion?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then

                    Dim ds_dev2 As DataSet
                    Dim DS2 As New DataSet
                    Dim var As Integer
                    Dim presentacion As String
                    Dim nombre As String

                    DS2 = DAdevolucion.Devolucion_ObtenerProd_Por_CodyLte(tx_CodProd.Text, Tx_CodLte.Text)
                    var = (DS2.Tables(0).Rows(0).Item(5)) - (tx_Cant.Text)
                    presentacion = DS2.Tables(0).Rows(0).Item(11)
                    nombre = DS2.Tables(0).Rows(0).Item(2)
                    If var >= 0 Then
                        If Combo_Stock.SelectedIndex = 0 Then

                            ds_dev2 = DAdevolucion.ProdDetalle_modificar(var, "Stock", (DS2.Tables(0).Rows(0).Item(10)), Tx_CodLte.Text)
                        End If
                        'Devolucion ALTA  ////////////////////////////////////////////////////////////////////////


                        Dim ds_dev As DataSet
                        ds_dev = DAdevolucion.Devolucion_alta(Lb_cod_dev.Text, Tx_motivo.Text, Tx_entidad.Text, DT_fecha.Value, tx_Cant.Text, tx_CodProd.Text, Tx_CodLte.Text, presentacion, nombre)
                        '                Dim Dev_id As Integer = ds_dev.Tables(0).Rows(0).Item(0)

                        MessageBox.Show("Se Cargo Correctamente la devolucion.", "Sistema de Gestion.")

                        limpiar_deshabilitar()
                        Generar_cod_interno()
                    Else
                        MessageBox.Show("La Cantidad Ingresada no es Correcta", "Sistema de Gestion.")
                        tx_Cant.Focus()
                    End If


                End If

            Else
                MessageBox.Show("La Cantidad Ingresada no es Correcta", "Sistema de Gestion.")
                tx_Cant.Focus()
            End If
        Else
            MessageBox.Show("Verifique la Existencia del Producto", "Sistema de Gestion.")
            tx_CodProd.Focus()
        End If

    End Sub

    Private Sub BO_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cargar.Click
        tx_CodProd.Enabled = True
        Tx_CodLte.Enabled = True
        Tx_CodLte.Text = ""
        tx_CodProd.Text = ""
        BO_Buscar_Cod.Visible = True
        BO_Cargar.Visible = False

    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        limpiar_deshabilitar()

    End Sub

 
End Class