<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Vehiculo_Historico.aspx.vb" Inherits="Presentacion.Vehiculo_Historico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>


<div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Historial de Vehiculos</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">

              <div class="form-group">

              <div class="row">
                    <div class="col-sm-3">
                      <!-- text input -->
                      <div class="form-group">
                        <label>Marca</label>
                         <asp:TextBox ID="tb_marca" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                      </div>
                    </div>
                    <div class="col-sm-3">
                      <div class="form-group">
                        <label>Modelo</label>
                        <asp:TextBox ID="tb_modelo" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                      </div>
                    </div>
                  
                   <div class="col-sm-3">
                      <div class="form-group">
                        <label>Patente</label>
                          <asp:TextBox ID="tb_patente" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
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
                          <asp:BoundField DataField="VehiculoId" HeaderText="VehiculoId" 
                              Visible="False" />
                          <asp:BoundField DataField="ObraId" HeaderText="ObraId" Visible="False" />
                          <asp:BoundField DataField="VehiculoMarca" HeaderText="VehiculoMarca" 
                              Visible="False" />
                          <asp:BoundField DataField="VehiculoModelo" HeaderText="VehiculoModelo" 
                              Visible="False" />
                          <asp:BoundField DataField="VehiculoPatente" HeaderText="VehiculoPatente" 
                              Visible="False" />
                          <asp:BoundField DataField="ObraNombre" HeaderText="Nombre de Obra" />
                          <asp:BoundField DataField="ObraDomicilio" HeaderText="Domicilio" />
                          <asp:BoundField DataField="ObraLocalidad" HeaderText="Localidad" />
                          <asp:BoundField DataField="VeObFecha" HeaderText="Fecha De Asignacion" />
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
                    <asp:Button ID="Volver" CssClass="btn btn-primary" runat="server" Text="Volver" />
              
                </div>









        </form>
            </div>


             </ContentTemplate>

        
    </asp:UpdatePanel>
        
  


</asp:Content>
