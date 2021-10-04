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
                        &nbsp;<asp:TextBox ID="Txt_grupo_id" placeholder="ingrese ID" runat="server" CausesValidation="True" onkeypress="return justNumbers(event);"></asp:TextBox>
                        
                        &nbsp;
                        <button type="button" id="btn_modificar" runat="server" class="btn btn-primary">
                          Modificar
                        </button>
                    </div>
                    <div class="form-group">
                    <button type="button" id="btn_nuevo" runat="server" class="btn btn-primary">
                          Nuevo Grupo
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
                                        <asp:BoundField DataField="Fecha" HeaderText="Fecha de Proc." >
                                        <HeaderStyle ForeColor="#0099FF" />
                                        </asp:BoundField>
                                        <asp:TemplateField HeaderText="Modificar">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Button ID="GridBtn_modif" runat="server" CommandName="op_modificar" CommandArgument='<%# Eval("Grupo_id") %>' 
                                                    Text="Modificar" />
                                            </ItemTemplate>
                                            <HeaderStyle ForeColor="#0099FF" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Eliminar">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Button ID="GridBtn_eliminar" runat="server" CommandName="op_eliminar" CommandArgument='<%# Eval("Grupo_id") %>' data-toggle="modal" data-target="#modal-baja" 
                                                    Text="Eliminar" />
                                            </ItemTemplate>
                                            <HeaderStyle ForeColor="#0099FF" />
                                        </asp:TemplateField>
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
