namespace NorthWind.Sales.UsesCases.CreateOrder
{
    internal class CreateOrderInteractor : ICreateOrderInputPort
    {
        private readonly INorthWindSalesCommandsRepository Repository;
        private readonly ICreateOrderOutputPort OutputPort;

        public CreateOrderInteractor(INorthWindSalesCommandsRepository repository, ICreateOrderOutputPort outputPort)
        {
            Repository = repository;
            OutputPort = outputPort;
        }


        public async ValueTask Handle(CreateOrderDto orderDto)
        {
            OrderAggregate orderAggregate = new OrderAggregate
            {
                CustomerId = orderDto.CustomerId,
                ShipAddress = orderDto.ShipAddress,
                ShipCity = orderDto.ShipCity,
                ShipCountry = orderDto.ShipCountry,
                ShipPostalCode = orderDto.ShipPostalCode
            };

            foreach (var item in orderDto.OrderDetails)
            {
                orderAggregate.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);
            }

            await Repository.CrearOrder(orderAggregate);
            await Repository.SaveChanges();


            await OutputPort.Handle(orderAggregate.Id);

        }
    }
}
