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
    public class ProductForCreationDto
    {
        [Required(ErrorMessage = "Data entry should be in strings"), DataType(DataType.Text), MaxLength(20)]
        public string? Product_Name { get; set; }
        [Required(ErrorMessage = "Data entry should be in numerals"), DataType(DataType.Currency)]
        public double Product_Price { get; set; }
        [Required(ErrorMessage = "Data entry should be in strings"), MaxLength(50)]
        public string? Product_Description { get; set; }
        [Required(ErrorMessage = "Data entry should be in strings"), DataType(DataType.Text), MaxLength(50)]
        public string? Product_Category { get; set; }
        [Required(ErrorMessage = "Data entry should be in integers"), Range(1, uint.MaxValue)]
        public int Reorder_Quantity { get; set; }
    }
}
