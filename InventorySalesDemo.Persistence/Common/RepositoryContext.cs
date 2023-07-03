using InventorySalesDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Persistence.Common
{
    public class RepositoryContext :DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //using the modelBuilder to override two PFs in a table
            modelBuilder.Entity<DailyInventoryLevel>()
                 .HasKey(x => new { x.Day_Date, x.Product_Id });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductInSale>()
                .HasKey(x => new {x.Sales_Id, x.Product_Id });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<DailyInventoryLevel> DailyInventoryLevels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInSale> ProductInSales { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<RefCalendar> RefCalendars { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
