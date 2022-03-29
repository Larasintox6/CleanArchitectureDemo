namespace NorthWind.Sales.Controllers
{
    internal class CreateOrderController : ICreateOrderController
    {
        private readonly ICreateOrderInputPort InputPort;
        private readonly ICreateOrderPresenter Presenter;

        public CreateOrderController(ICreateOrderInputPort inputPort, ICreateOrderPresenter presenter)
        {
            this.InputPort = inputPort;
            this.Presenter = presenter;
        }

        public async ValueTask<int> CreateOrder(CreateOrderDto createOrder)
        {
            await InputPort.Handle(createOrder);
            return Presenter.OrderId;
        }
    }
}
