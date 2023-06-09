using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForDisplay
{
    public class DailyInventoryLevelDtoForDisplay
    {

        public DateTime Day_Date { get; set; }

        public int Product_Id { get; set; }

        public int Level { get; set; }
    }
}
