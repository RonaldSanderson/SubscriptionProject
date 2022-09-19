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

            SqlCommand command = new SqlCommand("SELECT SubscriptionID, SubscriptionName, DatePurchased, SubscriptionType, SubscriptionCost "
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

        public DataSet GetSubscription()
        {
            DataSet dataset = new DataSet();
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            string subscriptionConn = ConfigurationManager.ConnectionStrings["SubscriptionConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(subscriptionConn);

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT SubscriptionID, SubscriptionName, DatePurchased, SubscriptionType, SubscriptionCost "
                + "FROM dbo.Subscription "
                + "WHERE SubscriptionID = @SubscriptionID", connection);

            command.Parameters.AddWithValue("@SubscriptionID", SessionService.SubscriptionID);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataset, "Subscription");
            connection.Close();

            return dataset;
        }

        public DataSet SaveSubscription()
        {
            DataSet dataset = new DataSet();
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            string subscriptionConn = ConfigurationManager.ConnectionStrings["SubscriptionConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(subscriptionConn);

            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE dbo.Subscription "
                + "SET SubscriptionName = @SubscriptionName, DatePurchased = @DatePurchased, SubscriptionType = @SubscriptionType, SubscriptionCost = @SubscriptionCost "
                + "WHERE SubscriptionID = @SubscriptionID", connection);

            command.Parameters.AddWithValue("@SubscriptionID", SessionService.SubscriptionID);
            command.Parameters.AddWithValue("@SubscriptionName", SessionService.SubscriptionName);
            command.Parameters.AddWithValue("@DatePurchased", SessionService.DatePurchased);
            command.Parameters.AddWithValue("@SubscriptionType", SessionService.SubscriptionType);
            command.Parameters.AddWithValue("@SubscriptionCost", SessionService.SubscriptionCost);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataset, "Subscription");
            connection.Close();

            return dataset;
        }
    }
}