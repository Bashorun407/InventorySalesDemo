using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.Contracts;
using InventorySalesDemo.Persistence.Repositories;
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
        private readonly Lazy<ISaleRepository> _saleRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _dailyInventoryLevelRepository = new Lazy<IDailyInventoryLevelRepository>(() => new DailyInventoryLevelRepository(repositoryContext));
            _productInSaleRepository = new Lazy<IProductInSaleRepository>(() => new ProductInSaleRepository(repositoryContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
            _productTypeRepository = new Lazy<IProductTypeRepository>(() => new ProductTypeRepository(repositoryContext));
            _refCalendarRepository = new Lazy<IRefCalendarRepository>(() => new RefCalendarRepository(repositoryContext));
            _saleRepository = new Lazy<ISaleRepository>(() => new SaleRepository(repositoryContext));
        }
        public IDailyInventoryLevelRepository DailyInventoryLevelRepository => _dailyInventoryLevelRepository.Value;

        public IProductInSaleRepository ProductInSaleRepository => _productInSaleRepository.Value;

        public IProductRepository ProductRepository => _productRepository.Value;

        public IProductTypeRepository ProductTypeRepository => _productTypeRepository.Value;

        public IRefCalendarRepository RefCalendarRepository => _refCalendarRepository.Value;

        public ISaleRepository SaleRepository => _saleRepository.Value;

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
