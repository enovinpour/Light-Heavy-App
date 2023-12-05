import { Component, OnInit } from '@angular/core';
import { Product, StoreService } from './store.service';

@Component({
  selector: 'app-store-section',
  templateUrl: './store-section.component.html',
  styleUrls: ['./store-section.component.css'],
  providers: [StoreService]
})
export class StoreSectionComponent implements OnInit {
  products!: Product[];

  constructor(private storeService: StoreService) { }

  ngOnInit(): void {
    this.storeService
      .getProducts()
      .subscribe(result => {
        this.products = result;
      });
  }

}
