<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Obra_Nueva.aspx.vb" Inherits="Presentacion.Obra_Nueva" %>
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
                <h3 class="card-title">Obra</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
                <div class="card-body">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Nombre de la Obra</label>
                      <asp:TextBox ID="tb_nombre" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>
                  <div class="form-group">
                    <label for="exampleInputPassword1">Descripcion</label>
                    <asp:TextBox ID="tb_Desc" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>
                  
                    <div class="form-group">
                    <label for="exampleInputPassword1">Domicilio</label>
                    <asp:TextBox ID="tb_Domicilio" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>
                  
                    <div class="form-group">
                    <label for="exampleInputPassword1">Localidad </label>
                    <asp:TextBox ID="tb_Localidad" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>

               <div class="form-group">
                  <label>Fecha de Inicio:</label>
                  <div class="input-group">
                    <div class="input-group-prepend">
                      <span class="input-group-text"><i class="far fa-calendar-alt"></i></span>
                    </div>
                    <input runat="server" id="Tb_fechaIn" type="text" class="form-control" data-inputmask-alias="datetime" data-inputmask-inputformat="dd/mm/yyyy" data-mask="" im-insert="false">
                  </div>
                  <!-- /.input group -->
                </div>

                 <div class="form-group" id="div_fechafin" runat="server">
                  <label>Fecha de Fin:</label>
                  <div class="input-group">
                    <div class="input-group-prepend">
                      <span class="input-group-text"><i class="far fa-calendar-alt"></i></span>
                    </div>
                    <input runat="server" id="Tb_fechaFin" type="text" class="form-control" data-inputmask-alias="datetime" data-inputmask-inputformat="dd/mm/yyyy" data-mask="" im-insert="false">
                  </div>
                  <!-- /.input group -->
                </div>
                   
               <div class="card bg-danger" visible="false" runat="server" id="lbl_Err">
              <div class="card-header" visible="false" runat="server" id="Campos" >
                <h3 class="card-title">Debe Completar Todos los Campos</h3>
              </div>
              <div class="card-header" visible="false" runat="server" id="fechas">
                <h3 class="card-title">La fecha de inicio de obra no puede ser posterior a la de fin de obra </h3>
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
                <asp:Button ID="btn_volver" runat="server" Text="Volver" CssClass="btn btn-primary" />
                </div>

              </form>

               </div>
        
                </ContentTemplate>

                        
       
       
</asp:UpdatePanel>
            

</asp:Content>