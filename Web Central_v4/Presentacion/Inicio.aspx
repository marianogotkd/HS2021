<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Inicio.aspx.vb" Inherits="Presentacion.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script>

    //funcion que reconoce teclas para ir a los botones retroceso, baja y graba
    function tecla_op_botones(e) {
        var keycode = e.keyCode;
        ///ENTER
        if (keycode == '13') {
            e.preventDefault();
            document.getElementsByTagName('button')[0].focus();
            document.getElementsByTagName('button')[0].click();

        }

//        ///F2 
//        if (keycode == '113') {
//            e.preventDefault();
//            document.getElementsByTagName('button')[0].focus();
//            document.getElementsByTagName('button')[0].click();
//        }

    }




</script>
 

 



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--<asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/descarga (1).jpg" />--%>

<asp:ScriptManager ID="ScriptManager1" runat="server" 
                            EnableScriptGlobalization="True">
</asp:ScriptManager>             

<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>



<div class="card card-primary">


<div class="card-header">
<h3 class="card-title">MENU PRINCIPAL</h3>
</div>


<form role="form">
<div class="card-body">
<div>   <%--align="center"--%>
<div class="row justify-content-center" >   <%--class="row "--%>
<div class="col-lg-6">
<div class="card">
<div class="card-body">


    <div class="container ">
        <div class="row">
            <div class="col">  <%--class="col-4"--%>
              <div class="form-group">
              1 - INICIAR DIA.
              </div>
              <div class="form-group">
              2 - CARGA DE RECORRIDOS/ZONAS.
              </div>
              <div class="form-group">
              3 - CARGA PAGOS/COBROS/RECLAMOS.
              </div>
              <div class="form-group">
              4
              </div>
              <div class="form-group">
              5
              </div>
              <div class="form-group">
              6
              </div>
              <div class="form-group">
              7
              </div>
              <div class="form-group">
              8
              </div>
              <div class="form-group">
              9
              </div>
              <div class="form-group">
              10
              </div>
              
            </div>
            <div class="col"> <%--class="col-4"--%>
              <div class="form-group">
              A - A.B.M. GRUPOS.
              </div>
              <div class="form-group">
              B - A.B.M. CLIENTES.
              </div>
              <div class="form-group">
              C - A.B.M.L. PRESTAMOS/CREDITOS.
              </div>
              <div class="form-group">
              D - A.C.L. GASTOS.
              </div>
              <div class="form-group">
              E - A.B. RECORRIDOS/ZONAS.
              </div>
              <div class="form-group">
              F - MODIFICA SALDOS.
              </div>
              <div class="form-group">
              G
              </div>
              <div class="form-group">
              H
              </div>
              <div class="form-group">
              I
              </div>
              <div class="form-group">
              J
              </div>
            </div>
        </div>
    </div>

    <div align="center">
    <div class="form-group">
        
        <asp:TextBox ID="txt_opcion" runat="server" placeholder="ingrese opción..." 
            Width="120px" onkeydown="tecla_op_botones(event);" MaxLength="1"></asp:TextBox>
        &nbsp;
        <button type="button" id="btn_opcion" runat="server" class="btn btn-primary" onkeydown="tecla_op_botones(event);">
                          IR
        </button>
    </div>
    
    </div>

</div>

<div class="card-footer">
    <div class="row justify-content-center" >

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
