using AutoMapper;
using InventorySales.CoreServiceContract.Contract;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceRepository.Services
{
    internal sealed class ProductInSaleService : IProductInSaleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductInSaleService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public Task CreateProductInSale(ProductDtoForCreation productDtoForCreation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductInSale(int productInSaleId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDtoForDisplay>> GetAllProductInSale()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDtoForUpdate> GetProductInSaleById(int productInSaleId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductInSale(ProductDtoForUpdate productDtoForUpdate, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
