<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Grupos_abm.aspx.vb" Inherits="Presentacion.Grupos_abm" %>
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
                <h3 class="card-title">A.B.M. GRUPOS</h3>
</div>
<form role="form">
<div class="card-body">
    <div align="center">
    <div class="row justify-content-center" >   <%--class="row"--%>
        <div class="col-lg-6">
            <div class="card">
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label ID="Lb_grupo" runat="server" Text="Grupo:"></asp:Label>
                        &nbsp;<asp:TextBox ID="Txt_grupo_id" runat="server"></asp:TextBox>
                        &nbsp;
                        <button type="button" id="btn_ir" runat="server" class="btn btn-primary">
                          IR
                        </button>
                    </div>
                    <div class="form-group">
                            <asp:GridView ID="GridView1" runat="server" class="table table-sm" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                                   BorderColor="Black" GridLines="None" 
                                  EnableSortingAndPagingCallbacks="True" PageSize="20"> <%--class="table table-hover"--%>
                                    <Columns>
                                        <asp:BoundField DataField="Grupo_id" HeaderText="ID" >                                                               
                                        <HeaderStyle ForeColor="#0099FF" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Nombre" HeaderText="Grupo" >
                                        <HeaderStyle ForeColor="#0099FF" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" >
                                        <HeaderStyle ForeColor="#0099FF" />
                                        </asp:BoundField>
                                    </Columns>
                                </asp:GridView>
                        </div>
                                        
                </div>
            </div>
            </div>
        
    </div>
    </div>
</div>
</form>
</div>


</ContentTemplate>
</asp:UpdatePanel>

</asp:Content>
