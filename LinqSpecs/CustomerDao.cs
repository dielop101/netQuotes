using LinqSpecs.Core;
using System.Collections.Generic;
using System.Linq;

namespace LinqSpecsCore
{
    public class CustomerDao
    {
        private IEnumerable<Customer> _listOfCustomers = new List<Customer>()
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
            return _listOfCustomers.AsQueryable().Where(specification.ToExpression());
        }
        public int Count(Specification<Customer> specification)
        {
            return _listOfCustomers.AsQueryable().Count(specification.ToExpression());
        }

    }
}
