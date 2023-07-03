using AutoMapper;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using InventorySalesDemo.Domain.Entities;

namespace InventorySalesDemo.WebApi
{
    public class ProfileMapping: Profile
    {
        public ProfileMapping()
        {
            //Mapping for Display
            CreateMap<DailyInventoryLevel, DailyInventoryLevelForDisplayDto>();
            CreateMap<Product, ProductForDisplayDto>();
            CreateMap<ProductInSale, ProductInSaleForDisplayDto>();
            CreateMap<ProductType, ProductTypeForDisplayDto>();
            CreateMap<Sale, SaleForDisplayDto>();

            //Mapping for Creation
            CreateMap<DailyInventoryLevelForCreationDto, DailyInventoryLevel>();
            CreateMap<ProductForCreationDto, Product>();
            CreateMap<ProductForCreationDto, ProductInSale>();
            CreateMap<ProductTypeForCreationDto, ProductType>();
            CreateMap<SaleForCreationDto, Sale>();

            //Mapping for Update
            CreateMap<DailyInventoryLevelForUpdateDto, DailyInventoryLevel>();
            CreateMap<ProductForUpdateDto, Product>();
            CreateMap<ProductInSaleForUpdateDto, ProductInSale>();
            CreateMap<ProductTypeForUpdateDto, ProductType>();
            CreateMap<SaleForUpdateDto, Sale>();
        }
    }
}
