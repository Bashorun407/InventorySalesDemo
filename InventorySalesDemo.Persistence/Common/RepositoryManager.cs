using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Persistence.Common
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IDailyInventoryLevelRepository> _dailyInventoryLevelRepository;
        private readonly Lazy<IProductInSaleRepository> _productInSaleRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IProductTypeRepository> _productTypeRepository;
        private readonly Lazy<IRefCalendarRepository> _refCalendarRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _dailyInventoryLevelRepository = new Lazy<IDailyInventoryLevelRepository>(() => new DailyInventoryLevelRepository(repositoryContext));
        }


        public IDailyInventoryLevelRepository dailyInventoryLevelRepository => 

        public IProductInSaleRepository productInSaleRepository => throw new NotImplementedException();

        public IProductRepository productRepository => throw new NotImplementedException();

        public IProductTypeRepository productTypeRepository => throw new NotImplementedException();

        public IRefCalendarRepository refCalendarRepository => throw new NotImplementedException();

        public ISaleRepository saleRepository => throw new NotImplementedException();

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
