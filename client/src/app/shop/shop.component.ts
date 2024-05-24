import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { IProduct, IShopProduct } from '../shared/models/product';
import { ShopService } from './shop.service';
import { IBrand } from '../shared/models/brand';
import { IType } from '../shared/models/productType';
import { ShopParams } from '../shared/models/shopParams';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})

export class ShopComponent implements OnInit {
  @ViewChild('search', { static: false }) searchTerm: ElementRef;
  products: IProduct[];
  shopProducts: IShopProduct[];
  brands: IBrand[];
  types: IType[];
  shopParams = new ShopParams();
  totalCount: number;
  sortOption = [
    { name: 'Alphabetical', value: 'name' },
    { name: 'Price: Low to High', value: 'priceAsc' },
    { name: 'Price: High to Low', value: 'priceDesc' }
  ];


  constructor(private shopService: ShopService) {

  }

  getValue(event: Event): string {
    return (event.target as HTMLInputElement).value;
  }

  ngOnInit() {

  }

  getShopProductsPCDisplays() {
    this.shopService.getShopProductsPCDisplays(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsSmartphones() {
    this.shopService.getShopProductsSmartphones(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsTV() {
    this.shopService.getShopProductsTV(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsHeadphones() {
    this.shopService.getShopProductsHeadphones(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsBatteriesAndAccums() {
    this.shopService.getShopProductsBatteriesAndAccums(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsDishWashers() {
    this.shopService.getShopProductsDishWashers(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsMicrowaves() {
    this.shopService.getShopProductsMicrowaves(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsFreezers() {
    this.shopService.getShopProductsFreezers(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsVacuumCleaners() {
    this.shopService.getShopProductsVacuumCleaners(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsWashers() {
    this.shopService.getShopProductsWashers(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsBedroom() {
    this.shopService.getShopProductsBedroom(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsHallway() {
    this.shopService.getShopProductsHallway(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsKitchen() {
    this.shopService.getShopProductsKitchen(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsOffice() {
    this.shopService.getShopProductsOffice(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsMenClothes() {
    this.shopService.getShopProductsMenClothes(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsWomenClothes() {
    this.shopService.getShopProductsWomenClothes(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsMenAccessories() {
    this.shopService.getShopProductsMenAccessories(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsWomenAccessories() {
    this.shopService.getShopProductsMenAccessories(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsMenShoes() {
    this.shopService.getShopProductsMenShoes(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsWomenShoes() {
    this.shopService.getShopProductsWomenShoes(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsCPU() {
    this.shopService.getShopProductsCPU(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsGPU() {
    this.shopService.getShopProductsGPU(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsHDD() {
    this.shopService.getShopProductsHDD(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsMotherboards() {
    this.shopService.getShopProductsMotherboards(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsRAM() {
    this.shopService.getShopProductsRAM(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsSSD() {
    this.shopService.getShopProductsSSD(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsKeyboards() {
    this.shopService.getShopProductsKeyboards(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsMice() {
    this.shopService.getShopProductsMice(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsWebCams() {
    this.shopService.getShopProductsWebCams(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsEbooks() {
    this.shopService.getShopProductsEbooks(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsLaptops() {
    this.shopService.getShopProductsLaptops(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  getShopProductsTablets() {
    this.shopService.getShopProductsTablets(this.shopParams)
      .subscribe(response => {
        this.shopProducts = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
        console.log(response)
      }, error => {
        console.log(error);
      });
  }

  onPageChanged(event: any) {
    if (this.shopParams.pageNumber !== event) {

      this.shopParams.pageNumber = event;

      if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "PC_Displays") {
        this.getShopProductsPCDisplays()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "Tablets") {
        this.getShopProductsLaptops()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "Laptops") {
        this.getShopProductsLaptops()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "Ebooks") {
        this.getShopProductsEbooks()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "Web_cams") {
        this.getShopProductsWebCams()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "Mice") {
        this.getShopProductsMice()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "Keyboards") {
        this.getShopProductsKeyboards()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "RAM") {
        this.getShopProductsRAM()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "SSD") {
        this.getShopProductsSSD()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "CPU") {
        this.getShopProductsCPU()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "Motherboards") {
        this.getShopProductsMotherboards()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "HDD") {
        this.getShopProductsHDD()
      }
      else if (this.shopProducts[0].shopSubsubcategoryName 
        && this.shopProducts[0].shopSubsubcategoryName === "GPU") {
        this.getShopProductsGPU()
      }
      else if (this.shopProducts[0].shopSubcategoryName 
        && this.shopProducts[0].shopSubcategoryName === "Smartphones") {
        this.getShopProductsSmartphones()
      }
      else if (this.shopProducts[0].shopSubcategoryName 
        && this.shopProducts[0].shopSubcategoryName === "TV") {
        this.getShopProductsTV()
      }
      else if (this.shopProducts[0].shopSubcategoryName 
        && this.shopProducts[0].shopSubcategoryName === "Headphones") {
        this.getShopProductsHeadphones()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Batteries_and_accumulators") {
        this.getShopProductsBatteriesAndAccums()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Dishwashers") {
        this.getShopProductsDishWashers()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Microwaves") {
        this.getShopProductsMicrowaves()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Freezers") {
        this.getShopProductsFreezers()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Vacuum_cleaners") {
        this.getShopProductsVacuumCleaners()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Washers") {
        this.getShopProductsWashers()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Bedroom") {
        this.getShopProductsBedroom()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Hallway") {
        this.getShopProductsHallway()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Kitchen") {
        this.getShopProductsKitchen()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Office") {
        this.getShopProductsOffice()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Men_clothes") {
        this.getShopProductsMenClothes()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Women_clothes") {
        this.getShopProductsWomenClothes()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Men_accessories") {
        this.getShopProductsMenAccessories()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Women_accessories") {
        this.getShopProductsWomenAccessories()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Men_shoes") {
        this.getShopProductsMenShoes()
      }
      else if (this.shopProducts[0].shopSubcategoryName &&
        this.shopProducts[0].shopSubcategoryName === "Women_shoes") {
        this.getShopProductsWomenShoes()
      }
    }
  }

  getProducts() {
    this.shopService.getProducts(this.shopParams)
      .subscribe(response => {
        this.products = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
      }, error => {
        console.log(error);
      });
  }

  getBrands() {
    this.shopService.getBrands().subscribe(response => {
      this.brands = [{ id: 0, name: 'All' }, ...response];
    }, error => {
      console.log(error);
    });
  }

  getTypes() {
    this.shopService.getTypes().subscribe(response => {
      this.types = [{ id: 0, name: 'All' }, ...response];
    }, error => {
      console.log(error);
    });
  }

  onBrandSelected(brandId: number) {
    this.shopParams.brandId = brandId;
    this.shopParams.pageNumber = 1;
    this.getProducts();
  }

  onTypeSelected(typeId: number) {
    this.shopParams.typeId = typeId;
    this.shopParams.pageNumber = 1;
    this.getProducts();
  }

  onSortSelected(sort: string) {
    this.shopParams.sort = sort;
    this.getShopProducts();
  }

  onSearch() {
    this.shopParams.search = this.searchTerm.nativeElement.value;
    this.shopParams.pageNumber = 1;
    this.getShopProducts();
  }

  onReset() {
    this.shopParams.search = undefined;
    this.shopParams = new ShopParams();
    this.searchTerm.nativeElement.value = '';
    this.getShopProducts();
  }

  getShopProducts() {
    if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "PC_Displays") {
      this.getShopProductsPCDisplays()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "Tablets") {
      this.getShopProductsLaptops()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "Laptops") {
      this.getShopProductsLaptops()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "Ebooks") {
      this.getShopProductsEbooks()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "Web_cams") {
      this.getShopProductsWebCams()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "Mice") {
      this.getShopProductsMice()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "Keyboards") {
      this.getShopProductsKeyboards()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "RAM") {
      this.getShopProductsRAM()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "SSD") {
      this.getShopProductsSSD()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "CPU") {
      this.getShopProductsCPU()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "Motherboards") {
      this.getShopProductsMotherboards()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "HDD") {
      this.getShopProductsHDD()
    }
    else if (this.shopProducts[0].shopSubsubcategoryName 
      && this.shopProducts[0].shopSubsubcategoryName === "GPU") {
      this.getShopProductsGPU()
    }
    else if (this.shopProducts[0].shopSubcategoryName 
      && this.shopProducts[0].shopSubcategoryName === "Smartphones") {
      this.getShopProductsSmartphones()
    }
    else if (this.shopProducts[0].shopSubcategoryName 
      && this.shopProducts[0].shopSubcategoryName === "TV") {
      this.getShopProductsTV()
    }
    else if (this.shopProducts[0].shopSubcategoryName 
      && this.shopProducts[0].shopSubcategoryName === "Headphones") {
      this.getShopProductsHeadphones()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Batteries_and_accumulators") {
      this.getShopProductsBatteriesAndAccums()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Dishwashers") {
      this.getShopProductsDishWashers()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Microwaves") {
      this.getShopProductsMicrowaves()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Freezers") {
      this.getShopProductsFreezers()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Vacuum_cleaners") {
      this.getShopProductsVacuumCleaners()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Washers") {
      this.getShopProductsWashers()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Bedroom") {
      this.getShopProductsBedroom()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Hallway") {
      this.getShopProductsHallway()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Kitchen") {
      this.getShopProductsKitchen()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Office") {
      this.getShopProductsOffice()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Men_clothes") {
      this.getShopProductsMenClothes()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Women_clothes") {
      this.getShopProductsWomenClothes()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Men_accessories") {
      this.getShopProductsMenAccessories()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Women_accessories") {
      this.getShopProductsWomenAccessories()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Men_shoes") {
      this.getShopProductsMenShoes()
    }
    else if (this.shopProducts[0].shopSubcategoryName &&
      this.shopProducts[0].shopSubcategoryName === "Women_shoes") {
      this.getShopProductsWomenShoes()
    }
  }
}