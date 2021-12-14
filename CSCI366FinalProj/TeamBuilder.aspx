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
        <asp:DropDownList ID="Pokemon1Dropdown" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:TextBox ID="NicknameBox" runat="server"></asp:TextBox>
        <asp:Button ID="addPokemonButton" runat="server" OnClick="Button1_Click" Text="Add Pokemon" />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:TextBox ID="trainerIDBox" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Trainer ID"></asp:Label>
            <asp:TextBox ID="TrainerNameBox" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Trainer Name"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="CreateTeamButton" runat="server" OnClick="Button2_Click" Text="Create Team" />
        </p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/viewTeams.aspx">View Teams</asp:HyperLink>
    </form>
</body>
</html>
