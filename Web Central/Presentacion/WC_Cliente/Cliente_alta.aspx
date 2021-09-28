<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Cliente_alta.aspx.vb" Inherits="Presentacion.Cliente_alta" %>
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
<div class="row">
<div class="col-lg-6">
<div class="card">
<div class="card-body">
        <div class="form-group">
        
            <table class="w-100">
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label_cliente_id" runat="server" Text="Cliente:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_cliente_id" runat="server" Width="50px"></asp:TextBox>
                    </td>
                    <td class="style2">
                        <asp:Label ID="Label_cliente_nomb" runat="server" Text="Nombre:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_cliente_nomb" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label_grupo_nomb" runat="server" Text="Grupo:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_grupo_nomb" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            </div>
        <div class="form-group">

            <table class="w-100">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="% Comision:"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" Width="70px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="% Regalo:"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" Width="70px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="% Comision1:"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" Width="70px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="% Regalo1:"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server" Width="70px"></asp:TextBox>
                    </td>
                </tr>
            </table>

        </div>
        <div class="form-group">
        <table class="w-100">
        <tr>
            <td class="style3">
                <asp:Label ID="Label5" runat="server" Text="Proceso:"></asp:Label>
                &nbsp;<asp:TextBox ID="TextBox5" runat="server" Width="70px"></asp:TextBox>
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
                        &nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="70px"></asp:TextBox>
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
                        &nbsp;<asp:TextBox ID="TextBox7" runat="server" Width="70px"></asp:TextBox>
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
                        &nbsp;<asp:TextBox ID="TextBox8" runat="server" Width="70px"></asp:TextBox>
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
                        &nbsp;<asp:TextBox ID="TextBox9" runat="server" Width="70px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label19" runat="server" Text="Orden Nº:"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox10" runat="server" Width="70px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        
        </div>
        <div class="form-group">
        
            <table class="style6">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label22" runat="server" Text="Variable:"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox11" runat="server" Width="70px"></asp:TextBox>
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
                        &nbsp;<asp:TextBox ID="TextBox12" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        
        </div>
        <div class="form-group">
            <table class="style6">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label24" runat="server" Text="Variable1:"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox13" runat="server" Width="70px"></asp:TextBox>
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
                        &nbsp;<asp:TextBox ID="TextBox14" runat="server" Width="200px"></asp:TextBox>
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
        <div class="form-group">
                    
            <button type="submit" UseSubmitBehavior="false" class="btn btn-primary" runat="server" id="btn_retroceder">ESC = RETROCEDE</button>
            &nbsp;
            <button type="submit" UseSubmitBehavior="false" class="btn btn-primary" runat="server" id="btn_baja">F4 = DAR DE BAJA</button>
            &nbsp;
            <button type="submit" UseSubmitBehavior="false" class="btn btn-primary" runat="server" id="btn">F8 = GRABA</button>
                    
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


</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
