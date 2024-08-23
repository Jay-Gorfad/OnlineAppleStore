using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace OnlineAppleStore.Class
{
    public class CartClass
    {
        SqlConnection con;
        public CartClass()
        {
            con = Connection.getcon();
        }
         
        public DataSet getCartDataSet(int userId)
        {
            DataSet ds = new DataSet();
            string query = $"select p.Image, p.Name, p.Quantity, p.Price, p.Storage, p.Color,p.Mobile_Id from Product_Details_tbl as p inner join Cart_Details_tbl as c on p.Mobile_Id = c.Mobile_Id where c.User_Id={userId}";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            return ds;
        }

        public bool recordExits(string userId, string mobileId)
        {
            string query = $"select count(*) from Cart_Details_tbl where User_Id={userId} and Mobile_Id={mobileId}";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteScalar()!=null && cmd.ExecuteScalar().ToString() != "0")
                return true;
            else
                return false;
        }

        public void addToCart(int mobileId, int quantity, int userId)
        {
            string query = $"insert into Cart_Details_tbl values({mobileId},{quantity},{userId})";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public DataSet getDataSet(string userId)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select p.Mobile_Id, p.Name, p.Price from Product_Details_tbl as p right join Cart_Details_tbl as c on c.Mobile_Id = p.Mobile_Id where c.User_Id =" + userId, con);
            da.Fill(ds);
            return ds;
        }
    }
}