namespace InventorySalesDemo.WebApi.Exceptions
{
    public class IdParemetersBadRequestException : BadRequestException
    {
        public IdParemetersBadRequestException() : base("Parameter Id is null")
        {
        }
    }
}
