using Microsoft.EntityFrameworkCore;
using RegisterAnimals.Entities;

namespace RegisterAnimals.Data
{
    public class AnimalDbContext : DbContext
    {
        DbSet<Animal> Animals => Set<Animal>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("AnimalDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasDiscriminator<string>("AnimalType")
                .HasValue<Lion>("lion")
                .HasValue<Elephant>("elephant");
        }

    }
}