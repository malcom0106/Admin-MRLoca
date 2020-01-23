using Admin_MRLoca.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_MRLoca
{
    public partial class AdminReservations : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DaoReservation daoReservation = new DaoReservation();
            this.lsvReservations.DataSource = daoReservation.GetReservations();
            this.lsvReservations.DataBind();
        }

        protected void lsvReservations_ItemDataBound(object sender, ListViewItemEventArgs e)
        {

        }

        protected void lsvReservations_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {

        }
    }
}