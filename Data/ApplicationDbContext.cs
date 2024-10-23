using Microsoft.EntityFrameworkCore;
using Session7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7.Data
{
    internal class ApplicationDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =.;database = ASP_EF2;Trusted_Connection = True;TrustServerCertificate = True");
        }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
