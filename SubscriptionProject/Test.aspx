<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="SubscriptionProject.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Subscription Tracker Application</h2>
    <br />
    <p>
        Subscription Name:
        <br />
        <asp:TextBox ID="SubscriptionNameTextbox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
        <br />
        <asp:Label ID="SuccessLabel" runat="server" Visible="false">Saved Succesfully!</asp:Label>
    </p>
    
</asp:Content>
