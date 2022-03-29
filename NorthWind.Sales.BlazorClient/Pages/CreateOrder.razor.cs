
namespace NorthWind.Sales.BlazorClient.Pages
{
    public partial class CreateOrder
    {
        ErrorBoundary ErrorBoundaryRef;
        CreateOrderDto Order = new CreateOrderDto
        {
            OrderDetails = new List<CreateOrderDetailDto>()
        };


        void Recover()
        {
            ErrorBoundaryRef?.Recover();
        }
    }
}
