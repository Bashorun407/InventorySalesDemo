namespace InventorySalesDemo.WebApi.Exceptions
{
    public class SaleNotFoundException : NotFoundException
    {
        public SaleNotFoundException(string Id) : base($"The sale with Id {Id} doesn't exist in the database")
        {
        }
    }
}
