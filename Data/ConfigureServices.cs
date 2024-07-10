using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data
{
    internal class ApplicationDbContext : DbContext
    {
        #region Tables
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Sales_DB;
                                        Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(eb => {
            eb.Property(b => b.Name).HasMaxLength(50).IsUnicode();
            });
            modelBuilder.Entity<Customers>(eb => { 
                eb.Property(b => b.Name).HasMaxLength(100).IsUnicode();
                eb.Property(b => b.Email).HasMaxLength(80).IsUnicode(false);
            });
            modelBuilder.Entity<Stores>(eb => { 
                eb.Property(b => b.Name).HasMaxLength(80).IsUnicode();
            });
            modelBuilder.Entity<Sales>(eb =>
            {
                /*
                 * so each time i insert a new row it will have the date 
                 * of the moment 
                 */
                eb.Property(b => b.Date).HasDefaultValueSql("GETDATE()");
            });
        }
    }
}