using System;
using System.Linq.Expressions;
using LinqSpecs.Core;

namespace LinqSpecsCore
{
    public class CustomerFromCountrySpec : Specification<Customer>
    {
        public string Country { get; set; }

        public CustomerFromCountrySpec(string country)
        {
            Country = country;
        }

        public override Expression<Func<Customer, bool>> ToExpression()
        {
            return c => c.Country == Country;
        }
    }
}
