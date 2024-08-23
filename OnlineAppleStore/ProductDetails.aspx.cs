using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineAppleStore.Class;

namespace OnlineAppleStore
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        ProductAdd obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new ProductAdd();
            if (!IsPostBack)
            {
                fillData();
            }
        }

        void fillData()
        {
            hfMobileId.Value = Request.QueryString["Mobile_Id"];
            string mobileId = Request.QueryString["Mobile_Id"];
            obj.fetchProduct(Convert.ToInt32(mobileId));
            lblName.Text = obj.name;
            lblColor.Text = obj.color;
            lblStorage.Text = obj.storage;
            lblDescription.Text = obj.description;
            lblPrice.Text = obj.price;
            imgMobile.ImageUrl = obj.image;
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Cart.aspx?Mobile_Id={hfMobileId.Value}&Quantity={quantity.Text}");
        }
    }
}