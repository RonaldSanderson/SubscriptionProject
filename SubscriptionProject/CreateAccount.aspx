<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="SubscriptionProject.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>
            Create Account
        </h2>
        <table>
            <tr>
                <td style="padding-right:10px;">
                    <asp:Label ID="FirstNameLabel" runat="server" Text="First Name:"></asp:Label>
                    <br />
                    <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="FirstNameTextBox" ErrorMessage="<br />First Name is required."></asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
                <td colspan="2">
                    <asp:Label ID="LastNameLabel" runat="server" Text="Last Name:"></asp:Label>
                    <br />
                    <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldLastName" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="LastNameTextBox" ErrorMessage="<br />Last Name is required."></asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="padding-right:10px;">
                    <asp:Label ID="UsernameLabel" runat="server" Text="Username:"></asp:Label>
                    <br />
                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldUserName" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="UserName" ErrorMessage="<br />Username is required."></asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
                <td style="padding-right:10px;">
                    <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>
                    <br />
                    <asp:TextBox ID="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="Password" ErrorMessage="<br />Password is required."></asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Confirm Password:"></asp:Label>
                    <br />
                    <asp:TextBox ID="ConfirmPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldConfirmPassword" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="ConfirmPassword" ErrorMessage="<br />Confirm Password is required."></asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="EmailLabel" runat="server" Text="Email:"></asp:Label>
                    <br />
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="100%" TextMode="Email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldEmail" runat="server" Display="Dynamic" CssClass="Required" ControlToValidate="EmailTextBox" ErrorMessage="<br />Email is required."></asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
        </table>
        
        <asp:Button ID="CreateAccountButton" runat="server" Text="Create Account" OnClick="CreateAccountButton_Click" />
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" CausesValidation="false"/>
        <br />
        <asp:Label ID="StatusLabel" runat="server" CssClass="Required" Visible="false"> 
        </asp:Label>
        <asp:Label ID="SuccessLabel" runat="server" CssClass="Correct" Visible="false">
        </asp:Label>
    </div>
</asp:Content>
