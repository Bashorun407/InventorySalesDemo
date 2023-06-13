using AutoMapper;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using InventorySalesDemo.Domain.Entities;

namespace InventorySalesDemo.WebApi
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            //For DailyInventoryLevel
            CreateMap<DailyInventoryLevel, DailyInventoryLevelDtoForDisplay>();
            CreateMap<DailyInventoryLevelDtoForCreation, DailyInventoryLevel>();
            CreateMap<DailyInventoryLevelDtoForUpdate, DailyInventoryLevel>();

            //For Product
            CreateMap<Product, ProductDtoForDisplay>();
            CreateMap<ProductDtoForCreation, Product>();
            CreateMap<ProductDtoForUpdate, Product>();

            //For ProductInSale
            CreateMap<ProductInSale, ProductInSaleDtoForDisplay>();
            CreateMap<ProductInSaleDtoForCreation, ProductInSale>();
            CreateMap<ProductInSaleDtoForUpdate, ProductInSale>();

            //For ProductType
            CreateMap<ProductType, ProductTypeDtoForDisplay>();
            CreateMap<ProductTypeDtoForCreation, ProductType>();
            CreateMap<ProductTypeDtoForUpdate, ProductType>();

            //For Sale
            CreateMap<Sale, SaleDtoForDisplay>();
            CreateMap<SaleDtoForCreation, Sale>();
            CreateMap<SaleDtoForUpdate, Sale>();
        }
    }
}
