using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace WayfindingCasusB2C2.Models
{
    public class ConnectionStringClass:DbContext
    {
         public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options):base(options)
        {

        }

        public DbSet<Gebruiker> Gebruiker { get; set; }
    }
}
