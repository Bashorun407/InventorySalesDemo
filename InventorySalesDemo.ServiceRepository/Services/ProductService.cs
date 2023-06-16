using AutoMapper;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
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

        public void CreateProduct(ProductDtoForCreation product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, ProductDtoForUpdate product)
        {
            throw new NotImplementedException();
        }
    }
}
