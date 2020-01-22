using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_MRLoca
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValider_Click(object sender, EventArgs e)
        {
            string login = this.txtLogin.Text;
            string password = this.txtPassword.Text;
            if(!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                Admin admin = null;
                //On instencie le nouveau model de donnees ORM
                MRLocaEntities mRLocaEntities = new MRLocaEntities();

                //Requete LINQ
                var reqAdmin = from a in mRLocaEntities.Admins
                               where a.Login == login && a.Password == password
                               select a;
                // Verification du conteneur
                if(reqAdmin != null && reqAdmin.Count() > 0)
                {
                    // On recupere le premier element
                    admin = reqAdmin.First();
                }
                if(admin != null)
                {
                    Session["Admin"] = admin;
                    Response.Redirect("AdminHome.aspx");
                }
            }
        }
    }
}