﻿Public Class US_administrador
    Public Terminal_id As Integer
    Dim _enabledCerrar As Boolean = False
    Dim dausuario As New Datos.Usuario
    Dim APcaja As New Aplicacion.Caja 'la uso para validar la apertura de caja entre otras cosas
    Dim DAterminal As New Datos.Terminal
    Public no_caja As String 'esta variable se actualiza en el procedimiento publico de clalase Caja.Caja_validar
    Public apellidoynombre As String 'este es el usuario que tiene abierto el turno en caja
    Public TurnoUsuario_id As Integer 'usado en la clase caja.caja_validar
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

    Private Sub NuevoEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoEmpleadoToolStripMenuItem.Click
        llamar_Form(Empleado_alta)
    End Sub

    Private Sub ModificarEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarEmpleadoToolStripMenuItem.Click
        llamar_Form(Empleado_modificar)
    End Sub

    Private Sub ListaNuevaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaNuevaToolStripMenuItem.Click
        llamar_Form(Lista_alta)
    End Sub

    Private Sub ListaActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaActualizarToolStripMenuItem.Click
        llamar_Form(Lista_producto_gestion)
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorAgregar_ToolStripMenuItem.Click
        'llamar_Form(Proveedor_alta)
        Proveedor_alta.Show()
        Proveedor_alta.tx_nombre.Focus()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorModificar_ToolStripMenuItem.Click
        'llamar_Form(Proveedor_modificar)
        Proveedor_modificar.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_Stock_Categoria.Click
        'llamar_Form(Categorias)
        Categoria_Actualizar.Show()
    End Sub

    Private Sub NuevoProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Producto_alta)
    End Sub

    Private Sub ActualizarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarProductoToolStripMenuItem.Click
        'llamar_Form(Producto_modificar)
        Producto_modificar.Close()
        Producto_modificar.Show()
    End Sub



    Private Sub CargarServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Servicios_Alta)
    End Sub

    'TURNO ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub TurnoNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_alta)
    End Sub

    Private Sub TurnoFijoNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(TurnoFijo_alta)
    End Sub

    Private Sub TurnoConfigurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoConfigurarToolStripMenuItem.Click
        llamar_Form(Turno_Configurar)
    End Sub

    Private Sub MailConfigurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailConfigurarToolStripMenuItem.Click
        llamar_Form(Turno_ConfigurarMail)
    End Sub

    Private Sub EmailDestinoConfigurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailDestinoConfigurarToolStripMenuItem.Click
        llamar_Form(Turno_ConfigurarMailDestino)
    End Sub

    Private Sub TurnoGestionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoGestionToolStripMenuItem.Click
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
        result = MessageBox.Show("¿Desea cambiar la Contraseña de Usuario?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            USU_contrasena.Usuario_Datos(USU_id, USU_contr)
            USU_contrasena.Show()
        End If
    End Sub

    Private Sub BO_USU_sesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_sesion.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cerrar la Sesion de Usuario?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'cierro todos los form que quedaron abiertos.
            For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 1 Step -1
                Dim form As Form = System.Windows.Forms.Application.OpenForms(i)
                If form.Name <> "Inicio" Then
                    form.Close()
                End If
            Next i
            'elimino la relacion de usuario con terminal
            DAterminal.Usuario_x_Terminal_eliminar(Inicio.terminal_id)
            Me.Close()
            Inicio.Visible = True
        End If
    End Sub

    Private Sub BO_USU_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_cerrar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cerrar el Sistema?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Me.Close()
            Inicio.Close()
        End If
    End Sub



    Private Sub NuevoPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Pedidos_Nuevo)
    End Sub

    Private Sub VentaEnCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaEnCajaToolStripMenuItem.Click
        'Venta_Caja_gestion.Show()
        Venta_Caja_seleccion_tipo_vta.Show()
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
        'Call TiempoEjecutar(Tiempo)
    End Sub

    Private TiempoRestante As Integer





    Dim APturno As New Aplicacion.Turno
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TiempoRestante >= 0 Then
        '    TiempoRestante = TiempoRestante - 1
        'Else
        '    APturno.TurnoIniciado_control(1)
        'End If
    End Sub

    Dim DAcliente As New Datos.Cliente
    Dim Cliente_reporte_ds As New Cliente_reporte_ds 'esto lo hago para poder referencias al ds del proyecto
    Private Sub ClienteInformeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'primero limpio los datos de reporte
        Cliente_reporte_ds.Tables("Cliente").Rows.Clear()
        Cliente_reporte_ds.Tables("Empresa").Rows.Clear()

        'ahora recupero de la bd todos los clientes
        Dim ds_cliente As DataSet = DAcliente.Cliente_obtenertodos_reporte()
        If ds_cliente.Tables(0).Rows.Count <> 0 Then
            MessageBox.Show("A continuacion se listaran los clientes registrados", "Sistema de Gestión")

            'Clientes
            Cliente_reporte_ds.Tables("Cliente").Merge(ds_cliente.Tables(0))

            'Empresa
            Cliente_reporte_ds.Tables("Empresa").Merge(ds_cliente.Tables(1))

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Cliente\Reporte\CR_listadocliente.rpt")
            CrReport.Database.Tables("Cliente").SetDataSource(Cliente_reporte_ds.Tables("Cliente"))
            CrReport.Database.Tables("Empresa").SetDataSource(Cliente_reporte_ds.Tables("Empresa"))

            Cliente_reporte_show.CrystalReportViewer1.ReportSource = CrReport
            Cliente_reporte_show.Show()
        Else
            MessageBox.Show("No hay clientes registrados", "Sistema de Gestión")
        End If


        'Dim ds_cliente As DataSet = DAcliente.Informe_Cliente
        'If ds_cliente.Tables(0).Rows.Count > 0 Then
        '    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        '    CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_InformeCliente.rpt")
        '    CrReport.Database.Tables("Cliente").SetDataSource(ds_cliente.Tables(0))
        '    Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
        '    Informe_Mostrar.Show()
        'End If

    End Sub

    Private Sub InformeEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeEmpleadoToolStripMenuItem.Click

    End Sub
    Dim DAempleado As New Datos.Empleado
    Private Sub FuncionYRemuneracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionYRemuneracionToolStripMenuItem.Click
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

    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
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
        'llamar_Form(Pedidos_Consulta)
        Pedido_Productos.Show()
    End Sub

    Private Sub EgresoNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Egresos_Alta)
    End Sub

    Private Sub ServicioNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Servicios_Alta)
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Usuario_alta.Close()
        Usuario_alta.Show()
        'llamar_Form(Usuario_alta)
    End Sub

    Private Sub UsuarioActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioActualizarToolStripMenuItem.Click
        Usuario_modificar.Close()
        Usuario_modificar.Show()
        'llamar_Form(Usuario_modificar)
    End Sub

    Private Sub Permisos_USU(ByVal Tipo As String)
        'Para Dialisis oculto TODO solo muestro lo que  necesito'
        Dim DS_Modulos As DataSet = dausuario.UsuarioModulos_obtener(Inicio.UT_id)
        Dim i As Integer = 0
        While i < DS_Modulos.Tables(0).Rows.Count


            '________PACIENTE________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "PAC_actualizar" Then
                Tool_Paciente.Visible = True
                MenuItem_PAC_Act.Visible = True
                Label_paciente.Visible = True
                Separator_Paciente.Visible = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "PAC_Nuevo" Then
                Tool_Paciente.Visible = True
                MenuItem_PAC_nuevo.Visible = True
                Label_paciente.Visible = True
                Separator_Paciente.Visible = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "PAC_HC" Then
                Tool_Paciente.Visible = True
                MenuItem_PAC_HC.Visible = True
                Label_paciente.Visible = True
                Separator_Paciente.Visible = True
            End If


            '______________FIN PACIENTE_____________


            '________ENFERMERIA________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_NSD" Then
                Tool_Enfermeria.Visible = True
                MenuItem_ENF_NSD.Visible = True
                Label_Enfermeria.Visible = True
                Separator_Enfermeria.Visible = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_ID" Then
                Tool_Enfermeria.Visible = True
                MenuItem_ENF_Informe.Visible = True
                Label_Enfermeria.Visible = True
                Separator_Enfermeria.Visible = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_Consulta" Then
                Tool_Enfermeria.Visible = True
                MenuItem_ENF_Consulta.Visible = True
                Label_Enfermeria.Visible = True
                Separator_Enfermeria.Visible = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_RevMov" Then
                Tool_Enfermeria.Visible = True
                MenuItem_ENF_RegMov.Visible = True
                Label_Enfermeria.Visible = True
                Separator_Enfermeria.Visible = True
            End If



            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_stock" Then
                Tool_Enfermeria.Visible = True
                MenuItem_ENF_stock.Visible = True
                Label_Enfermeria.Visible = True
                Separator_Enfermeria.Visible = True
            End If
            '________ENFERMERIA________



            '________MEDICO________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "MEDICO_Nuevo" Then
                Tool_Medico.Visible = True
                MenuItem_MEDICO_nuevo.Visible = True
                Label_Medicos.Visible = True
                Separator_Medico.Visible = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "MEDIOC_Consulta" Then
                Tool_Medico.Visible = True
                MenuItem_MEDICO_consulta.Visible = True
                Label_Medicos.Visible = True
                Separator_Medico.Visible = True
            End If

            '______________FIN MEDICO_____________


            '________OBRA SOCIAL________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "OBRA_nuevo" Then
                Tool_ObraSocial.Visible = True
                Label_ObraSocial.Visible = True
                MenuItem_OBRA_nuevo.Visible = True
                Separator_ObraSocial.Visible = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "OBRA_Actualizar" Then
                Tool_ObraSocial.Visible = True
                Label_ObraSocial.Visible = True
                MenuItem_OBRA_actualizar.Visible = True
                Separator_ObraSocial.Visible = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "OBRA_InfPac" Then
                Tool_ObraSocial.Visible = True
                Label_ObraSocial.Visible = True
                MenuItem_OBRA_informe.Visible = True
                Separator_ObraSocial.Visible = True
            End If

            '______________OBRA SOCIAL_____________


            '________DEPOSITO y MOVIMIENTOS________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "DEP_Ingreso" Then
                Tool_Deposito.Visible = True
                Label_deposito.Visible = True
                MenuItem_DEP_ingreso.Visible = True
                Separator_deposito.Visible = True
            End If


            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "DEP_Mov" Then
                Tool_Deposito.Visible = True
                Label_deposito.Visible = True
                MenuItem_DEP_Mov.Visible = True
                Separator_deposito.Visible = True
            End If


            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "DEP_Baja" Then
                Tool_Deposito.Visible = True
                Label_deposito.Visible = True
                MenuItem_DEP_baja.Visible = True
                Separator_deposito.Visible = True
            End If


            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "DEP_Consultas" Then
                Tool_Deposito.Visible = True
                Label_deposito.Visible = True
                MenuItem_DEP_Consulta.Visible = True
                Separator_deposito.Visible = True
            End If

            '______________DEPOSITO y MOVIMIENTOS____________




            '____STOCK______________________


            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Insumos" Then
                Tool_stock.Visible = True '- Icono
                MenuItem_Stock_Insumos.Visible = True
                ' ProductoNuevoNEWToolStripMenuItem.Visible = True
                Label_stock.Visible = True
                Separator_stock.Visible = True

            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Prove" Then
                Tool_stock.Visible = True '- Icono
                MenuItem_Stock_Prov.Visible = True
                ' ProductoNuevoNEWToolStripMenuItem.Visible = True
                Label_stock.Visible = True
                Separator_stock.Visible = True

            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Marca" Then
                Tool_stock.Visible = True '- Icono
                MenuItem_Stock_marca.Visible = True
                ' ProductoNuevoNEWToolStripMenuItem.Visible = True
                Label_stock.Visible = True
                Separator_stock.Visible = True

            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Cat" Then
                Tool_stock.Visible = True '- Icono
                MenuItem_Stock_Categoria.Visible = True
                ' ProductoNuevoNEWToolStripMenuItem.Visible = True
                Label_stock.Visible = True
                Separator_stock.Visible = True

            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Consumir" Then
                Tool_stock.Visible = True '- Icono
                MenuItem_Stock_consumir.Visible = True
                ' ProductoNuevoNEWToolStripMenuItem.Visible = True
                Label_stock.Visible = True
                Separator_stock.Visible = True

            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Consulta" Then
                Tool_stock.Visible = True '- Icono
                MenuItem_Stock_Consulta.Visible = True
                ' ProductoNuevoNEWToolStripMenuItem.Visible = True
                Label_stock.Visible = True
                Separator_stock.Visible = True

            End If

            '____________FIN SOTCK__________________






            If DS_Modulos.Tables(0).Rows(i).Item("UT_id") = "1" Then

                '        '___CONFIGURACION_______

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "CONF_Usuario" Then
                    ToolS_Configuracion.Visible = True '- Icono
                    MenuItem_CONF_usuario.Visible = True
                    Separator_Conf.Visible = True
                    Label_Configuraciones.Visible = True
                    'NuevoUsuarioToolStripMenuItem.Visible = True

                End If


                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "CONF_Sucursal" Then
                    ToolS_Configuracion.Visible = True '- Icono
                    MenuItem_CONF_Sucursales.Visible = True
                    Separator_Conf.Visible = True
                    Label_Configuraciones.Visible = True
                    'NuevoUsuarioToolStripMenuItem.Visible = True

                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "CONF_Empresa" Then
                    ToolS_Configuracion.Visible = True '- Icono
                    MenuItem_CONF_empresa.Visible = True
                    Separator_Conf.Visible = True
                    Label_Configuraciones.Visible = True
                    'NuevoUsuarioToolStripMenuItem.Visible = True

                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "CONF_Turnos" Then
                    ToolS_Configuracion.Visible = True '- Icono
                    MenuItem_CONF_turnos.Visible = True
                    Separator_Conf.Visible = True
                    Label_Configuraciones.Visible = True
                    'NuevoUsuarioToolStripMenuItem.Visible = True

                End If

            End If


          


            i = i + 1
        End While


        '    Dim DS_Modulos As DataSet = dausuario.UsuarioModulos_obtener(Inicio.UT_id)
        '    Dim i As Integer = 0
        '    While i < DS_Modulos.Tables(0).Rows.Count

        '        '_____CLiente______
        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Cliente_Nuevo" Then
        '            ToolStripDropDownButton2.Visible = True '- Icono
        '            NuevoClienteToolStripMenuItem.Visible = True


        '        End If
        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Cliente_Informe" Then
        '            'El informe se lo saca del menu 12-12-19
        '            ToolStripDropDownButton2.Visible = True '- Icono
        '            'ClienteInformeToolStripMenuItem.Visible = False


        '        End If
        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Cliente_Actulizar" Then
        '            ToolStripDropDownButton2.Visible = True '- Icono
        '            'BusquedaToolStripMenuItem.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Cliente_CtaCte" Then
        '            ToolStripDropDownButton2.Visible = True '- Icono

        '            'Si usa ctacte se habilitan los remitos sino no
        '            'CuentaCorrienteToolStripMenuItem.Visible = True
        '            RemitoToolStripMenuItem.Visible = True

        '        End If


        '        '___Fin CLiente____


        '        '____STOCK______________________

        '        '_Proveedores_____

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Proveedor_Nuevo" Then
        '            ToolStripDropDownButton4.Visible = True '- Icono
        '            ProveedorToolStripMenuItem.Visible = True
        '            AgregarToolStripMenuItem.Visible = True
        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Proveedor_Actualizar" Then
        '            ToolStripDropDownButton4.Visible = True '- Icono
        '            ModificarToolStripMenuItem.Visible = True
        '            ProveedorToolStripMenuItem.Visible = True

        '        End If

        '        '_______________

        '        '_Producto_____

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Producto_Nuevo" Then
        '            ToolStripDropDownButton4.Visible = True '- Icono
        '            ProductosToolStripMenuItem.Visible = True
        '            ProductoNuevoNEWToolStripMenuItem.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Producto_Actualizar" Then
        '            ToolStripDropDownButton4.Visible = True '- Icono
        '            ProductosToolStripMenuItem.Visible = True
        '            ActualizarProductoToolStripMenuItem.Visible = True

        '        End If
        '        '_______________

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Categoria" Then
        '            ToolStripDropDownButton4.Visible = True '- Icono
        '            CategoriasToolStripMenuItem.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Gestion_Mercaderia" Then
        '            ToolStripDropDownButton4.Visible = True '- Icono
        '            GestionDeMercaderiaToolStripMenuItem.Visible = True


        '        End If
        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Consulta_Movimiento" Then
        '            ToolStripDropDownButton4.Visible = True '- Icono
        '            MovimientosDeMercaderiaToolStripMenuItem.Visible = True


        '        End If


        '        '____________FIN SOTCK__________________

        '        '___VENTAS______

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Venta_Caja" Then
        '            ToolStripDropDownButton6.Visible = True '- Icono
        '            VentaEnCajaToolStripMenuItem.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Venta_Consulta" Then
        '            ToolStripDropDownButton6.Visible = True '- Icono
        '            VentasConsultasToolStripMenuItem.Visible = True

        '        End If
        '        '________FIN VENTAS________

        '        '_______PEDIDOS_________

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Pedidos_Nuevo" Then
        '            ToolStripDropDownButton7.Visible = True '- Icono
        '            NuevoToolStripMenuItem.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Pedidos_Consulta" Then
        '            ToolStripDropDownButton7.Visible = True '- Icono
        '            ConsultaToolStripMenuItem1.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Pedidos_Recepcion" Then
        '            ToolStripDropDownButton7.Visible = True '- Icono
        '            RecepciónToolStripMenuItem.Visible = True

        '        End If
        '        '_________FIN PEDIDOS___________

        '        '___SERVICIOS________
        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Servicio_Nuevo" Then
        '            ToolStripDropDownButtonServicios.Visible = True '- Icono
        '            ToolStripMenuItem_servicio_nuevo.Visible = True
        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Servicio_Consulta" Then
        '            ToolStripDropDownButtonServicios.Visible = True '- Icono
        '            ToolStripMenuItem3.Visible = True
        '        End If
        '        '____________

        '        '___CONFIGURACION_______
        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Usuario_Nuevo" Then
        '            ToolStripDropDownButtonConfiguracion.Visible = True '- Icono
        '            UsuarioToolStripMenuItem1.Visible = True
        '            NuevoUsuarioToolStripMenuItem.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Usuario_Actualizar" Then
        '            ToolStripDropDownButtonConfiguracion.Visible = True '- Icono
        '            UsuarioToolStripMenuItem1.Visible = True
        '            UsuarioActualizarToolStripMenuItem.Visible = True


        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Usuario_Permisos" Then
        '            ToolStripDropDownButtonConfiguracion.Visible = True '- Icono
        '            UsuarioToolStripMenuItem1.Visible = True
        '            PermisosToolStripMenuItem.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Sucursal" Then
        '            ToolStripDropDownButtonConfiguracion.Visible = True '- Icono
        '            SucursalesToolStripMenuItem.Visible = True

        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Empresa" Then
        '            ToolStripDropDownButtonConfiguracion.Visible = True '- Icono
        '            EmpresaToolStripMenuItem.Visible = True
        '        End If

        '        '___CAJA________
        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Caja_CiereCaja" Then
        '            ToolStripDropDownButton8.Visible = True '- Icono
        '            Caja_ToolStripMenuItem1.Visible = True
        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Caja_EgreIngr" Then
        '            ToolStripDropDownButton8.Visible = True '- Icono
        '            EgresosToolStripMenuItem.Visible = True
        '        End If

        '        If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Caja_Consulta" Then
        '            ToolStripDropDownButton8.Visible = True '- Icono
        '            ConsultarCajasToolStripMenuItem.Visible = True
        '        End If

        '        '____________


        '        i = i + 1
        '    End While




    End Sub
    Private Sub US_administrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llamar_Form(PN_Inicio)
        Permisos_USU(Inicio.tipo_usuario)
        BO_Caja.Visible = False
        Btn_corte_caja.Visible = False



    End Sub

    Private Sub VentaEnMesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Mesas_gestion)
    End Sub


    Private Sub TurnoFijoNuevoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoFijoNuevoToolStripMenuItem.Click
        llamar_Form(TurnoFijo_alta)
    End Sub

    Private Sub TurnoFijoActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoFijoActualizarToolStripMenuItem.Click
        llamar_Form(TurnoFijo_Modificar)
    End Sub

    Private Sub TurnoComunNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoComunNuevoToolStripMenuItem.Click
        llamar_Form(Turno_alta)
    End Sub

    Private Sub TurnoComunEliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoComunEliminarToolStripMenuItem.Click
        llamar_Form(Turno_Eliminar)
    End Sub

    Private Sub EgresosRegistradosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Egresos_registrados_consulta)
    End Sub

    Private Sub SonidoAlarmaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SonidoAlarmaToolStripMenuItem.Click
        Turno_Alarma.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Turno_Alarma.Show()
    End Sub

    Private Sub TurnoConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Turno_Consulta.Show()
        Turno_Consulta_ampliada.Show()
    End Sub

    Private Sub VentaEnMesas2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaEnMesas2ToolStripMenuItem.Click
        llamar_Form(Mesas_gestion_2)
    End Sub


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caja_ToolStripMenuItem1.Click
        Registro_inicio_cierre.Show()
    End Sub


    Private Sub BO_Caja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Caja.Click
        If Inicio.UT_id = 1 Then
            '//////////choco 17-12-2019//////////////////
            APcaja.Caja_Validar_admin()
            If APcaja.SESION_CAJA = 1 And no_caja <> "deshabilitar" Then '1 = caja nueva, lista para iniciar
                Caja_abrir_turno.Close()
                Caja_abrir_turno.Show()
            Else
                If APcaja.SESION_CAJA = 2 And no_caja <> "deshabilitar" Then 'si esta abierta no importa quien sea el responsable. Como admin puedo realizar la venta siempre registrando los ingresos en la caja activa.
                    '2 =  la caja esta abierta y lista para vender
                    Registro_cierre_caja.Close()
                    Registro_cierre_caja.Show()
                End If
            End If
            '///////fin 17-12-2019////////////////
        Else
            'diseño alternativo choco: 04-07-2019////////////////
            APcaja.Caja_Validar()
            If APcaja.SESION_CAJA = 1 And no_caja <> "deshabilitar" Then '1 = caja nueva, lista para iniciar
                Caja_abrir_turno.Close()
                Caja_abrir_turno.Show()
            Else
                If APcaja.SESION_CAJA = 2 And no_caja <> "deshabilitar" Then
                    '2 =  la caja esta abierta y lista para vender
                    Registro_cierre_caja.Close()
                    Registro_cierre_caja.Show()
                Else
                    MessageBox.Show("Error!, No puede acceder a la caja, esta siendo utilizada por el usuario: " + apellidoynombre, "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            '/////////////////////////////////////////////////
        End If



        ''esto es lo que funcionaba antes////////no uso turnos///////////////////
        'Registro_inicio_cierre.Show()
        'Registro_inicio_cierre.Habilitar()
    End Sub

    Private Sub VentasConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasConsultasToolStripMenuItem.Click
        'llamar_Form(Venta_consulta_seleccionar_sucursal)
        If Inicio.UT_id = 1 Then 'el UT es el tipo de usuario, el 1 es administrador
            '__________cierro forms ________________
            Venta_consulta_seleccionar_sucursal.Close()
            Venta_consulta_sucursal.Close()
            Venta_detalle.Close()
            Venta_detalle_servicio.Close()
            '____________________________________________
            Venta_consulta_seleccionar_sucursal.Procedencia = "Venta_consulta_sucursal"
            Venta_consulta_seleccionar_sucursal.Show()
        Else
            '__________cierro forms ________________
            Venta_consulta_seleccionar_sucursal.Close()
            Venta_consulta_sucursal.Close()
            Venta_detalle.Close()
            Venta_detalle_servicio.Close()
            '____________________________________________
            Venta_consulta_sucursal.sucursal_id = Inicio.suc_id
            Venta_consulta_sucursal.sucursal_nombre = Label_Suc.Text
            'Venta_consulta_sucursal.sucursal_nombre = ComboBox_sucursales.Text
            'Me.Close()
            Venta_consulta_sucursal.Button1.Visible = False 'este es el boton de volver a venta_consulta_seleccionar_sucursal
            Venta_consulta_sucursal.Show()
        End If

    End Sub

    Private Sub BO_TurnoConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_TurnoConsulta.Click
        'Turno_Consulta.Show()
        Turno_Consulta_ampliada.Show()
    End Sub

    Private Sub TurnoInformeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_Informe)
    End Sub

    Private Sub CajaConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaConsultaToolStripMenuItem.Click
        llamar_Form(Caja_consulta)
    End Sub

    Private Sub CalculadoraDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraDelSistemaToolStripMenuItem.Click
        Shell("C:\WINDOWS\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub TurnoConsultaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoConsultaToolStripMenuItem.Click
        'Turno_Consulta.Show()
        Turno_Consulta_ampliada.Show()
    End Sub

    Private Sub TurnoCOMUNToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Turno_comun)
    End Sub

    Private Sub HeladeraGondolaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Gondola)
    End Sub


    Private Sub ClientesnewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cliente_alta_New.Show()
    End Sub

    Private Sub MenuMesasNEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMesasNEWToolStripMenuItem.Click
        Mesas_gestion_2_new.Show()
    End Sub

    Private Sub CierreDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreDeCajaToolStripMenuItem.Click
        Cierre_Caja.Show()
    End Sub

    Private Sub ProductoNuevoNEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoNuevoNEWToolStripMenuItem.Click
        Producto_alta_New.Show()
        Producto_alta_New.tx_descripcion.Focus()

    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_CONF_Sucursales.Click
        Sucursales.Close()
        Sucursales.Show()
    End Sub

    Private Sub GestionDeMercaderiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Producto_Reporte_Global.Close()
        Producto_Reporte_Global.Show()

    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_CONF_empresa.Click
        Empresa.Close()
        Empresa.Show()
        'Empresa_Modificar.Show()
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_PAC_nuevo.Click
        Cliente_alta_New.Show()
    End Sub

    Private Sub BusquedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cliente_modificar.Show()
        Cliente_modificar.Focus()
    End Sub


    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_servicio_nuevo.Click
        Servicio_nuevo.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Servicio_Consulta.Show()
    End Sub


    Private Sub RecepciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónToolStripMenuItem.Click
        'aqui debo ocultar los botones de ver y editar
        Pedidos_Consulta_NEW.Close()
        Pedidos_Consulta_NEW.Text = "Recepción de pedidos (F1 busqueda avanzada)"
        Pedidos_Consulta_NEW.Button_ver.Visible = False
        Pedidos_Consulta_NEW.Button_editar.Visible = False
        Pedidos_Consulta_NEW.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Pedidos_New.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem1.Click
        'aqui debo ocultar el boton de recepcion.
        Pedidos_Consulta_NEW.Close()
        Pedidos_Consulta_NEW.Button_recepcion.Visible = False
        Pedidos_Consulta_NEW.Show()
    End Sub

    Private Sub PermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosToolStripMenuItem.Click
        Permisios_Dialisis.Show()
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosToolStripMenuItem.Click
        Egresos_Ingresos.Close()
        Egresos_Ingresos.Show()
    End Sub

    Private Sub ConsultarCajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarCajasToolStripMenuItem.Click
        'llamar_Form(Venta_consulta_seleccionar_sucursal)
        If Inicio.UT_id = 1 Then 'el UT es el tipo de usuario, el 1 es administrador
            Venta_consulta_seleccionar_sucursal.Procedencia = "Caja_consulta"
            'Venta_consulta_seleccionar_sucursal.Close()
            Venta_consulta_seleccionar_sucursal.Show()
        Else
            Caja_consulta.sucursal_id = Inicio.suc_id
            Caja_consulta.sucursal_nombre = Label_Suc.Text
            'Venta_consulta_sucursal.sucursal_nombre = ComboBox_sucursales.Text
            'Me.Close()

            Caja_consulta.Show()
        End If




    End Sub


    Private Sub MovimientosDeMercaderiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem1.Click
        Marca_Modificar.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
        Marca_alta.Show()

    End Sub

    Private Sub Btn_corte_caja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_corte_caja.Click
        'aqui valido que la caja este abierta.
        APcaja.Caja_Validar()
        If APcaja.SESION_CAJA = 2 Then
            '2 =  la caja esta abierta y lista para vender
            Corte_caja.Close()
            Corte_caja.Show()
        End If

    End Sub

    Private Sub VendedorNuevoToolStripMenuitem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VendedorNuevoToolStripMenuitem.Click
        Vendedor_alta.Close()
        Vendedor_alta.Show()
    End Sub

    Private Sub CuentaCorrienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cliente_Cta_Cte_Buscar.Close()
        Cliente_Cta_Cte_Buscar.Show()
    End Sub

    Private Sub VendedorActualizarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VendedorActualizarToolStripMenuItem.Click
        Vendedor_modificar.Close()
        Vendedor_modificar.Show()
    End Sub

    Private Sub RemitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemitoToolStripMenuItem.Click
        Remito.Close()
        Remito.Show()
    End Sub

    Private Sub TerminalNuevoToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TerminalNuevoToolStripMenuItem2.Click
        Terminal_alta.Close()
        Terminal_alta.Show()
    End Sub

    Private Sub TerminalModificarToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TerminalModificarToolStripMenuItem2.Click
        Terminal_modificar.Close()
        Terminal_modificar.Show()
    End Sub



    Private Sub NuevoMedicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Medico_Alta.Close()
        Medico_Alta.Show()
    End Sub

    Private Sub GestiónDeConsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_Stock_consumir.Click
        Insumos_gestion.Close()
        Insumos_gestion.Show()
    End Sub

    Private Sub ConsultaDeConsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_Stock_Consulta.Click
        
    End Sub



    Private Sub MedicoNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_MEDICO_nuevo.Click
        Medico_Alta.Show()
        Medico_Alta.Focus()
    End Sub



    Private Sub MedicosConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_MEDICO_consulta.Click
        Medico_Actualizar.Show()
        Medico_Actualizar.Focus()
    End Sub







    Private Sub BajaDeInsumosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_DEP_baja.Click
        Gestion_Mercaderia.procedencia = "baja"
        Gestion_Mercaderia.Show()
        Gestion_Mercaderia.Focus()
    End Sub

    Private Sub MovimientoDeInsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_DEP_Mov.Click
        Gestion_Mercaderia.procedencia = "movimiento"
        Gestion_Mercaderia.Show()
        Gestion_Mercaderia.Focus()
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ObraSocial_nuevo.Close()
        ObraSocial_nuevo.Show()

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ObraSocial_actualizar.Close()
        ObraSocial_actualizar.Show()

    End Sub




    Private Sub IngresoDeInsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_DEP_ingreso.Click
        Gestion_Mercaderia_Alta.Close()
        Gestion_Mercaderia_Alta.Show()
    End Sub

    Private Sub ConsultaDeMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Movimientos_consulta.Close()
        Movimientos_consulta.Show()
    End Sub

    Private Sub RegistroDeAltasporFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeAltasporFacturaToolStripMenuItem.Click
        Consulta_Alta_a.Close()
        Consulta_Alta_a.Show()
    End Sub

    Private Sub RegistroDeAltassoloInsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeAltassoloInsumosToolStripMenuItem.Click
        Consulta_Alta_b.Close()
        Consulta_Alta_b.Show()
    End Sub


    Private Sub TurnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Turno_seleccionar.Close()
        Turno_seleccionar.Show()
    End Sub


    Private Sub RegistroDeMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeMovimientosToolStripMenuItem.Click
        Movimientos_consulta.Close()
        Movimientos_consulta.Text = "Consulta de movimientos - registros historicos"
        Movimientos_consulta.Show()
    End Sub

    Private Sub RegistroDeBajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeBajasToolStripMenuItem.Click
        Movimientos_consulta.Close()
        Movimientos_consulta.tipo_consulta = "solo bajas" 'esto hago para q la grilla solo me muestre bajas
        Movimientos_consulta.Text = "Consulta de bajas - registros historicos"
        Movimientos_consulta.Show()
    End Sub

    Private Sub HistoriaClinicaToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_PAC_HC.Click
        Cliente_modificar.Close() 'lo cierro x si quedo oculto.
        Cliente_modificar.Show()
        Cliente_modificar.Focus()
    End Sub

    Private Sub InformeDePacientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_OBRA_informe.Click
        Paciente_reporte_seleccionar.Close()
        Paciente_reporte_seleccionar.Show()
    End Sub


    Private Sub NuevoToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem2.Click
        TurnoDialisis_nuevo.Close()
        TurnoDialisis_nuevo.Show()
    End Sub


  

    Private Sub NuevoToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_OBRA_nuevo.Click
        ObraSocial_nuevo.Close()
        ObraSocial_nuevo.Show()

    End Sub

    Private Sub ActualizarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_OBRA_actualizar.Click
        ObraSocial_actualizar.Close()
        ObraSocial_actualizar.Show()
    End Sub


    Private Sub ActualizarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        TurnoDialisis_modificar.Close()
        TurnoDialisis_modificar.Show()
    End Sub

    Private Sub HistoriaClinicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_PAC_Act.Click
        Cliente_modificar.Close() 'para q no se abra 2 veces
        Cliente_modificar.Show()
        Cliente_modificar.Focus()
    End Sub

    
    Private Sub MenuItem_ENF_NSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_ENF_NSD.Click
        Turno_seleccionar.Close()
        Turno_seleccionar.Show()
    End Sub

    Private Sub MenuItem_ENF_Informe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_ENF_Informe.Click
        Enfermeria_pacientes_seleccionar.Close()
        Enfermeria_pacientes_seleccionar.Show()
    End Sub

    Private Sub RegistroDeBajassoloInsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeBajassoloInsumosToolStripMenuItem.Click
        Consultas_Bajas_b.Close()
        Consultas_Bajas_b.Show()
    End Sub

    Private Sub RegistroDeMovimientossoloInsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeMovimientossoloInsumosToolStripMenuItem.Click
        Consultas_Movimientos_b.Close()
        Consultas_Movimientos_b.Show()
    End Sub

    Private Sub ConsultasGlobalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_ENF_Consulta.Click
        Sesiones_consulta_global.Close()
        Sesiones_consulta_global.Show()
    End Sub

    Private Sub RegistroDeMovimientosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_ENF_RegMov.Click
        Movimientos_consulta.Close()
        Movimientos_consulta.Text = "Consulta de movimientos - registros historicos"
        Movimientos_consulta.tipo_consulta = "solo Sala de Dialisis"

        Movimientos_consulta.Show()
    End Sub

    Private Sub ConsultaDeStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_ENF_stock.Click
        Producto_modificar.enfermeria_op = 1
        Producto_modificar.Show()

    End Sub

    Private Sub InsumosPredefinidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsumosPredefinidosToolStripMenuItem.Click
        Insumos_Predefinidos.Show()

    End Sub

    Private Sub ConsultaDeAjustesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAjustesToolStripMenuItem.Click
        Ajuste_Consulta.Show()
    End Sub

    Private Sub RegistroDeConsumosporInsumoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeConsumosporInsumoToolStripMenuItem.Click
        Consumos_consulta.Close()
        Consumos_consulta.Show()
    End Sub

    Private Sub RegistroDeConsumosporConceptoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeConsumosporConceptoToolStripMenuItem.Click
        Consumo_consulta_x_concepto.Close()
        Consumo_consulta_x_concepto.Show()
    End Sub
End Class