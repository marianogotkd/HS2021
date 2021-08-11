<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage/MasterPage.Master" CodeBehind="Modificar_Evento.aspx.vb" Inherits="fitfa.Modificar_Evento" %>

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
                <h3 class="card-title">Modificar Evento</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
                <div class="card-body">

                <div class="form-group">
                  <label>Seleccione El Evento a Modificar</label>
                  <asp:DropDownList ID="drop_evento" runat="server" class="form-control" 
                        AutoPostBack="True">
                     
                   </asp:DropDownList>
                </div>


                  <div class="form-group">
                  <label>Tipo de Evento</label>
                  <asp:DropDownList ID="combo_TipoEvento" runat="server" class="form-control">
                      <asp:ListItem Value="Torneo" Selected="True">Torneo</asp:ListItem>
                      <asp:ListItem Value="Curso">Curso</asp:ListItem>
                      <asp:ListItem Value="Examen">Examen</asp:ListItem>
                   </asp:DropDownList>
                </div>

                  <div class="form-group" >
                    <label>Nombre </label>
                    <label id="lbl_errNom" class="label label-danger" runat="server">Debe Completar El Campo</label>
                      <input type="text" class="form-control" id="tb_nombre" runat="server" causesvalidation="False" required="" placeholder="Nombre del Evento"/>
                      
                  </div>



    <div class="form-group" > 
                 <div>   
               <label>Foto del Evento</label>  
               </div> 
         <asp:Image ID="Image1" runat="server" Height="286px" 
         ImageUrl="~/Eventos/imagen/logo_evento.jpg" Width="286px" Visible="true" 
                     BorderStyle="solid" />
                 <br />
        <button type="button" class="btn btn-primary" data-toggle="modal" runat="server" id="btn_Examinar" data-target="#exampleModal">Examinar</button>
        &nbsp;
        <button type="button" class="btn btn-danger" id="btn_quitar" runat="server" 
                     visible="True">Quitar</button>
        <label id="lbl_errImg" class="label label-danger" runat="server">Solo imagenes</label>
       
 
            <!-- Modal -->
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
              <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Seleccione un Foto Para Subir</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                  </div>
                  <div class="modal-body">
                    <div class="file-loading">
                      <%--<input id="FileUpload1" name="FileUpload1" multiple type="file" runat="server">--%>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
            

                    </div>
                    <div id="kartik-file-errors"></div>
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btn-primary" id="Subir_Foto" runat="server" rutitle="Your custom upload logic" >Subir</button>
                  </div>
                </div>
              </div>
            </div>
   
 </div>


 


                  

