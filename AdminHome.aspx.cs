using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_MRLoca
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin admin = (Admin)Session["Admin"];
            if(admin != null)
            {
                this.lblAdmin.Text = admin.Login + ' ' + admin.Password;
            }
        }
    }
}