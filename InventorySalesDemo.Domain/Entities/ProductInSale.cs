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
    public class ProductInSale
    {
        [Key]
        public int Sales_Id { get; set; } //Sales_Id

        [Key]  
        public int Product_Id { get; set;}

        [Required(ErrorMessage ="Data entry has to be integer"), DataType("integer")]
        public int Quantity { get;set; }

    }

}
