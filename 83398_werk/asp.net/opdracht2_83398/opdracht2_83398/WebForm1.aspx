<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="opdracht2_83398.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
            <br />
       

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br /> 
            
            <asp:Button ID="plus" runat="server" Text="+" OnClick="plus_Click" />
            <asp:Button ID="min" runat="server" Text="-" OnClick="min_Click" />
            <asp:Button ID="keer" runat="server" Text="*" OnClick="keer_Click" />
            <asp:Button ID="Button1" runat="server" Text="/" OnClick="Button1_Click1" />
            <br />
            
            <!--<asp:Button ID="is" runat="server" Text="=" OnClick="Button1_Click" />-->
            <br />
            <asp:Label ID="Label2" runat="server" Text="het antwoord is"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br /><br />
            <!--<asp:Label ID="Label4" runat="server" Text="Het is nu"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label> -->

        </div>
    </form>
</body>
</html>
