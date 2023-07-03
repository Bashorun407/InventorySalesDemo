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
    public class ProductInSale : AuditableBaseEntity
    {
        [Key, Column(Order = 0)]
        [ForeignKey(nameof(Sale))]
        public int Sales_Id { get; set; } 

        [Key, Column(Order = 1)]
        [ForeignKey(nameof(Product))]
        public int Product_Id { get; set;}

        [Required(ErrorMessage ="Data entry has to be integer"), Column(Order = 2), Range(1, uint.MaxValue)]
        public int Quantity { get;set; }

    }

}
