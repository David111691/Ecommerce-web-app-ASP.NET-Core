namespace Core.Entities.ShopGoods
{
    public class ShopSubcategory
    {
        public int Id { get; set; }
        public int ShopCategoryId { get; set; }
        public string ShopCategoryName { get; set; } = null!;
        public ShopCategory ShopCategory { get; set; } = null!;

        //household_equipment
        public ICollection<DishWasherItem> DishWasherItems { get; set; } = null!;
        public ICollection<FreezerItem> FreezerItems { get; set; } = null!;
        public ICollection<MicrowaveItem> MicrowaveItems { get; set; } = null!;
        public ICollection<VacuumCleanerItem> VacuumCleanerItems { get; set; } = null!;
        public ICollection<WasherItem> WasherItems { get; set; } = null!;

        //furniture
        public ICollection<BedroomItem> BedroomItems { get; set; } = null!;
        public ICollection<HallwayItem> HallwayItems { get; set; } = null!;
        public ICollection<KitchenItem> KitchenItems { get; set; } = null!;
        public ICollection<OfficeItem> OfficeItems { get; set; } = null!;

        //Electronic
        public ICollection<BatteriesAndAccumItem> BatteriesAndAccumItems { get; set; } = null!;
        public ICollection<HeadphonesItem> HeadphonesItems { get; set; } = null!;
        public ICollection<SmartphoneItem> SmartphoneItems { get; set; } = null!;
        public ICollection<TVItem> TVItems { get; set; } = null!;

        //Clothes
        public ICollection<MenAccessoriesItem> MenAccessoriesItems { get; set; } = null!;
        public ICollection<WomenAccessoriesItem> WomenAccessoriesItems { get; set; } = null!;
        public ICollection<MenClothesItem> MenClothesItems { get; set; } = null!;
        public ICollection<WomenClothesItem> WomenClothesItems { get; set; } = null!;
        public ICollection<MenShoesItem> MenShoesItems { get; set; } = null!;
        public ICollection<WomenShoesItem> WomenShoesItems { get; set; } = null!;

        //Computer Items
        public ICollection<PCPeriphery> Peripheries { get; set; } = null!;
        public ICollection<PCAccessory> PCAccessories { get; set; } = null!;
        public ICollection<PCDisplay> PCDisplays { get; set; } = null!;
        public ICollection<PCPortable> PCPortables { get; set; } = null!;
    }
}