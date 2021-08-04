﻿Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Caja
    Inherits Datos.Conexion


    Public Function Caja_consultar() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_consultar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Sub Caja_abrir(ByVal CAJA_apertura As DateTime, ByVal CAJA_estado As String, ByVal CAJA_montoinicial As Decimal,
                          ByVal CAJA_montoingresosefectivo As Decimal, ByVal CAJA_montoneto As Decimal, ByVal USU_id As Integer, ByVal suc_id As Integer, ByVal CAJA_montoegresos As Decimal, ByVal CAJA_montoingresostarjeta As Decimal,
                          ByVal terminal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_abrir", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_apertura ", CAJA_apertura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_estado", CAJA_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoinicial", CAJA_montoinicial))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresosefectivo", CAJA_montoingresosefectivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoneto", CAJA_montoneto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@suc_id", suc_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoegresos", CAJA_montoegresos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresostarjeta", CAJA_montoingresostarjeta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub

    Public Sub Caja_modificar(ByVal CAJA_montoingresos As Decimal, ByVal CAJA_montoneto As Decimal, ByVal USU_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresos ", CAJA_montoingresos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoneto", CAJA_montoneto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub


    Public Sub Caja_cierre(ByVal CAJA_cierre As DateTime, ByVal Caja_id As Integer, ByVal terminal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_cierre", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_cierre", CAJA_cierre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Caja_id", Caja_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Terminal_id", terminal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub



#Region "MANEJO_DE_TURNOS"

    Public Function Caja_validad_Apertura(ByVal suc_id As Integer, ByVal usu_id As Integer, ByVal terminal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_validad_Apertura", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@suc_id", suc_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usu_id", usu_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consultar_estado_terminal(ByVal terminal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Terminal_consultar_estado", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Caja_turno_cambio(ByVal USU_id As Integer, ByVal sucursal_id As Integer, ByVal TurnoUsuario_apertura As DateTime, ByVal TurnoUsuario_MontoInicial As Decimal, ByVal terminal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_turno_cambio", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_apertura", TurnoUsuario_apertura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_MontoInicial", TurnoUsuario_MontoInicial))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub

    'NO LO ESTOY USANDO
    Public Sub Caja_turno_alta(ByVal CAJA_ID As Integer, ByVal terminal_id As Integer, ByVal Caja_estado As Integer, ByVal turno_apertura As DateTime, ByVal CAJA_montoingresosefectivo As Decimal, ByVal CAJA_montoinicial As Decimal, ByVal USU_id As Integer, ByVal sucursal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_turno_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_ID", CAJA_ID))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Caja_estado", Caja_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_apertura", turno_apertura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresosefectivo", CAJA_montoingresosefectivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoinicial", CAJA_montoinicial))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub



#End Region




    Public Function Caja_validad_AperturayCierre(ByVal suc_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_validad_AperturayCierre", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@suc_id ", suc_id))
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    'Caja_Actualizar
    Public Sub Caja_Actualizar(ByVal CAJA_monto As Decimal, ByVal USU_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_Actualizar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresos ", CAJA_monto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub

    'choco: 07-11-2018
    'Caja_Actualizar2 ..esta actualiza caja y caja detalle ya sea venta-ingreso-egreso-tarjeta
    Public Sub Caja_Actualizar2(ByVal USU_id As Integer, ByVal descripcion As String, ByVal CAJAdetalle_ingreso_efectivo As Decimal, ByVal CAJAdetalle_egreso As Decimal, ByVal CajaTipoMov_int As Integer,
                                ByVal CAJAdetalle_ingreso_tarjeta As Decimal, ByVal ingreso As Decimal, ByVal CAJAdetalle_fechahora As DateTime, ByVal terminal_id As Integer, ByVal TurnoUsuario_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_Actualizar2", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@descripcion", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_ingreso_efectivo", CAJAdetalle_ingreso_efectivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_egreso", CAJAdetalle_egreso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CajaTipoMov_int", CajaTipoMov_int))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_ingreso_tarjeta", CAJAdetalle_ingreso_tarjeta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ingreso", ingreso)) 'este es el monto de ingreso, puede ser efectivo/tarjeta
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_fechahora", CAJAdetalle_fechahora))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_id", TurnoUsuario_id)) 'para saber quien vende QUE, en cada turno
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub

    'choco 17-12-2019
    'caja actualizar_3 esta actualiza la caja por id_caja y turno_id 
    Public Sub Caja_Actualizar3(ByVal CAJA_id As Integer, ByVal terminal_id As Integer, ByVal TurnoUsuario_id As Integer,
                                ByVal descripcion As String,
                                ByVal CAJAdetalle_ingreso_efectivo As Decimal,
                                ByVal CAJAdetalle_egreso As Decimal,
                                ByVal CajaTipoMov_int As Integer,
                                ByVal CAJAdetalle_ingreso_tarjeta As Decimal,
                                ByVal ingreso As Decimal,
                                ByVal CAJAdetalle_fechahora As DateTime
                                )
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_Actualizar3", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_id", CAJA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_id", TurnoUsuario_id)) 'para saber quien vende QUE, en cada turno
        comando.Parameters.Add(New OleDb.OleDbParameter("@descripcion", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_ingreso_efectivo", CAJAdetalle_ingreso_efectivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_egreso", CAJAdetalle_egreso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CajaTipoMov_int", CajaTipoMov_int))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_ingreso_tarjeta", CAJAdetalle_ingreso_tarjeta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ingreso", ingreso)) 'este es el monto de ingreso, puede ser efectivo/tarjeta
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_fechahora", CAJAdetalle_fechahora))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub


    'choco 18-10-2018 esta rutina consulta el estado de las cajas desde una fecha hasta otra, manda como parametro el id de la sucursal
    Public Function Caja_consultar_caja_sucursal(ByVal sucursal_id As Integer, ByVal fecha_desde As Date, ByVal fecha_hasta As Date, ByVal terminal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_consultar_caja_sucursal", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_desde", fecha_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_hasta", fecha_hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Caja_consultar_caja_sucursal_x_usuario(ByVal sucursal_id As Integer, ByVal fecha_desde As Date, ByVal fecha_hasta As Date, ByVal usu_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_consultar_caja_sucursal_x_usuario", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_desde", fecha_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_hasta", fecha_hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usu_id", usu_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
        Return ds_JE
    End Function


    'LO USO EN EL MODULO DE CIERRE DE CAJA ABIERTA...ME TRAE TODAS LAS TRANSACCIONES DE UNA CAJA ABIERTA ---OJO ESTADO=1
    Public Function Caja_obtener_detalle(ByVal USU_id As Integer, ByVal sucursal_id As Integer, ByVal TurnoUsuario_id As Integer, ByVal CAJA_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_obtener_detalle", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_id", TurnoUsuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_id", CAJA_id))
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Caja_obtener_detalle_x_cajaID(ByVal caja_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Caja_obtener_detalle_x_cajaID", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@caja_id", caja_id))
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

#Region "Egresos-ingresos"
    'elimimar ingreso
    Public Function Caja_ingreso_eliminar(ByVal USU_id As Integer, ByVal CAJAdetalle_ingreso_efectivo As Decimal, ByVal CAJAdetalle_id As Integer, ByVal terminal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_ingreso_eliminar", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_ingreso_efectivo", CAJAdetalle_ingreso_efectivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_id", CAJAdetalle_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    'eliminar egreso
    Public Function Caja_egreso_eliminar(ByVal USU_id As Integer, ByVal CAJAdetalle_egreso As Decimal, ByVal CAJAdetalle_id As Integer, ByVal terminal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_egreso_eliminar", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_egreso", CAJAdetalle_egreso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJAdetalle_id", CAJAdetalle_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Caja_obtener_ingresos_egresos(ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_obtener_ingresos_egresos", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Caja_obtener_ingresos_egresos_x_fecha(ByVal fecha_Origen As DateTime, ByVal fecha_destino As DateTime, ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_obtener_ingresos_egresos_x_fecha", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_Origen", fecha_Origen))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_destino", fecha_destino))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    'recuperar para recalcular cuando elimino un ingreso o egreso

    Public Function Caja_recuperar_recalcular(ByVal CAJA_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_recuperar_recalcular", dbconn)
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_id", CAJA_id))
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cajas")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Caja_actualizar_recalcular(ByVal CAJA_id As Integer, ByVal CAJA_ingresos As Decimal, ByVal CAJA_egresos As Decimal, ByVal CAJA_neto As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Caja_actualizar_recalcular", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_id", CAJA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoingresosefectivo", CAJA_ingresos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoegresos", CAJA_egresos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_montoneto", CAJA_neto))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
    End Sub



#End Region





#Region "Caja y turnos de usuario"
    Public Function TurnoUsuario_CerrarTurno(ByVal caja_id As Integer, ByVal TurnoUsuario_cierre As DateTime, ByVal TurnoUsuario_montocorte As Decimal, ByVal TurnoUsuario_Obs As String, ByVal TurnoUsuario_MontoFinal As Integer, ByVal Terminal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoUsuario_CerrarTurno", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@caja_id", caja_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_cierre", TurnoUsuario_cierre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_montocorte", TurnoUsuario_montocorte))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_Obs", TurnoUsuario_Obs))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TurnoUsuario_MontoFinal", TurnoUsuario_MontoFinal))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Terminal_id", Terminal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function TurnoUsuario_Validar(ByVal usuario_id As Integer, ByVal sucursla_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoUsuario_Validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursla_id", sucursla_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Caja")
        dbconn.Close()
        Return ds_JE
    End Function


#End Region


End Class
