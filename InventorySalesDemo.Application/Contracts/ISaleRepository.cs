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
        Task<IEnumerable<Sale>> GetAllAsync(bool trackChanges);
        Task<Sale> GetSaleById(int Id, bool trackChanges);
        void CreateSale(Sale entity);
        void DeleteSale(Sale entity);
    }
}
