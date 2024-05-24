using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.ShopGoods
{
    public class PCPeriphery
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string SubSubcategoryName { get; set; } = null!;
        public ShopSubcategory ShopSubcategory { get; set; } = null!;
        public ICollection<PCPeripheryKeyboardItem> PCPeripheryKeyboardItems { get; set; } = null!;
        public ICollection<PCPeripheryMiceItem> PCPeripheryMiceItems { get; set; } = null!;
        public ICollection<PCPeripheryWebCamItem> PCPeripheryWebCamItems { get; set; } = null!;
    }

    public class PCPeripheryWebCamItem
    {
        public int Id { get; set; }
        public int PCPeripheryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Resolution { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCPeriphery PCPeriphery { get; set; } = null!;
    }

    public class PCPeripheryMiceItem
    {
        public int Id { get; set; }
        public int PCPeripheryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Linking { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCPeriphery PCPeriphery { get; set; } = null!;
    }

    public class PCPeripheryKeyboardItem
    {
        public int Id { get; set; }
        public int PCPeripheryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Linking { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCPeriphery PCPeriphery { get; set; } = null!;
    }

    public class PCAccessory
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string SubSubcategoryName { get; set; } = null!;
        public ShopSubcategory ShopSubcategory { get; set; } = null!;
        public ICollection<PCAccessoryCPUItem> PCAccessoryCPUItems { get; set; } = null!;
        public ICollection<PCAccessoryGPUItem> PCAccessoryGPUItems { get; set; } = null!;
        public ICollection<PCAccessoryHDDItem> PCAccessoryHDDItems { get; set; } = null!;
        public ICollection<PCAccessoryMotherboardItem> PCAccessoryMotherboardItems { get; set; } = null!;
        public ICollection<PCAccessoryRAMItem> PCAccessoryRAMItems { get; set; } = null!;
        public ICollection<PCAccessorySSDItem> PCAccessorySDDItems { get; set; } = null!;
    }

    public class PCAccessoryRAMItem
    {
        public int Id { get; set; }
        public int PCAccessoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Brand { get; set; } = null!;
        public string? Value { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCAccessory PCAccessory { get; set; } = null!;
    }

    public class PCAccessoryMotherboardItem
    {
        public int Id { get; set; }
        public int PCAccessoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Brand { get; set; } = null!;
        public string? Socket { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCAccessory PCAccessory { get; set; } = null!;
    }

    public class PCAccessoryHDDItem
    {
        public int Id { get; set; }
        public int PCAccessoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; } = null;
        public decimal Price { get; set; }
        public string? Value { get; set; } = null;
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCAccessory PCAccessory { get; set; } = null!;
    }

    public class PCAccessoryGPUItem
    {
        public int Id { get; set; }
        public int PCAccessoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Brand { get; set; } = null;
        public string? Value { get; set; } = null;
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCAccessory PCAccessory { get; set; } = null!;
    }

    public class PCAccessoryCPUItem
    {
        public int Id { get; set; }
        public int PCAccessoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Brand { get; set; } = null;
        public string? Cores { get; set; } = null;
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCAccessory PCAccessory { get; set; } = null!;
    }

    public class PCAccessorySSDItem
    {
        public int Id { get; set; }
        public int PCAccessoryId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Brand { get; set; } = null;
        public string? Value { get; set; } = null;
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCAccessory PCAccessory { get; set; } = null!;
    }

    public class PCDisplay
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string SubSubcategoryName { get; set; } = null!;
        public ShopSubcategory ShopSubcategory { get; set; } = null!;
        public ICollection<PCDisplayItem> PCDisplayItems { get; set; } = null!;
    }

    public class PCDisplayItem
    {
        public int Id { get; set; }
        public int PCDisplayId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; } = null;
        public string? Clock { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCDisplay PCDisplay { get; set; } = null!;
    }

    public class PCPortable
    {
        public int Id { get; set; }
        public int ShopSubcategoryId { get; set; }
        public string SubSubcategoryName { get; set; } = null!;
        public ShopSubcategory ShopSubcategory { get; set; } = null!;
        public ICollection<PCPortableEbookItem> PCPortableEbookItem { get; set; } = null!;
        public ICollection<PCPortableLaptopItem> PCPortableLaptopItems { get; set; } = null!;
        public ICollection<PCPortableTabletItem> PCPortableTabletItems { get; set; } = null!;
    }

    public class PCPortableTabletItem
    {
        public int Id { get; set; }
        public int PCPortableId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCPortable PCPortable { get; set; } = null!;
    }

    public class PCPortableLaptopItem
    {
        public int Id { get; set; }
        public int PCPortableId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; } = null;
        public string? RAM_Value { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCPortable PCPortable { get; set; } = null!;
    }

    public class PCPortableEbookItem
    {
        public int Id { get; set; }
        public int PCPortableId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; } = null;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string? Description { get; set; } = null;
        public PCPortable PCPortable { get; set; } = null!;
    }
}