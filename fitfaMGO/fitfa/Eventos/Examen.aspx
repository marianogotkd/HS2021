<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage/MasterPage.Master" CodeBehind="Examen.aspx.vb" Inherits="fitfa.Examen" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
                  
                  
                  
                      &nbsp;
                      
                      <br />


                      
                  <div id="Div1" class="card-body table-responsive p-0" runat ="server">
                      <asp:GridView ID="GridView2" class="table table-hover" runat="server" 
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
                  
                  </div>
                      <div class="mailbox-controls">
                         <asp:Label ID="Label_sel" runat="server" Text="Cambiar turnos seleccionados a:"></asp:Label>                  
                          &nbsp;<asp:DropDownList ID="DropDownList_turnos" runat="server">
                          </asp:DropDownList>
                         
                            &nbsp;<asp:Button ID="Btn_confirmar_cambio_turno" runat="server" Text="Confirmar" 
                              class="" BackColor="#00CC99" Font-Bold="True" ForeColor="White" />
              
                     </div>

                      </div>

                      

                    
                  <!-- /.tab-pane -->
                  <div class="tab-pane" id="timeline">
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
                      
                       
                  <div id="Div2" class="card-body table-responsive p-0" runat ="server">
                                            
                      <asp:GridView ID="GridView3" class="table table-hover" runat="server" 
                AllowSorting="True" AutoGenerateColumns="False" 
                           BorderColor="Black" GridLines="None" 
                          EnableSortingAndPagingCallbacks="True">
                          <Columns>
                              <asp:BoundField DataField="Info" HeaderText="Resumen:" >
                              <HeaderStyle ForeColor="#0099FF" />
                              </asp:BoundField>
                          </Columns>
                      </asp:GridView>
                  
                  </div>
                                   
                                          
                    
                  
                  
                  
                  </div>
                  <!-- /.tab-pane -->

                  <div class="tab-pane" id="settings">
                  <!-- Aqui va el codigo para la pestaña "RESULTADOS" -->
                      <asp:Label ID="Label_evento_c" runat="server" Text="Evento:" 
                          forecolor = "#3399FF" Font-Bold="True"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_fecha_c" runat="server" Text="Fecha:"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_direccion_c" runat="server" Text="Direccion:"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label_evento_cant_inscriptos_c" runat="server" Text="Cantidad de inscriptos:"></asp:Label>
                      <br />  
                      
                     <div id="grupo_sin_evaluar" runat="server" visible ="false">
                     
                      <asp:Label ID="Label_ETIQUETA_SINEVALUAR" runat="server" 
                          Text="Examenes Sin Evaluar:" ForeColor="#CC00FF"></asp:Label>
                      <div id="Div3" class="card-body table-responsive p-0" runat ="server">
                      <asp:GridView ID="GridView_sinevaluar" class="table table-hover" runat="server" 
                AllowSorting="True" AutoGenerateColumns="False" 
                           BorderColor="Black" GridLines="None" 
                          EnableSortingAndPagingCallbacks="True">
                          <Columns>
                              <asp:BoundField DataField="Nro." HeaderText="Nro." >
                              <HeaderStyle ForeColor="#CC00FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="ApeyNom" HeaderText="Alumno" >
                              <HeaderStyle ForeColor="#CC00FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Dni" HeaderText="Dni" >
                              <HeaderStyle ForeColor="#CC00FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Libreta" HeaderText="Libreta" >
                              <HeaderStyle ForeColor="#CC00FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Grad.Rendir" HeaderText="Grad.Rendir" >
                              <HeaderStyle ForeColor="#CC00FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Edad" HeaderText="Edad" >
                              <HeaderStyle ForeColor="#CC00FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Exam.Anterior" HeaderText="Exam.Anterior" >
                              <HeaderStyle ForeColor="#CC00FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Instructor" HeaderText="Instructor" >
                              <HeaderStyle ForeColor="#CC00FF" />
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
                              <HeaderStyle ForeColor="#CC00FF" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Inscexamen_id" HeaderText="Inscexamen_id" 
                                  Visible="False" />
                              <asp:TemplateField HeaderText="Resultado">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:DropDownList ID="Drop_resultado" runat="server">
                                          <asp:ListItem Selected="True">Aprobado</asp:ListItem>
                                          <asp:ListItem>Doble Promoción</asp:ListItem>
                                          <asp:ListItem>Desaprobado</asp:ListItem>
                                          <asp:ListItem>Sin Evaluar</asp:ListItem>
                                      </asp:DropDownList>
                                  </ItemTemplate>
                              </asp:TemplateField>
                              <asp:TemplateField HeaderText="Check">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:CheckBox ID="chk_calificar" runat="server" />
                                  </ItemTemplate>
                              </asp:TemplateField>
                          </Columns>
                      </asp:GridView>
                  
                  </div>
                      <div class="mailbox-controls">
                         <asp:Label ID="Label1" runat="server" Text="Confirmar resultados de la evaluación:"></asp:Label>                  
                                                  
                            &nbsp;<asp:Button ID="Btn_confirmar_resultados_evaluacion" runat="server" Text="Confirmar" 
                              class="" BackColor="#CC00FF" Font-Bold="True" ForeColor="White" />
              
                     </div>
                     </div>

                     

                      
                      <div id="grupo_desaprobados" runat="server" visible ="false">
                      
                      <%--EXAMENES DESAPROBADOS--%>
                      <asp:Label ID="Label2" runat="server" 
                          Text="Examenes Desaprobados:" ForeColor="Red"></asp:Label>
                      <div id="Div4" class="card-body table-responsive p-0" runat ="server">
                      <asp:GridView ID="GridView_desaprobados" class="table table-hover" runat="server" 
                AllowSorting="True" AutoGenerateColumns="False" 
                           BorderColor="Black" GridLines="None" 
                          EnableSortingAndPagingCallbacks="True">
                          <Columns>
                              <asp:BoundField DataField="Nro." HeaderText="Nro." >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="ApeyNom" HeaderText="Alumno" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Dni" HeaderText="Dni" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Libreta" HeaderText="Libreta" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Grad.Rendir" HeaderText="Grad.Rendir" 
                                  Visible="False" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Edad" HeaderText="Edad" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Exam.Anterior" HeaderText="Exam.Anterior" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Instructor" HeaderText="Instructor" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="usuario_id" HeaderText="usuario_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="Graduacion" HeaderText="Graduacion" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="graduacion_id" HeaderText="graduacion_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="instructor_id" HeaderText="instructor_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="evento_id" HeaderText="evento_id" Visible="False" />
                              <asp:BoundField DataField="Turno" HeaderText="Turno" >
                              <HeaderStyle ForeColor="Red" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Inscexamen_id" HeaderText="Inscexamen_id" 
                                  Visible="False" />
                              <%--<asp:TemplateField HeaderText="Check">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:CheckBox ID="chk_calificar" runat="server" />
                                  </ItemTemplate>
                              </asp:TemplateField>--%>
                          </Columns>
                      </asp:GridView>
                  
                  </div>
                      </div>
                      
                      
                      <div id="grupo_aprobados" runat="server" visible ="false">
                      <%--EXAMENES APROBADOS--%>
                      <asp:Label ID="Label3" runat="server" 
                          Text="Examenes Aprobados:" ForeColor="#00CC99"></asp:Label>
                      <div id="Div5" class="card-body table-responsive p-0" runat ="server">
                      <asp:GridView ID="GridView_aprobados" class="table table-hover" runat="server" 
                AllowSorting="True" AutoGenerateColumns="False" 
                           BorderColor="Black" GridLines="None" 
                          EnableSortingAndPagingCallbacks="True">
                          <Columns>
                              <asp:BoundField DataField="Nro." HeaderText="Nro." >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="ApeyNom" HeaderText="Alumno" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Dni" HeaderText="Dni" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Libreta" HeaderText="Libreta" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Grad.Rendir" HeaderText="Grad.Rendir" 
                                  Visible="False" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Edad" HeaderText="Edad" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Exam.Anterior" HeaderText="Exam.Anterior" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Instructor" HeaderText="Instructor" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="usuario_id" HeaderText="usuario_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="Graduacion" HeaderText="Graduacion" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="graduacion_id" HeaderText="graduacion_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="instructor_id" HeaderText="instructor_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="evento_id" HeaderText="evento_id" Visible="False" />
                              <asp:BoundField DataField="Turno" HeaderText="Turno" >
                              <HeaderStyle ForeColor="#00CC99" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Inscexamen_id" HeaderText="Inscexamen_id" 
                                  Visible="False" />
                              <%--<asp:TemplateField HeaderText="Check">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:CheckBox ID="chk_calificar" runat="server" />
                                  </ItemTemplate>
                              </asp:TemplateField>--%>
                          </Columns>
                      </asp:GridView>
                  
                  </div>
                      

                      </div>
                      

                      <div id="grupo_doblepromo" runat="server" visible ="false">
                      <%--EXAMENES DOBLE PROMOCION--%>
                      <asp:Label ID="Label4" runat="server" 
                          Text="Examenes con Doble Promoción:" ForeColor="#003300"></asp:Label>
                          <div id="Div6" class="card-body table-responsive p-0" runat ="server">
                      <asp:GridView ID="GridView_doblepromo" class="table table-hover" runat="server" 
                AllowSorting="True" AutoGenerateColumns="False" 
                           BorderColor="Black" GridLines="None" 
                          EnableSortingAndPagingCallbacks="True">
                          <Columns>
                              <asp:BoundField DataField="Nro." HeaderText="Nro." >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="ApeyNom" HeaderText="Alumno" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Dni" HeaderText="Dni" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Libreta" HeaderText="Libreta" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Grad.Rendir" HeaderText="Grad.Rendir" 
                                  Visible="False" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Edad" HeaderText="Edad" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Exam.Anterior" HeaderText="Exam.Anterior" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Instructor" HeaderText="Instructor" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="usuario_id" HeaderText="usuario_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="Graduacion" HeaderText="Graduacion" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="graduacion_id" HeaderText="graduacion_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="instructor_id" HeaderText="instructor_id" 
                                  Visible="False" />
                              <asp:BoundField DataField="evento_id" HeaderText="evento_id" Visible="False" />
                              <asp:BoundField DataField="Turno" HeaderText="Turno" >
                              <HeaderStyle ForeColor="#003300" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Inscexamen_id" HeaderText="Inscexamen_id" 
                                  Visible="False" />
                              <%--<asp:TemplateField HeaderText="Check">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:CheckBox ID="chk_calificar" runat="server" />
                                  </ItemTemplate>
                              </asp:TemplateField>--%>
                          </Columns>
                      </asp:GridView>
                  
                  </div>

                      </div>




                  </div>
                   <div class="tab-pane" id="otro">
                    
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                  </div>
                  <!-- /.tab-pane -->
                </div>
                <!-- /.tab-content -->
              </div><!-- /.card-body -->
            </div>




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