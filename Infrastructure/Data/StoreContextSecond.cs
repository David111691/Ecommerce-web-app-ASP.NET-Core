using System.Reflection;
using Core.Entities.ShopGoods;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContextSecond : DbContext
    {
        public StoreContextSecond(DbContextOptions<StoreContextSecond> options) : base(options)
        {
            //Database.EnsureDeleted();
        }

        public DbSet<ShopCategory> Categories { get; set; }
        public DbSet<ShopSubcategory> ShopSubcategories { get; set; }

        //household_equipment
        public DbSet<DishWasherItem> DishWasherItems { get; set; }
        public DbSet<FreezerItem> FreezerItems { get; set; }
        public DbSet<MicrowaveItem> MicrowaveItems { get; set; }
        public DbSet<VacuumCleanerItem> VacuumCleanerItems { get; set; }
        public DbSet<WasherItem> WasherItems { get; set; }

        //furniture
        public DbSet<BedroomItem> BedroomItems { get; set; }
        public DbSet<HallwayItem> HallwayItems { get; set; }
        public DbSet<KitchenItem> KitchenItems { get; set; }
        public DbSet<OfficeItem> OfficeItems { get; set; }

        //Electronic
        public DbSet<BatteriesAndAccumItem> BatteriesAndAccumItems { get; set; }
        public DbSet<HeadphonesItem> HeadphonesItems { get; set; }
        public DbSet<SmartphoneItem> SmartphoneItems { get; set; }
        public DbSet<TVItem> TVItems { get; set; }

        //Clothes
        public DbSet<MenAccessoriesItem> MenAccessoriesItems { get; set; }
        public DbSet<WomenAccessoriesItem> WomenAccessoriesItems { get; set; }
        public DbSet<MenClothesItem> MenClothesItems { get; set; }
        public DbSet<WomenClothesItem> WomenClothesItems { get; set; }
        public DbSet<MenShoesItem> MenShoesItems { get; set; }
        public DbSet<WomenShoesItem> WomenShoesItems { get; set; }

        //Computer Items
        public DbSet<PCPeriphery> Peripheries { get; set; }
        public DbSet<PCAccessory> PCAccessories { get; set; }
        public DbSet<PCDisplay> PCDisplays { get; set; }
        public DbSet<PCPortable> PCPortables { get; set; }

        public DbSet<PCPeripheryKeyboardItem> PCPeripheryKeyboardItems { get; set; }
        public DbSet<PCPeripheryMiceItem> PCPeripheryMiceItems { get; set; }
        public DbSet<PCPeripheryWebCamItem> PCPeripheryWebCamItems { get; set; }

        public DbSet<PCAccessoryCPUItem> PCAccessoryCPUItems { get; set; }
        public DbSet<PCAccessoryGPUItem> PCAccessoryGPUItems { get; set; }
        public DbSet<PCAccessoryHDDItem> PCAccessoryHDDItems { get; set; }
        public DbSet<PCAccessoryMotherboardItem> PCAccessoryMotherboardItems { get; set; }
        public DbSet<PCAccessoryRAMItem> PCAccessoryRAMItems { get; set; }
        public DbSet<PCAccessorySSDItem> PCAccessorySSDItems { get; set; }

        public DbSet<PCDisplayItem> PCDisplayItems { get; set; }

        public DbSet<PCPortableEbookItem> PCPortableEbookItems { get; set; }
        public DbSet<PCPortableLaptopItem> PCPortableLaptopItems { get; set; }
        public DbSet<PCPortableTabletItem> PCPortableTabletItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType.GetProperties()
                        .Where(p => p.PropertyType == typeof(decimal));

                    foreach (var property in properties)
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name)
                            .HasConversion<double>();
                    }
                }
            }
        }
    }
}