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
        Task<IEnumerable<SaleForDisplayDto>> GetAllSaleAsync(bool trackChanges);
        Task<SaleForDisplayDto> GetSaleAsync(int Id, bool trackChanges);
        Task<SaleForDisplayDto> CreateSaleAsync(SaleForCreationDto saleForCreationDto);
        Task UpdateSaleAsync(int Id, SaleForUpdateDto saleForUpdateDto, bool trackChanges);
        Task DeleteSaleAsync(int Id, bool trackChanges);
    }
}
