<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage/MasterPage.Master" CodeBehind="Examen.aspx.vb" Inherits="fitfa.Examen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>


    <div class="card">
              <div class="card-header p-2">
                <ul class="nav nav-pills">
                  <li class="nav-item"><a class="nav-link active" href="#activity" data-toggle="tab">Listado del Examen</a></li>
                  <li class="nav-item"><a class="nav-link" href="#timeline" data-toggle="tab">Turnos</a></li>
                  <li class="nav-item"><a class="nav-link" href="#settings" data-toggle="tab">Resultados</a></li>
                  <li class="nav-item"><a class="nav-link" href="#otro" data-toggle="tab">Otro</a></li>
                </ul>
              </div><!-- /.card-header -->
              <div class="card-body">
                <div class="tab-content">
                  <div class="active tab-pane" id="activity">
                      <asp:Button ID="Button1" runat="server" Text="Button" />
                  </div>
                  <!-- /.tab-pane -->
                  <div class="tab-pane" id="timeline">
                    <!-- The timeline -->
                      <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                  </div>
                  <!-- /.tab-pane -->

                  <div class="tab-pane" id="settings">
                    


                  </div>
                   <div class="tab-pane" id="otro">
                    
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                  </div>
                  <!-- /.tab-pane -->
                </div>
                <!-- /.tab-content -->
              </div><!-- /.card-body -->
            </div>





     </ContentTemplate>

    </asp:UpdatePanel>

    </asp:Content>