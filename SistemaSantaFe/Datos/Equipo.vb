Imports System.Data.OleDb
Imports System.Data.DataRow
Imports System.Data.SqlClient
Public Class Equipo
    Inherits Datos.Conexion

#Region "Equipo alta"
    Public Function Equipo_alta(ByVal descripcion As String, ByVal denominacion As String, ByVal sector_id As Integer, ByVal idcat As Integer, ByVal nrocat As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_descripcion", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_id", sector_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_idcat", idcat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_nrocat", nrocat))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Equipo_alta_todo_junto(ByVal descripcion As String, ByVal denominacion As String, ByVal sector_id As Integer, ByVal idcat As Integer, ByVal nrocat As Integer, ByVal tabla_atributos As DataTable) As String
        Dim validar_op As String = ""
        Dim Equipo_id As Integer = 0
        Using connection As OleDbConnection = dbconn
            'Using connection As OleDbConnection = New OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=25.112.197.145\SQLEXPRESS_CHOK")
            Dim transaccion As OleDbTransaction = Nothing
            Try
                connection.Open()
                transaccion = connection.BeginTransaction
                Dim comando As New OleDbCommand("Equipo_alta", connection) 'AQUI PROCEDIMIENTO ALMACENADO
                comando.Transaction = transaccion
                'comando.Connection = connection
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_descripcion", descripcion))
                comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", denominacion))
                comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_id", sector_id))
                comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_idcat", idcat))
                comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_nrocat", nrocat))
                'comando.ExecuteNonQuery()
                Dim ds_JE As New DataSet()
                Dim da_JE As New OleDbDataAdapter(comando)
                da_JE.Fill(ds_JE, "Equipo") 'con esta instruccion recupero en un dataset el select del procedimiento almacenado "Equipo_alta"
                Equipo_id = ds_JE.Tables(0).Rows(0).Item("Equipo_id")
                If tabla_atributos.Rows.Count <> 0 Then
                    'entonces ciclo y agrego los detalles.
                    Dim ii As Integer = 0
                    While ii < tabla_atributos.Rows.Count
                        Dim valor As String = ""
                        If IsDBNull(tabla_atributos.Rows(ii).Item("Atributo_detalle_valor")) Then
                            valor = ""
                        Else
                            valor = tabla_atributos.Rows(ii).Item("Atributo_detalle_valor")

                        End If
                        'aqui va guardo
                        Dim comando_2 As New OleDbCommand("Equipo_atributo_detalle_alta", connection) 'AQUI PROCEDIMIENTO ALMACENADO
                        comando_2.Transaction = transaccion
                        comando_2.CommandType = CommandType.StoredProcedure
                        comando_2.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))
                        comando_2.Parameters.Add(New OleDb.OleDbParameter("@Cat2_caract_id", tabla_atributos.Rows(ii).Item("Cat2_caract_id")))
                        comando_2.Parameters.Add(New OleDb.OleDbParameter("@Atributo_detalle_valor", valor))
                        comando_2.ExecuteNonQuery() 'lo uso para que guarde a medida que cicla.
                        ii = ii + 1
                    End While
                End If
                transaccion.Commit() 'esta instruccion recien hace la transaccion en lote de todo lo q estoy insertando.
                validar_op = "GUARDADO"
            Catch ex As Exception
                validar_op = "ERROR"
                'MsgBox("ERROR EN LA TRANSACCION, SE VOLVERA A ATRAS.", vbOK, "Sistema de Gestión.")
                Try
                    transaccion.Rollback() 'deshace todos los insert en la bd, en ambas tablas. -------------IMPORTANTEEEEEEEEEEEEEEEEE
                Catch ex_rollback As Exception
                    'no muestro nada
                End Try
            End Try
        End Using
        Return validar_op
    End Function





    Public Function Equipo_atributo_detalle_alta(ByVal Equipo_id As Integer, ByVal Cat2_caract_id As Integer, ByVal Atributo_detalle_valor As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_atributo_detalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_caract_id", Cat2_caract_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Atributo_detalle_valor", Atributo_detalle_valor))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_idcat", idcat))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_nrocat", nrocat))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region

#Region "Equipo modificar"
    Public Function Equipo_modificar(ByVal Equipo_denominacion As String, ByVal Equipo_descripcion As String, ByVal Equipo_idcat As Integer, ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", Equipo_denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_descripcion", Equipo_descripcion))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", Equipo_denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_idcat", Equipo_idcat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

    'Equipo_recuperar_info
    Public Function Equipo_recuperar_info(ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_recuperar_info", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))
        
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Equipo_atributo_detalle_borrar(ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_atributo_detalle_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Cat2_caract_id", Cat2_caract_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Atributo_detalle_valor", Atributo_detalle_valor))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_idcat", idcat))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_nrocat", nrocat))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region

    Public Function Equipo_validar(ByVal Cliente_suc_sector_id As Integer, ByVal Equipo_descripcion As String, ByVal Equipo_denominacion As String, ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente_suc_sector_id", Cliente_suc_sector_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_descripcion", Equipo_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_denominacion", Equipo_denominacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Equipo_buscar_x_sucursal(ByVal SucxClie_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_buscar_x_sucursal", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@SucxClie_id", SucxClie_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

    'recuperar_info_equipo
    Public Function Equipo_obtener_info(ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_obtener_info", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function

    'equipo eliminacion logica
    Public Function Equipo_eliminar(ByVal Equipo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Equipo_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Equipo_id", Equipo_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Equipo")
        dbconn.Close()
        Return ds_JE
    End Function



End Class
