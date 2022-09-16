using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SubscriptionProject.App_Code
{
    public class SubscriptionTracker
    {
        public DataSet GetSubscriptions()
        {
            DataSet dataset = new DataSet();
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            string subscriptionConn = ConfigurationManager.ConnectionStrings["SubscriptionConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(subscriptionConn);

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT SubscriptionName, DatePurchased, SubscriptionType, SubscriptionCost "
                + "FROM dbo.Subscription "
                + "WHERE CreatedBy = @CreatedBy "
                + "ORDER BY SubscriptionName", connection);

            command.Parameters.AddWithValue("@CreatedBy", System.Web.HttpContext.Current.User.Identity.Name);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataset, "Subscriptions");
            connection.Close();

            return dataset;
        }
    }
}