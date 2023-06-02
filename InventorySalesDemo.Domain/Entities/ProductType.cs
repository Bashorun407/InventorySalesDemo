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

        [DataType(DataType.Text), MaxLength(20)]
        [Required(ErrorMessage ="Category name is required.")]
        public string Category_Name { get; set; }

        [DataType(DataType.Text), MaxLength(100)]
        [Required(ErrorMessage ="Category description is required")]
        public string? Category_Description { get; set; }

        //Has One to many mapping with Product table
        List<IEnumerable<Product>>? Products { get; set; }

    }
}
