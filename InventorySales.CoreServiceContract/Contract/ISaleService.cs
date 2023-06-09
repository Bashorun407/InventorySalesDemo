using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.CoreServiceContract.Contract
{
    public interface ISaleService
    {
        Task CreateSale(SaleDtoForCreation sale);
        Task UpdateSale(SaleDtoForUpdate sale);
        Task DeleteSale(int saleId);
        Task<IEnumerable<SaleDtoForDisplay>> GetAllSale();
        Task<SaleDtoForDisplay> GetSaleById(int saleId);
    }
}
