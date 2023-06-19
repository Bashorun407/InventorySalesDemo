using AutoMapper;
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

        public void CreateSale(SaleDtoForCreation sale)
        {
            throw new NotImplementedException();
        }

        public void DeleteSale(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SaleDtoForDisplay>> GetAllSalesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<SaleDtoForDisplay> GetSaleByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateSale(int id, SaleDtoForUpdate sale)
        {
            throw new NotImplementedException();
        }
    }
}
