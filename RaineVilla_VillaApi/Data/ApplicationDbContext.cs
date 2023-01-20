using Microsoft.EntityFrameworkCore;
using RaineVilla_VillaApi.Models;

namespace RaineVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public DbSet <Villa> Villas { get; set; }
    }
}
