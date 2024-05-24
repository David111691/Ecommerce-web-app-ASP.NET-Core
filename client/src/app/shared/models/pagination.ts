import { IProduct } from './product';
import { IShopProduct } from './product';

export interface IPagination {
    pageIndex: number;
    pageSize:  number;
    count:     number;
    data:      IProduct[];
}

export interface IShopPagination {
    pageIndex: number;
    pageSize:  number;
    count:     number;
    data:      IShopProduct[];
}