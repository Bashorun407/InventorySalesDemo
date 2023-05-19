using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Repository
{
    public interface IProductInSaleRepository
    {
        Task<ICollection<IProductInSaleRepository>> GetAllProductInSale();
        Task<IProductInSaleRepository> GetProductInSaleById(int id);
        void Add(IProductInSaleRepository productInSale);
        void Update(IProductInSaleRepository productInSale);
        void Delete(IProductInSaleRepository productInSale);
    }
}

