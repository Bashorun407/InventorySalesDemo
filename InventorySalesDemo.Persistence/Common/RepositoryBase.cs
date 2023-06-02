using InventorySalesDemo.Application.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Persistence.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        //Protected class field
        protected RepositoryContext RepositoryContext;

        //Class constructor
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public void Add(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAllAsync(bool trackChanges)
        {
            return !trackChanges ?
                RepositoryContext.Set<T>()
                .AsNoTracking() : 
                RepositoryContext.Set<T>(); 
        }

        public IQueryable<T> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return !trackChanges ?
                RepositoryContext.Set<T>()
                .Where(expression)
                .AsNoTracking() :
                RepositoryContext.Set<T>()
                .Where (expression);
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
