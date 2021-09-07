Public Class Caja

    Dim DAcaja As New Datos.Caja

    Dim DAusuario As New Datos.Usuario

    Public SESION_CAJA As Integer

    Public Sub Caja_Validar()
        Dim ds_caja As DataSet = DAcaja.Caja_validad_AperturayCierre()

        If ds_caja.Tables(0).Rows.Count = 0 Then
            'No Existe Sesion Abierta
            SESION_CAJA = 1
        Else
            Dim S As Integer = 0

            'Sesiones Abiertas
            Dim B As Integer = 0
            While B < ds_caja.Tables(0).Rows.Count
                Dim USU_id As Integer = ds_caja.Tables(0).Rows(B).Item("USU_id").ToString
                If USU_id = Inicio.USU_id Then
                    Inicio.CAJA_id = ds_caja.Tables(0).Rows(B).Item("CAJA_id").ToString
                    S = 1
                End If
                B = B + 1
            End While

            If S = 1 Then
                SESION_CAJA = 2
            Else
                SESION_CAJA = 3
            End If
        End If

        Select Case (SESION_CAJA)
            Case (1)
                Dim Ruta As String = Application.StartupPath & "\..\..\\Resources\Caja.png"
                US_administrador.BO_Caja.Image = Image.FromFile(Ruta)
                US_Empleado.BO_Caja.Image = Image.FromFile(Ruta)

                US_administrador.ToolStripDropDownButton6.Enabled = True   'boton de ventas  ADMINISTRADOR
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = False   'venta en caja
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnMesas2ToolStripMenuItem").Enabled = False  'venta en mesas
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentasConsultasToolStripMenuItem").Enabled = True  'venta consulta

                US_Empleado.ToolStripDropDownButton6.Enabled = True   'boton de ventas  EMPLEADO
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = False   'venta en caja
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnMesasToolStripMenuItem").Enabled = False  'venta en mesas
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaConsultaToolStripMenuItem").Enabled = True  'venta consulta


                'US_administrador.TurnoGestionToolStripMenuItem.Enabled = False
                'US_administrador.TurnoFijoNuevoToolStripMenuItem.Enabled = False
                'US_administrador.TurnoComunNuevoToolStripMenuItem.Enabled = False

                US_Empleado.TurnoGestionToolStripMenuItem.Enabled = False
                US_Empleado.TurnoFijoNuevoToolStripMenuItem1.Enabled = False
                US_Empleado.TurnoComunNuevoToolStripMenuItem.Enabled = False
            Case (2)
                Dim Ruta As String = Application.StartupPath & "\..\..\\Resources\CajaAbierta.png"
                US_administrador.BO_Caja.Image = Image.FromFile(Ruta)
                US_Empleado.BO_Caja.Image = Image.FromFile(Ruta)

                US_administrador.ToolStripDropDownButton6.Enabled = True
                US_Empleado.ToolStripDropDownButton6.Enabled = True



                US_administrador.ToolStripDropDownButton6.Enabled = True   'boton de ventas  ADMINISTRADOR
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = True    'venta en caja
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnMesas2ToolStripMenuItem").Enabled = True   'venta en mesas
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentasConsultasToolStripMenuItem").Enabled = True   'venta consulta

                US_Empleado.ToolStripDropDownButton6.Enabled = True   'boton de ventas EMPLEADO
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = True    'venta en caja
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnMesasToolStripMenuItem").Enabled = True   'venta en mesas
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaConsultaToolStripMenuItem").Enabled = True   'venta consulta

                'US_administrador.TurnoGestionToolStripMenuItem.Enabled = True
                'US_administrador.TurnoFijoNuevoToolStripMenuItem.Enabled = True
                'US_administrador.TurnoComunNuevoToolStripMenuItem.Enabled = True

                US_Empleado.TurnoGestionToolStripMenuItem.Enabled = True
                US_Empleado.TurnoFijoNuevoToolStripMenuItem1.Enabled = True
                US_Empleado.TurnoComunNuevoToolStripMenuItem.Enabled = True
            Case (3)
                Dim Ruta As String = Application.StartupPath & "\..\..\\Resources\CajaCerrada.png"
                US_administrador.BO_Caja.Image = Image.FromFile(Ruta)
                US_Empleado.BO_Caja.Image = Image.FromFile(Ruta)

                US_administrador.ToolStripDropDownButton6.Enabled = False
                US_Empleado.ToolStripDropDownButton6.Enabled = False


                US_administrador.ToolStripDropDownButton6.Enabled = True   'boton de ventas  ADMINISTRADOR
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = False   'venta en caja
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnMesas2ToolStripMenuItem").Enabled = False  'venta en mesas
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentasConsultasToolStripMenuItem").Enabled = True  'venta consulta

                US_Empleado.ToolStripDropDownButton6.Enabled = True  'boton de ventas EMPLEADO
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = False   'venta en caja
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnMesasToolStripMenuItem").Enabled = False  'venta en mesas
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaConsultaToolStripMenuItem").Enabled = True  'venta consulta

                'US_administrador.TurnoGestionToolStripMenuItem.Enabled = False
                'US_administrador.TurnoFijoNuevoToolStripMenuItem.Enabled = False
                'US_administrador.TurnoComunNuevoToolStripMenuItem.Enabled = False

                US_Empleado.TurnoGestionToolStripMenuItem.Enabled = False
                US_Empleado.TurnoFijoNuevoToolStripMenuItem1.Enabled = False
                US_Empleado.TurnoComunNuevoToolStripMenuItem.Enabled = False
        End Select

    End Sub



End Class
