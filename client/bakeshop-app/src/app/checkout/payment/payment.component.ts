import { Component, OnInit } from '@angular/core';
import { render } from 'creditcardpayments/creditCardPayments';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit {

  intervalId: any;
  constructor() {

    this.intervalId = setInterval(() => {
      const elementExists = !!document.getElementById('myPaypalButtons')
      if (elementExists) {
        this.loadPaypalScript();
        render({
          id: "#myPaypalButtons",
          currency: "USD",
          value: "100.00",
          onApprove: (details) => {
            alert("Transaction Successful");
          }
        });
      }
    }, 1000)
    
   }

  public loadPaypalScript() {
    clearInterval(this.intervalId);
  }
  ngOnInit(): void {
  }

}
