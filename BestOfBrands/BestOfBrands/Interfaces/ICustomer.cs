namespace BestOfBrands.Interfaces
{
    interface ICustomer
    {
        int ID { get; set; }

        //konstruktorn till Person ser ut såhär
        //Person(string address, string email, string name, string password, string phoneNumber, string username);

        bool EditOrder(); // only its own orders
    }
}