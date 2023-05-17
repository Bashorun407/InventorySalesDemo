using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Common
{
    public interface IRepositoryBase
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T>FindByCondition(Expression<Func<Task, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    public class T
    {
    }
}
