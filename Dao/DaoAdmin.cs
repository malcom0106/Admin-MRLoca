using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_MRLoca.Dao
{
    public class DaoAdmin : DataAccess
    {
        public DaoAdmin() : base()
        {

        }
        public Admin GetAdmin(string login, string password)
        {
            Admin admin = null;
            try
            {
                
                //On instencie le nouveau model de donnees ORM
                //MRLocaEntities mRLocaEntities = new MRLocaEntities();

                //Requete LINQ
                var reqAdmin = from a in mRLocaEntities.Admins
                               where a.Login == login && a.Password == password
                               select a;
                // Verification du conteneur
                if (reqAdmin != null && reqAdmin.Count() > 0)
                {
                    // On recupere le premier element
                    admin = reqAdmin.First();
                }
            } 
            catch(Exception ex)
            {
                throw ex;
            }
            
            return admin;
        }
    }
}