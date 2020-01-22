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
                this.lsvHebergement.DataSource = mRLocaEntities.Hebergements.ToList();
                this.lsvHebergement.DataBind();
            }    
            
        }

        protected void btnDesactive_Click(object sender, EventArgs e)
        {
            int idHebergement = Convert.ToInt32(((Button)sender).CommandArgument);

            //Find recherche uniquement l'Id
            Hebergement hebergement = mRLocaEntities.Hebergements.Find(idHebergement);

            //Ecriture en Lambda en dessous             
            //Hebergement hebergement = mRLocaEntities.Hebergements.Where(h => h.IdHebergement == idHebergement).First();
            //Where(H tel que H.IdHebergement est égal à idHebergement)

            hebergement.Etat = !(hebergement.Etat);
            mRLocaEntities.SaveChanges();

            this.lsvHebergement.DataSource = mRLocaEntities.Hebergements.ToList();
            this.lsvHebergement.DataBind();
        }        

        protected void lsvHebergement_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            this.DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            MRLocaEntities mRLocaEntities = new MRLocaEntities();
            this.lsvHebergement.DataSource = mRLocaEntities.Hebergements.ToList();
            this.lsvHebergement.DataBind();
        }

        protected void lsvHebergement_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if(e.Item.ItemType == ListViewItemType.DataItem)
            {
                Label Statut = (Label)e.Item.FindControl("lblStatut");
                Button btnactive = (Button)e.Item.FindControl("btnActive");
                Hebergement hebergement1 = (Hebergement)e.Item.DataItem;
                //Find recherche uniquement l'Id
                Hebergement hebergement = mRLocaEntities.Hebergements.Find(hebergement1.IdHebergement);
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