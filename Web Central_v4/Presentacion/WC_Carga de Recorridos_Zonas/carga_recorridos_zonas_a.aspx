<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="carga_recorridos_zonas_a.aspx.vb" Inherits="Presentacion.carga_recorridos_zonas_a" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script>
    //funcion que reconoce teclas para ir a los botones retroceso, baja y graba
    function tecla_op(e) {
        var keycode = e.keyCode;
        ///ESC RETROCEDE
        if (keycode == '27') {
            e.preventDefault();
            document.getElementsByTagName('button')[0].focus();
            document.getElementsByTagName('button')[0].click();

        }
        ///se anula el enter y va al boton graba
        if (keycode == '13') {
            e.preventDefault();
            document.getElementsByTagName('button')[1].focus();
            document.getElementsByTagName('button')[1].click();
        }


        //F8 GRABA
        if (keycode == '119') {
            e.preventDefault();
            document.getElementsByTagName('button')[1].focus();
            document.getElementsByTagName('button')[1].click();
        }
    }

    //funcion que reconoce teclas para ir a los botones retroceso, baja y graba
    function tecla_op_botones(e) {
        var keycode = e.keyCode;
        ///ESC RETROCEDE
        if (keycode == '27') {
            e.preventDefault();
            document.getElementsByTagName('button')[0].focus();
            document.getElementsByTagName('button')[0].click();

        }
        //        ///no voy a anular el ENTER
        //        if (keycode == '13') {
        //            e.preventDefault();
        //        }


        //F8 GRABA
        if (keycode == '119') {
            e.preventDefault();
            document.getElementsByTagName('button')[1].focus();
            document.getElementsByTagName('button')[1].click();
        }
    }
    
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
<div class="card card-primary">
<div class="card-header">
                <h3 class="card-title">CARGA DE RECORRIDOS/ZONAS.</h3>
