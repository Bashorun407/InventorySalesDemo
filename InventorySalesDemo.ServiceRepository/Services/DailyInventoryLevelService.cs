using AutoMapper;
using InventorySales.CoreServiceContract.Contract;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
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

        public Task CreateDailyInventoryLevel(DailyInventoryLevelDtoForCreation dailyInventoryLevelDtoForCreation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDailyInventoryLevel(int dailyInventoryLevelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DailyInventoryLevelDtoForDisplay>> GetAllDailyInventoryLevels()
        {
            throw new NotImplementedException();
        }

        public Task<DailyInventoryLevelDtoForDisplay> GetDailyInventoryLevelById(int dailyInventoryLevelId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDailyInventoryLevel(DailyInventoryLevelDtoForUpdate dailyInventoryLevelDtoForUpdate, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
