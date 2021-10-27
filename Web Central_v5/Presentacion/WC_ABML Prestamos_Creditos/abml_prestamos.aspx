<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="abml_prestamos.aspx.vb" Inherits="Presentacion.abml_prestamos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script>
    //funcion que reconoce teclas para ir a los botones retroceso, baja y graba
    function tecla_op(e) {
        var keycode = e.keyCode;
        ///ESC RETROCEDE
        if (keycode == '27') {
            e.preventDefault();
            document.getElementsByTagName('button')[0].focus();
            document.getElementsByTagName('button')[0].click();

        }
        ///se anula el enter Y PASO AL BOTON DE GRABA
        if (keycode == '13') {
            e.preventDefault();
            
        }


        //F8 GRABA
        if (keycode == '119') {
            e.preventDefault();
            document.getElementsByTagName('button')[1].focus();
            document.getElementsByTagName('button')[1].click();
        }
    }

    //funcion que reconoce teclas para ir a los botones retroceso, baja y graba
    function tecla_op_botones(e) {
        var keycode = e.keyCode;
        ///ESC RETROCEDE
        if (keycode == '27') {
            e.preventDefault();
            document.getElementsByTagName('button')[0].focus();
            document.getElementsByTagName('button')[0].click();

        }
        //        ///no voy a anular el ENTER
        //        if (keycode == '13') {
        //            e.preventDefault();
        //        }


        //F8 GRABA
        if (keycode == '119') {
            e.preventDefault();
            document.getElementsByTagName('button')[1].focus();
            document.getElementsByTagName('button')[1].click();
        }
    }
    
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
<div class="card card-primary">
    <div class="card-header">
                <h3 class="card-title">A.B.M.L. PRESTAMOS Y CREDITOS.</h3>
    </div>
    <form role="form">
    <div class="card-body">
    <div class="container-fluid">
    <div class="row justify-content-center">
    <div class="col-lg-12">
    <div class="card">
            <div class="card-body">
                    <div class="form-group">
                            <div class="row justify-content-center">
                                    <div class="col-md-4">
                                        <label for="Label_cliente_id">OPCION 1: CARGA DEL PRESTAMO.</label> 
                                    </div>
                                    <div class="col-md-4">
                                    </div>
                            </div>
                    </div>
                        
                        
                        <div class="form-group">       
                                <div class="row justify-content-center">
                                        <div class="col-md-4">
                                                <label for="Label_cliente_id">Cliente:</label>
                                                <asp:TextBox ID="Txt_cliente_codigo" runat="server" placeholder="Ingrese código..." class="form-control" onkeydown="tecla_op(event);" onkeypress="return justNumbers(event);"></asp:TextBox>
                                                <asp:Label ID="lb_error_codigo" runat="server" ForeColor="Red" Text="*" Visible="false"></asp:Label>
                                                
                                        </div>
                                        <div class="col-md-4">
                                                <label for="Label_cliente_nomb">Nombre:</label>
                                                <asp:TextBox ID="Txt_cliente_nomb" runat="server" placeholder="Ingrese nombre..." class="form-control" MaxLength="50" onkeydown="tecla_op(event);"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        <div class="form-group">       
                                <div class="row justify-content-center">
                                        <div class="col-md-4">
                                                <label for="Label_fecha">Fecha:</label>
                                                <asp:TextBox ID="Txt_fecha" onkeydown="tecla_op(event);" runat="server" 
                                                    TextMode="Date" Width="120px"></asp:TextBox>
                                                &nbsp;<asp:Label ID="lb_error_fecha" runat="server" ForeColor="Red" Text="*" Visible="False"></asp:Label>
                                                &nbsp;<asp:Button ID="btn_buscar" runat="server" onkeydown="tecla_op_botones(event);" Text="Buscar" />
                                        </div>
                                        <div class="col-md-4">
                                            <div class="col-md-4">

                                            </div>
                                        </div>
                                </div>
                        </div>
                        <div class="form-group">       
                                <div class="row justify-content-center">
                                        <div class="col-md-4">
                                                <label for="Label_formadecobro">Forma de Cobro:</label>
                                        <asp:TextBox ID="Txt_tipo" runat="server" placeholder="Ingrese opción..." class="form-control" CausesValidation="True" 
                                        MaxLength="1" onkeydown="tecla_op(event);" onkeypress="return solo_123_valitation(event);" 
                                        ToolTip="Ingrese tipo (1,2,3)" validationgroup="check" 
                                        xmlns:asp="#unknown"></asp:TextBox>
                                        <asp:Label ID="lb_error_tipo" runat="server" ForeColor="Red" Text="*" Visible="False"></asp:Label>
                                                                           
                                
                                        </div>

                                        <div class="col-md-4">
                                                <small id="Small1" runat="server" visible=true class="form-text text-muted">1= % Comision.</small>
                                                <small id="Small2" runat="server" visible=true class="form-text text-muted">2= % Regalo.</small>
                                                <small id="Small3" runat="server" visible=true class="form-text text-muted">3= A descontar manual.</small>       
                                        </div>
                                
                                </div>
                        </div>
                        <div class="form-group">       
                                <div class="row justify-content-center">
                                        <div class="col-md-4">
                                                <label for="Label_porcentaje">Porcentaje %:</label>
                                                <asp:TextBox ID="Txt_porcentaje" runat="server" class="form-control" placeholder="0,00 %" CausesValidation="True" validationgroup="check_2" xmlns:asp="#unknown2" MaxLength="6" onkeydown="tecla_op(event);" onkeypress="return onKeyDecimal(event, this);"></asp:TextBox>
                                                <asp:Label ID="lb_error_porcentaje" runat="server" ForeColor="Red" Text="*" Visible="False"></asp:Label>
                            
                                        </div>

                                        <div class="col-md-4">

                                        </div>
                                </div>
                        </div>


            </div>
    </div>
    </div>
    </div>
    </div>
    </div>
    </form>
    </div>
<div class="card-footer">
        <div class="row justify-content-center" >
        

         <div class="row align-items-center">
            
                <div class="form-group">
                  <button type="submit" UseSubmitBehavior="false" class="btn btn-primary" runat="server" id="btn_retroceder" onkeydown="tecla_op_botones(event);">ESC = RETROCEDE</button>
                    &nbsp;</div>
                      
                 <div class="form-group">
                                <button type="button" Class="btn btn-primary" id = "BOTON_GRABA" runat="server" onkeydown="tecla_op_botones(event);">F8 = GRABA</button>
        
                 </div>
            
         </div>

        </div>
        

</div>




</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
