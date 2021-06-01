using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagementVacanciesAndResume
{
    public class Vacancie
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Position { set; get; }
        public List<Resume> Resumes { set; get; }
    }
    public class Resume
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string SurName { set; get; }
        public int Age { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Position { set; get; }
        public string Skills { set; get; }
        public int VacanciesID { set; get; }
        public Vacancie Vacancies { set; get; }
    }
    public class ContextApp : DbContext
    {
        public DbSet<Vacancie> Vacancies { set; get; }
        public DbSet<Resume> Resumes { set; get; }
        public ContextApp()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ManagementVacanciesAndResume;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VacancieConfiguration());
            modelBuilder.ApplyConfiguration(new ResumeConfiguration());
        }
    }
    public class VacancieConfiguration : IEntityTypeConfiguration<Vacancie>
    {
        public void Configure(EntityTypeBuilder<Vacancie> builder)
        {
            builder.Property(n => n.Name).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Position).IsRequired().HasMaxLength(30);
        }
    }
    public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
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
