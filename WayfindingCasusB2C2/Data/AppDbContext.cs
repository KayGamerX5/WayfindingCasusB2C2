using Microsoft.EntityFrameworkCore;
using WayfindingCasusB2C2.Models;
using Route = WayfindingCasusB2C2.Models.Route;

namespace WayfindingCasusB2C2.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> contextOptions)
            : base(contextOptions)  
        {

        }

        public DbSet<Plattegrond> Plattegronden { get; set; }
        public DbSet<Bedrijf> Bedrijven { get; set; }
        public DbSet<BedrijfDetail> BedrijfDetails { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Legenda> Legendas { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Ruimte> Ruimtes { get; set; }


    }
}
