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
    public partial class AddSubscription : System.Web.UI.Page
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
            //Tells button to use Sql server
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            //Names the connection string and tells the button which connection string to use
            string SqlSubscriptionConnString = ConfigurationManager.ConnectionStrings["SubscriptionConnectionString"].ConnectionString;
            //Names and makes a new connection to the database
            SqlConnection newConn = new SqlConnection(SqlSubscriptionConnString);
            //Opens the new connection
            newConn.Open();
            //Creates the command for the insert statement
            SqlCommand commandSubscription = new SqlCommand("INSERT INTO dbo.Subscription (SubscriptionName, DatePurchased, SubscriptionType, SubscriptionCost) "
            + "VALUES (@SubscriptionName, @DatePurchased, @SubscriptionType, @SubscriptionCost)", newConn);
            //Inserting textbox value into the parameter: this is for security purposes to avoid SQL injection
            commandSubscription.Parameters.AddWithValue("@SubscriptionName", this.SubscriptionNameTextBox.Text);
            commandSubscription.Parameters.AddWithValue("@DatePurchased", this.PurchaseDateTextBox.Text);
            commandSubscription.Parameters.AddWithValue("@SubscriptionType", this.SubscriptionTypeTextBox.SelectedItem.Text);
            commandSubscription.Parameters.AddWithValue("@SubscriptionCost", this.SubscriptionCostTextBox.Text);
            //Creates the command adaptor
            SqlDataAdapter adapterSubscription = new SqlDataAdapter();
            //Sets up the insert command
            adapterSubscription.InsertCommand = commandSubscription;
            //Runs the insert command
            commandSubscription.ExecuteScalar();
            //Closes the connection when everything is done
            newConn.Close();
            //Shows a message to a user
            this.SuccessLabel.Visible = true;
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}