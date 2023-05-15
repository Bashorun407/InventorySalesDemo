using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Entities
{
    public class DailyInventoryLevel
    {
        [Key]
        public DateTime Day_Date { get; set; }

        [Key]
        public int Product_Id { get; set; }

        [Required,DataType("string"), MaxLength(20)]
        public string? Level { get; set;}

    }
}

