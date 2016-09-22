namespace BestOfBrands.Interfaces
{
    interface ICounter
    {
        int CustomerNumber { get; set; }
        int OrderNumber { get; set; }
        int ProductNumber { get; set; }

        //konstruktorn kommer behöva plocka upp senast lagda
        //kund-, produkt- och ordernummer från databas

        int NewCustomerNumber();

        int NewProductNumber();

        int NewOrderNumber();
    }
}