using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubscriptionProject
{
    public static class SessionService
    {
        public static string SubscriptionID
        {
            get
            {
                if (HttpContext.Current.Session["SubscriptionID"] != null)
                {
                    return (string)HttpContext.Current.Session["SubscriptionID"];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(value == null)
                {
                    HttpContext.Current.Session.Remove("SubscriptionID");
                }
                else
                {
                    HttpContext.Current.Session["SubscriptionID"] = value;
                }
            }
        }
    }
}