using API.Dtos;
using API.Errors;
using API.Helpers;
using AutoMapper;
using Core.Entities;
using Core.Entities.ShopGoods;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ShopController : BaseApiController
    {
        private readonly IGenericRepository<ShopCategory> _categoriesRepo;
        private readonly IGenericRepository<ShopSubcategory> _shopSubcategoriesRepo;

        //household_equipment
        private readonly IGenericRepository<DishWasherItem> _dishWasherItemsRepo;
        private readonly IGenericRepository<FreezerItem> _freezerItemsRepo;
        private readonly IGenericRepository<MicrowaveItem> _microwaveItemsRepo;
        private readonly IGenericRepository<VacuumCleanerItem> _vacuumCleanerItemsRepo;
        private readonly IGenericRepository<WasherItem> _washerItemsRepo;

        //furniture
        private readonly IGenericRepository<BedroomItem> _bedroomItemsRepo;
        private readonly IGenericRepository<HallwayItem> _hallwayItemsRepo;
        private readonly IGenericRepository<KitchenItem> _kitchenItemsRepo;
        private readonly IGenericRepository<OfficeItem> _officeItemsRepo;

        //Electronic
        private readonly IGenericRepository<BatteriesAndAccumItem> _batteriesAndAccumItemsRepo;
        private readonly IGenericRepository<HeadphonesItem> _headphonesItemsRepo;
        private readonly IGenericRepository<SmartphoneItem> _smartphoneItemsRepo;
        private readonly IGenericRepository<TVItem> _tvItemsRepo;

        //Clothes
        private readonly IGenericRepository<MenAccessoriesItem> _menAccessoriesItemsRepo;
        private readonly IGenericRepository<WomenAccessoriesItem> _womenAccessoriesItemsRepo;
        private readonly IGenericRepository<MenClothesItem> _menClothesItemsRepo;
        private readonly IGenericRepository<WomenClothesItem> _womenClothesItemsRepo;
        private readonly IGenericRepository<MenShoesItem> _menShoesItemsRepo;
        private readonly IGenericRepository<WomenShoesItem> _womenShoesItemsRepo;

        //Computer Items
        private readonly IGenericRepository<PCPeriphery> _peripheriesRepo;
        private readonly IGenericRepository<PCAccessory> _pcAccessoriesRepo;
        private readonly IGenericRepository<PCDisplay> _pcDisplaysRepo;
        private readonly IGenericRepository<PCPortable> _pcPortablesRepo;

        private readonly IGenericRepository<PCPeripheryKeyboardItem> _pcPeripheryKeyboardItemsRepo;
        private readonly IGenericRepository<PCPeripheryMiceItem> _pcPeripheryMiceItemsRepo;
        private readonly IGenericRepository<PCPeripheryWebCamItem> _pcPeripheryWebCamItemsRepo;

        private readonly IGenericRepository<PCAccessoryCPUItem> _pcAccessoryCPUItemsRepo;
        private readonly IGenericRepository<PCAccessoryGPUItem> _pcAccessoryGPUItemsRepo;
        private readonly IGenericRepository<PCAccessoryHDDItem> _pcAccessoryHDDItemsRepo;
        private readonly IGenericRepository<PCAccessoryMotherboardItem> _pcAccessoryMotherboardItemsRepo;
        private readonly IGenericRepository<PCAccessoryRAMItem> _pcAccessoryRAMItemsRepo;
        private readonly IGenericRepository<PCAccessorySSDItem> _pcAccessorySSDItemsRepo;

        private readonly IGenericRepository<PCDisplayItem> _pcDisplayItemsRepo;

        private readonly IGenericRepository<PCPortableEbookItem> _pcPortableEbookItemRepo;
        private readonly IGenericRepository<PCPortableLaptopItem> _pcPortableLaptopItemsRepo;
        private readonly IGenericRepository<PCPortableTabletItem> _pcPortableTabletItemsRepo;

        private readonly IMapper _mapper;

        public ShopController(
         IGenericRepository<ShopCategory> categoriesRepo,
         IGenericRepository<ShopSubcategory> shopSubcategoriesRepo,

        //householdequipment
         IGenericRepository<DishWasherItem> dishWasherItemsRepo,
         IGenericRepository<FreezerItem> freezerItemsRepo,
         IGenericRepository<MicrowaveItem> microwaveItemsRepo,
         IGenericRepository<VacuumCleanerItem> vacuumCleanerItemsRepo,
         IGenericRepository<WasherItem> washerItemsRepo,

        //furniture
         IGenericRepository<BedroomItem> bedroomItemsRepo,
         IGenericRepository<HallwayItem> hallwayItemsRepo,
         IGenericRepository<KitchenItem> kitchenItemsRepo,
         IGenericRepository<OfficeItem> officeItemsRepo,

        //Electronic
         IGenericRepository<BatteriesAndAccumItem> batteriesAndAccumItemsRepo,
         IGenericRepository<HeadphonesItem> headphonesItemsRepo,
         IGenericRepository<SmartphoneItem> smartphoneItemsRepo,
         IGenericRepository<TVItem> tvItemsRepo,

        //Clothes
         IGenericRepository<MenAccessoriesItem> menAccessoriesItemsRepo,
         IGenericRepository<WomenAccessoriesItem> womenAccessoriesItemsRepo,
         IGenericRepository<MenClothesItem> menClothesItemsRepo,
         IGenericRepository<WomenClothesItem> womenClothesItemsRepo,
         IGenericRepository<MenShoesItem> menShoesItemsRepo,
         IGenericRepository<WomenShoesItem> womenShoesItemsRepo,

        //Computer Items
         IGenericRepository<PCPeriphery> peripheriesRepo,
         IGenericRepository<PCAccessory> pcAccessoriesRepo,
         IGenericRepository<PCDisplay> pcDisplaysRepo,
         IGenericRepository<PCPortable> pcPortablesRepo,

         IGenericRepository<PCPeripheryKeyboardItem> pcPeripheryKeyboardItemsRepo,
         IGenericRepository<PCPeripheryMiceItem> pcPeripheryMiceItemsRepo,
         IGenericRepository<PCPeripheryWebCamItem> pcPeripheryWebCamItemsRepo,

         IGenericRepository<PCAccessoryCPUItem> pcAccessoryCPUItemsRepo,
         IGenericRepository<PCAccessoryGPUItem> pcAccessoryGPUItemsRepo,
         IGenericRepository<PCAccessoryHDDItem> pcAccessoryHDDItemsRepo,
         IGenericRepository<PCAccessoryMotherboardItem> pcAccessoryMotherboardItemsRepo,
         IGenericRepository<PCAccessoryRAMItem> pcAccessoryRAMItemsRepo,
         IGenericRepository<PCAccessorySSDItem> pcAccessorySSDItemsRepo,

         IGenericRepository<PCDisplayItem> pcDisplayItemsRepo,

         IGenericRepository<PCPortableEbookItem> pcPortableEbookItemRepo,
         IGenericRepository<PCPortableLaptopItem> pcPortableLaptopItemsRepo,
         IGenericRepository<PCPortableTabletItem> pcPortableTabletItemsRepo,
         IMapper mapper
         )
        {
            _categoriesRepo = categoriesRepo;
            _shopSubcategoriesRepo = shopSubcategoriesRepo;

            //household_equipment
            _dishWasherItemsRepo = dishWasherItemsRepo;
            _freezerItemsRepo = freezerItemsRepo;
            _microwaveItemsRepo = microwaveItemsRepo;
            _vacuumCleanerItemsRepo = vacuumCleanerItemsRepo;
            _washerItemsRepo = washerItemsRepo;

            //furniture
            _bedroomItemsRepo = bedroomItemsRepo;
            _hallwayItemsRepo = hallwayItemsRepo;
            _kitchenItemsRepo = kitchenItemsRepo;
            _officeItemsRepo = officeItemsRepo;

            //Electronic
            _batteriesAndAccumItemsRepo = batteriesAndAccumItemsRepo;
            _headphonesItemsRepo = headphonesItemsRepo;
            _smartphoneItemsRepo = smartphoneItemsRepo;
            _tvItemsRepo = tvItemsRepo;

            //Clothes
            _menAccessoriesItemsRepo = menAccessoriesItemsRepo;
            _womenAccessoriesItemsRepo = womenAccessoriesItemsRepo;
            _menClothesItemsRepo = menClothesItemsRepo;
            _womenClothesItemsRepo = womenClothesItemsRepo;
            _menShoesItemsRepo = menShoesItemsRepo;
            _womenShoesItemsRepo = womenShoesItemsRepo;

            //Computer Items
            _peripheriesRepo = peripheriesRepo;
            _pcAccessoriesRepo = pcAccessoriesRepo;
            _pcDisplaysRepo = pcDisplaysRepo;
            _pcPortablesRepo = pcPortablesRepo;

            _pcPeripheryKeyboardItemsRepo = pcPeripheryKeyboardItemsRepo;
            _pcPeripheryMiceItemsRepo = pcPeripheryMiceItemsRepo;
            _pcPeripheryWebCamItemsRepo = pcPeripheryWebCamItemsRepo;

            _pcAccessoryCPUItemsRepo = pcAccessoryCPUItemsRepo;
            _pcAccessoryGPUItemsRepo = pcAccessoryGPUItemsRepo;
            _pcAccessoryHDDItemsRepo = pcAccessoryHDDItemsRepo;
            _pcAccessoryMotherboardItemsRepo = pcAccessoryMotherboardItemsRepo;
            _pcAccessoryRAMItemsRepo = pcAccessoryRAMItemsRepo;
            _pcAccessorySSDItemsRepo = pcAccessorySSDItemsRepo;

            _pcDisplayItemsRepo = pcDisplayItemsRepo;

            _pcPortableEbookItemRepo = pcPortableEbookItemRepo;
            _pcPortableLaptopItemsRepo = pcPortableLaptopItemsRepo;
            _pcPortableTabletItemsRepo = pcPortableTabletItemsRepo;

            _mapper = mapper;
        }

        [HttpGet]
        [Route("dushwashers")]
        public async Task<ActionResult<Pagination<DishWasherItemToReturnDto>>> GetDishWasherProducts
            ([FromQuery] ItemParams productParams)
        {
            var spec = new DishWasherProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationDishWashers(productParams);

            var totalItems = await _dishWasherItemsRepo.CountAsync(countSpec);

            var products = await _dishWasherItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<DishWasherItem>, IReadOnlyList<DishWasherItemToReturnDto>>(products);

            return Ok(new Pagination<DishWasherItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("dishwashers/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DishWasherItemToReturnDto>> GetDishWasherProduct(int id)
        {
            var spec = new DishWasherProductWithSubcategorySpecification(id);

            var product = await _dishWasherItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<DishWasherItem, DishWasherItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("freezers")]
        public async Task<ActionResult<Pagination<FreezerItemToReturnDto>>> GetFreezerProducts
            ([FromQuery] ItemParams productParams)
        {
            var spec = new FreezerProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationFreezers(productParams);

            var totalItems = await _freezerItemsRepo.CountAsync(countSpec);

            var products = await _freezerItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<FreezerItem>, IReadOnlyList<FreezerItemToReturnDto>>(products);

            return Ok(new Pagination<FreezerItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("freezers/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FreezerItemToReturnDto>> GetFreezerProduct(int id)
        {
            var spec = new FreezerProductWithSubcategorySpecification(id);

            var product = await _freezerItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<FreezerItem, FreezerItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("microwaves")]
        public async Task<ActionResult<Pagination<MicrowaveItemToReturnDto>>> GetMicrowaveProducts
    ([FromQuery] ItemParams productParams)
        {
            var spec = new MicrowaveProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationMicrowaves(productParams);

            var totalItems = await _microwaveItemsRepo.CountAsync(countSpec);

            var products = await _microwaveItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<MicrowaveItem>, IReadOnlyList<MicrowaveItemToReturnDto>>(products);

            return Ok(new Pagination<MicrowaveItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("microwaves/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MicrowaveItemToReturnDto>> GetMicrowaveProduct(int id)
        {
            var spec = new MicrowaveProductWithSubcategorySpecification(id);

            var product = await _microwaveItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<MicrowaveItem, MicrowaveItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("vacuumcleaners")]
        public async Task<ActionResult<Pagination<VacuumCleanerItemToReturnDto>>> GetVacuumCleanerProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new VacuumCleanerProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationVacuumCleaners(productParams);

            var totalItems = await _vacuumCleanerItemsRepo.CountAsync(countSpec);

            var products = await _vacuumCleanerItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<VacuumCleanerItem>, IReadOnlyList<VacuumCleanerItemToReturnDto>>(products);

            return Ok(new Pagination<VacuumCleanerItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("vacuumcleaners/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VacuumCleanerItemToReturnDto>> GetVacuumCleanerProduct(int id)
        {
            var spec = new VacuumCleanerProductWithSubcategorySpecification(id);

            var product = await _vacuumCleanerItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<VacuumCleanerItem, VacuumCleanerItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("washers")]
        public async Task<ActionResult<Pagination<WasherItemToReturnDto>>> GetWasherProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new WasherProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationWasher(productParams);

            var totalItems = await _washerItemsRepo.CountAsync(countSpec);

            var products = await _washerItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<WasherItem>, IReadOnlyList<WasherItemToReturnDto>>(products);

            return Ok(new Pagination<WasherItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("washers/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WasherItemToReturnDto>> GetWasherProduct(int id)
        {
            var spec = new WasherProductWithSubcategorySpecification(id);

            var product = await _washerItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<WasherItem, WasherItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("bedroom")]
        public async Task<ActionResult<Pagination<BedroomItemToReturnDto>>> GetBedRoomProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new BedRoomProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationBedRoom(productParams);

            var totalItems = await _bedroomItemsRepo.CountAsync(countSpec);

            var products = await _bedroomItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<BedroomItem>, IReadOnlyList<BedroomItemToReturnDto>>(products);

            return Ok(new Pagination<BedroomItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("bedroom/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BedroomItemToReturnDto>> GetBedRoomProduct(int id)
        {
            var spec = new BedRoomProductWithSubcategorySpecification(id);

            var product = await _bedroomItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<BedroomItem, BedroomItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("hallway")]
        public async Task<ActionResult<Pagination<HallwayItemToReturnDto>>> GetHallwayProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new HallwayProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationHallway(productParams);

            var totalItems = await _hallwayItemsRepo.CountAsync(countSpec);

            var products = await _hallwayItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<HallwayItem>,
                IReadOnlyList<HallwayItemToReturnDto>>(products);

            return Ok(new Pagination<HallwayItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("hallway/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<HallwayItemToReturnDto>> GetHallwayProduct(int id)
        {
            var spec = new HallwayProductWithSubcategorySpecification(id);

            var product = await _hallwayItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<HallwayItem, HallwayItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("kitchen")]
        public async Task<ActionResult<Pagination<KitchenItemToReturnDto>>> GetKitchenProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new KitchenProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationKitchen(productParams);

            var totalItems = await _kitchenItemsRepo.CountAsync(countSpec);

            var products = await _kitchenItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<KitchenItem>,
                IReadOnlyList<KitchenItemToReturnDto>>(products);

            return Ok(new Pagination<KitchenItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("kitchen/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<KitchenItemToReturnDto>> GetKitchenProduct(int id)
        {
            var spec = new KitchenProductWithSubcategorySpecification(id);

            var product = await _kitchenItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<KitchenItem, KitchenItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("office")]
        public async Task<ActionResult<Pagination<OfficeItemToReturnDto>>> GetOfficeProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new OfficeProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationOffice(productParams);

            var totalItems = await _officeItemsRepo.CountAsync(countSpec);

            var products = await _officeItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<OfficeItem>,
                IReadOnlyList<OfficeItemToReturnDto>>(products);

            return Ok(new Pagination<OfficeItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("office/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<OfficeItemToReturnDto>> GetOfficeProduct(int id)
        {
            var spec = new OfficeProductWithSubcategorySpecification(id);

            var product = await _officeItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<OfficeItem, OfficeItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("batteries")]
        public async Task<ActionResult<Pagination<BatteriesAndAccumItemToReturnDto>>> GetBatteryProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new BatteryProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationBattery(productParams);

            var totalItems = await _batteriesAndAccumItemsRepo.CountAsync(countSpec);

            var products = await _batteriesAndAccumItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<BatteriesAndAccumItem>,
                IReadOnlyList<BatteriesAndAccumItemToReturnDto>>(products);

            return Ok(new Pagination<BatteriesAndAccumItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("batteries/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BatteriesAndAccumItemToReturnDto>> GetBatteryProduct(int id)
        {
            var spec = new BatteryProductWithSubcategorySpecification(id);

            var product = await _batteriesAndAccumItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<BatteriesAndAccumItem, BatteriesAndAccumItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("headphones")]
        public async Task<ActionResult<Pagination<HeadphonesItemToReturnDto>>> GetHeadphoneProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new HeadphoneProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationHeadphone(productParams);

            var totalItems = await _headphonesItemsRepo.CountAsync(countSpec);

            var products = await _headphonesItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<HeadphonesItem>,
                IReadOnlyList<HeadphonesItemToReturnDto>>(products);

            return Ok(new Pagination<HeadphonesItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("headphones/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<HeadphonesItemToReturnDto>> GetHeadphoneProduct(int id)
        {
            var spec = new HeadphoneProductWithSubcategorySpecification(id);

            var product = await _headphonesItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<HeadphonesItem, HeadphonesItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("smartphones")]
        public async Task<ActionResult<Pagination<SmartphoneItemToReturnDto>>> GetSmartphoneProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new SmartphoneProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationSmartphone(productParams);

            var totalItems = await _smartphoneItemsRepo.CountAsync(countSpec);

            var products = await _smartphoneItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<SmartphoneItem>,
                IReadOnlyList<SmartphoneItemToReturnDto>>(products);

            return Ok(new Pagination<SmartphoneItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("smartphones/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<SmartphoneItemToReturnDto>> GetSmartphoneProduct(int id)
        {
            var spec = new SmartphoneProductWithSubcategorySpecification(id);

            var product = await _smartphoneItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<SmartphoneItem, SmartphoneItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("TV")]
        public async Task<ActionResult<Pagination<TVItemToReturnDto>>> GetTVProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new TVProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationTV(productParams);

            var totalItems = await _tvItemsRepo.CountAsync(countSpec);

            var products = await _tvItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<TVItem>,
                IReadOnlyList<TVItemToReturnDto>>(products);

            return Ok(new Pagination<TVItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("TV/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TVItemToReturnDto>> GetTVProduct(int id)
        {
            var spec = new TVProductWithSubcategorySpecification(id);

            var product = await _tvItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<TVItem, TVItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("menaccessories")]
        public async Task<ActionResult<Pagination<MenAccessoriesItemToReturnDto>>> GetMenAccessoriesProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new MenAccessoriesProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationMenAccessories(productParams);

            var totalItems = await _menAccessoriesItemsRepo.CountAsync(countSpec);

            var products = await _menAccessoriesItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<MenAccessoriesItem>,
                IReadOnlyList<MenAccessoriesItemToReturnDto>>(products);

            return Ok(new Pagination<MenAccessoriesItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("menaccessories/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MenAccessoriesItemToReturnDto>> GetMenAccessoriesProduct(int id)
        {
            var spec = new MenAccessoriesProductWithSubcategorySpecification(id);

            var product = await _menAccessoriesItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<MenAccessoriesItem, MenAccessoriesItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("womenaccessories")]
        public async Task<ActionResult<Pagination<WomenAccessoriesItemToReturnDto>>> GetWomenAccessoriesProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new WomenAccessoriesProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationWomenAccessories(productParams);

            var totalItems = await _womenAccessoriesItemsRepo.CountAsync(countSpec);

            var products = await _womenAccessoriesItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<WomenAccessoriesItem>,
                IReadOnlyList<WomenAccessoriesItemToReturnDto>>(products);

            return Ok(new Pagination<WomenAccessoriesItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("womenaccessories/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WomenAccessoriesItemToReturnDto>> GetWomenAccessoriesProduct(int id)
        {
            var spec = new WomenAccessoriesProductWithSubcategorySpecification(id);

            var product = await _womenAccessoriesItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<WomenAccessoriesItem, WomenAccessoriesItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("menclothes")]
        public async Task<ActionResult<Pagination<MenClothesItemToReturnDto>>> GetMenClothesProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new MenClothesProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationMenClothes(productParams);

            var totalItems = await _menClothesItemsRepo.CountAsync(countSpec);

            var products = await _menClothesItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<MenClothesItem>,
                IReadOnlyList<MenClothesItemToReturnDto>>(products);

            return Ok(new Pagination<MenClothesItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("menclothes/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MenClothesItemToReturnDto>> GetMenClothesProduct(int id)
        {
            var spec = new MenClothesProductWithSubcategorySpecification(id);

            var product = await _menClothesItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<MenClothesItem, MenClothesItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("womenclothes")]
        public async Task<ActionResult<Pagination<WomenClothesItemToReturnDto>>> GetWomenClothesProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new WomenClothesProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationWomenClothes(productParams);

            var totalItems = await _womenClothesItemsRepo.CountAsync(countSpec);

            var products = await _womenClothesItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<WomenClothesItem>,
                IReadOnlyList<WomenClothesItemToReturnDto>>(products);

            return Ok(new Pagination<WomenClothesItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("womenclothes/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WomenClothesItemToReturnDto>> GetWomenClothesProduct(int id)
        {
            var spec = new WomenClothesProductWithSubcategorySpecification(id);

            var product = await _womenClothesItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<WomenClothesItem, WomenClothesItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("menshoes")]
        public async Task<ActionResult<Pagination<MenShoesItemToReturnDto>>> GetMenShoesProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new MenShoesProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationMenShoes(productParams);

            var totalItems = await _menShoesItemsRepo.CountAsync(countSpec);

            var products = await _menShoesItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<MenShoesItem>,
                IReadOnlyList<MenShoesItemToReturnDto>>(products);

            return Ok(new Pagination<MenShoesItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("menshoes/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MenShoesItemToReturnDto>> GetMenShoesProduct(int id)
        {
            var spec = new MenShoesProductWithSubcategorySpecification(id);

            var product = await _menShoesItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<MenShoesItem, MenShoesItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("WomenShoes")]
        public async Task<ActionResult<Pagination<WomenShoesItemToReturnDto>>> GetWomenShoesProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new WomenShoesProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationWomenShoes(productParams);

            var totalItems = await _womenShoesItemsRepo.CountAsync(countSpec);

            var products = await _womenShoesItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<WomenShoesItem>,
                IReadOnlyList<WomenShoesItemToReturnDto>>(products);

            return Ok(new Pagination<WomenShoesItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("WomenShoes/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WomenShoesItemToReturnDto>> GetWomenShoesProduct(int id)
        {
            var spec = new WomenShoesProductWithSubcategorySpecification(id);

            var product = await _womenShoesItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<WomenShoesItem, WomenShoesItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCPeripheryWebCamItem")]
        public async Task<ActionResult<Pagination<PCPeripheryWebCamItemToReturnDto>>> GetPCPeripheryWebCamProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCPeripheryWebCamProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCPeripheryWebCam(productParams);

            var totalItems = await _pcPeripheryWebCamItemsRepo.CountAsync(countSpec);

            var products = await _pcPeripheryWebCamItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCPeripheryWebCamItem>,
                IReadOnlyList<PCPeripheryWebCamItemToReturnDto>>(products);

            return Ok(new Pagination<PCPeripheryWebCamItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCPeripheryWebCamItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCPeripheryWebCamItemToReturnDto>> GetPCPeripheryWebCamProduct(int id)
        {
            var spec = new PCPeripheryWebCamProductWithSubcategorySpecification(id);

            var product = await _pcPeripheryWebCamItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCPeripheryWebCamItem, PCPeripheryWebCamItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCPeripheryMiceItem")]
        public async Task<ActionResult<Pagination<PCPeripheryMiceItemToReturnDto>>> GetPCPeripheryMiceItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCPeripheryMiceItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCPeripheryMiceItem(productParams);

            var totalItems = await _pcPeripheryMiceItemsRepo.CountAsync(countSpec);

            var products = await _pcPeripheryMiceItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCPeripheryMiceItem>,
                IReadOnlyList<PCPeripheryMiceItemToReturnDto>>(products);

            return Ok(new Pagination<PCPeripheryMiceItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCPeripheryMiceItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCPeripheryMiceItemToReturnDto>> GetPCPeripheryMiceItemProduct(int id)
        {
            var spec = new PCPeripheryMiceItemProductWithSubcategorySpecification(id);

            var product = await _pcPeripheryMiceItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCPeripheryMiceItem, PCPeripheryMiceItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCPeripheryKeyboardItem")]
        public async Task<ActionResult<Pagination<PCPeripheryKeyboardItemToReturnDto>>> GetPCPeripheryKeyboardItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCPeripheryKeyboardItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCPeripheryKeyboardItem(productParams);

            var totalItems = await _pcPeripheryKeyboardItemsRepo.CountAsync(countSpec);

            var products = await _pcPeripheryKeyboardItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCPeripheryKeyboardItem>,
                IReadOnlyList<PCPeripheryKeyboardItemToReturnDto>>(products);

            return Ok(new Pagination<PCPeripheryKeyboardItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCPeripheryKeyboardItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCPeripheryKeyboardItemToReturnDto>> GetPCPeripheryKeyboardItemProduct(int id)
        {
            var spec = new PCPeripheryKeyboardItemProductWithSubcategorySpecification(id);

            var product = await _pcPeripheryKeyboardItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCPeripheryKeyboardItem, PCPeripheryKeyboardItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCAccessoryCPUItem")]
        public async Task<ActionResult<Pagination<PCAccessoryCPUItemToReturnDto>>> GetPCAccessoryCPUItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCAccessoryCPUItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCAccessoryCPUItem(productParams);

            var totalItems = await _pcAccessoryCPUItemsRepo.CountAsync(countSpec);

            var products = await _pcAccessoryCPUItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCAccessoryCPUItem>,
                IReadOnlyList<PCAccessoryCPUItemToReturnDto>>(products);

            return Ok(new Pagination<PCAccessoryCPUItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCAccessoryCPUItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCAccessoryCPUItemToReturnDto>> GetPCAccessoryCPUItemProduct(int id)
        {
            var spec = new PCAccessoryCPUItemProductWithSubcategorySpecification(id);

            var product = await _pcAccessoryCPUItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCAccessoryCPUItem, PCAccessoryCPUItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCAccessoryGPUItem")]
        public async Task<ActionResult<Pagination<PCAccessoryGPUItemToReturnDto>>> GetPCAccessoryGPUItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCAccessoryGPUItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCAccessoryGPUItem(productParams);

            var totalItems = await _pcAccessoryGPUItemsRepo.CountAsync(countSpec);

            var products = await _pcAccessoryGPUItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCAccessoryGPUItem>,
                IReadOnlyList<PCAccessoryGPUItemToReturnDto>>(products);

            return Ok(new Pagination<PCAccessoryGPUItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCAccessoryGPUItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCAccessoryGPUItemToReturnDto>> GetPCAccessoryGPUItemProduct(int id)
        {
            var spec = new PCAccessoryGPUItemProductWithSubcategorySpecification(id);

            var product = await _pcAccessoryGPUItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCAccessoryGPUItem, PCAccessoryGPUItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCAccessoryHDDItem")]
        public async Task<ActionResult<Pagination<PCAccessoryHDDItemToReturnDto>>> GetPCAccessoryHDDItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCAccessoryHDDItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCAccessoryHDDItem(productParams);

            var totalItems = await _pcAccessoryHDDItemsRepo.CountAsync(countSpec);

            var products = await _pcAccessoryHDDItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCAccessoryHDDItem>,
                IReadOnlyList<PCAccessoryHDDItemToReturnDto>>(products);

            return Ok(new Pagination<PCAccessoryHDDItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCAccessoryHDDItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCAccessoryHDDItemToReturnDto>> GetPCAccessoryHDDItemProduct(int id)
        {
            var spec = new PCAccessoryHDDItemProductWithSubcategorySpecification(id);

            var product = await _pcAccessoryHDDItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCAccessoryHDDItem, PCAccessoryHDDItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCAccessoryMotherboardItem")]
        public async Task<ActionResult<Pagination<PCAccessoryMotherboardItemToReturnDto>>> GetPCAccessoryMotherboardItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCAccessoryMotherboardItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCAccessoryMotherboardItem(productParams);

            var totalItems = await _pcAccessoryMotherboardItemsRepo.CountAsync(countSpec);

            var products = await _pcAccessoryMotherboardItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCAccessoryMotherboardItem>,
                IReadOnlyList<PCAccessoryMotherboardItemToReturnDto>>(products);

            return Ok(new Pagination<PCAccessoryMotherboardItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCAccessoryMotherboardItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCAccessoryMotherboardItemToReturnDto>> GetPCAccessoryMotherboardItemProduct(int id)
        {
            var spec = new PCAccessoryMotherboardItemProductWithSubcategorySpecification(id);

            var product = await _pcAccessoryMotherboardItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCAccessoryMotherboardItem, PCAccessoryMotherboardItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCAccessoryRAMItem")]
        public async Task<ActionResult<Pagination<PCAccessoryRAMItemToReturnDto>>> GetPCAccessoryRAMItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCAccessoryRAMItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCAccessoryRAMItem(productParams);

            var totalItems = await _pcAccessoryRAMItemsRepo.CountAsync(countSpec);

            var products = await _pcAccessoryRAMItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCAccessoryRAMItem>,
                IReadOnlyList<PCAccessoryRAMItemToReturnDto>>(products);

            return Ok(new Pagination<PCAccessoryRAMItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCAccessoryRAMItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCAccessoryRAMItemToReturnDto>> GetPCAccessoryRAMItemProduct(int id)
        {
            var spec = new PCAccessoryRAMItemProductWithSubcategorySpecification(id);

            var product = await _pcAccessoryRAMItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCAccessoryRAMItem, PCAccessoryRAMItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCAccessorySSDItem")]
        public async Task<ActionResult<Pagination<PCAccessorySSDItemToReturnDto>>> GetPCAccessorySSDItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCAccessorySSDItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCAccessorySSDItem(productParams);

            var totalItems = await _pcAccessorySSDItemsRepo.CountAsync(countSpec);

            var products = await _pcAccessorySSDItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCAccessorySSDItem>,
                IReadOnlyList<PCAccessorySSDItemToReturnDto>>(products);

            return Ok(new Pagination<PCAccessorySSDItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCAccessorySSDItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCAccessorySSDItemToReturnDto>> GetPCAccessorySSDItemProduct(int id)
        {
            var spec = new PCAccessorySSDItemProductWithSubcategorySpecification(id);

            var product = await _pcAccessorySSDItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCAccessorySSDItem, PCAccessorySSDItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCDisplayItem")]
        public async Task<ActionResult<Pagination<PCDisplayItemToReturnDto>>> GetPCDisplayItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCDisplayItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCDisplayItem(productParams);

            var totalItems = await _pcDisplayItemsRepo.CountAsync(countSpec);

            var products = await _pcDisplayItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCDisplayItem>,
                IReadOnlyList<PCDisplayItemToReturnDto>>(products);

            return Ok(new Pagination<PCDisplayItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCDisplayItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCDisplayItemToReturnDto>> GetPCDisplayItemProduct(int id)
        {
            var spec = new PCDisplayItemProductWithSubcategorySpecification(id);

            var product = await _pcDisplayItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCDisplayItem, PCDisplayItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCPortableEbookItem")]
        public async Task<ActionResult<Pagination<PCPortableEbookItemToReturnDto>>> GetPCPortableEbookItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCPortableEbookItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCPortableEbookItem(productParams);

            var totalItems = await _pcPortableEbookItemRepo.CountAsync(countSpec);

            var products = await _pcPortableEbookItemRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCPortableEbookItem>,
                IReadOnlyList<PCPortableEbookItemToReturnDto>>(products);

            return Ok(new Pagination<PCPortableEbookItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCPortableEbookItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCPortableEbookItemToReturnDto>> GetPCPortableEbookItemProduct(int id)
        {
            var spec = new PCPortableEbookItemProductWithSubcategorySpecification(id);

            var product = await _pcPortableEbookItemRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCPortableEbookItem, PCPortableEbookItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCPortableLaptopItem")]
        public async Task<ActionResult<Pagination<PCPortableLaptopItemToReturnDto>>> GetPCPortableLaptopItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCPortableLaptopItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCPortableLaptopItem(productParams);

            var totalItems = await _pcPortableLaptopItemsRepo.CountAsync(countSpec);

            var products = await _pcPortableLaptopItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCPortableLaptopItem>,
                IReadOnlyList<PCPortableLaptopItemToReturnDto>>(products);

            return Ok(new Pagination<PCPortableLaptopItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCPortableLaptopItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCPortableLaptopItemToReturnDto>> GetPCPortableLaptopItemProduct(int id)
        {
            var spec = new PCPortableLaptopItemProductWithSubcategorySpecification(id);

            var product = await _pcPortableLaptopItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCPortableLaptopItem, PCPortableLaptopItemToReturnDto>(product);
        }

        [HttpGet]
        [Route("PCPortableTabletItem")]
        public async Task<ActionResult<Pagination<PCPortableTabletItemToReturnDto>>> GetPCPortableTabletItemProducts
([FromQuery] ItemParams productParams)
        {
            var spec = new PCPortableTabletItemProductWithSubcategorySpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificationPCPortableTabletItem(productParams);

            var totalItems = await _pcPortableTabletItemsRepo.CountAsync(countSpec);

            var products = await _pcPortableTabletItemsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyCollection<PCPortableTabletItem>,
                IReadOnlyList<PCPortableTabletItemToReturnDto>>(products);

            return Ok(new Pagination<PCPortableTabletItemToReturnDto>(productParams.PageIndex, productParams.PageSize,
                totalItems, data));
        }

        [HttpGet("PCPortableTabletItem/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PCPortableTabletItemToReturnDto>> GetPCPortableTabletItemProducts(int id)
        {
            var spec = new PCPortableTabletItemProductWithSubcategorySpecification(id);

            var product = await _pcPortableTabletItemsRepo.GetEntityWithSpec(spec);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return _mapper.Map<PCPortableTabletItem, PCPortableTabletItemToReturnDto>(product);
        }
    }
}