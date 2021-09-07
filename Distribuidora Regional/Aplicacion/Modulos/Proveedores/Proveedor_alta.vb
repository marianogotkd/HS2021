Public Class Proveedor_alta
    Dim DAproveedor As New Datos.Proveedor


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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

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
        If form_inicio = "producto_alta" Then
            Producto_alta.Cargarcombo_proveedor()
            Me.Close()
        Else
            If form_inicio = "producto_modificar" Then
                Producto_modificar.Cargarcombo_proveedor()
                Me.Close()
            End If

        End If

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

    End Sub
    Dim form_inicio As String = ""
    Public Sub Origen_alta(ByRef inicio As String)
        form_inicio = inicio
    End Sub

    Private Sub Proveedor_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Focus()
        Me.tx_codinterno.Focus()
        Me.tx_codinterno.SelectAll()
    End Sub
End Class