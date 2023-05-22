using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Contracts
{
    public interface IRefCalendarRepository
    {
        Task<IEnumerable<RefCalendar>> GetAllAsync(bool trackChanges);
        Task<RefCalendar> GetRefCalendarById(int Id, bool trackChanges);
        void CreateRefCalendar(RefCalendar entity);
        void DeleteRefCalendar(RefCalendar entity);
    }
}
