using InventorySalesDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Entities
{
    public class Sale : IBaseClass
    {
        [Key]
        public int Id { get; set; } //Sales_Id

        [Required(ErrorMessage ="Data entry should be in date time"), DataType("DateTime")]
        public DateTime Date_Of_Sales { get; set; }

        [Required (ErrorMessage ="Data entry should be numerals"), DataType("decimal")]
        public Decimal Total_Amount_Of_Sale { get; set; }

        //One to many relationship with ProductInSale table
        List<IEnumerable<ProductInSale>>? ProductInSale { get; set; }
    }
}
