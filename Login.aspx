<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto2SIPC2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <link rel="stylesheet" href="../Content/estilo.css">
<body>
    <form id="form1" runat="server">
        <div class="login-box">
    <h1>Login</h1>
    <form action="juego.html" onsubmit="return logear();">
        <label for="username">Usuario</label>
        <asp:TextBox ID="TextBox1" runat="server"  placeholder="Ingrese Username"></asp:TextBox>
        <label for="password">Password</label>
        <asp:TextBox ID="TextBox2" runat="server"  placeholder="Ingrese Password"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <a style="color: white; text-align: center; display: inline-block; width: 100%; " runat="server" href="Registro">Registrarse</a>
    </form>
</div>
    </form>
</body>
</html>
