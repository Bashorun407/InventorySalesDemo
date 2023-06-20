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
    internal sealed class SaleService : ISaleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SaleService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async void CreateSale(SaleDtoForCreation sale)
        {
            var SalesEntity = _mapper.Map<Sale>(sale);
            _repository.saleRepository.CreateSale(SalesEntity);

            await _repository.SaveAsync();
        }

        public async void DeleteSale(int id, bool trackChanges)
        {
            var SaleEntity = await _repository.saleRepository.GetSaleById(id, trackChanges);

            if (SaleEntity != null)
            {
                _repository.saleRepository.DeleteSale(SaleEntity);
                await _repository.SaveAsync();
            }
        }

        public async Task<IEnumerable<SaleDtoForDisplay>> GetAllSalesAsync(bool trackChanges)
        {
            var SaleEntity = await _repository.saleRepository.GetAllSaleAsync(trackChanges);
            var saleToReturn = _mapper.Map<IEnumerable<SaleDtoForDisplay>>(SaleEntity);

            return saleToReturn;
        }

        public async Task<SaleDtoForDisplay> GetSaleByIdAsync(int id, bool trackChanges)
        {
            var SaleEntity = await _repository.saleRepository.GetSaleById(id, trackChanges);
            var saleToReturn = _mapper.Map<SaleDtoForDisplay>(SaleEntity);

            return saleToReturn;
        }

        public async void UpdateSale(int id, SaleDtoForUpdate sale, bool trackChanges)
        {
            var SaleGotten = await _repository.saleRepository.GetSaleById(id, trackChanges);
            _mapper.Map(sale, SaleGotten);
            await _repository.SaveAsync();
        }
    }
}
