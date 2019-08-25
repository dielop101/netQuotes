namespace LinqSpecsCore
{
    public class Customer
    {
        public string Country { get; private set; }

        public Customer(string country)
        {
            Country = country;
        }
    }
}
