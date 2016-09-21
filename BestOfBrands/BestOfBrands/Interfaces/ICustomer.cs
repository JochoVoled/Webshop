namespace BestOfBrands.Interfaces
{
    interface ICustomer
    {
        int ID { get; set; }
        void EditOrder(); // only its own orders
    }
}