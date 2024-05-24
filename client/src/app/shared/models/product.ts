export interface IProduct {
    id:           number;
    name:         string;
    description:  string;
    price:        number;
    pictureUrl:   string;
    productType:  string;
    productBrand: string;
}

export interface IShopProduct {
    id:           number;
    name:         string;
    description:  string;
    price:        number;
    image:        string;
    shopSubcategoryName: string;
    Brand: string;
    Type: string;
    Display: string;
    Resolution: string;
    Power: string;
    Volume: string;
    Noise: string;
    Spin: string;
    PCPeripheryName: string;
    Linking: string;
    PCAccessoryName: string;
    Value: string;
    Socket: string;
    Cores: string;
    Clock: string;
    RAM_Value: string;
    PCPortableName: string;
    shopSubsubcategoryName: string;
}
