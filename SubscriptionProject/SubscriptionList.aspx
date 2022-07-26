﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubscriptionList.aspx.cs" Inherits="SubscriptionProject.SubscriptionList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Subscription List</h2>
    <br />
    <asp:Button ID="AddSubscriptionButton" runat="server" Text="Add Subscription" OnClick="AddSubscriptionButton_Click" CssClass="btn btn-primary"/>
    <br />
    <asp:GridView ID="ListGrid" runat="server" EmptyDataText="No Subscriptions to Display" DataSourceID="ObjectDataSourceSubscriptions" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:Button ID="EditButton" runat="server" Text="Edit" CommandArgument ="EditSubscription" OnCommand="EditButton_Command" CssClass="btn btn-primary"/>
                    </asp:Panel>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("SubscriptionName") %>'></asp:Label>
                    <asp:Label ID="SubscriptionIDLabel" runat="server" Text='<%# Eval("SubscriptionID") %>' Visible="false"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Purchase Date">
                <ItemTemplate>
                    <asp:Label ID="PurchaseDateLabel" runat="server" Text='<%# Eval("DatePurchased", "{0:MM/dd/yyyy}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Subscription Type">
                <ItemTemplate>
                    <asp:Label ID="SubscriptionTypeLabel" runat="server" Text='<%# Eval("SubscriptionType") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cost">
                <ItemTemplate>
                    <asp:Label ID="CostLabel" runat="server" Text='<%# Eval("SubscriptionCost") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSourceSubscriptions" runat="server" SelectMethod="GetSubscriptions" TypeName="SubscriptionProject.App_Code.SubscriptionTracker"></asp:ObjectDataSource>
</asp:Content>
