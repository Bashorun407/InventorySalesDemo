using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Entities
{
    public class ProductType
    {
        [Key]
        public int Product_Type_Code { get; set; }

        [ForeignKey(nameof(Product))]
        public int Parent_Product_Type_Code { get; set; }

        [DataType("string"), MaxLength(100)]
        public string? Product_Type_Description { get; set; }

        //Has One to many mapping with Product table
        List<IEnumerable<Product>>? Products { get; set; }

    }
}
