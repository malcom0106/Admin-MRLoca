using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_MRLoca
{
    public partial class AdminClients : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                this.lsvClient.DataSource = mRLocaEntities.Clients.ToList();
                this.lsvClient.DataBind();
            }
        }

        protected void lsvClient_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            Button btnactivation = (Button)e.Item.FindControl("btnActive");
            Client client = (Client)e.Item.DataItem;
            Client MonClient = mRLocaEntities.Clients.Find(client.IdClient);
            if (MonClient.StatutClient == true)
            {
                btnactivation.CssClass = "btn btn-danger";
                btnactivation.Text = "Désactivé";
            }
            else
            {
                btnactivation.CssClass = "btn btn-primary";
                btnactivation.Text = "Réactivé";
            }

        }

        protected void lsvClient_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            this.dtpClients.SetPageProperties(e.StartRowIndex, e.MaximumRows,false);
            this.lsvClient.DataSource = mRLocaEntities.Clients.ToList();
            this.lsvClient.DataBind();
        }

        protected void btnActive_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(((Button)sender).CommandArgument);
            var client = mRLocaEntities.Clients.Find(idClient);
            client.StatutClient = !client.StatutClient;
            mRLocaEntities.SaveChanges();
            this.lsvClient.DataSource = mRLocaEntities.Clients.ToList();
            this.lsvClient.DataBind();
        }
    }
}