namespace NorthWind.EFCore.Repositories.DataContexts
{
    //add-migration InitialCreate -p NorthWind.EFCore.Repositories -s NorthWind.EFCore.Repositories -context NorthWindContext
    //update-database -p NorthWind.EFCore.Repositories -s NorthWind.EFCore.Repositories -context NorthWindContext

    internal class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NortWindDB");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
