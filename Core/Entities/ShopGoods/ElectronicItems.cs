namespace Core.Entities.ShopGoods
{
    public class BatteriesAndAccumItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; } = null;
        public string? Type { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class HeadphonesItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; } = null;
        public string? Type { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class SmartphoneItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Display { get; set; } = null;
        public string? Resolution { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class TVItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Display { get; set; } = null;
        public string? Resolution { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }
}