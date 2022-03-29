namespace NorthWind.Sales.BusinessObjects.Aggregates
{
    public class OrderAggregate : Order
    {
        readonly List<OrderDatail> OrderDatailsField = new List<OrderDatail>();
        public IReadOnlyCollection<OrderDatail> OrderDatails => OrderDatailsField;

        void AddDetail(OrderDatail orderDatail)
        {
            var ExistingOrderDetail = OrderDatailsField.FirstOrDefault(x => x.ProductId == orderDatail.ProductId);
            if (ExistingOrderDetail != default)
            {
                OrderDatailsField.Add(
                    ExistingOrderDetail with
                    {
                        Quantity = (short)(ExistingOrderDetail.Quantity + orderDatail.Quantity)
                    }
                    );
                OrderDatailsField.Remove(ExistingOrderDetail);
            }
            else
            {
                OrderDatailsField.Add(orderDatail);
            }

        }

        public void AddDetail(int productId, decimal unitPrices, short quantity) => AddDetail(new OrderDatail(productId, unitPrices, quantity));
    }
}
