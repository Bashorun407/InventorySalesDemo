using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Common
{
    public interface IRepositoryBase<T>
    {
        Task<ICollection<T>> FindAllAsync(bool trackChanges);
        Task<ICollection<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
