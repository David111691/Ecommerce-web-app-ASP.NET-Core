namespace Core.Entities.ShopGoods
{
    public class ShopCategory
    {
        public int Id { get; set; }
        public string ShopCategoryName { get; set; } = null!;
        public ICollection<ShopSubcategory> ShopSubcategories { get; set; } = null!;
    }
}