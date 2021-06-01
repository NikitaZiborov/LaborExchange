using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UnemploymentManagement
{
    public class ContextApp : DbContext
    {
        public DbSet<WorkLess> WorkLesses { set; get; }
        public ContextApp()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=UnemploymentManagement;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkLessConfiguration());
        }
    }
    public class WorkLess
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string SurName { set; get; }
        public int Age { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Position { set; get; }
        public string Skills { set; get; }
    }
    public class WorkLessConfiguration : IEntityTypeConfiguration<WorkLess>
    {
        public void Configure(EntityTypeBuilder<WorkLess> builder)
        {
            builder.Property(n => n.Name).IsRequired().HasMaxLength(15);
            builder.Property(s => s.SurName).IsRequired().HasMaxLength(20);
            builder.Property(a => a.Age).IsRequired().HasMaxLength(2);
            builder.Property(p => p.Phone).IsRequired().HasMaxLength(15);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Position).IsRequired().HasMaxLength(25);
            builder.Property(s => s.Skills).IsRequired().HasMaxLength(25);
        }
    }
}
