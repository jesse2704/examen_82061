<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_project1_83807.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width: 100%;">
                <tr>
                    <td>Voornaam:</td>
                    <td><asp:TextBox ID="voornaam" runat="server" BorderColor="#0000CC"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Achternaam:</td>
                    <td><asp:TextBox ID="achternaam" runat="server" BorderColor="#0000CC"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Klas:</td>
                    <td><asp:TextBox ID="klas" runat="server" BorderColor="#0000CC"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Woonplaats:</td>
                    <td><asp:TextBox ID="woonplaats" runat="server" BorderColor="#0000CC"></asp:TextBox></td>
                </tr>
            </table>

            <p>
            
                <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_click"/>

            </p><br/><br/>   

             <asp:Label ID="mijnBegroeting" runat="server" Text="begroeting"></asp:Label>

        </div>
        
    </form>
</body>
</html>
