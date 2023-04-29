using Microsoft.EntityFrameworkCore;
using P2_2020ZA601_2020AA603_2020SC603.Models;

namespace Parcial_2_2023.Models
{
    public class covidDbContext: DbContext
    {
        public covidDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<departamentos> departamentos { get; set; } 
    }
}
