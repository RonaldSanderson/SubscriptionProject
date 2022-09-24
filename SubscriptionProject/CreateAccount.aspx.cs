using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
namespace SubscriptionProject
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateAccountButton_Click(object sender, EventArgs e)
        {
            //Tells button to use Sql server
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            //Names the connection string and tells the button which connection string to use
            string SqlSubscriptionConnString = ConfigurationManager.ConnectionStrings["SubscriptionConnectionString"].ConnectionString;
            //Names and makes a new connection to the database
            SqlConnection newConn = new SqlConnection(SqlSubscriptionConnString);
            //Opens the new connection
            newConn.Open();
            
            
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            IdentityUser user = new IdentityUser() { UserName = UserName.Text };
            IdentityResult result = manager.Create(user, Password.Text);

            if(result.Succeeded)
            {
                //Creates the command for the insert statement
                SqlCommand commandSubscription = new SqlCommand("INSERT INTO dbo.Users (FirstName, LastName, UserName, Email) "
                + "VALUES (@FirstName, @LastName, @UserName, @Email)", newConn);
                //Inserting textbox value into the parameter: this is for security purposes to avoid SQL injection
                commandSubscription.Parameters.AddWithValue("@FirstName", this.FirstNameTextBox.Text);
                commandSubscription.Parameters.AddWithValue("@LastName", this.LastNameTextBox.Text);
                commandSubscription.Parameters.AddWithValue("@UserName", this.UserName.Text);
                commandSubscription.Parameters.AddWithValue("@Email", this.EmailTextBox.Text);
                //Creates the command adaptor
                SqlDataAdapter adapterSubscription = new SqlDataAdapter();
                //Sets up the insert command
                adapterSubscription.InsertCommand = commandSubscription;
                //Runs the insert command
                commandSubscription.ExecuteScalar();
                //Closes the connection when everything is done
                newConn.Close();
                this.SuccessLabel.Visible = true;
                this.StatusLabel.Visible = false;
                SuccessLabel.Text = string.Format("User {0} was created successfully!", user.UserName);
                Response.Redirect("~/LoginPage.aspx");
            }
            else
            {
                this.StatusLabel.Visible = true;
                this.SuccessLabel.Visible = false;
                StatusLabel.Text = result.Errors.FirstOrDefault();
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LoginPage.aspx");
        }
    }
}