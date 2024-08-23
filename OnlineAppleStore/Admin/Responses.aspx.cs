using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineAppleStore.Class;

namespace OnlineAppleStore.Admin
{
    public partial class Responses : System.Web.UI.Page
    {
        ResponsesClass obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new ResponsesClass();
            if (!IsPostBack)
                fillData();
        }

        void fillData()
        {
            GridView1.DataSource = obj.getResponseDataSet();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("cmd_delete"))
            {
                obj.deleteResponsess(e.CommandArgument.ToString());
                fillData();
            }
        }
    }
}