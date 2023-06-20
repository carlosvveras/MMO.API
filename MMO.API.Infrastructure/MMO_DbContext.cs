using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MMO.API.Core.Entities;

namespace MMO.API.Infrastructure
{
    public class MMO_DbContext : DbContext
    {
        public MMO_DbContext(DbContextOptions<MMO_DbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Shopbridge_Context"));
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Client>(c =>
        //    {
        //        c.HasKey(x => x.Id);
        //        c.Property(x => x.Name).IsRequired();
        //        c.Property(x => x.ContactName).IsRequired();
        //        c.Property(x => x.Address).IsRequired();
        //        c.Property(x => x.City).IsRequired();
        //        c.Property(x => x.StateProvince).IsRequired();
        //        c.Property(x => x.Country).IsRequired();
        //        c.Property(x => x.Name).IsRequired();
        //    });
        //}
    }
}
