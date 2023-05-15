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
    public class Product : IBaseClass
    {

        [Key]
        public int Id { get; set; } //Product_Id

        [ForeignKey(nameof(ProductInSale))]
        public int Product_Type_Code { get; set;}

        [Required(ErrorMessage ="Data entry should be in strings"), DataType("string"), MaxLength(20)]
        public string? Product_Name { get; set; }
        [Required(ErrorMessage = "Data entry should be in numerals"), DataType("decimal")]
        public Decimal Product_Price { get; set; }
        [MaxLength(50)]
        public string? Product_Description { get; set;}
        [Required (ErrorMessage ="Data entry should be in strings"),DataType("string") , MaxLength(50)]
        public string? Product_Category { get; set;}
        [Required(ErrorMessage ="Data entry should be in integers"), DataType("integer")]
        public int Reorder_Quantity { get;set; }

        //Has One to Many mapping with ProductInSale table
        List<IEnumerable<ProductInSale>>? productInSales { get; set; }

        //Has One to Many mapping with DailyInventoryLevel
        List<IEnumerable<DailyInventoryLevel>>? dailyInventoryLevel { get; set;}

    }
}
