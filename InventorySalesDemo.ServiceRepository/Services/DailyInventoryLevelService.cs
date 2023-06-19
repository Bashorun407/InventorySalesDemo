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

        public async void CreateDailyInventoryLevel(DailyInventoryLevelDtoForCreation dailyInventoryLevel)
        {
            var DailyInventoryEntity = _mapper.Map<DailyInventoryLevel>(dailyInventoryLevel);
            _repository.dailyInventoryLevelRepository.CreateDailyInventoryLevel(DailyInventoryEntity);
            await _repository.SaveAsync();

        }

        public async void DeleteDailyInventoryLevel(int id, bool trackChanges)
        {
            var DailyInventoryToDelete =  await _repository.dailyInventoryLevelRepository.GetDailyInventoryLevelById(id, trackChanges);
            if (DailyInventoryToDelete != null)
            {
                _repository.dailyInventoryLevelRepository.DeleteDailyInventoryLevel(DailyInventoryToDelete);
                await _repository.SaveAsync();
            }

        }

        public async Task<IEnumerable<DailyInventoryLevelDtoForDisplay>> GetAllDailyInventoryLevelAsync(bool trackChanges)
        {
            var dailyInventory = await _repository.dailyInventoryLevelRepository.GetAllDailyInventoryLevelAsync(trackChanges);
            var dailyInventoryToReturn = _mapper.Map<IEnumerable<DailyInventoryLevelDtoForDisplay>>(dailyInventory);

            return dailyInventoryToReturn;
        }

        public async Task<DailyInventoryLevelDtoForDisplay> GetDailyInventoryLevelById(int id, bool trackChanges)
        {
            var dailyInventoryEntity = await _repository.dailyInventoryLevelRepository.GetDailyInventoryLevelById(id, trackChanges);
            var dailyInventoryToReturn = _mapper.Map<DailyInventoryLevelDtoForDisplay>(dailyInventoryEntity);
            return dailyInventoryToReturn;
        }

        public async void UpdateDailyInventoryLevel(int id, DailyInventoryLevelDtoForUpdate dailyInventoryLevel, bool trackChanges)
        {
            var dailyInventoryToUpdate = _repository.dailyInventoryLevelRepository.GetDailyInventoryLevelById(id, trackChanges);
            //to update
            await _mapper.Map(dailyInventoryLevel, dailyInventoryToUpdate);
            await _repository.SaveAsync();
        }
    }
}
