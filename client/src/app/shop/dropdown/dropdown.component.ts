import { Component } from '@angular/core';
import { ShopComponent } from '../shop.component';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';

@Component({
  selector: 'app-dropdown',
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.scss']
})
export class DropdownComponent {
  isFirstMenuActive = false;
  isSecondMenuActive = false;
  isThirdMenuActive = false;
  isFourthMenuActive = false;
  isFivthMenuActive = false;

  firstMenuLinks = [{ link: 'Обзор', func: () => this.shopComp.getShopProductsPCDisplays() },
  { link: 'Обновления', func: () => this.shopComp.getShopProductsPCDisplays() },
  { link: 'Отчеты', func: () => this.shopComp.getShopProductsPCDisplays() }];

  secondMenuLinks = [{ link: 'Смартфоны', func: () => this.shopComp.getShopProductsSmartphones() },
  { link: 'Телевизоры', func: () => this.shopComp.getShopProductsTV() },
  { link: 'Наушники', func: () => this.shopComp.getShopProductsHeadphones() },
  { link: 'Батарейки и аккум.', func: () => this.shopComp.getShopProductsBatteriesAndAccums() }];

  thirdMenuLinks = [{ link: 'Посудомоечные машины', func: () => this.shopComp.getShopProductsDishWashers() },
  { link: 'Микроволновки', func: () => this.shopComp.getShopProductsMicrowaves() },
  { link: 'Холодильники', func: () => this.shopComp.getShopProductsFreezers() },
  { link: 'Пылесосы', func: () => this.shopComp.getShopProductsVacuumCleaners() },
  { link: 'Стиральные машины', func: () => this.shopComp.getShopProductsWashers() }];

  fourthMenuLinks = [{ link: 'Мебель для спальни', func: () => this.shopComp.getShopProductsBedroom() },
  { link: 'Мебель для коридора', func: () => this.shopComp.getShopProductsHallway() },
  { link: 'Мебель для кухни', func: () => this.shopComp.getShopProductsKitchen() },
  { link: 'Мебель для офиса', func: () => this.shopComp.getShopProductsOffice() }];

  fivthMenuLinks = [{ link: 'Мужская одежда', func: () => this.shopComp.getShopProductsMenClothes() },
  { link: 'Женская одежда', func: () => this.shopComp.getShopProductsWomenClothes() },
  { link: 'Мужские аксессуары', func: () => this.shopComp.getShopProductsMenAccessories() },
  { link: 'Женские аксессуары', func: () => this.shopComp.getShopProductsWomenAccessories() },
  { link: 'Мужская обувь', func: () => this.shopComp.getShopProductsMenShoes() },
  { link: 'Женская обувь', func: () => this.shopComp.getShopProductsWomenShoes() }];



  isFirstMenuFirstSubcategoryActive = false;
  isFirstMenuFirstSubcategoryActive2 = false;
  isFirstMenuFirstSubcategoryActive3 = false;

  firstSubmenuLinks = [{ link: 'Процессоры', func: () => this.shopComp.getShopProductsCPU() },
  { link: 'Видеокарты', func: () => this.shopComp.getShopProductsGPU() },
  { link: 'Жесткие диски', func: () => this.shopComp.getShopProductsHDD() },
  { link: 'Материнские платы', func: () => this.shopComp.getShopProductsMotherboards() },
  { link: 'Оперативная память', func: () => this.shopComp.getShopProductsRAM() },
  { link: 'Твердотельные накопители', func: () => this.shopComp.getShopProductsSSD() }]

  secondSubmenuLinks = [{ link: 'Клавиатуры', func: () => this.shopComp.getShopProductsKeyboards() },
  { link: 'Мыши', func: () => this.shopComp.getShopProductsMice() },
  { link: 'Веб-камеры', func: () => this.shopComp.getShopProductsWebCams() }]

  thirdSubmenuLinks = [{ link: 'Эл. книги', func: () => this.shopComp.getShopProductsEbooks() },
  { link: 'Ноутбуки', func: () => this.shopComp.getShopProductsLaptops() },
  { link: 'Планшеты', func: () => this.shopComp.getShopProductsTablets() }]

  displayLinks = { link: 'Мониторы', func: () => this.shopComp.getShopProductsPCDisplays() }


  constructor(private shopComp: ShopComponent) { }

  toggleFirstMenuFirstSubcategory() {
    this.isFirstMenuFirstSubcategoryActive = !this.isFirstMenuFirstSubcategoryActive;
  }

  toggleFirstMenuSecondSubcategory() {
    this.isFirstMenuFirstSubcategoryActive2 = !this.isFirstMenuFirstSubcategoryActive2;
  }

  toggleFirstMenuThirdSubcategory() {
    this.isFirstMenuFirstSubcategoryActive3 = !this.isFirstMenuFirstSubcategoryActive3;
  }

  toggleFirstMenu() {
    this.isFirstMenuActive = !this.isFirstMenuActive;
  }

  toggleSecondMenu() {
    this.isSecondMenuActive = !this.isSecondMenuActive;
  }

  toggleThirdMenu() {
    this.isThirdMenuActive = !this.isThirdMenuActive;
  }

  toggleFourthMenu() {
    this.isFourthMenuActive = !this.isFourthMenuActive;
  }

  toggleFivthMenu() {
    this.isFivthMenuActive = !this.isFivthMenuActive;
  }

  handleLinkClick(func: () => void) {
    this.shopComp.shopParams.pageNumber = 1;
    func();
  }
}
