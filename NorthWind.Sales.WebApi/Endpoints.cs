using NorthWind.Sales.BusinessObjects.DTOs.CreateOrder;
using NorthWind.Sales.BusinessObjects.Interfaces.Controllers;

namespace NorthWind.Sales.WebApi
{
    public static class Endpoints
    {
        public static WebApplication UseNorthWindSalesEndpoints(
        this WebApplication app)
        {
            app.MapPost("/create",
            async (CreateOrderDto order,
            ICreateOrderController controller) =>
            Results.Ok(await controller.CreateOrder(order)));
            return app;
        }
    }

}
