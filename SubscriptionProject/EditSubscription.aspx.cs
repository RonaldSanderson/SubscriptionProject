using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SubscriptionProject
{
    public partial class EditSubscription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Only when the page firsts loads, hides the user message.
            if(!IsPostBack)
            {
                this.SuccessLabel.Visible = false;
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            FormView subscriptionFormView = this.SubscriptionFormView;
            TextBox subscriptionNameTextBox = (TextBox)subscriptionFormView.FindControl("SubscriptionNameTextBox");
            TextBox datePurchasedTextBox = (TextBox)subscriptionFormView.FindControl("PurchaseDateTextBox");
            DropDownList subscriptionTypeTextBox = (DropDownList)subscriptionFormView.FindControl("SubscriptionTypeDropDownList");
            TextBox subscriptionCostTextBox = (TextBox)subscriptionFormView.FindControl("SubscriptionCostTextBox");

            SessionService.SubscriptionName = subscriptionNameTextBox.Text;
            SessionService.DatePurchased = datePurchasedTextBox.Text;
            SessionService.SubscriptionType = subscriptionTypeTextBox.SelectedItem.Text;
            SessionService.SubscriptionCost = subscriptionCostTextBox.Text;

            this.ObjectDataSourceSubscription.Update();

            //Shows a message to a user
            this.SuccessLabel.Visible = true;
            Response.Redirect("~/SubscriptionList.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SubscriptionList.aspx");
        }
    }
}