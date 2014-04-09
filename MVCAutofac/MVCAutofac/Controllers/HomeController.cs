using MVCAutofac.Service;
using MVCAutofac.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAutofac.Controllers
{
    public class HomeController : Controller
    {
        private CustomersService customerRepo;
        public HomeController(CustomersService customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        public ActionResult Index(int page = 1)
        {
            var itemsPerPage = 10;
            var result = customerRepo.GetItemsOnPage(itemsPerPage, page);

            var customersVM = new CustomersViewModel
            {
                SelectedPage = page,
                MaxPage = result.Item2,
                ItemsPerPage = itemsPerPage,
                DataOfCustomers = result.Item1
            };

            return View(customersVM);
        }
	}
}