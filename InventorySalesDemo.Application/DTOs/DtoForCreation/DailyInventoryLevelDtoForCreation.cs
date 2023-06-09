using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForCreation
{
    public class DailyInventoryLevelDtoForCreation
    {
        [Key, Column(Order = 0)]
        [ForeignKey(nameof(RefCalendar))]
        public DateTime Day_Date { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey(nameof(Product))]
        public int Product_Id { get; set; }

        [Required(ErrorMessage = "Data entry has to be text"), DataType(DataType.Text), MaxLength(20), Column(Order = 2)]
        public int Level { get; set; }
    }
}
