﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage/MasterPage.Master" CodeBehind="Examen.aspx.vb" Inherits="fitfa.Examen" %>
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
                  
                  <%--aqui va el codigo para la primer pestaña--%>
                      <asp:Label ID="Label_evento" runat="server" Text="Evento:" 
                          forecolor = "#3399FF" Font-Bold="True"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_fecha" runat="server" Text="Fecha:"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_direccion" runat="server" Text="Direccion:"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_cant_inscriptos" runat="server" Text="Cantidad de inscriptos:"></asp:Label>
                      <br />
                      
                  
                  <div class="card-body table-responsive p-0" runat ="server">
                      <asp:GridView ID="GridView1" class="table table-hover" runat="server" 
                AllowSorting="True" AutoGenerateColumns="False" 
                           BorderColor="Black" GridLines="None" 
                          EnableSortingAndPagingCallbacks="True">
                          <Columns>
                              <asp:BoundField DataField="Nro." HeaderText="Nro." >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="ApeyNom" HeaderText="Alumno" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Dni" HeaderText="Dni" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Libreta" HeaderText="Libreta" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Grad.Rendir" HeaderText="Grad.Rendir" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Edad" HeaderText="Edad" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Exam.Anterior" HeaderText="Exam.Anterior" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Instructor" HeaderText="Instructor" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="usuario_id" HeaderText="usuario_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="Graduacion" HeaderText="Graduacion" 
                                  Visible="False" />
                              <asp:BoundField DataField="graduacion_id" HeaderText="graduacion_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="instructor_id" HeaderText="instructor_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="evento_id" HeaderText="evento_id" Visible="False" />
                              <asp:BoundField DataField="Turno" HeaderText="Turno" Visible="False" />
                              <asp:BoundField DataField="Inscexamen_id" HeaderText="Inscexamen_id" 
                                  Visible="False" />
                          </Columns>
                      </asp:GridView>
                  
                  </div>
                  <button type="submit" class="btn btn-primary" runat="server" id="btn_exportar_excel1">Exportar excel</button>
                  
                  
                  
                      &nbsp;</div>
                    <asp:Button ID="Boton_exportar" runat="server" Text="Excel"/>
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