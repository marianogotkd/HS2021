<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Vehiculo_Nuevo.aspx.vb" Inherits="Presentacion.Vehiculo_Nuevo" %>
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
                <h3 class="card-title">Vehiculo</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
                <div class="card-body">
                <div class="form-group">
                 <label for="exampleInputEmail1">Estado:</label>
                 <br />
                    <asp:RadioButton ID="RadioButton_Activo" text="Activo" runat="server" 
                        GroupName="Estado" AutoPostBack="True" Checked="True" />
                         <br />
                    <asp:RadioButton ID="RadioButton_Debaja" text="De Baja" runat="server" 
                        GroupName="Estado" AutoPostBack="True"/>

                </div>

               
               
                  <div class="form-group">
                    <label for="exampleInputEmail1">Marca:</label>
                      <asp:TextBox ID="tb_marca" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>
                  <div class="form-group">
                    <label for="exampleInputPassword1">Modelo:</label>
                    <asp:TextBox ID="tb_modelo" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>
                  
                                  
                    <div class="form-group">
                    <label for="exampleInputPassword1">Año:</label>
                    <asp:TextBox ID="tb_año"   onkeypress="return justNumbers(event);" CssClass="form-control" runat="server"></asp:TextBox>
                  
                  
                  </div>

                   <div class="form-group">
                    <label for="exampleInputPassword1">Patente:</label>
                    <asp:TextBox ID="tb_patente" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>

                   <div class="form-group">
                    <label for="exampleInputPassword1">Tipo</label>
                    <asp:TextBox ID="tb_tipo" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>




                  
                                  
               <div class="card bg-danger" visible="false" runat="server" id="lbl_Err">
              <div class="card-header" visible="false" runat="server" id="Campos" >
                <h3 class="card-title">Debe Completar Todos los Campos</h3>
              </div>                             
              </div> 


      <div class="card bg-success" visible="false" runat="server" id="card_OK">
              <div class="card-header" runat="server" id="Div2" >
                <h3 class="card-title">Los Datos se Guardaron Correctamente</h3>
              </div>
                   
                   
                        <!-- /.card-body -->
            </div>


                </div>
               
                <!-- /.card-body -->

                <div class="card-footer">
                  <%--<button type="submit" class="btn btn-primary">Submit</button>--%>
                  <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" CssClass="btn btn-primary" />

                    <%--<button type="submit" class="btn btn-primary">Submit</button>--%>
                  <asp:Button ID="Btn_Actualizar" runat="server" Text="Actualizar" CssClass="btn btn-primary" Visible="false" />
                </div>

                  <div class="card-footer">
                  <%--<button type="submit" class="btn btn-primary">Submit</button>--%>
                  <asp:Button ID="btn_volver" runat="server" Text="Volver" CssClass="btn btn-primary" />

                  </div>

              </form>

               </div>
        
                </ContentTemplate>

                        
       
       
</asp:UpdatePanel>
            


</asp:Content>
