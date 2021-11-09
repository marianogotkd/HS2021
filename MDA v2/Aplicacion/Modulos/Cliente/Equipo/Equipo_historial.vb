Public Class Equipo_historial

    Public equipo_id As Integer
    Public CLI_id As Integer
    Dim Daequipo As New Datos.Equipo
    Dim DAservicio As New Datos.Servicio
    Private Sub Equipo_historial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        equipo_recuperar()


    End Sub
    Dim ds_info As DataSet
    Private Sub equipo_recuperar()
        ds_info = Daequipo.Equipo_historial_recuperar(equipo_id)

        txt_cliente.Text = ds_info.Tables(0).Rows(0).Item("Cliente")
        txt_sucursal.Text = ds_info.Tables(0).Rows(0).Item("Sucursal")
        txt_sector.Text = ds_info.Tables(0).Rows(0).Item("Cliente_suc_sector_descripcion")
        txt_categoria.Text = ds_info.Tables(0).Rows(0).Item("categoria")
        txt_nombre.Text = ds_info.Tables(0).Rows(0).Item("Equipo_descripcion")
        txt_etiqueta.Text = ds_info.Tables(0).Rows(0).Item("etiqueta")
        CLI_id = ds_info.Tables(0).Rows(0).Item("CLI_id")
        'If ds_info.Tables(1).Rows.Count <> 0 Then
        Equipos_ds.Tables("mant_listados").Rows.Clear()
        Equipos_ds.Tables("mant_listados").Merge(ds_info.Tables(1))
        'Equipos_ds.Tables("mant_listados").Merge(ds_info.Tables(3)) 'ordenes de revision
        Equipos_ds.Tables("mant_listados").Merge(ds_info.Tables(4)) 'orden de trabajo
        DG_clientes.Sort(DG_clientes.Columns("FechaDataGridViewTextBoxColumn"), System.ComponentModel.ListSortDirection.Ascending) 'orden x fecha ASC
        'End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DG_clientes.RowCount <> 0 Then

            If DG_clientes.CurrentRow.Cells("Servicio_id").Value = 0 Then
                Dim form_detalle As New Mantenimientos_realizados_detalle
                '**************pasamos los datos***************************
                form_detalle.txt_cliente.Text = txt_cliente.Text
                form_detalle.txt_sucursal.Text = txt_sucursal.Text
                form_detalle.txt_etiqueta.Text = txt_etiqueta.Text
                form_detalle.txt_equipo.Text = txt_nombre.Text
                form_detalle.txt_sector.Text = txt_sector.Text
                form_detalle.txt_categoria.Text = txt_categoria.Text
                form_detalle.txt_fecha.Text = DG_clientes.CurrentRow.Cells("FechaDataGridViewTextBoxColumn").Value
                form_detalle.txt_mantenimiento.Text = DG_clientes.CurrentRow.Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                form_detalle.txt_periodicidad.Text = DG_clientes.CurrentRow.Cells("PeriodicidadDataGridViewTextBoxColumn").Value

                'mando los parametros
                form_detalle.Mantenimiento_id = DG_clientes.CurrentRow.Cells("MantenimientoidDataGridViewTextBoxColumn").Value
                form_detalle.Mant_realizados_id = DG_clientes.CurrentRow.Cells("MantrealizadosidDataGridViewTextBoxColumn").Value
                form_detalle.Equipo_id = DG_clientes.CurrentRow.Cells("EquipoidDataGridViewTextBoxColumn").Value

                'ahora agregamos los detalles.
                Dim mant_realizados_id As Integer = CInt(DG_clientes.CurrentRow.Cells("MantrealizadosidDataGridViewTextBoxColumn").Value)
                'ds_mant_realizados.Tables("tareas").Rows.Clear() 'borro siempre el contenido
                Dim i As Integer = 0
                While i < ds_info.Tables(2).Rows.Count
                    If mant_realizados_id = ds_info.Tables(2).Rows(i).Item("Mant_realizados_id") Then
                        'agrego una fila en la grilla del dataset q uso en el formulario mantenimientos_realizados_detalle
                        Dim fila As DataRow = form_detalle.Ds_mant_realizados.Tables("tareas").NewRow
                        fila("Tareas") = ds_info.Tables(2).Rows(i).Item("Tareas_desc")
                        fila("Valor") = ds_info.Tables(2).Rows(i).Item("Mant_detalle")
                        form_detalle.Ds_mant_realizados.Tables("tareas").Rows.Add(fila)
                    End If
                    i = i + 1
                End While
                form_detalle.Show()
            Else
                If DG_clientes.Rows.Count <> 0 Then
                    'serv_id = DG_OrdenTrabajo.CurrentRow.Cells("ServicioidDataGridViewTextBoxColumn1").Value
                    Servicio_nuevo.Close()
                    Servicio_nuevo.Cliente_ID = CLI_id
                    Servicio_nuevo.serv_id = DG_clientes.CurrentRow.Cells("Servicio_id").Value
                    Servicio_nuevo.Show()
                    'Me.Close()
                End If
            End If



        Else
            MessageBox.Show("Seleccione un equipo para ver los detalles.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Equipo_historial_seleccionar_informe.Close()
        Equipo_historial_seleccionar_informe.Show()
    End Sub
    Dim DAventa As New Datos.Venta

    Public Sub REPORTE_DETALLADO(ByVal tipo As String)
        Try
            Equipos_ds.Equipo_historial.Rows.Clear()
            Equipos_ds.Equipo_historial_detalle.Rows.Clear()
            Equipos_ds.historial_mantenimiento.Rows.Clear()
            Equipos_ds.ordentrabajo_producto.Rows.Clear()

            '////////EMPRESA///////////
            Dim usuario_id As String
            usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
            Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
            If ds_usuario.Tables(1).Rows.Count <> 0 Then
                Equipos_ds.Tables("Empresa").Rows.Clear()
                Equipos_ds.Tables("Empresa").Merge(ds_usuario.Tables(1))
            End If
            '////////////////////////////////////////////////////////

            Dim fila_a As DataRow = Equipos_ds.Equipo_historial.NewRow
            fila_a("Cliente") = txt_cliente.Text
            fila_a("Sucursal") = txt_sucursal.Text
            fila_a("Sector") = txt_sector.Text
            fila_a("Equipo") = txt_nombre.Text
            fila_a("Etiqueta") = txt_etiqueta.Text
            fila_a("Equipo_id") = equipo_id
            Equipos_ds.Equipo_historial.Rows.Add(fila_a)

            Dim valido As String = "no"
            If tipo = "seleccion" Then
                'verifico que este tildado al menos 1 en el gridview

                Dim i As Integer = 0
                While i < DG_clientes.Rows.Count
                    If DG_clientes.Rows(i).Cells("item").Value = True Then
                        valido = "si"
                        Dim fila As DataRow = Equipos_ds.Equipo_historial_detalle.NewRow
                        fila("Equipo_id") = equipo_id
                        Dim mant_realizados_id As Integer = CInt(DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value)
                        If mant_realizados_id = 0 Then
                            fila("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                        Else
                            fila("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value + "Nº:" + CStr(mant_realizados_id)
                        End If

                        fila("periodicidad") = DG_clientes.Rows(i).Cells("PeriodicidadDataGridViewTextBoxColumn").Value
                        fila("Fecha") = DG_clientes.Rows(i).Cells("FechaDataGridViewTextBoxColumn").Value
                        fila("Mant_realizados_id") = DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value
                        fila("Trabajo_Real") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                        Equipos_ds.Equipo_historial_detalle.Rows.Add(fila)

                        'ahora agregamos los detalles.

                        'ds_mant_realizados.Tables("tareas").Rows.Clear() 'borro siempre el contenido
                        If mant_realizados_id <> 0 Then
                            Dim ii As Integer = 0
                            While ii < ds_info.Tables(2).Rows.Count
                                If mant_realizados_id = ds_info.Tables(2).Rows(ii).Item("Mant_realizados_id") Then
                                    'agrego una fila en la grilla del dataset q uso en el formulario mantenimientos_realizados_detalle
                                    Dim fila_b As DataRow = Equipos_ds.historial_mantenimiento.NewRow
                                    fila_b("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value + "Nº:" + CStr(mant_realizados_id)
                                    fila_b("tareas") = ds_info.Tables(2).Rows(ii).Item("Tareas_desc")
                                    fila_b("valor") = ds_info.Tables(2).Rows(ii).Item("Mant_detalle")

                                    Equipos_ds.historial_mantenimiento.Rows.Add(fila_b)

                                End If
                                ii = ii + 1
                            End While
                        Else
                            'recuperar info del servicio
                            Dim fila_ot As DataRow = Equipos_ds.historial_ordentrabajo.NewRow
                            fila_ot("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                            fila_ot("Diagnostico") = DG_clientes.Rows(i).Cells("diagnostico").Value
                            Equipos_ds.historial_ordentrabajo.Rows.Add(fila_ot)
                            'ahora cargo items y cantidad.
                            Dim serv_id As Integer = DG_clientes.Rows(i).Cells("Servicio_id").Value
                            Dim Ds_servicio As DataSet = DAservicio.Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(serv_id)
                            If Ds_servicio.Tables(1).Rows.Count <> 0 Then
                                Dim jj As Integer = 0
                                While jj < Ds_servicio.Tables(1).Rows.Count
                                    Dim fila_ot_detalle As DataRow = Equipos_ds.ordentrabajo_producto.NewRow
                                    fila_ot_detalle("producto") = Ds_servicio.Tables(1).Rows(jj).Item("Descripcion")
                                    fila_ot_detalle("cantidad") = Ds_servicio.Tables(1).Rows(jj).Item("Cantidad")
                                    fila_ot_detalle("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                                    Equipos_ds.ordentrabajo_producto.Rows.Add(fila_ot_detalle)
                                    jj = jj + 1
                                End While
                            End If
                        End If
                    End If

                    i = i + 1
                End While
            Else
                'recorro TODO
                Dim i As Integer = 0
                While i < DG_clientes.Rows.Count
                    'If DG_clientes.Rows(i).Cells("item").Value = True Then
                    valido = "si"
                    Dim fila As DataRow = Equipos_ds.Equipo_historial_detalle.NewRow
                    fila("Equipo_id") = equipo_id
                    Dim mant_realizados_id As Integer = CInt(DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value)
                    If mant_realizados_id = 0 Then
                        fila("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                    Else
                        fila("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value + "Nº:" + CStr(mant_realizados_id)
                    End If

                    fila("periodicidad") = DG_clientes.Rows(i).Cells("PeriodicidadDataGridViewTextBoxColumn").Value
                    fila("Fecha") = DG_clientes.Rows(i).Cells("FechaDataGridViewTextBoxColumn").Value
                    fila("Mant_realizados_id") = DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value
                    fila("Trabajo_Real") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                    Equipos_ds.Equipo_historial_detalle.Rows.Add(fila)

                    'ahora agregamos los detalles.

                    'ds_mant_realizados.Tables("tareas").Rows.Clear() 'borro siempre el contenido
                    If mant_realizados_id <> 0 Then
                        Dim ii As Integer = 0
                        While ii < ds_info.Tables(2).Rows.Count
                            If mant_realizados_id = ds_info.Tables(2).Rows(ii).Item("Mant_realizados_id") Then
                                'agrego una fila en la grilla del dataset q uso en el formulario mantenimientos_realizados_detalle
                                Dim fila_b As DataRow = Equipos_ds.historial_mantenimiento.NewRow
                                fila_b("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value + "Nº:" + CStr(mant_realizados_id)
                                fila_b("tareas") = ds_info.Tables(2).Rows(ii).Item("Tareas_desc")
                                fila_b("valor") = ds_info.Tables(2).Rows(ii).Item("Mant_detalle")

                                Equipos_ds.historial_mantenimiento.Rows.Add(fila_b)

                            End If
                            ii = ii + 1
                        End While
                    Else
                        'recuperar info del servicio
                        Dim fila_ot As DataRow = Equipos_ds.historial_ordentrabajo.NewRow
                        fila_ot("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                        fila_ot("Diagnostico") = DG_clientes.Rows(i).Cells("diagnostico").Value
                        Equipos_ds.historial_ordentrabajo.Rows.Add(fila_ot)
                        'ahora cargo items y cantidad.
                        Dim serv_id As Integer = DG_clientes.Rows(i).Cells("Servicio_id").Value
                        Dim Ds_servicio As DataSet = DAservicio.Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(serv_id)
                        If Ds_servicio.Tables(1).Rows.Count <> 0 Then
                            Dim jj As Integer = 0
                            While jj < Ds_servicio.Tables(1).Rows.Count
                                Dim fila_ot_detalle As DataRow = Equipos_ds.ordentrabajo_producto.NewRow
                                fila_ot_detalle("producto") = Ds_servicio.Tables(1).Rows(jj).Item("Descripcion")
                                fila_ot_detalle("cantidad") = Ds_servicio.Tables(1).Rows(jj).Item("Cantidad")
                                fila_ot_detalle("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                                Equipos_ds.ordentrabajo_producto.Rows.Add(fila_ot_detalle)
                                jj = jj + 1
                            End While
                        End If
                    End If
                    'End If

                    i = i + 1
                End While
            End If


            If valido = "si" Then
                'genero el reporte
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Reporte\CR_equipo_historial_b.rpt")
                CrReport.Database.Tables("Empresa").SetDataSource(Equipos_ds.Tables("Empresa"))
                CrReport.Database.Tables("Equipo_historial").SetDataSource(Equipos_ds.Tables("Equipo_historial"))
                CrReport.Database.Tables("Equipo_historial_detalle").SetDataSource(Equipos_ds.Tables("Equipo_historial_detalle"))
                CrReport.Database.Tables("historial_ordentrabajo").SetDataSource(Equipos_ds.Tables("historial_ordentrabajo"))
                CrReport.Database.Tables("ordentrabajo_producto").SetDataSource(Equipos_ds.Tables("ordentrabajo_producto"))
                CrReport.Database.Tables("historial_mantenimiento").SetDataSource(Equipos_ds.Tables("historial_mantenimiento"))
                'CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))
                Dim visor As New Facturacion_report_show
                visor.CrystalReportViewer1.ReportSource = CrReport
                visor.Text = "Reporte Historial del Equipo: " + txt_etiqueta.Text + ". Imprimir."
                visor.Show()

            Else
                MessageBox.Show("Debe seleccionar al menos 1 item para generar el reporte.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try




    End Sub


    Public Sub reporte(ByVal tipo As String)
        Try
            Equipos_ds.Equipo_historial.Rows.Clear()
            Equipos_ds.Equipo_historial_detalle.Rows.Clear()
            Equipos_ds.historial_mantenimiento.Rows.Clear()
            Equipos_ds.ordentrabajo_producto.Rows.Clear()


            '////////EMPRESA///////////
            Dim usuario_id As String
            usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
            Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
            If ds_usuario.Tables(1).Rows.Count <> 0 Then
                Equipos_ds.Tables("Empresa").Rows.Clear()
                Equipos_ds.Tables("Empresa").Merge(ds_usuario.Tables(1))
            End If
            '////////////////////////////////////////////////////////

            Dim fila_a As DataRow = Equipos_ds.Equipo_historial.NewRow
            fila_a("Cliente") = txt_cliente.Text
            fila_a("Sucursal") = txt_sucursal.Text
            fila_a("Sector") = txt_sector.Text
            fila_a("Equipo") = txt_nombre.Text
            fila_a("Etiqueta") = txt_etiqueta.Text
            fila_a("Equipo_id") = equipo_id
            Equipos_ds.Equipo_historial.Rows.Add(fila_a)
            Dim valido As String = "no"
            If tipo = "seleccion" Then
                'verifico que este tildado al menos 1 en el gridview
                Dim i As Integer = 0
                While i < DG_clientes.Rows.Count
                    If DG_clientes.Rows(i).Cells("item").Value = True Then
                        valido = "si"
                        Dim fila As DataRow = Equipos_ds.Equipo_historial_detalle.NewRow
                        fila("Equipo_id") = equipo_id
                        fila("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                        fila("periodicidad") = DG_clientes.Rows(i).Cells("PeriodicidadDataGridViewTextBoxColumn").Value
                        fila("Fecha") = DG_clientes.Rows(i).Cells("FechaDataGridViewTextBoxColumn").Value

                        Equipos_ds.Equipo_historial_detalle.Rows.Add(fila)

                    End If

                    i = i + 1
                End While
            Else
                'agrego todo
                'verifico que este tildado al menos 1 en el gridview

                Dim i As Integer = 0
                While i < DG_clientes.Rows.Count
                    valido = "si"
                    Dim fila As DataRow = Equipos_ds.Equipo_historial_detalle.NewRow
                    fila("Equipo_id") = equipo_id
                    fila("Trabajo") = DG_clientes.Rows(i).Cells("TipomantenimientoDataGridViewTextBoxColumn").Value
                    fila("periodicidad") = DG_clientes.Rows(i).Cells("PeriodicidadDataGridViewTextBoxColumn").Value
                    fila("Fecha") = DG_clientes.Rows(i).Cells("FechaDataGridViewTextBoxColumn").Value

                    Equipos_ds.Equipo_historial_detalle.Rows.Add(fila)

                    i = i + 1
                End While
            End If

            If valido = "si" Then
                'genero el reporte
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Equipo\Reporte\CR_equipo_historial.rpt")
                CrReport.Database.Tables("Empresa").SetDataSource(Equipos_ds.Tables("Empresa"))
                CrReport.Database.Tables("Equipo_historial").SetDataSource(Equipos_ds.Tables("Equipo_historial"))
                CrReport.Database.Tables("Equipo_historial_detalle").SetDataSource(Equipos_ds.Tables("Equipo_historial_detalle"))
                'CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))
                Dim visor As New Facturacion_report_show
                visor.CrystalReportViewer1.ReportSource = CrReport
                visor.Text = "Reporte Historial del Equipo: " + txt_etiqueta.Text + ". Imprimir."
                visor.Show()

            Else
                If tipo = "seleccion" Then
                    MessageBox.Show("Debe seleccionar al menos 1 item para generar el reporte.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error, la consulta actual no puede generar un informe.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DG_clientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_clientes.Click
        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If DG_clientes.Rows.Count <> 0 Then

            'Dim i As Integer = 0
            'While i < DG_clientes.Rows.Count
            '    If DG_clientes.Rows(i).Cells("item").Value = True Then
            '        DG_clientes.Rows(i).Cells("item").Value = False
            '    End If
            '    i = i + 1
            'End While

            If DG_clientes.CurrentRow.Cells("item").Value = True Then
                'ahora solo tildo el actual
                DG_clientes.CurrentRow.Cells("item").Value = False
            Else
                'ahora solo tildo el actual
                DG_clientes.CurrentRow.Cells("item").Value = True
            End If
            
            'End If
        End If
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            'habilito el group para la busqueda x fecha
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
            'deberia recuperar todos nuevamente.
            equipo_recuperar()
        End If
    End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click

        If fecha_hasta.Value.Date >= fecha_desde.Value.Date Then
            Dim ds_rango As DataSet = Daequipo.Equipo_historial_buscar_rango_fecha(equipo_id, fecha_desde.Value.Date, fecha_hasta.Value.Date)
            If ds_rango.Tables(0).Rows.Count <> 0 Then
                'encontre resultados, primero borramos lo que tiene el dataset
                Equipos_ds.Tables("mant_listados").Rows.Clear()
                Equipos_ds.Tables("mant_listados").Merge(ds_rango.Tables(1))
                'Equipos_ds.Tables("mant_listados").Merge(ds_rango.Tables(3)) 'ordenes de revision 
                Equipos_ds.Tables("mant_listados").Merge(ds_rango.Tables(4)) 'orden de trabajo
                DG_clientes.Sort(DG_clientes.Columns("FechaDataGridViewTextBoxColumn"), System.ComponentModel.ListSortDirection.Ascending) 'orden x fecha ASC
                If DG_clientes.Rows.Count = 0 Then
                    MessageBox.Show("la busqueda no arrojo resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If


            Else
                MessageBox.Show("la busqueda no arrojo resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Error, modifique el rango de fecha.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txt_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        Dim Filtro
        'tipo trabajo
        Filtro = String.Format("CONVERT(Tipo_mantenimiento, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
        MantlistadosBindingSource.Filter = Filtro
        If DG_clientes.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(periodicidad, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
            MantlistadosBindingSource.Filter = Filtro
            If DG_clientes.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(Fecha, System.String) LIKE '%{0}%'", txt_buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                MantlistadosBindingSource.Filter = Filtro
            End If
        End If

    End Sub
    Dim daMant As New Datos.Mantenimiento
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        Dim sucursal_id = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")

                Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar los items seleccionados?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
            Dim valido As String = "no"
            Dim i As Integer = 0
            While i < DG_clientes.Rows.Count
                If DG_clientes.Rows(i).Cells("item").Value = True Then
                    valido = "si"
                    'veo si es una orden de trabajo o bien un mantenimiento.
                    If DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value = 0 Then
                        'entonces es una orden de trabajo.
                        Dim Servicio_id As Integer = CInt(DG_clientes.Rows(i).Cells("Servicio_id").Value)
                        DAservicio.Servicio_ActualizarEstado(Servicio_id, "ANULADO")
                        DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, Servicio_id, Now, "ANULADO")
                    Else
                        'es un mantenimiento.
                        Dim Mant_realizados_id As Integer = CInt(DG_clientes.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value)
                        daMant.Mantenimiento_realizado_eliminar(Mant_realizados_id)
                    End If
                End If
                i = i + 1
            End While

            If valido = "si" Then
                'vuelvo a cargar 
                equipo_recuperar()
                MessageBox.Show("Datos actualizados!", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error, debe seleccionar al menos un item para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If



    End Sub
End Class