using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_MRLoca.Dao
{
    public class DaoClient : DataAccess
    {
        public DaoClient() : base()
        {

        }
        public List<Client> GetClients()
        {
            return mRLocaEntities.Clients.ToList();
        }
        public void ChangeStatutClient(int IdClient)
        {
            //Find recherche uniquement l'Id
            Client client = mRLocaEntities.Clients.Find(IdClient);

            //Ecriture en Lambda en dessous             
            //Hebergement hebergement = mRLocaEntities.Hebergements.Where(h => h.IdHebergement == idHebergement).First();
            //Where(H tel que H.IdHebergement est égal à idHebergement)

            client.StatutClient = !(client.StatutClient);
            mRLocaEntities.SaveChanges();
        }
    }
}