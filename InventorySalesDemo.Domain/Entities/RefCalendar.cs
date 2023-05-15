using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Entities
{
    public class RefCalendar
    {
        [Key]
        public DateTime Day_Date { get; set; }

        //Has one to many mapping to DailyInventoryLevel table
        List<IEnumerable<DailyInventoryLevel>>? Days { get; set; }
    }
}
