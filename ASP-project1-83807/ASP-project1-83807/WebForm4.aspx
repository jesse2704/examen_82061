<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="ASP_project1_83807.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
           Hoeveel pennen wil je kopen? <asp:TextBox ID="pennenVeld" runat="server" BorderColor="#000099"></asp:TextBox>
        </div>

        <p>
            <asp:Button ID="Button1" runat="server" Text="Kopen" Height="201px" Width="941px" OnClick="Button1_Click" />
        </p>

        <asp:Label ID="Label1" runat="server" Text="[ReactieLabel]"></asp:Label><br/>
        <asp:Label ID="Label2" runat="server" Text="[reactietextLabel]"></asp:Label>

    </form>
</body>
</html>
