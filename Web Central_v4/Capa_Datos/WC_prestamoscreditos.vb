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

End Class
