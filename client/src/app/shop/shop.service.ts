import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IPagination, IShopPagination } from '../shared/models/pagination';
import { IBrand } from '../shared/models/brand';
import { IType } from '../shared/models/productType';
import { map } from 'rxjs/operators';
import { ShopParams } from '../shared/models/shopParams';
import { IProduct, IShopProduct } from '../shared/models/product';

@Injectable({
  providedIn: 'root'
})

export class ShopService {
  baseUrl = 'https://localhost:5206/API/';
  baseUrl2 = 'https://localhost:5206/API/Shop/';

  constructor(private http: HttpClient) {

  }

  getShopProductsPCDisplays(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCDisplayItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsSmartphones(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/smartphones', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsTV(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/TV', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsHeadphones(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/headphones', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsBatteriesAndAccums(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/batteries', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsDishWashers(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/dushwashers', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsMicrowaves(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/microwaves', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsFreezers(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/freezers', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsVacuumCleaners(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/vacuumcleaners', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsWashers(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/washers', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsBedroom(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/bedroom', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsHallway(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/hallway', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsKitchen(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/kitchen', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsOffice(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/office', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsMenClothes(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/menclothes', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsWomenClothes(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/womenclothes', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsMenAccessories(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/menaccessories', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsWomenAccessories(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/womenaccessories', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsMenShoes(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/menshoes', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsWomenShoes(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/womenshoes', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsCPU(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCAccessoryCPUItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsGPU(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCAccessoryGPUItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsHDD(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCAccessoryHDDItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsMotherboards(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCAccessoryMotherboardItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsRAM(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCAccessoryMotherboardItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsSSD(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCAccessorySSDItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsKeyboards(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCPeripheryKeyboardItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsMice(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCPeripheryMiceItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsWebCams(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCPeripheryWebCamItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsEbooks(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCPortableEbookItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsLaptops(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCPortableLaptopItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getShopProductsTablets(shopParams: ShopParams) {
    let params = new HttpParams();
    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IShopPagination>(this.baseUrl + 'Shop/PCPortableTabletItem', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }


  //ПОЛУЧЕНИЕ ЕДИНИЧНОГО ТОВАРА
  getShopProductsPCDisplay(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCDisplayItem/' + id);
  }

  getShopProductsSmartphone(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/smartphones/' + id);
  }

  getShopProductsTVItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/TV/' + id);
  }

  getShopProductsHeadphone(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/headphones/' + id);
  }

  getShopProductsBatteriesAndAccum(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/batteries/' + id);
  }

  getShopProductsDishWasher(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/dushwashers/' + id);
  }

  getShopProductsMicrowave(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/microwaves/' + id);
  }

  getShopProductsFreezer(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/freezers/' + id);
  }

  getShopProductsVacuumCleaner(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/vacuumcleaners/' + id);
  }

  getShopProductsWasher(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/washers/' + id);
  }

  getShopProductsBedroomItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/bedroom/' + id);
  }

  getShopProductsHallwayItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/hallway/' + id);
  }

  getShopProductsKitchenItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/kitchen/' + id);
  }

  getShopProductsOfficeItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/office/' + id);
  }

  getShopProductsMenClothesItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/menclothes/' + id);
  }

  getShopProductsWomenClothesItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/womenclothes/' + id);
  }

  getShopProductsMenAccessoriesItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/menaccessories/' + id);
  }

  getShopProductsWomenAccessoriesItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/womenaccessories/' + id);
  }

  getShopProductsMenShoesItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/menshoes/' + id);
  }

  getShopProductsWomenShoesItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/womenshoes/' + id);
  }

  getShopProductsCPUItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCAccessoryCPUItem/' + id);
  }

  getShopProductsGPUItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCAccessoryGPUItem/' + id);
  }

  getShopProductsHDDItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCAccessoryHDDItem/' + id);
  }

  getShopProductsMotherboardsItem(id: number) {
        return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCAccessoryMotherboardItem/' + id);
  }

  getShopProductsRAMItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCAccessoryRAMItem/' + id);
  }

  getShopProductsSSDItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCAccessorySSDItem/' + id);
  }

  getShopProductsKeyboardsItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCPeripheryKeyboardItem/' + id);
  }

  getShopProductsMiceItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCPeripheryMiceItem/' + id);
  }

  getShopProductsWebCamsItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCPeripheryWebCamItem/' + id);
  }

  getShopProductsEbooksItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCPortableEbookItem/' + id);
  }

  getShopProductsLaptopsItem(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCPortableLaptopItem/' + id);
  }

  getShopProductsTablet(id: number) {
    return this.http.get<IShopProduct>(this.baseUrl + 'Shop/PCPortableTabletItem/' + id);
  }

  getShopProduct(path: string, id: string) {
    let newPath = path.replace(':id', id);
    return this.http.get<IShopProduct>(this.baseUrl2 + newPath);
  }
//КОНЕЦ 


  getProducts(shopParams: ShopParams) {
    let params = new HttpParams();

    if (shopParams.brandId !== 0) {
      params = params.append('brandId', shopParams.brandId.toString());
    }

    if (shopParams.typeId !== 0) {
      params = params.append('typeId', shopParams.typeId.toString());
    }

    if (shopParams.search) {
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageNumber.toString());
    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IPagination>(this.baseUrl + 'products', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body
        })
      );
  }

  getProduct(id: number) {
    return this.http.get<IProduct>(this.baseUrl + 'products/' + id);
  }

  getBrands() {
    return this.http.get<IBrand[]>(this.baseUrl + 'products/brands')
  }

  getTypes() {
    return this.http.get<IType[]>(this.baseUrl + 'products/types')
  }
}
