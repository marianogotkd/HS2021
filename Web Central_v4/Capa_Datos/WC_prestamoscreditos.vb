Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class WC_prestamoscreditos
    Inherits Capa_Datos.Conexion

    Public Function Prestamos_buscar_cliente_info(ByVal Codigo As String, ByVal Fecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Prestamos_buscar_cliente_info", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Codigo", Codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha", Fecha))

        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "Prestamos")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

    Public Function Prestamos_alta(ByVal Cliente As Integer, ByVal Fecha As Date, ByVal Importe As Decimal, ByVal Tipocobro As String, ByVal Porcentaje As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim tipo As String = "P"
        Dim comando As New OleDbCommand("PrestamosCreditos_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente", Cliente))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha", Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Importe", Importe))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tipo", tipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tipocobro", Tipocobro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Porcentaje", Porcentaje))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dias", 0))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Saldo", CDec(0)))

        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "Prestamos")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function


    Public Function Prestamos_modificar(ByVal Cliente As Integer, ByVal Fecha As Date, ByVal Importe As Decimal, ByVal Tipocobro As String, ByVal Porcentaje As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim tipo As String = "P"
        Dim comando As New OleDbCommand("Prestamos_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente", Cliente))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha", Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Importe", Importe))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tipocobro", Tipocobro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Porcentaje", Porcentaje))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tipo", tipo))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Dias", 0))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Saldo", CDec(0)))

        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "Prestamos")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

#Region "Creditos"
    Public Function Creditos_buscar_cliente_info(ByVal Codigo As String, ByVal Fecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Creditos_buscar_cliente_info", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Codigo", Codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha", Fecha))

        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "Creditos")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

    Public Function Creditos_alta(ByVal Cliente As Integer, ByVal Fecha As Date, ByVal Importe As Decimal, ByVal Porcentaje As Decimal, ByVal Dias As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim tipo As String = "C"
        Dim comando As New OleDbCommand("PrestamosCreditos_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente", Cliente))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha", Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Importe", Importe))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tipo", tipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tipocobro", "")) 'nulo en creditos
        comando.Parameters.Add(New OleDb.OleDbParameter("@Porcentaje", Porcentaje))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dias", Dias))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Saldo", CDec(0)))

        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "Creditos")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

    Public Function Creditos_modificar(ByVal Cliente As Integer, ByVal Fecha As Date, ByVal Importe As Decimal, ByVal Porcentaje As Decimal, ByVal Dias As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim tipo As String = "C"
        Dim comando As New OleDbCommand("Creditos_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cliente", Cliente))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha", Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Importe", Importe))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dias", Dias))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Porcentaje", Porcentaje))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tipo", tipo))
        

        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "Creditos")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

#End Region

#Region "RESUMEN"
    Public Function PrestamosCreditos_resumen(ByVal Fecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("PrestamosCreditos_resumen", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha", Fecha))
        
        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "RESUMEN")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

    Public Function PrestamosCreditos_eliminar(ByVal ID As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("PrestamosCreditos_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Idprestamocredito", ID))

        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "RESUMEN")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

#End Region

End Class
