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

        public async Task<ProductInSaleForDisplayDto> CreateProductInSaleAsync(ProductInSaleForCreationDto productInSaleForCreationDto)
        {
            var productInSaleEntity = _mapper.Map<ProductInSale>(productInSaleForCreationDto);

            _repository.ProductInSaleRepository.AddProductInSale(productInSaleEntity);
            await _repository.SaveAsync();

            var productInSaleToReturn = _mapper.Map<ProductInSaleForDisplayDto>(productInSaleEntity);
            return productInSaleToReturn;
        }

        public async Task DeleteProductInSaleAsync(int Id, bool trackChanges)
        {
            var GetProductInSale = await _repository.ProductInSaleRepository.GetProductInSaleByIdAsync(Id, trackChanges);
            _repository.ProductInSaleRepository.DeleteProductInSale(GetProductInSale);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ProductInSaleForDisplayDto>> GetAllProductInSaleAsync(bool trackChanges)
        {
            var GetProductInSalesEntities = await _repository.ProductInSaleRepository.GetAllProductInSaleAsync(trackChanges);
            var productInSaleEntities = _mapper.Map<IEnumerable<ProductInSaleForDisplayDto>>(GetProductInSalesEntities);
            return productInSaleEntities;
        }

        public async Task<ProductInSaleForDisplayDto> GetProductInSaleAsync(int Id, bool trackChanges)
        {
            var GetProductInSale = await _repository.ProductInSaleRepository.GetProductInSaleByIdAsync(Id, trackChanges);
            var ProductInSaleEntity = _mapper.Map<ProductInSaleForDisplayDto>(GetProductInSale);
            return ProductInSaleEntity;
        }

        public async Task UpdateProductInSaleAsync(int Id, ProductInSaleForUpdateDto productInSaleForUpdateDto, bool trackChanges)
        {
            var GetProductInSaleDetail = await _repository.ProductInSaleRepository.GetProductInSaleByIdAsync(Id, trackChanges);
            _mapper.Map(productInSaleForUpdateDto, GetProductInSaleDetail);
            await _repository.SaveAsync();
        }
    }
}
