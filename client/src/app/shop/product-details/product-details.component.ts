import { Component, OnInit } from '@angular/core';
import { IProduct, IShopProduct} from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';
import { ActivatedRoute } from '@angular/router';
import { BreadcrumbService } from 'xng-breadcrumb';
import { BasketService } from 'src/app/basket/basket.service';
import { environment } from 'src/environments/environment.development';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
  aspNetCoreServerURL = environment.aspNetCoreServerURL;

  product: IProduct;
  shopProduct: IShopProduct;
  quantity = 1;

  constructor(private shopService: ShopService, private activateRoute: ActivatedRoute,
    private bcService: BreadcrumbService, private basketService: BasketService) {
    this.bcService.set('@productDetails', ' ');
  }

  ngOnInit(): void {
    this.loadProduct();
  }

  addItemToBasket() {
    this.basketService.addItemToBasket(this.shopProduct, this.quantity);
  }

  incrementQuantity() {
    this.quantity++;
  }

  decrementQantity() {
    if (this.quantity > 1) {
      this.quantity--;
    }
  }

  loadProduct() {
    let currentPath = this.activateRoute.snapshot.routeConfig.path;
    let currentIdParam = this.activateRoute.snapshot.paramMap.get('id');
    this.shopService.getShopProduct(currentPath, currentIdParam).subscribe(shopProduct => {
      this.shopProduct = shopProduct;
      this.bcService.set('@productDetails', shopProduct.name);
    }, error => {
      console.log(error);
    });
  }
}
