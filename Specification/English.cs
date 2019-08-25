using DataAccess;

namespace Specification
{
    public class English : ISpecification
    {
        public bool IsSatisfiedBy(Customer candidate)
        {
            return candidate.Country == "England";
        }
    }
}
