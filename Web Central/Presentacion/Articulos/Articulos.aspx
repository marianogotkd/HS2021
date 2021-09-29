<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Articulos.aspx.vb" Inherits="Presentacion.Articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

    <!-- jQuery -->
<script src="../../plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="../../dist/js/demo.js"></script>
  
  <!-- jQuery -->
<script src="../../plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- Select2 -->
<script src="../../plugins/select2/js/select2.full.min.js"></script>
<!-- Bootstrap4 Duallistbox -->
<script src="../../plugins/bootstrap4-duallistbox/jquery.bootstrap-duallistbox.min.js"></script>
<!-- InputMask -->
<script src="../../plugins/moment/moment.min.js"></script>
<script src="../../plugins/inputmask/min/jquery.inputmask.bundle.min.js"></script>
<!-- date-range-picker -->
<script src="../../plugins/daterangepicker/daterangepicker.js"></script>
<!-- bootstrap color picker -->
<script src="../../plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.min.js"></script>
<!-- Tempusdominus Bootstrap 4 -->
<script src="../../plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js"></script>
<!-- Bootstrap Switch -->
<script src="../../plugins/bootstrap-switch/js/bootstrap-switch.min.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="../../dist/js/demo.js"></script>
<!-- Page script -->

  <script>
      $(document).keydown(function (e) {


          if (e.keyCode == 119) {
              $('#btn_Agregar').trigger('click');
              alert('pasa')
          }
          else if (e.keyCode == 117) {
              $('#previous').click();
          }
      });
</script>


<div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Articulos</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
                <div class="card-body">

                <div class="form-group">
               <div class="card-body">
              <div class="row">
                    <div class="col-sm-3">
                      <!-- text input -->
                      <div class="form-group">
                        <label>Nombre</label>
                         <asp:TextBox ID="tb_nombre" CssClass="form-control" runat="server"></asp:TextBox>
                      </div>
                    </div>
                    <div class="col-sm-3">
                      <div class="form-group">
                        <label>Rubro</label>
                      <asp:DropDownList ID="DropDownList_Rubro" runat="server" CssClass="custom-select" 
                            AutoPostBack="True">
                             <asp:ListItem Selected="True">Materiales</asp:ListItem>
                             <asp:ListItem>Herramientas</asp:ListItem>
                        </asp:DropDownList>
                      </div>
                    </div>
                   <div class="col-sm-3">
                      <div class="form-group">                                    
                  <br />
                  <asp:Button ID="btn_Agregar" CssClass="btn btn-primary" runat="server" Text="Agregar" 
                              Font-Size="Large"   />        
                  
                  
                  </div>
                    </div>
                  </div>
                    
                  </div>

                
                  
                  </div>

                   
                  
               
               <%-- BUSCADOR!!!!1--%>
             <%--   <div class="input-group input-group-sm">
                    <asp:TextBox ID="tb_Buscar" runat="server" CssClass="form-control"></asp:TextBox>
                  
                  <span class="input-group-append">
                   
                      <asp:Button ID="Btn_buscar" runat="server" Text="Buscar Vehiculo" 
                        CssClass="btn btn-info btn-flat"/>
                  </span>
                </div>--%>
                
              
              <%--COMBO FILTRO--%>
           <%--   <div class="form-group">

               <div class="row">
                    <div class="col-sm-3">
                        <label>Ver Solamente</label>
                       
                         <asp:DropDownList ID="DropDownList1" runat="server" CssClass="custom-select" 
                            AutoPostBack="True">
                             <asp:ListItem Selected="True">Todos</asp:ListItem>
                             <asp:ListItem>Activo</asp:ListItem>
                             <asp:ListItem>De Baja</asp:ListItem>
                        </asp:DropDownList>

                        </div>
                       </div>
                      </div>--%>
                                                           
                          
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
                          <asp:BoundField DataField="ArticuloId" HeaderText="Codigo" />
                          <asp:BoundField DataField="ArticuloNombre" HeaderText="Nombre" />
                          <asp:BoundField DataField="ArticuloRubro" HeaderText="Rubro" />
                          <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" 
                              HeaderText="Editar" />
                          <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
                              HeaderText="Eliminar" Text="Eliminar" />
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


                     <br />
                     <br />

                                    
    

               </div>

                 <div class="card bg-success" visible="false" runat="server" id="Div1">
              <div class="card-header" runat="server" id="Div3" >
                <h3 class="card-title">Los Datos se Guardaron Correctamente</h3>
              </div>
                             
                       
            </div>
                                    
               <div class="card bg-danger" visible="false" runat="server" id="lbl_Err">
              <div class="card-header" visible="false" runat="server" id="Campos" >
                <h3 class="card-title">El Vehiculo ya se encuetra asignado a la obra</h3>
              </div>                             
              </div> 

                       <div class="card bg-danger" visible="false" runat="server" id="Div_ErrVehi">
              <div class="card-header" visible="false" runat="server" id="Div_Div_ErrVehi_text" >
                <h3 class="card-title">Debe seleccionar un vehiculo</h3>
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