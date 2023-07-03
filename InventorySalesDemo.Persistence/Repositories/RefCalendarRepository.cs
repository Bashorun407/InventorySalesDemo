using InventorySalesDemo.Application.Contracts;
using InventorySalesDemo.Domain.Entities;
using InventorySalesDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Persistence.Repositories
{
    internal sealed class RefCalendarRepository : RepositoryBase<RefCalendar>, IRefCalendarRepository
    {
        public RefCalendarRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddRefCalendar(RefCalendar refCalendar)
        {
            Add(refCalendar);
        }

        public void DeleteRefCalendar(RefCalendar refCalendar)
        {
            Delete(refCalendar);
        }

        public async Task<IEnumerable<RefCalendar>> GetAllAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x =>x.Day_Date)
                .ToListAsync();
        }

    }
}
