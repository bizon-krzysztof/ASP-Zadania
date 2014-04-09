using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAutofac.Repository
{
    public class SQLCustomerRepo: ICustomerRepository
    {
        private northwindEntities db;

        public SQLCustomerRepo(northwindEntities db)
        {
            this.db = db;
        }

        public IQueryable<Customers> Query()
        {
            return db.Customers; 
        }
    }
}