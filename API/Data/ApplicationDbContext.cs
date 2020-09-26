using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    #pragma warning disable CS1591    // Missing XML comment for publicly visible type or number
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<NationalPark> NationalParks { get; set; }
    }
}