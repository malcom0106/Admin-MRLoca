using Admin_MRLoca.Dao;
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
        List<Client> clients;
        protected void Page_Load(object sender, EventArgs e)
        {
            DaoClient daoClient = new DaoClient();
            clients = daoClient.GetClients();

            if (!IsPostBack)
            {                
                this.lsvClient.DataSource = clients;
                this.lsvClient.DataBind();
            }
        }

        protected void lsvClient_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Button btnactivation = (Button)e.Item.FindControl("btnActive");
            Client client = (Client)e.Item.DataItem;

            if ((bool)client.StatutClient)
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

            DaoClient daoClient = new DaoClient();
            this.lsvClient.DataSource = daoClient.GetClients();
            this.lsvClient.DataBind();
        }

        protected void btnActive_Click(object sender, EventArgs e)
        {            
            int idClient = Convert.ToInt32(((Button)sender).CommandArgument);
            
            DaoClient daoClient = new DaoClient();
            daoClient.ChangeStatutClient(idClient);
            this.lsvClient.DataSource = daoClient.GetClients();
            this.lsvClient.DataBind();
        }
    }
}