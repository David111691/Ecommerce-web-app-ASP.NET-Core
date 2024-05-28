using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;
using Core.Entities.ShopGoods;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());

            CreateMap<DishWasherItem, DishWasherItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<FreezerItem, FreezerItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<MicrowaveItem, MicrowaveItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<VacuumCleanerItem, VacuumCleanerItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<WasherItem, WasherItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<BedroomItem, BedroomItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<HallwayItem, HallwayItemToReturnDto>()
    .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<KitchenItem, KitchenItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<OfficeItem, OfficeItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));


            CreateMap<BatteriesAndAccumItem, BatteriesAndAccumItemToReturnDto>()
                .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<HeadphonesItem, HeadphonesItemToReturnDto>()
                 .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<SmartphoneItem, SmartphoneItemToReturnDto>()
                  .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<TVItem, TVItemToReturnDto>()
                  .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));


            CreateMap<MenAccessoriesItem, MenAccessoriesItemToReturnDto>()
                  .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));


            CreateMap<WomenAccessoriesItem, WomenAccessoriesItemToReturnDto>()
                  .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<MenClothesItem, MenClothesItemToReturnDto>()
                  .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<WomenClothesItem, WomenClothesItemToReturnDto>()
                  .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<MenShoesItem, MenShoesItemToReturnDto>()
                  .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<WomenShoesItem, WomenShoesItemToReturnDto>()
                  .ForMember(d => d.ShopSubcategoryName, o => o.MapFrom(s => s.ShopSubcategory.ShopCategoryName));

            CreateMap<PCPeripheryWebCamItem, PCPeripheryWebCamItemToReturnDto>()
                  .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCPeriphery.SubSubcategoryName));

            CreateMap<PCPeripheryMiceItem, PCPeripheryMiceItemToReturnDto>()
                   .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCPeriphery.SubSubcategoryName));

            CreateMap<PCPeripheryKeyboardItem, PCPeripheryKeyboardItemToReturnDto>()
                   .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCPeriphery.SubSubcategoryName));

            CreateMap<PCAccessoryCPUItem, PCAccessoryCPUItemToReturnDto>()
                   .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCAccessory.SubSubcategoryName));

            CreateMap<PCAccessoryGPUItem, PCAccessoryGPUItemToReturnDto>()
                        .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCAccessory.SubSubcategoryName));

            CreateMap<PCAccessoryHDDItem, PCAccessoryHDDItemToReturnDto>()
                              .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCAccessory.SubSubcategoryName));

            CreateMap<PCAccessoryMotherboardItem, PCAccessoryMotherboardItemToReturnDto>()
                               .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCAccessory.SubSubcategoryName));

            CreateMap<PCAccessoryRAMItem, PCAccessoryRAMItemToReturnDto>()
                                   .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCAccessory.SubSubcategoryName));

            CreateMap<PCAccessorySSDItem, PCAccessorySSDItemToReturnDto>()
                                       .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCAccessory.SubSubcategoryName));

            CreateMap<PCDisplayItem, PCDisplayItemToReturnDto>()
                                       .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCDisplay.SubSubcategoryName));

            CreateMap<PCPortableEbookItem, PCPortableEbookItemToReturnDto>()
                                       .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCPortable.SubSubcategoryName));

            CreateMap<PCPortableLaptopItem, PCPortableLaptopItemToReturnDto>()
                                       .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCPortable.SubSubcategoryName));

            CreateMap<PCPortableTabletItem, PCPortableTabletItemToReturnDto>()
                                        .ForMember(d => d.ShopSubsubcategoryName, o => o.MapFrom(s => s.PCPortable.SubSubcategoryName));
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
