using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Repository
{
    public interface ISaleRepository
    {
        Task<ICollection<Sale>> GetAllSale();
        Task<Sale> GetSaleById(int id);
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);

    }
}
