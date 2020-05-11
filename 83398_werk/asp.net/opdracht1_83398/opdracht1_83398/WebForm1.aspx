<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="opdracht1_83398.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <td><asp:Label ID="voornaam" runat="server" Text="Wat is je voornaam?"></asp:Label></td>
                    <td><asp:TextBox ID="voornaamveld" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><asp:Label ID="achternaam" runat="server" Text="Wat is je achternaam?"></asp:Label></td>
                    <td><asp:TextBox ID="achternaamveld" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><asp:Label ID="woonplaats" runat="server" Text="Waar woon je?"></asp:Label></td>
                    <td><asp:TextBox ID="woonplaatsveld" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><asp:Label ID="klas" runat="server" Text="In welke klas zit je?"></asp:Label></td>
                    <td><asp:TextBox ID="klasveld" runat="server"></asp:TextBox></td>
                </tr>

            </table>        
            <br />
            <asp:Button ID="mijnknop" runat="server" Text="Verzenden" OnClick="mijnknop_Click" />
        </div>
        <asp:Label ID="groet" runat="server" Text=""></asp:Label>
    </form>
   
</body>
</html>
