namespace NorthWind.Sales.BusinessObjects.ValueObjects
{
    public record struct OrderDatail(int ProductId, decimal UnitPrice, short Quantity);

}
