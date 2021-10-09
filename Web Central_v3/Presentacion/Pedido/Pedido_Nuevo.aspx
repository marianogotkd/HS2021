<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Pedido_Nuevo.aspx.vb" Inherits="Presentacion.Pedido_Nuevo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

    <ContentTemplate>


<div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">DATOS DEL PEDIDO</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
             
             
          
              <div class="form-group">
               <div class="card-body">
              <div class="row">
                    <div class="col">
                      <!-- text input -->
                      <div class="form-group">
                        <label>N° de Pedido:</label>
                         <asp:TextBox ID="tb_numped" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                      </div>
                    </div>
                    <div class="col">
                      <div class="form-group">
                        <label>Seleccion Obra</label>
                 <asp:DropDownList ID="DropDownList_obra" runat="server" CssClass="form-control">
                  </asp:DropDownList>
                      </div>
                    </div>
                  
                  
                   <div class="col">
                      <div class="form-group">
                        <label>Seleccione vehiculo:</label>
                           <asp:DropDownList ID="DropDownList_vehi" runat="server" CssClass="form-control">
                  </asp:DropDownList>
                      </div>
                    </div>

                      <div class="col">
                      <div class="form-group">
                        <label>Responsable:</label>
                          <asp:TextBox ID="tb_Nombre" CssClass="form-control" runat="server"></asp:TextBox>
                      </div>
                    </div>

                       <div class="col">
                      <div class="form-group">
                        <label>Fecha de Pedido</label>
                          <asp:TextBox ID="Tb_fecha" CssClass="form-control" runat="server" type="Date"></asp:TextBox>
                      </div>
                    </div>

                     <div class="col">
                      <div class="form-group">
                        <label>Fecha de Recepcion</label>
                          <asp:TextBox ID="tb_FechaRecep" CssClass="form-control" runat="server"  type="Date" > </asp:TextBox>
                      </div>
                    </div> 

                  </div>
                    
                  </div>
                  
                  </div>
                      </div>
          


                 
        <div class="card card-primary">
                     <div class="card-header">
                <h3 class="card-title">Articulos</h3>
              </div>
               </div>
                
                  

               <label>Ingrese el Codigo ó Nombre del Articulo</label>
                <div class="input-group input-group-sm">
                    <asp:TextBox ID="tb_Buscar" runat="server" CssClass="form-control"></asp:TextBox>
                  
                  <span class="input-group-append">
                   
                      <asp:Button ID="Btn_buscar" runat="server" Text="Buscar" 
                        CssClass="btn btn-info btn-flat"/>
                  </span>
                </div>
             
             <br />

                <div class="card-body">

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
                          <asp:TemplateField HeaderText="Observaciones">
                              <ItemTemplate>
                                  <asp:TextBox ID="tb_Obs" runat="server" Height="31px" Width="380px"></asp:TextBox>
                              </ItemTemplate>
                          </asp:TemplateField>
                          <asp:CommandField ButtonType="Button" SelectText="Agregar" 
                              ShowSelectButton="True" />
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

                   
                      <div class="card bg-danger" visible="false" runat="server" id="Div_Elim" >
              <div class="card-header"  runat="server" id="asd"  >
                  <asp:Label ID="lbl_err" runat="server" Text="Label"></asp:Label>
              </div>                             
           
              </div> 


                    <div class="card card-primary" id="div_titulo" runat="server" visible="false">
                     <div class="card-header">
                <h3 class="card-title">Listado de Articulos Para el Pedido</h3>
              </div>
               </div>

                 <br />

                        <asp:GridView ID="GridView2" runat="server" 
                      class="dataTables_wrapper dt-bootstrap4" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                      BorderStyle="None" BorderWidth="1px" CellPadding="3">
                      <Columns>
                          <asp:BoundField DataField="ArticuloId" HeaderText="Codigo" />
                          <asp:BoundField DataField="ArticuloNombre" HeaderText="Nombre" />
                          <asp:BoundField DataField="ArticuloRubro" HeaderText="Rubro" />
                          <asp:BoundField DataField="ObrArtCantidad" HeaderText="Cantidad" />
                          <asp:BoundField DataField="Obs" HeaderText="Observaciones" />
                          <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar" />
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

                          <div class="card bg-danger" visible="false" runat="server" id="Div_err2" >
              <div class="card-header"  runat="server" id="Div2"  >
                  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
              </div>                             
           
              </div> 

              <div class="card bg-success" visible="false" runat="server" id="card_OK">
              <div class="card-header" runat="server" id="Div1" >
                <h3 class="card-title">Los Datos se Guardaron Correctamente</h3>
              </div>

             </div>

                     <div>
        <asp:Button ID="btn_guardar" CssClass="btn btn-primary" runat="server" Text="Guardar" />
              
                </div>

                     <br />
                                                     
                
               
                      <div>
        <asp:Button ID="btn_Volver" CssClass="btn btn-primary" runat="server" Text="Volver" />
              
                </div>


 </div>








        </form>
            </div>


             </ContentTemplate>

        
    </asp:UpdatePanel>
        
  



</asp:Content>
