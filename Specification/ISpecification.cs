using DataAccess;

namespace Specification
{
    public interface ISpecification
    {
        bool IsSatisfiedBy(Customer candidate);
    }
}
