Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class WC_gastos
    Inherits Capa_Datos.Conexion

#Region "Gastos Tipo"
    Public Function GastosTipo_validar(ByVal motivo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("GastosTipo_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@motivo", motivo))


        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)

        DA.Fill(ds, "GastosTipo")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

    Public Function GastosTipo_obtener_todos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("GastosTipo_obtener_todos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        'comando.Parameters.Add(New OleDb.OleDbParameter("@motivo", motivo))


        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)

        DA.Fill(ds, "GastosTipo")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function

    Public Function GastosTipo_alta(ByVal motivo As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("GastosTipo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@motivo", motivo))

        Dim ds As New DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Grupos".
        DA.Fill(ds, "GastosTipo")
        ''Cierro la conexión
        dbconn.Close()
        Return ds
    End Function
#End Region
End Class
