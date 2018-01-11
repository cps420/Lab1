<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="WelcomeApp.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmWelcome" runat="server">
        <div id="Content">
            <asp:Label ID="lblName" runat="server">Hello</asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Image runat="server" />
            <asp:Button ID="btnGreeting" runat="server" Text="Submit" BackColor="#cc3300" ForeColor="#f2f2f2" OnClick="btnGreeting_Click" />
        </div>
    </form>
</body>
</html>
