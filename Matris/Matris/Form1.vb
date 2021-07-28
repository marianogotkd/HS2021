Public Class Form1
    Dim columna, fila As Integer
    Dim num As Integer
    'Dim x, y As Integer

    Private Sub btn_Crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Crear.Click

        columna = Val(tb_Col.Text)
        fila = Val(tb_fila.Text)

        dt_matris.ColumnCount = columna
        dt_matris.RowCount = fila

        For i = 0 To columna - 1
            For j = 0 To fila - 1
                num = Rnd() * 1

                dt_matris.Rows(j).Cells(i).Value = num

            Next

        Next

        


    End Sub


    
End Class
