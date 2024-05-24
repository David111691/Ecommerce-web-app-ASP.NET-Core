import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router'
import { ShopComponent } from './shop.component';
import { ProductDetailsComponent } from './product-details/product-details.component';

const routes: Routes = [  
  {path:'', component: ShopComponent},
  {path:':id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCDisplayItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'smartphones/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'TV/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'headphones/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'batteries/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'dushwashers/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'microwaves/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'freezers/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'vacuumcleaners/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'washers/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'bedroom/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'hallway/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'kitchen/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'office/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'menclothes/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'womenclothes/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'menaccessories/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'womenaccessories/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'menshoes/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'womenshoes/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCAccessoryCPUItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCAccessoryGPUItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCAccessoryHDDItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCAccessoryMotherboardItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCAccessorySSDItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCPeripheryKeyboardItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCPeripheryMiceItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCPeripheryWebCamItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCPortableEbookItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCPortableLaptopItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCPortableTabletItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}},
  {path:'PCAccessoryRAMItem/:id', component: ProductDetailsComponent, data: {breadcrumb: {alias: 'productDetails'}}}
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})
export class ShopRoutingModule { }
