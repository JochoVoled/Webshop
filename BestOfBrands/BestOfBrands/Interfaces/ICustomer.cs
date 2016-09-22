namespace BestOfBrands.Interfaces
{
    interface ICustomer
    {
        int ID { get; set; }
        bool EditOrder(); // only its own orders
    }
}