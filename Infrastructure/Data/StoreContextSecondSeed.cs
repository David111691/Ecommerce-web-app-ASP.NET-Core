using System.Text.Json;
using System.Text.RegularExpressions;
using Core.Entities;
using Core.Entities.ShopGoods;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace Infrastructure.Data
{
    public class StoreContextSecondSeed
    {
        public static async Task SeedAsync(StoreContextSecond context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Categories.Any())
                {
                    ShopCategory category = new ShopCategory();
                    category.ShopCategoryName = "Computer_items";
                    context.Categories.Add(category);

                    ShopCategory category2 = new ShopCategory();
                    category2.ShopCategoryName = "Electronic";
                    context.Categories.Add(category2);

                    ShopCategory category3 = new ShopCategory();
                    category3.ShopCategoryName = "Household_equipment";
                    context.Categories.Add(category3);

                    ShopCategory category4 = new ShopCategory();
                    category4.ShopCategoryName = "Furniture";
                    context.Categories.Add(category4);

                    ShopCategory category5 = new ShopCategory();
                    category5.ShopCategoryName = "Clothes";
                    context.Categories.Add(category5);
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.ShopSubcategories.Any())
                {
                    //computer items
                    ShopSubcategory subcategory = new ShopSubcategory();
                    subcategory.ShopCategoryName = "Periphery";
                    subcategory.ShopCategoryId = 1;
                    context.ShopSubcategories.Add(subcategory);

                    ShopSubcategory subcategory2 = new ShopSubcategory();
                    subcategory2.ShopCategoryName = "Accessories";
                    subcategory2.ShopCategoryId = 1;
                    context.ShopSubcategories.Add(subcategory2);

                    ShopSubcategory subcategory3 = new ShopSubcategory();
                    subcategory3.ShopCategoryName = "Displays";
                    subcategory3.ShopCategoryId = 1;
                    context.ShopSubcategories.Add(subcategory3);

                    ShopSubcategory subcategory4 = new ShopSubcategory();
                    subcategory4.ShopCategoryName = "Laptop_tablets_and_portables";
                    subcategory4.ShopCategoryId = 1;
                    context.ShopSubcategories.Add(subcategory4);

                    //electronic
                    ShopSubcategory subcategory5 = new ShopSubcategory();
                    subcategory5.ShopCategoryName = "Batteries_and_accumulators";
                    subcategory5.ShopCategoryId = 2;
                    context.ShopSubcategories.Add(subcategory5);

                    ShopSubcategory subcategory6 = new ShopSubcategory();
                    subcategory6.ShopCategoryName = "Headphones";
                    subcategory6.ShopCategoryId = 2;
                    context.ShopSubcategories.Add(subcategory6);

                    ShopSubcategory subcategory7 = new ShopSubcategory();
                    subcategory7.ShopCategoryName = "Smartphones";
                    subcategory7.ShopCategoryId = 2;
                    context.ShopSubcategories.Add(subcategory7);

                    ShopSubcategory subcategory8 = new ShopSubcategory();
                    subcategory8.ShopCategoryName = "TV";
                    subcategory8.ShopCategoryId = 2;
                    context.ShopSubcategories.Add(subcategory8);

                    //Household_equipment
                    ShopSubcategory subcategory9 = new ShopSubcategory();
                    subcategory9.ShopCategoryName = "Dishwashers";
                    subcategory9.ShopCategoryId = 3;
                    context.ShopSubcategories.Add(subcategory9);

                    ShopSubcategory subcategory10 = new ShopSubcategory();
                    subcategory10.ShopCategoryName = "Freezers";
                    subcategory10.ShopCategoryId = 3;
                    context.ShopSubcategories.Add(subcategory10);

                    ShopSubcategory subcategory11 = new ShopSubcategory();
                    subcategory11.ShopCategoryName = "Microwaves";
                    subcategory11.ShopCategoryId = 3;
                    context.ShopSubcategories.Add(subcategory11);

                    ShopSubcategory subcategory12 = new ShopSubcategory();
                    subcategory12.ShopCategoryName = "Vacuum_cleaners";
                    subcategory12.ShopCategoryId = 3;
                    context.ShopSubcategories.Add(subcategory12);

                    ShopSubcategory subcategory13 = new ShopSubcategory();
                    subcategory13.ShopCategoryName = "Washers";
                    subcategory13.ShopCategoryId = 3;
                    context.ShopSubcategories.Add(subcategory13);

                    //Furniture
                    ShopSubcategory subcategory14 = new ShopSubcategory();
                    subcategory14.ShopCategoryName = "Bedroom";
                    subcategory14.ShopCategoryId = 4;
                    context.ShopSubcategories.Add(subcategory14);

                    ShopSubcategory subcategory15 = new ShopSubcategory();
                    subcategory15.ShopCategoryName = "Hallway";
                    subcategory15.ShopCategoryId = 4;
                    context.ShopSubcategories.Add(subcategory15);

                    ShopSubcategory subcategory16 = new ShopSubcategory();
                    subcategory16.ShopCategoryName = "Kitchen";
                    subcategory16.ShopCategoryId = 4;
                    context.ShopSubcategories.Add(subcategory16);

                    ShopSubcategory subcategory17 = new ShopSubcategory();
                    subcategory17.ShopCategoryName = "Office";
                    subcategory17.ShopCategoryId = 4;
                    context.ShopSubcategories.Add(subcategory17);

                    //Clothes
                    ShopSubcategory subcategory18 = new ShopSubcategory();
                    subcategory18.ShopCategoryName = "Men_clothes";
                    subcategory18.ShopCategoryId = 5;
                    context.ShopSubcategories.Add(subcategory18);

                    ShopSubcategory subcategory19 = new ShopSubcategory();
                    subcategory19.ShopCategoryName = "Women_clothes";
                    subcategory19.ShopCategoryId = 5;
                    context.ShopSubcategories.Add(subcategory19);

                    ShopSubcategory subcategory20 = new ShopSubcategory();
                    subcategory20.ShopCategoryName = "Men_accessories";
                    subcategory20.ShopCategoryId = 5;
                    context.ShopSubcategories.Add(subcategory20);

                    ShopSubcategory subcategory21 = new ShopSubcategory();
                    subcategory21.ShopCategoryName = "Women_accessories";
                    subcategory21.ShopCategoryId = 5;
                    context.ShopSubcategories.Add(subcategory21);

                    ShopSubcategory subcategory22 = new ShopSubcategory();
                    subcategory22.ShopCategoryName = "Men_shoes";
                    subcategory22.ShopCategoryId = 5;
                    context.ShopSubcategories.Add(subcategory22);

                    ShopSubcategory subcategory23 = new ShopSubcategory();
                    subcategory23.ShopCategoryName = "Women_shoes";
                    subcategory23.ShopCategoryId = 5;
                    context.ShopSubcategories.Add(subcategory23);
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.Peripheries.Any())
                {
                    PCPeriphery pcPeriphery = new PCPeriphery();
                    pcPeriphery.ShopSubcategoryId = 1;
                    pcPeriphery.SubSubcategoryName = "Keyboards";
                    context.Peripheries.Add(pcPeriphery);

                    PCPeriphery pcPeriphery2 = new PCPeriphery();
                    pcPeriphery2.ShopSubcategoryId = 1;
                    pcPeriphery2.SubSubcategoryName = "Mice";
                    context.Peripheries.Add(pcPeriphery2);

                    PCPeriphery pcPeriphery3 = new PCPeriphery();
                    pcPeriphery3.ShopSubcategoryId = 1;
                    pcPeriphery3.SubSubcategoryName = "Web_cams";
                    context.Peripheries.Add(pcPeriphery3);
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCAccessories.Any())
                {
                    PCAccessory accessory = new PCAccessory();
                    accessory.ShopSubcategoryId = 2;
                    accessory.SubSubcategoryName = "CPU";
                    context.PCAccessories.Add(accessory);

                    PCAccessory accessory2 = new PCAccessory();
                    accessory2.ShopSubcategoryId = 2;
                    accessory2.SubSubcategoryName = "GPU";
                    context.PCAccessories.Add(accessory2);

                    PCAccessory accessory3 = new PCAccessory();
                    accessory3.ShopSubcategoryId = 2;
                    accessory3.SubSubcategoryName = "HDD";
                    context.PCAccessories.Add(accessory3);

                    PCAccessory accessory4 = new PCAccessory();
                    accessory4.ShopSubcategoryId = 2;
                    accessory4.SubSubcategoryName = "Motherboards";
                    context.PCAccessories.Add(accessory4);

                    PCAccessory accessory5 = new PCAccessory();
                    accessory5.ShopSubcategoryId = 2;
                    accessory5.SubSubcategoryName = "RAM";
                    context.PCAccessories.Add(accessory5);

                    PCAccessory accessory6 = new PCAccessory();
                    accessory6.ShopSubcategoryId = 2;
                    accessory6.SubSubcategoryName = "SSD";
                    context.PCAccessories.Add(accessory6);
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCDisplays.Any())
                {
                    PCDisplay display = new PCDisplay();
                    display.ShopSubcategoryId = 3;
                    display.SubSubcategoryName = "PC_Displays";
                    context.PCDisplays.Add(display);
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCPortables.Any())
                {
                    PCPortable pcPortable = new PCPortable();
                    pcPortable.ShopSubcategoryId = 4;
                    pcPortable.SubSubcategoryName = "Ebooks";
                    context.PCPortables.Add(pcPortable);

                    PCPortable pcPortable2 = new PCPortable();
                    pcPortable2.ShopSubcategoryId = 4;
                    pcPortable2.SubSubcategoryName = "Laptops";
                    context.PCPortables.Add(pcPortable2);

                    PCPortable pcPortable3 = new PCPortable();
                    pcPortable3.ShopSubcategoryId = 4;
                    pcPortable3.SubSubcategoryName = "Tablets";
                    context.PCPortables.Add(pcPortable3);
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            //Добавляем household equipment
            try
            {
                if (!context.DishWasherItems.Any())
                {
                    var dishWasherItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/household_equipment/dishwashers/products.json");

                    dishWasherItemsJson = RemoveAllPriceQuotes(dishWasherItemsJson);

                    //Console.WriteLine(dishWasherItemsJson);
                    //return;

                    var dishWasherItems = JsonSerializer.Deserialize<List<DishWasherItem>>(dishWasherItemsJson);

                    foreach (var item in dishWasherItems)
                    {
                        item.ShopSubcategoryId = 9;
                        context.DishWasherItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.FreezerItems.Any())
                {
                    var freezerItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/household_equipment/freezers/products.json");
                    freezerItemsJson = RemoveAllPriceQuotes(freezerItemsJson);
                    var freezerItems = JsonSerializer.Deserialize<List<FreezerItem>>(freezerItemsJson);

                    foreach (var item in freezerItems)
                    {
                        item.ShopSubcategoryId = 10;
                        context.FreezerItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.MicrowaveItems.Any())
                {
                    var microwaveItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/household_equipment/microwaves/products.json");
                    microwaveItemsJson = RemoveAllPriceQuotes(microwaveItemsJson);
                    var microwaveItems = JsonSerializer.Deserialize<List<MicrowaveItem>>(microwaveItemsJson);

                    foreach (var item in microwaveItems)
                    {
                        item.ShopSubcategoryId = 11;
                        context.MicrowaveItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.VacuumCleanerItems.Any())
                {
                    var vacuumCleanerItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/household_equipment/vacuum_cleaners/products.json");
                    vacuumCleanerItemsJson = RemoveAllPriceQuotes(vacuumCleanerItemsJson);
                    var vacuumCleanerItems = JsonSerializer.Deserialize<List<VacuumCleanerItem>>(vacuumCleanerItemsJson);

                    foreach (var item in vacuumCleanerItems)
                    {
                        item.ShopSubcategoryId = 12;
                        context.VacuumCleanerItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.WasherItems.Any())
                {
                    var washerItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/household_equipment/washers/products.json");
                    washerItemsJson = RemoveAllPriceQuotes(washerItemsJson);
                    var washerItems = JsonSerializer.Deserialize<List<WasherItem>>(washerItemsJson);

                    foreach (var item in washerItems)
                    {
                        item.ShopSubcategoryId = 13;
                        context.WasherItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            //добавляем furniture
            try
            {
                if (!context.BedroomItems.Any())
                {
                    var bedroomItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/furniture/bedroom/products.json");
                    bedroomItemsJson = RemoveAllPriceQuotes(bedroomItemsJson);
                    var bedroomItems = JsonSerializer.Deserialize<List<BedroomItem>>(bedroomItemsJson);

                    foreach (var item in bedroomItems)
                    {
                        item.ShopSubcategoryId = 14;
                        context.BedroomItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.HallwayItems.Any())
                {
                    var hallwayItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/furniture/hallway/products.json");
                    hallwayItemsJson = RemoveAllPriceQuotes(hallwayItemsJson);
                    var hallwayItems = JsonSerializer.Deserialize<List<HallwayItem>>(hallwayItemsJson);

                    foreach (var item in hallwayItems)
                    {
                        item.ShopSubcategoryId = 15;
                        context.HallwayItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.KitchenItems.Any())
                {
                    var kitchenItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/furniture/hallway/products.json");
                    kitchenItemsJson = RemoveAllPriceQuotes(kitchenItemsJson);
                    var kitchenItems = JsonSerializer.Deserialize<List<KitchenItem>>(kitchenItemsJson);

                    foreach (var item in kitchenItems)
                    {
                        item.ShopSubcategoryId = 16;
                        context.KitchenItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.OfficeItems.Any())
                {
                    var officeItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/furniture/hallway/products.json");
                    officeItemsJson = RemoveAllPriceQuotes(officeItemsJson);
                    var officeItems = JsonSerializer.Deserialize<List<OfficeItem>>(officeItemsJson);

                    foreach (var item in officeItems)
                    {
                        item.ShopSubcategoryId = 17;
                        context.OfficeItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            //Добавление electronic 
            try
            {
                if (!context.BatteriesAndAccumItems.Any())
                {
                    var batteriesAndAccumItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/electronic/batteries_and_accumulators/products.json");
                    batteriesAndAccumItemsJson = RemoveAllPriceQuotes(batteriesAndAccumItemsJson);
                    var batteriesAndAccumItems = JsonSerializer.Deserialize<List<BatteriesAndAccumItem>>(batteriesAndAccumItemsJson);

                    foreach (var item in batteriesAndAccumItems)
                    {
                        item.ShopSubcategoryId = 5;
                        context.BatteriesAndAccumItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.HeadphonesItems.Any())
                {
                    var headphonesItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/electronic/headphones/products.json");
                    headphonesItemsJson = RemoveAllPriceQuotes(headphonesItemsJson);
                    var headphonesItems = JsonSerializer.Deserialize<List<HeadphonesItem>>(headphonesItemsJson);

                    foreach (var item in headphonesItems)
                    {
                        item.ShopSubcategoryId = 6;
                        context.HeadphonesItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.SmartphoneItems.Any())
                {
                    var smartphoneItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/electronic/smartphones/products.json");
                    smartphoneItemsJson = RemoveAllPriceQuotes(smartphoneItemsJson);
                    var smartphoneItems = JsonSerializer.Deserialize<List<SmartphoneItem>>(smartphoneItemsJson);

                    foreach (var item in smartphoneItems)
                    {
                        item.ShopSubcategoryId = 7;
                        context.SmartphoneItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.TVItems.Any())
                {
                    var tvItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/electronic/TV/products.json");
                    tvItemsJson = RemoveAllPriceQuotes(tvItemsJson);
                    var tvItems = JsonSerializer.Deserialize<List<TVItem>>(tvItemsJson);

                    foreach (var item in tvItems)
                    {
                        item.ShopSubcategoryId = 8;
                        context.TVItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            //добавление clothes
            try
            {
                if (!context.MenClothesItems.Any())
                {
                    var menClothesItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/clothes/men_clothes/products.json");
                    menClothesItemsJson = RemoveAllPriceQuotes(menClothesItemsJson);
                    var menClothesItems = JsonSerializer.Deserialize<List<MenClothesItem>>(menClothesItemsJson);

                    foreach (var item in menClothesItems)
                    {
                        item.ShopSubcategoryId = 18;
                        context.MenClothesItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.WomenClothesItems.Any())
                {
                    var womenClothesItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/clothes/women_clothes/products.json");
                    womenClothesItemsJson = RemoveAllPriceQuotes(womenClothesItemsJson);
                    var womenClothesItems = JsonSerializer.Deserialize<List<WomenClothesItem>>(womenClothesItemsJson);

                    foreach (var item in womenClothesItems)
                    {
                        item.ShopSubcategoryId = 19;
                        context.WomenClothesItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.MenAccessoriesItems.Any())
                {
                    var menAccessoriesItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/clothes/men_accessories/products.json");
                    menAccessoriesItemsJson = RemoveAllPriceQuotes(menAccessoriesItemsJson);
                    var menAccessoriesItems = JsonSerializer.Deserialize<List<MenAccessoriesItem>>(menAccessoriesItemsJson);

                    foreach (var item in menAccessoriesItems)
                    {
                        item.ShopSubcategoryId = 20;
                        context.MenAccessoriesItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.WomenAccessoriesItems.Any())
                {
                    var womenAccessoriesItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/clothes/women_accessories/products.json");
                    womenAccessoriesItemsJson = RemoveAllPriceQuotes(womenAccessoriesItemsJson);
                    var womenAccessoriesItems = JsonSerializer.Deserialize<List<WomenAccessoriesItem>>(womenAccessoriesItemsJson);

                    foreach (var item in womenAccessoriesItems)
                    {
                        item.ShopSubcategoryId = 21;
                        context.WomenAccessoriesItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.MenShoesItems.Any())
                {
                    var menShoesItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/clothes/men_shoes/products.json");
                    menShoesItemsJson = RemoveAllPriceQuotes(menShoesItemsJson);
                    var menShoesItems = JsonSerializer.Deserialize<List<MenShoesItem>>(menShoesItemsJson);

                    foreach (var item in menShoesItems)
                    {
                        item.ShopSubcategoryId = 22;
                        context.MenShoesItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.WomenShoesItems.Any())
                {
                    var womenShoesItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/clothes/women_shoes/products.json");
                    womenShoesItemsJson = RemoveAllPriceQuotes(womenShoesItemsJson);
                    var womenShoesItems = JsonSerializer.Deserialize<List<WomenShoesItem>>(womenShoesItemsJson);

                    foreach (var item in womenShoesItems)
                    {
                        item.ShopSubcategoryId = 23;
                        context.WomenShoesItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            //добавление computer_items
            try
            {
                if (!context.PCPeripheryKeyboardItems.Any())
                {
                    var pcPeripheryKeyboardItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/periphery/keyboards/products.json");
                    pcPeripheryKeyboardItemsJson = RemoveAllPriceQuotes(pcPeripheryKeyboardItemsJson);
                    var pcPeripheryKeyboardItems = JsonSerializer.Deserialize<List<PCPeripheryKeyboardItem>>(pcPeripheryKeyboardItemsJson);

                    foreach (var item in pcPeripheryKeyboardItems)
                    {
                        item.PCPeripheryId = 1;
                        context.PCPeripheryKeyboardItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCPeripheryMiceItems.Any())
                {
                    var pcPeripheryMiceItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/periphery/mice/products.json");
                    pcPeripheryMiceItemsJson = RemoveAllPriceQuotes(pcPeripheryMiceItemsJson);
                    var pcPeripheryMiceItems = JsonSerializer.Deserialize<List<PCPeripheryMiceItem>>(pcPeripheryMiceItemsJson);

                    foreach (var item in pcPeripheryMiceItems)
                    {
                        item.PCPeripheryId = 2;
                        context.PCPeripheryMiceItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCPeripheryWebCamItems.Any())
                {
                    var pcPeripheryWebCamItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/periphery/web_cams/products.json");
                    pcPeripheryWebCamItemsJson = RemoveAllPriceQuotes(pcPeripheryWebCamItemsJson);
                    var pcPeripheryWebCamItems = JsonSerializer.Deserialize<List<PCPeripheryWebCamItem>>(pcPeripheryWebCamItemsJson);

                    foreach (var item in pcPeripheryWebCamItems)
                    {
                        item.PCPeripheryId = 3;
                        context.PCPeripheryWebCamItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCDisplayItems.Any())
                {
                    var pcDisplayItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/displays/products.json");
                    pcDisplayItemsJson = RemoveAllPriceQuotes(pcDisplayItemsJson);
                    var pcDisplayItems = JsonSerializer.Deserialize<List<PCDisplayItem>>(pcDisplayItemsJson);

                    foreach (var item in pcDisplayItems)
                    {
                        item.PCDisplayId = 1;
                        context.PCDisplayItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCAccessoryCPUItems.Any())
                {
                    var pcAccessoryCPUItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/accessories/CPU/proccessors.json");
                    pcAccessoryCPUItemsJson = RemoveAllPriceQuotes(pcAccessoryCPUItemsJson);
                    var pcAccessoryCPUItems = JsonSerializer.Deserialize<List<PCAccessoryCPUItem>>(pcAccessoryCPUItemsJson);

                    foreach (var item in pcAccessoryCPUItems)
                    {
                        item.PCAccessoryId = 1;
                        context.PCAccessoryCPUItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCAccessoryGPUItems.Any())
                {
                    var pcAccessoryGPUItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/accessories/GPU/products.json");
                    pcAccessoryGPUItemsJson = RemoveAllPriceQuotes(pcAccessoryGPUItemsJson);
                    var pcAccessoryGPUItems = JsonSerializer.Deserialize<List<PCAccessoryGPUItem>>(pcAccessoryGPUItemsJson);

                    foreach (var item in pcAccessoryGPUItems)
                    {
                        item.PCAccessoryId = 2;
                        context.PCAccessoryGPUItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCAccessoryHDDItems.Any())
                {
                    var pcAccessoryHDDItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/accessories/HDD/hdd.json");
                    pcAccessoryHDDItemsJson = RemoveAllPriceQuotes(pcAccessoryHDDItemsJson);
                    var pcAccessoryHDDItems = JsonSerializer.Deserialize<List<PCAccessoryHDDItem>>(pcAccessoryHDDItemsJson);

                    foreach (var item in pcAccessoryHDDItems)
                    {
                        item.PCAccessoryId = 3;
                        context.PCAccessoryHDDItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCAccessoryMotherboardItems.Any())
                {
                    var pcAccessoryMotherboardItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/accessories/motherboards/motherboards.json");
                    pcAccessoryMotherboardItemsJson = RemoveAllPriceQuotes(pcAccessoryMotherboardItemsJson);
                    var pcAccessoryMotherboardItems = JsonSerializer.Deserialize<List<PCAccessoryMotherboardItem>>(pcAccessoryMotherboardItemsJson);

                    foreach (var item in pcAccessoryMotherboardItems)
                    {
                        item.PCAccessoryId = 4;
                        context.PCAccessoryMotherboardItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCAccessoryRAMItems.Any())
                {
                    var pcAccessoryRAMItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/accessories/RAM/products.json");
                    pcAccessoryRAMItemsJson = RemoveAllPriceQuotes(pcAccessoryRAMItemsJson);
                    var pcAccessoryRAMItems = JsonSerializer.Deserialize<List<PCAccessoryRAMItem>>(pcAccessoryRAMItemsJson);

                    foreach (var item in pcAccessoryRAMItems)
                    {
                        item.PCAccessoryId = 5;
                        context.PCAccessoryRAMItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCAccessorySSDItems.Any())
                {
                    var pcAccessorySDDItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/accessories/SDD/products.json");
                    pcAccessorySDDItemsJson = RemoveAllPriceQuotes(pcAccessorySDDItemsJson);
                    var pcAccessorySDDItems = JsonSerializer.Deserialize<List<PCAccessorySSDItem>>(pcAccessorySDDItemsJson);

                    foreach (var item in pcAccessorySDDItems)
                    {
                        item.PCAccessoryId = 6;
                        context.PCAccessorySSDItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCPortableEbookItems.Any())
                {
                    var pcPortableEbookItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/laptops_tablets_portables/ebooks/products.json");
                    pcPortableEbookItemsJson = RemoveAllPriceQuotes(pcPortableEbookItemsJson);
                    var pcPortableEbookItems = JsonSerializer.Deserialize<List<PCPortableEbookItem>>(pcPortableEbookItemsJson);

                    foreach (var item in pcPortableEbookItems)
                    {
                        item.PCPortableId = 1;
                        context.PCPortableEbookItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCPortableLaptopItems.Any())
                {
                    var pcPortableLaptopItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/laptops_tablets_portables/laptops/products.json");
                    pcPortableLaptopItemsJson = RemoveAllPriceQuotes(pcPortableLaptopItemsJson);
                    var pcPortableLaptopItems = JsonSerializer.Deserialize<List<PCPortableLaptopItem>>(pcPortableLaptopItemsJson);

                    foreach (var item in pcPortableLaptopItems)
                    {
                        item.PCPortableId = 2;
                        context.PCPortableLaptopItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }

            try
            {
                if (!context.PCPortableTabletItems.Any())
                {
                    var pcPortableTabletItemsJson = File.ReadAllText("../Infrastructure/Data/ShopGoods/computer_items/laptops_tablets_portables/tablets/products.json");
                    pcPortableTabletItemsJson = RemoveAllPriceQuotes(pcPortableTabletItemsJson);
                    var pcPortableTabletItems = JsonSerializer.Deserialize<List<PCPortableTabletItem>>(pcPortableTabletItemsJson);

                    foreach (var item in pcPortableTabletItems)
                    {
                        item.PCPortableId = 3;
                        context.PCPortableTabletItems.Add(item);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSecondSeed>();
                logger.LogError(ex.Message);
            }
        }

        private static string RemoveAllPriceQuotes(string jsonFile)
        {
            var jsonArray = JArray.Parse(jsonFile);

            foreach (JObject obj in jsonArray)
            {
                // Проверяем наличие поля "Price"
                if (obj["Price"] != null)
                {
                    // Получаем значение поля "Price"
                    string priceString = obj["Price"].ToString();

                    // Преобразуем значение в число
                    if (decimal.TryParse(priceString, out decimal price))
                    {
                        // Обновляем значение поля "Price" в объекте
                        obj["Price"] = price;
                    }
                }
            }

            string modifiedJson = jsonArray.ToString();
            return modifiedJson;
        }
    }
}