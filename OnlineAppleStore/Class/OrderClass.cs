using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace OnlineAppleStore.Class
{
    public class OrderClass
    {
        SqlConnection con;

        public OrderClass()
        {
            con = Connection.getcon();
        }

        public string getOrderId(string userId, string addressId, int shippingCharge, double total)
        {
            string query = $"insert into Order_tbl(User_Id, Order_Date, Order_Status_Id, Address_Id, Shipping_Charge, Total) values({userId},GETDATE(),0,{addressId},{shippingCharge},{total});SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteScalar().ToString();
        }

        public void addOrderDetails(string orderId, string productId, string quantity, string price)
        {
            string query = $"insert into Order_Details_tbl(Order_Id,Product_Id,Quantity,Price) values({orderId},{productId},{quantity},{price.Replace(",","")})";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public DataSet getOrderDataSet()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Order_tbl", con);
            da.Fill(ds);
            return ds;
        }
    }
}