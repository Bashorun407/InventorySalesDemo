using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceContract.Interfaces
{
    public interface ISaleService
    {
        Task<IEnumerable<SaleDtoForDisplay>> GetAllSalesAsync(bool trackChanges);
        Task<SaleDtoForDisplay> GetSaleByIdAsync(int id, bool trackChanges);
        void CreateSale(SaleDtoForCreation sale);
        void UpdateSale(int id, SaleDtoForUpdate sale, bool trackChanges);
        void DeleteSale(int id, bool trackChanges);
    }
}
