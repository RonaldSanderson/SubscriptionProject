<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSubscription.aspx.cs" Inherits="SubscriptionProject.AddSubscription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Subscription Tracker Application</h2>
    <br />
    <table>
        <tr>
            <td style ="padding-right:20px;">
                Subscription Name:
                <br />
                <asp:TextBox ID="SubscriptionNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                Purchase Date:
                <br />
                <asp:TextBox ID="PurchaseDateTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style ="padding-right:20px;">
                Subscription Type:
                <br />
                <asp:DropDownList ID="SubscriptionTypeTextBox" runat="server" Width ="180px">
                    <asp:ListItem>Select Type:</asp:ListItem>
                    <asp:ListItem>Monthly</asp:ListItem>
                    <asp:ListItem>Yearly</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                Subscription Cost:
                <br />
                <asp:TextBox ID="SubscriptionCostTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p>
        <br />
        <br />
        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
        <br />
        <asp:Label ID="SuccessLabel" runat="server" Visible="false">Saved Succesfully!</asp:Label>
    </p>
    
</asp:Content>
