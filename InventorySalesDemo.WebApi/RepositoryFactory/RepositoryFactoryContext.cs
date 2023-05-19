using InventorySalesDemo.Persistence.DataBaseContext;
using Microsoft.EntityFrameworkCore.Design;

namespace InventorySalesDemo.WebApi.RepositoryFactory
{

    public class RepositoryFactoryContext : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }
    }

}
