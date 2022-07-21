import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PaymentSuccessService } from 'src/app/payment-success.service';

@Component({
  selector: 'app-shipping-info',
  templateUrl: './shipping-info.component.html',
  styleUrls: ['./shipping-info.component.css']
})
export class ShippingInfoComponent implements OnInit {
  fname: string = '';
  lname: string = '';
  email: string = '';
  addressA: string = '';
  addressB: string = '';
  isAddressValid: boolean = false;
  constructor(private paymentService: PaymentSuccessService) { }

  ngOnInit(): void {
    this.paymentService.addressConfirmed(this.isAddressValid);
  }

  onSubmit(){
    this.isAddressValid = true;
    this.paymentService.addressConfirmed(this.isAddressValid);
  }
}
