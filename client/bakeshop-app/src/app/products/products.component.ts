import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { ShowProductModalService } from '../show-product-modal.service';
import { IProduct } from './Iproduct';
import { ProductsService } from './products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit, OnDestroy {

  selectedProductIndex: number = 0;
  selectedCake!: IProduct;
  /*
  cakes: IProduct[] = [
    {
      "id": "1",
      "productName": "Coffee Cake",
      "productDescription": "A coffee-flavored cake is typically baked in a circular shape with two layers separated by coffee butter icing, which may also cover the top of the cake",
      "productPrice": 721.00,
      "imageUrl": "assets/coffee-cake.jpg"
  },
  {
      "id": "2",
      "productName": "Banana Cake",
      "productDescription": "A traditional banana cake is made like a butter cake with the addition of mashed banana for flavour.",
      "productPrice": 700.00,
      "imageUrl": "assets/banana-cake.jpeg"
  },
  {
      "id": "3",
      "productName": "Funfetti Cake",
      "productDescription": "Cake that has rainbow colored sprinkles baked into the batter.",
      "productPrice": 714.00,
      "imageUrl": "assets/funfetti-cake.jpg"
  },
  {
      "id": "4",
      "productName": "Lemon Cake",
      "productDescription": "The 'lemony' flavour in a lemon cake is from the volatile oils which are present in the fruit's zest,(mainly nerol, limonene and citral).",
      "productPrice": 600.00,
      "imageUrl": "assets/lemon-cake.jpg"
  },
  {
      "id": "5",
      "productName": "Black Forest Cake",
      "productDescription": "Black Forest gateau consists of several layers of chocolate sponge cake sandwiched with whipped cream and cherries.",
      "productPrice": 805.00,
      "imageUrl": "assets/black-forest-cake.jpg"
  },
  {
      "id": "6",
      "productName": "Cheesecake",
      "productDescription": "The main, and thickest, layer consists of a mixture of a soft, fresh cheese, eggs, and sugar.",
      "productPrice": 781.00,
      "imageUrl": "assets/cheese-cake.jpg"
  }
  ];
  */

  cakes: IProduct[] = [];
  errorMessage: string = '';

  sub!:Subscription;
  constructor(public generateModal: ShowProductModalService, 
      private productService: ProductsService) { }

  ngOnInit(): void {

    this.sub = this.productService.getCakes().subscribe({
      next: cakes => {
        console.log(cakes);
        this.cakes = cakes;
      },
      error: err => this.errorMessage = err
    });
  }

  openModal(index: number): void{
    this.selectedProductIndex = index;
    this.selectedCake = this.cakes[this.selectedProductIndex];
    
    this.generateModal.showModal=true;
    console.log('clicked');
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

}
