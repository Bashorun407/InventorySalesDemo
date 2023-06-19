using AutoMapper;
using InventorySales.CoreServiceContract.Contract;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using InventorySalesDemo.ServiceContract.Interfaces;
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

        public void CreateProductType(ProductTypeDtoForCreation productType)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductType(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductTypeDtoForDisplay>> GetAllProductTypeAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<ProductTypeDtoForDisplay> GetProductTypeByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductType(int id, ProductTypeDtoForUpdate productType)
        {
            throw new NotImplementedException();
        }
    }
}
