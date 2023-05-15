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
    public class DailyInventoryLevel : AuditableBaseEntity
    {

        [Key]
        public DateTime Day_Date { get; set; }

        [Key]
        public int Product_Id { get; set; }

        [Required(ErrorMessage = "Data entry has to be text"),DataType(DataType.Text), MaxLength(20)]
        public string? Level { get; set;}

    }
}

