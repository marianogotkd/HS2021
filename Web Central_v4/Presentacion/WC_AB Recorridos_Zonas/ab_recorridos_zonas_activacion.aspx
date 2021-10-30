<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="ab_recorridos_zonas_activacion.aspx.vb" Inherits="Presentacion.ab_recorridos_zonas_activacion" %>
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
        ///se anula el enter
        if (keycode == '13') {
            e.preventDefault();
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


    //funcion para seleccionar todo le contenido de un textbox cuando se pone el foco sobre el control. se agrega como atributo en el codebehind
    function seleccionarTexto(obj) {
        if (obj != null) {
            obj.select();
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
                <h3 class="card-title">A.B. RECORRIDOS/ZONAS</h3>
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
                                    <asp:Label ID="Label_dia" runat="server" Text="DIA:"></asp:Label>
                                    <asp:HiddenField ID="HF_dia_nro" runat="server" />
                                </div>

                                <div class="col-4">
                                    <asp:Label ID="Label1" runat="server" Text="0. Deshabilita."></asp:Label>
                                          
                                    
                                </div>
                                <div class="col-4">
                                    <asp:Label ID="Label2" runat="server" Text="1. Habilita"></asp:Label>
                                </div>

                        </div>
                </div>
                <div class="form-group">
                        <div class="row">
                                <div class="col">
                                    <asp:Label ID="Label3" runat="server" Text="RECORRIDO 1" ForeColor="#6666FF"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label4" runat="server" Text="1A - ZONA 1:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1a" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label5" runat="server" Text="1B - ZONA 2:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1b" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label6" runat="server" Text="1C - ZONA 3:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1c" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label7" runat="server" Text="1D - ZONA 4:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1d" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label8" runat="server" Text="1E - ZONA 5:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1e" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label9" runat="server" Text="1F - ZONA 6:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1f" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label10" runat="server" Text="1G - ZONA 7:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1g" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label11" runat="server" Text="1H - ZONA 8:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1h" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label12" runat="server" Text="1I - ZONA 9:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1i" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label13" runat="server" Text="1J - ZONA 10:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_1j" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                </div>

                                <div class="col">
                                <asp:Label ID="Label14" runat="server" Text="RECORRIDO 2" ForeColor="#6666FF"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label15" runat="server" Text="2A - ZONA 11:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2a" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label16" runat="server" Text="2B - ZONA 12:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2b" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label17" runat="server" Text="2C - ZONA 13:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2c" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label18" runat="server" Text="2D - ZONA 14:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2d" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label19" runat="server" Text="2E - ZONA 15:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2e" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label20" runat="server" Text="2F - ZONA 16:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2f" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label21" runat="server" Text="2G - ZONA 17:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2g" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label22" runat="server" Text="2H - ZONA 18:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2h" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label23" runat="server" Text="2I - ZONA 19:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2i" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label24" runat="server" Text="2J - ZONA 20:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_2j" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                </div>

                                <div class="col">
                                <asp:Label ID="Label25" runat="server" Text="RECORRIDO 3" ForeColor="#6666FF"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label26" runat="server" Text="3A - ZONA 21:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3a" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label27" runat="server" Text="3B - ZONA 22:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3b" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label28" runat="server" Text="3C - ZONA 23:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3c" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label29" runat="server" Text="3D - ZONA 24:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3d" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label30" runat="server" Text="3E - ZONA 25:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3e" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label31" runat="server" Text="3F - ZONA 26:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3f" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label32" runat="server" Text="3G - ZONA 27:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3g" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label33" runat="server" Text="3H - ZONA 28:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3h" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label34" runat="server" Text="3I - ZONA 29:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3i" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label35" runat="server" Text="3J - ZONA 30:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_3j" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                </div>

                                <div class="col">
                                <asp:Label ID="Label36" runat="server" Text="RECORRIDO 4" Font-Bold="False" 
                                        ForeColor="#6666FF"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label37" runat="server" Text="4A - ZONA 31:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4a" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label38" runat="server" Text="4B - ZONA 32:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4b" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label39" runat="server" Text="4C - ZONA 33:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4c" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label40" runat="server" Text="4D - ZONA 34:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4d" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label41" runat="server" Text="4E - ZONA 35:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4e" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label42" runat="server" Text="4F - ZONA 36:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4f" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label43" runat="server" Text="4G - ZONA 37:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4g" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label44" runat="server" Text="4H - ZONA 38:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4h" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label45" runat="server" Text="4I - ZONA 39:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4i" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label46" runat="server" Text="4J - ZONA 40:" Width="100px"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_4j" runat="server" Text="0" MaxLength="1" Width="30px" onkeydown="tecla_op(event);" onkeypress="return solo_ceroyuno_valitation(event);"></asp:TextBox>
                                    <br />
                                    <br />
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
</div>

</form>
</div>

<%--Modal MENSAJE OK GRABADO--%>
<div class="modal fade" id="modal-sm_OKGRABADO" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true" data-backdrop="static" data-keyboard="false">
        <div class="modal-dialog modal-sm modal-dialog-centered " role="document">
          <div class="modal-content">
            <div class="modal-header">
              <h4 class="modal-title">Graba</h4>
              <button type="button" id="btn_graba_close" runat="server" class="close" tabindex="-1" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="modal-body">
              <p>Se guardo correctamente!&hellip;</p>
            </div>
            <div class="modal-footer justify-content-center ">
            <%--<div class="modal-footer justify-content-between">--%>
              <%--<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>--%>
              <button type="button" id="btn_ok" runat="server" class="btn btn-primary" data-dismiss="modal">OK</button>
            </div>
          </div>
          <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
      </div>
      <!-- /.modal -->


<%--MODAL MSJ CENTRADO - ERROR OPCION--%>
<div class="modal fade" id="modal-sm_error" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true" data-backdrop="static" data-keyboard="false">
        <div class="modal-dialog modal-sm modal-dialog-centered " role="document">
          <div class="modal-content">
            <div class="modal-header">
              <h4 class="modal-title">Error!</h4>
              <button type="button" id="btn_close_error" runat="server" class="close" tabindex="-1" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="modal-body">
              <p>Ocurrión un problema, intente nuevamente!&hellip;</p>
            </div>
            <div class="modal-footer justify-content-center ">
            <%--<div class="modal-footer justify-content-between">--%>
              <%--<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>--%>
              <button type="button" id="btn_ok_error" runat="server" tabindex="1" class="btn btn-primary" data-dismiss="modal">OK</button>
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
