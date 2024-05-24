using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.ShopGoods;

namespace Core.Specification
{

    public class ItemParams
    {
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1;

        private int _pageSize = 6;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string? Sort { get; set; }

        private string? _search;
        public string? Search
        {
            get => _search;
            set => _search = value.ToLower();
        }
    }

    //ПОСУДАМОЕЧНЫЕ МАШИНЫ -- СПЕЦИФИКАЦИЯ
    public class DishWasherProductWithSubcategorySpecification : BaseSpecification<DishWasherItem>
    {
        public DishWasherProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public DishWasherProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //ХОЛОДИЛЬНИКИ -- СПЕЦИФИКАЦИЯ
    public class FreezerProductWithSubcategorySpecification : BaseSpecification<FreezerItem>
    {
        public FreezerProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public FreezerProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //МИКРОВОЛНОВКИ -- СПЕЦИФИКАЦИЯ
    public class MicrowaveProductWithSubcategorySpecification : BaseSpecification<MicrowaveItem>
    {
        public MicrowaveProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public MicrowaveProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //ПЫЛЕСОСЫ -- СПЕЦИФИКАЦИЯ
    public class VacuumCleanerProductWithSubcategorySpecification : BaseSpecification<VacuumCleanerItem>
    {
        public VacuumCleanerProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public VacuumCleanerProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }


    //СТИРАЛЬНЫЕ МАШИНЫ -- СПЕЦИФИКАЦИЯ
    public class WasherProductWithSubcategorySpecification : BaseSpecification<WasherItem>
    {
        public WasherProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public WasherProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //СПАЛЬНАЯ -- СПЕЦИФИКАЦИЯ
    public class BedRoomProductWithSubcategorySpecification : BaseSpecification<BedroomItem>
    {
        public BedRoomProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public BedRoomProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //КОРИДОР -- СПЕЦИФИКАЦИЯ
    public class HallwayProductWithSubcategorySpecification : BaseSpecification<HallwayItem>
    {
        public HallwayProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public HallwayProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //КУХНЯ -- СПЕЦИФИКАЦИЯ
    public class KitchenProductWithSubcategorySpecification : BaseSpecification<KitchenItem>
    {
        public KitchenProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public KitchenProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //КУХНЯ -- СПЕЦИФИКАЦИЯ
    public class OfficeProductWithSubcategorySpecification : BaseSpecification<OfficeItem>
    {
        public OfficeProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public OfficeProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //батарея -- СПЕЦИФИКАЦИЯ
    public class BatteryProductWithSubcategorySpecification : BaseSpecification<BatteriesAndAccumItem>
    {
        public BatteryProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public BatteryProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //наушники -- СПЕЦИФИКАЦИЯ
    public class HeadphoneProductWithSubcategorySpecification : BaseSpecification<HeadphonesItem>
    {
        public HeadphoneProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public HeadphoneProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //смартфоны -- СПЕЦИФИКАЦИЯ
    public class SmartphoneProductWithSubcategorySpecification : BaseSpecification<SmartphoneItem>
    {
        public SmartphoneProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public SmartphoneProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //TV -- СПЕЦИФИКАЦИЯ
    public class TVProductWithSubcategorySpecification : BaseSpecification<TVItem>
    {
        public TVProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public TVProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //men accessories -- СПЕЦИФИКАЦИЯ
    public class MenAccessoriesProductWithSubcategorySpecification : BaseSpecification<MenAccessoriesItem>
    {
        public MenAccessoriesProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public MenAccessoriesProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //women accessories -- СПЕЦИФИКАЦИЯ
    public class WomenAccessoriesProductWithSubcategorySpecification : BaseSpecification<WomenAccessoriesItem>
    {
        public WomenAccessoriesProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public WomenAccessoriesProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //men clothes -- СПЕЦИФИКАЦИЯ
    public class MenClothesProductWithSubcategorySpecification : BaseSpecification<MenClothesItem>
    {
        public MenClothesProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public MenClothesProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //women clothes -- СПЕЦИФИКАЦИЯ
    public class WomenClothesProductWithSubcategorySpecification : BaseSpecification<WomenClothesItem>
    {
        public WomenClothesProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public WomenClothesProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }


