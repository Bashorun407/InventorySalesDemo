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

        public async void CreateProductInSale(ProductInSaleDtoForCreation productInSale)
        {
            var ProductInSaleEntity = _mapper.Map<ProductInSale>(productInSale);
            _repository.productInSaleRepository.CreateProductInSale(ProductInSaleEntity);
            await _repository.SaveAsync();
        }

        public async void DeleteProductInSale(int id, bool trackChanges)
        {
            var productInSale = await _repository.productInSaleRepository.GetProductInSaleById(id, trackChanges);
            if (productInSale != null)
            {
                _repository.productInSaleRepository.DeleteProductInSale(productInSale);
                await _repository.SaveAsync();
            }

        }

        public async Task<IEnumerable<ProductInSaleDtoForDisplay>> GetAllProductInSaleAsync(bool trackChanges)
        {
            var productInSale = await _repository.productInSaleRepository.GetAllProductInSaleAsync(trackChanges);

            var productInSaleToReturn = _mapper.Map<IEnumerable<ProductInSaleDtoForDisplay>>(productInSale);

            return productInSaleToReturn;
        }

        public async Task<ProductInSaleDtoForDisplay> GetProductInSaleById(int id, bool trackChanges)
        {
            var productInSale = await _repository.productInSaleRepository.GetProductInSaleById(id, trackChanges);
            var productInsaleToReturn = _mapper.Map<ProductInSaleDtoForDisplay>(productInSale);

            return productInsaleToReturn;
        }

        public async void UpdateProductInSale(int id, ProductDtoForUpdate productInSale, bool trackChanges)
        {
            var ProductInSale = await _repository.productInSaleRepository.GetProductInSaleById(id, trackChanges);
            _mapper.Map(productInSale, ProductInSale);

           await _repository.SaveAsync();

        }
    }
}
