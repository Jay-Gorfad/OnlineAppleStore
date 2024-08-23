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
    public partial class AddUser : System.Web.UI.Page
    {
        UserAdd obj;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new UserAdd();
            lblresponse.Visible = false;
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

        protected void btnnAddUser_Click(object sender, EventArgs e)
        {
            string firstname = txFirstName.Text;
            string lastname = txLastName.Text;
            string email = txEmail.Text;
            string phoneno = txPhoneNo.Text;
            string password = txPassword.Text;
            int userroleid = Convert.ToInt32(txUserRoleId.Text);

            obj.addUser(firstname, lastname, email, phoneno, password, userroleid);


            lblresponse.Text = "User Added Successfully!";
            lblresponse.Visible = true;

            clearForm();
        }

        void clearForm()
        {
            txFirstName.Text = "";
            txLastName.Text = "";
            txEmail.Text = "";
            txPhoneNo.Text = "";
            txPassword.Text = "";
            txUserRoleId.Text = "";
        }
    }
}