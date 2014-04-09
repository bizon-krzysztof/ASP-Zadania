using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCAutofac.Repository
{
    public interface ICustomerRepository
    {
        IQueryable<Customers> Query();
    }
}
