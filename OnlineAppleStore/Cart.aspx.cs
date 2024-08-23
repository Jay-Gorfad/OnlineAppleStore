using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineAppleStore.Class;

namespace OnlineAppleStore
{
    public partial class Cart : System.Web.UI.Page
    {
        CartClass obj;
        string userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new CartClass();

            string mobileId = Request.QueryString["Mobile_Id"];
            string quantity = Request.QueryString["Quantity"];
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            userId = Session["userId"].ToString();


            if (!IsPostBack)
            {
                fillGrid(); 
            }
            if (mobileId != null && quantity != null)
            {
                if (!obj.recordExits(userId, mobileId))
                {
                    obj.addToCart(Convert.ToInt32(mobileId), Convert.ToInt32(quantity), Convert.ToInt32(userId));
                    fillGrid();
                }
            }
        }

        void fillGrid()
        {
            DataSet ds = obj.getCartDataSet(Convert.ToInt32(userId));
            GridView1.DataSource = ds;
            GridView1.DataBind();
            setData(ds);
            ViewState["total"] = lblTotal.Text;
        }

        void setData(DataSet ds)
        {
            double subtotal = 0, shipping = 50, total;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                subtotal += Convert.ToDouble(ds.Tables[0].Rows[0]["Price"]);
            }
            lblTotal.Text = subtotal.ToString();
            lblShipping.Text = shipping.ToString();
            total = shipping + subtotal;
            lblOrderTotal.Text = total.ToString();
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            ViewState["total"] = lblTotal.Text;
            Response.Redirect("Checkout.aspx");
        }
    }
}