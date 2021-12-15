<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeamBuilder.aspx.cs" Inherits="CSCI366FinalProj.TeamBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
        </div>
        <asp:Label ID="Label5" runat="server" Text="Choose Pokemon:"></asp:Label>
&nbsp;<asp:DropDownList ID="Pokemon1Dropdown" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Nickname:"></asp:Label>
        &nbsp;<asp:TextBox ID="NicknameBox" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="addPokemonButton" runat="server" OnClick="Button1_Click" Text="Add Pokemon" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="Trainer Name"></asp:Label>
            :
            <asp:TextBox ID="TrainerNameBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="CreateTeamButton" runat="server" OnClick="Button2_Click" Text="Create Team" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/viewTeams.aspx">View Teams</asp:HyperLink>
    </form>
</body>
</html>
