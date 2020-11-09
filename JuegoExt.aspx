<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JuegoExt.aspx.cs" Inherits="Proyecto2SIPC2.JuegoExt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="../Content/EstiloTab.css">
    <div style="height: 60px">
    </div>
     
     <div style=" height: 50px">
         <h1 style= "text-align: center; color:white;">Partida</h1>

     </div>
    <div style=" height: 1600px;">
        <div  style="border: 2px solid white; position: absolute; width: 296px; height: 770px; top: 20%; left: 2%;">
            <asp:Label ID="Label1" runat="server" Style = "position: absolute; top: 41px; left: 105px; height: 20px;" Text="Cargar Partida" ForeColor="White" Visible="True"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" Style = "position: absolute; top: 81px; left: 14px;" />
            <asp:Button Style="position: absolute; top: 139px; left: 116px; height: 28px; width: 68px;" ID="Button1" runat="server" Text="Cargar" OnClick="Button1_Click"/>    
            <asp:Label ID="Label20" runat="server" Style = "position: absolute; top: 262px; left: 108px;" Text="Nueva Partida" ForeColor="White"></asp:Label>
            <asp:CheckBox ID="CheckBox21" runat="server"  Style = "position: absolute; top: 322px; left: 154px;" Text="Modo inverso" ForeColor="White" />
        

            <asp:Button Style="position: absolute; top: 693px; left: 110px; height: 29px; width: 68px;" ID="Button3" runat="server" Text="Iniciar" OnClick="Button3_Click" />    
            <asp:DropDownList ID="DropDownList1" Style="position: absolute; top: 368px; left: 61px;" runat="server">
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" Style="position: absolute; top: 368px; left: 198px;" runat="server">
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
            </asp:DropDownList>
       
            <asp:Label ID="Label21" runat="server" Style = "position: absolute; top: 370px; left: 17px;" Text="Filas" ForeColor="White"></asp:Label>
            <asp:Label ID="Label22" runat="server" Style = "position: absolute; top: 370px; left: 127px;" Text="Columnas" ForeColor="White"></asp:Label>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server" OnLoad="UpdatePanel1_Load" server="" Style=" width: auto " UpdateMode="Conditional">
                <ContentTemplate>
            <asp:CheckBox ID="CheckBox1" runat="server"  Style = "position: absolute; top: 425px; left: 20px;" Text="Negro" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged" AutoPostBack="true" />
            <asp:CheckBox ID="CheckBox2" runat="server"  Style = "position: absolute; top: 450px; left: 20px;" Text="Blanco" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox3" runat="server"  Style = "position: absolute; top: 475px; left: 20px;" Text="Rojo" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged" AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox4" runat="server"  Style = "position: absolute; top: 500px; left: 20px;" Text="Amarillo" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox5" runat="server"  Style = "position: absolute; top: 525px; left: 20px;" Text="Azul" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox6" runat="server"  Style = "position: absolute; top: 550px; left: 20px;" Text="Anaranjado" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox7" runat="server"  Style = "position: absolute; top: 575px; left: 20px;" Text="Verde" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox8" runat="server"  Style = "position: absolute; top: 600px; left: 20px;" Text="Violeta" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox9" runat="server"  Style = "position: absolute; top: 625px; left: 20px;" Text="Celeste" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox10" runat="server"  Style = "position: absolute; top: 650px; left: 20px;" Text="Gris" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox11" runat="server"  Style = "position: absolute; top: 425px; left: 55%;" Text="Negro" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox12" runat="server"  Style = "position: absolute; top: 450px; left: 55%;" Text="Blanco" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox13" runat="server"  Style = "position: absolute; top: 475px; left: 55%;" Text="Rojo" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox14" runat="server"  Style = "position: absolute; top: 500px; left: 55%;" Text="Amarillo" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox15" runat="server"  Style = "position: absolute; top: 525px; left: 55%;" Text="Azul" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox16" runat="server"  Style = "position: absolute; top: 550px; left: 55%;" Text="Anaranjado" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox17" runat="server"  Style = "position: absolute; top: 575px; left: 55%;" Text="Verde" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox18" runat="server"  Style = "position: absolute; top: 600px; left: 55%;" Text="Violeta" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox19" runat="server"  Style = "position: absolute; top: 625px; left: 55%;" Text="Celeste" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
            <asp:CheckBox ID="CheckBox20" runat="server"  Style = "position: absolute; top: 650px; left: 55%;" Text="Gris" ForeColor="White" OnCheckedChanged="CheckBox_CheckedChanged"  AutoPostBack="true"/>
                    <asp:CheckBox ID="CheckBox22" runat="server" ForeColor="White" Style="position: absolute; top: 323px; left: 16px;" Text="Ap Personalizada" />
      </ContentTemplate>
      </asp:UpdatePanel>
               
        </div>
        
        

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" OnLoad="UpdatePanel1_Load" server="" Style="position: absolute; width: auto " UpdateMode="Conditional">
         <ContentTemplate>
            <asp:Label ID="Label19" runat="server" Style = "position: page;  left: 45%" Text="Truno:" ForeColor="White" Font-Size="Large"></asp:Label>
            <asp:Panel ID="Panel1" runat="server" style="   width: auto;  top: 20%; left: 1%">
            </asp:Panel>
            
           
             </ContentTemplate>
          </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" style="float: left; ">
                         <ContentTemplate>
                 <div >
                 <div  style=" border: 2px solid white; position: absolute;  width:296px; height: 173px; top: 200px; right: 2%; ">
                <asp:Label ID="Label3" runat="server" Style = "position: absolute; top: 20px; left: 30px; height: 20px;" Text="Jugador 1: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label4" runat="server" Style = "position: absolute; top: 20px; left: 120px; height: 20px;" Text="Jugador 1 " ForeColor="White"></asp:Label>
                <asp:Label ID="Label5" runat="server" Style = "position: absolute; top: 50px; left: 30px; height: 20px;" Text="Color: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label6" runat="server" Style = "position: absolute; top: 50px; left: 120px; height: 20px;" Text="Color de fichas " ForeColor="White"></asp:Label>
                <asp:Label ID="Label7" runat="server" Style = "position: absolute; top: 80px; left: 30px; height: 20px;" Text="Fichas: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label8" runat="server" Style = "position: absolute; top: 80px; left: 120px; height: 20px;" Text="numero de fichas " ForeColor="White"></asp:Label>
                <asp:Label ID="Label9" runat="server" Style = "position: absolute; top: 110px; left: 30px; height: 20px;" Text="Movimientos: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label10" runat="server" Style = "position: absolute; top: 110px; left: 120px; height: 20px; " Text="numero de Turnos " ForeColor="White"></asp:Label>
                </div>

                <div  style="border: 2px solid white; position: absolute; width: 296px; height: 173px; top: 450px; right: 2%;">    
                <asp:Label ID="Label11" runat="server" Style = "position: absolute; top: 20px; left: 30px; height: 20px;" Text="Jugador 2: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label12" runat="server" Style = "position: absolute; top: 20px; left: 120px; height: 20px;" Text="Jugador 1 " ForeColor="White"></asp:Label>
                <asp:Label ID="Label13" runat="server" Style = "position: absolute; top: 50px; left: 30px; height: 20px;" Text="Color: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label14" runat="server" Style = "position: absolute; top: 50px; left: 120px; height: 20px;" Text="Color de fichas " ForeColor="White"></asp:Label>
                <asp:Label ID="Label15" runat="server" Style = "position: absolute; top: 80px; left: 30px; height: 20px;" Text="Fichas: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label16" runat="server" Style = "position: absolute; top: 80px; left: 120px; height: 20px;" Text="numero de fichas " ForeColor="White"></asp:Label>
                <asp:Label ID="Label17" runat="server" Style = "position: absolute; top: 110px; left: 30px; height: 20px;" Text="Movimientos: " ForeColor="White"></asp:Label>
                <asp:Label ID="Label18" runat="server" Style = "position: absolute; top: 110px; left: 120px; height: 20px;" Text="numero de Turnos " ForeColor="White"></asp:Label>



                </div>

             </div>
                         </ContentTemplate>

        </asp:UpdatePanel>
    </div>

</asp:Content>
