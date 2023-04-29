using Microsoft.EntityFrameworkCore;
namespace Parcial_2_2023.Models
{
    public class covidDbContext: DbContext
    {
        public covidDbContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
