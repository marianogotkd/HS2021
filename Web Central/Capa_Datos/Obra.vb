Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Obra
    Inherits Capa_Datos.Conexion


    Public Function Obra_Alta(ByVal ObraNombre As String, ByVal ObraDescripcion As String, ByVal ObraDomicilio As String, ByVal ObraLocalidad As String,
                              ByVal ObraFechaInicio As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Obra_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraNombre", ObraNombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraDescripcion", ObraDescripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraDomicilio", ObraDomicilio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraLocalidad", ObraLocalidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraFechaInicio", ObraFechaInicio))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Obra")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Obra_Obtener_x_Id(ByVal ObraId As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Obra_Obtener_x_Id", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraId", ObraId))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " OBRA")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function Obra_Obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Obra_Obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " OBRA")
        dbconn.Close()
        Return ds_usu
    End Function


    Public Function Obra_modificar(ByVal ObraId As Integer, ByVal ObraNombre As String, ByVal ObraDescripcion As String, ByVal ObraDomicilio As String,
                              ByVal ObraLocalidad As String, ByVal ObraFechaInicio As Date, ByVal ObraFechaFinal As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Obra_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraId", ObraId))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraNombre", ObraNombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraDescripcion", ObraDescripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraDomicilio", ObraDomicilio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraLocalidad", ObraLocalidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraFechaInicio", ObraFechaInicio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraFechaFinal", ObraFechaFinal))
        ' crear dataset que sirve de contenedor para todos los datatables
        ''el dataset es un contenedor, repositorio
        Dim ds As New DataSet() 'System.Data.DataSet()
        Dim DA As New OleDbDataAdapter(comando)
        ''Fill= Método que Agrega filas al objeto DataSet y crea un objeto DataTable denominado "Tabla", en nuestro caso "Producto".
        DA.Fill(ds, "Obra_modificar")
        ''Cierro la conexión
        dbconn.Close()
        ''Como toda función debe retornar al uso RETURN
        Return ds
    End Function

    Public Function Obra_Eliminar(ByVal ObraId As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Obra_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ObraId", ObraId))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " Obra_Eliminar")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function Obra_Obtener_Fecha() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Obra_Obtener_Fecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, " OBRA")
        dbconn.Close()
        Return ds_usu
    End Function

End Class