</div>
<form role="form">
<div class="card-body">
<div class="container-fluid">
<div class="row justify-content-center">
<div class="col-lg"> <%--aqui decia col-lg-6--%>
<div class="card">
        <div class="card-body">
                <div class="form-group">
                        <div class="row justify-content-center">
                                <div class="col-4">
                                    <asp:HiddenField ID="HF_parametro_id" runat="server" />
                                    <asp:Label ID="LABEL_FECHA" runat="server" Text="FECHA:"></asp:Label>
                                    <asp:TextBox ID="Txt_fecha" onkeydown="tecla_op(event);" runat="server" TextMode="Date"></asp:TextBox>   
                                </div>
                                <div class="col-4">
                                    <asp:Label ID="Label_dia" runat="server" Text="DIA:"></asp:Label>
                                    <asp:HiddenField ID="HF_dia_id" runat="server" />
                                </div>
                                <div class="col-4">
                                    <asp:Label ID="Label1" runat="server" Text="Referencia: verde-zonas cargadas."></asp:Label>
                                </div>

                        </div>
                </div>

                <div class="form-group">
                        <div class="row">
                                <div class="col">
                                    <asp:Label ID="Label3" runat="server" Text="RECORRIDO 1" ForeColor="#6666FF"></asp:Label>
                                    <br />
                                    <div id = "Div_1A" runat="server" visible="false" >
                                         <asp:Label ID="Lb_1A" runat="server" Text="1A - ZONA 1." Width="100px"></asp:Label>
                                         <br />
                                         <br />
                                    </div>
                                    
                                    <div id = "Div_1B" runat="server" visible="false" >
                                          <asp:Label ID="Lb_1B" runat="server" Text="1B - ZONA 2." Width="100px"></asp:Label>
                                    
                                          <br />
                                          <br />
                                    </div>
                                    <div id = "Div_1C" runat="server" visible="false" >
                                    <asp:Label ID="Lb_1C" runat="server" Text="1C - ZONA 3." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_1D" runat="server" visible="false" >
                                    <asp:Label ID="Lb_1D" runat="server" Text="1D - ZONA 4." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_1E" runat="server" visible="false" >
                                    <asp:Label ID="Lb_1E" runat="server" Text="1E - ZONA 5." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_1F" runat="server" visible="false" >
                                    <asp:Label ID="Lb_1F" runat="server" Text="1F - ZONA 6." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_1G" runat="server" visible="false" >
                                    <asp:Label ID="Lb_1G" runat="server" Text="1G - ZONA 7." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_1H" runat="server" visible="false" >
                                    <asp:Label ID="Lb_1H" runat="server" Text="1H - ZONA 8." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_1I" runat="server" visible="false" >
                                    <asp:Label ID="Lb_1I" runat="server" Text="1I - ZONA 9." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_1J" runat="server" visible="false" >
                                    <asp:Label ID="Lb_1J" runat="server" Text="1J - ZONA 10." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                </div>

                                <div class="col">
                                <asp:Label ID="Label14" runat="server" Text="RECORRIDO 2" ForeColor="#6666FF"></asp:Label>
                                    <br />
                                    <div id = "Div_2A" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2A" runat="server" Text="2A - ZONA 11." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2B" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2B" runat="server" Text="2B - ZONA 12." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2C" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2C" runat="server" Text="2C - ZONA 13." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2D" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2D" runat="server" Text="2D - ZONA 14." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2E" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2E" runat="server" Text="2E - ZONA 15." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2F" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2F" runat="server" Text="2F - ZONA 16." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2G" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2G" runat="server" Text="2G - ZONA 17." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2H" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2H" runat="server" Text="2H - ZONA 18." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2I" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2I" runat="server" Text="2I - ZONA 19." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_2J" runat="server" visible="false" >
                                    <asp:Label ID="Lb_2J" runat="server" Text="2J - ZONA 20." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                </div>

                                <div class="col">
                                <asp:Label ID="Label25" runat="server" Text="RECORRIDO 3" ForeColor="#6666FF"></asp:Label>
                                    <br />
                                    <div id = "Div_3A" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3A" runat="server" Text="3A - ZONA 21." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3B" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3B" runat="server" Text="3B - ZONA 22." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3C" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3C" runat="server" Text="3C - ZONA 23." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3D" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3D" runat="server" Text="3D - ZONA 24." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3E" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3E" runat="server" Text="3E - ZONA 25." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3F" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3F" runat="server" Text="3F - ZONA 26." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3G" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3G" runat="server" Text="3G - ZONA 27." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3H" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3H" runat="server" Text="3H - ZONA 28." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3I" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3I" runat="server" Text="3I - ZONA 29." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_3J" runat="server" visible="false" >
                                    <asp:Label ID="Lb_3J" runat="server" Text="3J - ZONA 30." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                </div>

                                <div class="col">
                                <asp:Label ID="Label36" runat="server" Text="RECORRIDO 4" Font-Bold="False" 
                                        ForeColor="#6666FF"></asp:Label>
                                    <br />
                                    <div id = "Div_4A" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4A" runat="server" Text="4A - ZONA 31." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4B" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4B" runat="server" Text="4B - ZONA 32." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4C" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4C" runat="server" Text="4C - ZONA 33." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4D" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4D" runat="server" Text="4D - ZONA 34." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4E" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4E" runat="server" Text="4E - ZONA 35." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4F" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4F" runat="server" Text="4F - ZONA 36." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4G" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4G" runat="server" Text="4G - ZONA 37." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4H" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4H" runat="server" Text="4H - ZONA 38." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4I" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4I" runat="server" Text="4I - ZONA 39." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                    <div id = "Div_4J" runat="server" visible="false" >
                                    <asp:Label ID="Lb_4J" runat="server" Text="4J - ZONA 40." Width="100px"></asp:Label>
                                    
                                    <br />
                                    <br />
                                    </div>
                                </div>
                        </div>
                </div>
                <div class="form-group">
                        <div class="row justify-content-center">
                                <div class="col-4">
                                    <asp:Label ID="Label2" runat="server" Text="ZONA:"></asp:Label>
                                    <asp:TextBox ID="txt_zona" runat="server" MaxLength="2" Width="50px" onkeydown="tecla_op(event);"></asp:TextBox>
                                
                                </div>
                        </div>
                </div>
            


        </div>

        <div class="card-footer">
        <div class="row justify-content-center" >
        <div class="row align-items-center">
            <div class="form-group">
            <button type="submit" UseSubmitBehavior="false" class="btn btn-primary" runat="server" id="btn_retroceder" onkeydown="tecla_op_botones(event);">
                ESC = RETROCEDE</button>
            &nbsp;
            </div>

            

            <div class="form-group">
            <button type="button" id="BOTON_GRABAR" runat="server" class="btn btn-primary" onkeydown="tecla_op_botones(event);"> <%--data-targe="#modal-primary"--%>
                  F8 = GRABA
                </button>
            </div>
        
        </div>
        

        </div>
        </div>
</div>
</div>
</div>
</div>
</form>
</div>

<%--Modal MENSAJE ERROR OK 1--%>
<div class="modal fade" id="modal-ok_error" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true" data-backdrop="static" data-keyboard="false">
        <div class="modal-dialog modal-sm modal-dialog-centered " role="document">
          <div class="modal-content">
            <div class="modal-header">
              <h4 class="modal-title">Error</h4>
              <button type="button" id="btn_error_close" runat="server" class="close" tabindex="-1" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="modal-body">
              <p>Error, primero debe iniciar dia!&hellip;</p>
            </div>
            <div class="modal-footer justify-content-center ">
            <%--<div class="modal-footer justify-content-between">--%>
              <%--<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>--%>
              <button type="button" id="btn_ok_error" runat="server" class="btn btn-primary" data-dismiss="modal">OK</button>
            </div>
          </div>
          <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
      </div>
      <!-- /.modal -->

<%--Modal MENSAJE ERROR OK 1--%>
<div class="modal fade" id="modal_ok_error_op" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true" data-backdrop="static" data-keyboard="false">
        <div class="modal-dialog modal-sm modal-dialog-centered " role="document">
          <div class="modal-content">
            <div class="modal-header">
              <h4 class="modal-title">Error</h4>
              <button type="button" id="btn_error_op_close" runat="server" class="close" tabindex="-1" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="modal-body">
              <p>Error, ingrese una zona válida!&hellip;</p>
            </div>
            <div class="modal-footer justify-content-center ">
            <%--<div class="modal-footer justify-content-between">--%>
              <%--<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>--%>
              <button type="button" id="btn_ok_error_op" runat="server" class="btn btn-primary" data-dismiss="modal">OK</button>
            </div>
          </div>
          <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
      </div>
      <!-- /.modal -->


</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
