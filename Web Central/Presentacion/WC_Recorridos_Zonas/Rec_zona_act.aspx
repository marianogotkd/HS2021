<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Rec_zona_act.aspx.vb" Inherits="Presentacion.Rec_zona_act" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server" 
                        EnableScriptGlobalization="True">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
<div class="card card-primary">
<div class="card-header">
                <h3 class="card-title">ACTIVACION RECORRIDOS/ZONAS</h3>
</div>


<div class="card-body">
<div class="container-fluid">
<div class="row justify-content-center">
<div class="col-lg-6">
<div class="card">
    <div class="card-body">
    <div class="row align-items-start">
    <div class="col">
    <asp:Label ID="Lb_dia" runat="server" Text="DIA:"></asp:Label>
            &nbsp;<asp:TextBox ID="Txt_dia" runat="server" Width="100px"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" type="Date" TextMode="Date"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:TextBox ID="TextBox2" runat="server" type="Date"></asp:TextBox>
    </div>
    <div class="col">
    <asp:Label ID="Label1" runat="server" Text="0-Deshabilita."></asp:Label>
    </div>
    <div class="col">
    <asp:Label ID="Label2" runat="server" Text="1-Habilita."></asp:Label>
    </div>
    
    
    </div>
        
        
     
    
    
    
    </div>
</div>
</div>
</div>
</div>
</div>

</div>

</ContentTemplate>
</asp:UpdatePanel>

</asp:Content>
