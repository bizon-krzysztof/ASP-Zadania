using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAutofac.ViewModels
{
    public class CustomersViewModel
    {
        public int SelectedPage { get; set; }
        public int MaxPage { get; set; }
        public int ItemsPerPage { get; set; }
        public IEnumerable<Customers> DataOfCustomers { get; set; }
    }
}