using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
  

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Scully", Species = "Dog", Age = 7 },
          new Animal { AnimalId = 2, Name = "Blaze", Species = "Dog", Age = 6 },
          new Animal { AnimalId = 3, Name = "Kitty", Species = "Cat", Age = 13 },
          new Animal { AnimalId = 4, Name = "Newt", Species = "Dog", Age = 1 },
          new Animal { AnimalId = 5, Name = "Ripley", Species = "Dog", Age = 4 },
          new Animal { AnimalId = 6, Name = "Kevin", Species = "Cat", Age = 14 },
          new Animal { AnimalId = 7, Name = "Tank", Species = "Dog", Age = 12 },
          new Animal { AnimalId = 8, Name = "Yuzu", Species = "Dog", Age = 1 },
          new Animal { AnimalId = 9, Name = "Tzufie", Species = "Dog", Age = 2 },
          new Animal { AnimalId = 10, Name = "Lou", Species = "Dog", Age = 9 }
        );
    }
  }
}