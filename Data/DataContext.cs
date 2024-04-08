using Microsoft.EntityFrameworkCore;
using PetAdoptionProject.Components.Pages;
using PetAdoptionProject.Models;

namespace PetAdoptionProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        
        
            modelBuilder.Entity<ClientDB>().HasKey(c => c.ClientID);
            // Other configurations
            modelBuilder.Entity<ClientDB>().HasData(
                    new ClientDB { ClientID = 1, FisrtName = "Ani", LastName = "Gilavyan", ClientAddress = "Goris", AnimalID = 84 },
                    new ClientDB { ClientID = 2, FisrtName = "Artyom", LastName = "Gilavyan", ClientAddress = "Goris", AnimalID = 42 }
                    );

            modelBuilder.Entity<UserDB>().HasKey(c => c.UserID);
            // Other configurations
            modelBuilder.Entity<UserDB>().HasData(
                    new UserDB { UserID = 1, FisrtName = "Manush", LastName = "Atasunts", UserAddress = "Goris", AnimalID = 12 },
                    new UserDB { UserID = 2, FisrtName = "Arkadi", LastName = "Gilavyan", UserAddress = "Goris", AnimalID = 31 }
                    );

            modelBuilder.Entity<PetsDB>().HasKey(c => c.PetID);
            // Other configurations
            modelBuilder.Entity<PetsDB>().HasData(
                    new PetsDB { PetID = 1, PetName = "Rony", PetDescription = "Healthy", PetType = "Dog"},
                    new PetsDB { PetID = 2, PetName = "Boghar", PetDescription = "Healthy", PetType = "Dog"},
                    new PetsDB { PetID = 3, PetName = "August", PetDescription = "Needs medical care", PetType = "Dog" }
                    );
            modelBuilder.Entity<NourishmentDB>().HasKey(c => c.NourishID);
            // Other configurations
            modelBuilder.Entity<NourishmentDB>().HasData(
                    new NourishmentDB { NourishID = 1, Brand = "DogNour", NourishName = "MommyDoggy", Price = 100},
                    new NourishmentDB { NourishID = 2, Brand = "YumDog", NourishName = "DogSnack", Price = 200 },
                    new NourishmentDB { NourishID = 3, Brand = "PetYummas", NourishName = "Yummy", Price = 300 }
                    );
        }
        public DbSet<ClientDB> Clients { get; set; }
        public DbSet<UserDB> Users { get; set; }
        public DbSet<PetsDB> Pets { get; set; }
        public DbSet<NourishmentDB> Nourishments { get; set; }
    }
}
