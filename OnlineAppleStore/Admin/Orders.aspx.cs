using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using OnlineAppleStore.Class;

namespace OnlineAppleStore.Admin
{
    public partial class Orders : System.Web.UI.Page
    {
        OrderClass obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new OrderClass();
            if (!IsPostBack)
                fillData();
        }

        void fillData()
        {
            GridView1.DataSource = obj.getOrderDataSet();
            GridView1.DataBind();
        }
    }
}