<%--           <div class="container">
            <h1>Bootstrap File Input Example</h1>
            <form enctype="multipart/form-data">
                <div class="form-group">
                    <input id="file-1" type="file" class="file" multiple=true data-preview-file-type="any">
                </div>
                <div class="form-group">
                    <input id="file-2" type="file" class="file" readonly=true>
                </div> 
                <div class="form-group">
                    <input id="file-3" type="file" multiple=true>
                </div>
                <div class="form-group">
                    <button class="btn btn-primary">Submit</button>
                    <button class="btn btn-default" type="reset">Reset</button>
                </div>
            </form>
        </div>
    </body>
	<script>
	    $("#file-3").fileinput({
	        showCaption: false,
	        browseClass: "btn btn-primary btn-lg",
	        fileType: "any"
	    });
	</script>
                 --%>


              <%--    <div class="form-group">
                    <label for="exampleInputFile">Subir Foto </label>
                    <div class="input-group">

                                   
                      <div class="custom-file">
                        <input type="file" class="custom-file-input" id="exampleInputFile">
                        <label class="custom-file-label" for="exampleInputFile"></label>
                      </div>
                      <div class="input-group-append">
                        <span class="input-group-text" id="">Subir</span>
                      </div>
                    </div>--%>

                    



                 

                    <div class="form-group">
                  <label>Fecha del Evento</label>
                  <label id="lbl_errfechaini" class="label label-danger" runat="server">Debe Completar El Campo</label>
                  <div class="input-group">
                    <div class="input-group-prepend">
                      <span class="input-group-text"><i class="fa fa-calendar"></i></span>
                    </div>
                    <input type="text" class="form-control" required="" runat="server" id="tb_fechainicio" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask="">
                  </div>
                  <!-- /.input group -->
                </div>

                  
                 <div class="form-group">
                  <label>Fecha de Cierre </label>
                  <label id="lbl_errFecCier" class="label label-danger" runat="server">Debe Completar El Campo</label>
                  <div class="input-group">
                    <div class="input-group-prepend">
                      <span class="input-group-text"><i class="fa fa-calendar"></i></span>
                    </div>
                    <input type="text" required="" class="form-control" runat="server" id="tb_fechaCierre" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask="">
                  </div>
                  <!-- /.input group -->
                </div>
                
                  <asp:CompareValidator ID="cmpEndDate" runat="server" 
                        ErrorMessage="La fecha de cierre no puede ser anterior a la del evento" class="label label-danger" 
                        ControlToCompare="tb_fechainicio" ControlToValidate="tb_fechaCierre" 
                        Operator="GreaterThanEqual" Type="Date">
                        </asp:CompareValidator>
                  <!-- Hora -->
                <div class="bootstrap-timepicker">
                  <div class="form-group">
                    <label>Hora Limite:</label>
                     <label id="lbl_horaCierre" class="label label-danger" runat="server">Debe Completar El Campo</label>
                    <div class="input-group">
                      <input type="text" class="form-control timepicker" required="" id="tb_horaCierre" runat="server">

                      <div class="input-group-append">
                        <span class="input-group-text"><i class="fa fa-clock-o"></i></span>
                      </div>
                    </div>
                    <!-- /.input group -->
                  </div>
                  <!-- /.form group -->
                </div>
                <!-- Hora -->

                  <div class="form-group" >
                    <label>Costo</label>
                    <label id="lbl_costo" class="label label-danger" runat="server">Debe Completar El Campo</label>
                    <%--  <input type="text"  visible="false" class="form-control" id="tb_Costo" runat="server" causesvalidation="False" required="" placeholder="Costo"/>--%>
                         <asp:TextBox ID="textbox_Costo" CssClass="form-control" runat="server" ></asp:TextBox>                   
                   <%-- <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server"  Enabled="True" TargetControlID="textbox_Costo" ValidChars="0123456789," >
                    </asp:FilteredTextBoxExtender>
                  --%>
                  </div>

     <div id="Ocultar" runat="server" visible="false">
                  <asp:button id="hButton" runat="server" style="display:none;" />
                  <%--<asp:Button runat="server" ID="btnAdd" Text="Add" />--%>
                    <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="hButton"
                    PopupControlID="Panel1" Drag="true" BackgroundCssClass="modalBackground" CancelControlID="btn_Cerrar">
                    </asp:ModalPopupExtender>
                                       
                    
              
                    <asp:Panel ID="Panel1" runat="server" CssClass="panel panel-primary">
                                              
            <div class="card card-success">
              <div class="card-header">
                <h3 class="card-title" align="center">
                    <asp:Label ID="Label1" runat="server" Text="Eventos" Font-Bold="True" Font-Size="Large"></asp:Label></h3>

                <div class="card-tools">
                  <%--<button type="button" class="btn btn-tool" id="btn_cerrar_poup" runat="server" data-widget="remove"><i class="fa fa-times"></i>
                  </button>--%>
                </div>
                <!-- /.card-tools -->
              </div>
              <!-- /.card-header -->
              <div class="card-body">
                  <asp:Label ID="Label2" runat="server" Text="Evento Modificado" Font-Italic="True" Font-Bold="True" Font-Size="Medium"></asp:Label>
              <div>
              
              </div>
              <div align="center">
                  <asp:Button ID="btn_Cerrar" runat="server" Text="OK" CssClass="btn btn-primary" />
               </div>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /.card -->
          
                    </asp:Panel>
     </div>

     
                                       
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" >
                    <ProgressTemplate>

         <div style="background-color: Gray; filter:alpha(opacity=60); opacity:0.60; width: 100%; top: 0px; left: 0px; position: fixed; height: 100%;"> </div>
          <div style="margin:auto;
              font-family:Trebuchet MS;
              filter: alpha(opacity=100);
              opacity: 1;
              font-size:small;
              vertical-align: middle;
              top: 40%;
              position: fixed;
              right: 40%;
              color: #275721;
              text-align: center;
              background-color: White;
              height: 100px;
              ">


              <div class="card card-danger">
              <div class="card-header">
                <h3 class="card-title"> Procesando Solicitud</h3>
              </div>
              <div class="card-body">
                Aguarde un Momento Por Favor...
              </div>
              <!-- /.card-body -->
              <!-- Loading (remove the following to stop the loading)-->
              <div class="overlay">
                <i class="fa fa-refresh fa-spin"></i>
              </div>
              <!-- end loading -->
            </div>
                     

        </div>
                        
                    </ProgressTemplate>
                    </asp:UpdateProgress>
              
                    </form>
            </div>

                <div class="card-footer">
                  <button type="submit" class="btn btn-primary" runat="server" id="btn_guardar">Guarda Cambios</button>
                  <button type="button" class="btn btn-primary" data-toggle="modal" runat="server" id="Button1" data-target="#Div1">Eliminar</button>
                </div>
                  <div class="form-group" > 
                  <div>   
                 </div> 
        
        
            <!-- Modal -->
            <div class="modal fade" id="Div1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
              <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="H1">¿Está seguro que desea eliminar el evento?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                  </div>
                  
                  <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btn-primary" id="btn_eliminar" runat="server" rutitle="Your custom upload logic" >Eliminar</button>
                  </div>
                </div>
              </div>
            </div>
   
 </div>



                

                
                <%--<label id="lbl_ok" class="label label-warning" visible="False" runat="server" >Evento Modificado  </label>--%>
          <%--      <div id="div_registro_guardado" runat="server" visible="false" 
                style="color: #00CC00; font-style: normal; font-variant: normal;">
                    Datos actualizados!
                </div>--%>

     
     

      


                   </ContentTemplate>

                          <Triggers>
                            <asp:PostBackTrigger ControlID="Subir_Foto" />
                            <asp:PostBackTrigger ControlID="tb_fechainicio" />
                            <asp:PostBackTrigger ControlID="Button1" />
                             <asp:PostBackTrigger ControlID="btn_eliminar" />
                        </Triggers>
       
       
</asp:UpdatePanel>

    



</asp:Content>
