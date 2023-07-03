using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForUpdate
{
    public class DailyInventoryLevelForUpdateDto
    {

        [Required(ErrorMessage ="Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Data entry has to be text"), DataType(DataType.Text), MaxLength(20), Column(Order = 2)]
        public int Level { get; set; }
    }
}
