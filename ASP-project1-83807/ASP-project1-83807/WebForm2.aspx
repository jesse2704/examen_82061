<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASP_project1_83807.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="getalveld1" runat="server"></asp:TextBox><br/>
            <asp:TextBox ID="getalveld2" runat="server"></asp:TextBox><br/>

            <asp:Button ID="Button1" runat="server" Text="X" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="/" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="-" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="+" OnClick="Button4_Click" /><br/>

            <asp:TextBox ID="antwoordveld" runat="server"></asp:TextBox><br/> 

        </div>
    </form>
</body>
</html>
