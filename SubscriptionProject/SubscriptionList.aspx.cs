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

        protected void ListGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "EditSubscription")
            {
                GridViewRow row = (GridViewRow)(((Button)e.CommandSource).NamingContainer);
                SessionService.SubscriptionID = row.FindControl("SubscriptionIDLabel").ToString();
                Response.Redirect("~/EditSubscription.aspx");
            }

        }

        //protected void EditButton_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("~/EditSubscription.aspx");
        //}
    }
}