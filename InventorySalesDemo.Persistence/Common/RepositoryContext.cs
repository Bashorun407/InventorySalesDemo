using InventorySalesDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Persistence.Common
{
    //Install EntityFrameworkCore to use 'DbContext' 
    public class RepositoryContext : DbContext
    {
        //Class constructor
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

        //This code helps override the Primary-Foreign key tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //For DailyInventoryLevel
            modelBuilder.Entity<DailyInventoryLevel>()
                .HasKey(x => new { x.Day_Date, x.Product_Id });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductInSale>()
                .HasKey(x => new {x.Sales_Id, x.Product_Id });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DailyInventoryLevel>  dailyInventoryLevels { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductInSale> productInSale { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
        public DbSet<RefCalendar> refCalendars { get; set; }
        public DbSet<Sale> sales { get; set; }
    }
}
