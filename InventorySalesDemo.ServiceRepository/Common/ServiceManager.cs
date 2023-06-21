using AutoMapper;
using InventorySales.CoreServiceContract.Common;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.Contracts;
using InventorySalesDemo.ServiceContract.Interfaces;
using InventorySalesDemo.ServiceRepository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceRepository.Common
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IDailyInventoryLevelService> _dailyInventoService;
        private readonly Lazy<IProductInSaleService> _productInSaleService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IProductTypeService> _productTypeService;
        private readonly Lazy<ISaleService> _saleService;

        public ServiceManager(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _dailyInventoService = new Lazy<IDailyInventoryLevelService>(
                () => new DailyInventoryLevelService(repository, logger, mapper));

            _productInSaleService = new Lazy<IProductInSaleService>(
                ()=> new ProductInSaleService(repository, logger,mapper));

            _productService = new Lazy<IProductService>(
                () => new ProductService(repository, logger, mapper));

            _productTypeService = new Lazy<IProductTypeService>(
                () => new ProductTypeService(repository, logger, mapper));

            _saleService = new Lazy<ISaleService>(
                () => new  SaleService(repository, logger, mapper));
        }

        public IDailyInventoryLevelService DailyInventoryLevelService => _dailyInventoService.Value;
        public IProductInSaleService ProductInSaleService { get => _productInSaleService.Value; }
        public IProductService ProductService { get => _productService.Value; }
        public IProductTypeService ProductTypeService { get => _productTypeService.Value; }
        public ISaleService SaleService { get => _saleService.Value; }
    }
}
