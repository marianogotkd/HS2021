Public Class US_administrador

    Dim _enabledCerrar As Boolean = False

    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")> _
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property

    'MENU
    Dim form_anterior
    Public Sub llamar_Form(ByVal var)
        If (Me.PN_Entrada.Controls.Count > 0) Then
            Me.PN_Entrada.Controls.RemoveAt(0)
            If form_anterior.ToString <> var.ToString Then
                form_anterior.close()
            End If
            var.TopLevel = False
            var.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            var.Dock = DockStyle.Fill
            Me.PN_Entrada.Controls.Add(var)
            Me.PN_Entrada.Tag = var
            form_anterior = var
            var.Show()
        Else
            var.TopLevel = False
            var.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            var.Dock = DockStyle.Fill
            Me.PN_Entrada.Controls.Add(var)
            Me.PN_Entrada.Tag = var
            form_anterior = var
            var.Show()
        End If
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        llamar_Form(Cliente_modificar)
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        llamar_Form(Proveedor_modificar)
    End Sub

    Private Sub NuevoEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Empleado_alta)
    End Sub

    Private Sub ModificarEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Empleado_modificar)
    End Sub

    Private Sub ListaNuevaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Lista_alta)
    End Sub

    Private Sub ListaActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Lista_producto_gestion)
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Proveedor_alta)
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Proveedor_modificar)
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Categorias)
    End Sub

    Private Sub NuevoProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Producto_alta)
    End Sub

    Private Sub ActualizarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Producto_modificar)
    End Sub



    Private Sub CargarServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Servicios_Alta)
    End Sub

    'TURNO ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub TurnoNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        llamar_Form(Turno_alta)
    End Sub

    Private Sub TurnoFijoNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        llamar_Form(TurnoFijo_alta)
    End Sub

    Private Sub TurnoConfigurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_Configurar)
    End Sub

    Private Sub MailConfigurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_ConfigurarMail)
    End Sub

    Private Sub EmailDestinoConfigurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_ConfigurarMailDestino)
    End Sub

    Private Sub TurnoGestionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'llamar_Form(Turno_Gestion)
        Turno_Gestion.Show()
        Turno_Gestion.Turno_ObtenerIniciado()
    End Sub




    Private Sub NuevoEgresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Egresos_Alta)
    End Sub


    'Cambiar contraseña
    Public USU_id As String
    Dim USU_contr As String
    Private Sub BO_USU_contrasena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_contrasena.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cambiar la Contraseña de Usuario?", "Sistema de Gestion La Santa Fe.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            USU_contrasena.Usuario_Datos(USU_id, USU_contr)
            USU_contrasena.Show()
        End If
    End Sub

    Private Sub BO_USU_sesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_sesion.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cerrar la Sesion de Usuario?", "Sistema de Gestion La Santa Fe.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Me.Close()
            Inicio.Visible = True
        End If
    End Sub

    Private Sub BO_USU_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_cerrar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cerrar el Sistema?", "Sistema de Gestion La Santa Fe.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Me.Close()
            Inicio.Close()
        End If
    End Sub



    Private Sub NuevoPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Pedidos_Nuevo)
    End Sub

    Private Sub VentaEnCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Venta_Caja_gestion)
    End Sub

    Private Sub BuscarProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Busqueda_Productos)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'llamar_Form(Turno_Gestion)
        Turno_Gestion.Show()
        Turno_Gestion.Turno_ObtenerIniciado()
        Button1.Visible = False
    End Sub

    '////////////////////////////////////////////////////////////////////////////////

    Public Sub Configuracion(ByVal ds_usu As DataSet)
        LB_USU_ape.Text = (CType(ds_usu.Tables(0).Rows(0).Item("USU_ape"), String)) + " " + (CType(ds_usu.Tables(0).Rows(0).Item("USU_nom"), String))
        LB_UT_dep.Text = (CType(ds_usu.Tables(0).Rows(0).Item("UT_desc"), String))
        USU_id = (CType(ds_usu.Tables(0).Rows(0).Item("USU_id"), String))
        USU_contr = (CType(ds_usu.Tables(0).Rows(0).Item("USU_cont"), String))
        Inicio.Visible = False
    End Sub


    Private Sub PedidosConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Pedidos_Consulta)
    End Sub

    'Tiempo ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Public Sub Iniciar_Tiempo()
        Dim Tiempo As Integer = 60
        Call TiempoEjecutar(Tiempo)
    End Sub

    Private TiempoRestante As Integer

    Public Function TiempoEjecutar(ByVal Tiempo As Integer)
        TiempoEjecutar = ""
        TiempoRestante = Tiempo  ' 1 minutos=60 segundos 
        Timer1.Interval = 1000

        Call TimerOn(1000) ' Hechanos a andar el timer
    End Function

    Public Sub TimerOn(ByRef Interval As Short)
        If Interval > 0 Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Dim APturno As New Aplicacion.Turno
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TiempoRestante >= 0 Then
            TiempoRestante = TiempoRestante - 1
        Else
            APturno.TurnoIniciado_control(1)
        End If
    End Sub

    Dim DAcliente As New Datos.Cliente
    Private Sub ClienteInformeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ds_cliente As DataSet = DAcliente.Informe_Cliente
        If ds_cliente.Tables(0).Rows.Count > 0 Then
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_InformeCliente.rpt")
            CrReport.Database.Tables("Cliente").SetDataSource(ds_cliente.Tables(0))
            Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
            Informe_Mostrar.Show()
        End If

    End Sub

    Private Sub InformeEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim DAempleado As New Datos.Empleado
    Private Sub FuncionYRemuneracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ds_empleado As DataSet = DAempleado.Informe_Empleado
        If ds_empleado.Tables(0).Rows.Count > 0 Then
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_InformeEmpleado.rpt")

            CrReport.Database.Tables("Empleado").SetDataSource(ds_empleado.Tables(0))
            'CrReport.SetDataSource(ds_Jugador.Tables(0))
            Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
            'ERROR_Socio.Visible = False
            Informe_Mostrar.Show()
        End If
    End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ds_empleado As DataSet = DAempleado.Informe_Empleado
        If ds_empleado.Tables(0).Rows.Count > 0 Then
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_InformeEmpleDP.rpt")

            CrReport.Database.Tables("Empleado").SetDataSource(ds_empleado.Tables(0))
            'CrReport.SetDataSource(ds_Jugador.Tables(0))
            Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
            'ERROR_Socio.Visible = False
            Informe_Mostrar.Show()
        End If
    End Sub


    Private Sub PedidoNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Pedidos_Nuevo)
    End Sub

    Private Sub PedidoActualziarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Pedidos_Consulta)
    End Sub

    Private Sub EgresoNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Egresos_Alta)
    End Sub

    Private Sub ServicioNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        llamar_Form(Servicios_Alta)
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        llamar_Form(Usuario_alta)
    End Sub

    Private Sub UsuarioActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioActualizarToolStripMenuItem.Click
        llamar_Form(Usuario_modificar)
    End Sub

    Private Sub US_administrador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        llamar_Form(PN_Inicio)
    End Sub

    Private Sub VentaEnMesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Mesas_gestion)
    End Sub


    Private Sub TurnoFijoNuevoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        llamar_Form(TurnoFijo_alta)
    End Sub

    Private Sub TurnoFijoActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(TurnoFijo_Modificar)
    End Sub

    Private Sub TurnoComunNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_alta)
    End Sub

    Private Sub TurnoComunEliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_Eliminar)
    End Sub

    Private Sub EgresosRegistradosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Egresos_registrados_consulta)
    End Sub

    Private Sub SonidoAlarmaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Turno_Alarma.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Turno_Alarma.Show()
    End Sub

    Private Sub TurnoConsultaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Turno_Consulta.Show()
        Turno_Consulta_ampliada.Show()
    End Sub

    Private Sub VentaEnMesas2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Mesas_gestion_2)
    End Sub

    
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Registro_inicio_cierre.Show()
    End Sub

    Private Sub BO_Caja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Caja.Click
        Registro_inicio_cierre.Show()
        Registro_inicio_cierre.Habilitar()
    End Sub

    Private Sub VentasConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(VentaRegional_consulta)
    End Sub

    Private Sub BO_TurnoConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_TurnoConsulta.Click
        'Turno_Consulta.Show()
        Turno_Consulta_ampliada.Show()
    End Sub

    Private Sub TurnoInformeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_Informe)
    End Sub

    Private Sub CajaConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Caja_consulta)
    End Sub

    Private Sub CalculadoraDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("C:\WINDOWS\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub TurnoConsultaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Turno_Consulta.Show()
        Turno_Consulta_ampliada.Show()
    End Sub

    Private Sub RecepciónDeProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Recepcion_gestion)
    End Sub

    Private Sub ListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Recepcion_gestion)
    End Sub

    Private Sub EgresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Retiro_Producto)
    End Sub

    Private Sub PedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Devolución_gestión)
    End Sub




    Private Sub MarcaDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaDeProductosToolStripMenuItem.Click
        Marca_gestion.Show()

    End Sub

    Private Sub VentaDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Venta_regional)
    End Sub

    Private Sub AProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Devolución_gestión)
    End Sub

    Private Sub DeClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Devolucion_cliente)
    End Sub

    Private Sub AProveedorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Retiro_Producto)
    End Sub

    Private Sub DeClienteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Retiro_cliente)
    End Sub

    Private Sub AltaStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Sock_Alta)
    End Sub

    Private Sub VentaDeProductosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaDeProductosToolStripMenuItem.Click
        llamar_Form(VentaRegional_nuevodiseño)
    End Sub

    Private Sub RecepciónDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeProductosToolStripMenuItem.Click
        llamar_Form(Recepcion_nuevo_diseño)
    End Sub

    Private Sub AProveedorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProveedorToolStripMenuItem2.Click
        llamar_Form(Devolución_gestión)
    End Sub

    Private Sub DeClienteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Devolucion_cliente)
    End Sub

    Private Sub AProveedorToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProveedorToolStripMenuItem3.Click
        llamar_Form(Retiro_Producto)
    End Sub

    Private Sub DeClienteToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Retiro_cliente)
    End Sub

    Private Sub RetirosRegistradosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Retiro_consulta.Show()
    End Sub

    
    Private Sub ConsultaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem2.Click
        Recepcion_consulta.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem1.Click
        Retiro_consulta.Show()
    End Sub

    
    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        Devolucion_consulta.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem3.Click
        VentaRegional_consulta.Show()
    End Sub

  
    Private Sub ConsultaGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaGeneralToolStripMenuItem.Click
        Consultar_General.Show()

    End Sub

    
End Class