using InventorySalesDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Entities
{
    public class Product : AuditableBaseEntity
    {

        [ForeignKey(nameof(ProductInSale))]
        public int Product_Type_Code { get; set;}

        [Required(ErrorMessage ="Data entry should be in strings"), DataType(DataType.Text), MaxLength(20)]
        public string? Product_Name { get; set; }
        [Required(ErrorMessage = "Data entry should be in numerals"), DataType(DataType.Currency)]
        public double Product_Price { get; set; }
        [MaxLength(50)]
        public string? Product_Description { get; set;}
        [Required (ErrorMessage ="Data entry should be in strings"),DataType(DataType.Text) , MaxLength(50)]
        public string? Product_Category { get; set;}
        [Required(ErrorMessage ="Data entry should be in integers"), Range(1, uint.MaxValue)]
        public int Reorder_Quantity { get;set; }

        //Has One to Many mapping with ProductInSale table
        List<IEnumerable<ProductInSale>>? productInSales { get; set; }

        //Has One to Many mapping with DailyInventoryLevel
        List<IEnumerable<DailyInventoryLevel>>? DailyInventoryLevel { get; set;}

    }
}
