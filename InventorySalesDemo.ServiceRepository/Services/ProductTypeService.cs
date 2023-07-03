using AutoMapper;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.Contracts;
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

        public async Task<ProductTypeForDisplayDto> CreateProductTypeAsync(ProductTypeForCreationDto productTypeForCreationDto)
        {
            var productTypeEntity = _mapper.Map<ProductType>(productTypeForCreationDto);

            _repository.ProductTypeRepository.AddProductType(productTypeEntity);
            await _repository.SaveAsync();

            var productTypeToReturn = _mapper.Map<ProductTypeForDisplayDto>(productTypeEntity);
            return productTypeToReturn;
        }

        public async Task DeleteProductTypeAsync(int Id, bool trackChanges)
        {
            var GetProductType = await _repository.ProductTypeRepository.GetProductTypeByIdAsync(Id, trackChanges);
            _repository.ProductTypeRepository.DeleteProductType(GetProductType);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ProductTypeForDisplayDto>> GetAllProductTypeAsync(bool trackChanges)
        {
            var GetProductTypeEntities = await _repository.ProductTypeRepository.GetAllProductTypeAsync(trackChanges);
            var productTypeEntities = _mapper.Map<IEnumerable<ProductTypeForDisplayDto>>(GetProductTypeEntities);
            return productTypeEntities;
        }

        public async Task<ProductTypeForDisplayDto> GetProductTypeAsync(int Id, bool trackChanges)
        {
            var GetProductType = await _repository.ProductTypeRepository.GetProductTypeByIdAsync(Id, trackChanges);
            var ProductTypeEntity = _mapper.Map<ProductTypeForDisplayDto>(GetProductType);
            return ProductTypeEntity;
        }

        public async Task UpdateProductTypeAsync(int Id, ProductTypeForUpdateDto productTypeForUpdateDto, bool trackChanges)
        {
            var GetProductTypeDetail = await _repository.ProductTypeRepository.GetProductTypeByIdAsync(Id, trackChanges);
            _mapper.Map(productTypeForUpdateDto, GetProductTypeDetail);
            await _repository.SaveAsync();
        }
    }
}
