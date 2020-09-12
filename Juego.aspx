<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Juego.aspx.cs" Inherits="Proyecto2SIPC2.Juego" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height: 60px">
    </div>
     <div style="height: 150px">
         <h1 style= "text-align: center;">Partida</h1>
     </div>
    <script>
        function cambiarColor(boton)
        {
            document.boton.style.background = black;
        }
    </script>
    <div style="height: 600px">
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
                <asp:Button Style="border-radius: 100%; background-color:transparent; border: none;"  ID="Button1" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>    
            </div>
            <div class="cuadroB flotar">
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button2" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>    
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button3" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button4" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button5" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button6" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button7" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button8" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
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
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button9" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button10" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button11" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button12" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button13" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button14" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button15" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button16" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
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
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button17" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button18" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button19" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button20" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button21" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button22" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button23" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button24" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
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
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button25" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button26" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button27" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button28" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button29" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button30" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button31" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button32" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
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
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button33" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button34" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button35" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button36" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button37" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button38" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button39" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button40" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
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
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button41" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button42" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button43" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button44" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button45" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button46" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button47" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button48" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
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
                 <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button49" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button50" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button51" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button52" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button53" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button54" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button55" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button56" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
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
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button57" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button58" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button59" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button60" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button61" runat="server" Text="" Height="60px" Width="60px" OnClick="Click" />
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button62" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button63" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
            </div>
            <div class="cuadroB flotar">
                <asp:Button Style="border-radius: 100%; background-color: transparent; border: none;" ID="Button64" runat="server" Text="" Height="60px" Width="60px" OnClick="Click"/>
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
