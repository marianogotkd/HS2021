Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Stock
    Inherits Datos.Conexion
    Public Function Stock_alta(ByVal Stock_codigo As String,
                                  ByVal Stock_fecha_sistema As Date,
                                  ByVal Stock_codigoproducto As String,
                                  ByVal Stock_nombreproducto As String,
                                  ByVal Stock_PROD_T_id As Integer,
                                  ByVal Stock_nrolote As String,
                                 ByVal Stock_condi_alm As String,
                                 ByVal Stock_cantidad As Integer,
                                 ByVal Stock_fechavencimiento As Date,
                                 ByVal Stock_Marca_id As Integer,
                                 ByVal Stock_nrofactura As String,
                                 ByVal Stock_fechafactura As Date,
                                 ByVal Stock_Prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Stock_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_codigo", Stock_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_fecha_sistema", Stock_fecha_sistema))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_codigoproducto", Stock_codigoproducto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_nombreproducto", Stock_nombreproducto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_PROD_T_id", Stock_PROD_T_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_nrolote", Stock_nrolote))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_condi_alm", Stock_condi_alm))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_cantidad", Stock_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_fechavencimiento", Stock_fechavencimiento))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_Marca_id", Stock_Marca_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_nrofactura", Stock_nrofactura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_fechafactura", Stock_fechafactura))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Stock_Prov_id", Stock_Prov_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function
End Class
