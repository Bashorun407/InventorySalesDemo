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
    
    internal sealed class ProductTypeService : IProductTypeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductTypeService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public Task CreateProductType(ProductTypeDtoForCreation productType)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductType(int productTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductTypeDtoForDisplay>> GetAllProductType()
        {
            throw new NotImplementedException();
        }

        public Task<ProductTypeDtoForDisplay> GetProductTypeById(int productTypeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductType(ProductTypeDtoForUpdate productType)
        {
            throw new NotImplementedException();
        }
    }
}
