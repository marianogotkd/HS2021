Public Class Marca_gestion
    Dim DAmarca As New Datos.Marca
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage2
        tx_nom_marca.Text = ""
        tx_nom_marca.SelectAll()
        tx_nom_marca.Focus()
        BO_Guardar.Enabled = True
        BO_Cancelar.Enabled = True
        operacion = "alta"
        GroupBox1.Enabled = False
    End Sub

    Private Sub Marca_gestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'recupero las marcas existentes
        recuperar_marcas_existentes()
    End Sub


    Dim ds_marcas As New DataSet
    Private Sub recuperar_marcas_existentes()
        ds_marcas = DAmarca.Marca_obtener()
        If ds_marcas.Tables(0).Rows.Count <> 0 Then
            DataGridView1.DataSource = ds_marcas.Tables(0)
        End If
    End Sub

    Private Sub BO_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cancelar.Click
        TabControl1.SelectedTab = TabPage1
        tx_codinterno.Visible = False
        Lb_codinterno.Visible = False
        GroupBox1.Enabled = True
        operacion = ""

        BO_Cancelar.Enabled = False
        BO_Guardar.Enabled = False



    End Sub

    Private Sub BO_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Guardar.Click
        'ALTA DE MARCA
        If operacion = "alta" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea agregar la nueva Marca?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                DAmarca.Marca_alta(tx_nom_marca.Text)
                'Producto_alta.Cargarcombo_marca()
                MessageBox.Show("La Marca fue agregada correctamente.", "Sistema de Gestion.")
                recuperar_marcas_existentes()
                TabControl1.SelectedTab = TabPage1
                BO_Cancelar.Enabled = False
                BO_Guardar.Enabled = False
                operacion = ""
                GroupBox1.Enabled = True


            End If
        End If

        'MODIFICARCION DE MARCA
        If operacion = "modificar" Then
            If tx_nom_marca.Text <> "" Then
                DAmarca.Marca_modificar(tx_codinterno.Text, tx_nom_marca.Text)
                MessageBox.Show("La Marca fue modificada correctamente.", "Sistema de Gestion.")
                recuperar_marcas_existentes()
                TabControl1.SelectedTab = TabPage1
                BO_Cancelar.Enabled = False
                BO_Guardar.Enabled = False
                operacion = ""
                tx_codinterno.Visible = False
                Lb_codinterno.Visible = False
                GroupBox1.Enabled = True

            Else
                MessageBox.Show("Error, ingrese un nombre en la marca.", "Sistema de Gestion.")
                tx_nom_marca.SelectAll()
                tx_nom_marca.Focus()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'primero quito la seleccion de los demas
        Dim i = 0
        While i < DataGridView1.Rows.Count
            DataGridView1.Rows(i).Cells(1).Value = False
            i = i + 1
        End While
        If DataGridView1.Rows(e.RowIndex).Cells(1).Value = True Then
            DataGridView1.Rows(e.RowIndex).Cells(1).Value = False
        Else
            DataGridView1.Rows(e.RowIndex).Cells(1).Value = True
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex <> 1 Then Exit Sub
        'primero quito la seleccion de los demas
        Dim i = 0
        While i < DataGridView1.Rows.Count
            DataGridView1.Rows(i).Cells(1).Value = False
            i = i + 1
        End While
        If DataGridView1.Rows(e.RowIndex).Cells(1).Value = True Then
            DataGridView1.Rows(e.RowIndex).Cells(1).Value = False
        Else
            DataGridView1.Rows(e.RowIndex).Cells(1).Value = True
        End If
    End Sub

    Private Sub TX_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_buscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            DataGridView1.DataSource = Nothing
            If TX_buscar.Text <> "" Then
                Filtrar_datatable(Me.TX_buscar.Text)
            Else
                DataGridView1.DataSource = ds_marcas.Tables(0)
            End If
        End If
    End Sub

    Public Sub Filtrar_datatable(ByVal parametro As String)
        If ds_marcas.Tables.Count <> 0 Then
            ''uso ds_marcas que trae las marcas buscadas en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("Marca_id")
            table_filtrada.Columns.Add("Marca_nom")
            table_filtrada.Rows.Clear()
            DataGridView1.DataSource = Nothing
            Dim table As DataTable = ds_marcas.Tables(0)
            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("Marca_nom")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                'If apellido = table.Rows(a).Item("CLI_ape") Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If
                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DataGridView1.DataSource = table_filtrada
            Else
                DataGridView1.DataSource = ds_marcas.Tables(0)
            End If
        End If
    End Sub




    Dim operacion As String = ""
    Private Sub BO_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cargar.Click



        Dim codigo_interno As Integer = 0
        Dim nombre As String = ""
        Dim aa As Integer = 0
        While aa < DataGridView1.Rows.Count
            If DataGridView1.Rows(aa).Cells(1).Value = True Then
                codigo_interno = DataGridView1.Rows(aa).Cells(0).Value
                nombre = DataGridView1.Rows(aa).Cells(2).Value
            End If
            aa = aa + 1
        End While

        If codigo_interno <> 0 Then
            tx_codinterno.Text = codigo_interno
            tx_codinterno.Visible = True
            Lb_codinterno.Visible = True
            tx_nom_marca.Text = nombre
            GroupBox1.Enabled = False
            TabControl1.SelectedTab = TabPage2
            BO_Guardar.Enabled = True
            BO_Cancelar.Enabled = True

            operacion = "modificar"
        Else
            MessageBox.Show("Seleccione una marca para modificar.", "Sistema de Gestion.")
        End If



    End Sub

    
    Private Sub BO_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ape.Click

    End Sub
End Class