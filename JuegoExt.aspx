<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JuegoExt.aspx.cs" Inherits="Proyecto2SIPC2.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="../Content/EstiloTab.css">
    <div style="height: 60px">
    </div>
     
     <div style=" height: 50px">
         <h1 style= "text-align: center; color:white;">Partida</h1>

     </div>
    <div style=" height: 1600px;">
        <div  style="border: 2px solid white; position: absolute; width: 296px; height: 428px; top: 20%; left: 2%;">
            <asp:Label ID="Label1" runat="server" Style = "position: absolute; top: 41px; left: 105px; height: 20px;" Text="Cargar Partida" ForeColor="White" Visible="True"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" Style = "position: absolute; top: 81px; left: 14px;" />
            <asp:Button Style="position: absolute; top: 139px; left: 116px; height: 28px; width: 68px;" ID="Button1" runat="server" Text="Cargar"/>    
            <asp:Label ID="Label2" runat="server" Style = "position: absolute; top: 212px; left: 102px;" Text="Guardar Partida" ForeColor="White"></asp:Label>
            <asp:Button Style="position: absolute; top: 269px; left: 117px; height: 28px; width: 68px;" ID="Button2" runat="server" Text="Guardar" />    
            <asp:Label ID="Label20" runat="server" Style = "position: absolute; top: 316px; left: 106px;" Text="Nueva Partida" ForeColor="White"></asp:Label>
            <asp:Button Style="position: absolute; top: 351px; left: 117px; height: 28px; width: 68px;" ID="Button3" runat="server" Text="Iniciar" />    
        </div>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" OnLoad="UpdatePanel1_Load" UpdateMode="Conditional" Style =" position: page; left: 15%">
         <ContentTemplate>
            <asp:Label ID="Label19" runat="server" Style = "position: page;  left: 45%" Text="Truno:" ForeColor="White" Font-Size="Large"></asp:Label>
            <asp:Panel ID="Panel1" runat="server" style="position: page;  top: 20%; left: 33%;">
            </asp:Panel>
            <div  style=" border: 2px solid white; position: absolute; width:296px; height: 173px; top: 20%; right: 2%;">
                <asp:Label ID="Label3" runat="server" Style = "position: absolute; top: 20px; left: 30px; height: 20px;" Text="Jugador 1: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label4" runat="server" Style = "position: absolute; top: 20px; left: 120px; height: 20px;" Text="Jugador 1 " ForeColor="White"></asp:Label>
                <asp:Label ID="Label5" runat="server" Style = "position: absolute; top: 50px; left: 30px; height: 20px;" Text="Color: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label6" runat="server" Style = "position: absolute; top: 50px; left: 120px; height: 20px;" Text="Color de fichas " ForeColor="White"></asp:Label>
                <asp:Label ID="Label7" runat="server" Style = "position: absolute; top: 80px; left: 30px; height: 20px;" Text="Fichas: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label8" runat="server" Style = "position: absolute; top: 80px; left: 120px; height: 20px;" Text="numero de fichas " ForeColor="White"></asp:Label>
                <asp:Label ID="Label9" runat="server" Style = "position: absolute; top: 110px; left: 30px; height: 20px;" Text="Movimientos: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label10" runat="server" Style = "position: absolute; top: 110px; left: 120px; height: 20px;" Text="numero de Turnos " ForeColor="White"></asp:Label>
            </div>
            <div  style=" border: 2px solid white; position: absolute; width:296px; height: 173px; top: 45%; right: 2%;">
                <asp:Label ID="Label11" runat="server" Style = "position: absolute; top: 20px; left: 30px; height: 20px;" Text="Jugador 2: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label12" runat="server" Style = "position: absolute; top: 20px; left: 120px; height: 20px;" Text="Jugador 1 " ForeColor="White"></asp:Label>
                <asp:Label ID="Label13" runat="server" Style = "position: absolute; top: 50px; left: 30px; height: 20px;" Text="Color: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label14" runat="server" Style = "position: absolute; top: 50px; left: 120px; height: 20px;" Text="Color de fichas " ForeColor="White"></asp:Label>
                <asp:Label ID="Label15" runat="server" Style = "position: absolute; top: 80px; left: 30px; height: 20px;" Text="Fichas: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label16" runat="server" Style = "position: absolute; top: 80px; left: 120px; height: 20px;" Text="numero de fichas " ForeColor="White"></asp:Label>
                <asp:Label ID="Label17" runat="server" Style = "position: absolute; top: 110px; left: 30px; height: 20px;" Text="Movimientos: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label18" runat="server" Style = "position: absolute; top: 110px; left: 120px; height: 20px;" Text="numero de Turnos " ForeColor="White"></asp:Label>



        </div>
             </ContentTemplate>
          </asp:UpdatePanel>
    </div>

</asp:Content>
