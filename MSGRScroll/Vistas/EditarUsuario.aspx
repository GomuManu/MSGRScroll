<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="MSGRScroll.Usuarios.EditarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Content/Login.css" rel="stylesheet" />
</head>
<body>
      <form id="formLogin" runat="server">
        <div>
            <div id="logo"></div>
            <table>
                <tr>
                    <td class="auto-style1">Nombre de usuario: </td>
                    <td>
                        <asp:TextBox ID="txtUsuario" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">Contraseña: </td>
                    <td>
                        <asp:TextBox ID="txtContrasena" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Repetir Contraseña: </td>
                    <td>
                        <asp:TextBox ID="txtContrasena2" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Nickname: </td>
                    <td>
                        <asp:TextBox ID="txtNickname" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Estado: </td>
                    <td>
                        <asp:TextBox ID="txtEstado" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
            </table>
             <asp:ImageButton ImageUrl="~/images/bEditar.png" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click"/>
        </div>
    </form>
</body>
</html>
