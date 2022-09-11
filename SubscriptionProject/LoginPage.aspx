<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" MasterPageFile="~/LoginMaster.Master" Inherits="SubscriptionProject.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>
            Login
        </h2>
        <asp:Label ID="UsernameLabel" runat="server" Text="Username:"></asp:Label>
        <br />
        <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>
        <br />
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="LoginButton" runat="server" Text="Login" />
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="CreateAccountButton" runat="server" Text="Create Account" />
    </div>
</asp:Content>
