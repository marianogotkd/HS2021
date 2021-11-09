Public Class Mantenimientos_realizados_consulta
    Dim DAventa As New Datos.Venta
    Public Sub generar_reporte(ByVal op As String)
        '//////////EMPRESA/////////////////////////////
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            MANT_2_ds.Tables("Empresa").Rows.Clear()
            MANT_2_ds.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If
        '/////////////////////////////////////////////




        MANT_2_ds.Tables("Report_mantenimiento").Rows.Clear()
        'MANT_2_ds1.Tables("Report_mantenimiento").Rows.Clear()
        Dim filass As DataRow = MANT_2_ds.Tables("Report_mantenimiento").NewRow
        filass("id_revision") = 0
        filass("cliente") = txt_cliente.Text + ", Suc: " + txt_sucursal.Text
        filass("direccion") = "" 'no tengo
        filass("Sucursal") = txt_sucursal.Text
        filass("fecha") = Today.Date
        filass("diagnostico_previo") = ""
        filass("Equipo") = ""
        MANT_2_ds.Tables("Report_mantenimiento").Rows.Add(filass)



        'cargo el dataset para el reporte
        Dim i As Integer = 0
        Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Clear()
        While i < DG_clientes.Rows.Count
            Dim fila As DataRow = Ds_mant_realizados.Tables("reporte_mant_listados").NewRow
            fila("Equipo") = DG_clientes.Rows(i).Cells("EquipoDataGridViewTextBoxColumn").Value
            fila("Sector") = DG_clientes.Rows(i).Cells("SectorDataGridViewTextBoxColumn").Value
            fila("Etiqueta") = DG_clientes.Rows(i).Cells("EtiquetaDataGridViewTextBoxColumn").Value
            fila("Tipo_mantenimiento") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
            fila("Mantenimiento_id") = DG_clientes.Rows(i).Cells("MantenimientoidDataGridViewTextBoxColumn").Value
            fila("Mant_realizados_id") = DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value
            fila("Equipo_id") = DG_clientes.Rows(i).Cells("EquipoidDataGridViewTextBoxColumn").Value
            fila("periodicidad") = DG_clientes.Rows(i).Cells("PeriodicidadDataGridViewTextBoxColumn").Value
            fila("Fecha") = DG_clientes.Rows(i).Cells("DataGridViewTextBoxColumn1").Value
            fila("Categoria") = DG_clientes.Rows(i).Cells("Categoria").Value
            Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Add(fila)
            i = i + 1
        End While

        'ahora cargo las tareas
        Ds_mant_realizados.Tables("reporte_tares").Rows.Clear()
        Dim j As Integer = 0
        While j < Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Count
            Dim mant_realizados_id As Integer = Ds_mant_realizados.Tables("reporte_mant_listados").Rows(j).Item("Mant_realizados_id")
            Dim jj As Integer = 0
            While jj < ds_mant_todos.Tables(3).Rows.Count
                If mant_realizados_id = ds_mant_todos.Tables(3).Rows(jj).Item("Mant_realizados_id") Then
                    Dim fila As DataRow = Ds_mant_realizados.Tables("reporte_tares").NewRow
                    fila("Mant_realizados_id") = mant_realizados_id
                    fila("Tareas") = ds_mant_todos.Tables(3).Rows(jj).Item("Tareas_desc")
                    fila("Valor") = ds_mant_todos.Tables(3).Rows(jj).Item("Mant_detalle")
                    Ds_mant_realizados.Tables("reporte_tares").Rows.Add(fila)
                End If
                jj = jj + 1
            End While
            j = j + 1
        End While

        If Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Count <> 0 Then
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            If op = "si" Then
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Mantenimiento\Reporte_mantenimientos_realizados\CR_mant_realizado_consulta.rpt")
            Else
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Mantenimiento\Reporte_mantenimientos_realizados\CR_mant_realizado_consulta_b.rpt")
            End If
            CrReport.Database.Tables("Empresa").SetDataSource(MANT_2_ds.Tables("Empresa"))
            CrReport.Database.Tables("Revision").SetDataSource(MANT_2_ds.Tables("Report_mantenimiento"))
            CrReport.Database.Tables("reporte_mant_listados").SetDataSource(Ds_mant_realizados.Tables("reporte_mant_listados"))
            CrReport.Database.Tables("reporte_tares").SetDataSource(Ds_mant_realizados.Tables("reporte_tares"))


            Dim visor As New Facturacion_report_show
            visor.CrystalReportViewer1.ReportSource = CrReport

            visor.Text = "Mantenimientos realizados. Imprimir."
            visor.Show()
        Else
            MessageBox.Show("Error, no se genero el reporte. Verifique que en el listado hay mantenimientos realizados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Public SucxClie_id As Integer
    Dim daMant As New Datos.Mantenimiento


    Private Sub Mantenimientos_realizados_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_mantenimientos_realizados()
        txt_buscar.Focus()
    End Sub
    Dim ds_mant_todos As DataSet
    Private Sub recuperar_mantenimientos_realizados()
        Ds_mant_realizados.Tables("mant_listados").Rows.Clear()
        'usando el SucxClie_id recupero los mantenimientos realizados.
        ds_mant_todos = daMant.Mantenimiento_realizado_buscar_todos(SucxClie_id)
        If ds_mant_todos.Tables(0).Rows.Count <> 0 Then
            Ds_mant_realizados.Tables("mant_listados").Merge(ds_mant_todos.Tables(0))
        End If
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            'habilito el group para la busqueda x fecha
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
            'deberia recuperar todos nuevamente.
            Ds_mant_realizados.Tables("mant_listados").Rows.Clear()
            Ds_mant_realizados.Tables("mant_listados").Merge(ds_mant_todos.Tables(0)) 'como el ds_mant_todos ya tiene los resultados de la primera busqueda, solo hago el merge
        End If
    End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click

        If fecha_hasta.Value.Date >= fecha_desde.Value.Date Then
            Dim ds_rango As DataSet = daMant.Mantenimiento_realizado_buscar_rango_fecha(SucxClie_id, fecha_desde.Value.Date, fecha_hasta.Value.Date)
            If ds_rango.Tables(0).Rows.Count <> 0 Then
                'encontre resultados, primero borramos lo que tiene el dataset
                Ds_mant_realizados.Tables("mant_listados").Rows.Clear()
                Ds_mant_realizados.Tables("mant_listados").Merge(ds_rango.Tables(0))
            Else
                MessageBox.Show("la busqueda no arrojo resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Error, modifique el rango de fecha.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txt_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        'filtro fecha
        Dim Filtro
        Filtro = String.Format("CONVERT(Categoria, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
        MantlistadosBindingSource.Filter = Filtro
        If DG_clientes.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(Tipo_mantenimiento, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
            MantlistadosBindingSource.Filter = Filtro
            If DG_clientes.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(periodicidad, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                MantlistadosBindingSource.Filter = Filtro
                If DG_clientes.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(Etiqueta, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                    MantlistadosBindingSource.Filter = Filtro
                    If DG_clientes.Rows.Count = 0 Then
                        Filtro = String.Format("CONVERT(Sector, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                        MantlistadosBindingSource.Filter = Filtro
                        If DG_clientes.Rows.Count = 0 Then
                            Filtro = String.Format("CONVERT(Equipo, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                            MantlistadosBindingSource.Filter = Filtro
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DG_clientes.RowCount <> 0 Then


            Dim form_detalle As New Mantenimientos_realizados_detalle
            '**************pasamos los datos***************************
            form_detalle.txt_cliente.Text = txt_cliente.Text
            form_detalle.txt_sucursal.Text = txt_sucursal.Text
            form_detalle.txt_etiqueta.Text = DG_clientes.CurrentRow.Cells("EtiquetaDataGridViewTextBoxColumn").Value
            form_detalle.txt_equipo.Text = DG_clientes.CurrentRow.Cells("EquipoDataGridViewTextBoxColumn").Value
            form_detalle.txt_sector.Text = DG_clientes.CurrentRow.Cells("SectorDataGridViewTextBoxColumn").Value
            form_detalle.txt_categoria.Text = DG_clientes.CurrentRow.Cells("Categoria").Value
            form_detalle.txt_fecha.Text = DG_clientes.CurrentRow.Cells("DataGridViewTextBoxColumn1").Value
            form_detalle.txt_mantenimiento.Text = DG_clientes.CurrentRow.Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
            form_detalle.txt_periodicidad.Text = DG_clientes.CurrentRow.Cells("PeriodicidadDataGridViewTextBoxColumn").Value

            'mando los parametros
            form_detalle.Mantenimiento_id = DG_clientes.CurrentRow.Cells("MantenimientoidDataGridViewTextBoxColumn").Value
            form_detalle.Mant_realizados_id = DG_clientes.CurrentRow.Cells("MantrealizadosidDataGridViewTextBoxColumn").Value
            form_detalle.Equipo_id = DG_clientes.CurrentRow.Cells("EquipoidDataGridViewTextBoxColumn").Value



            'ahora agregamos los detalles.
            Dim mant_realizados_id As Integer = CInt(DG_clientes.CurrentRow.Cells("MantrealizadosidDataGridViewTextBoxColumn").Value)
            Ds_mant_realizados.Tables("tareas").Rows.Clear() 'borro siempre el contenido
            Dim i As Integer = 0
            While i < ds_mant_todos.Tables(3).Rows.Count
                If mant_realizados_id = ds_mant_todos.Tables(3).Rows(i).Item("Mant_realizados_id") Then
                    'agrego una fila en la grilla del dataset q uso en el formulario mantenimientos_realizados_detalle
                    Dim fila As DataRow = form_detalle.Ds_mant_realizados.Tables("tareas").NewRow
                    fila("Tareas") = ds_mant_todos.Tables(3).Rows(i).Item("Tareas_desc")
                    fila("Valor") = ds_mant_todos.Tables(3).Rows(i).Item("Mant_detalle")
                    form_detalle.Ds_mant_realizados.Tables("tareas").Rows.Add(fila)
                End If
                i = i + 1
            End While
            form_detalle.Show()
        Else
            MessageBox.Show("Seleccione un equipo para ver los detalles.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Dim MANT_2_ds As New MANT_2_ds

    'Private Sub generar_reporte(ByVal op As String)
    '    MANT_2_ds.Tables("Report_mantenimiento").Rows.Clear()
    '    'MANT_2_ds1.Tables("Report_mantenimiento").Rows.Clear()
    '    Dim filass As DataRow = MANT_2_ds.Tables("Report_mantenimiento").NewRow
    '    filass("id_revision") = 0
    '    filass("cliente") = txt_cliente.Text + ", Suc: " + txt_sucursal.Text
    '    filass("direccion") = "" 'no tengo
    '    filass("Sucursal") = txt_sucursal.Text
    '    filass("fecha") = Today.Date
    '    filass("diagnostico_previo") = ""
    '    filass("Equipo") = ""
    '    MANT_2_ds.Tables("Report_mantenimiento").Rows.Add(filass)



    '    'cargo el dataset para el reporte
    '    Dim i As Integer = 0
    '    Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Clear()
    '    While i < DG_clientes.Rows.Count
    '        Dim fila As DataRow = Ds_mant_realizados.Tables("reporte_mant_listados").NewRow
    '        fila("Equipo") = DG_clientes.Rows(i).Cells("EquipoDataGridViewTextBoxColumn").Value
    '        fila("Sector") = DG_clientes.Rows(i).Cells("SectorDataGridViewTextBoxColumn").Value
    '        fila("Etiqueta") = DG_clientes.Rows(i).Cells("EtiquetaDataGridViewTextBoxColumn").Value
    '        fila("Tipo_mantenimiento") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
    '        fila("Mantenimiento_id") = DG_clientes.Rows(i).Cells("MantenimientoidDataGridViewTextBoxColumn").Value
    '        fila("Mant_realizados_id") = DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value
    '        fila("Equipo_id") = DG_clientes.Rows(i).Cells("EquipoidDataGridViewTextBoxColumn").Value
    '        fila("periodicidad") = DG_clientes.Rows(i).Cells("PeriodicidadDataGridViewTextBoxColumn").Value
    '        fila("Fecha") = DG_clientes.Rows(i).Cells("DataGridViewTextBoxColumn1").Value
    '        fila("Categoria") = DG_clientes.Rows(i).Cells("Categoria").Value
    '        Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Add(fila)
    '        i = i + 1
    '    End While

    '    'ahora cargo las tareas
    '    Ds_mant_realizados.Tables("reporte_tares").Rows.Clear()
    '    Dim j As Integer = 0
    '    While j < Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Count
    '        Dim mant_realizados_id As Integer = Ds_mant_realizados.Tables("reporte_mant_listados").Rows(j).Item("Mant_realizados_id")
    '        Dim jj As Integer = 0
    '        While jj < ds_mant_todos.Tables(3).Rows.Count
    '            If mant_realizados_id = ds_mant_todos.Tables(3).Rows(jj).Item("Mant_realizados_id") Then
    '                Dim fila As DataRow = Ds_mant_realizados.Tables("reporte_tares").NewRow
    '                fila("Mant_realizados_id") = mant_realizados_id
    '                fila("Tareas") = ds_mant_todos.Tables(3).Rows(jj).Item("Tareas_desc")
    '                fila("Valor") = ds_mant_todos.Tables(3).Rows(jj).Item("Mant_detalle")
    '                Ds_mant_realizados.Tables("reporte_tares").Rows.Add(fila)
    '            End If
    '            jj = jj + 1
    '        End While
    '        j = j + 1
    '    End While

    '    If Ds_mant_realizados.Tables("reporte_mant_listados").Rows.Count <> 0 Then
    '        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
    '        If op = "si" Then
    '            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Mantenimiento\Reporte_mantenimientos_realizados\CR_mant_realizado_consulta.rpt")
    '        Else
    '            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Mantenimiento\Reporte_mantenimientos_realizados\CR_mant_realizado_consulta_b.rpt")
    '        End If

    '        CrReport.Database.Tables("Revision").SetDataSource(MANT_2_ds.Tables("Report_mantenimiento"))
    '        CrReport.Database.Tables("reporte_mant_listados").SetDataSource(Ds_mant_realizados.Tables("reporte_mant_listados"))
    '        CrReport.Database.Tables("reporte_tares").SetDataSource(Ds_mant_realizados.Tables("reporte_tares"))


    '        Dim visor As New Facturacion_report_show
    '        visor.CrystalReportViewer1.ReportSource = CrReport

    '        visor.Text = "Mantenimientos realizados. Imprimir."
    '        visor.Show()
    '    Else
    '        MessageBox.Show("Error, no se genero el reporte. Verifique que en el listado hay mantenimientos realizados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End If

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Reporte_msj.Close()



        Reporte_msj.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DG_clientes.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DG_clientes.Rows.Count
                If DG_clientes.Rows(i).Cells("item").Value = True Then
                    Dim pregunta As String = "no"
                    If MsgBox("¿Esta seguro que quiere eliminar definitivamente el item seleccionado con fecha: " + CStr(DG_clientes.Rows(i).Cells("DataGridViewTextBoxColumn1").Value) + "? Los datos se actualizaran directamente en su base de datos.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                        daMant.Mantenimiento_realizado_eliminar(CInt(DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value))
                        'ahora actualizo el formulario.
                        'para ello modifico el dataset y chau.
                        Dim j As Integer = 0
                        Dim Mant_realizados_id As Integer = CInt(DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value)
                        While j < Ds_mant_realizados.Tables("mant_listados").Rows.Count
                            If Mant_realizados_id = Ds_mant_realizados.Tables("mant_listados").Rows(j).Item("Mant_realizados_id") Then
                                Ds_mant_realizados.Tables("mant_listados").Rows.RemoveAt(j) 'lo quito de aqui
                                Exit While
                            End If
                            j = j + 1
                        End While
                        j = 0
                        While j < ds_mant_todos.Tables(0).Rows.Count
                            If Mant_realizados_id = ds_mant_todos.Tables(0).Rows(j).Item("Mant_realizados_id") Then
                                ds_mant_todos.Tables(0).Rows.RemoveAt(j) 'lo quito de aqui
                                Exit While
                            End If
                            j = j + 1
                        End While

                    End If
                    Exit While
                End If
                i = i + 1
            End While


        End If
    End Sub

    Private Sub DG_clientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_clientes.Click
        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If DG_clientes.Rows.Count <> 0 Then

            Dim i As Integer = 0
            While i < DG_clientes.Rows.Count
                If DG_clientes.Rows(i).Cells("item").Value = True Then
                    DG_clientes.Rows(i).Cells("item").Value = False
                End If
                i = i + 1
            End While
            'ahora solo tildo el actual
            DG_clientes.CurrentRow.Cells("item").Value = True
            'End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Calendario_seleccion_cliente.Show()
        Me.Close()
    End Sub
End Class
