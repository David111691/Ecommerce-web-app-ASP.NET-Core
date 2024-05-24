namespace Core.Entities.ShopGoods
{
    public class MenAccessoriesItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class WomenAccessoriesItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class MenClothesItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class WomenClothesItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class MenShoesItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }

    public class WomenShoesItem
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ShopSubcategory ShopSubcategory{ get; set; } = null!;
    }
}