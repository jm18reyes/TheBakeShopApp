import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { ICart } from '../cart/cart';
import { ShowContactModalService } from '../contact/show-contact-modal.service';
import { SearchItemService } from '../search-item.service';
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
  searchSub!:Subscription;
  filteredCakes: IProduct[] = [];



  constructor(public generateModal: ShowProductModalService, 
      private productService: ProductsService,
      private searchItemService: SearchItemService) { 
        
      }

  ngOnInit(): void {

    this.sub = this.productService.getCakes().subscribe({
      next: cakes => {
        console.log(cakes);
        this.cakes = cakes;
        this.filteredCakes = this.cakes;
      },
      error: err => this.errorMessage = err
    });

    this.searchSub = this.searchItemService.getSearchedItem().subscribe({
      next: userSearched => {
        if(userSearched == ''){
          this.filteredCakes = this.cakes;
        }else{
          
          this.filteredCakes = this.performFilter(userSearched);
        }

      }
    });

  }

  performFilter(filterBy: string): IProduct[]{
    filterBy = filterBy.toLocaleLowerCase();
    return this.cakes.filter((product: IProduct) => 
        product.productName.toLocaleLowerCase().includes(filterBy));
    
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
