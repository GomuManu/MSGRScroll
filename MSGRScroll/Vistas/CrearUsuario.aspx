<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="MSGRScroll.Usuarios.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Content/Login.css" rel="stylesheet" />
</head>
<body>
     <form id="formGeneral" runat="server">
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
            </table>
             <asp:ImageButton ImageUrl="~/images/bCrear.png" ID="btnIngresar" runat="server" Text="Crear" OnClick="btnIngresar_Click"/>
        </div>
    </form>
</body>
</html>
