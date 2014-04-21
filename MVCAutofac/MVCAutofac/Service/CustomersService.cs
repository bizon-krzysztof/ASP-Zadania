using MVCAutofac.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MVCAutofac.Service
{
    public static class CustomersSortExtension
    {
        public static IQueryable<T> OrderByField<T>(this IQueryable<T> q, string sortField, bool ascending)
        {
            var param = Expression.Parameter(typeof(T), "p");
            var prop = Expression.Property(param, sortField);
            var exp = Expression.Lambda(prop, param);
            string method = ascending ? "OrderBy" : "OrderByDescending";
            Type[] types = new Type[] { q.ElementType, exp.Body.Type };
            var mce = Expression.Call(typeof(Queryable), method, types, q.Expression, exp);

            return q.Provider.CreateQuery<T>(mce);
        }
    }


    public class CustomersService
    {
        private readonly ICustomerRepository customerRepo;
        public CustomersService(ICustomerRepository customerRepo)
        {
            this.customerRepo = customerRepo;
        }


        public Tuple<List<Customers>, int> GetItemsOnPage(int itemsPerPage, int selectedPage, string parameter, bool ascending)
        {
            var result = customerRepo
                        .Query()
                        .OrderByField(parameter, ascending)
                        .Skip((selectedPage - 1) * itemsPerPage)
                        .Take(itemsPerPage)
                        .ToList();

            return Tuple.Create(result, (customerRepo.Query().Count() / itemsPerPage) + 1);
        }

        public List<Customers> GetAllItems()
        {
            return customerRepo.Query().ToList();
        }

        public List<string> GetColumnNames()
        {
            return typeof(Customers).GetProperties().Select(n => n.Name).ToList();
        }
    }
}