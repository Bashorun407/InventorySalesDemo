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
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ProductForDisplayDto> CreateProductAsync(ProductForCreationDto productForCreationDto)
        {
            var productEntity = _mapper.Map<Product>(productForCreationDto);

            _repository.ProductRepository.AddProduct(productEntity);
            await _repository.SaveAsync();

            var productToReturn = _mapper.Map<ProductForDisplayDto>(productEntity);
            return productToReturn;
        }

        public async Task DeleteProductAsync(int Id, bool trackChanges)
        {
            var GetProduct = await _repository.ProductRepository.GetProductByIdAsync(Id, trackChanges);
            _repository.ProductRepository.DeleteProduct(GetProduct);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ProductForDisplayDto>> GetAllProductAsync(bool trackChanges)
        {
            var GetProductEntities = await _repository.ProductRepository.GetAllProductAsync(trackChanges);
            var productEntities = _mapper.Map<IEnumerable<ProductForDisplayDto>>(GetProductEntities);
            return productEntities;
        }

        public async Task<ProductForDisplayDto> GetProductByIdAsync(int Id, bool trackChanges)
        {
            var GetProduct = await _repository.ProductRepository.GetProductByIdAsync(Id, trackChanges);
            var ProductEntity = _mapper.Map<ProductForDisplayDto>(GetProduct);
            return ProductEntity;
        }

        public async Task UpdateProductAsync(int Id, ProductForUpdateDto productForUpdateDto, bool trackChanges)
        {
            var GetProductDetail = await _repository.ProductRepository.GetProductByIdAsync(Id, trackChanges);
            _mapper.Map(productForUpdateDto, GetProductDetail);
            await _repository.SaveAsync();
        }
    }
}
