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
        IDailyInventoryLevelRepository DailyInventoryLevelRepository { get; }
        IProductInSaleRepository ProductInSaleRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductTypeRepository ProductTypeRepository { get; }
        IRefCalendarRepository RefCalendarRepository { get; }
        ISaleRepository SaleRepository { get; }
    }
}
