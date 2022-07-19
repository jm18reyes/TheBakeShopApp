import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { IProduct } from '../products/Iproduct';
import { ICart } from './cart';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  grandTotal:number = 0;
  cartItemList: any[] = [];
  cartItem!: ICart;
  productList = new BehaviorSubject<any>([]);
  finalTotal = new BehaviorSubject<any>([]);
  constructor() { }

  getProducts(){
    return this.productList.asObservable();
  }

  getGrandTotal(){
    return this.finalTotal.asObservable();
  }
 
  setProduct(product: any){
    
    this.cartItemList.push(...product);
    this.productList.next(product);
  }

 
  
  addToCart(product: any){
    this.cartItemList.push(product);

    

    this.productList.next(this.cartItemList);
    this.computeGrandTotal();
    
    console.log(this.cartItemList);

    
  }

  computeGrandTotal(){

    this.grandTotal = 0;
    this.cartItemList.forEach((item)=>{
      this.grandTotal += (item.productBasePrice* item.productQuantity);
    });

    this.finalTotal.next(this.grandTotal);
  }
  
    

  removeCartItem(product: any){
    this.cartItemList.map((a:any, index:any) =>{
      if(product.productName=== a.productName){
        this.cartItemList.splice(index, 1);
      }
    });

    
    this.productList.next(this.cartItemList);

    this.computeGrandTotal();
  }

  removeAllCart(){
    this.cartItemList= [];
    this.productList.next(this.cartItemList);
  }
}
