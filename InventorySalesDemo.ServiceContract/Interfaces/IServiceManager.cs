using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceContract.Interfaces
{
    public interface IServiceManager
    {
        IDailyInventoryLevelService DailyInventoryLevelService { get; }
        IProductInSaleService ProductInSaleService { get; }
        IProductService ProductService { get; }
        IProductTypeService ProductTypeService { get; }
        ISaleService SaleService { get; }
    }
}
