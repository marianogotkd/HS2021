<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Grupos_alta.aspx.vb" Inherits="Presentacion.Grupos_alta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 203px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" 
                        EnableScriptGlobalization="True">
</asp:ScriptManager>

<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>


    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>



<div class="card card-primary">
<div class="card-header">
                <h3 class="card-title">A.B.M. GRUPOS</h3>
</div>
<form role="form">
<div class="card-body">
<div class="container-fluid">
<div class="row">
<div class="col-lg-6">
<div class="card">
<div class="card-body">
<div class="form-group">

    <asp:Label ID="Label_grupo_id" runat="server" Text="Grupo:"></asp:Label>
    &nbsp;<asp:TextBox ID="Txt_grupo_id" runat="server" ReadOnly="True"></asp:TextBox>
    &nbsp;<asp:Label ID="Label_grupo_nomb" runat="server" Text="Nombre:"></asp:Label>
    &nbsp;<asp:TextBox ID="Txt_grupo_nomb" runat="server"></asp:TextBox>

</div>
<div class="form-group">


    
    <table class="w-100">
        <tr>
            <td>
                <asp:Label ID="Label_tipo" runat="server" Text="Tipo:"></asp:Label>
                &nbsp;<asp:TextBox ID="Txt_tipo" runat="server" Width="62px" MaxLength="1" 
                    validationgroup="check" xmlns:asp="#unknown" 
                    ToolTip="Ingrese tipo (1,2,3,4)" onkeypress="return justNumbers(event);" 
                    CausesValidation="True"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    controltovalidate="Txt_tipo" xmlns:asp="#unknown"
                    ErrorMessage="Error!" ValidationExpression="[1234]" 
                    ValidationGroup="check" ForeColor="Red" SetFocusOnError="True" 
                    Font-Size="X-Small"></asp:RegularExpressionValidator>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="Txt_tipo" ErrorMessage="Campo requerido"  
                    SetFocusOnError="True" InitialValue=" "></asp:RequiredFieldValidator>--%>
                    
                    

            </td>
            <td>
                <asp:Label ID="Label_tipo1" runat="server" Text="1= % del grupo y descuento de los pagados por prestamos."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label_tipo2" runat="server" Text="2= % de los que ganan no cobran."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label_tipo3" runat="server" Text="3= % del grupo."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Labeltipo4" runat="server" Text="4= no tiene calculo."></asp:Label>
            </td>
        </tr>
    </table>

</div>

<div class="form-group">

    <asp:Label ID="Label_porcentaje" runat="server" Text="Porcentaje:"></asp:Label>
    &nbsp;<asp:TextBox ID="Txt_porcentaje" runat="server" Width="62px" 
        CausesValidation="True" validationgroup="check_2" xmlns:asp="#unknown2" 
        MaxLength="6"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="Txt_porcentaje" xmlns:asp="#unknown2" ErrorMessage="Error!" ValidationExpression="^\d+\.\d{1,2}$|^\d+\,\d{1,2}$|^\d+$" Font-Size="X-Small" 
        ForeColor="Red" ValidationGroup="check_2" SetFocusOnError="True"></asp:RegularExpressionValidator>
        <%--uso una expresion regular(enteros/enteros2decimales con punto/entero2decimales con coma)--%>
</div>

<div class="form-group">

    <asp:Label ID="Label_clieporcentaje" runat="server" Text="Cliente Porcentaje:"></asp:Label>
    &nbsp;<asp:TextBox ID="Txt_clieporcentaje" runat="server" Width="62px" 
        MaxLength="6"></asp:TextBox>

        

</div>

<div class="form-group">


    
    <table class="w-100">
        <tr>
            <td class="style1">
                <asp:Label ID="Label_codcobro" runat="server" Text="Código de Cobro:"></asp:Label>
                &nbsp;<asp:TextBox ID="Txt_codcobro" runat="server" Width="62px" MaxLength="1"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label_cobro1" runat="server" Text="1= todo."></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label_cobro2" runat="server" Text="2= sin recibos."></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label_cobro3" runat="server" Text="3= con computo."></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label_cobro4" runat="server" Text="4= solo."></asp:Label>
            </td>
        </tr>
    </table>

</div>

<div class="form-group">

    <asp:Label ID="Label_fechaproc" runat="server" Text="Fecha de procesamiento:"></asp:Label>
    &nbsp;<asp:TextBox ID="Txt_fechaproc" runat="server" type="Date"></asp:TextBox>
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
