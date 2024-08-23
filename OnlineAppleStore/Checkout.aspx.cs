using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineAppleStore.Class;
using System.Data;

namespace OnlineAppleStore
{
    public partial class Checkout : System.Web.UI.Page
    {
        AddressClass addressObj;
        string userId;
        double subtotal = 0, shipping = 50, total;
        CartClass cartObj;
        OrderClass orderObj;
        protected void Page_Load(object sender, EventArgs e)
        {
            addressObj = new AddressClass();
            cartObj = new CartClass();
            orderObj = new OrderClass();

            userId = Session["userId"].ToString();
            if (!IsPostBack)
            {
                lblShipping.Text = "50";
            }
            getData();
            fillData();
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string AddressId = addressObj.addAddress(userId,txtName.Text,txtEmail.Text,txtPhone.Text,txtCountry.Text,txtState.Text,txtCity.Text,txtPincode.Text,txtAddress.Text);
            string orderId = orderObj.getOrderId(userId, AddressId, Convert.ToInt32(shipping), total);

            DataSet ds = new DataSet();
            ds = cartObj.getCartDataSet(Convert.ToInt32(userId));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string productId = ds.Tables[0].Rows[0][6].ToString();
                string quantity = ds.Tables[0].Rows[0][2].ToString();
                string price = ds.Tables[0].Rows[0][3].ToString();
                orderObj.addOrderDetails(orderId, productId, quantity, price);
            }
            Response.Redirect("Confirm.aspx");
        }



        void getData()
        {
            DataSet ds = cartObj.getCartDataSet(Convert.ToInt32(Session["userId"].ToString()));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                subtotal += Convert.ToDouble(ds.Tables[0].Rows[0]["Price"]);
            }
        }

        void fillData()
        {
            lblShipping.Text = "50";
            lblSubtotal.Text = subtotal.ToString();
            total = subtotal + Convert.ToDouble(lblShipping.Text);
            lblTotal.Text = total.ToString();

            userId = Session["userId"].ToString();
            DataList1.DataSource = cartObj.getDataSet(userId);
            DataList1.DataBind();
        }

    }
}