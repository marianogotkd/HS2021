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

    Private Sub agregar_nodo_al_camino(ByVal i As Integer, ByVal j As Integer, ByVal movimiento As String)
        Dim fila_a As DataRow = nodos.NewRow
        fila_a("nodos") = CStr(i) + "," + CStr(j) + ","
        fila_a("movimiento") = movimiento
        fila_a("en_camino") = "si"
        nodos.Rows.Add(fila_a)
    End Sub

    Private Sub recursivo(ByVal i As Integer, ByVal j As Integer)
        'si las variables boolean estan en true, ya se recorrio.
        Dim arriba As Boolean = False
        Dim abajo As Boolean = False
        Dim izquierda As Boolean = False
        Dim derecha As Boolean = False
        Dim valido = ""
        Dim listo = "no"

        If i + 1 = dt_matris.Rows.Count Then
        Else
            If i < dt_matris.Rows.Count And abajo = False Then
                If dt_matris.Rows(i + 1).Cells(j).Value = "0" Then 'pregunto x el de abajo
                    validar_nodo_Camino(valido, i + 1, j)

                    If valido = "si" Then
                        agregar_nodo_al_camino(i + 1, j, "abajo")

                        recursivo(i + 1, j)
                        listo = "si"
                    End If
                End If
                abajo = True 'significa que lo agregue
            End If

            If (j + 1 < dt_matris.ColumnCount) And listo = "no" Then
                If dt_matris.Rows(i).Cells(j + 1).Value = "0" And derecha = False Then 'pregunto x el de la derecha
                    validar_nodo_Camino(valido, i, j + 1)
                    If valido = "si" Then

                        agregar_nodo_al_camino(i, j + 1, "derecha")
                        recursivo(i, j + 1)
                        listo = "si"
                    End If
                Else
                    derecha = True
                    If j > 0 Then

                        If dt_matris.Rows(i).Cells(j - 1).Value = "0" And izquierda = False Then 'pregunto x la izquierda
                            validar_nodo_Camino(valido, i, j - 1)

                            If valido = "si" Then

                                agregar_nodo_al_camino(i, j - 1, "izquierda")
                                recursivo(i, j - 1)
                                listo = "si"
                            End If
                        End If
                        izquierda = True
                    End If
                End If
            End If

            If listo = "no" And i > 0 Then 'pregunto x el de arriba.
                If dt_matris.Rows(i - 1).Cells(j).Value = "0" And arriba = False Then
                    validar_nodo_Camino(valido, i - 1, j)
                    If valido = "si" Then
                        agregar_nodo_al_camino(i - 1, j, "arriba")
                        recursivo(i - 1, j)
                        listo = "si"
                    End If
                End If
                arriba = True
            End If


            If arriba = True And abajo = True And derecha = True And izquierda = True Then
                Dim i_nodo As Integer
                Dim j_nodo As Integer
                Dim quitado As String = ""
                'en base a el ultimo agregado busco el indice del nodo anterior agregado.
                Dim tt As Integer = 0
                While tt < nodos.Rows.Count
                    Dim indices() As String = nodos.Rows(tt).Item("nodos").ToString.Split(",")
                    i_nodo = CInt(indices(0))
                    j_nodo = CInt(indices(1))
                    If i = i_nodo And j = j_nodo Then
                        'lo quito de la tabla nodos.
                        nodos.Rows(tt).Item("en_camino") = "no"
                        quitado = "si"
                        Exit While
                    End If
                    tt = tt + 1
                End While
                If quitado = "si" Then
                    Dim jj As Integer = 0

                    While jj < nodos.Rows.Count
                        If nodos.Rows(jj).Item("en_camino") = "si" Then
                            Dim indices() As String = nodos.Rows(jj).Item("nodos").ToString.Split(",")
                            i_nodo = CInt(indices(0))
                            j_nodo = CInt(indices(1))
                        End If
                        jj = jj + 1
                    End While
                    recursivo(i_nodo, j_nodo) 'vuelve al nodo padre
                End If
            End If
        End If
    End Sub

    Dim nodos As New DataTable
    Private Sub camino()
        Dim seguir As String = "si"
        Dim i As Integer = 0
        While i < dt_matris.Rows.Count
            Dim j As Integer = 0
            While j + 1 < dt_matris.ColumnCount
                colorear_negro_todo()
                If dt_matris.Rows(i).Cells(j).Value = "0" Then
                    nodos.Rows.Clear() 'limpio el camino
                    Dim fila As DataRow = nodos.NewRow
                    fila("nodos") = CStr(i) + "," + CStr(j)
                    fila("movimiento") = "primero"
                    fila("en_camino") = "si"
                    nodos.Rows.Add(fila)
                    'ahora avanzo.
                    If dt_matris.Rows(i).Cells(j + 1).Value = "0" Then
                        'avanzo x derecha.
                        Dim fila_a As DataRow = nodos.NewRow
                        fila_a("nodos") = CStr(i) + "," + CStr(j + 1) + ","
                        fila_a("movimiento") = "derecha"
                        fila_a("en_camino") = "si"
                        nodos.Rows.Add(fila_a)
                        recursivo(i, j + 1)

                    Else
                        If dt_matris.Rows(i + 1).Cells(j).Value = "0" Then
                            'avanzo x abajo.
                            Dim fila_a As DataRow = nodos.NewRow
                            fila_a("nodos") = CStr(i + 1) + "," + CStr(j) + ","
                            fila_a("movimiento") = "abajo"
                            fila_a("en_camino") = "si"
                            nodos.Rows.Add(fila_a)
                            recursivo(i + 1, j)

                        Else
                            'error
                            'MessageBox.Show("no hay camino")
                        End If
                    End If
                    pintar_rojo_camino(seguir)
                End If
                If seguir = "si" Then
                    j = j + 1
                Else
                    Exit While 'encontro un 0, aqui tendria q ir una condicion, si no hay camino se termina.
                End If
            End While
            'If seguir = "si" Then
            '    i = i + 1
            'Else
            Exit While
            'End If
        End While
        If existe = "no" Then
            MessageBox.Show("no hay camino")
        End If
    End Sub

    Public existe As String = "no"
    Private Sub pintar_rojo_camino(ByRef seguir As String)
        existe = "no"
        Dim indiceS_ultimo_fila() As String = nodos.Rows(nodos.Rows.Count - 1).Item("nodos").ToString.Split(",")
        Dim ultima_fila As Integer = CInt(indiceS_ultimo_fila(0))
        If ultima_fila = dt_matris.Rows.Count - 1 Then
            seguir = "no"
        Else
            Dim ks As Integer = 0
            While ks < nodos.Rows.Count
                nodos.Rows(ks).Item("en_camino") = "no"
                ks = ks + 1
            End While
        End If
        Dim k As Integer = 0
        While k < nodos.Rows.Count
            If nodos.Rows(k).Item("en_camino") = "si" Then
                existe = "si"
                Dim indices() As String = nodos.Rows(k).Item("nodos").ToString.Split(",")
                Dim i_nodo As Integer = CInt(indices(0))
                Dim j_nodo As Integer = CInt(indices(1))
                dt_matris.Rows(i_nodo).Cells(j_nodo).Style.ForeColor = Color.Red
                dt_matris.Rows(i_nodo).Cells(j_nodo).Style.BackColor = Color.Gray
            End If
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
        nodos.Columns.Add("movimiento")
        nodos.Columns.Add("en_camino")
    End Sub
End Class
