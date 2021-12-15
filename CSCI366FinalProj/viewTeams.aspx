<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTeams.aspx.cs" Inherits="CSCI366FinalProj.ViewTeams" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            Enter &quot;trainer_id&quot; of team to delete:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Team" />
            <br />
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TeamBuilder.aspx">Create Teams</asp:HyperLink>
    </form>
</body>
</html>
