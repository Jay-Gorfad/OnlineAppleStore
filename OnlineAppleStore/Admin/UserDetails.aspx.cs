using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineAppleStore.Class;

namespace OnlineAppleStore.Admin
{
    public partial class UserDetails : System.Web.UI.Page
    {
        UserAdd obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.obj = new UserAdd();
            if (!IsPostBack)
                fillData();
        }

        void fillData()
        {
            DataSet ds = obj.getUserDataSet();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string userId = e.CommandArgument.ToString();
            if (e.CommandName.Equals("cmd_delete"))
            {
                obj.deleteUser(userId);
                fillData();
            }
            else if (e.CommandName.Equals("cmd_update"))
            {
                Response.Redirect("UpdateUser.aspx?userId=" + userId);
            }
        }
    }
}