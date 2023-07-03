using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Contracts
{
    public interface ISaleRepository
    {
        Task<IEnumerable<Sale>> GetAllSaleAsync(bool trackChanges);
        Task<Sale?> GetSaleByIdAsync(int Id, bool trackChanges);
        void AddSale(Sale sale);
        void DeleteSale(Sale sale);
    }
}
