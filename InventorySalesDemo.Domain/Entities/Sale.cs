using InventorySalesDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Entities
{
    public class Sale : AuditableBaseEntity
    {
        [Required(ErrorMessage ="Data entry should be in date time"), DataType(DataType.Date)]
        public DateTime Date_Of_Sales { get; set; }

        [Required (ErrorMessage ="Data entry should be numerals"), DataType(DataType.Currency)]
        public double Total_Amount_Of_Sale { get; set; }

        //One to many relationship with ProductInSale table
        List<IEnumerable<ProductInSale>>? ProductInSales { get; set; }
    }
}
