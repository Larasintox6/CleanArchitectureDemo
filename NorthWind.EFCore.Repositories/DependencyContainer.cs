namespace NorthWind.EFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<NorthWindSalesContext>(o => o.UseSqlServer(configuration.GetConnectionString(connectionStringName)));
            services.AddScoped<INorthWindSalesCommandsRepository, NorthWindSalesCommandsRepository>();
            return services;

        }
    }
}
