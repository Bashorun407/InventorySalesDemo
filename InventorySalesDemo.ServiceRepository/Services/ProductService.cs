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

        public async void CreateProduct(ProductDtoForCreation product)
        {
            var ProductEntity = _mapper.Map<Product>(product);
            _repository.productRepository.CreateProduct(ProductEntity);
            await _repository.SaveAsync();
        }

        public async void DeleteProduct(int id, bool trackChanges)
        {
            var Product = await _repository.productRepository.GetProductById(id, trackChanges);
            if (Product != null)
            {
                _repository.productRepository.DeleteProduct(Product);
                await _repository.SaveAsync();
            }
        }

        public async Task<IEnumerable<ProductDtoForDisplay>> GetAllProductsAsync(bool trackChanges)
        {
            var products = await _repository.productRepository.GetAllProductAsync(trackChanges);
            var productsToReturn = _mapper.Map<IEnumerable<ProductDtoForDisplay>>(products);

            return productsToReturn;
        }

        public  async Task<ProductDtoForDisplay> GetProductByIdAsync(int id, bool trackChanges)
        {
            var product = await _repository.productRepository.GetProductById(id, trackChanges);
            var productToReturn = _mapper.Map<ProductDtoForDisplay>(product);

            return productToReturn;
        }

        public async void UpdateProduct(int id, ProductDtoForUpdate product, bool trackChanges)
        {
            var Product = await _repository.productRepository.GetProductById(id, trackChanges);

            _mapper.Map(product, Product);

            await _repository.SaveAsync();
        }
    }
}
