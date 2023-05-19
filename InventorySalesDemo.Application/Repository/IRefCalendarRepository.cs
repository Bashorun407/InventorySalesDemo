using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Repository
{
    public interface IRefCalendarRepository
    {
        Task<ICollection<RefCalendar>> GetAllRefCalendar();
        Task<RefCalendar> GetRefCalendarById(int id);
        void Add(RefCalendar refCalendar);
        void Update(RefCalendar refCalendar);
        void Delete(RefCalendar refCalendar);
    }
}
