
<%@ Page  Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="MSGRScroll.Usuarios.Amigos" EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/MainCss.css" rel="stylesheet" />
    <link href="Content/botstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
           <a class="text-center" runat="server" href="agregarAmigos.aspx">Agregar amigo</a>
            <a class="text-center" runat="server" href="EditarUsuario.aspx">Datos personales</a>

                    <!-- Solicitudes de amistad-->
                        <div class="dropdown">
                          <a>Solicitudes de amistad</a>
                            <asp:DataList 
                             runat="server"
                             id="solicitudesList"
                            >
                              <ItemTemplate>
                                  <div class="dropdown-content">

                                      <div class="chat_img"> <img src="../images/blake.png" alt="sunil" /> </div>
                                      <div  class="chat_description">
                                          <h5><%# DataBinder.Eval(Container.DataItem, "nickName") %>, te ha enviado una solicitud de amistad</h5>
                                          <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" CssClass="btnAceptar" Text="Aceptar" runat="server"/>
                                          <asp:Button ID="btnRechazar" OnClick="btnRechazar_Click" CssClass="btnRechazar" Text="Rechazar" runat="server"/>
                                      </div>

                                  </div>
                              </ItemTemplate>

                          </asp:DataList>
                        </div>
                        <!-- Fin -->

           <div class="container">
            <h3 class=" text-center">Mensajes</h3>
            <div class="messaging">
                  <div class="inbox_msg">
                    <div class="inbox_people">

                      <div class="headind_srch">
                        <div class="recent_heading">
                          <h4>Recent</h4>
                        </div>
                        <div class="srch_bar">
                          <div class="stylish-input-group">
                            <input type="text" class="search-bar"  placeholder="Search" />
                            <span class="input-group-addon">
                            <button type="button"> <i class="fa fa-search" aria-hidden="true"></i> </button>
                            </span> </div>
                        </div>
                      </div>
                      <div class="inbox_chat">

                        <asp:DataList 
                            runat="server"
                            id="amigosList"
                            OnComandAbrirChat="OnComandAbrirChat"
                            >
                             <ItemTemplate>

                               <div class="chat_list">
                                  <div class="chat_people"> 
                                    <div class="chat_img"> <asp:ImageButton CssClass="imgAbrirChat" CommandName="OnComandAbrirChat" ImageUrl="../images/blake.png" runat="server" /> </div>
                                    <div class="chat_abrirChat"> <asp:ImageButton  CssClass="imgAbrirChat" CommandName="OnComandAbrirChat" ImageUrl="../images/bChat.png" runat="server" /> </div>
                                    <div class="chat_ib">
                                      <h5> <%# DataBinder.Eval(Container.DataItem, "nickName") %> <span class="chat_date"></span></h5>
                                      <p> <%# DataBinder.Eval(Container.DataItem, "estadoTexto") %> </p>
                                    </div>
                                  </div>
                                </div>

                             </ItemTemplate>
                          </asp:DataList>


                      </div>
                    </div>

                    <div class="mesgs">
                      <div class="msg_history">
                        <!--
                        <div class="incoming_msg">
                          <div class="incoming_msg_img"> <img src="https://ptetutorials.com/images/user-profile.png" alt="sunil"> </div>
                          <div class="received_msg">
                            <div class="received_withd_msg">
                              <p>Mensaje</p>
                              <span class="time_date"> 11:01 AM    |    June 9</span></div>
                          </div>
                        </div>

                        <div class="outgoing_msg">
                          <div class="sent_msg">
                            <p>Mensaje</p>
                            <span class="time_date"> 11:01 AM    |    June 9</span> </div>
                        </div>
                         -->

                           <%--<asp:DataList 
                            runat="server"
                            id="mensajesChattList"
                            >

                             <ItemTemplate>

                                <div class="incoming_msg">
                                  <div class="incoming_msg_img"> <img src="https://ptetutorials.com/images/user-profile.png" alt="sunil"> </div>
                                  <div class="received_msg">
                                    <div class="received_withd_msg">
                                      <p>Mensaje</p>
                                      <span class="time_date"> 11:01 AM    |    June 9</span></div>
                                  </div>
                                </div>


                             </ItemTemplate>


                            </asp:DataList>--%>

                      <div class="type_msg">
                        <div class="input_msg_write">
                          <input type="text" class="write_msg" placeholder="Type a message" />
                          <button class="msg_send_btn" type="button"><i class="fa fa-paper-plane-o" aria-hidden="true"></i></button>
                        </div>
                      </div>

                    </div>
                  </div>

                </div>
           </div>
    </form>
</body>
</html>
