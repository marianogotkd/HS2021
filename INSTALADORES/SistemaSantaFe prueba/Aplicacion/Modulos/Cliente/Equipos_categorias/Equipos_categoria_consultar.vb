Public Class Equipos_categoria_consultar
    Dim daequipo_cat As New Datos.Equipos_categorias

    Private Sub BO_cliente_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_nuevo.Click
        Me.Hide()
        Equipos_categorias_alta.Close()
        Equipos_categorias_alta.Show()
    End Sub

    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_modificar.Click
        If DG_clientes.Rows.Count <> 0 Then
            Equipos_categorias_alta.Close()
            Dim Cat1_equipo_id As Integer = DG_clientes.CurrentRow.Cells("Cat1equipoidDataGridViewTextBoxColumn").Value
            Equipos_categorias_alta.Cat1_equipo_id = Cat1_equipo_id
            Equipos_categorias_alta.procedencia = "modificar"
            Equipos_categorias_alta.Text = "Editar Categoría de Equipos"
            Equipos_categorias_alta.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub Equipos_categoria_consultar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        recuperar_categorias()
        
    End Sub

    Public Sub recuperar_categorias()
        'recupero categorias
        Equipos_cat_DS.Tables("Categorias_consultar").Rows.Clear()

        Dim ds_cat As DataSet = daequipo_cat.Equipo_categorias_recuperartodo()

        Dim i As Integer = 0
        While i < ds_cat.Tables(0).Rows.Count
            Dim fila As DataRow = Equipos_cat_DS.Tables("Categorias_consultar").NewRow
            fila("Tipo_desc") = ds_cat.Tables(0).Rows(i).Item("Cat1_equipo_desc")
            fila("Cat1_equipo_id") = ds_cat.Tables(0).Rows(i).Item("Cat1_equipo_id")
            Dim cat1_equipo_id As Integer = ds_cat.Tables(0).Rows(i).Item("Cat1_equipo_id")
            Dim subtipos_concatenados As String = ""
            Dim j As Integer = 0
            While j < ds_cat.Tables(1).Rows.Count
                If cat1_equipo_id = CInt(ds_cat.Tables(1).Rows(j).Item("Cat1_equipo_id")) Then
                    subtipos_concatenados = subtipos_concatenados + "/" + CStr(ds_cat.Tables(1).Rows(j).Item("Cat2_equipo_desc"))
                End If
                j = j + 1
            End While
            fila("Subtipos_concatenados") = subtipos_concatenados
            Equipos_cat_DS.Tables("Categorias_consultar").Rows.Add(fila)
            i = i + 1
        End While
    End Sub
End Class