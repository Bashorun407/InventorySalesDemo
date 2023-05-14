using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }

        [ForeignKey(nameof(ProductInSale))]
        public int Product_Type_Code { get; set;}

        [Required, DataType("string"), MaxLength(20)]
        public string? Product_Name { get; set; }
        [Required, DataType("decimal")]
        public Decimal Product_Price { get; set; }
        [MaxLength(50)]
        public string? Product_Description { get; set;}
        [Required,DataType("string") , MaxLength(50)]
        public string? Product_Category { get; set;}
        [Required, DataType("integer")]
        public int Reorder_Quantity { get;set; }

        //Has One to Many mapping with ProductInSale table
        List<IEnumerable<ProductInSale>>? productInSales { get; set; }

        //Has One to Many mapping with DailyInventoryLevel
        List<IEnumerable<DailyInventoryLevel>>? dailyInventoryLevel { get; set;}

    }
}
