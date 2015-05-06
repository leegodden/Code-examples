using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Collections;

namespace Tests
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Httpcontect examples for authentication
            Response.Write("Username" + HttpContext.Current.User.Identity.Name + "<br>");
            Response.Write("Is Authenticated" + HttpContext.Current.User.Identity.IsAuthenticated + "<br>");
            Response.Write("Authentication type" + HttpContext.Current.User.Identity.AuthenticationType + "<br>");


            // Key value/pairs example
            List<KeyValuePair<string, string>> kvpList = new List<KeyValuePair<string, string>>()
            {
                 new KeyValuePair<string, string>("Key1", "Value1"),
                 new KeyValuePair<string, string>("Key2", "Value2"),
                 new KeyValuePair<string, string>("Key3", "Value3"),
            };

            kvpList.Insert(0, new KeyValuePair<string, string>("New Key 1", "New Value 1"));

            foreach (KeyValuePair<string, string> kvp in kvpList)
            {
                Response.Write(string.Format("Key: {0} Value: {1}", kvp.Key, kvp.Value + "<br>"));
            }

            // Dictionary example using string and int
            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);
            dict.Add("four", 4);

            // Retrieve value/pair
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Response.Write(pair.Key.ToString() + "  -  " + pair.Value.ToString() + "<br>");
            }
        
        }

        
    }
};