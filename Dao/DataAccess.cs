using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_MRLoca.Dao
{
    public class DataAccess
    {
        public MRLocaEntities mRLocaEntities { get; set; }
        public DataAccess()
        {
            try
            {
                mRLocaEntities = new MRLocaEntities();
            } 
            catch(Exception ex)
            {
                throw ex;
            }            
        }
        public void AddErreur(Exception ex)
        {
            try
            {
                LogSQL logSQL = new LogSQL();
                logSQL.DateInsert = DateTime.Now;
                logSQL.Error = ex.Message;
                mRLocaEntities.LogSQLs.Add(logSQL);
            }
            catch
            {
                string message = ex.Message;
            }
            
        }
    }
}