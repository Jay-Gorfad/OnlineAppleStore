using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace OnlineAppleStore.Class
{
    public class ProductAdd
    {
        SqlConnection con;
        DataSet ds;

        public string productId;
        public string name;
        public string price;
        public int discount;
        public string description;
        public string color;
        public string storage;
        public int quantity;
        public string image;

        public ProductAdd()
        {
            con = Connection.getcon();
        }

        public void addProduct(string mobileName, string price, int discount, string description, string color,string storage,int quantity, string img)
        {
            string query = "insert into Product_Details_tbl(Name, Price, Discount, Description, Color, Storage, Quantity, Image, Upload_Date) values('" + mobileName + "','" + price + "'," + discount + ",'" + description + "','" + color + "','" + storage + "', " + quantity + ",'" + img + "','" + DateTime.Now.ToLongDateString() + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public DataSet getProductDataSet()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Product_Details_tbl", con);
            da.Fill(ds);
            return ds;
        }

        public void deleteProduct(string productId)
        {
            string query = "delete from Product_Details_tbl where Mobile_Id=" + productId;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public void fetchProduct(int productId)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Name, Price, Discount, Description, Color, Storage, Quantity, Image from Product_Details_tbl where Mobile_Id=" + productId, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            this.productId = productId.ToString();
            name = ds.Tables[0].Rows[0][0].ToString();
            price = ds.Tables[0].Rows[0][1].ToString();
            discount = Convert.ToInt32(ds.Tables[0].Rows[0][2]);
            description = ds.Tables[0].Rows[0][3].ToString();
            color = ds.Tables[0].Rows[0][4].ToString();
            storage = ds.Tables[0].Rows[0][5].ToString();
            quantity = Convert.ToInt32(ds.Tables[0].Rows[0][6]);
            image = ds.Tables[0].Rows[0][7].ToString();
        }

        public void updateProduct()
        {
            SqlCommand cmd = new SqlCommand($"update Product_Details_tbl set Name='{name}', Price='{price}', Discount={discount}, Description='{description}', Color='{color}', Storage='{storage}', Quantity={quantity}, Image='{image}' where Mobile_Id="+productId, con);
            cmd.ExecuteNonQuery();
        }


        public DataSet getProductData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Product_Details_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}