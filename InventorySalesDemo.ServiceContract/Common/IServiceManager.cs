
using InventorySalesDemo.ServiceContract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.CoreServiceContract.Common
{
    public interface IServiceManager
    {
        public IDailyInventoryLevelService DailyInventoryLevelService { get; }
        public IProductInSaleService ProductInSaleService { get; }
        public IProductService ProductService { get; }
        public IProductTypeService ProductTypeService { get; }
        public ISaleService SaleService { get; }
    }
}
