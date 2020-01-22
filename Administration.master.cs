using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_MRLoca
{
    public partial class Administration : System.Web.UI.MasterPage
    {
        public Admin Administrateur { get; set; }
        protected void Page_Init(object sender, EventArgs e)
        {
            Admin admin = (Admin)Session["Admin"];
            if (admin != null)
            {
                Administrateur = admin;
            }
            else
            {
                Response.Redirect("default.aspx");
            }
        }
    }
}