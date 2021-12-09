<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Move.aspx.cs" Inherits="CSCI366FinalProj.Move" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search by Move Name" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search By Type" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Order By Power High to Low" />
    </form>
</body>
</html>
