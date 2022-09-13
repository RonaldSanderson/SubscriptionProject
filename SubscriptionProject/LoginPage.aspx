﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" MasterPageFile="~/LoginMaster.Master" Inherits="SubscriptionProject.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>
            Login
        </h2>
        <asp:Label ID="UsernameLabel" runat="server" Text="Username:"></asp:Label>
        <br />
        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>
        <br />
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="LoginButton" runat="server" Text="Login"  OnClick="LoginButton_Click"/>
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="CreateAccountButton" runat="server" Text="Create Account"  OnClick="CreateAccountButton_Click"/>

        <asp:Label ID="StatusLabel" runat="server" CssClass="Required" Visible="false" />
    </div>
</asp:Content>
