'Imports System.IO
'Imports System.Data.OleDb
'Public Class Recepcion_gestion

'    Dim DAproveedores As New Datos.Proveedor
'    Dim DArecepcion As New Datos.Recepcion
'    Dim DAmarca As New Datos.Marca

'#Region "CARGA DE COMBOS AL INICIO DEL FORM"
'    Public Sub Generar_cod_interno()
'        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
'        Dim ds_generar As DataSet = DArecepcion.Recepcion_obtener_todo()
'        If ds_generar.Tables(0).Rows.Count <> 0 Then
'            lb_codigo.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("RECEPCION_codigo") + 1
'            tx_codproducto.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("RECEPCION_codigoproducto") + 1
'        Else
'            lb_codigo.Text = "1"
'            tx_codproducto.Text = "100"
'        End If
'    End Sub
'    Dim ds_proveedor As New DataSet
'    Public Sub Cargarcombo_proveedor()
'        ds_proveedor = DAproveedores.Proveedor_obtener
'        'Cargar Proveedor
'        cb_proveedores.DataSource = ds_proveedor.Tables(0)
'        cb_proveedores.DisplayMember = "Prov_nombre"
'        cb_proveedores.ValueMember = "Prov_id"
'        cb_proveedores.SelectedValue = ds_proveedor.Tables(0).Rows(0).Item("Prov_id")
'    End Sub
'    Dim ds_marca As New DataSet
'    Public Sub Cargarcombo_marca()
'        'Cargar la Marca
'        ds_marca = DAmarca.Marca_obtener
'        cb_marca.DataSource = ds_marca.Tables(0)
'        cb_marca.DisplayMember = "Marca_nom"
'        cb_marca.ValueMember = "Marca_id"
'        cb_marca.SelectedValue = ds_marca.Tables(0).Rows(0).Item("Marca_id")
'    End Sub
'    Dim ds_tipoproducto As New DataSet
'    Public Sub Cargarcombo_tipoproducto()
'        'Cargar la Marca
'        ds_tipoproducto = DArecepcion.ProductoTipo_obtener()
'        cb_tipoproducto.DataSource = ds_tipoproducto.Tables(0)
'        cb_tipoproducto.DisplayMember = "PROD_T_nom"
'        cb_tipoproducto.ValueMember = "PROD_T_id"
'        cb_tipoproducto.SelectedValue = ds_tipoproducto.Tables(0).Rows(0).Item("PROD_T_id")
'    End Sub
'#End Region

'    Private Sub Recepcion_gestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Generar_cod_interno()
'        Cargarcombo_proveedor()
'        Cargarcombo_marca()
'        Cargarcombo_tipoproducto()
'    End Sub

'    Private Sub BO_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_registrar.Click

'        Dim valida As String = "No"
'        Validar_producto(valida)


'        If valida = "Si" Then
'            Dim result As DialogResult
'            result = MessageBox.Show("¿Desea registrar la nueva recepción?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
'            If result = DialogResult.OK Then

'                Dim condicion As String = ""
'                If RB_ambiente.Checked = True Then
'                    condicion = "Ambiente"
'                End If
'                If RB_freezer.Checked = True Then
'                    condicion = "Freezer"
'                End If
'                If RB_heladera.Checked = True Then
'                    condicion = "Heladera"
'                End If


'                DArecepcion.Recepcion_alta(lb_codigo.Text,
'                                        DateTime_fechsistema.Value, tx_codproducto.Text,
'                                        tx_nombreproducto.Text, cb_tipoproducto.SelectedValue,
'                                         tx_nrolote.Text, condicion,
'                                         tx_cantidad.Text, DateTime_fechvto.Value, cb_marca.SelectedValue,
'                                         tx_nrofactura.Text, DateTime_fechfactura.Text, cb_proveedores.SelectedValue)

'                MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")

'                limpiar_deshabilitar()
'                Generar_cod_interno()

'            End If
'        End If



'    End Sub

'    Private Sub Validar_producto(ByRef valida As String)
'        If tx_nombreproducto.Text <> "" Then
'            If tx_nrolote.Text <> "" Then
'                If tx_cantidad.Text <> "" Or tx_cantidad.Text = "0" Then
'                    If tx_nrofactura.Text <> "" Then 'validar q no existe ese nro de factura????????????????????????????????????????????????
'                        'valido nro de factura
'                        Dim ds_recepciones As DataSet = DArecepcion.Recepcion_obtener_todo()


'                        Dim encontrado As String = "no"
'                        Dim i As Integer = 0
'                        While i < ds_recepciones.Tables(0).Rows.Count <> 0

'                            If ds_recepciones.Tables(0).Rows(i).Item("RECEPCION_nrofactura") = tx_nrofactura.Text Then
'                                encontrado = "si"
'                            End If
'                            i = i + 1
'                        End While

'                        If encontrado = "no" Then

'                            '////////////////////VALIDACION APROBADA//////////////
'                            valida = "Si"
'                            '/////////////////////////////////////////////////////


'                        Else
'                            MessageBox.Show("Modifique el Número de factura, ya existe una factura con ese numero", "Sistema de Gestion.")
'                            tx_nrofactura.Focus()
'                            tx_nrofactura.SelectAll()
'                        End If





'                    Else
'                        MessageBox.Show("Complete la información (Número de factura)", "Sistema de Gestion.")
'                        tx_nrofactura.Focus()
'                        tx_nrofactura.SelectAll()
'                    End If
'                Else
'                    MessageBox.Show("Complete la información (cantidad de unid. del producto)", "Sistema de Gestion.")
'                    tx_cantidad.Focus()
'                    tx_cantidad.SelectAll()
'                End If
'            Else
'                MessageBox.Show("Complete la información (Número de lote)", "Sistema de Gestion.")
'                'ERROR_tx_descripcion.Visible = True
'                tx_nrolote.Focus()
'                tx_nrolote.SelectAll()
'            End If
'        Else
'            MessageBox.Show("Complete la informacion (Nombre del producto)", "Sistema de Gestion.")
'            'ERROR_tx_codinterno.Visible = True
'            tx_nombreproducto.Focus()
'            tx_nombreproducto.SelectAll()
'        End If
'    End Sub

'    Private Sub limpiar_deshabilitar()
'        'aqui limpiamos los textbox una vez q guardo, o bien si cancelo la registracion en curso
'        tx_codproducto.Clear()
'        tx_nombreproducto.Clear()
'        tx_nrolote.Clear()
'        tx_cantidad.Text = "1"
'        tx_nrofactura.Clear()
'        RB_ambiente.Checked = True
'    End Sub

'    Private Sub BO_cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
'        limpiar_deshabilitar()
'        Generar_cod_interno()
'    End Sub
'End Class