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

        [Required(ErrorMessage = "Data entry has to be integer"), Column(Order = 2)]
        public int Level { get; set; }
    }
}
