<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="acl_gastos_carga.aspx.vb" Inherits="Presentacion.acl_gastos_carga" %>
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
        ///se anula el enter
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
                <h3 class="card-title">A.C.L. GASTOS</h3>
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
                            <label for="Label_cliente_id">OPCION 2: CARGA DE GASTOS.</label> 
                    </div>
                    </div>
        </div>


        <div class="form-group">
                    <div class="row justify-content-center">
                                <div class="col-md-2">
                                    <label for="Label_fecha">Fecha:</label>
                                    <asp:TextBox ID="Txt_fecha" onkeydown="tecla_op(event);" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
                                    <asp:Label ID="lb_error_fecha" runat="server" ForeColor="Red" Text="*" Visible="False"></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <label for="Label_gruponº">Grupo Nº:</label>
                                    <asp:TextBox ID="Txt_grupo_codigo" runat="server" placeholder="Ingrese código..." class="form-control" Visible="true"   
                                    onkeydown="tecla_op(event);" onkeypress="return justNumbers(event);"></asp:TextBox>
                                    <asp:Label ID="lb_error_codigo" runat="server" ForeColor="Red" Text="*" 
                                    Visible="False"></asp:Label>
                                </div>
                    </div>
        </div>
        
        <div class="form-group">
                    <div class="row justify-content-center">
                                <div class="col-md-4">
                                    <label for="Label_gruponº">Motivo:</label>
                                    <asp:DropDownList ID="DropDownList_motivo" runat="server" class="form-control" onkeydown="tecla_op(event);"></asp:DropDownList>
                                </div>
                    </div>
        </div>
        <div class="form-group">
                    <div class="row justify-content-center">
                                <div class="col-md-2">
                                    <label for="Label_gruponº">Importe: $</label>
                                    <asp:TextBox ID="Txt_importe" runat="server" class="form-control" placeholder="0,00" CausesValidation="True" validationgroup="check_2" xmlns:asp="#unknown2" MaxLength="0" onkeydown="tecla_op(event);" onkeypress="return onKeyDecimal(event, this);"></asp:TextBox>
                                    <asp:Label ID="lb_error_importe" runat="server" ForeColor="Red" Text="*" 
                                        Visible="False"></asp:Label>
                                </div>
                                <div class="col-md-2">
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
            <button type="submit" UseSubmitBehavior="false" class="btn btn-primary" runat="server" id="btn_retroceder" onkeydown="tecla_op_botones(event);">
                ESC = RETROCEDE</button>
            &nbsp;
            </div>
            

            <div class="form-group">
            <button type="button" id="BOTON_GRABAR" runat="server" class="btn btn-primary" onkeydown="tecla_op_botones(event);"> <%--data-targe="#modal-primary"--%>
                  F8 = GRABA
                </button>
            </div>
        
        </div>
        

</div>
</div>



</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
