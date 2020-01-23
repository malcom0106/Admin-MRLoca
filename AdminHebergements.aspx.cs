using Admin_MRLoca.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_MRLoca
{
    public partial class AdminHebergements : PageBase
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DaoHebergement daoHebergement = new DaoHebergement();
                this.lsvHebergement.DataSource = daoHebergement.GetHebergements();
                this.lsvHebergement.DataBind();
            }    
            
        }

        protected void btnDesactive_Click(object sender, EventArgs e)
        {
            int idHebergement = Convert.ToInt32(((Button)sender).CommandArgument);

            DaoHebergement daoHebergement = new DaoHebergement();
            daoHebergement.ChangeStatutHebergement(idHebergement);
            this.lsvHebergement.DataSource = daoHebergement.GetHebergements();
            this.lsvHebergement.DataBind();
        }        

        protected void lsvHebergement_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DaoHebergement daoHebergement = new DaoHebergement();
            this.DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);            
            this.lsvHebergement.DataSource = daoHebergement.GetHebergements();
            this.lsvHebergement.DataBind();
        }

        protected void lsvHebergement_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if(e.Item.ItemType == ListViewItemType.DataItem)
            {
                DataAccess dataAccess = new DataAccess();
                Label Statut = (Label)e.Item.FindControl("lblStatut");
                Button btnactive = (Button)e.Item.FindControl("btnActive");
                Hebergement hebergement1 = (Hebergement)e.Item.DataItem;
                
                
                //Find recherche uniquement l'Id
                Hebergement hebergement = dataAccess.mRLocaEntities.Hebergements.Find(hebergement1.IdHebergement);
                if (hebergement.Etat == true)
                {
                    Statut.CssClass = "btn btn-success";
                    Statut.Text = "<i class='fas fa-check'></i>";
                    btnactive.Text = "Activé";
                    btnactive.CssClass = "btn btn-warning";
                }
                else
                {
                    Statut.CssClass = "btn btn-danger";
                    Statut.Text = "<i class='fas fa-times'></i>";
                    btnactive.Text = "Désactivé";
                    btnactive.CssClass = "btn btn-danger";
                }
                
            }
        }
    }
}