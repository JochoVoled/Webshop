namespace BestOfBrands.Interfaces
{
    public interface IOrderNumber
    {
        int number { get; set; }
        int NextNumber();
    }
}