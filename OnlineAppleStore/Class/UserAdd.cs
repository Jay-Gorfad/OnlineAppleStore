using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace OnlineAppleStore.Class
{
    public class UserAdd
    {
        SqlConnection con;

        public string userId;
        public string firstname;
        public string lastname;
        public string emaill;
        public string phoneno;
        public string password;
        public int userroleid;

        public UserAdd()
        {
            con = Connection.getcon();
        }

        public DataSet getUserDataSet()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from User_tbl", con);
            da.Fill(ds);
            return ds;
        }

        public void deleteUser(string userId)
        {
            string query = "delete from User_tbl where User_Id=" + userId;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public void fetchUser(int userId)
        {
            SqlDataAdapter da = new SqlDataAdapter("select First_Name, Last_Name, Email, Phone_No, Password, User_Role_Id from User_tbl where User_Id=" + userId, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            this.userId = userId.ToString();
            firstname = ds.Tables[0].Rows[0][0].ToString();
            lastname = ds.Tables[0].Rows[0][1].ToString();
            emaill = ds.Tables[0].Rows[0][2].ToString();
            phoneno = ds.Tables[0].Rows[0][3].ToString();
            password = ds.Tables[0].Rows[0][4].ToString();
            userroleid = Convert.ToInt32(ds.Tables[0].Rows[0][5].ToString());
        }

        public void updateUser(int userId)
        {
            SqlCommand cmd = new SqlCommand($"update User_tbl set First_Name='{firstname}', Last_Name='{lastname}', Email='{emaill}', Phone_No='{phoneno}', Password='{password}', User_Role_Id={userroleid} where User_Id=" + userId, con);
            cmd.ExecuteNonQuery();
        }

        public void addUser(string firstname, string lastname, string email, string phoneno, string password, int userroleid)
        {
            string query = "insert into User_tbl(First_Name, Last_Name, Email, Phone_No, Password, User_Role_Id) values('" + firstname + "','" + lastname + "','" + email + "','" + phoneno + "','" + password + "', " + userroleid + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
