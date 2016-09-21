namespace BestOfBrands.Interfaces
{
    interface IOrderNumber
    {
        int number { get; set; }
        int NextNumber();
    }
}