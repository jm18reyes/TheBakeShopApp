import { Component, ElementRef, Input, OnInit, Renderer2, ViewChild } from '@angular/core';
import { ShowProductModalService } from 'src/app/show-product-modal.service';
import { IProduct } from '../Iproduct';

@Component({
  selector: 'app-product-modal',
  templateUrl: './product-modal.component.html',
  styleUrls: ['./product-modal.component.css']
})
export class ProductModalComponent implements OnInit {

  tempCakeQuantity: number = 1;

  @ViewChild('modal') modalElement!: ElementRef;



  @Input() currentCake!: IProduct;
  constructor(public generateModal: ShowProductModalService) { }

  ngOnInit(): void {
    
  }

  closeModal(){
    this.generateModal.showModal = false;
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
