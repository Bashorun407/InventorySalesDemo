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
    public class ProductDtoForDisplay
    {

        public int Product_Type_Code { get; set; }

        public string? Product_Name { get; set; }

        public double Product_Price { get; set; }
        
        public string? Product_Description { get; set; }

        public string? Product_Category { get; set; }

        public int Reorder_Quantity { get; set; }

    }
}
