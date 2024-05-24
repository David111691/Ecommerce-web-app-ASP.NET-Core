using Core.Entities;
using Core.Entities.ShopGoods;

namespace Core.Specification
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams) :
            base(x =>
                (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().
                Contains(productParams.Search)) &&
                (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
                (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
            )
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationDishWashers : BaseSpecification<DishWasherItem>
    {
        public ProductWithFiltersForCountSpecificationDishWashers(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationFreezers : BaseSpecification<FreezerItem>
    {
        public ProductWithFiltersForCountSpecificationFreezers(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationMicrowaves : BaseSpecification<MicrowaveItem>
    {
        public ProductWithFiltersForCountSpecificationMicrowaves(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationVacuumCleaners : BaseSpecification<VacuumCleanerItem>
    {
        public ProductWithFiltersForCountSpecificationVacuumCleaners(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationWasher : BaseSpecification<WasherItem>
    {
        public ProductWithFiltersForCountSpecificationWasher(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationBedRoom : BaseSpecification<BedroomItem>
    {
        public ProductWithFiltersForCountSpecificationBedRoom(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationHallway : BaseSpecification<HallwayItem>
    {
        public ProductWithFiltersForCountSpecificationHallway(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }


    public class ProductWithFiltersForCountSpecificationKitchen : BaseSpecification<KitchenItem>
    {
        public ProductWithFiltersForCountSpecificationKitchen(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationOffice : BaseSpecification<OfficeItem>
    {
        public ProductWithFiltersForCountSpecificationOffice(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationBattery : BaseSpecification<BatteriesAndAccumItem>
    {
        public ProductWithFiltersForCountSpecificationBattery(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationHeadphone : BaseSpecification<HeadphonesItem>
    {
        public ProductWithFiltersForCountSpecificationHeadphone(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationSmartphone : BaseSpecification<SmartphoneItem>
    {
        public ProductWithFiltersForCountSpecificationSmartphone(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationTV : BaseSpecification<TVItem>
    {
        public ProductWithFiltersForCountSpecificationTV(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationMenAccessories : BaseSpecification<MenAccessoriesItem>
    {
        public ProductWithFiltersForCountSpecificationMenAccessories(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationWomenAccessories : BaseSpecification<WomenAccessoriesItem>
    {
        public ProductWithFiltersForCountSpecificationWomenAccessories(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationMenClothes : BaseSpecification<MenClothesItem>
    {
        public ProductWithFiltersForCountSpecificationMenClothes(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationWomenClothes : BaseSpecification<WomenClothesItem>
    {
        public ProductWithFiltersForCountSpecificationWomenClothes(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationMenShoes : BaseSpecification<MenShoesItem>
    {
        public ProductWithFiltersForCountSpecificationMenShoes(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationWomenShoes : BaseSpecification<WomenShoesItem>
    {
        public ProductWithFiltersForCountSpecificationWomenShoes(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCPeripheryWebCam : BaseSpecification<PCPeripheryWebCamItem>
    {
        public ProductWithFiltersForCountSpecificationPCPeripheryWebCam(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCPeripheryMiceItem : BaseSpecification<PCPeripheryMiceItem>
    {
        public ProductWithFiltersForCountSpecificationPCPeripheryMiceItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCPeripheryKeyboardItem : BaseSpecification<PCPeripheryKeyboardItem>
    {
        public ProductWithFiltersForCountSpecificationPCPeripheryKeyboardItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCAccessoryCPUItem : BaseSpecification<PCAccessoryCPUItem>
    {
        public ProductWithFiltersForCountSpecificationPCAccessoryCPUItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCAccessoryGPUItem : BaseSpecification<PCAccessoryGPUItem>
    {
        public ProductWithFiltersForCountSpecificationPCAccessoryGPUItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCAccessoryHDDItem : BaseSpecification<PCAccessoryHDDItem>
    {
        public ProductWithFiltersForCountSpecificationPCAccessoryHDDItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCAccessoryMotherboardItem : BaseSpecification<PCAccessoryMotherboardItem>
    {
        public ProductWithFiltersForCountSpecificationPCAccessoryMotherboardItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCAccessoryRAMItem : BaseSpecification<PCAccessoryRAMItem>
    {
        public ProductWithFiltersForCountSpecificationPCAccessoryRAMItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCAccessorySSDItem : BaseSpecification<PCAccessorySSDItem>
    {
        public ProductWithFiltersForCountSpecificationPCAccessorySSDItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCDisplayItem : BaseSpecification<PCDisplayItem>
    {
        public ProductWithFiltersForCountSpecificationPCDisplayItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCPortableEbookItem : BaseSpecification<PCPortableEbookItem>
    {
        public ProductWithFiltersForCountSpecificationPCPortableEbookItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCPortableLaptopItem : BaseSpecification<PCPortableLaptopItem>
    {
        public ProductWithFiltersForCountSpecificationPCPortableLaptopItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }

    public class ProductWithFiltersForCountSpecificationPCPortableTabletItem : BaseSpecification<PCPortableTabletItem>
    {
        public ProductWithFiltersForCountSpecificationPCPortableTabletItem(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
        }
    }
}