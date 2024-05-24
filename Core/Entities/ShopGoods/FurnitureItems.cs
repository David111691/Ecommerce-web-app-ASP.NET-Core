namespace Core.Entities.ShopGoods
{
    public class BedroomItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class HallwayItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class KitchenItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class OfficeItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }
}