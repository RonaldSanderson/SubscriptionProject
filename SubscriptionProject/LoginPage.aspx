<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SubscriptionProject.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