    //men shoes -- СПЕЦИФИКАЦИЯ
    public class MenShoesProductWithSubcategorySpecification : BaseSpecification<MenShoesItem>
    {
        public MenShoesProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public MenShoesProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //women shoes -- СПЕЦИФИКАЦИЯ
    public class WomenShoesProductWithSubcategorySpecification : BaseSpecification<WomenShoesItem>
    {
        public WomenShoesProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.ShopSubcategory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public WomenShoesProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ShopSubcategory);
        }
    }

    //periphery -- СПЕЦИФИКАЦИЯ
    public class PCPeripheryWebCamProductWithSubcategorySpecification : BaseSpecification<PCPeripheryWebCamItem>
    {
        public PCPeripheryWebCamProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCPeriphery);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCPeripheryWebCamProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCPeriphery);
        }
    }

    public class PCPeripheryMiceItemProductWithSubcategorySpecification : BaseSpecification<PCPeripheryMiceItem>
    {
        public PCPeripheryMiceItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCPeriphery);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCPeripheryMiceItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCPeriphery);
        }
    }

    public class PCPeripheryKeyboardItemProductWithSubcategorySpecification : BaseSpecification<PCPeripheryKeyboardItem>
    {
        public PCPeripheryKeyboardItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCPeriphery);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCPeripheryKeyboardItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCPeriphery);
        }
    }

    public class PCAccessoryCPUItemProductWithSubcategorySpecification : BaseSpecification<PCAccessoryCPUItem>
    {
        public PCAccessoryCPUItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCAccessory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCAccessoryCPUItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCAccessory);
        }
    }

    public class PCAccessoryGPUItemProductWithSubcategorySpecification : BaseSpecification<PCAccessoryGPUItem>
    {
        public PCAccessoryGPUItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCAccessory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCAccessoryGPUItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCAccessory);
        }
    }

    public class PCAccessoryHDDItemProductWithSubcategorySpecification : BaseSpecification<PCAccessoryHDDItem>
    {
        public PCAccessoryHDDItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCAccessory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCAccessoryHDDItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCAccessory);
        }
    }

    public class PCAccessoryMotherboardItemProductWithSubcategorySpecification : BaseSpecification<PCAccessoryMotherboardItem>
    {
        public PCAccessoryMotherboardItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCAccessory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCAccessoryMotherboardItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCAccessory);
        }
    }

    public class PCAccessoryRAMItemProductWithSubcategorySpecification : BaseSpecification<PCAccessoryRAMItem>
    {
        public PCAccessoryRAMItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCAccessory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCAccessoryRAMItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCAccessory);
        }
    }

    public class PCAccessorySSDItemProductWithSubcategorySpecification : BaseSpecification<PCAccessorySSDItem>
    {
        public PCAccessorySSDItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCAccessory);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCAccessorySSDItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCAccessory);
        }
    }


    public class PCDisplayItemProductWithSubcategorySpecification : BaseSpecification<PCDisplayItem>
    {
        public PCDisplayItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCDisplay);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCDisplayItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCDisplay);
        }
    }

    public class PCPortableEbookItemProductWithSubcategorySpecification : BaseSpecification<PCPortableEbookItem>
    {
        public PCPortableEbookItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCPortable);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCPortableEbookItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCPortable);
        }
    }

    public class PCPortableLaptopItemProductWithSubcategorySpecification : BaseSpecification<PCPortableLaptopItem>
    {
        public PCPortableLaptopItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCPortable);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCPortableLaptopItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCPortable);
        }
    }


    public class PCPortableTabletItemProductWithSubcategorySpecification : BaseSpecification<PCPortableTabletItem>
    {
        public PCPortableTabletItemProductWithSubcategorySpecification(ItemParams productParams) :
            base(x => string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
        {
            AddInclude(x => x.PCPortable);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),
                productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public PCPortableTabletItemProductWithSubcategorySpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PCPortable);
        }
    }
}