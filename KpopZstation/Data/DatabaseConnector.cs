using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Data
{
    public class DatabaseConnector
    {
        private static DatabaseEntities DB = null;

        public static DatabaseEntities Connect()
        {
            if (DB == null)
            {
                DB = new DatabaseEntities();
            }

            return DB;
        }
    }
}