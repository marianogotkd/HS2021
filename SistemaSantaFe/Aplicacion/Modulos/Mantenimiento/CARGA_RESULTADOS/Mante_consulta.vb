Public Class Mante_consulta
    Public SucxClie_id As Integer = 19 'me la envia el formulario que esta haciendo mariano, el calendario
    Dim daMant As New Datos.Mantenimiento
    Dim daMantenimiento As New Datos.Mantenimiento

    Private Sub recuperar_mantenimientos()
        Dim ds_mant As DataSet = daMant.Mantenimiento_realizado_buscar_2(fecha.Value.Date, SucxClie_id)

        If ds_mant.Tables(2).Rows.Count <> 0 Then
            txt_dni.Text = ds_mant.Tables(2).Rows(0).Item("CLI_dni")
            txt_fantasia.Text = ds_mant.Tables(2).Rows(0).Item("CLI_Fan")
            txt_sucursal.Text = ds_mant.Tables(2).Rows(0).Item("SucxClie_nombre")
        End If

        If fecha.Value.DayOfWeek = DayOfWeek.Saturday Or fecha.Value.DayOfWeek = DayOfWeek.Sunday Then
            'como no es un dia laboral no recupera la info
        Else

            'primero recupero los que ya existan, se entiende que entro para modificar algo de sus valores
            If ds_mant.Tables(0).Rows.Count <> 0 Then


                MANT_2_ds.Tables("mant_listados").Merge(ds_mant.Tables(1))
            End If


            'ahora cargo los detalles de los mantenmientos realizados

            If ds_mant.Tables(3).Rows.Count <> 0 Then
                MANT_2_ds.Tables("mant_realizados_detalle").Merge(ds_mant.Tables(3))
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
                                    Dim Cat2_caract_id As Integer = ds_mant.Tables(4).Rows(ii).Item("Cat2_caract_id")
                                    Dim valido As String = "si"
                                    Dim j As Integer = 0
                                    While j < MANT_2_ds.Tables("mant_realizados_detalle").Rows.Count
                                        If (Mantenimiento_id = MANT_2_ds.Tables("mant_realizados_detalle").Rows(j).Item("Mantenimiento_id")) And (Cat2_caract_id = MANT_2_ds.Tables("mant_realizados_detalle").Rows(j).Item("Cat2_caract_id")) Then
                                            valido = "no"
                                            Exit While
                                        End If
                                        j = j + 1
                                    End While
                                    If valido = "si" Then
                                        'lo agrego
                                        Dim fila As DataRow = MANT_2_ds.Tables("mant_realizados_detalle").NewRow
                                        fila("Mantenimiento_id") = CInt(Mantenimiento_id)
                                        fila("Mant_realizados_id") = 0
                                        fila("Mant_realizado_detalle_id") = 0
                                        fila("Cat2_caract_atributo") = ds_mant.Tables(4).Rows(ii).Item("Cat2_caract_atributo")
                                        fila("Cat2_caract_id") = Cat2_caract_id
                                        fila("Mant_detalle") = ""
                                        fila("Estado") = "nuevo"
                                        MANT_2_ds.Tables("mant_realizados_detalle").Rows.Add(fila)
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
                                                Dim Cat2_caract_id As Integer = ds_mant.Tables(4).Rows(ii).Item("Cat2_caract_id")
                                                Dim valido2 As String = "si"
                                                Dim j As Integer = 0
                                                While j < MANT_2_ds.Tables("mant_realizados_detalle").Rows.Count
                                                    If (Mantenimiento_id = MANT_2_ds.Tables("mant_realizados_detalle").Rows(j).Item("Mantenimiento_id")) And (Cat2_caract_id = MANT_2_ds.Tables("mant_realizados_detalle").Rows(j).Item("Cat2_caract_id")) Then
                                                        valido2 = "no"
                                                        Exit While
                                                    End If
                                                    j = j + 1
                                                End While
                                                If valido2 = "si" Then
                                                    'lo agrego
                                                    Dim fila As DataRow = MANT_2_ds.Tables("mant_realizados_detalle").NewRow
                                                    fila("Mantenimiento_id") = CInt(Mantenimiento_id)
                                                    fila("Mant_realizados_id") = 0
                                                    fila("Mant_realizado_detalle_id") = 0
                                                    fila("Cat2_caract_atributo") = ds_mant.Tables(4).Rows(ii).Item("Cat2_caract_atributo")
                                                    fila("Cat2_caract_id") = Cat2_caract_id
                                                    fila("Mant_detalle") = ""
                                                    fila("Estado") = "nuevo"
                                                    MANT_2_ds.Tables("mant_realizados_detalle").Rows.Add(fila)
                                                End If
                                            End If
                                            ii = ii + 1
                                        End While
                                    End If
                                    '/////////////////////////////////////////////////////////////////////////////////////////////////////


                                    Exit While
                                Else
                                    fecha_aux = fecha_aux.AddDays(dias)
                                    'si la fecha cuando le agrego los dias cae un sabado o domingo lo paso para el siguiente dia laboral.
                                    If (fecha_aux.DayOfWeek = DayOfWeek.Saturday) Then
                                        If fecha_aux.AddDays(2) = fecha.Value.Date Then
                                            fecha_aux = fecha_aux.AddDays(2) 'sabado le sumo 2 'le sumo 2 si y solo si es el fin de semana previo a la fecha q se selecciono en el calendario
                                        End If
                                    Else
                                        If fecha_aux.DayOfWeek = DayOfWeek.Sunday Then
                                            If fecha_aux.AddDays(1) = fecha.Value.Date Then
                                                fecha_aux = fecha_aux.AddDays(1) 'domingo le sumo 1, sumo 1 si y solo si es el fin de semana previ a la fecha q se selecciono en el calendario
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
        While i < MANT_2_ds.Tables("mant_listados").Rows.Count
            If Mantenimiento_id = MANT_2_ds.Tables("mant_listados").Rows(i).Item("Mantenimiento_id") Then
                valido = "no"
                Exit While
            End If
            i = i + 1
        End While


        If valido = "si" Then
            'entonces agrego
            Dim fila As DataRow = MANT_2_ds.Tables("mant_listados").NewRow
            fila("Equipo") = datos.Rows(indice).Item(2)
            fila("Sector") = datos.Rows(indice).Item(3)
            fila("Etiqueta") = datos.Rows(indice).Item(4)
            fila("Tipo_mantenimiento") = datos.Rows(indice).Item(5)
            fila("estado") = "no esta en tabla mantenimiento_realizado"
            fila("Mantenimiento_id") = Mantenimiento_id
            fila("Mant_realizados_id") = 0
            fila("Equipo_id") = datos.Rows(indice).Item(1)
            MANT_2_ds.Tables("mant_listados").Rows.Add(fila)
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
        fecha.Value = "07/06/2021"
        recuperar_mantenimientos()
        'aplicar(filtro)
        If DG_clientes.Rows.Count <> 0 Then
            If MANT_2_ds.Tables("mant_realizados_detalle").Rows.Count <> 0 Then
                aplicarfiltro_mant_realizados_detalle(DG_clientes.Rows(0).Cells("Mantenimientoid").Value,
                                                      DG_clientes.Rows(0).Cells("Etiqueta").Value,
                                                      DG_clientes.Rows(0).Cells("Tipomantenimiento").Value)
            End If
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
            If MANT_2_ds.Tables("mant_realizados_detalle").Rows.Count <> 0 Then
                aplicarfiltro_mant_realizados_detalle(CInt(DG_clientes.CurrentRow.Cells("Mantenimientoid").Value),
                                                      DG_clientes.CurrentRow.Cells("Etiqueta").Value,
                                                          DG_clientes.CurrentRow.Cells("Tipomantenimiento").Value)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DG_clientes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_clientes.SelectionChanged
        Try
            If MANT_2_ds.Tables("mant_realizados_detalle").Rows.Count <> 0 Then
                aplicarfiltro_mant_realizados_detalle(CInt(DG_clientes.CurrentRow.Cells("Mantenimientoid").Value),
                                                      DG_clientes.CurrentRow.Cells("Etiqueta").Value,
                                                          DG_clientes.CurrentRow.Cells("Tipomantenimiento").Value)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class