<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarAmigos.aspx.cs" Inherits="MSGRScroll.Usuarios.agregarAmigos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/Login.css" rel="stylesheet" />
</head>
<body>
    <form id="formLogin" runat="server">
        <div>
            <h3 > Puedes agregar a alguien con su número de amigo.</h3>
            <a > Ejemplo: EJE#456</a>
            <table>
                <tr>
                    <td class="auto-style1">Número de Amigo: </td>
                    <td>
                        <asp:TextBox ID="txtNumeroAmigo" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
             <asp:ImageButton ImageUrl="~/images/bAgregar.png" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click"/>
        </div>
    </form>
</body>
</html>
