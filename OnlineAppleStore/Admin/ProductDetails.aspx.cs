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
    public partial class ProductDetails : System.Web.UI.Page
    {
        ProductAdd obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.obj = new ProductAdd();
            if (!IsPostBack)
                fillData();
        }

        void fillData()
        {
            DataSet ds = obj.getProductDataSet();
            GridView1.DataSource = ds;
            GridView1.DataBind();   
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string productId = e.CommandArgument.ToString();
            if (e.CommandName.Equals("cmd_delete"))
            {
                obj.deleteProduct(productId);
                fillData();
            }
            else if (e.CommandName.Equals("cmd_update"))
            {
                Response.Redirect("UpdateProduct.aspx?productId=" + productId);
            }
        }
    }
}