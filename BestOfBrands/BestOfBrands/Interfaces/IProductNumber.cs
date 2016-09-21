namespace BestOfBrands.Interfaces
{
    interface IProductNumber
    {
        int number { get; set; }
        int NextNumber();
    }
}
