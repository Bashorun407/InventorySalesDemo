using AutoMapper;
using InventorySales.CoreServiceContract.Contract;
using InventorySalesDemo.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceRepository.Services
{
    internal sealed class DailyInventoryLevelService : IDailyInventoryLevelService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DailyInventoryLevelService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public Task CreateDailyInventoryLevel(InventorySalesDemo.Application.DTOs.DtoForCreation.DailyInventoryLevelDtoForCreation dailyInventoryLevelDtoForCreation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDailyInventoryLevel(int dailyInventoryLevelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InventorySalesDemo.Application.DTOs.DtoForDisplay.DailyInventoryLevelDtoForDisplay>> GetAllDailyInventoryLevels()
        {
            throw new NotImplementedException();
        }

        public Task<InventorySalesDemo.Application.DTOs.DtoForDisplay.DailyInventoryLevelDtoForDisplay> GetDailyInventoryLevelById(int dailyInventoryLevelId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDailyInventoryLevel(InventorySalesDemo.Application.DTOs.DtoForUpdate.DailyInventoryLevelDtoForUpdate dailyInventoryLevelDtoForUpdate, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
