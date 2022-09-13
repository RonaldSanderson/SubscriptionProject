using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace SubscriptionProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateAccountButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CreateAccount.aspx");
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}