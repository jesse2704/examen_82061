<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="ASP_project1_83807.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            stel je pizza samen!:<br/>
            <asp:CheckBox ID="Tomatensaus" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tomatensaus 3$<br/>
            <asp:CheckBox ID="Salami" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Salami 2$<br/>
            <asp:CheckBox ID="Pepperoni" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pepperoni 2$<br/>
            <asp:CheckBox ID="Ham" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ham 2$<br/>
            <asp:CheckBox ID="Mozzarella" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mozzarella 3$<br/>
            <asp:CheckBox ID="Paprika" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Paprika 1.50$<br/> 
            <asp:CheckBox ID="Champignon" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Champignon 1.50$<br/>
            <asp:CheckBox ID="Gorgonzola" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Gorgonzola 3$<br/>
            <asp:CheckBox ID="Knoflook" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Knoflook 1$<br/>
            <asp:CheckBox ID="Ananas" runat="server"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ananas 999$<br/>

            <asp:Button ID="rekenuit" runat="server" Text="Reken uit" OnClick="rekenuit_Click1"/><br/>
            <asp:Label ID="Totaal" runat="server" Text="[totaal prijs]"></asp:Label>

        </div>
    </form>
</body>
</html>
