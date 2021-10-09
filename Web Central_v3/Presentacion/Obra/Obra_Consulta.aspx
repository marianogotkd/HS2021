<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Obra_Consulta.aspx.vb" Inherits="Presentacion.Obra_Consulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Obra</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
                <div class="card-body">
                <div>
                    <asp:Button ID="btn_Agregar" CssClass="btn btn-primary" runat="server" Text="Agregar" />
              
                    <asp:TextBox ID="Txt_fecha_prueba" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
              
                </div>
         <br />

                <div class="input-group input-group-sm">
                    <asp:TextBox ID="tb_Buscar" runat="server" CssClass="form-control"></asp:TextBox>
                  
                  <span class="input-group-append">
                   
                      <asp:Button ID="Btn_buscar" runat="server" Text="Buscar" 
                        CssClass="btn btn-info btn-flat"/>
                  </span>
                </div>
                <br />
                
                    <div class="col m-3">
                         <div class="form-group">
                        <label>Ver</label>
                 <asp:DropDownList ID="DropDownList_obra" runat="server"  CssClass="form-control" 
                                 AutoPostBack="True">
                     <asp:ListItem>Todos</asp:ListItem>
                     <asp:ListItem Value="Finalizadas">Finalizadas</asp:ListItem>
                     <asp:ListItem>Sin Finalizar</asp:ListItem>
                  </asp:DropDownList>
                      </div>
                       </div>

              <%--<div class="card">
              <div class="card-header">
                <h3 class="card-title">Consulta de Obra</h3>
              </div>
              <!-- /.card-header -->
              <div class="card-body">
                <div id="example2_wrapper" class="dataTables_wrapper dt-bootstrap4"><div class="row"><div class="col-sm-12 col-md-6"></div><div class="col-sm-12 col-md-6"></div></div><div class="row"><div class="col-sm-12"><table id="example2" class="table table-bordered table-hover dataTable dtr-inline" role="grid" aria-describedby="example2_info">
                  <thead>
                  <tr role="row"><th class="sorting" tabindex="0" aria-controls="example2" rowspan="1" colspan="1" aria-label="Browser: activate to sort column ascending">Nombre</th><th class="sorting" tabindex="0" aria-controls="example2" rowspan="1" colspan="1" aria-label="Platform(s): activate to sort column ascending">Descripcion</th><th class="sorting" tabindex="0" aria-controls="example2" rowspan="1" colspan="1" aria-label="Engine version: activate to sort column ascending">Localidad</th><th class="sorting" tabindex="0" aria-controls="example2" rowspan="1" colspan="1" aria-label="CSS grade: activate to sort column ascending">Fecha de Inicio</th></tr>
                  </thead>
                  <tbody>
                  
                              
                  <tr role="row" class="odd">
                    <td tabindex="0" class="sorting_1">Prueba 1</td>
                    <td>Prueba 1</td>
                    <td>Prueba 1</td>
                    <td>Prueba 1</td>
                 
                  </tr><tr role="row" class="even">
                    <td tabindex="0" class="sorting_1">Prueba 2</td>
                    <td>Prueba 2</td>
                    <td>Prueba 2</td>
                    <td>Prueba 2</td>
                    
                  </tr><tr role="row" class="odd">
                    <td tabindex="0" class="sorting_1">Prueba 3</td>
                    <td>Prueba 3</td>
                    <td>Prueba 3</td>
                    <td>Prueba 3</td>
                   
                  </tr><tr role="row" class="even">
                    <td tabindex="0" class="sorting_1">Prueba 4</td>
                    <td>Prueba 4</td>
                    <td>Prueba 4</td>
                    <td>Prueba 4</td>
                  
                  </tr>
                  
                                  
                  </tbody>
                  <tfoot>
                  <tr><th rowspan="1" colspan="1">Nombre</th><th rowspan="1" colspan="1">Descripcion</th><th rowspan="1" colspan="1">Localidad</th><th rowspan="1" colspan="1">Fecha de Inicio</th></tr>
                  </tfoot>
                </table><button type="submit" class="btn btn-primary">Editar</button>   <button type="submit" class="btn btn-primary">Eliminar</button> <button type="submit" class="btn btn-primary">Consultar</button></div></div><div class="row"><div class="col-sm-12 col-md-5"></div><div class="col-sm-12 col-md-7"><div class="dataTables_paginate paging_simple_numbers" id="example2_paginate"><ul class="pagination"><li class="paginate_button page-item previous disabled" id="example2_previous"><a href="#" aria-controls="example2" data-dt-idx="0" tabindex="0" class="page-link">Anterior</a></li><li class="paginate_button page-item active"><a href="#" aria-controls="example2" data-dt-idx="1" tabindex="0" class="page-link">1</a></li><li class="paginate_button page-item "><a href="#" aria-controls="example2" data-dt-idx="2" tabindex="0" class="page-link">2</a></li><li class="paginate_button page-item "><a href="#" aria-controls="example2" data-dt-idx="3" tabindex="0" class="page-link">3</a></li><li class="paginate_button page-item "><a href="#" aria-controls="example2" data-dt-idx="4" tabindex="0" class="page-link">4</a></li><li class="paginate_button page-item "><a href="#" aria-controls="example2" data-dt-idx="5" tabindex="0" class="page-link">5</a></li><li class="paginate_button page-item "><a href="#" aria-controls="example2" data-dt-idx="6" tabindex="0" class="page-link">6</a></li><li class="paginate_button page-item next" id="example2_next"><a href="#" aria-controls="example2" data-dt-idx="7" tabindex="0" class="page-link">Siguiente</a></li></ul></div></div></div></div>
              </div>
              <!-- /.card-body -->
            
             <div class="card-footer">
                
                </div>
            </div>--%>
              
              
              
              
              <div class="card-body">

                  <asp:GridView ID="GridView1" runat="server" 
                      class="dataTables_wrapper dt-bootstrap4" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                      BorderStyle="None" BorderWidth="1px" CellPadding="3">
                      <Columns>
                          <asp:BoundField DataField="ObraId" HeaderText="Codigo" />
                          <asp:BoundField DataField="ObraNombre" HeaderText="Nombre" />
                          <asp:BoundField DataField="ObraDescripcion" HeaderText="Descripcion" />
                          <asp:BoundField DataField="ObraDomicilio" HeaderText="Domicilio" />
                          <asp:BoundField DataField="ObraLocalidad" HeaderText="Localidad" />
                          <asp:BoundField DataField="ObraFechaInicio" HeaderText="Inicio" />
                          <asp:BoundField DataField="ObraFechaFinal" HeaderText="Fin" />
                          <asp:BoundField DataField="ObraEstado" HeaderText="Estado" Visible="False" />
                          <asp:CommandField ShowSelectButton="True" ButtonType="Button" 
                              HeaderText="Editar" SelectText="Editar" >
                          <FooterStyle HorizontalAlign="Center" />
                          </asp:CommandField>
                          <asp:ButtonField ButtonType="Button" HeaderText="Ver Vehiculos" CommandName="Ver_vehi"
                              Text="Ver" >
                          <FooterStyle HorizontalAlign="Center" />
                          <ItemStyle HorizontalAlign="Center" />
                          </asp:ButtonField>
                          <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
                              HeaderText="Eliminar" Text="Eliminar" />
                          <asp:ButtonField ButtonType="Button" CommandName="Articulos" 
                              HeaderText="Articulos" Text="Ver">
                          <ItemStyle HorizontalAlign="Center" />
                          </asp:ButtonField>
                      </Columns>
                      <FooterStyle BackColor="White" ForeColor="#000066" />
                      <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                      <RowStyle ForeColor="#000066" />
                      <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#007DBB" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#00547E" />
                  
                  </asp:GridView>
                     
               </div>


               
                     <div class="card bg-danger" visible="false" runat="server" id="Div_Elim" >
              <div class="card-header"  runat="server" id="asd"  >
                <h3 class="card-title">No se Puede Eliminar La Obra </h3>
              </div>                             
              </div> 


                       <div>
        <asp:Button ID="Agregar2" CssClass="btn btn-primary" runat="server" Text="Agregar" />
              
                </div>
                
                </div>
                </div>
                <!-- /.card-body -->

             
                

              </form>
            </div>
            
            

</asp:Content>
