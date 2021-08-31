<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage/MasterPage.Master" CodeBehind="Examen_costos.aspx.vb" Inherits="fitfa.Examen_costos" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
                <h3 class="card-title">Costos Para Examenes</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
                <div class="card-body">


                <div class="row">
                  <div class="col-md-4 col-center">
                  
                
                  <div class="form-group" >
                    <label>Costo</label>
                    <label id="lbl_costo" class="label label-danger" runat="server" visible="false">Debe Completar El Campo</label>
                    <%--  <input type="text"  visible="false" class="form-control" id="tb_Costo" runat="server" causesvalidation="False" required="" placeholder="Costo"/>--%>
                         <asp:TextBox ID="textbox_Costo" CssClass="form-control" runat="server" onkeypress="return justNumbers(event);"></asp:TextBox>                   
                   <%-- <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server"  Enabled="True" TargetControlID="textbox_Costo" ValidChars="0123456789," >
                    </asp:FilteredTextBoxExtender>
                  --%>
                  </div>

                     <label>Costo</label>
                    <label id="Label1" class="label label-danger" runat="server" visible="false">Debe Completar El Campo</label>
                    <%--  <input type="text"  visible="false" class="form-control" id="tb_Costo" runat="server" causesvalidation="False" required="" placeholder="Costo"/>--%>
                         <asp:TextBox ID="textbox1" CssClass="form-control" runat="server" onkeypress="return justNumbers(event);"></asp:TextBox>                   
                   <%-- <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server"  Enabled="True" TargetControlID="textbox_Costo" ValidChars="0123456789," >
                    </asp:FilteredTextBoxExtender>
                  --%>
                  </div>
                    
                    
                    </div>

                </div>


                
              
                    
          <div class="card-footer">
                  <button type="submit" class="btn btn-primary" runat="server" id="btn_guardar">Guardar Cambios</button>
              <asp:Button ID="btn_save" runat="server" Text="Guardar ASP" class="btn btn-primary" />
                </div>
                <label id="lbl_ok" class="label label-warning" visible="False" runat="server" >Evento Creado  </label>
                <div id="div_registro_guardado" runat="server" visible="false" 
                style="color: #00CC00; font-style: normal; font-variant: normal;">
                    Datos actualizados!
                </div>
                    


        <div id="div_modalOK" runat="server">
                                <asp:HiddenField ID="HiddenField_msj" runat="server" />
                                    <asp:Panel ID="Panel1" runat="server" >
              
                                        <div class="card card-success">
                                        <div class="card-header">
                                            <h3 class="card-title">Evento</h3>
                                        </div>
                                        <form role="form">
                                          <div class="card-body"> 
                                            <div class="row">
                                                <div align="center">
                                                    <asp:Label ID="Label16" runat="server" Text="El evento se generó exitosamente"></asp:Label>
                                                    &nbsp;
                                                </div>
                                            </div>
                                          </div>
                                        </form>  
                                        <div align="center">
                                                <asp:Button ID="Btb_msj_no_eventos" runat="server" Text="OK" CssClass="btn btn-success"  />
                                          </div> 
                                          <div>
                                             &nbsp;
                                          </div>             
                                        </div> 
                                    </asp:Panel>
        
            <asp:ModalPopupExtender ID="Modal_OK" runat="server" TargetControlID="HiddenField_msj" PopupControlID="Panel1" CancelControlID="Btb_msj_no_eventos" BackgroundCssClass="modalBackground">
            </asp:ModalPopupExtender>
                           
    
        </div>



                    </form>
            
                           
            
            
            </div>

                  </ContentTemplate>

                       
       
       
</asp:UpdatePanel>
</asp:Content>
