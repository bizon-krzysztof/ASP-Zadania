using MVCAutofac.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAutofac.Controllers
{
   // [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        private CustomersService customerRepo;
        public CustomerController(CustomersService customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        //[Route("{page:int}")]
        public IEnumerable<Customers> GetItemsOnPage(int page, int itemsPerPage, string parameter, bool ascending)
        {
            return customerRepo.GetItemsOnPage(itemsPerPage, page, parameter, ascending).Item1;
        }

        public int GetNumberOfAllItems()
        {
            return customerRepo.GetAllItems().Count;
        }

        public IEnumerable<string> GetColumnNames()
        {
            return customerRepo.GetColumnNames();
        }
    }
}
