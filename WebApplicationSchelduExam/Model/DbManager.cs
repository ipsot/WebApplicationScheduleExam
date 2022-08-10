using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationSchelduExam.Model.Tables;

namespace WebApplicationSchelduExam.Model
{
    public class DbManager
    {
        public TableScheldue TableScheldue {get;}
        private static DbManager instance = null;
      
        private DbManager()
        {
             TableScheldue = new TableScheldue();
        }
        public static DbManager GetInstance()
        {
            if (instance==null)
            {
                instance = new DbManager();
            }
            return instance;
        }

    }
}