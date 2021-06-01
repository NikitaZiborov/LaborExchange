using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirmOFCustomers
{
    class ContextApp : DbContext
    {
        public DbSet<Customer> Customers { set; get; }
        public ContextApp()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Customers;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
    public class Customer
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string SurName { set; get; }
        public int Age { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Country { set; get; }
        public string City { set; get; }
        public string Address { set; get; }
    }
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(n => n.Name).IsRequired().HasMaxLength(15);
            builder.Property(s => s.SurName).IsRequired().HasMaxLength(20);
            builder.Property(a => a.Age).IsRequired().HasMaxLength(2);
            builder.Property(p => p.Phone).IsRequired().HasMaxLength(15);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(30);
            builder.Property(c => c.Country).IsRequired().HasMaxLength(30);
            builder.Property(c => c.City).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Address).IsRequired().HasMaxLength(40);
        }
    }
}
