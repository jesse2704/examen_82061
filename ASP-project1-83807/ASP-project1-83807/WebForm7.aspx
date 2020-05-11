<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="ASP_project1_83807.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Vandaag is het: <asp:TextBox ID="vandaag" runat="server"></asp:TextBox><br /><br />
            Over: <asp:TextBox ID="overdag" runat="server"></asp:TextBox> dagen <br /><br />
            <asp:Button ID="antwoord" runat="server" Text="is het:" OnClick="Button1_Click" /> &nbsp; <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
