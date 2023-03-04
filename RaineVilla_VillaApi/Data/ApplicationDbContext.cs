using Microsoft.EntityFrameworkCore;
using RaineVilla_VillaApi.Models;
using System.Reflection.Emit;


namespace RaineVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
        public DbSet <Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean arcu velit, faucibus vel turpis in, convallis condimentum massa",
                    ImageUrl = "https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                    Occupancy = 5,
                    Rate = 200,
                    SquareFeet = 500,
                    Amenity = "Wifi",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Royal Villa",
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean arcu velit, faucibus vel turpis in, convallis condimentum massa",
                    ImageUrl = "https://images.unsplash.com/photo-1602002418082-a4443e081dd1?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=774&q=80",
                    Occupancy = 5,
                    Rate = 200,
                    SquareFeet = 500,
                    Amenity = "Wifi",
                    CreatedDate = DateTime.Now
                },
                 new Villa()
                 {
                     Id = 3,
                     Name = "Uvongo Villa",
                     Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean arcu velit, faucibus vel turpis in, convallis condimentum massa",
                     ImageUrl = "https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                     Occupancy = 5,
                     Rate = 200,
                     SquareFeet = 500,
                     Amenity = "Wifi",
                     CreatedDate = DateTime.Now
                 }, 
                 new Villa()
                 {
                     Id = 4,
                     Name = "Shelly Villa",
                     Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean arcu velit, faucibus vel turpis in, convallis condimentum massa",
                     ImageUrl = "https://images.unsplash.com/photo-1602002418211-9d76470fa71f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=774&q=80",
                     Occupancy = 5,
                     Rate = 200,
                     SquareFeet = 500,
                     Amenity = "Wifi",
                     CreatedDate = DateTime.Now
                 }, 
                 new Villa()
                 {
                     Id = 5,
                     Name = "Manaba Villa",
                     Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean arcu velit, faucibus vel turpis in, convallis condimentum massa",
                     ImageUrl = "https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                     Occupancy = 5,
                     Rate = 200,
                     SquareFeet = 500,
                     Amenity = "Wifi",
                     CreatedDate = DateTime.Now
                 });


        }
    }
}
