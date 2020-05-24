<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MSGRScroll.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/Login.css" rel="stylesheet" />
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
                        <asp:TextBox ID="txtContrasena" TextMode="Password" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">  
                        <a href ="../Vistas/CrearUsuario.aspx">Crear una cuenta</a>
                    </td>
                </tr>
            </table>
             <asp:ImageButton ImageUrl="~/images/bIngresar.png" ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"/>
        </div>
    </form>
</body>
</html>
