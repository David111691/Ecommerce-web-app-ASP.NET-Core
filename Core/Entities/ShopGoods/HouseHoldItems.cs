using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.ShopGoods
{
    public class DishWasherItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Power { get; set; } = null;
        public string? Volume { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class FreezerItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Noise { get; set; } = null!;
        public string? Volume { get; set; } 
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class MicrowaveItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Volume { get; set; } = null;
        public string? Power { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class VacuumCleanerItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Power { get; set; } = null;
        public string? Volume { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class WasherItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Value { get; set; } = null;
        public string? Spin { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }
}