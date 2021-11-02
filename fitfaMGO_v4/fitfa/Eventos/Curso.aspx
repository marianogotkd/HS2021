﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage/MasterPage.Master" CodeBehind="Curso.aspx.vb" Inherits="fitfa.Curso" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
   
                    <!-- Aqui va el codigo para la pestaña "TURNOS" -->
                      <asp:Label ID="Label_evento_b" runat="server" Text="Evento:" 
                          forecolor = "#3399FF" Font-Bold="True"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_fecha_b" runat="server" Text="Fecha:"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_direccion_b" runat="server" Text="Direccion:"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_cant_inscriptos_b" runat="server" Text="Cantidad de inscriptos:"></asp:Label>
                      <br />
                      

                       
                 
                      <asp:GridView ID="GridView2" class="table table-hover" runat="server" 
                AllowSorting="True" AutoGenerateColumns="False" 
                           BorderColor="Black" 
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
                              <asp:BoundField DataField="Exam.Anterior" HeaderText="Exam.Anterior" 
                                  Visible="False" >
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
                              <asp:BoundField DataField="Turno" HeaderText="Turno" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Inscexamen_id" HeaderText="Inscexamen_id" 
                                  Visible="False" />
                              <asp:TemplateField HeaderText="Mover">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:CheckBox ID="chk_mover" runat="server" style="text-align: center" />
                                  </ItemTemplate>
                                  <HeaderStyle ForeColor="#00CC99" />
                              </asp:TemplateField>
                              <asp:TemplateField HeaderText="Eliminar">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:Button ID="Button1" runat="server" CommandName="op_eliminar" CommandArgument='<%# Eval("Inscexamen_id") %>' 
                                          Text="Eliminar" />
                                  </ItemTemplate>
                                  <HeaderStyle ForeColor="#FF5050" />
                              </asp:TemplateField>
                          </Columns>
                      </asp:GridView>



                        <div id="div_msj_error_eliminar" runat="server">
            <asp:HiddenField ID="HiddenField_msj" runat="server" />
            <asp:Panel ID="Panel1" runat="server" >
                          <div class="card card-primary">
            <div class="card-header">
                <h3 class="card-title">Advertencia</h3>
            </div>
            <form role="form">
              <div class="card-body"> 
              <div class="row">
              <div align="center">
                    <asp:Label ID="Label12" runat="server" Text="No puede eliminar. El alumno ya fue evaluado!"></asp:Label>
                    &nbsp;
              </div>
              <div align="center">
                    <asp:Button ID="Btb_msj_no_eliminar" runat="server" Text="OK" />
              </div>  
              </div>
              </div>
            </form>              
            </div> 
        </asp:Panel>
                           <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="HiddenField_msj" PopupControlID="Panel1" CancelControlID="Btb_msj_no_eliminar" BackgroundCssClass="modalBackground">
                            </asp:ModalPopupExtender>
            </div>



 </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>