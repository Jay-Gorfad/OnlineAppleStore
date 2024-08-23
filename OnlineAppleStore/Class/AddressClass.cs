using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace OnlineAppleStore.Class
{
    public class AddressClass
    {
        SqlConnection con;

        public AddressClass()
        {
            con = Connection.getcon();
        }

        public string addAddress(string userId, string name, string email, string phone, string country, string state, string city, string pincode, string address)
        {
            string query = $"insert into Address_Details_tbl(User_Id, Name, Email, Phone, Country, State, City, Pincode, Address) values('{userId}','{name}','{email}','{phone}','{country}','{state}','{city}','{pincode}','{address}');SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteScalar().ToString();

        }
    }
}