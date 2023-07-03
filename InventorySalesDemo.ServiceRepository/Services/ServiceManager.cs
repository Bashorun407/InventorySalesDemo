using AutoMapper;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.ServiceContract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceRepository.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IDailyInventoryLevelService> _dailyInventoryLevelService;
        private readonly Lazy<IProductInSaleService> _productInSaleService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IProductTypeService> _productTypeService;
        private readonly Lazy<ISaleService> _saleService;
        public ServiceManager(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _dailyInventoryLevelService = new Lazy<IDailyInventoryLevelService>(() => new DailyInventoryLevelService(repository, logger, mapper));
            _productInSaleService = new Lazy<IProductInSaleService>(() => new ProductInSaleService(repository, logger, mapper));
            _productService = new Lazy<IProductService>(() => new ProductService(repository, logger,mapper));
            _productTypeService = new Lazy<IProductTypeService>(() => new ProductTypeService(repository, logger, mapper));
            _saleService = new Lazy<ISaleService>(() => new SaleService(repository, logger, mapper));
        }
        public IDailyInventoryLevelService DailyInventoryLevelService => _dailyInventoryLevelService.Value; 

        public IProductInSaleService ProductInSaleService => _productInSaleService.Value;

        public IProductService ProductService => _productService.Value;

        public IProductTypeService ProductTypeService => _productTypeService.Value;

        public ISaleService SaleService => _saleService.Value;
    }
}
