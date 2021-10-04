<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Cliente_alta.aspx.vb" Inherits="Presentacion.Cliente_alta" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 124px;
        }
        .style2
        {
            width: 301px;
        }
        .style3
        {
            width: 266px;
        }
        .style4
        {
            width: 81px;
        }
        .style5
        {
            width: 97px;
        }
        .style6
        {
            width: 100%;
        }
        .style7
        {
            width: 58px;
        }
        .style8
        {
            width: 95px;
        }
        .style9
        {
            width: 210px;
        }
        .style10
        {
            width: 212px;
        }
        .style11
        {
            width: 217px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" 
                        EnableScriptGlobalization="True">
</asp:ScriptManager>

<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
<div class="card card-primary">
<div class="card-header">
                <h3 class="card-title">A.B.M. CLIENTES</h3>
</div>
<form role="form">
<div class="card-body">
<div class="container-fluid">
<div class="row justify-content-center">
<div class="col-lg-6">
<div class="card">
<div class="card-body">
        <div class="form-group">
        
            <table class="w-100">
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label_cliente_id" runat="server" Text="Cliente:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_cliente_id" runat="server" Width="50px" 
                            ReadOnly="True" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="style2">
                        <asp:Label ID="Label_cliente_nomb" runat="server" Text="Nombre:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_cliente_nomb" runat="server" MaxLength="50"></asp:TextBox>
                        <asp:Label ID="lb_error_nombre" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                    </td>
                    <td>
                        
                    </td>
                </tr>
            </table>
            </div>
            <div class="form-group">
            <table class="w-100">
            <tr>
                <td>
                <asp:Label ID="Label28" runat="server" Text="DNI:"></asp:Label>
                &nbsp;<asp:TextBox ID="Txt_dni" runat="server" MaxLength="9" CausesValidation="True" onkeypress="return justNumbers(event);"></asp:TextBox>
                    
                    <asp:Label ID="lb_error_dni" runat="server" ForeColor="Red" Text="*" 
                        Visible="False"></asp:Label>
                    
                <td>
            </tr>
            
            </table>
            </div>
            <div class="form-group">
            <table class="w-100">
            <tr>
                <td>
                <asp:Label ID="Label_grupo_nomb" runat="server" Text="Grupo:"></asp:Label>
                        &nbsp;<asp:DropDownList ID="DropDownList_grupos" runat="server">
                        </asp:DropDownList>
                </td>
            
            </tr>
            
            </table>
            
            </div>
        <div class="form-group">

            <table class="w-100">
                <tr>
                    <td class="style9">
                        <asp:Label ID="Label1" runat="server" Text="% Comision: "></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_comision" runat="server" Width="70px" CausesValidation="True" validationgroup="check_2" xmlns:asp="#unknown2" MaxLength="6"></asp:TextBox>
                        <asp:Label ID="lb_error_comision" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="Txt_comision" ErrorMessage="Error!" Font-Size="X-Small" 
                            ForeColor="Red" SetFocusOnError="True" 
                            ValidationExpression="^\d+\.\d{1,2}$|^\d+\,\d{1,2}$|^\d+$" 
                            ValidationGroup="check_2" xmlns:asp="#unknown2"></asp:RegularExpressionValidator>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="Txt_comision" FilterType="Custom" ValidChars="0123456789,.">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style10">
                        <asp:Label ID="Label2" runat="server" Text="% Regalo: "></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_regalo" runat="server" Width="70px" CausesValidation="True" validationgroup="check_2" xmlns:asp="#unknown2" MaxLength="6"></asp:TextBox>
                        <asp:Label ID="lb_error_regalo" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                            ControlToValidate="Txt_regalo" ErrorMessage="Error!" Font-Size="X-Small" 
                            ForeColor="Red" SetFocusOnError="True" 
                            ValidationExpression="^\d+\.\d{1,2}$|^\d+\,\d{1,2}$|^\d+$" 
                            ValidationGroup="check_2" xmlns:asp="#unknown2"></asp:RegularExpressionValidator>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" TargetControlID="Txt_regalo" ValidChars="0123456789.,">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style11">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                
            </table>

        </div>
        <div class="form-group">
        <table class="w-100">
        <tr>
            <td class="style9">
                        <asp:Label ID="Label3" runat="server" Text="% Comision1:"></asp:Label>
                        <asp:TextBox ID="Txt_comision1" runat="server" CausesValidation="True" 
                            validationgroup="check_2" Width="70px" xmlns:asp="#unknown2" MaxLength="6"></asp:TextBox>
                        <asp:Label ID="lb_error_comision1" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                            ControlToValidate="Txt_comision1" ErrorMessage="Error!" Font-Size="X-Small" 
                            ForeColor="Red" SetFocusOnError="True" 
                            ValidationExpression="^\d+\.\d{1,2}$|^\d+\,\d{1,2}$|^\d+$" 
                            ValidationGroup="check_2" xmlns:asp="#unknown2"></asp:RegularExpressionValidator>
                <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" TargetControlID="Txt_comision1" ValidChars="0123456789.,">
                </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style10">
                        <asp:Label ID="Label4" runat="server" Text="% Regalo1:"></asp:Label>
                        <asp:TextBox ID="Txt_regalo1" runat="server" CausesValidation="True" 
                            validationgroup="check_2" Width="70px" xmlns:asp="#unknown2" MaxLength="6"></asp:TextBox>
                        <asp:Label ID="lb_error_regalo1" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                            ControlToValidate="Txt_regalo1" ErrorMessage="Error!" Font-Size="X-Small" 
                            ForeColor="Red" SetFocusOnError="True" 
                            ValidationExpression="^\d+\.\d{1,2}$|^\d+\,\d{1,2}$|^\d+$" 
                            ValidationGroup="check_2" xmlns:asp="#unknown2"></asp:RegularExpressionValidator>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server" TargetControlID="Txt_regalo1" ValidChars="123456789.,">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style11">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
        
        
        </tr>
        
        </table>
        </div>


        <div class="form-group">
        <table class="w-100">
        <tr>
            <td class="style3">
                <asp:Label ID="Label5" runat="server" Text="Proceso:"></asp:Label>
                &nbsp;<asp:TextBox ID="Txt_proceso" runat="server" Width="70px" 
                    CausesValidation="True" validationgroup="check_3" xmlns:asp="#unknown3" 
                    MaxLength="1"></asp:TextBox>
                <asp:Label ID="lb_error_proceso" runat="server" ForeColor="Red" Text="*" 
                    Visible="False"></asp:Label>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txt_proceso" ErrorMessage="Error!" Font-Size="X-Small" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[DSMdsm]" ValidationGroup="check_3" xmlns:asp="#unknown3"></asp:RegularExpressionValidator>
                <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" 
                    TargetControlID="Txt_proceso" ValidChars="dsmDSM">
                </asp:FilteredTextBoxExtender>
            </td>
            <td class="style4">
                <asp:Label ID="Label6" runat="server" Text="D= diario."></asp:Label>
            </td>
            <td class="style5">
                <asp:Label ID="Label7" runat="server" Text="S= semanal."></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="M= mensual."></asp:Label>
            </td>
        </tr>
        </table>
        </div>
        
        <div class="form-group">
            <table class="style6">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label9" runat="server" Text="Calculo:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_calculo" runat="server" Width="70px" CausesValidation="True" validationgroup="check_4" xmlns:asp="#unknown4" MaxLength="1" onkeypress="return justNumbers(event);"></asp:TextBox>
                        <asp:Label ID="lb_error_calculo" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="Txt_calculo" ErrorMessage="Error!" Font-Size="X-Small" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[01]" ValidationGroup="check_4" xmlns:asp="#unknown4"></asp:RegularExpressionValidator>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server" TargetControlID="Txt_calculo" ValidChars="01">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style7">
                        <asp:Label ID="Label10" runat="server" Text="0= NO."></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="1= SI."></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div class="form-group">
        
            <table class="style6">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label12" runat="server" Text="Factor:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_factor" runat="server" Width="70px" CausesValidation="True" validationgroup="check_6" xmlns:asp="#unknown6" MaxLength="1" onkeypress="return justNumbers(event);"></asp:TextBox>
                        <asp:Label ID="lb_error_factor" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="Txt_factor" ErrorMessage="Error!" Font-Size="X-Small" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[01]" ValidationGroup="check_6" xmlns:asp="#unknown6"></asp:RegularExpressionValidator>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender7" runat="server" 
                            TargetControlID="Txt_factor" ValidChars="01">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style8">
                        <asp:Label ID="Label13" runat="server" Text="0= sin factor."></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label14" runat="server" Text="1= con factor."></asp:Label>
                    </td>
                </tr>
            </table>
        
        </div>
        <div class="form-group">
        
            <table class="style6">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label15" runat="server" Text="Imprime calculo:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_imprimecalculo" runat="server" Width="70px" CausesValidation="True" validationgroup="check_5" xmlns:asp="#unknown5" MaxLength="1" onkeypress="return justNumbers(event);"></asp:TextBox>
                        <asp:Label ID="lb_error_imprimecalculo" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="Txt_imprimecalculo" ErrorMessage="Error!" Font-Size="X-Small" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[01]" ValidationGroup="check_5" xmlns:asp="#unknown5"></asp:RegularExpressionValidator>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender8" runat="server" TargetControlID="Txt_imprimecalculo" ValidChars="01">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style7">
                        <asp:Label ID="Label16" runat="server" Text="0= NO."></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label17" runat="server" Text="1= SI."></asp:Label>
                    </td>
                </tr>
            </table>
        
        </div>
        <div class="form-group">
        
            <table class="style6">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label18" runat="server" Text="Recorrido Nº:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_recorrido" runat="server" Width="70px" MaxLength="2"></asp:TextBox>
                        <asp:Label ID="lb_error_recorrido" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender11" runat="server" TargetControlID="Txt_recorrido" ValidChars="0123456789">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td>
                        <asp:Label ID="Label19" runat="server" Text="Orden Nº:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_orden" runat="server" Width="70px" MaxLength="3"></asp:TextBox>
                        <asp:Label ID="lb_error_orden" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender12" runat="server" TargetControlID="Txt_orden" ValidChars="0123456789">
                        </asp:FilteredTextBoxExtender>
                    </td>
                </tr>
            </table>
        
        </div>
        <div class="form-group">
        
            <table class="style6">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label22" runat="server" Text="Variable:" ></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_variable" runat="server" Width="70px" CausesValidation="True" validationgroup="check_7" xmlns:asp="#unknown7" MaxLength="1" onkeypress="return justNumbers(event);" ></asp:TextBox>
                        <asp:Label ID="lb_error_variable" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="Txt_variable" ErrorMessage="Error!" Font-Size="X-Small" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[01]" ValidationGroup="check_7" xmlns:asp="#unknown7"></asp:RegularExpressionValidator>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender9" runat="server" TargetControlID="Txt_variable" ValidChars="01">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style7">
                        <asp:Label ID="Label20" runat="server" Text="0= NO."></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label21" runat="server" Text="1= SI."></asp:Label>
                    </td>
                </tr>
            </table>
        
        </div>
        <div class="form-group">
        
            <table class="style6">
                <tr>
                    <td>
                        <asp:Label ID="Label23" runat="server" Text="Leyenda:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_leyenda" runat="server" Width="200px" MaxLength="40"></asp:TextBox>
                        <asp:Label ID="lb_error_leyenda" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        
        </div>
        <div class="form-group">
            <table class="style6">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label24" runat="server" Text="Variable1:" ></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_variable1" runat="server" Width="70px" CausesValidation="True" validationgroup="check_8" xmlns:asp="#unknown8" MaxLength="1" onkeypress="return justNumbers(event);"></asp:TextBox>
                        <asp:Label ID="lb_error_variable1" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="Txt_variable1" ErrorMessage="Error!" Font-Size="X-Small" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[01]" ValidationGroup="check_8" xmlns:asp="#unknown8"></asp:RegularExpressionValidator>
                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender10" runat="server" TargetControlID="Txt_variable1" ValidChars="01">
                        </asp:FilteredTextBoxExtender>
                    </td>
                    <td class="style7">
                        <asp:Label ID="Label25" runat="server" Text="0= NO."></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label26" runat="server" Text="1= SI."></asp:Label>
                    </td>
                </tr>
            </table>
        
        </div>
        <div class="form-group">
            <table class="style6">
                <tr>
                    <td>
                        <asp:Label ID="Label27" runat="server" Text="Leyenda1:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_leyenda1" runat="server" Width="200px" MaxLength="40"></asp:TextBox>
                        <asp:Label ID="lb_error_leyenda1" runat="server" ForeColor="Red" Text="*" 
                            Visible="False"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Lb_error_validacion" runat="server" Font-Bold="True" 
                           ForeColor="Red" Text="Error!" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
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
        <div class="form-group">
                    
            <button type="submit" UseSubmitBehavior="false" class="btn btn-primary" runat="server" id="btn_retroceder">ESC = RETROCEDE</button>
            &nbsp;
            <button type="button" Class="btn btn-primary" data-toggle="modal" data-target="#modal-baja">F4 = DAR DE BAJA</button>
            &nbsp;
            <button type="button" Class="btn btn-primary" data-toggle="modal" data-target="#modal-graba">F8 = GRABA</button>
                    
        </div>                  
        </div>
        

<%--<form role="form">
              <div class="card-body"> 
              <div class="row">
                <div class="col-sm-4" align="center"></div>
                <div class="col-sm-4" align="center">
                    
                      
    
                </div>
                <div class="col-sm-4" align="center"></div>
                </div>
              </div>
</form>--%>
</div>


<div class="modal fade" id="modal-graba">
        <div class="modal-dialog">
          <div class="modal-content bg-primary">
            <div class="modal-header">
              <h4 class="modal-title">Graba</h4>
              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span></button>
            </div>
            <div class="modal-body">
              <p>¿Confirma la operación?&hellip;</p>
            </div>
            <div class="modal-footer justify-content-between">
              <button type="button"    class="btn btn-outline-light" data-dismiss="modal">Cancelar</button>
              <button type="button" id="btn_graba_modal" runat="server"  class="btn btn-outline-light" data-dismiss="modal">Confirmar</button>
            </div>
          </div>
          <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
      </div>
      <!-- /.modal -->

<div class="modal fade" id="modal-baja">
        <div class="modal-dialog">
          <div class="modal-content bg-primary">
            <div class="modal-header">
              <h4 class="modal-title">Dar de Baja</h4>
              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span></button>
            </div>
            <div class="modal-body">
              <p>¿Confirma la operación?&hellip;</p>
            </div>
            <div class="modal-footer justify-content-between">
              <button type="button"    class="btn btn-outline-light" data-dismiss="modal">Cancelar</button>
              <button type="button" id="btn_baja_modal" runat="server"  class="btn btn-outline-light" data-dismiss="modal">Confirmar</button>
            </div>
          </div>
          <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
      </div>
      <!-- /.modal -->


</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
