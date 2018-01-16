<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="WelcomeApp.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmWelcome" runat="server">
        <div id="Content" style="background-color: gainsboro;">
            <asp:Label ID="lblWelcome" runat="server" ForeColor="#CC3300" Text="Hello World!" Font-Size="XX-Large" Font-Bold="True" Font-Names="Verdana"></asp:Label>
            <br />
            <asp:Image runat="server" ImageUrl="/Content/Images/Bufsquirrel_thumb.jpg" ID="imgMyPicture" />
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnGreeting" runat="server" Text="Say Hello" ForeColor="#FFCC00" OnClick="btnGreeting_Click" Font-Bold="True" Font-Names="Verdana" Font-Size="Large" BackColor="#CC3300" />
        </div>
        <asp:Table ID="Table1" runat="server" Width="362px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell Text="Name" AbbreviatedText="NME" BorderStyle="Solid" BorderWidth="1 px" BorderColor="#CC3300"></asp:TableHeaderCell>
                <asp:TableHeaderCell Text="Date" AbbreviatedText="DTE" BorderColor="#CC3300" BorderStyle="Solid" BorderWidth="1 px"></asp:TableHeaderCell>
                <asp:TableHeaderCell Text="Course" AbbreviatedText="Course" BorderColor="#CC3300" BorderStyle="Solid" BorderWidth="1 px"></asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </form>
</body>
</html>
