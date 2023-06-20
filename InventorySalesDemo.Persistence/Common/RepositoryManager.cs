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
        }


        public IDailyInventoryLevelRepository dailyInventoryLevelRepository => _dailyInventoryLevelRepository.Value;

        public IProductInSaleRepository productInSaleRepository => _productInSaleRepository.Value;

        public IProductRepository productRepository => _productRepository.Value;

        public IProductTypeRepository productTypeRepository => _productTypeRepository.Value;

        public IRefCalendarRepository refCalendarRepository => _refCalendarRepository.Value;

        public ISaleRepository saleRepository => _saleRepository.Value;

        public async Task SaveAsync()
        {
           await _repositoryContext.SaveChangesAsync();
        }
    }
}
