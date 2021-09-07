Public Class Proveedor_modificar

    Dim DAproveedor As New Datos.Proveedor

    Dim busqueda As String = ""
    Dim busqueda_parametro As String = ""
    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAproveedor.Proveedor_obtener_todo()
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            tx_codinterno.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item(1) + 1
        Else
            tx_codinterno.Text = "1"
        End If
    End Sub
    Private Sub buscar_codinterno()
        If tx_cod_modif.Text <> "" Then
            Me.DataGrid_proveedor.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproveedor.Proveedor_buscarcod(Me.tx_cod_modif.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DataGrid_proveedor.Rows().Add()
                    DataGrid_proveedor.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DataGrid_proveedor.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(1) 'cod interno
                    DataGrid_proveedor.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(2) 'nombre
                    DataGrid_proveedor.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(3) 'responsable
                    DataGrid_proveedor.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(4) 'direccion
                    DataGrid_proveedor.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(5) 'telefono
                    DataGrid_proveedor.Rows(fila).Cells(6).Value = DS.Tables(0).Rows(fila).Item(6) 'celular
                    DataGrid_proveedor.Rows(fila).Cells(7).Value = DS.Tables(0).Rows(fila).Item(7) 'mail
                    DataGrid_proveedor.Rows(fila).Cells(8).Value = DS.Tables(0).Rows(fila).Item(8) 'observacion

                    fila = fila + 1
                End While
                busqueda = "COD INTERNO"
                busqueda_parametro = tx_cod_modif.Text
            End If
            Me.tx_cod_modif.Select()
        Else
            Me.DataGrid_proveedor.Rows.Clear()
        End If
    End Sub

    Private Sub BO_Buscar_dni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_Cod.Click
        buscar_codinterno()
    End Sub

    Private Sub BO_buscar_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar_nom.Click
        If tx_nombre_modif.Text <> "" Then
            Me.DataGrid_proveedor.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproveedor.Proveedor_buscarnom(Me.tx_nombre_modif.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DataGrid_proveedor.Rows().Add()
                    DataGrid_proveedor.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DataGrid_proveedor.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(1) 'cod interno
                    DataGrid_proveedor.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(2) 'nombre
                    DataGrid_proveedor.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(3) 'responsable
                    DataGrid_proveedor.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(4) 'direccion
                    DataGrid_proveedor.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(5) 'telefono
                    DataGrid_proveedor.Rows(fila).Cells(6).Value = DS.Tables(0).Rows(fila).Item(6) 'celular
                    DataGrid_proveedor.Rows(fila).Cells(7).Value = DS.Tables(0).Rows(fila).Item(7) 'mail
                    DataGrid_proveedor.Rows(fila).Cells(8).Value = DS.Tables(0).Rows(fila).Item(8) 'observaciones

                    fila = fila + 1
                End While
                busqueda = "NOMBRE"
                busqueda_parametro = tx_nombre_modif.Text
            End If
            Me.tx_nombre_modif.Select()
        Else
            actualizar_todo()
            Me.tx_nombre_modif.Select()

        End If
    End Sub

    Public Sub actualizar_por_codigo()
        Me.DataGrid_proveedor.Rows.Clear()
        Dim DS As New DataSet
        DS = DAproveedor.Proveedor_buscarcod(busqueda_parametro)
        If DS.Tables(0).Rows.Count <> 0 Then
            Dim fila As Integer = 0
            While fila < DS.Tables(0).Rows.Count
                Me.DataGrid_proveedor.Rows().Add()
                DataGrid_proveedor.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                DataGrid_proveedor.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(1) 'cod interno
                DataGrid_proveedor.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(2) 'nombre
                DataGrid_proveedor.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(3) 'responsable
                DataGrid_proveedor.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(4) 'direccion
                DataGrid_proveedor.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(5) 'telefono
                DataGrid_proveedor.Rows(fila).Cells(6).Value = DS.Tables(0).Rows(fila).Item(6) 'celular
                DataGrid_proveedor.Rows(fila).Cells(7).Value = DS.Tables(0).Rows(fila).Item(7) 'mail
                DataGrid_proveedor.Rows(fila).Cells(8).Value = DS.Tables(0).Rows(fila).Item(8) 'observaciones


                fila = fila + 1
            End While
        End If
    End Sub

    Public Sub actualizar_por_nombre()
        Me.DataGrid_proveedor.Rows.Clear()
        Dim DS As New DataSet
        DS = DAproveedor.Proveedor_buscarnom(busqueda_parametro)
        If DS.Tables(0).Rows.Count <> 0 Then
            Dim fila As Integer = 0
            While fila < DS.Tables(0).Rows.Count
                Me.DataGrid_proveedor.Rows().Add()
                DataGrid_proveedor.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                DataGrid_proveedor.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(1) 'cod interno
                DataGrid_proveedor.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(2) 'nombre
                DataGrid_proveedor.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(3) 'responsable
                DataGrid_proveedor.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(4) 'direccion
                DataGrid_proveedor.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(5) 'telefono
                DataGrid_proveedor.Rows(fila).Cells(6).Value = DS.Tables(0).Rows(fila).Item(6) 'celular
                DataGrid_proveedor.Rows(fila).Cells(7).Value = DS.Tables(0).Rows(fila).Item(7) 'mail
                DataGrid_proveedor.Rows(fila).Cells(8).Value = DS.Tables(0).Rows(fila).Item(8) 'observaciones
                fila = fila + 1
            End While
        End If

    End Sub


    Public Sub actualizar_todo()
        Me.DataGrid_proveedor.Rows.Clear()
        Dim DS As New DataSet
        DS = DAproveedor.Proveedor_obtener_todo()
        If DS.Tables(0).Rows.Count <> 0 Then
            Dim fila As Integer = 0
            While fila < DS.Tables(0).Rows.Count
                Me.DataGrid_proveedor.Rows().Add()
                DataGrid_proveedor.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                DataGrid_proveedor.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(1) 'cod interno
                DataGrid_proveedor.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(2) 'nombre
                DataGrid_proveedor.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(3) 'responsable
                DataGrid_proveedor.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(4) 'direccion
                DataGrid_proveedor.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(5) 'telefono
                DataGrid_proveedor.Rows(fila).Cells(6).Value = DS.Tables(0).Rows(fila).Item(6) 'celular
                DataGrid_proveedor.Rows(fila).Cells(7).Value = DS.Tables(0).Rows(fila).Item(7) 'mail
                DataGrid_proveedor.Rows(fila).Cells(8).Value = DS.Tables(0).Rows(fila).Item(8) 'observaciones
                fila = fila + 1
            End While
        End If

    End Sub

    Private Sub BO_empleado_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_proveedor_modificar.Click
        VarElec = "modificar"

        If Me.DataGrid_proveedor.CurrentRow IsNot Nothing Then

            Dim codselec As String = DataGrid_proveedor.SelectedCells(1).Value
            If codselec <> "" Then
                tx_codinterno.Text = DataGrid_proveedor.SelectedCells(1).Value
                tx_nombre.Text = DataGrid_proveedor.SelectedCells(2).Value
                Me.TabControl1.SelectedTab = TabPage2

                GP_proveedor.Enabled = True 'datos proveedor
                recuperar_datos_cliente()
                GroupBox1.Enabled = False 'grupo de busqueda
                Bo_guardar.Enabled = True
                Bo_cancelar.Enabled = True
            Else
                MsgBox("Seleccione un proveedor", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un proveedor", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub recuperar_datos_cliente()
        'PESTAÑA proveedor//////////////////////////////////////////////////////////////////////////////////
        Dim ds_proveedor As New DataSet
        ds_proveedor = DAproveedor.Proveedor_obtenerDatos(tx_codinterno.Text, tx_nombre.Text)

        'cargo en los textbox los datos recuperados

        'responsable
        tx_responsable.Text = ds_proveedor.Tables(0).Rows(0).Item(3)
        'direccion
        tx_direccion.Text = ds_proveedor.Tables(0).Rows(0).Item(4)
        'telefono
        tx_telefono.Text = ds_proveedor.Tables(0).Rows(0).Item(5)
        'celular
        tx_celular.Text = ds_proveedor.Tables(0).Rows(0).Item(6)
        'correo electronico
        tx_mail.Text = ds_proveedor.Tables(0).Rows(0).Item(7)
        'observaciones
        tx_obs.Text = ds_proveedor.Tables(0).Rows(0).Item(8)

    End Sub

    Private Sub Limpiar_box_btn()

        tx_codinterno.Clear()
        tx_nombre.Clear()
        tx_responsable.Clear()
        tx_direccion.Clear()
        tx_telefono.Clear()
        tx_celular.Clear()
        tx_mail.Clear()
        tx_obs.Clear()

        ERROR_tx_codinterno.Visible = False
        ERROR_tx_nombre.Visible = False

        Me.tx_codinterno.Focus()

        Bo_guardar.Enabled = False
        Bo_cancelar.Enabled = False

        GroupBox1.Enabled = True

        Me.TabControl1.SelectedTab = TabPage1
        Me.GP_proveedor.Enabled = False


    End Sub

    Private Sub validar_guardar(ByRef valido As String)

        If tx_codinterno.Text <> "" Then
            If tx_nombre.Text <> "" Then
                valido = "SI"
            Else

                MessageBox.Show("Complete la información", "Sistema de Gestion.")
                ERROR_tx_nombre.Visible = True
                tx_nombre.Focus()
            End If
        Else

            MessageBox.Show("Complete la información", "Sistema de Gestion.")
            ERROR_tx_codinterno.Visible = True
            tx_nombre.Focus()
        End If

    End Sub

    Dim VarElec As String
    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        If VarElec = "nuevo" Then
            Guardar_Nuevo()

        Else
            Guardar_modificar()

        End If

        Recepcion_nuevo_diseño.Cargarcombo_proveedor()

    End Sub

    Public Sub Guardar_nuevo()

        Dim valido As String = "NO"
        validar_guardar(valido)

        If valido = "SI" Then
            'aqui pregunto
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea agregar el Proveedor?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then


                Dim buscar_proveedor As New DataSet
                buscar_proveedor = DAproveedor.Proveedor_buscar(tx_codinterno.Text, tx_nombre.Text)
                If buscar_proveedor.Tables(0).Rows.Count = 0 And buscar_proveedor.Tables(1).Rows.Count = 0 Then
                    'si no existe guardo

                    DAproveedor.Proveedor_Alta(tx_codinterno.Text, tx_nombre.Text, tx_responsable.Text, tx_direccion.Text, tx_telefono.Text, tx_celular.Text, tx_mail.Text, tx_obs.Text)

                    MessageBox.Show("El Proveedor fue agregado correctamente.", "Sistema de Gestion.")

                    'borrar textbox y ocultar los botones de error
                    Limpiar_box_btn()
                Else
                    MessageBox.Show("Ya se encuentra agregado, corrija la informacion", "Sistema de Gestion.")
                    ERROR_tx_codinterno.Visible = True
                    ERROR_tx_nombre.Visible = True
                    tx_codinterno.Focus()
                End If
            End If

        End If
        If busqueda = "COD INTERNO" Then
            'actualizo grilla x dni
            actualizar_por_codigo()
        Else
            If busqueda = "NOMBRE" Then
                'actualizo grilla x nombre
                actualizar_por_nombre()
            Else
                actualizar_todo()
            End If

        End If
        'If form_inicio = "producto_alta" Then
        '    Producto_alta.Cargarcombo_proveedor()
        '    Me.Close()
        'Else
        '    If form_inicio = "producto_modificar" Then
        '        Producto_modificar.Cargarcombo_proveedor()
        '        Me.Close()
        '    End If

        'End If

    End Sub
    Public Sub Guardar_modificar()
        Dim valido As String = "NO"
        validar_guardar(valido)

        If valido = "SI" Then
            'aqui pregunto
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea modificar el Proveedor?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then


                Dim buscar_proveedor As New DataSet
                buscar_proveedor = DAproveedor.Proveedor_buscar(tx_codinterno.Text, tx_nombre.Text)
                If buscar_proveedor.Tables(0).Rows.Count <> 0 And buscar_proveedor.Tables(1).Rows.Count <> 0 Then 'si lo encuentro edito
                    'si existe guardo
                    Dim prov_cod As String = DataGrid_proveedor.CurrentRow.Cells(1).Value
                    Dim prov_nombre As String = DataGrid_proveedor.CurrentRow.Cells(2).Value
                    DAproveedor.Proveedor_modificar(prov_cod, prov_nombre, tx_responsable.Text, tx_direccion.Text, tx_telefono.Text, tx_celular.Text, tx_mail.Text, tx_obs.Text)
                    MessageBox.Show("El proveedor se modifico correctamente", "Sistema de Gestion")

                    'borrar textbox y ocultar los botones de error
                    Limpiar_box_btn()

                    If busqueda = "COD INTERNO" Then
                        'actualizo grilla x dni
                        actualizar_por_codigo()
                    Else
                        If busqueda = "NOMBRE" Then
                            'actualizo grilla x nombre
                            actualizar_por_nombre()
                        Else
                            actualizar_todo()
                        End If

                    End If


                End If
            End If
        End If
    End Sub

    Private Sub tx_codinterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_codinterno.KeyPress
        If VarElec = "modificar" Then
            e.Handled = True
        End If
    End Sub

    Private Sub tx_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_nombre.KeyPress
        If VarElec = "modificar" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        Limpiar_box_btn()
    End Sub

    Private Sub tx_cod_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_cod_modif.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_codinterno()
        End If
    End Sub

    Private Sub tx_cod_modif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_cod_modif.TextChanged
        If tx_cod_modif.Text = Nothing Then
            BO_Buscar_Cod.Enabled = False
        Else
            BO_Buscar_Cod.Enabled = True
        End If
    End Sub

    Private Sub Proveedor_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BO_Buscar_Cod.Enabled = False
        Generar_cod_interno()
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        Generar_cod_interno()
        'Btn_Nuevo.Enabled = False
        GP_proveedor.Enabled = True
        Bo_guardar.Enabled = True
        GroupBox1.Enabled = False 'grupo de busqueda
        Bo_guardar.Enabled = True
        Bo_cancelar.Enabled = True
        VarElec = "nuevo"
        TabControl1.SelectedTab = TabPage2
    End Sub


End Class