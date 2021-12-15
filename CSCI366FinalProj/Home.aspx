<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CSCI366FinalProj.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            CSCI 366 Final Project</p>
        <p class="auto-style2">
            Created by Steven Eddy &amp; Alex Tjellesen</p>
        <p class="auto-style2">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Pokemon.aspx">Pokemon</asp:HyperLink>
&nbsp;|
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Move.aspx">Moves</asp:HyperLink>
&nbsp;|
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/TeamBuilder.aspx">Team Builder</asp:HyperLink>
        &nbsp;|
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/viewTeams.aspx">View Teams</asp:HyperLink>
&nbsp;|
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/TypeMatchup.aspx">Type Matchup</asp:HyperLink>
        </p>
    </form>
</body>
</html>
