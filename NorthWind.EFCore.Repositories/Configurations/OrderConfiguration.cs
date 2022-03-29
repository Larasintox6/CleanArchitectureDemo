namespace NorthWind.EFCore.Repositories.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.CustomerId).IsRequired().HasMaxLength(5).IsFixedLength();
            builder.Property(x => x.ShipAddress).IsRequired().HasMaxLength(60);
            builder.Property(x => x.ShipCity).HasMaxLength(15);
            builder.Property(x => x.ShipCountry).HasMaxLength(15);
            builder.Property(x => x.ShipPostalCode).HasMaxLength(10);
        }
    }
}
