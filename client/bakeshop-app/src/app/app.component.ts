import { Component } from '@angular/core';
import { PaymentSuccessService } from './payment-success.service';
import { ShowProductModalService } from './show-product-modal.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'bakeshop-app';

  constructor(public generateModal: ShowProductModalService,
    private paymentService: PaymentSuccessService){
      this.paymentService.addressConfirmed(false);
    }
}
