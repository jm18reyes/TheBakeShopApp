import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { ICart } from '../cart/cart';
import { ShowContactModalService } from '../contact/show-contact-modal.service';
import { ShowProductModalService } from '../show-product-modal.service';
import { IProduct } from './Iproduct';
import { ProductsService } from './products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit, OnDestroy {
  selectedCakey!: IProduct;
  selectedProductIndex: number = 0;
  selectedCake!: IProduct;
  tempCakeQuantity: number = 1;

  cakes: IProduct[] = [];
  errorMessage: string = '';

  cartItems: ICart[] = [];
  cartItem = {} as ICart;

  sub!:Subscription;
  constructor(public generateModal: ShowProductModalService, 
      private productService: ProductsService) { 
        
      }

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
