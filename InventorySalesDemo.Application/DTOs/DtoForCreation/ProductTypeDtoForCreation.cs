using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForCreation
{
    public class ProductTypeDtoForCreation
    {
        [DataType(DataType.Text), MaxLength(20)]
        [Required(ErrorMessage = "Category name is required.")]
        public string? Category_Name { get; set; }

        [DataType(DataType.Text), MaxLength(100)]
        [Required(ErrorMessage = "Category description is required")]
        public string? Category_Description { get; set; }

    }
}
