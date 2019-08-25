using LinqSpecs.Core;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class CustomerDao
    {
        public IEnumerable<Customer> ListOfCustomers = new List<Customer>()
            {
                new Customer("Spain"),
                new Customer("England"),
                new Customer("France"),
                new Customer("France"),
                new Customer("France"),
                new Customer("Spain"),
                new Customer("France"),
                new Customer("Portugal")
            };

        public IEnumerable<Customer> FindAll(Specification<Customer> specification)
        {
            return ListOfCustomers.AsQueryable().Where(specification.ToExpression());
        }
        public int Count(Specification<Customer> specification)
        {
            return ListOfCustomers.AsQueryable().Count(specification.ToExpression());
        }

    }
}
