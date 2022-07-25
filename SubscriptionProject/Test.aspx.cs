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
    public partial class Test : System.Web.UI.Page
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
            SqlCommand commandSubscription = new SqlCommand("INSERT INTO dbo.Subscription (SubscriptionName) "
            + "VALUES (@SubscriptionName)", newConn);
            //Inserting textbox value into the parameter: this is for security purposes to avoid SQL injection
            commandSubscription.Parameters.AddWithValue("@SubscriptionName", this.SubscriptionNameTextbox.Text);
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
    }
}