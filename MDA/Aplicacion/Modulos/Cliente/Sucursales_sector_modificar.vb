Public Class Sucursales_sector_modificar
    Dim DAsector As New Datos.Sucursal_sector
    Public SucxClie_id As Integer 'este parametro me lo envia otro formulario, me indica de que sucursal debo recuperar los sectores
    Private Sub Sucursales_sector_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_sectores()
    End Sub

    Public Sub recuperar_sectores()
        Cliente_ds.Tables("Sectores").Rows.Clear()

        Dim ds_info As DataSet = DAsector.Cliente_suc_sector_recuperar_todos(SucxClie_id)
        If ds_info.Tables(0).Rows.Count <> 0 Then
            Cliente_ds.Tables("Sectores").Merge(ds_info.Tables(0))
        End If
    End Sub

    Private Sub DG_sector_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_sector.Click
        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If DG_sector.Rows.Count <> 0 Then
            'DataGridView2.Rows(i).Cells("Item").Value = True
            'If DataGridView2.CurrentRow.Cells("item").Value = True Then
            Dim i As Integer = 0
            While i < DG_sector.Rows.Count
                If DG_sector.Rows(i).Cells("item").Value = True Then
                    DG_sector.Rows(i).Cells("item").Value = False
                End If
                i = i + 1
            End While
            'ahora solo tildo el actual
            DG_sector.CurrentRow.Cells("item").Value = True
            'End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

        
        If DG_sector.Rows.Count <> 0 Then
            Dim i As Integer = 0
            Dim chequeado As String = "no"

            While i < DG_sector.Rows.Count
                If DG_sector.Rows(i).Cells("item").Value = True Then
                    'aqui pregunto si esta seguro.
                    chequeado = "si"
                    If MsgBox("¿Esta seguro que quiere eliminar definitivamente el item seleccionado : " + CStr(DG_sector.CurrentRow.Cells("ClientesucsectordescripcionDataGridViewTextBoxColumn").Value) + "?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                        'borrado lógico
                        Dim cliente_suc_sector_id As Integer = DG_sector.CurrentRow.Cells("ClientesucsectoridDataGridViewTextBoxColumn").Value
                        DAsector.Cliente_suc_sector_eliminar(cliente_suc_sector_id)
                        'y actualizo la grilla.
                            recuperar_sectores()
                            MessageBox.Show("Sector eliminado correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                        Exit While
                End If
                i = i + 1
            End While

            If chequeado = "no" Then
                MessageBox.Show("Error, debe seleccionar un item del listado para quitar.", "Sistema de Gestión.", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("Error, debe seleccionar un item del listado para quitar.", "Sistema de Gestión.", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Error, la operación falló. Intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub BO_equipo_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_equipo_nuevo.Click

        Sucursales_sector_nuevo.Close()
        Sucursales_sector_nuevo.SucxClie_id = SucxClie_id
        Sucursales_sector_nuevo.procedencia = "sucursales_sector_modificar"
        Sucursales_sector_nuevo.operacion = "alta"
        Sucursales_sector_nuevo.Show()



    End Sub

    Private Sub BO_equipo_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_equipo_editar.Click
        If DG_sector.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DG_sector.Rows.Count
                If DG_sector.Rows(i).Cells("item").Value = True Then
                    'aqui lo abro.
                    Sucursales_sector_nuevo.Close()
                    Sucursales_sector_nuevo.SucxClie_id = SucxClie_id
                    Sucursales_sector_nuevo.procedencia = "sucursales_sector_modificar"
                    Sucursales_sector_nuevo.operacion = "modificar"
                    Sucursales_sector_nuevo.Text = "Editar sucursal."
                    Sucursales_sector_nuevo.txt_denominacion.Text = DG_sector.Rows(i).Cells("ClientesucsectordenominacionDataGridViewTextBoxColumn").Value
                    Sucursales_sector_nuevo.txt_descripcion.Text = DG_sector.Rows(i).Cells("ClientesucsectordescripcionDataGridViewTextBoxColumn").Value
                    Sucursales_sector_nuevo.Cliente_suc_sector_id = DG_sector.Rows(i).Cells("ClientesucsectoridDataGridViewTextBoxColumn").Value
                    Sucursales_sector_nuevo.Show()
                    Exit While
                End If
                i = i + 1
            End While
            

        End If


    End Sub
End Class