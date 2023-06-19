
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
        public IDailyInventoryLevelService DailyInventoryLevelService { get; set; }
        public IProductInSaleService ProductInSaleService { get; set; }
        public IProductService ProductService { get; set; }
        public IProductTypeService ProductTypeService { get; set; }
        public ISaleService SaleService { get; set; }
    }
}
