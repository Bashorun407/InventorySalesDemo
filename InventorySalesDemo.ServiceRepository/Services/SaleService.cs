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
    internal class SaleService : ISaleService
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

        public async Task<SaleForDisplayDto> CreateSaleAsync(SaleForCreationDto saleForCreationDto)
        {
            var saleEntity = _mapper.Map<Sale>(saleForCreationDto);

            _repository.SaleRepository.AddSale(saleEntity);
            await _repository.SaveAsync();

            var saleToReturn = _mapper.Map<SaleForDisplayDto>(saleEntity);
            return saleToReturn;
        }

        public async Task DeleteSaleAsync(int Id, bool trackChanges)
        {
            var GetSale = await _repository.SaleRepository.GetSaleByIdAsync(Id, trackChanges);
            _repository.SaleRepository.DeleteSale(GetSale);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<SaleForDisplayDto>> GetAllSaleAsync(bool trackChanges)
        {
            var GetSaleEntities = await _repository.SaleRepository.GetAllSaleAsync(trackChanges);
            var saleEntities = _mapper.Map<IEnumerable<SaleForDisplayDto>>(GetSaleEntities);
            return saleEntities;
        }

        public async Task<SaleForDisplayDto> GetSaleAsync(int Id, bool trackChanges)
        {
            var GetSale = await _repository.SaleRepository.GetSaleByIdAsync(Id, trackChanges);
            var SaleEntity = _mapper.Map<SaleForDisplayDto>(GetSale);
            return SaleEntity;
        }

        public async Task UpdateSaleAsync(int Id, SaleForUpdateDto saleForUpdateDto, bool trackChanges)
        {
            var GetSaleDetail = await _repository.SaleRepository.GetSaleByIdAsync(Id, trackChanges);
            _mapper.Map(saleForUpdateDto, GetSaleDetail);
            await _repository.SaveAsync();
        }
    }
}
