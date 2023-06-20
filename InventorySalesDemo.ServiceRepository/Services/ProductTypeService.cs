using AutoMapper;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using InventorySalesDemo.Domain.Entities;
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

        public async void CreateProductType(ProductTypeDtoForCreation productType)
        {
            var ProductTypeEntity = _mapper.Map<ProductType>(productType);
            _repository.productTypeRepository.CreateProductType(ProductTypeEntity);
            await _repository.SaveAsync();
        }

        public async void DeleteProductType(int id, bool trackChanges)
        {
            var ProductTypeEntity = await _repository.productTypeRepository.GetProductTypeById(id, trackChanges);

            if (ProductTypeEntity != null)
            {
                _repository.productTypeRepository.DeleteProductType(ProductTypeEntity);
                await _repository.SaveAsync();
            }
        }

        public async Task<IEnumerable<ProductTypeDtoForDisplay>> GetAllProductTypeAsync(bool trackChanges)
        {
            var allProducts = await _repository.productTypeRepository.GetAllProductTypeAsync(trackChanges);
            var productsToReturn = _mapper.Map<IEnumerable<ProductTypeDtoForDisplay>>(allProducts);

            return productsToReturn;
        }

        public async Task<ProductTypeDtoForDisplay> GetProductTypeByIdAsync(int id, bool trackChanges)
        {
            var ProductTypeEntity = await _repository.productTypeRepository.GetProductTypeById(id, trackChanges);
            var productToReturn = _mapper.Map<ProductTypeDtoForDisplay>(ProductTypeEntity);

            return productToReturn;
        }

        public async void UpdateProductType(int id, ProductTypeDtoForUpdate productType, bool trackChanges)
        {
            var ProductType = await _repository.productTypeRepository.GetProductTypeById(id, trackChanges);
            _mapper.Map(productType, ProductType);
            
            await _repository.SaveAsync();

        }
    }
}
