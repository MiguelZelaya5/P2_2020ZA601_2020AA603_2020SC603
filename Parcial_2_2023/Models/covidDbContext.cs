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
        public DbSet<generos> generos { get; set; }

        public DbSet<casos_reportados> casos_reportados { get; set; } 

    }
}
