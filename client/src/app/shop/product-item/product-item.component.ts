import { Component, Input } from '@angular/core';
import { BasketService } from 'src/app/basket/basket.service';
import { IProduct, IShopProduct } from 'src/app/shared/models/product';
import { environment } from 'src/environments/environment.development';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.scss']
})

export class ProductItemComponent {
  @Input() product: IProduct;
  @Input() shopProduct: IShopProduct;

  environment = environment;

  constructor(private basketService: BasketService) { }

  addItemToBasket() {
    this.basketService.addItemToBasket(this.shopProduct);
  }

  getShopProductRoutePath() {
    if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "PC_Displays") {
        return 'PCDisplayItem/' + this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "Tablets") {
        return 'PCPortableTabletItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "Laptops") {
        return 'PCPortableLaptopItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "Ebooks") {
        return 'PCPortableEbookItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "Web_cams") {
        return 'PCPeripheryWebCamItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "Mice") {
        return 'PCPeripheryMiceItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "Keyboards") {
        return 'PCPeripheryKeyboardItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "RAM") {
        return 'PCAccessoryRAMItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "SSD") {
        return 'PCAccessorySSDItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "CPU") {
        return 'PCAccessoryCPUItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "Motherboards") {
        return 'PCAccessoryMotherboardItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "HDD") {
        return 'PCAccessoryHDDItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubsubcategoryName 
      && this.shopProduct.shopSubsubcategoryName === "GPU") {
        return 'PCAccessoryGPUItem/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName 
      && this.shopProduct.shopSubcategoryName === "Smartphones") {
        return 'smartphones/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName 
      && this.shopProduct.shopSubcategoryName === "TV") {
        return 'TV/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName 
      && this.shopProduct.shopSubcategoryName === "Headphones") {
        return 'headphones/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Batteries_and_accumulators") {
        return 'batteries/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Dishwashers") {
        return 'dushwashers/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Microwaves") {
        return 'microwaves/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Freezers") {
        return 'freezers/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Vacuum_cleaners") {
        return 'vacuumcleaners/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Washers") {
        return 'washers/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Bedroom") {
        return 'bedroom/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Hallway") {
        return 'hallway/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Kitchen") {
        return 'kitchen/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Office") {
        return 'office/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Men_clothes") {
        return 'menclothes/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Women_clothes") {
        return 'womenclothes/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Men_accessories") {
        return 'menaccessories/'+ this.shopProduct.id.toString();    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Women_accessories") {
        return 'womenaccessories/'+ this.shopProduct.id.toString();
    }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Men_shoes") {
        return 'menshoes/'+ this.shopProduct.id.toString(); }
    else if (this.shopProduct.shopSubcategoryName &&
      this.shopProduct.shopSubcategoryName === "Women_shoes") {
        return 'womenshoes/'+ this.shopProduct.id.toString();
    }
  }
}
