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
    public partial class UpdateUser : System.Web.UI.Page
    {
        UserAdd obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new UserAdd();
            if (!IsPostBack)
                loadData();
        }

        void loadData()
        {
            int userId = Convert.ToInt32(Request.QueryString["userId"]);
            obj.fetchUser(userId);
            txxtFisrtName.Text = obj.firstname;
            txxtLastName.Text = obj.lastname;
            txxtEmail.Text = obj.emaill;
            txxtPhoneNo.Text = obj.phoneno;
            txxtPassword.Text = obj.password;
            txxtUserRoleId.Text = obj.userroleid.ToString();
        }

        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {
            obj.userId = hfUserId.Value;
            obj.firstname = txxtFisrtName.Text;
            obj.lastname = txxtLastName.Text;
            obj.emaill = txxtEmail.Text;
            obj.phoneno = txxtPhoneNo.Text;
            obj.password = txxtPassword.Text;
            obj.userroleid = Convert.ToInt32(txxtUserRoleId.Text);

            obj.updateUser(Convert.ToInt32(Request.QueryString["userId"]));

            Response.Redirect("UserDetails.aspx");
        }
    }
}