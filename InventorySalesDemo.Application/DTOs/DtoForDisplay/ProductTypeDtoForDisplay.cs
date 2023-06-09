using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForDisplay
{
    public class ProductTypeDtoForDisplay    
    {
        public string? Category_Name { get; set; }

        public string? Category_Description { get; set; }
    }
}
