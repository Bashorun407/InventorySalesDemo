using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForCreation
{
    public class ProductTypeForCreationDto
    {
        [Required(ErrorMessage = "The product type name is required"), MaxLength(50)]
        public string? CategoryName { get; set; }
        [Required(ErrorMessage = "The product type description is required"), MaxLength(100)]
        public string? CategoryDescription { get; set; }
    }
}
