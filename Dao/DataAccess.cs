﻿using System;
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
    }
}