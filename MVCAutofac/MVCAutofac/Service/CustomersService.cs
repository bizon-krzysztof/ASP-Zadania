using MVCAutofac.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAutofac.Service
{
    public class CustomersService
    {
        private readonly ICustomerRepository customerRepo;
        public CustomersService(ICustomerRepository customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        public Tuple<List<Customers>, int> GetItemsOnPage(int itemsPerPage, int selectedPage)
        {
            var result = customerRepo
                        .Query()
                        .OrderBy(id => id.CustomerID)
                        .Skip((selectedPage - 1) * itemsPerPage)
                        .Take(itemsPerPage)
                        .ToList();

            return Tuple.Create(result, (customerRepo.Query().Count() / itemsPerPage) + 1);
        }
    }
}