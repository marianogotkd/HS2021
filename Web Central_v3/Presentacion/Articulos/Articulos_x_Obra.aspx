<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Articulos_x_Obra.aspx.vb" Inherits="Presentacion.Articulos_x_Obra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>


<div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Consulta de Vehiculos</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
             
             
          
              <div class="form-group">
               <div class="card-body">
              <div class="row">
                    <div class="col-sm-3">
                      <!-- text input -->
                      <div class="form-group">
                        <label>Obra:</label>
                         <asp:TextBox ID="tb_nombre" CssClass="form-control" runat="server"></asp:TextBox>
                      </div>
                    </div>
                    <div class="col-sm-3">
                      <div class="form-group">
                        <label>Domicilio</label>
                        <asp:TextBox ID="tb_Domicilio" CssClass="form-control" runat="server"></asp:TextBox>
                      </div>
                    </div>
                  
                   <div class="col-sm-3">
                      <div class="form-group">
                        <label>Fecha de Inicio:</label>
                          <asp:TextBox ID="tb_fecha" CssClass="form-control" runat="server"></asp:TextBox>
                      </div>
                    </div>
                  </div>
                    
                  </div>
                  
                  </div>
                      </div>
  <%--AQUI   --%>             
<%--
ESTE NO ME DEJA EDITAR LA GRILLA


<div class="card-body">
 <div class="row" >
  <div class="col-sm-3">

   <div class="card card-primary">
                     <div class="card-header">
                <h3 class="card-title">Listado de Articulos</h3>
              </div>
               </div>


                  <asp:GridView ID="GridView1" runat="server" 
                      class="dataTables_wrapper dt-bootstrap4" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                      BorderStyle="None" BorderWidth="1px" CellPadding="3">
                      <Columns>
                          <asp:BoundField DataField="ArticuloId" HeaderText="Codigo" />
                          <asp:BoundField DataField="ArticuloNombre" HeaderText="Nombre" />
                          <asp:BoundField DataField="ArticuloRubro" HeaderText="Rubro" />
                          <asp:TemplateField HeaderText="Cantidad">
                              <ItemTemplate>
                                  <asp:TextBox ID="txt_cant"   runat="server" Height="32px" Width="95px"></asp:TextBox>
                              </ItemTemplate>
                          </asp:TemplateField>
                      </Columns>
                      <FooterStyle BackColor="White" ForeColor="#000066" />
                      <HeaderStyle BackColor="#ffc107" Font-Bold="false" ForeColor="Black" />
                      <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                      <RowStyle ForeColor="#000066" />
                      <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#007DBB" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#00547E" />
                  
                  </asp:GridView>





                 </div>

                  <div class="col-sm-3">
                  </div>

                 <div class="col-sm-3">

                  <div class="card card-primary">
                     <div class="card-header">
                <h3 class="card-title">Articulos Actuales en la Obra</h3>
              </div>
               </div>

                  <asp:GridView ID="GridView2" runat="server" 
                      class="dataTables_wrapper dt-bootstrap4" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                      BorderStyle="None" BorderWidth="1px" CellPadding="3">
                      <Columns>
                          <asp:BoundField DataField="ArticuloId" HeaderText="Codigo" />
                          <asp:BoundField DataField="ArticuloNombre" HeaderText="Nombre" />
                          <asp:BoundField DataField="ArticuloRubro" HeaderText="Rubro" />
                          <asp:BoundField DataField="ObrArtCantidad" HeaderText="Cantidad" />
                      </Columns>
                      <FooterStyle BackColor="White" ForeColor="#000066" />
                      <HeaderStyle BackColor="#ffc107" Font-Bold="false" ForeColor="Black" />
                      <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                      <RowStyle ForeColor="#000066" />
                      <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#007DBB" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#00547E" />
                  
                  </asp:GridView>
                 </div>






                   </div>

                  <br />
                     <div>
        <asp:Button ID="btn_guardar" CssClass="btn btn-warning" runat="server" Text="Guardar" />
              
                </div>

                     <br />
                     <br />

                                    
    

               </div>
             

***************-------------------------%>
              

             <div class="card-body">

                      


                  <div class="card card-primary">
                     <div class="card-header">
                <h3 class="card-title">Articulos Actuales en la Obra</h3>
              </div>
               </div>

                  <asp:GridView ID="GridView2" runat="server" 
                      class="dataTables_wrapper dt-bootstrap4" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                      BorderStyle="None" BorderWidth="1px" CellPadding="3">
                      <Columns>
                          <asp:BoundField DataField="ArticuloId" HeaderText="Codigo" />
                          <asp:BoundField DataField="ArticuloNombre" HeaderText="Nombre" />
                          <asp:BoundField DataField="ArticuloRubro" HeaderText="Rubro" />
                          <asp:BoundField DataField="ObrArtCantidad" HeaderText="Cantidad" />
                          <asp:ButtonField ButtonType="Button" HeaderText="Eliminar" Text="Quitar" />
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
                 </div>



                 
   <div class="card card-danger">
                     <div class="card-header">
                <h3 class="card-title">Listado de Articulos</h3>
              </div>
               </div>


                  <asp:GridView ID="GridView1" runat="server" 
                      class="dataTables_wrapper dt-bootstrap4" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                      BorderStyle="None" BorderWidth="1px" CellPadding="3">
                      <Columns>
                          <asp:BoundField DataField="ArticuloId" HeaderText="Codigo" />
                          <asp:BoundField DataField="ArticuloNombre" HeaderText="Nombre" />
                          <asp:BoundField DataField="ArticuloRubro" HeaderText="Rubro" />
                          <asp:TemplateField HeaderText="Cantidad">
                              <ItemTemplate>
                                  <asp:TextBox ID="txt_cant"   runat="server" Height="32px" Width="95px"></asp:TextBox>
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
                     <div>
        <asp:Button ID="btn_guardar" CssClass="btn btn-primary" runat="server" Text="Guardar" />
              
                </div>

                     <br />
                     <br />

                                    
    

               </div>



                      <div>
        <asp:Button ID="btn_Volver" CssClass="btn btn-primary" runat="server" Text="Volver" />
              
                </div>











        </form>
            </div>


             </ContentTemplate>

        
    </asp:UpdatePanel>
        
  



</asp:Content>