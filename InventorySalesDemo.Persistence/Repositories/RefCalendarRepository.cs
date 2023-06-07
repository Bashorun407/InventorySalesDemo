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
        protected RepositoryContext _repositoryContext;

        public RefCalendarRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateRefCalendar(RefCalendar entity)
        {
            CreateRefCalendar(entity);
        }

        public void DeleteRefCalendar(RefCalendar entity)
        {
            DeleteRefCalendar(entity);
        }

        public async Task<IEnumerable<RefCalendar>> GetAllRefCalendarAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x => x.Day_Date)
                .ToListAsync();

        }

        public void UpdateRefCalendar(RefCalendar entity)
        {
            UpdateRefCalendar(entity);
        }
    }
}
