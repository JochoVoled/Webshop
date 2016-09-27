namespace BestOfBrands.Interfaces
{
    public interface IPerson
    {
        string Username { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }

        bool LogIn(string username, string password);
        bool LogOut();
    }
}
