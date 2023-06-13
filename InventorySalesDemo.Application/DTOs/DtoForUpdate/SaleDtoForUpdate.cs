using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForUpdate
{
    public class SaleDtoForUpdate
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Data entry should be in date time"), DataType(DataType.Date)]
        public DateTime Date_Of_Sales { get; set; }

        [Required(ErrorMessage = "Data entry should be numerals"), DataType(DataType.Currency)]
        public double Total_Amount_Of_Sale { get; set; }

    }
}
