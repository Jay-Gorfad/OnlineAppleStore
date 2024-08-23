using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using OnlineAppleStore.Class;

namespace OnlineAppleStore.Admin
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        ProductAdd obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new ProductAdd();
            if (!IsPostBack)
                loadData();
        }

        void loadData()
        {
            int productId = Convert.ToInt32(Request.QueryString["productId"]);
            obj.fetchProduct(productId);
            txtMobileName.Text = obj.name;
            txtPrice.Text = obj.price;
            txtDiscount.Text = obj.discount.ToString();
            txtDescription.Text = obj.description;
            txtColor.Text = obj.color;
            txtStorage.Text = obj.storage;
            txtQuantity.Text = obj.quantity.ToString();

            hfImage.Value = obj.image;
            hfProductId.Value = productId.ToString();
        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (fldimg.HasFile)
            {
                string imgExtension = Path.GetExtension(fldimg.FileName);
                if (imgExtension == ".jpg" || imgExtension == ".png" || imgExtension == ".jpeg")
                {
                    string img = "../imgs/products/" + fldimg.FileName;
                    fldimg.SaveAs(Server.MapPath(img));
                    obj.image = img;
                }
                else
                {
                    lblImageMessage.Text = "Please Upload Image Only";
                }
            }
            else
            {
                obj.image = hfImage.Value;
            }

            obj.productId = hfProductId.Value;
            obj.name = txtMobileName.Text;
            obj.price = txtPrice.Text;
            obj.discount = Convert.ToInt32(txtDiscount.Text);
            obj.description = txtDescription.Text;
            obj.color = txtColor.Text;
            obj.storage = txtStorage.Text;
            obj.quantity = Convert.ToInt32(txtQuantity.Text);

            obj.updateProduct();

            Response.Redirect("ProductDetails.aspx");
        }
    }
}