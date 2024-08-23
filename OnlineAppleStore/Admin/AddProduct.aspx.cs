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
    public partial class AddProduct : System.Web.UI.Page
    {
        ProductAdd obj;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new ProductAdd();
            lblresponse.Visible = false;
            lblImageMessage.Visible = false;
            if (ViewState["Id"] == null)
            {
                ViewState["Id"] = 0;
            }
            else
            {
                int ID = (int)ViewState["Id"];
                ViewState["Id"] = ++ID;
            }
            id = (int)ViewState["Id"];
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            string imgExtension = Path.GetExtension(fldimg.FileName);
            if (imgExtension == ".jpg" || imgExtension == ".png" || imgExtension == ".jpeg")
            {
                string img = "../imgs/products/" + fldimg.FileName;
                Server.MapPath(img);
                string mobilename = txtMobileName.Text;
                string price = txtPrice.Text;
                int discount = Convert.ToInt32(txtDiscount.Text);
                string description = txtDescription.Text;
                string color = txtColor.Text;
                string storage = txtStorage.Text;
                int quantity = Convert.ToInt32(txtQuantity.Text);


                fldimg.SaveAs(Server.MapPath(img));
                obj.addProduct(mobilename, price, discount, description, color, storage, quantity, img);


                lblresponse.Text = "Product Added Successfully!";
                lblresponse.Visible = true;

                clearForm();
            }
            else
            {
                lblImageMessage.Text = "Please upload image";
                lblImageMessage.Visible = true;
            }
        }
        void clearForm()
        {
            txtMobileName.Text = "";
            txtPrice.Text = "";
            txtDiscount.Text = "";
            txtDescription.Text = "";
            txtColor.Text = "";
            txtStorage.Text = "";
            txtQuantity.Text = "";
        }
    }
}