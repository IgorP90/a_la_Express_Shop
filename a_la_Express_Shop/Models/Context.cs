using a_la_Express_Shop.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a_la_Express_Shop.Models
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
        }*/

        public Context(DbContextOptions<Context> option) : base(option)
        {}

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("varchar(100000)");
                entity.Property(e => e.Name).HasColumnType("varchar(100000)");
                entity.Property(e => e.Description).HasColumnType("varchar(100000)");
                entity.Property(e => e.Price).HasColumnType("varchar(100000)");
            });
        }*/

      
    }
}
