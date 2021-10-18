<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="ab_recorridos_zonas.aspx.vb" Inherits="Presentacion.ab_recorridos_zonas" %>
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


    function dias_valitation(evt) {
        
        
        var charCode = (evt.which) ? evt.which : event.keyCode
        //                acepta solo 1 al 7). el caracter || es un OR


        if ((charCode == 49) || (charCode == 50) || (charCode == 51) || (charCode == 52) || (charCode == 53) || (charCode == 54) || (charCode == 55))
            return true;
        else
            return false;



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
<div class="col-lg-6">
<div class="card">
        <div class="card-body">
                <div class="form-group">
                        <div class="row justify-content-center">
                                <div class="col-4">
                                    <asp:Label ID="Label_dia" runat="server" Text="DIA:"></asp:Label>
                                    &nbsp;<asp:TextBox ID="txt_dia" runat="server" MaxLength="1" Width="35px" onkeydown="tecla_op(event);" onkeypress="return dias_valitation(event);"></asp:TextBox>
                                </div>

                                <div class="col-4">
                                    <asp:Label ID="Label1" runat="server" Text="1. Domingo."></asp:Label>
                                    <br />
                                    <asp:Label ID="Label2" runat="server" Text="2. Lunes."></asp:Label>
                                    <br />
                                    <asp:Label ID="Label3" runat="server" Text="3. Martes."></asp:Label>
                                    <br />
                                    <asp:Label ID="Label4" runat="server" Text="4. Miercoles."></asp:Label>
                                    <br />
                                    <asp:Label ID="Label5" runat="server" Text="5. Jueves."></asp:Label>
                                    <br />
                                    <asp:Label ID="Label6" runat="server" Text="6. Viernes."></asp:Label>
                                    <br />
                                    <asp:Label ID="Label7" runat="server" Text="7. Sabado."></asp:Label>
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
              <p>OPCION INCORRECTA!&hellip;</p>
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
