using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OnlineAppleStore.Class
{
    public class Connection
    {
        public static SqlConnection getcon()
        {
            SqlConnection con;
            string s = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con = new SqlConnection(s);
            con.Open();
            return con;
        }
    }
}