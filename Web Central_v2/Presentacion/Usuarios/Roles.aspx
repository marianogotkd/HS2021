<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Roles.aspx.vb" Inherits="Presentacion.Roles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

<div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Roles</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
                <div class="card-body"> 

                <div class="form-group">
               <div class="card-body">
              <div class="row">
                    <div class="col">
                      <!-- text input -->
                      <div class="form-group"  runat="server" id="div_rol">
                        <label>Rol Descripcion</label>
                         <asp:TextBox ID="tb_nombre" CssClass="form-control" runat="server"></asp:TextBox>
                      </div>
                       </div>
                        <div class="col">
                         <div class="form-group">
                        <label>Roles</label>
                 <asp:DropDownList ID="DropDownList_obra" runat="server"  CssClass="form-control" 
                                 AutoPostBack="True">
                  </asp:DropDownList>
                      </div>
                       </div>

                   </div>
                    
                                   </div>
                    
                  </div>
                  
                  </div>

                  
               
                      
                                                           
                          
              
              
                <div class="card bg-success" visible="false" runat="server" id="card_OK">
              <div class="card-header" runat="server" id="Div2" >
                <h3 class="card-title">Los Datos se Guardaron Correctamente</h3>
              </div>
                             
                       
            </div>
              
              
              
              <div class="card-body">

                  <asp:GridView ID="GridView1" runat="server" 
                      class="dataTables_wrapper dt-bootstrap4" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                      BorderStyle="None" BorderWidth="1px" CellPadding="3">
                      <Columns>
                          <asp:BoundField DataField="ModuloId" HeaderText="Codigo" />
                          <asp:BoundField DataField="ModuloDesc" HeaderText="Nombre" />
                          <asp:TemplateField HeaderText="Seleccionar">
                              <ItemTemplate>
                                  <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" />
                              </ItemTemplate>
                          </asp:TemplateField>
                      </Columns>
                      <FooterStyle BackColor="White" ForeColor="#000066" />
                      <HeaderStyle BackColor="#006699" Font-Bold="false" ForeColor="white" />
                      <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                      <RowStyle ForeColor="#000066" />
                      <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#007DBB" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#00547E" />
                  
                  </asp:GridView>
                 
                  <br />

                       <div class="form-group">                                    
                  <br />
                  <asp:Button ID="btn_Guardar" CssClass="btn btn-primary" runat="server" Text="Guardar" 
                              Font-Size="Large" />        
                  </div>
                     <br />
                     <br />

                                    
    

               </div>

                 <div class="card bg-success" visible="false" runat="server" id="Div1">
              <div class="card-header" runat="server" id="Div3" >
                <h3 class="card-title">Los Datos se Guardaron Correctamente</h3>
              </div>
                             
                       
            </div>
                                    
               <div class="card bg-danger" visible="false" runat="server" id="lbl_Err">
              <div class="card-header"  runat="server" id="Campos" >
                <h3 class="card-title">Debe Seleccionar al Menos un Modulo</h3>
              </div>                             
              </div> 

                       <div class="card bg-danger" visible="false" runat="server" id="Div_Err">
              <div class="card-header" runat="server" id="Div_Div_ErrVehi_text" >
                <h3 class="card-title">El Rol debe tener un nombre</h3>
              </div>                             
              </div> 

                     <div class="card bg-danger" visible="false" runat="server" id="Div_Elim" >
              <div class="card-header"  runat="server" id="asd"  >
                <h3 class="card-title">No se Puede Eliminar el Articulo </h3>
              </div>                             
              </div> 

                       <div>
              
                </div>
                
                </div>
                </div>

                 <!-- /.card-body -->

             
                

              </form>
            </div>


             </ContentTemplate>

        
    </asp:UpdatePanel>
        
    

</asp:Content>
