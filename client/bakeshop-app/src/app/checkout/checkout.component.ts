import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { PaymentSuccessService } from '../payment-success.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {
  validAddressSub!: Subscription;
  validAddress: boolean = false;
  constructor(private paymentService: PaymentSuccessService ) { }

  ngOnInit(): void {

    this.validAddressSub = this.paymentService.getAddressConfirmation().subscribe(confirm =>{
      this.validAddress = confirm;
      
    });
  }

  proceedToPayment(signal:any){
    this.validAddress = signal;

  }
}
