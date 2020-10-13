<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Proyecto2SIPC2.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            
    <link rel="stylesheet" href="../Content/estilo.css">
    <div style="height: 60px"></div>
    <div style="height: 800px; position:static; top: 50%;">
        <div style=" height: 50px">
            <h1 style= "text-align: center; color:white;">Bienvenido a Othello</h1>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Jugador:" style="position:absolute; left: 20%; " ForeColor="White"></asp:Label>
        <div style="height: 500px; position:absolute; top: 20%; left: 20%; width: 450px; border: 2px solid white;">
            <asp:Label ID="Label5" Style="position: absolute; top: 40px; left: 44%;" runat="server" Text="Jugar!" ForeColor="White" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="Label2" Style="position: absolute; top: 100px; left: 35%;" runat="server" Text="Partida 1 Jugador." ForeColor="White" Font-Size="Large"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Style="position: absolute; top: 130px; left: 5%;" Text="J1 Color Negro" ForeColor="White" />
            <asp:Button ID="Button1" Style="position: absolute; top: 130px; left: 39%;" runat="server" Text="Nueva Partida" OnClick="Button1_Click" />
            <asp:Label ID="Label3" Style="position: absolute; top: 180px; left: 34%;" runat="server" Text="Partida 2 Jugadores" ForeColor="White" Font-Size="Large"></asp:Label>
            <asp:Label ID="Label6" Style="position: absolute; top: 210px; left: 37%;" runat="server" Text="Nombre Jugador 2." ForeColor="White" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TextBox1" Style="position: absolute; top: 240px; left: 31%;" runat="server"></asp:TextBox>
            <asp:CheckBox ID="CheckBox2" runat="server" Style="position: absolute; top: 280px; left: 5%;" Text="J1 Color Negro" ForeColor="White" />
            <asp:Button ID="Button2" Style="position: absolute; top: 280px; left: 39%;" runat="server" Text="Nueva Partida" OnClick="Button2_Click" />
            <asp:Label ID="Label4" Style="position: absolute; top: 330px; left: 39%;" runat="server" Text="Crear Torneo" ForeColor="White" Font-Size="Large"></asp:Label>
            <asp:Button ID="Button3" Style="position: absolute; top: 360px; left: 39%;" runat="server" Text="Nuevo Torneo" />
           
        </div>
        <div style="height: 500px; position:absolute; top: 20%; right: 20%; width: 450px; border: 2px solid white;">
           
        </div>
    </div>
</asp:Content>
