using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace OnlineAppleStore.Class
{
    public class ResponsesClass
    {
        SqlConnection con;  

        public ResponsesClass()
        {
            con = Connection.getcon();
        }

        public void addResponsess(string name, string email, string subject, string phone, string message)
        {
            SqlCommand cmd = new SqlCommand($"insert into Responses_tbl(Name, Email, Subject, Phone_No, Message) values('{name}','{email}','{subject}','{phone}','{message}')", con);
            cmd.ExecuteNonQuery();
        }

        public DataSet getResponseDataSet()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Responses_tbl", con);
            da.Fill(ds);
            return ds;
        }

        public void deleteResponsess(string responseId)
        {
            SqlCommand cmd = new SqlCommand("delete from Responses_tbl where Response_Id=" + responseId, con);
            cmd.ExecuteNonQuery();
        }
    }
}