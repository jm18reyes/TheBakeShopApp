import { Component, ElementRef, Input, OnInit, Renderer2, ViewChild } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ICart } from 'src/app/cart/cart';
import { CartService } from 'src/app/cart/cart.service';
import { ShowProductModalService } from 'src/app/show-product-modal.service';
import { IProduct } from '../Iproduct';

@Component({
  selector: 'app-product-modal',
  templateUrl: './product-modal.component.html',
  styleUrls: ['./product-modal.component.css']
})
export class ProductModalComponent implements OnInit {
  tempCakeQuantity: number = 1;
  isAdded: boolean = false;
  @ViewChild('modal') modalElement!: ElementRef;

  cartItem!: ICart;

  @Input() currentCake!: IProduct;
  constructor(public generateModal: ShowProductModalService,
    private cartService: CartService,
    private toastr: ToastrService) { 
      
    }

  ngOnInit(): void {
    
  }

  closeModal(){
    this.isAdded = false;
    this.generateModal.showModal = false;
  }

  addToCart(){
    this.cartItem = {
      'id': '00-00',
      'productId':this.currentCake.id,
      'productName':this.currentCake.productName,
      'productBasePrice': this.currentCake.productPrice,
      'productQuantity': this.tempCakeQuantity,
      'imageUrl': this.currentCake.imageUrl
    }
    this.cartService.addToCart(this.cartItem);

    this.isAdded = true;
    //this.toastr.success('Successfully Added to cart!', `${this.cartItem.productName}`);

  }


  
  ngAfterViewInit(){
    console.log('iz true');
    if(this.generateModal.showModal == true){
      console.log('iz true');
      
    }
  }

  typedQuantity(input: any):void{
    this.tempCakeQuantity = Number(input);
  }

  addQuantity():void{
    this.tempCakeQuantity++;
  }

  minusQuantity():void{
    if(this.tempCakeQuantity > 1){
      console.log(this.tempCakeQuantity)
      this.tempCakeQuantity--;
    }
    else{
      this.tempCakeQuantity = 1;
    }
  }
  

}
