using Microsoft.EntityFrameworkCore;
using MyRestApi.Databse.Entities;

namespace MyRestApi.Databse
{
    public class PeopleDb : DbContext
    {
        public PeopleDb(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var personEntity= modelBuilder.Entity<PersonEntity>();
            personEntity.ToTable("Person");
            personEntity.Property(p=>p.FirstName).isRequired().HasMaxLength(250);
            personEntity.Property(p=>p.LastName).isRequired().HasMaxLength(250);
            personEntity.Property(p => p.PhoneNumber).IsRequired(false).HasMaxLength(12);
        }
    }
}