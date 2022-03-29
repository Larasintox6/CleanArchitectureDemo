using NorthWind.Sales.BusinessObjects.Interfaces.Ports;
using NorthWind.Sales.UsesCases.CreateOrder;

namespace NorthWind.Sales.UsesCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateOrderInputPort, CreateOrderInteractor>();

            return services;
        }
    }
}
