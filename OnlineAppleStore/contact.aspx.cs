using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineAppleStore.Class;

namespace OnlineAppleStore
{
    public partial class contact : System.Web.UI.Page
    {
        ResponsesClass obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new ResponsesClass();
        }

        protected void btnSubmitMessage_Click(object sender, EventArgs e)
        {
            obj.addResponsess(txttName.Text,txttEmail.Text,txttSubject.Text,txttPhoneNo.Text,txttMessage.Text);
            lblResponse.Text = "Record Submitted Successfully!";
            clearForm();
        }

        void clearForm()
        {
            txttName.Text = "";
            txttEmail.Text = "";
            txttSubject.Text = "";
            txttPhoneNo.Text = "";
            txttMessage.Text = "";
        }
    }
}