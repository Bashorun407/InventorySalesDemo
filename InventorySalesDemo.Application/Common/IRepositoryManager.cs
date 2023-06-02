using InventorySalesDemo.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Common
{
    public interface IRepositoryManager
    {
        IDailyInventoryLevelRepository dailyInventoryLevelRepository { get; }
        IProductInSaleRepository productInSaleRepository { get; }
        IProductRepository productRepository { get; }
        IProductTypeRepository productTypeRepository { get; }
        IRefCalendarRepository refCalendarRepository { get; }
        ISaleRepository saleRepository { get; }
        Task SaveAsync();
        
    }
}
