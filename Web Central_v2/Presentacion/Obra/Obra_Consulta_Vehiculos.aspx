<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Obra_Consulta_Vehiculos.aspx.vb" Inherits="Presentacion.Obra_Consulta_Vehiculos" %>
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
                  


              <div class="card-body">

                  <asp:GridView ID="GridView1" runat="server" 
                      class="dataTables_wrapper dt-bootstrap4" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                      BorderStyle="None" BorderWidth="1px" CellPadding="3">
                      <Columns>
                          <asp:BoundField DataField="VehiculoId" HeaderText="Codigo" />
                          <asp:BoundField DataField="VehiculoMarca" HeaderText="Marca" />
                          <asp:BoundField DataField="VehiculoModelo" HeaderText="Modelo" />
                          <asp:BoundField DataField="VehiculoAño" HeaderText="Año" />
                          <asp:BoundField DataField="VehiculoPatente" HeaderText="Patente" />
                          <asp:BoundField DataField="VehiculoTipo" HeaderText="Tipo" />
                          <asp:BoundField DataField="VehiculoEstado" HeaderText="Estado" />
                          <asp:ButtonField ButtonType="Button" HeaderText="Liberar Vehiculo" 
                              Text="Liberar"  CommandName="Liberar" >
                          <ItemStyle HorizontalAlign="Center" />
                          </asp:ButtonField>
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
             
              
                      <div>
        <asp:Button ID="btn_Volver" CssClass="btn btn-warning" runat="server" Text="Volver" />
              
                </div>











        </form>
            </div>


             </ContentTemplate>

        
    </asp:UpdatePanel>
        
  



</asp:Content>
