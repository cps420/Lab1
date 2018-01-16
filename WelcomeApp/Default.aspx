<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WelcomeApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price quotation</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Price quotation</h1>
        <asp:Table runat="server" Height="100px" Width="544px">
            <asp:TableRow>
                <asp:TableCell>Sales price</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtSalesPrice" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblWarningSalesPrice" runat="server" Text="This field is required." ForeColor="#FF9900"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Discount percent</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtDiscountPercent" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblWarningDiscountPercent" runat="server" Text="This field is required." ForeColor="#FF9900"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Discount amount</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblDiscountAmount" runat="server" Font-Bold="True">$100</asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Total price</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblTotal" runat="server" Font-Bold="True">$400</asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="btnCalculate" OnClick="btnCalculate_Click" runat="server" Text="Calculate"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
