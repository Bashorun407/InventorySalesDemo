using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForUpdate
{
    public class ProductTypeDtoForUpdate
    {
        public int Id { get; set; }

        [DataType(DataType.Text), MaxLength(20)]
        [Required(ErrorMessage = "Category name is required.")]
        public string? Category_Name { get; set; }

        [DataType(DataType.Text), MaxLength(100)]
        [Required(ErrorMessage = "Category description is required")]
        public string? Category_Description { get; set; }
    }
}
