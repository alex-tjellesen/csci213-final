<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pokemon.aspx.cs" Inherits="CSCI366FinalProj.Pokemon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sort by HP" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sort by Attack" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Sort by Defense" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Sort by Special" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Sort by Speed" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Sort by Type" />
    </form>
</body>
</html>
