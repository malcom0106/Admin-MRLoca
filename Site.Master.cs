using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_MRLoca
{
    public partial class SiteMaster : MasterPage
    {
        public string Nom { get; set; }
        public Admin Administrateur { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Admin"] == null)
            {
                this.btnDeconnection.Visible = false;
                
            }
            if(Administrateur != null)
            {
                this.lblNom.Text = Administrateur.NomAdmin;
            }
            

        }

        protected void btnDeconnection_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");
        }
    }
}