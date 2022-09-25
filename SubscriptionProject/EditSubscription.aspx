<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditSubscription.aspx.cs" Inherits="SubscriptionProject.EditSubscription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Subscription Tracker Application</h2>
    <br />
    <h2>Edit Subscription</h2>
    <br />
    <asp:FormView ID="SubscriptionFormView" runat="server" DataSourceID="ObjectDataSourceSubscription" DefaultMode="Edit">
        <EditItemTemplate>
            <table>
        <tr>
            <td style ="padding-right:20px;">
                Subscription Name:
                <br />
                <asp:TextBox ID="SubscriptionNameTextBox" runat="server" Text='<%# Bind("SubscriptionName") %>' CssClass="form-control input-lg"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldSubscriptionName" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="SubscriptionNameTextBox" ErrorMessage="<br />Subscription Name is required."></asp:RequiredFieldValidator>
            </td>
            <td>
                Purchase Date:
                <br />
                <asp:TextBox ID="PurchaseDateTextBox" runat="server" Text='<%# Bind("DatePurchased", "{0:MM/dd/yyyy}") %>' CssClass="form-control input-lg"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldPurchaseDate" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="PurchaseDateTextBox" ErrorMessage="<br />Purchase Date is required."></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorPurchaseDate" runat="server" Display="Dynamic" Type="Date" Operator="DataTypeCheck" CssClass="Required" ControlToValidate="PurchaseDateTextBox" ErrorMessage="<br />Please enter a valid date."></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style ="padding-right:20px;">
                Subscription Type:
                <br />
                <asp:DropDownList ID="SubscriptionTypeDropDownList" runat="server" Width ="180px" SelectedValue ='<%# Bind("SubscriptionType") %>' CssClass="form-control input-lg">
                    <asp:ListItem>Select Type:</asp:ListItem>
                    <asp:ListItem>Monthly</asp:ListItem>
                    <asp:ListItem>Yearly</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldSubscriptionType" runat="server" Display="Dynamic" InitialValue="Select Type:" CssClass="Required" ControlToValidate="SubscriptionTypeDropDownList" ErrorMessage="<br />Please select a Subscription Type."></asp:RequiredFieldValidator>
            </td>
            <td>
                Subscription Cost:
                <br />
                <asp:TextBox ID="SubscriptionCostTextBox" runat="server" Text='<%# Bind("SubscriptionCost") %>' CssClass="form-control input-lg"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldSubscriptionCost" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="SubscriptionCostTextBox" ErrorMessage="<br />Subscription Cost is required."></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorSubscriptionCost" runat="server" Display="Dynamic" Type="Double" Operator="DataTypeCheck" CssClass="Required" ControlToValidate="SubscriptionCostTextBox" ErrorMessage="<br />Please enter a valid cost."></asp:CompareValidator>
            </td>
        </tr>
    </table>
    <p>
        <br />
        <br />
        <asp:Button ID="SaveButton" runat="server" Text="Save Changes" OnClick="SaveButton_Click" CssClass="btn btn-primary"/>
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" CausesValidation="false" CssClass="btn btn-primary"/>
    </p>
        </EditItemTemplate>
    </asp:FormView>
    <br />
        <asp:Label ID="SuccessLabel" runat="server" CssClass="Correct" Visible="false"><br />Saved Successfully!</asp:Label>
        <asp:ObjectDataSource ID="ObjectDataSourceSubscription" runat="server" SelectMethod="GetSubscription" UpdateMethod="SaveSubscription" TypeName="SubscriptionProject.App_Code.SubscriptionTracker"></asp:ObjectDataSource>
</asp:Content>
