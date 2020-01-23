using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_MRLoca.Dao
{
    public class DaoAvis : DataAccess
    {
        public DaoAvis() : base()
        {

        }
        public List<Avi> GetAvis()
        {
            return mRLocaEntities.Avis.ToList();
        }
    }
}