using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SubscriptionProject
{
    public partial class SubscriptionList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EditButton_Command(object sender, CommandEventArgs e)
        {
            Panel selectedRow = (Panel)((Button)sender).Parent;
            Label subscriptionIDLabel = (Label)selectedRow.FindControl("SubscriptionIDLabel");
            int subscriptionID;

            if(Int32.TryParse(subscriptionIDLabel.Text, out subscriptionID))
            {
                SessionService.SubscriptionID = subscriptionID;

                switch(e.CommandArgument.ToString())
                {
                    case "EditSubscription":
                        Response.Redirect("~/EditSubscription.aspx");
                        break;
                    default:
                        break;
                }
            }
        }

        protected void AddSubscriptionButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddSubscription.aspx");
        }
    }
}