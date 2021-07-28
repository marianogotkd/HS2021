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
        colorear_negro_todo()
    End Sub

    Private Sub validar_nodo_Camino(ByRef valido As String, ByVal i As Integer, ByVal j As Integer) 'verifico que el nodo no este ya en la lista del camino
        valido = "si"
        Dim k As Integer = 0
        While k < nodos.Rows.Count
            Dim indices() As String = nodos.Rows(k).Item("nodos").ToString.Split(",")
            Dim i_nodo As Integer = CInt(indices(0))
            Dim j_nodo As Integer = CInt(indices(1))
            If (i_nodo = i) And (j_nodo = j) Then
                valido = "no"
                Exit While
            End If
            k = k + 1
        End While
    End Sub

    Private Sub agregar_nodo_al_camino(ByVal i, ByVal j)
        Dim fila_a As DataRow = nodos.NewRow
        fila_a("nodos") = CStr(i) + "," + CStr(j) + ","
        nodos.Rows.Add(fila_a)
    End Sub

    Private Sub recursivo(ByVal i As Integer, ByVal j As Integer)
        Dim valido = ""
        Dim listo = "no"
        If i < dt_matris.Rows.Count Then
            If dt_matris.Rows(i + 1).Cells(j).Value = "0" Then 'pregunto x el de abajo
                validar_nodo_Camino(valido, i + 1, j)
                If valido = "si" Then
                    agregar_nodo_al_camino(i + 1, j)
                    recursivo(i + 1, j)
                    listo = "si"
                End If
            End If
        End If

        If j < dt_matris.ColumnCount And listo = "no" Then
            If dt_matris.Rows(i).Cells(j + 1).Value = "0" Then 'pregunto x el de la derecha
                validar_nodo_Camino(valido, i, j + 1)
                If valido = "si" Then
                    agregar_nodo_al_camino(i, j + 1)
                    recursivo(i, j + 1)
                    listo = "si"
                End If
            Else
                If j > 0 Then
                    If dt_matris.Rows(i).Cells(j - 1).Value = "0" Then
                        validar_nodo_Camino(valido, i, j - 1)
                        If valido = "si" Then
                            agregar_nodo_al_camino(i, j - 1)
                            recursivo(i, j - 1)
                            listo = "si"
                        End If
                    End If
                End If
            End If
        End If

        If listo = "no" And i > 0 Then 'pregunto x el de arriba.
            If dt_matris.Rows(i - 1).Cells(j).Value = "0" Then
                validar_nodo_Camino(valido, i - 1, j)
                If valido = "si" Then
                    agregar_nodo_al_camino(i - 1, j)
                    recursivo(i - 1, j)
                    listo = "si"
                End If
            Else

            End If
        End If

        If listo = "no" Then
            'no hay mas ceros x ningun nodo adyacente
        End If

    End Sub

    Dim nodos As New DataTable
    Private Sub camino()

        Dim i As Integer = 0
        While i < dt_matris.Rows.Count
            Dim j As Integer = 0
            While j < dt_matris.ColumnCount
                colorear_negro_todo()
                If dt_matris.Rows(i).Cells(j).Value = "0" Then
                    nodos.Rows.Clear() 'limpio el camino
                    Dim fila As DataRow = nodos.NewRow
                    fila("nodos") = CStr(i) + "," + CStr(j)
                    nodos.Rows.Add(fila)
                    'ahora avanzo.
                    If dt_matris.Rows(i).Cells(j + 1).Value = "0" Then
                        'avanzo x derecha.
                        Dim fila_a As DataRow = nodos.NewRow
                        fila_a("nodos") = CStr(i) + "," + CStr(j + 1) + ","
                        nodos.Rows.Add(fila_a)
                        recursivo(i, j + 1)

                    Else
                        If dt_matris.Rows(i + 1).Cells(j).Value = "0" Then
                            'avanzo x abajo.
                            Dim fila_a As DataRow = nodos.NewRow
                            fila_a("nodos") = CStr(i + 1) + "," + CStr(j) + ","
                            nodos.Rows.Add(fila_a)
                            recursivo(i + 1, j)

                        Else
                            'error
                            MessageBox.Show("no hay camino")
                        End If
                    End If
                    pintar_rojo_camino()
                    Exit While 'encontro un 0, aqui tendria q ir una condicion, si no hay camino se termina.
                End If
                j = j + 1
            End While
            Exit While
            'i = i + 1
            Exit While 'no quiero buscar en la segunda fila
        End While
    End Sub

    Private Sub pintar_rojo_camino()
        Dim k As Integer = 0
        While k < nodos.Rows.Count
            Dim indices() As String = nodos.Rows(k).Item("nodos").ToString.Split(",")
            Dim i_nodo As Integer = CInt(indices(0))
            Dim j_nodo As Integer = CInt(indices(1))
            dt_matris.Rows(i_nodo).Cells(j_nodo).Style.ForeColor = Color.Red
            dt_matris.Rows(i_nodo).Cells(j_nodo).Style.BackColor = Color.Gray
            k = k + 1
        End While
    End Sub

    Private Sub colorear_negro_todo()
        Dim i As Integer = 0
        While i < dt_matris.Rows.Count
            Dim j As Integer = 0
            While j < dt_matris.ColumnCount
                'If dt_matris.Rows(i).Cells(j).Value = "0" Then
                dt_matris.Rows(i).Cells(j).Style.ForeColor = Color.Black
                dt_matris.Rows(i).Cells(j).Style.BackColor = Color.White
                'End If
                j = j + 1
            End While
            i = i + 1
        End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        camino()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        nodos.Columns.Add("nodos")
    End Sub


    
End Class
