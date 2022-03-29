namespace NorthWind.Sales.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNortWindSalesControllers(this IServiceCollection services)
        {


            services.AddScoped<CreateOrderController>();
            services.AddScoped<ICreateOrderController>(p => p.GetService<CreateOrderController>());
            services.AddScoped<ICreateOrderController>(p => p.GetService<CreateOrderController>());
            return services;
        }
    }
}
