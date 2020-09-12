<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Proyecto2SIPC2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro</title>
</head>
        <link rel="stylesheet" href="../Content/estilo.css">

<body>
    <form id="form1" runat="server">
        <div class="registro-box">
            <h1>Registrar</h1>
            <form>
                <label for="nombre">Nombres</label>
                <asp:TextBox ID="TextBox1" placeholder="Ingrese Nombre" runat="server"></asp:TextBox>
                <label for="apellido">Apellidos</label>
                <asp:TextBox ID="TextBox2" placeholder="Ingrese Apellido" runat="server"></asp:TextBox>
                <label for="email">E-mail</label>
                <asp:TextBox ID="TextBox3" placeholder="Ingrese E-mail" runat="server"></asp:TextBox>
                <label for="user">Usuario</label>
                <asp:TextBox ID="TextBox4" placeholder="Ingrese Usuario" runat="server"></asp:TextBox>
                <label for="pass">Contrasenia</label>
                <asp:TextBox ID="TextBox5" placeholder="Ingrese Password" runat="server"></asp:TextBox>
                <label for="fecha">Fecha de nacimiento</label>
                <asp:TextBox ID="TextBox6" type="date" placeholder="dd/mm/aa" runat="server"></asp:TextBox>
                <label for="country">Elija pais:</label>
                <asp:TextBox ID="TextBox7"  placeholder="Ingrese pais" runat="server"></asp:TextBox>
                <p></p>
                <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click"/>
                <img src="../Img/facebook.jpg" style="width: 85px; height: 55px; position: absolute; left: 15%; top: 93%;">
                <img src="../Img/circleicon-googleplus-white.png" style="width: 40px; height: 40px; position: absolute; left: 45%; top: 94%;" ;>
                <img src="../Img/twitter.png" style="width: 40px; height: 40px; position: absolute; left: 70%; top: 94%;">

    </form>
</div>
    </form>
</body>
</html>
