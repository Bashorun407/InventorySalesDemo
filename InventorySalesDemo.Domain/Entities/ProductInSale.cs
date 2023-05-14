using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Entities
{
    public class ProductInSale
    {
        [Key]
        public int Sales_Id { get; set; }

        [ForeignKey(nameof(Product))]  
        public int Product_Id { get; set;}

        [Required, DataType("integer")]
        public int Quantity { get;set; }

    }

}
