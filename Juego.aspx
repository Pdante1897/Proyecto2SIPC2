<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Juego.aspx.cs" Inherits="Proyecto2SIPC2.Juego" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height: 60px">
    </div>
     <div style=" height: 50px">
         <h1 style= "text-align: center; color:white;">Partida</h1>

     </div>
    <div style="border: 2px solid white; height: 700px">
        <div  style="border: 2px solid white; position: absolute; width: 296px; height: 315px; top: 20%; left: 13%;">
         <asp:Label ID="Label1" runat="server" Style = "position: absolute; top: 41px; left: 105px; height: 20px;" Text="Cargar Partida" ForeColor="White"></asp:Label>
         <asp:FileUpload style="position:absolute; top: 87px; left: 13px;" ID="FileUpload1" runat="server" ForeColor="White" />
         <asp:Button Style="position: absolute; top: 139px; left: 116px; height: 28px; width: 68px;" ID="Button1" runat="server" Text="Cargar" OnClick="Button1_Click"/>    

         <asp:Label ID="Label2" runat="server" Style = "position: absolute; top: 212px; left: 102px;" Text="Cargar Partida" ForeColor="White"></asp:Label>
         <asp:Button Style="position: absolute; top: 269px; left: 117px; height: 28px; width: 68px;" ID="Button2" runat="server" Text="Cargar" OnClick="Button1_Click"/>    

        </div>
        <div  style=" border: 2px solid white; position:absolute; width:296px; height: 173px; top: 65%; left: 13%;">
         <asp:Label ID="Label3" runat="server" Style = "position: absolute; top: 17px; left: 88px; height: 20px;" Text="Ingresar coordenadas" ForeColor="White"></asp:Label>
         <asp:Button Style="position: absolute; top: 116px; left: 115px; height: 28px; width: 68px;" ID="Button3" runat="server" Text="Colocar" OnClick="Button3_Click1"/>    

            <asp:TextBox  Style="position: absolute; top: 64px; left: 63px;" ID="TextBox1" runat="server"></asp:TextBox>

        </div>
    <div  style="position:absolute; width:800px; height: 400px; top: 20%; left: 33%;">
                <link rel="stylesheet" href="../Content/EstiloTab.css">
        
       <div class="flotar">

            <div class="cafe flotar">
                
            </div>
            <div class="cafe flotar">
                <h1>A</h1>
            </div>
            <div class="cafe flotar">
                <h1>B</h1>
            </div>
            <div class="cafe flotar">
                <h1>C</h1>
            </div>
            <div class="cafe flotar">
                <h1>D</h1>
            </div>
            <div class="cafe flotar">
                <h1>E</h1>
            </div>
            <div class="cafe flotar">
                <h1>F</h1>
            </div>
            <div class="cafe flotar">
                <h1>G</h1>
            </div>
            <div class="cafe flotar">
                <h1>H</h1>
            </div>
            <div class="cafe flotar">

            </div>
       </div>
       <div class="flotar">
           <div class="cafe flotar">
               <h1>1</h1>
            </div>
             <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color:transparent; border: none;"  ID="A1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>    
            </div>
            <div class="cuadroB flotar">
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="B1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>    
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="C1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="D1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="E1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="F1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="G1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="H1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cafe flotar">
                <h1>1</h1>
            </div>
       </div>
        <div class="flotar">
            <div class="cafe flotar">
                <h1>2</h1>
            </div>
             <div class="cuadroB flotar">
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="A2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="B2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="C2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="D2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="E2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="F2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="G2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="H2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cafe flotar">
                <h1>2</h1>
            </div>
       </div>
       <div class="flotar">
           <div class="cafe flotar">
               <h1>3</h1>
            </div>
             <div class="cuadroB flotar">
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="A3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="B3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="C3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="D3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="E3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="F3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="G3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="H3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cafe flotar">
                <h1>3</h1>
            </div>
       </div>
        <div class="flotar">
            <div class="cafe flotar">
                <h1>4</h1>
            </div>
             <div class="cuadroB flotar">
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="A4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="B4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="C4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="D4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="E4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="F4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="G4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="H4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cafe flotar">
                <h1>4</h1>
            </div>
       </div>
       <div class="flotar">
           <div class="cafe flotar">
               <h1>5</h1>
            </div>
             <div class="cuadroB flotar">
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="A5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="B5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="C5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="D5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="E5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="F5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="G5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="H5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cafe flotar">
                <h1>5</h1>
            </div>
       </div>
        <div class="flotar">
            <div class="cafe flotar">
                <h1>6</h1>
            </div>
             <div class="cuadroB flotar">
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="A6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="B6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="C6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="D6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="E6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="F6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="G6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="H6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cafe flotar">
                <h1>6</h1>
            </div>
       </div>
       <div class="flotar">
           <div class="cafe flotar">
               <h1>7</h1>
            </div>
             <div class="cuadroB flotar">
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="A7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="B7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="C7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="D7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="E7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="F7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="G7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="H7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cafe flotar">
                <h1>7</h1>
            </div>
       </div>
        <div class="flotar">

            <div class="cafe flotar">
                <h1>8</h1>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="A8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="B8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="C8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="D8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="E8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="F8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="G8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="H8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cafe flotar">
                <h1>8</h1>
            </div>
       </div>
       <div class="flotar">

            <div class="cafe flotar">
                
            </div>
            <div class="cafe flotar">
                <h1>A</h1>
            </div>
            <div class="cafe flotar">
                <h1>B</h1>
            </div>
            <div class="cafe flotar">
                <h1>C</h1>
            </div>
            <div class="cafe flotar">
                <h1>D</h1>
            </div>
            <div class="cafe flotar">
                <h1>E</h1>
            </div>
            <div class="cafe flotar">
                <h1>F</h1>
            </div>
            <div class="cafe flotar">
                <h1>G</h1>
            </div>
            <div class="cafe flotar">
                <h1>H</h1>
            </div>
            <div class="cafe flotar">

            </div>
       </div>
    </div>
    </div>
</asp:Content>
