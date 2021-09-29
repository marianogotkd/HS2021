<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Inicio.aspx.vb" Inherits="Presentacion.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


 
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/descarga (1).jpg" />
             
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
            
<script type="text/javascript">
    $(function () {
        //Yes! use keydown because some keys are fired only in this trigger,
        //such arrows keys
        $("body").keydown(function (e) {
            //well so you need keep on mind that your browser use some keys 
            //to call some function, so we'll prevent this
            e.preventDefault();

            //now we caught the key code.
            var keyCode = e.keyCode || e.which;

            //your keyCode contains the key code, F1 to F12 
            //is among 112 and 123. Just it.
            alert(keyCode);

            switch (keyCode) {
                case 112:
                    window.location.href = "../Articulos/Articulos.aspx";
                    break;
                case 113:
                    window.location.href = "Articulos.aspx";
                    break;
                default:
                    break;
            }

        });
    });
    </script>
</asp:Content>

