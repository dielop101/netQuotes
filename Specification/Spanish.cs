using DataAccess;

namespace Specification
{
    public class Spanish : ISpecification
    {
        public bool IsSatisfiedBy(Customer candidate)
        {
            return candidate.Country == "Spain";
        }
    }
}
