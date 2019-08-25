using DataAccess;
using LinqSpecsCore;
using Specification;
using System;

namespace netquotes
{
    class Program
    {
        private static readonly CustomerDao _customerDao = new CustomerDao();

        static void Main(string[] args)
        {
            UseLinqSpecsCore();
            UseSpecification();
        }

        private static void UseSpecification()
        {
            var spec1 = new Spanish();
            var spec2 = new English();

            var spanish = 0;
            var english = 0;
            foreach (var customer in _customerDao.ListOfCustomers)
            {
                if (spec1.IsSatisfiedBy(customer))
                    spanish++;
                else if (spec2.IsSatisfiedBy(customer))
                    english++;
            }

            Console.WriteLine($"Total english = {english} and total spanish = {spanish}");
        }

        private static void UseLinqSpecsCore()
        {
            CheckAndWriteCount("Spain");
            CheckAndWriteCount("France");
            CheckAndWriteCount("Portugal");
            CheckAndWriteCountList("Spain", "Portugal");
        }

        private static void CheckAndWriteCountList(string c1, string c2)
        {
            var customerFromCountrySpecC1 = new CustomerFromCountrySpec(c1);
            var customerFromCountrySpecC2 = new CustomerFromCountrySpec(c2);
            var customers = _customerDao.Count(customerFromCountrySpecC1 || customerFromCountrySpecC2);
            Console.WriteLine($"Total {c1} and {c2} = {customers}");
        }

        private static void CheckAndWriteCount(string country)
        {
            var customerFromCountrySpec = new CustomerFromCountrySpec(country);
            var customers = _customerDao.Count(customerFromCountrySpec);
            Console.WriteLine($"Total {country} = {customers}");
        }
    }
}
