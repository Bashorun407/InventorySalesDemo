using InventorySalesDemo.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Common
{
    public interface IRepositoryManager
    {
        public IDailyInventoryLevelRepository idailyInventoryLevelRepository {  get; }
        public IProductInSaleRepository iproductInSaleRepository { get; }
        public IProductRepository iproductRepository { get; }
        public IProductTypeRepository iproductTypeRepository { get; }
        public IRefCalendarRepository irefCalendarRepository { get; }
        public ISaleRepository isaleRepository { get; }
    }
}
