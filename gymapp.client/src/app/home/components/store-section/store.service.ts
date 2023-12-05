import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

export interface Product {
    id: number,
    title: string,
    price: string,
    category: string,
    description: string,
    image: string
}

@Injectable()
export class StoreService {
    constructor(private http: HttpClient) {}

    public getProducts() {
        return this.http.get<Product[]>("/api/store/getProducts");
    }
}

