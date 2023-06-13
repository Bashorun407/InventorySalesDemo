using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.DTOs.DtoForUpdate
{
    public class ProductInSaleDtoForUpdate
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Data entry has to be integer"), Column(Order = 2), Range(1, uint.MaxValue)]
        public int Quantity { get; set; }

    }
}
