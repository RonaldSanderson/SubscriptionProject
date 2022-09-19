using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubscriptionProject
{
    public static class SessionService
    {
        public static Nullable<Int32> SubscriptionID
        {
            get
            {
                if (HttpContext.Current.Session["SubscriptionID"] != null)
                {
                    return (int)HttpContext.Current.Session["SubscriptionID"];
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

        public static string SubscriptionName
        {
            get
            {
                if (HttpContext.Current.Session["SubscriptionName"] != null)
                {
                    return (string)HttpContext.Current.Session["SubscriptionName"];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    HttpContext.Current.Session.Remove("SubscriptionName");
                }
                else
                {
                    HttpContext.Current.Session["SubscriptionName"] = value;
                }
            }
        }

        public static string DatePurchased
        {
            get
            {
                if (HttpContext.Current.Session["DatePurchased"] != null)
                {
                    return (string)HttpContext.Current.Session["DatePurchased"];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    HttpContext.Current.Session.Remove("DatePurchased");
                }
                else
                {
                    HttpContext.Current.Session["DatePurchased"] = value;
                }
            }
        }

        public static string SubscriptionType
        {
            get
            {
                if (HttpContext.Current.Session["SubscriptionType"] != null)
                {
                    return (string)HttpContext.Current.Session["SubscriptionType"];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    HttpContext.Current.Session.Remove("SubscriptionType");
                }
                else
                {
                    HttpContext.Current.Session["SubscriptionType"] = value;
                }
            }
        }

        public static string SubscriptionCost
        {
            get
            {
                if (HttpContext.Current.Session["SubscriptionCost"] != null)
                {
                    return (string)HttpContext.Current.Session["SubscriptionCost"];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    HttpContext.Current.Session.Remove("SubscriptionCost");
                }
                else
                {
                    HttpContext.Current.Session["SubscriptionCost"] = value;
                }
            }
        }
    }
}