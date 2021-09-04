Imports System.IO
Imports System.Data.OleDb
Public Class Gastos_Consulta

    Dim datasetvisual_gastos As New Costo_Ind
    Dim ds As DataSet
    Dim dagasto As New Datos.Costo_Indirecto

    Private Sub BO_cliente_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agre.Click

        'If DG_gasto.Rows.Count <> 0 Then

        '    Dim i = 0
        '    'datasetvisual_gastos.Tables("Gastos").Rows.Clear()
        '    datasetvisual_gastos.Tables("Gastos").Merge(ds.Tables(0))
        '    'While i < DG_gasto.Rows.Count

        '    '    Dim row2 As DataRow = ds.Tables(0).NewRow()
        '    '    row2("Gastos_Desc") = DG_gasto.Rows(i).Cells(1).Value
        '    '    row2("Gastos_Monto") = DG_gasto.Rows(i).Cells(2).Value



        '    '    ds.Tables(0).Rows.Add(row2)



        '    '    i = i + 1
        '    'End While

        'End If






        'Dim row As DataRow = datasetvisual_gastos.Tables("Gastos").NewRow()
        'row("Gastos_Desc") = tb_desc.Text
        'row("Gastos_Monto") = tb_monto.Text


        'datasetvisual_gastos.Tables("Gastos").Rows.Add(row)

        'DG_gasto.DataSource = datasetvisual_gastos.Tables("Gastos")

        DG_gasto.Rows.Add(tb_desc.Text, tb_monto.Text)


    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If DG_gasto.Rows.Count <> 0 Then
            Dim i = 0

            While i < DG_gasto.Rows.Count

                dagasto.Gastos_alta(DG_gasto.Rows(i).Cells(0).Value, DG_gasto.Rows(i).Cells(1).Value)


                i = i + 1

            End While
        End If
    End Sub
End Class