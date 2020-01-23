using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_MRLoca.Dao
{
    public class DaoReservation : DataAccess
    {
        public DaoReservation() : base()
        {

        }
        public List<Reservation> GetReservations()
        {
            return mRLocaEntities.Reservations.ToList();
        }
        
    }
}