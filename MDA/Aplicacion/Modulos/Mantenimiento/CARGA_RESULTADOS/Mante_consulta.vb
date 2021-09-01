Public Class Mante_consulta
    Public SucxClie_id As Integer 'me la envia el formulario que esta haciendo mariano, el calendario
    Dim daMant As New Datos.Mantenimiento
    Dim daMantenimiento As New Datos.Mantenimiento
    Dim direccion_sucursal As String = ""

    Public procedencia As String = "calendario_todos_X_fecha" 'este parametro puede cambiar segun lo que se envie en el form "Calendario_b.vb"
    Public mantenimiento_id As Integer

    Private Sub recuperar_mantenimientos()
        MANT_2_ds1.Tables("mant_listados").Rows.Clear()
        MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Clear()

        Dim ds_mant As DataSet
        If procedencia = "calendario_todos_X_fecha" Then
            ds_mant = daMant.Mantenimiento_realizado_buscar_TODOS_2021_07_27(fecha.Value.Date)
        Else 'calendario_b
            ds_mant = daMant.Mantenimiento_obtener_calendario_B(fecha.Value.Date, mantenimiento_id)
        End If

        'Dim ds_mant As DataSet = daMant.Mantenimiento_realizado_buscar_2(fecha.Value.Date, SucxClie_id) choco: este funciona si se discrimna la sucursal en el calendario

        If ds_mant.Tables(2).Rows.Count <> 0 Then
            txt_dni.Text = ds_mant.Tables(2).Rows(0).Item("CLI_dni")
            txt_fantasia.Text = ds_mant.Tables(2).Rows(0).Item("CLI_Fan")
            txt_sucursal.Text = ds_mant.Tables(2).Rows(0).Item("SucxClie_nombre")
            direccion_sucursal = ds_mant.Tables(2).Rows(0).Item("SucxClie_dir")
        End If

        If fecha.Value.DayOfWeek = DayOfWeek.Saturday Or fecha.Value.DayOfWeek = DayOfWeek.Sunday Then
            'como no es un dia laboral no recupera la info
        Else

            'primero recupero los que ya existan, se entiende que entro para modificar algo de sus valores
            If ds_mant.Tables(0).Rows.Count <> 0 Then


                MANT_2_ds1.Tables("mant_listados").Merge(ds_mant.Tables(0))
            End If


            'ahora cargo los detalles de los mantenimientos realizados

            If ds_mant.Tables(3).Rows.Count <> 0 Then
                MANT_2_ds1.Tables("mant_realizados_detalle").Merge(ds_mant.Tables(3))
            End If


            If ds_mant.Tables(1).Rows.Count <> 0 Then
                'ahora con los mantenimientos iniciales veo cuales corresponden a la fecha vigente.
                Dim i As Integer = 0
                While i < ds_mant.Tables(1).Rows.Count
                    Dim Mantenimiento_id As Integer = ds_mant.Tables(1).Rows(i).Item("Mantenimiento_id")
                    Dim fecha_recuperada As Date = CDate(ds_mant.Tables(1).Rows(i).Item("Mantenimiento_fecha_inicio"))
                    Dim dias As Integer = ds_mant.Tables(1).Rows(i).Item("Mant_periodicidad_dias")
                    If fecha_recuperada = fecha.Value.Date Then
                        'si lo agrego si es que ya no existe en el dataset mant_listados
                        validar_y_agregar(Mantenimiento_id, ds_mant.Tables(1), i)
                        '//////////////////////////////////////////////////////////////////////////////////////////////////////
                        If ds_mant.Tables(4).Rows.Count <> 0 Then
                            'aqui agrego los item si y solo si no se encuentra ya en el table mant_realizados_detalle
                            Dim ii As Integer = 0
                            While ii < ds_mant.Tables(4).Rows.Count
                                If Mantenimiento_id = ds_mant.Tables(4).Rows(ii).Item("Mantenimiento_id") Then
                                    'Dim Mantenimiento_id As Integer = ds_mant.Tables(4).Rows(ii).Item("Mantenimiento_id")
                                    'Dim Cat2_caract_id As Integer = ds_mant.Tables(4).Rows(ii).Item("Cat2_caract_id")
                                    Dim Tareas_asignadas_id As Integer = ds_mant.Tables(4).Rows(ii).Item("Tareas_asignadas_id")
                                    Dim valido As String = "si"
                                    Dim j As Integer = 0
                                    While j < MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Count
                                        If (Mantenimiento_id = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Mantenimiento_id")) And (Tareas_asignadas_id = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Tareas_asignadas_id")) Then
                                            valido = "no"
                                            Exit While
                                        End If
                                        j = j + 1
                                    End While
                                    If valido = "si" Then
                                        'lo agrego
                                        Dim fila As DataRow = MANT_2_ds1.Tables("mant_realizados_detalle").NewRow
                                        fila("Mantenimiento_id") = CInt(Mantenimiento_id)
                                        fila("Mant_realizados_id") = 0
                                        fila("Mant_realizado_detalle_id") = 0
                                        fila("Tareas_asignadas_id") = ds_mant.Tables(4).Rows(ii).Item("Tareas_asignadas_id")
                                        fila("Tareas_desc") = ds_mant.Tables(4).Rows(ii).Item("Tareas_desc")
                                        fila("Mant_detalle") = ""
                                        fila("Estado") = "nuevo"
                                        MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Add(fila)
                                    End If
                                End If
                                ii = ii + 1
                            End While
                        End If
                        '/////////////////////////////////////////////////////////////////////////////////////////////////////





                        'MessageBox.Show("Agrego este mantenimiento")
                    Else
                        Dim valido As String = "no"
                        Dim fecha_aux As Date = fecha_recuperada
                        While valido = "no"
                            If fecha_aux <= fecha.Value.Date Then
                                If fecha_aux = fecha.Value.Date Then
                                    'si lo agrego si es que ya no existe en el dataset mant_listados
                                    validar_y_agregar(Mantenimiento_id, ds_mant.Tables(1), i)
                                    'MessageBox.Show("Agrego este mantenimiento")
                                    '//////////////////////////////////////////////////////////////////////////////////////////////////////
                                    If ds_mant.Tables(4).Rows.Count <> 0 Then
                                        'aqui agrego los item si y solo si no se encuentra ya en el table mant_realizados_detalle
                                        Dim ii As Integer = 0
                                        While ii < ds_mant.Tables(4).Rows.Count
                                            If Mantenimiento_id = ds_mant.Tables(4).Rows(ii).Item("Mantenimiento_id") Then
                                                'Dim Mantenimiento_id As Integer = ds_mant.Tables(4).Rows(ii).Item("Mantenimiento_id")
                                                'Dim Cat2_caract_id As Integer = ds_mant.Tables(4).Rows(ii).Item("Cat2_caract_id")
                                                Dim Tareas_asignadas_id As Integer = ds_mant.Tables(4).Rows(ii).Item("Tareas_asignadas_id")
                                                Dim valido2 As String = "si"
                                                Dim j As Integer = 0
                                                While j < MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Count
                                                    If (Mantenimiento_id = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Mantenimiento_id")) And (Tareas_asignadas_id = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Tareas_asignadas_id")) Then
                                                        valido2 = "no"
                                                        Exit While
                                                    End If
                                                    j = j + 1
                                                End While
                                                If valido2 = "si" Then
                                                    'lo agrego
                                                    Dim fila As DataRow = MANT_2_ds1.Tables("mant_realizados_detalle").NewRow
                                                    fila("Mantenimiento_id") = CInt(Mantenimiento_id)
                                                    fila("Mant_realizados_id") = 0
                                                    fila("Mant_realizado_detalle_id") = 0
                                                    fila("Tareas_asignadas_id") = ds_mant.Tables(4).Rows(ii).Item("Tareas_asignadas_id")
                                                    fila("Tareas_desc") = ds_mant.Tables(4).Rows(ii).Item("Tareas_desc")
                                                    'fila("Cat2_caract_atributo") = ds_mant.Tables(4).Rows(ii).Item("Cat2_caract_atributo")
                                                    'fila("Cat2_caract_id") = Cat2_caract_id
                                                    fila("Mant_detalle") = ""
                                                    fila("Estado") = "nuevo"
                                                    MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Add(fila)
                                                End If
                                            End If
                                            ii = ii + 1
                                        End While
                                    End If
                                    '/////////////////////////////////////////////////////////////////////////////////////////////////////


                                    Exit While
                                Else
                                    'si el item tiene los dias = 0 entonces y ya no lo puedo agregar si no coincide con la fecha
                                    If dias = 0 Then
                                        'no lo agrego
                                        Exit While
                                    Else
                                        fecha_aux = fecha_aux.AddDays(dias)
                                        'si la fecha cuando le agrego los dias cae un sabado o domingo lo paso para el siguiente dia laboral.
                                        If (fecha_aux.DayOfWeek = DayOfWeek.Saturday) Then
                                            'If fecha_aux.AddDays(2) = fecha.Value.Date Then
                                            fecha_aux = fecha_aux.AddDays(2) 'sabado le sumo 2 'le sumo 2 si y solo si es el fin de semana previo a la fecha q se selecciono en el calendario
                                            'End If
                                        Else
                                            If fecha_aux.DayOfWeek = DayOfWeek.Sunday Then
                                                'If fecha_aux.AddDays(1) = fecha.Value.Date Then
                                                fecha_aux = fecha_aux.AddDays(1) 'domingo le sumo 1, sumo 1 si y solo si es el fin de semana previ a la fecha q se selecciono en el calendario
                                                'End If
                                            End If
                                        End If
                                    End If
                                End If
                            Else
                                Exit While
                                'no lo agrego
                            End If
                        End While
                    End If
                    i = i + 1
                End While
            End If
        End If
    End Sub

    Private Sub validar_y_agregar(ByVal Mantenimiento_id As Integer, ByVal datos As DataTable, ByVal indice As Integer)
        'aqui controlo que en dataset mant_listado ya no este el mantenimiento que quiero agregar.
        Dim valido As String = "si"
        Dim i As Integer = 0
        While i < MANT_2_ds1.Tables("mant_listados").Rows.Count
            If Mantenimiento_id = MANT_2_ds1.Tables("mant_listados").Rows(i).Item("Mantenimiento_id") Then
                valido = "no"
                Exit While
            End If
            i = i + 1
        End While


        If valido = "si" Then
            'entonces agrego
            Dim fila As DataRow = MANT_2_ds1.Tables("mant_listados").NewRow
            fila("Equipo") = datos.Rows(indice).Item(2)
            fila("Sector") = datos.Rows(indice).Item(3)
            fila("Etiqueta") = datos.Rows(indice).Item(4)
            fila("Tipo_mantenimiento") = datos.Rows(indice).Item(5)
            fila("estado") = "no esta en tabla mantenimiento_realizado"
            fila("Mantenimiento_id") = Mantenimiento_id
            fila("Mant_realizados_id") = 0
            fila("Equipo_id") = datos.Rows(indice).Item(1)
            fila("periodicidad") = datos.Rows(indice).Item(10)
            fila("CLI_Fan") = datos.Rows(indice).Item(11)
            fila("SucxClie_nombre") = datos.Rows(indice).Item(12)
            fila("SucxClie_dir") = datos.Rows(indice).Item(13)

            MANT_2_ds1.Tables("mant_listados").Rows.Add(fila)
        End If



    End Sub

    Private Sub recup_mant()
        Dim ds_mant As DataSet = daMant.Mantenimiento_realizado_buscar_2(fecha.Value.Date, SucxClie_id)
        If ds_mant.Tables(2).Rows.Count <> 0 Then
            txt_dni.Text = ds_mant.Tables(2).Rows(0).Item("CLI_dni")
            txt_fantasia.Text = ds_mant.Tables(2).Rows(0).Item("CLI_Fan")
            txt_sucursal.Text = ds_mant.Tables(2).Rows(0).Item("SucxClie_nombre")
        End If
    End Sub


    Private Sub Mante_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'fecha.Value = "07/06/2021"
        recuperar_mantenimientos()
        'aplicar(filtro)
        If DG_clientes.Rows.Count <> 0 Then
            If MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Count <> 0 Then
                aplicarfiltro_mant_realizados_detalle(DG_clientes.Rows(0).Cells("Mantenimientoid").Value,
                                                      DG_clientes.Rows(0).Cells("Etiqueta").Value,
                                                      DG_clientes.Rows(0).Cells("Tipomantenimiento").Value)
            End If
        End If

        If DG_clientes.Rows.Count = 0 Then
            MessageBox.Show("No hay citas registradas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If

    End Sub

    Private Sub aplicarfiltro_mant_realizados_detalle(ByVal Mantenimiento_id As Integer, ByVal etiqueta As String, ByVal tipo_de_mantenimiento As String)
        MantrealizadosdetalleBindingSource.Filter = ""

        txt_etiqueta.Text = etiqueta
        txt_tipomantenimiento.Text = tipo_de_mantenimiento

        Dim Filtro
        'Filtro = String.Format("{0} LIKE '%{1}%'", "Mantenimiento_id", CStr(Mantenimiento_id)) 'esto para campos strings, FUNCIONA PERFECTO
        Filtro = String.Format("CONVERT(Mantenimiento_id, System.String) LIKE '%{0}%'", CStr(Mantenimiento_id)) 'esto para campos strings, FUNCIONA PERFECTO
        MantrealizadosdetalleBindingSource.Filter = Filtro


    End Sub


    Private Sub DG_clientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_clientes.Click
        Try
            If MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Count <> 0 Then
                aplicarfiltro_mant_realizados_detalle(CInt(DG_clientes.CurrentRow.Cells("Mantenimientoid").Value),
                                                      DG_clientes.CurrentRow.Cells("Etiqueta").Value,
                                                          DG_clientes.CurrentRow.Cells("Tipomantenimiento").Value)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DG_clientes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_clientes.SelectionChanged
        Try
            If MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Count <> 0 Then
                aplicarfiltro_mant_realizados_detalle(CInt(DG_clientes.CurrentRow.Cells("Mantenimientoid").Value),
                                                      DG_clientes.CurrentRow.Cells("Etiqueta").Value,
                                                          DG_clientes.CurrentRow.Cells("Tipomantenimiento").Value)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click

        'guardo resultados de las tareas

        Dim result As DialogResult
        result = MessageBox.Show("¿Desea guardar la información del Equipo: " + txt_etiqueta.Text + "?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim i As Integer = 0
            Dim mant_realizados_id As Integer = DataGridView1.Rows(i).Cells("MantrealizadosidDataGridViewTextBoxColumn").Value
            While i < DataGridView1.Rows.Count

                If mant_realizados_id = 0 Then
                    'quiere decir que todavia no se registro como mantenimiento_realizado en la tabla
                    'por eso hay q hacer el alta
                    Dim Mantenimiento_id As Integer = DataGridView1.Rows(i).Cells("MantenimientoidDataGridViewTextBoxColumn").Value
                    Dim ds_mant As DataSet = daMantenimiento.Mantenimiento_realizado_alta(Mantenimiento_id, fecha.Value.Date)
                    mant_realizados_id = ds_mant.Tables(0).Rows(0).Item("Mant_realizados_id")
                End If

                Dim mant_detalle As String = DataGridView1.Rows(i).Cells("MantdetalleDataGridViewTextBoxColumn").Value
                Dim tareas_asignadas_id As Integer = DataGridView1.Rows(i).Cells("TareasasignadasidDataGridViewTextBoxColumn").Value

                'valido para ver si es un alta o una modificación.
                Dim ds_validar As DataSet = daMantenimiento.Mantenimiento_realizado_detalle_validar(tareas_asignadas_id, mant_realizados_id)
                If ds_validar.Tables(0).Rows.Count <> 0 Then
                    'existe y hay q actualizar
                    Dim mant_realizado_detalle_id As Integer = DataGridView1.Rows(i).Cells("MantrealizadodetalleidDataGridViewTextBoxColumn").Value
                    daMantenimiento.Mantenimiento_realizado_detalle_modificar(mant_detalle, mant_realizado_detalle_id)
                Else
                    'no existe, hay q hacer un alta
                    daMantenimiento.Mantenimiento_realizado_detalle_alta(mant_realizados_id, mant_detalle, tareas_asignadas_id)
                End If
                i = i + 1
            End While

            'recupero y actualizo las grillas, es fundamental para el algoritmo./////////////////////////////////
            recuperar_mantenimientos()
            'aplicar(filtro)
            If DG_clientes.Rows.Count <> 0 Then
                If MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Count <> 0 Then
                    aplicarfiltro_mant_realizados_detalle(DG_clientes.Rows(0).Cells("Mantenimientoid").Value,
                                                          DG_clientes.Rows(0).Cells("Etiqueta").Value,
                                                          DG_clientes.Rows(0).Cells("Tipomantenimiento").Value)
                End If
            End If
            '//////////////////////////////////////////////////////////////////////////////////////////////////



            MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'aqui supongo no hace falta actualizar las grillas.
        End If





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        reporte()
    End Sub
    Dim DAventa As New Datos.Venta
    Private Sub reporte()

        MANT_2_ds1.Tables("Report_mantenimiento").Rows.Clear()
        MANT_2_ds1.Tables("Report_tareas").Rows.Clear()
        MANT_2_ds1.Tables("Report_tareas_doblecolumna").Rows.Clear()

        '////////EMPRESA///////////
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            MANT_2_ds1.Tables("Empresa").Rows.Clear()
            MANT_2_ds1.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If


        '////////////////////////////////////////////////////////



        Dim ii As Integer = 0
        While ii < DG_clientes.Rows.Count
            If DG_clientes.Rows(ii).Cells("item").Value = True Then 'esta chequeado para generar el reporte
                'los datos del cliente los tengo que recuperar de la bd.
                Dim fila As DataRow = MANT_2_ds1.Tables("Report_mantenimiento").NewRow
                fila("id_revision") = 0
                fila("cliente") = DG_clientes.Rows(ii).Cells("CLI_Fan").Value + DG_clientes.Rows(ii).Cells("SucxClie_nombre").Value
                'fila("cliente") = txt_fantasia.Text + ", Suc: " + txt_sucursal.Text
                fila("direccion") = DG_clientes.Rows(ii).Cells("SucxClie_dir").Value
                fila("Sucursal") = DG_clientes.Rows(ii).Cells("SucxClie_nombre").Value
                fila("fecha") = fecha.Value.Date
                fila("diagnostico_previo") = ""
                fila("Equipo") = ""
                MANT_2_ds1.Tables("Report_mantenimiento").Rows.Add(fila)


                Dim Mantenimiento_id As Integer = DG_clientes.Rows(ii).Cells("Mantenimientoid").Value
                Dim etiqueta As String = DG_clientes.Rows(ii).Cells("Etiqueta").Value
                Dim equipo As String = DG_clientes.Rows(ii).Cells("EquipoDataGridViewTextBoxColumn").Value
                Dim sector As String = DG_clientes.Rows(ii).Cells("SectorDataGridViewTextBoxColumn").Value
                Dim Tipo_mantenimiento As String = DG_clientes.Rows(ii).Cells("Tipomantenimiento").Value
                'ahora lo busco en dataset de las tareas...no en el gridview x q el grid esta con un filtro aplicado y puede q no lo encuentre.
                Dim j As Integer = 0
                '//////////////////////////
                Dim dos_columnas As String = "vacia"
                '////////////////////////

                While j < MANT_2_ds1.Tables("mant_realizados_detalle").Rows.Count
                    If Mantenimiento_id = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Mantenimiento_id") Then
                        If dos_columnas = "vacia" Then
                            'ahora lo agrego.
                            Dim fila2 As DataRow = MANT_2_ds1.Tables("Report_tareas").NewRow
                            fila2("Tareas") = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Tareas_desc")
                            fila2("Valor_ingresado") = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Mant_detalle")
                            fila2("Mantenimiento_id") = Mantenimiento_id
                            fila2("Equipo") = equipo
                            fila2("Sector") = sector
                            fila2("Etiqueta") = etiqueta
                            fila2("Tipo_mantenimiento") = Tipo_mantenimiento
                            fila2("Tareas_b") = ""
                            fila2("Valor_ingresado_b") = ""
                            'fila2("Tareas") = DataGridView1.Rows(i).Cells("TareasdescDataGridViewTextBoxColumn").Value
                            'fila2("Valor_ingresado") = DataGridView1.Rows(i).Cells("MantdetalleDataGridViewTextBoxColumn").Value
                            MANT_2_ds1.Tables("Report_tareas").Rows.Add(fila2)
                            dos_columnas = "llena_izquierda" 'notifico q la tarea de la izquierda está cargada
                        Else
                            Dim indice_fila As Integer = MANT_2_ds1.Tables("Report_tareas").Rows.Count - 1
                            MANT_2_ds1.Tables("Report_tareas").Rows(indice_fila).Item("Tareas_b") = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Tareas_desc")
                            MANT_2_ds1.Tables("Report_tareas").Rows(indice_fila).Item("Valor_ingresado_b") = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Mant_detalle")
                            dos_columnas = "vacia"
                        End If

                        'If dos_columnas = "vacia" Then
                        '    'creo columna y agrego la primer tarea de la izquierda
                        '    Dim fila_nueva As DataRow = MANT_2_ds1.Tables("Report_tareas_doblecolumna").NewRow
                        '    fila_nueva("Tareas_a") = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Tareas_desc")
                        '    fila_nueva("Valor_ingresado_a") = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Mant_detalle")
                        '    fila_nueva("Mantenimiento_id_a") = Mantenimiento_id
                        '    fila_nueva("Equipo_a") = equipo
                        '    fila_nueva("Tipo_mantenimiento_a") = Tipo_mantenimiento
                        '    fila_nueva("Etiqueta_a") = etiqueta
                        '    fila_nueva("Sector_a") = sector
                        '    fila_nueva("Tareas_b") = ""
                        '    fila_nueva("Valor_ingresado_b") = ""
                        '    MANT_2_ds1.Tables("Report_tareas_doblecolumna").Rows.Add(fila_nueva)
                        '    dos_columnas = "llena_izquierda" 'notifico q la tarea de la izquierda está cargada
                        'Else
                        '    If dos_columnas = "llena_izquierda" Then
                        '        'entonces solo lleno la de la izquierda
                        '        Dim indice_fila As Integer = MANT_2_ds1.Tables("Report_tareas_doblecolumna").Rows.Count - 1
                        '        MANT_2_ds1.Tables("Report_tareas_doblecolumna").Rows(indice_fila).Item("Tareas_b") = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Tareas_desc")
                        '        MANT_2_ds1.Tables("Report_tareas_doblecolumna").Rows(indice_fila).Item("Valor_ingresado_b") = MANT_2_ds1.Tables("mant_realizados_detalle").Rows(j).Item("Mant_detalle")
                        '        dos_columnas = "vacia"
                        '    End If
                        'End If
                    End If

                    j = j + 1
                End While
                Exit While 'por ahora...cosa q haga 1 reporte x cada uno q tilda. luego solucionamos esto x el tema de los grupos en el reporte.
            End If
            'Dim i As Integer = 0
            'While i < DataGridView1.Rows.Count
            '    Dim fila2 As DataRow = MANT_2_ds1.Tables("Report_tareas").NewRow
            '    fila2("Tareas") = DataGridView1.Rows(i).Cells("TareasdescDataGridViewTextBoxColumn").Value
            '    fila2("Valor_ingresado") = DataGridView1.Rows(i).Cells("MantdetalleDataGridViewTextBoxColumn").Value
            '    MANT_2_ds1.Tables("Report_tareas").Rows.Add(fila2)
            '    i = i + 1
            'End While
            ii = ii + 1
        End While


        If MANT_2_ds1.Tables("Report_tareas").Rows.Count <> 0 Then
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Mantenimiento\CARGA_RESULTADOS\Reportes\CR_mantenimiento.rpt")
            CrReport.Database.Tables("Empresa").SetDataSource(MANT_2_ds1.Tables("Empresa"))
            CrReport.Database.Tables("Revision").SetDataSource(MANT_2_ds1.Tables("Report_mantenimiento"))
            CrReport.Database.Tables("Report_tareas").SetDataSource(MANT_2_ds1.Tables("Report_tareas"))
            'CrReport.Database.Tables("Report_tareas_doblecolumna").SetDataSource(MANT_2_ds1.Tables("Report_tareas_doblecolumna"))


            Dim visor As New Facturacion_report_show
            visor.CrystalReportViewer1.ReportSource = CrReport

            visor.Text = "Mantenimiento programado. Imprimir."
            visor.Show()
        Else
            MessageBox.Show("Error, debe seleccionar al menos un item de la LISTA DE MANTENIMIENTOS PROGRAMADOS.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        



    End Sub
End Class