<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TypeMatchup.aspx.cs" Inherits="CSCI366FinalProj.TypeMatchup" %>

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
            Attacking Type:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Defending Type:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Damage Multiplier: "></asp:Label>
        </div>
    </form>
</body>
</html>
