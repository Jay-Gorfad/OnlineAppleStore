using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineAppleStore.Class;

namespace OnlineAppleStore
{
    public partial class index : System.Web.UI.Page
    {
        ProductAdd obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new ProductAdd();
            if (!IsPostBack)
            {
                fillDataList();
            }
        }

        void fillDataList()
        {
            DataList1.DataSource = obj.getProductData();
            DataList1.DataBind();
        }
    }
}