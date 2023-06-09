using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForDisplay
{
    public class SaleDtoForDisplay
    {
        public DateTime Date_Of_Sales { get; set; }

        public double Total_Amount_Of_Sale { get; set; }

    }
}
