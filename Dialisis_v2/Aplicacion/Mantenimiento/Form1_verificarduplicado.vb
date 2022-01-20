Public Class Form1_verificarduplicado
    Dim damantenimiento As New Datos.Mantenimiento
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Select Case ComboBox1.SelectedItem
            Case "Sesiones"
                MessageBox.Show("Seleccionó Sesiones")
                Dim ds_info As DataSet = damantenimiento.Manteniminento_evaluar_duplicado

                DataGridView1.DataSource = ds_info.Tables(0)
                evaluar_duplicado(ds_info.Tables(0))

            Case "Paciente"
                MessageBox.Show("Seleccionó Paciente")
        End Select

    End Sub


    Private Sub evaluar_duplicado(ByVal table1 As DataTable)
        RichTextBox1.Text = ""
        Dim registrosduplicados As String = ""
        Dim i As Integer = 0
        While i < table1.Rows.Count
            Dim cont As Integer = 0
            Dim j As Integer = 0
            While j < table1.Rows.Count
                If table1.Rows(i).Item("PAC_id") = table1.Rows(j).Item("PAC_id") Then
                    If table1.Rows(i).Item("Sesiones_fecha") = table1.Rows(j).Item("Sesiones_fecha") Then
                        cont = cont + 1
                    End If
                End If
                j = j + 1
            End While
            If cont > 1 Then
                Dim registro As String = CStr(table1.Rows(i).Item("Sesiones_id")) + " Fecha:" + CStr(table1.Rows(i).Item("Sesiones_fecha")) + "PACIENTE:" + CStr(table1.Rows(i).Item("PAC_id")) + ", nombre:" + CStr(table1.Rows(i).Item("PAC_ape") + "," + table1.Rows(i).Item("PAC_nom"))

                registrosduplicados = registrosduplicados + "-" + registro
            End If

            i = i + 1
        End While

        RichTextBox1.Text = registrosduplicados




    End Sub

End Class