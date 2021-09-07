Public Class Caja_consulta

    Dim DAcaja As New Datos.Caja

    Private Sub Caja_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obtener_egresos()
        'obtener_usuarios()
        tabla_filtrada()
        'seleccionar el usuario administrador
        'If ds_usuarios.Tables(0).Rows.Count <> 0 Then
        '    'selecciono el usuario actual
        '    Dim i As Integer = 0
        '    Dim usuario_id As Integer = Inicio.USU_id
        '    While i < ds_usuarios.Tables(0).Rows.Count
        '        If ds_usuarios.Tables(0).Rows(i).Item("USU_id") = usuario_id Then
        '            CB_usuarios.SelectedValue = ds_usuarios.Tables(0).Rows(i).Item("USU_id")
        '            i = ds_usuarios.Tables(0).Rows.Count
        '        End If
        '        i = i + 1
        '    End While
        'End If

        'selecciono la primera fecha de la grilla y la pongo en el boton
        If DataGridView1.Rows.Count <> 0 Then

            Dim fecha_desde As Date = DataGridView1.Rows(0).Cells(1).Value
            'fecha_desde = Format(fecha_desde, "MM/dd/yyyy")
            DT_fecha_desde.Value = fecha_desde
        Else
            DT_fecha_desde.Value = Today
        End If

        DT_fecha_hasta.Value = Today


    End Sub

    Dim dataset_egresos As New DataSet
    Private Sub obtener_egresos()
        dataset_egresos = DAcaja.Caja_consultar

        'vamos a unir las tablas del dataset....

        'dataset_egresos.Tables(0).Merge(dataset_egresos.Tables(1))
        'dataset_egresos.Tables(0).Merge(dataset_egresos.Tables(2))
        'dataset_egresos.Tables(0).Merge(dataset_egresos.Tables(3))

        'ahora lo pongo como recurso del dataset
        'dataset_egresos.Tables(0).DefaultView.Sort = "[Fecha] ASC"

        DataGridView1.DataSource = dataset_egresos.Tables(0)

        'DataGridView1.DataSource = dataset_egresos.Tables(0)
        calcular_totales()

    End Sub
    Public Sub calcular_totales()
        Label_total.Text = "0,00"
        'DataG_listaTotal.Rows.Clear()
        'DataG_listaTotal.Rows.Add()
        'sumamos los subtotales con un ciclo
        Dim sumar As Decimal = "0,00"
        Dim ii As Integer = 0
        While ii < DataGridView1.Rows.Count
            sumar = sumar + DataGridView1.Rows(ii).Cells("CAJAmontonetoDataGridViewTextBoxColumn").Value
            ii = ii + 1
        End While
        sumar = Math.Round(sumar, 2)
        'DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
        Label_total.Text = (Math.Round(sumar, 2).ToString("N2"))
    End Sub

    Dim table_filtrada As New DataTable
    Private Sub tabla_filtrada()
        table_filtrada.Columns.Add("CAJA_id")
        table_filtrada.Columns.Add("CAJA_apertura")
        table_filtrada.Columns.Add("CAJA_cierre")
        table_filtrada.Columns.Add("CAJA_estado")
        table_filtrada.Columns.Add("CAJA_montoinicial")
        table_filtrada.Columns.Add("CAJA_montoingresos")
        table_filtrada.Columns.Add("CAJA_montoneto")
        table_filtrada.Columns.Add("USU_id")
        table_filtrada.Columns.Add("USU_ape")
        table_filtrada.Columns.Add("USU_nom")
        table_filtrada.Columns.Add("USU_usuario")
    End Sub

    Private Sub BUSCAR_RANGO()
        table_filtrada.Rows.Clear()
        Dim i As Integer = 0

        'Dim USU_id_selec As Integer = CB_usuarios.SelectedValue
        'Dim x As Integer = 0

        'Dim fecha_desde As Date = DT_fecha_desde.Text
        'fecha_desde = Format(fecha_desde, "MM/dd/yyyy")

        'Dim fecha_hasta As Date = DT_fecha_hasta.Text
        'fecha_hasta = Format(fecha_hasta, "MM/dd/yyyy")
        i = 0
        While i < dataset_egresos.Tables(0).Rows.Count

            Dim fecha_bd As Date = Format(dataset_egresos.Tables(0).Rows(i).Item("CAJA_apertura"), "dd/MM/yyyy")
            'fecha_bd = Format(fecha_bd, "MM/dd/yyyy")
            If fecha_bd >= DT_fecha_desde.Text And fecha_bd <= DT_fecha_hasta.Text Then
                table_filtrada.ImportRow(dataset_egresos.Tables(0).Rows(i))
            End If
            i = i + 1
        End While

        If table_filtrada.Rows.Count <> 0 Then

            'table_filtrada.DefaultView.Sort = "[Fecha] ASC"
            DataGridView1.DataSource = table_filtrada

        Else
            DataGridView1.DataSource = ""
        End If

        calcular_totales()

    End Sub

    Private Sub DT_fecha_desde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DT_fecha_desde.ValueChanged
        If dataset_egresos.Tables.Count <> 0 Then
            BUSCAR_RANGO()
        End If
    End Sub


    Private Sub DT_fecha_hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DT_fecha_hasta.ValueChanged
        If dataset_egresos.Tables.Count <> 0 Then
            BUSCAR_RANGO()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class