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
        public async Task<DailyInventoryLevelForDisplayDto> CreateDailyInventoryLevelAsync(DailyInventoryLevelForCreationDto dailyInventoryLevelCreationDto)
        {
            var dailyInventoryLevelEntity = _mapper.Map<DailyInventoryLevel>(dailyInventoryLevelCreationDto);

            _repository.DailyInventoryLevelRepository.AddDailyInventoryLevel(dailyInventoryLevelEntity);
            await _repository.SaveAsync();

            var dailyInventoryLevelToReturn = _mapper.Map<DailyInventoryLevelForDisplayDto>(dailyInventoryLevelEntity);
            return dailyInventoryLevelToReturn;
        }

        public async Task DeleteDailyInventoryLevelAsync(int Id, bool trackChanges)
        {
            var GetDailyInventoryLevel = await _repository.DailyInventoryLevelRepository.GetDailyInventoryLevelByIdAsync(Id, trackChanges);
            _repository.DailyInventoryLevelRepository.DeleteDailyInventoryLevel(GetDailyInventoryLevel);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<DailyInventoryLevelForDisplayDto>> GetAllDailyInventoryLevelAsync(bool trackChanges)
        {
            var GetDailyInventoryLevelsEntities = await _repository.DailyInventoryLevelRepository.GetAllDailyInventoryLevelAsync(trackChanges);
            var dailyInventoryLevelEntities = _mapper.Map<IEnumerable<DailyInventoryLevelForDisplayDto>>(GetDailyInventoryLevelsEntities);
            return dailyInventoryLevelEntities;
        }

        public async Task<DailyInventoryLevelForDisplayDto> GetDailyInventoryLevelByIdAsync(int Id, bool trackChanges)
        {
            var GetDailyInventoryLevel = await _repository.DailyInventoryLevelRepository.GetDailyInventoryLevelByIdAsync(Id, trackChanges);
            var DailyInventoryLevelEntity = _mapper.Map<DailyInventoryLevelForDisplayDto>(GetDailyInventoryLevel);
            return DailyInventoryLevelEntity;
        }

        public async Task UpdateDailyInventoryLevelAsync(int Id, DailyInventoryLevelForUpdateDto dailyInventoryLevelForUpdateDto, bool trackChanges)
        {
            var GetDailyInventoryLevelDetail = await _repository.DailyInventoryLevelRepository.GetDailyInventoryLevelByIdAsync(Id, trackChanges);
            _mapper.Map(dailyInventoryLevelForUpdateDto, GetDailyInventoryLevelDetail);
            await _repository.SaveAsync();
        }
    }
}
