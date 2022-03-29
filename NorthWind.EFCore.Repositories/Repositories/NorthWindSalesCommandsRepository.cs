namespace NorthWind.EFCore.Repositories.Repositories
{
    public class NorthWindSalesCommandsRepository : INorthWindSalesCommandsRepository
    {
        private readonly NorthWindSalesContext Context;

        public NorthWindSalesCommandsRepository(NorthWindSalesContext context)
        {
            this.Context = context;
        }

        public async ValueTask CrearOrder(OrderAggregate order)
        {
            await Context.AddAsync(order);
            foreach (var item in order.OrderDatails)
            {
                await Context.AddAsync(new OrderDetail
                {
                    Order = order,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,

                });
            }
        }

        public async ValueTask SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
