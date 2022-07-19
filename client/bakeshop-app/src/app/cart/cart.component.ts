import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ICart } from './cart';
import { CartService } from './cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit, OnDestroy {
  grandTotal: number = 0;
  cartSubscribe!:any;
  cartTotalSubscribe!:any;
  cartItems: ICart[] = [];
  constructor(private cartService: CartService, private router: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.cartSubscribe = this.cartService.getProducts().subscribe(items =>{
      this.cartItems = items;
      
    });

    this.cartTotalSubscribe = this.cartService.getGrandTotal().subscribe(price =>{
      this.grandTotal = price;
    });
    

    
    console.log(this.cartItems);
  }

  removeItem(index: number){
    this.cartService.removeCartItem(this.cartItems[index]);

    

    console.log('----');
    console.log(this.cartItems);
    console.log('----');
    
    this.cartItems.forEach((item) =>{
      console.log(item);
    })

    
    
  }

  ngOnDestroy(): void {
    this.cartSubscribe.unsubscribe();
  }
}
