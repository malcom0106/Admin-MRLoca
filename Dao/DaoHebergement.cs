using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_MRLoca.Dao
{
    public class DaoHebergement : DataAccess
    {
        public DaoHebergement() : base()
        {

        }
        public List<Hebergement> GetHebergements()
        {
            return mRLocaEntities.Hebergements.ToList();
        }
        public void ChangeStatutHebergement(int idHebergement)
        {
            //Find recherche uniquement l'Id
            Hebergement hebergement = mRLocaEntities.Hebergements.Find(idHebergement);

            //Ecriture en Lambda en dessous             
            //Hebergement hebergement = mRLocaEntities.Hebergements.Where(h => h.IdHebergement == idHebergement).First();
            //Where(H tel que H.IdHebergement est égal à idHebergement)

            hebergement.Etat = !(hebergement.Etat);
            mRLocaEntities.SaveChanges();
        }
    }
}