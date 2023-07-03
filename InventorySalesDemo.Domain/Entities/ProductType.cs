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
    public class ProductType : AuditableBaseEntity
    {
        [Required(ErrorMessage ="The product type name is required"), MaxLength(50)]
        public string? CategoryName { get; set; }

        [Required(ErrorMessage ="The product type description is required"), MaxLength (100)]
        public string? CategoryDescription { get; set; }

        //Has One to many mapping with Product table
        List<IEnumerable<Product>>? Products { get; set; }
    }
}
