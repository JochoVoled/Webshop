namespace BestOfBrands.Interfaces
{
    interface IPerson
    {
        string Username { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Adress { get; set; }
        string PhoneNumber { get; set; }

        bool LogIn();
        bool LogOut();
    }
}
