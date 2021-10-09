Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class VehiculoObra
    Inherits Capa_Datos.Conexion


    Public Function Asignar_vehiculo(ByVal VehiculoId As Integer, ByVal ObraId As Integer,
                              ByVal VeObFecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Asignar_vehiculo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraId", ObraId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VeObFecha", VeObFecha))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Asignar_vehiculo")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function
    Public Function VehiculoObra_Verficiar(ByVal VehiculoId As Integer, ByVal ObraId As Integer
                     ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VehiculoObra_Verficiar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraId", ObraId))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "VehiculoObra_Verficiar")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function VehiculoObra_Obtener_X_Obra(ByVal ObraId As Integer
                    ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VehiculoObra_Obtener_X_Obra", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraId", ObraId))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "VehiculoObra_Obtener_X_Obra")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Vehiculo_Liberar(ByVal VehiculoId As Integer, ByVal fecha As Date
                     ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Vehiculo_Liberar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha", fecha))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "VehiculoObra_Verficiar")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Vehiculo_Verficiar(ByVal VehiculoId As Integer
                     ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Vehiculo_Verficiar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Vehiculo_Verficiar")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Vehiculo_historial(ByVal VehiculoId As Integer
                     ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Vehiculo_historial", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@VehiculoId", VehiculoId))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Vehiculo_historial")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function
End Class
